<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmComm
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
  Public WithEvents cmdEnter As System.Windows.Forms.Button
	Public WithEvents txtSendCommand As System.Windows.Forms.TextBox
  Public WithEvents lblSendCommand As System.Windows.Forms.Label
  Public WithEvents lblMessagesFromTheRobot As System.Windows.Forms.Label
  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.cmdEnter = New System.Windows.Forms.Button()
    Me.txtSendCommand = New System.Windows.Forms.TextBox()
    Me.lblSendCommand = New System.Windows.Forms.Label()
    Me.lblMessagesFromTheRobot = New System.Windows.Forms.Label()
    Me.lstInputBuffer = New System.Windows.Forms.ListBox()
    Me.lstOutputBuffer = New System.Windows.Forms.ListBox()
    Me.lblMessagesToTheRobot = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'cmdEnter
    '
    Me.cmdEnter.BackColor = System.Drawing.SystemColors.Control
    Me.cmdEnter.Cursor = System.Windows.Forms.Cursors.Default
    Me.cmdEnter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdEnter.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmdEnter.Location = New System.Drawing.Point(331, 13)
    Me.cmdEnter.Name = "cmdEnter"
    Me.cmdEnter.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cmdEnter.Size = New System.Drawing.Size(53, 21)
    Me.cmdEnter.TabIndex = 2
    Me.cmdEnter.Text = "Enter"
    Me.cmdEnter.UseVisualStyleBackColor = False
    '
    'txtSendCommand
    '
    Me.txtSendCommand.AcceptsReturn = True
    Me.txtSendCommand.BackColor = System.Drawing.SystemColors.Window
    Me.txtSendCommand.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtSendCommand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSendCommand.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtSendCommand.Location = New System.Drawing.Point(89, 13)
    Me.txtSendCommand.MaxLength = 0
    Me.txtSendCommand.Name = "txtSendCommand"
    Me.txtSendCommand.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtSendCommand.Size = New System.Drawing.Size(239, 20)
    Me.txtSendCommand.TabIndex = 1
    '
    'lblSendCommand
    '
    Me.lblSendCommand.BackColor = System.Drawing.SystemColors.Control
    Me.lblSendCommand.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblSendCommand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSendCommand.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblSendCommand.Location = New System.Drawing.Point(47, 16)
    Me.lblSendCommand.Name = "lblSendCommand"
    Me.lblSendCommand.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblSendCommand.Size = New System.Drawing.Size(36, 17)
    Me.lblSendCommand.TabIndex = 3
    Me.lblSendCommand.Text = "Send Command"
    '
    'lblMessagesFromTheRobot
    '
    Me.lblMessagesFromTheRobot.BackColor = System.Drawing.SystemColors.Control
    Me.lblMessagesFromTheRobot.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblMessagesFromTheRobot.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMessagesFromTheRobot.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblMessagesFromTheRobot.Location = New System.Drawing.Point(12, 53)
    Me.lblMessagesFromTheRobot.Name = "lblMessagesFromTheRobot"
    Me.lblMessagesFromTheRobot.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblMessagesFromTheRobot.Size = New System.Drawing.Size(207, 19)
    Me.lblMessagesFromTheRobot.TabIndex = 0
    Me.lblMessagesFromTheRobot.Text = "Messages from the Robot"
    '
    'lstInputBuffer
    '
    Me.lstInputBuffer.FormattingEnabled = True
    Me.lstInputBuffer.ItemHeight = 14
    Me.lstInputBuffer.Location = New System.Drawing.Point(11, 72)
    Me.lstInputBuffer.Name = "lstInputBuffer"
    Me.lstInputBuffer.ScrollAlwaysVisible = True
    Me.lstInputBuffer.Size = New System.Drawing.Size(399, 284)
    Me.lstInputBuffer.TabIndex = 4
    Me.lstInputBuffer.UseTabStops = False
    '
    'lstOutputBuffer
    '
    Me.lstOutputBuffer.FormattingEnabled = True
    Me.lstOutputBuffer.ItemHeight = 14
    Me.lstOutputBuffer.Location = New System.Drawing.Point(11, 392)
    Me.lstOutputBuffer.Name = "lstOutputBuffer"
    Me.lstOutputBuffer.ScrollAlwaysVisible = True
    Me.lstOutputBuffer.Size = New System.Drawing.Size(399, 270)
    Me.lstOutputBuffer.TabIndex = 5
    Me.lstOutputBuffer.UseTabStops = False
    '
    'lblMessagesToTheRobot
    '
    Me.lblMessagesToTheRobot.BackColor = System.Drawing.SystemColors.Control
    Me.lblMessagesToTheRobot.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblMessagesToTheRobot.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMessagesToTheRobot.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblMessagesToTheRobot.Location = New System.Drawing.Point(12, 370)
    Me.lblMessagesToTheRobot.Name = "lblMessagesToTheRobot"
    Me.lblMessagesToTheRobot.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblMessagesToTheRobot.Size = New System.Drawing.Size(207, 19)
    Me.lblMessagesToTheRobot.TabIndex = 6
    Me.lblMessagesToTheRobot.Text = "Messages to the Robot"
    '
    'frmComm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(425, 688)
    Me.Controls.Add(Me.lblMessagesToTheRobot)
    Me.Controls.Add(Me.lstOutputBuffer)
    Me.Controls.Add(Me.lstInputBuffer)
    Me.Controls.Add(Me.cmdEnter)
    Me.Controls.Add(Me.txtSendCommand)
    Me.Controls.Add(Me.lblSendCommand)
    Me.Controls.Add(Me.lblMessagesFromTheRobot)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Location = New System.Drawing.Point(580, 104)
    Me.Name = "frmComm"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Communication Messages"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lstInputBuffer As System.Windows.Forms.ListBox
  Friend WithEvents lstOutputBuffer As System.Windows.Forms.ListBox
  Public WithEvents lblMessagesToTheRobot As System.Windows.Forms.Label
#End Region
End Class