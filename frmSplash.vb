Option Strict Off
Option Explicit On
Friend Class frmSplash
	Inherits System.Windows.Forms.Form
	
	Private Sub frmSplash_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Me.Close()
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
  Private Sub frmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    System.Diagnostics.Debug.WriteLine(My.Application.Info.Version.Major)
    lblVersion.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
		lblProductName.Text = My.Application.Info.Title
    lblCompany.Text = My.Application.Info.CompanyName
    lblComments.Text = My.Application.Info.Description
    lblLegalCopyright.Text = My.Application.Info.Copyright
    Me.TopMost = True
    Application.DoEvents()
  End Sub

End Class