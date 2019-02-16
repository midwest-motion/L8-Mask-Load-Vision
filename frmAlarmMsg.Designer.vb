<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAlarmMsg
#Region "Windows Form Designer generated code "
  <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
    MyBase.New()
    'This call is required by the Windows Form Designer.
    InitializeComponent()
  End Sub
  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
    If Disposing Then
      If Not components Is Nothing Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(Disposing)
  End Sub
  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer
  Public ToolTip1 As System.Windows.Forms.ToolTip
  Public WithEvents tmrZorder As System.Windows.Forms.Timer
	Public WithEvents tmrCloseForm As System.Windows.Forms.Timer
  Public WithEvents btnDepositPlate As System.Windows.Forms.Button
  Public WithEvents btnBlowoff As System.Windows.Forms.Button
  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlarmMsg))
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.tmrZorder = New System.Windows.Forms.Timer(Me.components)
		Me.tmrCloseForm = New System.Windows.Forms.Timer(Me.components)
		Me.btnDepositPlate = New System.Windows.Forms.Button()
		Me.btnBlowoff = New System.Windows.Forms.Button()
		Me.btnOK = New System.Windows.Forms.Button()
		Me.txtMessage = New System.Windows.Forms.RichTextBox()
		Me.btnTryAgain = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'tmrZorder
		'
		Me.tmrZorder.Enabled = True
		Me.tmrZorder.Interval = 2000
		'
		'tmrCloseForm
		'
		Me.tmrCloseForm.Enabled = True
		'
		'btnDepositPlate
		'
		Me.btnDepositPlate.BackColor = System.Drawing.SystemColors.Control
		Me.btnDepositPlate.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDepositPlate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDepositPlate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDepositPlate.Location = New System.Drawing.Point(607, 54)
		Me.btnDepositPlate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.btnDepositPlate.Name = "btnDepositPlate"
		Me.btnDepositPlate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDepositPlate.Size = New System.Drawing.Size(135, 34)
		Me.btnDepositPlate.TabIndex = 1
		Me.btnDepositPlate.Text = "Deposit Plate"
		Me.btnDepositPlate.UseVisualStyleBackColor = False
		'
		'btnBlowoff
		'
		Me.btnBlowoff.BackColor = System.Drawing.SystemColors.Control
		Me.btnBlowoff.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBlowoff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBlowoff.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBlowoff.Location = New System.Drawing.Point(607, 11)
		Me.btnBlowoff.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.btnBlowoff.Name = "btnBlowoff"
		Me.btnBlowoff.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBlowoff.Size = New System.Drawing.Size(135, 34)
		Me.btnBlowoff.TabIndex = 0
		Me.btnBlowoff.Text = "Blowoff"
		Me.btnBlowoff.UseVisualStyleBackColor = False
		'
		'btnOK
		'
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Location = New System.Drawing.Point(613, 192)
		Me.btnOK.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.Size = New System.Drawing.Size(135, 34)
		Me.btnOK.TabIndex = 5
		Me.btnOK.Text = "Close Dialog"
		Me.btnOK.UseVisualStyleBackColor = False
		'
		'txtMessage
		'
		Me.txtMessage.Location = New System.Drawing.Point(0, 1)
		Me.txtMessage.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.txtMessage.Name = "txtMessage"
		Me.txtMessage.Size = New System.Drawing.Size(594, 225)
		Me.txtMessage.TabIndex = 6
		Me.txtMessage.Text = ""
		'
		'btnTryAgain
		'
		Me.btnTryAgain.BackColor = System.Drawing.SystemColors.Control
		Me.btnTryAgain.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTryAgain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTryAgain.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTryAgain.Location = New System.Drawing.Point(607, 96)
		Me.btnTryAgain.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.btnTryAgain.Name = "btnTryAgain"
		Me.btnTryAgain.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTryAgain.Size = New System.Drawing.Size(135, 34)
		Me.btnTryAgain.TabIndex = 7
		Me.btnTryAgain.Text = "Try Again"
		Me.btnTryAgain.UseVisualStyleBackColor = False
		'
		'frmAlarmMsg
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.CausesValidation = False
		Me.ClientSize = New System.Drawing.Size(762, 230)
		Me.Controls.Add(Me.btnTryAgain)
		Me.Controls.Add(Me.txtMessage)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.btnDepositPlate)
		Me.Controls.Add(Me.btnBlowoff)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Location = New System.Drawing.Point(184, 250)
		Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAlarmMsg"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Robot Alarm"
		Me.TopMost = True
		Me.ResumeLayout(False)

	End Sub
  Public WithEvents btnOK As System.Windows.Forms.Button
	Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
	Public WithEvents btnTryAgain As System.Windows.Forms.Button
#End Region
End Class