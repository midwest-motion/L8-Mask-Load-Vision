Option Strict Off
Option Explicit On
Imports vb = Microsoft.VisualBasic

Friend Class frmAlarmMsg
  Inherits System.Windows.Forms.Form
  Private Const BLOWOFF As Short = 10
  Private Const DROPOFF As Short = 11
  Private Const TRYAGAIN As Short = 12
  Public ButtonPress As Short
  Public AlarmType As String

  Private Sub btnBlowoff_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBlowoff.Click
    ButtonPress = BLOWOFF
    Application.DoEvents()
    Me.Hide()
  End Sub

  Private Sub btnDepositPlate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDepositPlate.Click
    ButtonPress = DROPOFF
    Application.DoEvents()
    Me.Hide()
  End Sub

	Private Sub btnTryAgain_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnTryAgain.Click
		ButtonPress = TRYAGAIN
		Application.DoEvents()
		Me.Hide()
	End Sub

  Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
    Application.DoEvents()
    Me.Hide()
  End Sub

  Public Sub ShowAlarms()
    On Error GoTo AlarmError
		btnDepositPlate.Visible = False
		btnBlowoff.Visible = False
		btnTryAgain.Visible = False
		btnOK.Visible = True
		If AlarmType = "Vacuum Detected" Then
			btnDepositPlate.Visible = True
			btnBlowoff.Visible = True
			txtMessage.Text = "The Vacuum Switch RDI[1] was made. The robot detects glass on the tool." _
										 & vbCr & "If you want to release it where the robot is currently setting, click the [Blowoff] button" _
										 & vbCr & "OR you can select to deposit the glass on the shuttle by clicking the [Deposit] button"
		End If

		If AlarmType = "No Vacuum Detected" Then
			btnTryAgain.Visible = False
			txtMessage.Text = "The Vacuum Switch RDI[1] was not made.  Check the vacuum switch. If the robot doesn't have vacuum " _
							 & vbCr & " then lower the height adjustment for the area the robot is currently at by  1mm and " _
							 & vbCr & "try your desired action again."
		End If
    If AlarmType = "Disconnect Tripped too Slowly" Then
      txtMessage.Text = "The Disconnect was tripped too slowly causing a SRVO 272 error." _
               & vbCr & "This robot error must be reset in an unusual way." & vbCr _
               & vbCr & "On the robot Teach Pendant Hit the MENUS button" _
               & vbCr & "Hit item number 4 'Alarms', then Hit the F4 'RES_1CH' button" _
               & vbCr & "Answer Yes when it asks you if you want to do this" & vbCr _
               & vbCr & "Reset any other alarms by hitting the RESET button"
      'txtMessage.DeselectAll()
      txtMessage.Multiline = True
    End If
    Application.DoEvents()
    Exit Sub
AlarmError:
    MsgBox(Err.Description, MsgBoxStyle.SystemModal)
    Resume Next
  End Sub

  Private Sub frmAlarmMsg_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Me.ShowAlarms()
		Me.TopMost = True
    Application.DoEvents()
  End Sub

  'Private Sub frmAlarmMsg_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
  '  Dim Cancel As Boolean = eventArgs.Cancel
  '  Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
  '  If UnloadMode = System.Windows.Forms.CloseReason.UserClosing Then
  '    Cancel = True
  '  Else
  '    Cancel = False
  '  End If
  '  eventArgs.Cancel = Cancel
  'End Sub

	Private Sub tmrZorder_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrZorder.Tick
		Me.BringToFront()
		Me.Focus()
		Me.Select()
		Me.TopLevel = True
		Me.SetTopLevel(True)
		Me.TopMost = True
		Application.DoEvents()
	End Sub

End Class