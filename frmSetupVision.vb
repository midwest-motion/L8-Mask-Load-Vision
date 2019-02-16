Option Strict Off
Option Explicit On
Friend Class frmSetupVision
	Inherits System.Windows.Forms.Form
	
  Private Sub btnSaveHexsight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSaveHexsight.Click
    frmMain.SaveHexsight()
  End Sub
	
	Private Sub frmSetupVision_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		If UnloadMode <> 0 Then
			Cancel = False
		Else
			Cancel = True
		End If
		Me.Hide()
    eventArgs.Cancel = True 'Cancel
	End Sub
End Class