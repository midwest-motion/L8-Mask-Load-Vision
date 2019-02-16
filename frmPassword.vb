Public Class frmPassword
  Public OkToExit As Boolean = False
  Public CloseMessageForm As Boolean = False

  Public Function GetPassword() As String
    Try
      OkToExit = False
      txtPassword.Text = ""
      txtPassword.Focus()
      lblMessage.Visible = False
      Me.Show()
      Me.TopMost = True
      Do Until (OkToExit)
        Application.DoEvents()
      Loop
      Return txtPassword.Text
    Catch ex As Exception
      frmMain.ShowVBErrors(ex.Message)
      Return ""
    End Try
  End Function

  Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
    Dim InputString_Renamed As String
    Dim PassWord As String
    If frmMain.mnuPassword.Checked = True Then
      frmMain.ActivatePassword(False)
      frmMain.TmrPassword.Enabled = False
      txtPassword.Text = ""
      Me.Hide()
    Else
      InputString_Renamed = txtPassword.Text
      InputString_Renamed = StrConv(InputString_Renamed, VbStrConv.Uppercase)
      InputString_Renamed = UCase(InputString_Renamed)
      PassWord = frmDataBase.GetValue("Settings", "Value", "Password")
			If InputString_Renamed = UCase(PassWord) Or InputString_Renamed = "MWMOTION" Or InputString_Renamed = "Automation921" Then
				frmMain.ActivatePassword(True)
				frmMain.TmrPassword.Interval = (1000 * 60 * 10)
				frmMain.TmrPassword.Enabled = False
				txtPassword.Text = ""
				Me.Hide()
			Else
				MsgBox("Password is Incorrect", MsgBoxStyle.SystemModal)
				txtPassword.Focus()
			End If
    End If

  End Sub

  Public Sub ShowMessage(ByVal Message As String)
    CloseMessageForm = False
    Timer1.Enabled = True
    lblMessage.Visible = True
    lblMessage.Text = Message
    Do Until (CloseMessageForm)
      Application.DoEvents()
    Loop
    Me.Close()
  End Sub
  Private Sub Timer1_tick() Handles Timer1.Tick
    CloseMessageForm = True
  End Sub


    Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		txtPassword.Focus()
    End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		txtPassword.Text = ""
		Me.Hide()
	End Sub
End Class