<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSetupVision
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
	Public WithEvents ApplicationControl As AxHSAPPLICATIONLib.AxHSApplication
  Public WithEvents btnSaveHexsight As System.Windows.Forms.Button
  Public WithEvents fraAdjustExposure As System.Windows.Forms.GroupBox
  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupVision))
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.ApplicationControl = New AxHSAPPLICATIONLib.AxHSApplication
    Me.btnSaveHexsight = New System.Windows.Forms.Button
    Me.fraAdjustExposure = New System.Windows.Forms.GroupBox
    CType(Me.ApplicationControl, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.fraAdjustExposure.SuspendLayout()
    Me.SuspendLayout()
    '
    'ApplicationControl
    '
    Me.ApplicationControl.Enabled = True
    Me.ApplicationControl.Location = New System.Drawing.Point(0, 0)
    Me.ApplicationControl.Name = "ApplicationControl"
    Me.ApplicationControl.OcxState = CType(resources.GetObject("ApplicationControl.OcxState"), System.Windows.Forms.AxHost.State)
    Me.ApplicationControl.Size = New System.Drawing.Size(645, 375)
    Me.ApplicationControl.TabIndex = 6
    '
    'btnSaveHexsight
    '
    Me.btnSaveHexsight.BackColor = System.Drawing.SystemColors.Control
    Me.btnSaveHexsight.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSaveHexsight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSaveHexsight.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSaveHexsight.Location = New System.Drawing.Point(648, 4)
    Me.btnSaveHexsight.Name = "btnSaveHexsight"
    Me.btnSaveHexsight.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSaveHexsight.Size = New System.Drawing.Size(103, 41)
    Me.btnSaveHexsight.TabIndex = 7
    Me.btnSaveHexsight.Text = "Save"
    Me.btnSaveHexsight.UseVisualStyleBackColor = False
    '
    'fraAdjustExposure
    '
    Me.fraAdjustExposure.BackColor = System.Drawing.SystemColors.Control
    Me.fraAdjustExposure.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.fraAdjustExposure.ForeColor = System.Drawing.SystemColors.ControlText
    Me.fraAdjustExposure.Location = New System.Drawing.Point(8, 440)
    Me.fraAdjustExposure.Name = "fraAdjustExposure"
    Me.fraAdjustExposure.Padding = New System.Windows.Forms.Padding(0)
    Me.fraAdjustExposure.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.fraAdjustExposure.Size = New System.Drawing.Size(103, 129)
    Me.fraAdjustExposure.TabIndex = 0
    Me.fraAdjustExposure.TabStop = False
    Me.fraAdjustExposure.Text = "Adjust Exposure"

    '
    'frmSetupVision
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(754, 377)
    Me.Controls.Add(Me.ApplicationControl)
    Me.Controls.Add(Me.btnSaveHexsight)
    Me.Controls.Add(Me.fraAdjustExposure)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.Color.Black
    Me.Location = New System.Drawing.Point(4, 23)
    Me.Name = "frmSetupVision"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text = "Setup Vision Parameters"
    CType(Me.ApplicationControl, System.ComponentModel.ISupportInitialize).EndInit()
    Me.fraAdjustExposure.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region 
End Class