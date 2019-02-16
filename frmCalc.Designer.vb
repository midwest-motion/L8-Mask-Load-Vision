<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCalc
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
  Public WithEvents btnCalcAnchorShift As System.Windows.Forms.Button
  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.btnCalcAnchorShift = New System.Windows.Forms.Button()
		Me.txtX = New System.Windows.Forms.TextBox()
		Me.txtY = New System.Windows.Forms.TextBox()
		Me.btnCalcAngle = New System.Windows.Forms.Button()
		Me.txtAngle = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnCalcAnchorShift
		'
		Me.btnCalcAnchorShift.BackColor = System.Drawing.SystemColors.Control
		Me.btnCalcAnchorShift.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCalcAnchorShift.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalcAnchorShift.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCalcAnchorShift.Location = New System.Drawing.Point(20, 20)
		Me.btnCalcAnchorShift.Name = "btnCalcAnchorShift"
		Me.btnCalcAnchorShift.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCalcAnchorShift.Size = New System.Drawing.Size(135, 35)
		Me.btnCalcAnchorShift.TabIndex = 0
		Me.btnCalcAnchorShift.Text = "Calculate Anchor Shift"
		Me.btnCalcAnchorShift.UseVisualStyleBackColor = False
		'
		'txtX
		'
		Me.txtX.Location = New System.Drawing.Point(181, 66)
		Me.txtX.Name = "txtX"
		Me.txtX.Size = New System.Drawing.Size(103, 20)
		Me.txtX.TabIndex = 1
		'
		'txtY
		'
		Me.txtY.Location = New System.Drawing.Point(290, 66)
		Me.txtY.Name = "txtY"
		Me.txtY.Size = New System.Drawing.Size(103, 20)
		Me.txtY.TabIndex = 2
		'
		'btnCalcAngle
		'
		Me.btnCalcAngle.BackColor = System.Drawing.SystemColors.Control
		Me.btnCalcAngle.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCalcAngle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalcAngle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCalcAngle.Location = New System.Drawing.Point(181, 20)
		Me.btnCalcAngle.Name = "btnCalcAngle"
		Me.btnCalcAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCalcAngle.Size = New System.Drawing.Size(212, 35)
		Me.btnCalcAngle.TabIndex = 3
		Me.btnCalcAngle.Text = "Calculate Angle From 1 Point"
		Me.btnCalcAngle.UseVisualStyleBackColor = False
		'
		'txtAngle
		'
		Me.txtAngle.Location = New System.Drawing.Point(399, 66)
		Me.txtAngle.Name = "txtAngle"
		Me.txtAngle.Size = New System.Drawing.Size(103, 20)
		Me.txtAngle.TabIndex = 4
		'
		'frmCalc
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(516, 491)
		Me.Controls.Add(Me.txtAngle)
		Me.Controls.Add(Me.btnCalcAngle)
		Me.Controls.Add(Me.txtY)
		Me.Controls.Add(Me.txtX)
		Me.Controls.Add(Me.btnCalcAnchorShift)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Name = "frmCalc"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
  Friend WithEvents txtX As System.Windows.Forms.TextBox
  Friend WithEvents txtY As System.Windows.Forms.TextBox
  Public WithEvents btnCalcAngle As System.Windows.Forms.Button
  Friend WithEvents txtAngle As System.Windows.Forms.TextBox
#End Region 
End Class