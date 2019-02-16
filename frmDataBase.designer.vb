<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDataBase
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
  'Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
  'Public WithEvents dgrSettings As AxMSDataGridLib.AxDataGrid
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dgrSettings = New System.Windows.Forms.DataGridView()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuUpdateAllPartFiles = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.dgrSettings, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgrSettings
		'
		Me.dgrSettings.AllowUserToResizeColumns = False
		Me.dgrSettings.AllowUserToResizeRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.dgrSettings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgrSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.dgrSettings.BackgroundColor = System.Drawing.SystemColors.Control
		Me.dgrSettings.Location = New System.Drawing.Point(0, 27)
		Me.dgrSettings.MultiSelect = False
		Me.dgrSettings.Name = "dgrSettings"
		Me.dgrSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgrSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
		Me.dgrSettings.ShowCellToolTips = False
		Me.dgrSettings.ShowRowErrors = False
		Me.dgrSettings.Size = New System.Drawing.Size(1238, 968)
		Me.dgrSettings.TabIndex = 0
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1242, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'ControlsToolStripMenuItem
		'
		Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUpdateAllPartFiles})
		Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
		Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
		Me.ControlsToolStripMenuItem.Text = "Controls"
		'
		'mnuUpdateAllPartFiles
		'
		Me.mnuUpdateAllPartFiles.Name = "mnuUpdateAllPartFiles"
		Me.mnuUpdateAllPartFiles.Size = New System.Drawing.Size(158, 22)
		Me.mnuUpdateAllPartFiles.Text = "Update All Parts"
		'
		'frmDataBase
		'
		Me.AutoSize = True
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(1242, 999)
		Me.Controls.Add(Me.dgrSettings)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmDataBase"
		Me.TopMost = True
		CType(Me.dgrSettings, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents FrmMainBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
	Friend WithEvents dgrSettings As System.Windows.Forms.DataGridView
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents ControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuUpdateAllPartFiles As System.Windows.Forms.ToolStripMenuItem
#End Region
End Class