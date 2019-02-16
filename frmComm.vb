Option Strict Off
Option Explicit On

Imports System.Threading

Friend Class frmComm
  Inherits System.Windows.Forms.Form


  Private Sub frmComm_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim Cancel As Boolean = eventArgs.Cancel
    Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
    If UnloadMode = System.Windows.Forms.CloseReason.UserClosing Then
      Cancel = True
      Me.Hide()
    Else
      Cancel = False
    End If
    eventArgs.Cancel = Cancel
  End Sub

  Private Sub cmdEnter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEnter.Click
    Comm.SendDataToRobot(txtSendCommand.Text & vbCr)
  End Sub

  Private Sub lstInputBuffer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstInputBuffer.DoubleClick
    lstInputBuffer.Items.Clear()
    lstOutputBuffer.Items.Clear()
  End Sub

  Private Sub lstBuffer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    lstInputBuffer.SelectedIndexChanged, _
    lstOutputBuffer.SelectedIndexChanged
    'This keeps the two list boxes from having greater than 50 values
    Dim CurrentListBox As Windows.Forms.ListBox
    CurrentListBox = DirectCast(sender, Windows.Forms.ListBox)
    If CurrentListBox.Items.Count > 50 Then
      For Count As Integer = CurrentListBox.Items.Count - 1 To 49 Step -1
        CurrentListBox.Items.RemoveAt(49)
      Next Count
    End If
  End Sub

End Class


