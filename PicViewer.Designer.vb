<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PicViewer
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.picScreenShot = New System.Windows.Forms.PictureBox()
		CType(Me.picScreenShot, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picScreenShot
		'
		Me.picScreenShot.Location = New System.Drawing.Point(1, 12)
		Me.picScreenShot.Name = "picScreenShot"
		Me.picScreenShot.Size = New System.Drawing.Size(1845, 999)
		Me.picScreenShot.TabIndex = 0
		Me.picScreenShot.TabStop = False
		'
		'PicViewer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(737, 468)
		Me.Controls.Add(Me.picScreenShot)
		Me.Name = "PicViewer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "ScreenShot"
		CType(Me.picScreenShot, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents picScreenShot As System.Windows.Forms.PictureBox
End Class
