Public Class PicViewer

	Private Sub PicViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		picScreenShot.Width = Me.Width
		picScreenShot.Height = Me.Height
	End Sub

	Private Sub PicViewer_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
		picScreenShot.Width = Me.Width
		picScreenShot.Height = Me.Height
	End Sub

	Private Sub PicViewer_MinimumSizeChanged(sender As Object, e As EventArgs) Handles Me.MinimumSizeChanged
		picScreenShot.Width = Me.Width
		picScreenShot.Height = Me.Height
	End Sub

	Private Sub PicViewer_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
		picScreenShot.Width = Me.Width
		picScreenShot.Height = Me.Height
	End Sub
End Class