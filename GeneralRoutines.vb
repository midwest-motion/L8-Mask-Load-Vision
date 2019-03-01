Option Strict Off
Option Explicit On
Module GeneralRoutines
  Public WithEvents tmrDelay As New Timer

  Public Sub DelayTimer(ByRef TimeInterval As Integer)
    Try
      tmrDelay.Interval = TimeInterval
      tmrDelay.Enabled = True
      Do
        System.Windows.Forms.Application.DoEvents()
      Loop While tmrDelay.Enabled
    Catch ex As Exception
      frmMain.ShowVBErrors("DelayTimer", ex.Message)
    End Try
  End Sub

  Private Sub tmrDelayEvent(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
    Try
      tmrDelay.Enabled = False
    Catch ex As Exception
      frmMain.ShowVBErrors("tmrDelayEvent", ex.Message)
    End Try
  End Sub

End Module
