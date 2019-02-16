Public Class PartList

  Public Shared Sub GetFileList()
    Dim Count As Int32
    Dim Parts() As String = Nothing
    On Error Resume Next
    '
    'Initialize New Menus
    '
    frmMain.loadABC.Text = "A, B, C"
    frmMain.loadDEF.Text = "D, E, F"
    frmMain.loadGHI.Text = "G, H, I"
    frmMain.loadJKL.Text = "J, K, L"
    frmMain.loadMNO.Text = "M, N, O"
    frmMain.loadPQR.Text = "P, Q, R"
    frmMain.loadSTU.Text = "S, T, U"
    frmMain.loadVWX.Text = "V, W, X"
    frmMain.loadYZ.Text = "Y, Z"
		frmMain.loadOther.Text = "Other"
		frmMain.deleteABC.Text = "A, B, C"
    frmMain.deleteDEF.Text = "D, E, F"
    frmMain.deleteGHI.Text = "G, H, I"
    frmMain.deleteJKL.Text = "J, K, L"
    frmMain.deleteMNO.Text = "M, N, O"
    frmMain.deletePQR.Text = "P, Q, R"
    frmMain.deleteSTU.Text = "S, T, U"
    frmMain.deleteVWX.Text = "V, W, X"
    frmMain.deleteYZ.Text = "Y, Z"
		frmMain.deleteOther.Text = "Other"
		'
    'create the menu arrays and caption them
    GetPartDirectories(PartsPath, Parts)
    '
    'Clear out the existing menus
    frmMain.mnuLoadPart.DropDownItems.Clear()
    frmMain.mnuDeletePart.DropDownItems.Clear()
    frmMain.loadABC.DropDownItems.Clear()
    frmMain.loadDEF.DropDownItems.Clear()
    frmMain.loadGHI.DropDownItems.Clear()
    frmMain.loadJKL.DropDownItems.Clear()
    frmMain.loadMNO.DropDownItems.Clear()
    frmMain.loadPQR.DropDownItems.Clear()
    frmMain.loadSTU.DropDownItems.Clear()
    frmMain.loadVWX.DropDownItems.Clear()
		frmMain.loadYZ.DropDownItems.Clear()
		frmMain.loadOther.DropDownItems.Clear()
		frmMain.deleteABC.DropDownItems.Clear()
    frmMain.deleteDEF.DropDownItems.Clear()
    frmMain.deleteGHI.DropDownItems.Clear()
    frmMain.deleteJKL.DropDownItems.Clear()
    frmMain.deleteMNO.DropDownItems.Clear()
    frmMain.deletePQR.DropDownItems.Clear()
    frmMain.deleteSTU.DropDownItems.Clear()
    frmMain.deleteVWX.DropDownItems.Clear()
    frmMain.deleteYZ.DropDownItems.Clear()
		frmMain.deleteOther.DropDownItems.Clear()

		'
    'Populate the new menus
    For Count = 0 To Parts.Length - 1
      Dim SingleChar As String = ""
      SingleChar = UCase(Mid(Parts(Count), 1, 1))
      Select Case SingleChar
        Case "A", "B", "C"
          frmMain.loadABC.DropDownItems.Add(Parts(Count))
          frmMain.deleteABC.DropDownItems.Add(Parts(Count))
        Case "D", "E", "F"
          frmMain.loadDEF.DropDownItems.Add(Parts(Count))
          frmMain.deleteDEF.DropDownItems.Add(Parts(Count))
        Case "G", "H", "I"
          frmMain.loadGHI.DropDownItems.Add(Parts(Count))
          frmMain.deleteGHI.DropDownItems.Add(Parts(Count))
        Case "J", "K", "L"
          frmMain.loadJKL.DropDownItems.Add(Parts(Count))
          frmMain.deleteJKL.DropDownItems.Add(Parts(Count))
        Case "M", "N", "O"
          frmMain.loadMNO.DropDownItems.Add(Parts(Count))
          frmMain.deleteMNO.DropDownItems.Add(Parts(Count))
        Case "P", "Q", "R"
          frmMain.loadPQR.DropDownItems.Add(Parts(Count))
          frmMain.deletePQR.DropDownItems.Add(Parts(Count))
        Case "S", "T", "U"
          frmMain.loadSTU.DropDownItems.Add(Parts(Count))
          frmMain.deleteSTU.DropDownItems.Add(Parts(Count))
        Case "V", "W", "X"
          frmMain.loadVWX.DropDownItems.Add(Parts(Count))
          frmMain.deleteVWX.DropDownItems.Add(Parts(Count))
        Case "Y", "Z"
          frmMain.loadYZ.DropDownItems.Add(Parts(Count))
          frmMain.deleteYZ.DropDownItems.Add(Parts(Count))
        Case Else
          frmMain.loadOther.DropDownItems.Add(Parts(Count))
          frmMain.deleteOther.DropDownItems.Add(Parts(Count))
      End Select
      '
      'Add the new menus to the Load Menu
      With frmMain.mnuLoadPart.DropDownItems
        .Add(frmMain.loadABC)
        .Add(frmMain.loadDEF)
        .Add(frmMain.loadGHI)
        .Add(frmMain.loadJKL)
        .Add(frmMain.loadMNO)
        .Add(frmMain.loadPQR)
        .Add(frmMain.loadSTU)
        .Add(frmMain.loadVWX)
        .Add(frmMain.loadYZ)
        .Add(frmMain.loadOther)
      End With
      '
      'Add the new menus to the Delete Menu
      With frmMain.mnuDeletePart.DropDownItems
        .Add(frmMain.deleteABC)
        .Add(frmMain.deleteDEF)
        .Add(frmMain.deleteGHI)
        .Add(frmMain.deleteJKL)
        .Add(frmMain.deleteMNO)
        .Add(frmMain.deletePQR)
        .Add(frmMain.deleteSTU)
        .Add(frmMain.deleteVWX)
        .Add(frmMain.deleteYZ)
        .Add(frmMain.deleteOther)
      End With
    Next Count
  End Sub

  Public Shared Sub GetPartDirectories(ByVal SearchPath As String, ByRef Parts() As String)
    Dim Count As Int32
    '
    'Create the parts directory listbox
    Dim Dir As New System.IO.DirectoryInfo(SearchPath)
    Dim DirArray As System.IO.DirectoryInfo()
    Try
      DirArray = Dir.GetDirectories
      ReDim Parts(DirArray.Length - 1)
      For Count = 0 To DirArray.Length - 1
        Parts(Count) = DirArray(Count).Name
      Next Count
      'Sort the list
      Array.Sort(Parts)
    Catch ex As Exception
      MsgBox("GetPartDirectories" & "Couldn't read the part directory list")
    End Try
  End Sub

  Public Shared Sub GetFileNames(ByVal SearchPath As String, ByRef Parts() As String)
    Dim Count As Int32
    '
    'Create the file list
    Dim Dir As New System.IO.DirectoryInfo(SearchPath)
    Dim FileArray As System.IO.FileInfo()
    Try
      FileArray = Dir.GetFiles
      ReDim Parts(FileArray.Length - 1)
      For Count = 0 To FileArray.Length - 1
        Parts(Count) = FileArray(Count).Name
      Next(Count)
      'Sort the list
      Array.Sort(Parts)
    Catch ex As Exception
      frmMain.ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Shared Function CheckforFile(ByRef FileName As String) As Boolean
    GetFileList()
    Dim FSO As Scripting.FileSystemObject
    FSO = New Scripting.FileSystemObject
    Dim PathAndFile As String
    PathAndFile = PartsPath & FileName
    CheckforFile = FSO.FolderExists(PathAndFile)
  End Function

End Class
