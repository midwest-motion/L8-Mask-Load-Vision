Option Strict Off
Option Explicit On

Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe

Friend Class frmDataBase
  Inherits System.Windows.Forms.Form
  Private ds As DataSet = New DataSet
	Private UpdateCount As Int16
	Private newData As SqlCeDataAdapter

  Private Sub frmDataBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    FillTable()
    LayoutTable()
  End Sub

  Private Sub FillTable()
    Dim SqlCeConn As New SqlCeConnection
		SqlCeConn = frmDataBase.GetSqlConnection(TableName, "")
    If TableName <> "Settings" Then
      newData = New SqlCeDataAdapter("Select * From " & TableName & " Order By SortField, VariableName", SqlCeConn)
    Else
      newData = New SqlCeDataAdapter("Select * From " & TableName, SqlCeConn)
    End If
    newData.Fill(ds, TableName)
    dgrSettings.DataMember = TableName
    dgrSettings.DataSource = ds
    SqlCeConn.Close()
  End Sub

  Private Sub LayoutTable()
    'Updates the location and size of all the objects on the screen to
    'make a nice database display
    On Error Resume Next
    '
    '
    With dgrSettings
      'forbid access to these columns
      .Columns("Group").ReadOnly = False 'frmMain.PasswordValue
      .Columns("VariableName").ReadOnly = False 'frmMain.PasswordValue
      .Columns("Description").ReadOnly = False
      .Columns("Value").ReadOnly = False
      .Columns("SortField").ReadOnly = False
      'Set the location of the DBGrid
			'.Top = 5
      .Left = 5
      'Set the height of the DBGrid
      If TableName = "Settings" Then
        Me.Height = .Height + 50
        Me.Text = "General Program Settings"
      Else
        Me.Text = "Part File Settings"
      End If
      'Set the location of the form
      Me.Top = 0
      Me.Left = 350
    End With
  End Sub

  Private Sub frmDataBase_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim Cancel As Boolean = eventArgs.Cancel
    Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
    Dim btnBuilder As New SqlCeCommandBuilder(newData)
    Dim i As Integer
    Try
      If Me.Text = "General Program Settings" Then
        i = newData.Update(ds, "Settings")
      Else
        i = newData.Update(ds, TableName)
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
    eventArgs.Cancel = Cancel
  End Sub

  Public Function GetValue(ByVal TableName As String, ByVal SearchColumn As String, ByVal VariableName As String) As String
    Dim SqlCeConn As SqlCeConnection = Nothing
    Dim DatabaseValue As String = ""
    Dim ErrorString As String = ""
    Try
			SqlCeConn = GetSqlConnection(TableName, VariableName)
      Dim btn As New SqlCeCommand("SELECT " & SearchColumn & " FROM " & TableName & " WHERE VariableName = '" & VariableName & "'", SqlCeConn)
      DatabaseValue = btn.ExecuteScalar.ToString() '.ToString
      Return DatabaseValue
      'SqlCeConn.Dispose()
    Catch ex As Exception
      Try
        SqlCeConn.Close()
        'SqlCeConn.Dispose()
      Catch
      End Try
      ErrorString = "Unable to read from the database '" & TableName & "' the value for the item '" & VariableName & "'"
      frmMain.ShowVBErrors("GetValue", ex.Message)
      Return DatabaseValue
    End Try
  End Function

  Public Sub SetValue(ByRef Tablename As String, ByRef SearchColumn As String, ByRef VariableName As String, ByRef Value As String)
    Dim SqlCeConn As SqlCeConnection = Nothing
    Dim dummy As String
    Dim ErrorString As String = ""
    Try
			SqlCeConn = GetSqlConnection(Tablename, VariableName)
      Dim sqlUpdate As New SqlCeCommand("UPDATE " & Tablename & " SET " & SearchColumn & " = '" & Value & "' WHERE VariableName = '" & VariableName & "' ", SqlCeConn)
      dummy = sqlUpdate.CommandText
      sqlUpdate.ExecuteNonQuery()
      SqlCeConn.Close()
      'SqlCeConn.Dispose()
    Catch ex As Exception
      Try
        SqlCeConn.Close()
        'SqlCeConn.Dispose()
      Catch
      End Try
      ErrorString = "Unable to write to the database '" & Tablename & "' the value for the item '" & VariableName & "'"
      frmMain.ShowVBErrors("SetValue", ex.Message)
    End Try
  End Sub

	Public Shared Function GetSqlConnection(ByVal TableName As String, ByVal VariableName As String) As SqlCeConnection
		Try
			Dim sqlConn As New SqlCeConnection
			If TableName = "Settings" Then
				sqlConn.ConnectionString = ("Data Source=" & ConfigPath & "Settings.sdf" & "; Persist Security Info=False;")
			Else
				sqlConn.ConnectionString = ("Data Source=" & PartsPath & PartName & "\Partdata.sdf" & "; Persist Security Info=False;")
			End If
			sqlConn.Open()
			Return sqlConn
		Catch ex As Exception
			MsgBox(ex.Message & "  " & VariableName)
			Return Nothing
		End Try
	End Function

  Public Sub InsertRow(ByVal VariableName As String, ByVal Description As String, ByVal Value As String, ByVal SortField As String)
		Dim SqlCeConn As SqlCeConnection = Nothing
		Dim CommandString As String = ""
		Dim Data As String = ""
		Dim RowsAffected As Integer
		TableName = "Partdata"
		'
		'Build the INSERT command
		CommandString = " INSERT INTO Partdata ([VariableName], [Description],[Value],[SortField])" _
		& " VALUES ('" & VariableName & "', '" & Description & "', '" & Value & "', '" & SortField & "')"
		'
		'Connect and Create the command

		'
		'Execute the command and close the connection
		Try
			SqlCeConn = GetSqlConnection(TableName, VariableName)
			Dim cmd As New SqlCeCommand(CommandString, SqlCeConn)
			RowsAffected = cmd.ExecuteNonQuery()
			UpdateCount = UpdateCount + 1
		Catch ex As Exception
			If ex.Message.Contains("A duplicate value cannot be inserted into a unique index.") Then
			Else
				MsgBox("Unable to write to the database '" & SqlCeConn.ConnectionString & vbCr & _
				CommandString & vbCr, MsgBoxStyle.Critical, "Database Error")
			End If
		End Try
    Try
      SqlCeConn.Close()
    Catch ex As Exception
      frmMain.ShowVBErrors("InsertRow", ex.Message)
    End Try
	End Sub

	Public Sub DeleteRow(ByVal VariableName As String)
		Dim SqlCeConn As SqlCeConnection = Nothing
		Dim CommandString As String = ""
		Dim Data As String = ""
		Dim RowsAffected As Int16
		TableName = "Partdata"
		'
		'Build the INSERT command
		CommandString = "DELETE FROM Partdata WHERE VariableName = '" & VariableName & "'"
		'
		'Connect and Create the command
		SqlCeConn = GetSqlConnection(TableName, VariableName)
		Dim cmd As New SqlCeCommand(CommandString, SqlCeConn)
		'
		'Execute the command and close the connection
		Try
			RowsAffected = cmd.ExecuteNonQuery()
			If RowsAffected > 0 Then UpdateCount = UpdateCount + 1
		Catch ex As Exception
      frmMain.ShowVBErrors("DeleteRow", ex.Message)
    End Try
    Try
      SqlCeConn.Close()
    Catch ex As Exception
      frmMain.ShowVBErrors("DeleteRow", ex.Message)
    End Try
	End Sub

	Public Sub UpdateAllParts()
		Dim Count As Int32
		Dim Parts() As String = Nothing
		PartList.GetPartDirectories(PartsPath, Parts)
		'
		'cycle through all of the parts
		For Count = 0 To Parts.Length - 1
			PartName = Parts(Count)
			frmMain.lblPartTitle.Text = "'" & PartName & "'"
			'	If InSplash Then frmSplash.lblMessageBar.Text = "Updating Database " & frmMain.lblPartTitle.Text
			CurrentFilePath = PartsPath & PartName & "\"
      '
      'SortField data is as follows
      '
      'Delete Items
      'DeleteRow("grpImageDisplay")
      Application.DoEvents()
      '
      'Insert Items
      With frmMain
				InsertRow("NSearchBoxCenterX", "Search Area Corner", 110, "5")
				InsertRow("NSearchBoxCenterY", "Search Area Corner", 362, "5")
				InsertRow("NSearchBoxCenterR", "Search Area Corner", 0, "5")
				InsertRow("NSearchBoxWidth", "Search Area Corner", 383, "5")
				InsertRow("NSearchBoxHeight", "Search Area Corner", 257, "5")
				InsertRow("SSearchBoxCenterX", "Search Area Corner", 1318, "5")
				InsertRow("SSearchBoxCenterY", "Search Area Corner", 346, "5")
				InsertRow("SSearchBoxCenterR", "Search Area Corner", 0, "5")
				InsertRow("SSearchBoxWidth", "Search Area Corner", 539, "5")
				InsertRow("SSearchBoxHeight", "Search Area Corner", 253, "5")
      End With
    Next Count
		'
		'Reload the first part
		frmMain.lblPartTitle.Text = "'" & PartName & "'"
		MsgBox(CStr(UpdateCount) & " Database Items Modified", MsgBoxStyle.SystemModal)
		'If InSplash Then Exit Sub
		'frmMain.LoadPart()
	End Sub

	Private Sub UpdateAllPartFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateAllPartFiles.Click
		UpdateAllParts()
	End Sub

End Class