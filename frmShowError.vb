Public Class frmShowError
    Private Sub btnErrorOK_Click(sender As Object, e As EventArgs) Handles btnErrorOK.Click
    If frmMain.helperSouth.isOnline And frmMain.helperNorth.isOnline = True Then
      Me.Hide()
    End If
  End Sub
End Class