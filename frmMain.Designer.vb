<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
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
  Public InitializingForm As Boolean = True
  Private components As System.ComponentModel.IContainer
  Public WithEvents mnuLoadPart As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuDeletePart As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuSeperator1 As System.Windows.Forms.ToolStripSeparator
  Public WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuShowContours As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuDisplay As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuGeneralSettings As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuPositionalSettings As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuSeperator3 As System.Windows.Forms.ToolStripSeparator
  Public WithEvents mnuConfig As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuSystemDocumentation As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
  Public WithEvents tmrLocateTime As System.Windows.Forms.Timer
  Public WithEvents tmrSnapDelay As System.Windows.Forms.Timer
    Public WithEvents lblPartLoaded As System.Windows.Forms.Label
    Public WithEvents lblPartTitle As System.Windows.Forms.Label
    'Public WithEvents HSDisplay As AxHSDisplayArray
    'Public WithEvents chkRepeatLocate As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    'Public WithEvents chkRepeatSnap As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    'Public WithEvents btnJog As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    'Public WithEvents btnLocate As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    'Public WithEvents btnSearch As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    'Public WithEvents btnSnap As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    'Public WithEvents btnTrainExisting As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    'Public WithEvents btnTrainNew As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    'Public WithEvents fltScrScoreLimit As AxFlatScrollBarArray
    'Public WithEvents fraCameraControls As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    'Public WithEvents fraImageExposure As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    'Public WithEvents fraScoreLimit As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    'Public WithEvents fraSquareControls As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    'Public WithEvents fraVisionStatus As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    'Public WithEvents lblCameraTime As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblLocateTime As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblPartLoaded As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblRobotHeader As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblRobotSpeed As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblScore As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblScoreLimit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblScrollBar As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblVisionHeader As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents lblVisionMessage As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents staVisionPose As Microsoft.VisualBasic.Compatibility.VB6.StatusStripArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
    Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuLoadPart = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuDeletePart = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSeperator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuShowContours = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuConfig = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuGeneralSettings = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPositionalSettings = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSeperator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuCalibration = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuModifyHexsightControls = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCalibrateNorth = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCalibrateSouth = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSeperator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuVerifyVisionAccuracy = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuUseSouthCameraOnly = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSystemDocumentation = New System.Windows.Forms.ToolStripMenuItem()
    Me.lblPartLoaded = New System.Windows.Forms.Label()
    Me.lblPartTitle = New System.Windows.Forms.Label()
    Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.lblVisionMessageSouthMask = New System.Windows.Forms.Label()
    Me.btnDetailsSouthMask = New System.Windows.Forms.Button()
    Me.btnSnapSouth = New System.Windows.Forms.Button()
    Me.btnTrainExistingSouthMask = New System.Windows.Forms.Button()
    Me.btnTrainNewSouthMask = New System.Windows.Forms.Button()
    Me.btnSearchSettingsSouthMask = New System.Windows.Forms.Button()
    Me.btnLocateSouthMask = New System.Windows.Forms.Button()
    Me.btnLocateOnlySouthMask = New System.Windows.Forms.Button()
    Me.btnTrainExistingNorthGlass = New System.Windows.Forms.Button()
    Me.btnTrainNewNorthGlass = New System.Windows.Forms.Button()
    Me.btnLocateNorthGlass = New System.Windows.Forms.Button()
    Me.btnLocateOnlyNorthGlass = New System.Windows.Forms.Button()
    Me.btnSearchSettingsNorthGlass = New System.Windows.Forms.Button()
    Me.btnSnapNorth = New System.Windows.Forms.Button()
    Me.updnExposureNorth = New System.Windows.Forms.NumericUpDown()
    Me.updnContrastNorth = New System.Windows.Forms.NumericUpDown()
    Me.btnLocateBoth = New System.Windows.Forms.Button()
    Me.btnSnapBoth = New System.Windows.Forms.Button()
    Me.btnClearMarkersBoth = New System.Windows.Forms.Button()
    Me.btnLocateOnlyNorthMask = New System.Windows.Forms.Button()
    Me.btnLocateNorthMask = New System.Windows.Forms.Button()
    Me.btnSearchSettingsNorthMask = New System.Windows.Forms.Button()
    Me.btnTrainNewNorthMask = New System.Windows.Forms.Button()
    Me.btnTrainExistingNorthMask = New System.Windows.Forms.Button()
    Me.btnLocateOnlySouthGlass = New System.Windows.Forms.Button()
    Me.btnLocateSouthGlass = New System.Windows.Forms.Button()
    Me.btnSearchSettingsSouthGlass = New System.Windows.Forms.Button()
    Me.btnTrainNewSouthGlass = New System.Windows.Forms.Button()
    Me.btnTrainExistingSouthGlass = New System.Windows.Forms.Button()
    Me.btnDetailsSouthGlass = New System.Windows.Forms.Button()
    Me.lblVisionMessageSouthGlass = New System.Windows.Forms.Label()
    Me.TmrPassword = New System.Windows.Forms.Timer(Me.components)
    Me.tmrDisplayUpdate = New System.Windows.Forms.Timer(Me.components)
    Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.GrpRobot = New System.Windows.Forms.GroupBox()
    Me.lblPhone = New System.Windows.Forms.Label()
    Me.picLogo = New System.Windows.Forms.PictureBox()
    Me.tabCameraControls = New System.Windows.Forms.TabControl()
    Me.tabVisionBoth = New System.Windows.Forms.TabPage()
    Me.lblSouthMaskScore = New System.Windows.Forms.Label()
    Me.lblSouthGlassScore = New System.Windows.Forms.Label()
    Me.lblNorthGlassScore = New System.Windows.Forms.Label()
    Me.lblNorthMaskScore = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.lblFinalStatus = New System.Windows.Forms.Label()
    Me.chkRepeatSnapBoth = New System.Windows.Forms.CheckBox()
    Me.chkRepeatLocateBoth = New System.Windows.Forms.CheckBox()
    Me.lblSouthGlassPlaceHolder = New System.Windows.Forms.Label()
    Me.lblSouthMaskPlaceHolder = New System.Windows.Forms.Label()
    Me.lblNorthGlassPlaceHolder = New System.Windows.Forms.Label()
    Me.lblNorthMaskPlaceHolder = New System.Windows.Forms.Label()
    Me._Frame1_1 = New System.Windows.Forms.GroupBox()
    Me.txtSouthSecondClick = New System.Windows.Forms.TextBox()
    Me.txtSouthFirstClick = New System.Windows.Forms.TextBox()
    Me.txtSouthDistance = New System.Windows.Forms.TextBox()
    Me._lblPoint_5 = New System.Windows.Forms.Label()
    Me._lblPoint_4 = New System.Windows.Forms.Label()
    Me._lblPoint_3 = New System.Windows.Forms.Label()
    Me._Frame1_0 = New System.Windows.Forms.GroupBox()
    Me.txtCombinedOneHalf = New System.Windows.Forms.TextBox()
    Me.txtNorthDistance = New System.Windows.Forms.TextBox()
    Me.txtNorthFirstClick = New System.Windows.Forms.TextBox()
    Me.txtNorthSecondClick = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me._lblPoint_2 = New System.Windows.Forms.Label()
    Me._lblPoint_0 = New System.Windows.Forms.Label()
    Me._lblPoint_1 = New System.Windows.Forms.Label()
    Me.grpSouth = New System.Windows.Forms.GroupBox()
    Me.grpNorth = New System.Windows.Forms.GroupBox()
    Me.tabVisionNorth = New System.Windows.Forms.TabPage()
    Me.grpVisionNorth = New System.Windows.Forms.GroupBox()
    Me.grpVisionStatusNorthMask = New System.Windows.Forms.GroupBox()
    Me.lblScoreLimitNorthMask = New System.Windows.Forms.Label()
    Me.updnScoreLimitNorthMask = New System.Windows.Forms.NumericUpDown()
    Me.lblVisionPoseScoreNorthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseTimeNorthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseRNorthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseYNorthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseXNorthMask = New System.Windows.Forms.Label()
    Me.btnDetailsNorthMask = New System.Windows.Forms.Button()
    Me.lblVisionMessageNorthMask = New System.Windows.Forms.Label()
    Me.Label38 = New System.Windows.Forms.Label()
    Me.Label39 = New System.Windows.Forms.Label()
    Me.Label40 = New System.Windows.Forms.Label()
    Me.Label41 = New System.Windows.Forms.Label()
    Me.Label42 = New System.Windows.Forms.Label()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.chkLocateRepeatNorthMask = New System.Windows.Forms.CheckBox()
    Me.GroupBox6 = New System.Windows.Forms.GroupBox()
    Me.lblCameraStatusNorth = New System.Windows.Forms.Label()
    Me.lblTemperatureNorth = New System.Windows.Forms.Label()
    Me.pctTemperatureNorth = New System.Windows.Forms.PictureBox()
    Me.grpCameraControlsNorth = New System.Windows.Forms.GroupBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.lblContrastValueNorth = New System.Windows.Forms.Label()
    Me.lblBrightnessValueNorth = New System.Windows.Forms.Label()
    Me.lblExposureValueNorth = New System.Windows.Forms.Label()
    Me.lblContrastNorth = New System.Windows.Forms.Label()
    Me.lblExposureNorth = New System.Windows.Forms.Label()
    Me.chkSnapRepeatNorth = New System.Windows.Forms.CheckBox()
    Me.lblCameraTimeNorth = New System.Windows.Forms.Label()
    Me.grpVisionStatusNorthGlass = New System.Windows.Forms.GroupBox()
    Me.lblScoreLimitNorthGlass = New System.Windows.Forms.Label()
    Me.updnScoreLimitNorthGlass = New System.Windows.Forms.NumericUpDown()
    Me.lblVisionPoseScoreNorthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseTimeNorthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseRNorthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseYNorthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseXNorthGlass = New System.Windows.Forms.Label()
    Me.btnDetailsNorthGlass = New System.Windows.Forms.Button()
    Me.lblVisionMessageNorthGlass = New System.Windows.Forms.Label()
    Me.lblVisionXNorth = New System.Windows.Forms.Label()
    Me.lblVisionYNorth = New System.Windows.Forms.Label()
    Me.lblVisionAngleNorth = New System.Windows.Forms.Label()
    Me.lblVisionTimeNorth = New System.Windows.Forms.Label()
    Me.lblVisionScoreNorth = New System.Windows.Forms.Label()
    Me.grpHSDisplayNorth = New System.Windows.Forms.GroupBox()
    Me.cboCameras = New System.Windows.Forms.ComboBox()
    Me.HSDisplayNorth = New AxHSDISPLAYLib.AxHSDisplay()
    Me.grpLocatorControlsNorth = New System.Windows.Forms.GroupBox()
    Me.chkLocateRepeatNorthGlass = New System.Windows.Forms.CheckBox()
    Me.tabVisionSouth = New System.Windows.Forms.TabPage()
    Me.grpVisionSouth = New System.Windows.Forms.GroupBox()
    Me.grpLocatorControlsSouthGlass = New System.Windows.Forms.GroupBox()
    Me.chkLocateRepeatSouthGlass = New System.Windows.Forms.CheckBox()
    Me.grpVisionStatusSouthGlass = New System.Windows.Forms.GroupBox()
    Me.lblScoreLimitSouthGlass = New System.Windows.Forms.Label()
    Me.updnScoreLimitSouthGlass = New System.Windows.Forms.NumericUpDown()
    Me.lblVisionPoseScoreSouthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseTimeSouthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseRSouthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseYSouthGlass = New System.Windows.Forms.Label()
    Me.lblVisionPoseXSouthGlass = New System.Windows.Forms.Label()
    Me.lblXVisionSouthGlass = New System.Windows.Forms.Label()
    Me.lblYVisionSouthGlass = New System.Windows.Forms.Label()
    Me.lblRVisionSouthGlass = New System.Windows.Forms.Label()
    Me.lblTimeVisionSouthGlass = New System.Windows.Forms.Label()
    Me.lblScoreVisionSouthGlass = New System.Windows.Forms.Label()
    Me.grpCameraStatusSouth = New System.Windows.Forms.GroupBox()
    Me.lblCameraStatusSouth = New System.Windows.Forms.Label()
    Me.lblTemperatureSouth = New System.Windows.Forms.Label()
    Me.pctTemperatureSouth = New System.Windows.Forms.PictureBox()
    Me.grpLocatorControlsSouthMask = New System.Windows.Forms.GroupBox()
    Me.chkLocateRepeatSouthMask = New System.Windows.Forms.CheckBox()
    Me.grpHSDisplaySouth = New System.Windows.Forms.GroupBox()
    Me.HSDisplaySouth = New AxHSDISPLAYLib.AxHSDisplay()
    Me.grpCameraControlsSouth = New System.Windows.Forms.GroupBox()
    Me.Label31 = New System.Windows.Forms.Label()
    Me.lblContrastValueSouth = New System.Windows.Forms.Label()
    Me.lblBrightnessValueSouth = New System.Windows.Forms.Label()
    Me.lblExposureValueSouth = New System.Windows.Forms.Label()
    Me.lblContrastSouth = New System.Windows.Forms.Label()
    Me.lblExposureSouth = New System.Windows.Forms.Label()
    Me.updnContrastSouth = New System.Windows.Forms.NumericUpDown()
    Me.updnExposureSouth = New System.Windows.Forms.NumericUpDown()
    Me.chkSnapRepeatSouth = New System.Windows.Forms.CheckBox()
    Me.lblCameraTimeSouth = New System.Windows.Forms.Label()
    Me.grpVisionStatusSouthMask = New System.Windows.Forms.GroupBox()
    Me.lblScoreLimitSouthMask = New System.Windows.Forms.Label()
    Me.updnScoreLimitSouthMask = New System.Windows.Forms.NumericUpDown()
    Me.lblVisionPoseScoreSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseTimeSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseRSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseYSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionPoseXSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionXSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionYSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionAngleSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionTimeSouthMask = New System.Windows.Forms.Label()
    Me.lblVisionScoreSouthMask = New System.Windows.Forms.Label()
    Me.tabVisionDebug = New System.Windows.Forms.TabPage()
    Me.grpMisc = New System.Windows.Forms.GroupBox()
    Me.updnRLimit = New System.Windows.Forms.NumericUpDown()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.grpMaskCombined = New System.Windows.Forms.GroupBox()
    Me.lblMaskCombinedR = New System.Windows.Forms.Label()
    Me.lblMaskCombinedY = New System.Windows.Forms.Label()
    Me.lblMaskCombinedX = New System.Windows.Forms.Label()
    Me.lblMaskCombinedStatus = New System.Windows.Forms.Label()
    Me.Label35 = New System.Windows.Forms.Label()
    Me.Label36 = New System.Windows.Forms.Label()
    Me.Label37 = New System.Windows.Forms.Label()
    Me.grpGlassCombined = New System.Windows.Forms.GroupBox()
    Me.lblGlassCombinedR = New System.Windows.Forms.Label()
    Me.lblGlassCombinedY = New System.Windows.Forms.Label()
    Me.lblGlassCombinedX = New System.Windows.Forms.Label()
    Me.lblGlassCombinedStatus = New System.Windows.Forms.Label()
    Me.Label30 = New System.Windows.Forms.Label()
    Me.Label32 = New System.Windows.Forms.Label()
    Me.Label33 = New System.Windows.Forms.Label()
    Me.grpCombinedOffset = New System.Windows.Forms.GroupBox()
    Me.SSTab1 = New System.Windows.Forms.TabControl()
    Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label29 = New System.Windows.Forms.Label()
    Me.txtRLimit = New System.Windows.Forms.TextBox()
    Me.cmdOKLimits = New System.Windows.Forms.Button()
    Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
    Me.cmdOKGeneralSettings = New System.Windows.Forms.Button()
    Me.txtRetryCountLimit = New System.Windows.Forms.TextBox()
    Me.txtSnapAfterLocate = New System.Windows.Forms.TextBox()
    Me._lblSnapAfterLocate_0 = New System.Windows.Forms.Label()
    Me._Label8_3 = New System.Windows.Forms.Label()
    Me._Label8_2 = New System.Windows.Forms.Label()
    Me._lblSnapAfterLocate_1 = New System.Windows.Forms.Label()
    Me.grpCommStatus = New System.Windows.Forms.GroupBox()
    Me.txtCommStatus = New System.Windows.Forms.TextBox()
    Me.grpShiftOffset = New System.Windows.Forms.GroupBox()
    Me.updnXShift = New System.Windows.Forms.NumericUpDown()
    Me.updnYShift = New System.Windows.Forms.NumericUpDown()
    Me.Label21 = New System.Windows.Forms.Label()
    Me.Label20 = New System.Windows.Forms.Label()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.updnRLinear = New System.Windows.Forms.NumericUpDown()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.updnRShift = New System.Windows.Forms.NumericUpDown()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.grpCombinedOffsetDetail = New System.Windows.Forms.GroupBox()
    Me.txtRCombined = New System.Windows.Forms.TextBox()
    Me.txtYCombined = New System.Windows.Forms.TextBox()
    Me.Label28 = New System.Windows.Forms.Label()
    Me.txtXCombined = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.lblVisionTimeBoth = New System.Windows.Forms.Label()
    Me.Label27 = New System.Windows.Forms.Label()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.Label24 = New System.Windows.Forms.Label()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.lblPiece2DescY = New System.Windows.Forms.Label()
    Me.lblPiece2DescX = New System.Windows.Forms.Label()
    Me.lblPiece2DescR = New System.Windows.Forms.Label()
    Me.grpVBErrors = New System.Windows.Forms.GroupBox()
    Me.lstVBError = New System.Windows.Forms.ListBox()
    Me.MainMenu1.SuspendLayout()
    CType(Me.updnExposureNorth, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.updnContrastNorth, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpRobot.SuspendLayout()
    CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tabCameraControls.SuspendLayout()
    Me.tabVisionBoth.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me._Frame1_1.SuspendLayout()
    Me._Frame1_0.SuspendLayout()
    Me.tabVisionNorth.SuspendLayout()
    Me.grpVisionNorth.SuspendLayout()
    Me.grpVisionStatusNorthMask.SuspendLayout()
    CType(Me.updnScoreLimitNorthMask, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox6.SuspendLayout()
    CType(Me.pctTemperatureNorth, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpCameraControlsNorth.SuspendLayout()
    Me.grpVisionStatusNorthGlass.SuspendLayout()
    CType(Me.updnScoreLimitNorthGlass, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpHSDisplayNorth.SuspendLayout()
    CType(Me.HSDisplayNorth, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpLocatorControlsNorth.SuspendLayout()
    Me.tabVisionSouth.SuspendLayout()
    Me.grpVisionSouth.SuspendLayout()
    Me.grpLocatorControlsSouthGlass.SuspendLayout()
    Me.grpVisionStatusSouthGlass.SuspendLayout()
    CType(Me.updnScoreLimitSouthGlass, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpCameraStatusSouth.SuspendLayout()
    CType(Me.pctTemperatureSouth, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpLocatorControlsSouthMask.SuspendLayout()
    Me.grpHSDisplaySouth.SuspendLayout()
    CType(Me.HSDisplaySouth, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpCameraControlsSouth.SuspendLayout()
    CType(Me.updnContrastSouth, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.updnExposureSouth, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpVisionStatusSouthMask.SuspendLayout()
    CType(Me.updnScoreLimitSouthMask, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tabVisionDebug.SuspendLayout()
    Me.grpMisc.SuspendLayout()
    CType(Me.updnRLimit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpMaskCombined.SuspendLayout()
    Me.grpGlassCombined.SuspendLayout()
    Me.grpCombinedOffset.SuspendLayout()
    Me.SSTab1.SuspendLayout()
    Me._SSTab1_TabPage0.SuspendLayout()
    Me._SSTab1_TabPage1.SuspendLayout()
    Me.grpCommStatus.SuspendLayout()
    Me.grpShiftOffset.SuspendLayout()
    CType(Me.updnXShift, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.updnYShift, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.updnRLinear, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.updnRShift, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpCombinedOffsetDetail.SuspendLayout()
    Me.grpVBErrors.SuspendLayout()
    Me.SuspendLayout()
    '
    'MainMenu1
    '
    Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuDisplay, Me.mnuConfig, Me.mnuHelp})
    Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
    Me.MainMenu1.Name = "MainMenu1"
    Me.MainMenu1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
    Me.MainMenu1.Size = New System.Drawing.Size(1904, 24)
    Me.MainMenu1.TabIndex = 48
    '
    'mnuFile
    '
    Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoadPart, Me.mnuNew, Me.mnuDeletePart, Me.mnuSeperator1, Me.mnuPassword, Me.mnuQuit})
    Me.mnuFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuFile.Name = "mnuFile"
    Me.mnuFile.Size = New System.Drawing.Size(42, 20)
    Me.mnuFile.Text = "File"
    '
    'mnuLoadPart
    '
    Me.mnuLoadPart.Name = "mnuLoadPart"
    Me.mnuLoadPart.Size = New System.Drawing.Size(244, 22)
    Me.mnuLoadPart.Text = "Load a Part"
    '
    'mnuNew
    '
    Me.mnuNew.Name = "mnuNew"
    Me.mnuNew.Size = New System.Drawing.Size(244, 22)
    Me.mnuNew.Text = "Create a Part From This Part"
    '
    'mnuDeletePart
    '
    Me.mnuDeletePart.Name = "mnuDeletePart"
    Me.mnuDeletePart.Size = New System.Drawing.Size(244, 22)
    Me.mnuDeletePart.Text = "Delete a Part"
    '
    'mnuSeperator1
    '
    Me.mnuSeperator1.Name = "mnuSeperator1"
    Me.mnuSeperator1.Size = New System.Drawing.Size(241, 6)
    '
    'mnuPassword
    '
    Me.mnuPassword.Name = "mnuPassword"
    Me.mnuPassword.Size = New System.Drawing.Size(244, 22)
    Me.mnuPassword.Text = "Enter Password"
    '
    'mnuQuit
    '
    Me.mnuQuit.Name = "mnuQuit"
    Me.mnuQuit.Size = New System.Drawing.Size(244, 22)
    Me.mnuQuit.Text = "Quit"
    '
    'mnuDisplay
    '
    Me.mnuDisplay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowContours})
    Me.mnuDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuDisplay.Name = "mnuDisplay"
    Me.mnuDisplay.Size = New System.Drawing.Size(66, 20)
    Me.mnuDisplay.Text = "Display"
    '
    'mnuShowContours
    '
    Me.mnuShowContours.CheckOnClick = True
    Me.mnuShowContours.Name = "mnuShowContours"
    Me.mnuShowContours.Size = New System.Drawing.Size(219, 22)
    Me.mnuShowContours.Text = "Display Found Contours"
    '
    'mnuConfig
    '
    Me.mnuConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGeneralSettings, Me.mnuPositionalSettings, Me.mnuSeperator3, Me.mnuCalibration, Me.mnuSeperator2, Me.mnuVerifyVisionAccuracy, Me.mnuUseSouthCameraOnly})
    Me.mnuConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuConfig.Name = "mnuConfig"
    Me.mnuConfig.Size = New System.Drawing.Size(98, 20)
    Me.mnuConfig.Text = "Configuration"
    '
    'mnuGeneralSettings
    '
    Me.mnuGeneralSettings.Name = "mnuGeneralSettings"
    Me.mnuGeneralSettings.Size = New System.Drawing.Size(219, 22)
    Me.mnuGeneralSettings.Text = "General Settings"
    '
    'mnuPositionalSettings
    '
    Me.mnuPositionalSettings.Name = "mnuPositionalSettings"
    Me.mnuPositionalSettings.Size = New System.Drawing.Size(219, 22)
    Me.mnuPositionalSettings.Text = "Part Settings"
    '
    'mnuSeperator3
    '
    Me.mnuSeperator3.Name = "mnuSeperator3"
    Me.mnuSeperator3.Size = New System.Drawing.Size(216, 6)
    '
    'mnuCalibration
    '
    Me.mnuCalibration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModifyHexsightControls, Me.mnuCalibrateNorth, Me.mnuCalibrateSouth})
    Me.mnuCalibration.Name = "mnuCalibration"
    Me.mnuCalibration.Size = New System.Drawing.Size(219, 22)
    Me.mnuCalibration.Text = "Vision Settings"
    '
    'mnuModifyHexsightControls
    '
    Me.mnuModifyHexsightControls.Name = "mnuModifyHexsightControls"
    Me.mnuModifyHexsightControls.Size = New System.Drawing.Size(223, 22)
    Me.mnuModifyHexsightControls.Text = "Modify Hexsight Controls"
    '
    'mnuCalibrateNorth
    '
    Me.mnuCalibrateNorth.Name = "mnuCalibrateNorth"
    Me.mnuCalibrateNorth.Size = New System.Drawing.Size(223, 22)
    Me.mnuCalibrateNorth.Text = "Calibrate North Camera"
    '
    'mnuCalibrateSouth
    '
    Me.mnuCalibrateSouth.Name = "mnuCalibrateSouth"
    Me.mnuCalibrateSouth.Size = New System.Drawing.Size(223, 22)
    Me.mnuCalibrateSouth.Text = "Calibrate South Camera"
    '
    'mnuSeperator2
    '
    Me.mnuSeperator2.Name = "mnuSeperator2"
    Me.mnuSeperator2.Size = New System.Drawing.Size(216, 6)
    '
    'mnuVerifyVisionAccuracy
    '
    Me.mnuVerifyVisionAccuracy.Name = "mnuVerifyVisionAccuracy"
    Me.mnuVerifyVisionAccuracy.Size = New System.Drawing.Size(219, 22)
    Me.mnuVerifyVisionAccuracy.Text = "Verify Vision Accuracy"
    '
    'mnuUseSouthCameraOnly
    '
    Me.mnuUseSouthCameraOnly.Name = "mnuUseSouthCameraOnly"
    Me.mnuUseSouthCameraOnly.Size = New System.Drawing.Size(219, 22)
    Me.mnuUseSouthCameraOnly.Text = "Use South Camera Only"
    '
    'mnuHelp
    '
    Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSystemDocumentation})
    Me.mnuHelp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuHelp.Name = "mnuHelp"
    Me.mnuHelp.Size = New System.Drawing.Size(45, 20)
    Me.mnuHelp.Text = "Help"
    '
    'mnuSystemDocumentation
    '
    Me.mnuSystemDocumentation.Name = "mnuSystemDocumentation"
    Me.mnuSystemDocumentation.Size = New System.Drawing.Size(207, 22)
    Me.mnuSystemDocumentation.Text = "System Documentation"
    '
    'lblPartLoaded
    '
    Me.lblPartLoaded.BackColor = System.Drawing.SystemColors.Control
    Me.lblPartLoaded.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblPartLoaded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPartLoaded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblPartLoaded.Location = New System.Drawing.Point(289, 1)
    Me.lblPartLoaded.Name = "lblPartLoaded"
    Me.lblPartLoaded.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblPartLoaded.Size = New System.Drawing.Size(73, 24)
    Me.lblPartLoaded.TabIndex = 33
    Me.lblPartLoaded.Text = "Part is:"
    '
    'lblPartTitle
    '
    Me.lblPartTitle.BackColor = System.Drawing.SystemColors.Control
    Me.lblPartTitle.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblPartTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPartTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblPartTitle.Location = New System.Drawing.Point(358, 2)
    Me.lblPartTitle.Name = "lblPartTitle"
    Me.lblPartTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblPartTitle.Size = New System.Drawing.Size(483, 24)
    Me.lblPartTitle.TabIndex = 32
    Me.lblPartTitle.Text = "Nothing"
    '
    'tmrDelay
    '
    Me.tmrDelay.Interval = 1
    '
    'ToolTip1
    '
    Me.ToolTip1.AutoPopDelay = 32000
    Me.ToolTip1.InitialDelay = 500
    Me.ToolTip1.ReshowDelay = 100
    '
    'lblVisionMessageSouthMask
    '
    Me.lblVisionMessageSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionMessageSouthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionMessageSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionMessageSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionMessageSouthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblVisionMessageSouthMask.Location = New System.Drawing.Point(9, 18)
    Me.lblVisionMessageSouthMask.Name = "lblVisionMessageSouthMask"
    Me.lblVisionMessageSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionMessageSouthMask.Size = New System.Drawing.Size(299, 43)
    Me.lblVisionMessageSouthMask.TabIndex = 56
    Me.lblVisionMessageSouthMask.TextAlign = System.Drawing.ContentAlignment.TopCenter
    Me.ToolTip1.SetToolTip(Me.lblVisionMessageSouthMask, "The status of the most recent locate attempt.  Click the Details button for more " &
        "information. ")
    '
    'btnDetailsSouthMask
    '
    Me.btnDetailsSouthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnDetailsSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnDetailsSouthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnDetailsSouthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDetailsSouthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnDetailsSouthMask.Location = New System.Drawing.Point(11, 65)
    Me.btnDetailsSouthMask.Name = "btnDetailsSouthMask"
    Me.btnDetailsSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnDetailsSouthMask.Size = New System.Drawing.Size(54, 24)
    Me.btnDetailsSouthMask.TabIndex = 144
    Me.btnDetailsSouthMask.Text = "Details"
    Me.ToolTip1.SetToolTip(Me.btnDetailsSouthMask, "Click for the full description of the vision status of the most recent locate att" &
        "empt")
    Me.btnDetailsSouthMask.UseVisualStyleBackColor = False
    '
    'btnSnapSouth
    '
    Me.btnSnapSouth.BackColor = System.Drawing.Color.Transparent
    Me.btnSnapSouth.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSnapSouth.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnSnapSouth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSnapSouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSnapSouth.Location = New System.Drawing.Point(5, 18)
    Me.btnSnapSouth.Name = "btnSnapSouth"
    Me.btnSnapSouth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSnapSouth.Size = New System.Drawing.Size(99, 26)
    Me.btnSnapSouth.TabIndex = 73
    Me.btnSnapSouth.TabStop = False
    Me.btnSnapSouth.Text = "Take a Picture"
    Me.ToolTip1.SetToolTip(Me.btnSnapSouth, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
        "epeat box is checked next to it. ")
    Me.btnSnapSouth.UseVisualStyleBackColor = False
    '
    'btnTrainExistingSouthMask
    '
    Me.btnTrainExistingSouthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainExistingSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainExistingSouthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainExistingSouthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainExistingSouthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainExistingSouthMask.Location = New System.Drawing.Point(5, 65)
    Me.btnTrainExistingSouthMask.Name = "btnTrainExistingSouthMask"
    Me.btnTrainExistingSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainExistingSouthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainExistingSouthMask.TabIndex = 58
    Me.btnTrainExistingSouthMask.TabStop = False
    Me.btnTrainExistingSouthMask.Text = "Train Existing"
    Me.ToolTip1.SetToolTip(Me.btnTrainExistingSouthMask, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
        "o the current model without discarding any previous data.")
    Me.btnTrainExistingSouthMask.UseVisualStyleBackColor = False
    '
    'btnTrainNewSouthMask
    '
    Me.btnTrainNewSouthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainNewSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainNewSouthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainNewSouthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainNewSouthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainNewSouthMask.Location = New System.Drawing.Point(5, 91)
    Me.btnTrainNewSouthMask.Name = "btnTrainNewSouthMask"
    Me.btnTrainNewSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainNewSouthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainNewSouthMask.TabIndex = 59
    Me.btnTrainNewSouthMask.TabStop = False
    Me.btnTrainNewSouthMask.Text = "Train New"
    Me.ToolTip1.SetToolTip(Me.btnTrainNewSouthMask, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
        "is used to locate the glass on the incoming position and determine its pick up p" &
        "oint.")
    Me.btnTrainNewSouthMask.UseVisualStyleBackColor = False
    '
    'btnSearchSettingsSouthMask
    '
    Me.btnSearchSettingsSouthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnSearchSettingsSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSearchSettingsSouthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnSearchSettingsSouthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSearchSettingsSouthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSearchSettingsSouthMask.Location = New System.Drawing.Point(5, 117)
    Me.btnSearchSettingsSouthMask.Name = "btnSearchSettingsSouthMask"
    Me.btnSearchSettingsSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSearchSettingsSouthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnSearchSettingsSouthMask.TabIndex = 62
    Me.btnSearchSettingsSouthMask.Text = "Search Settings"
    Me.ToolTip1.SetToolTip(Me.btnSearchSettingsSouthMask, "Search Settings - Advanced settings for the search process can by modified here. " &
        " Should not be modified unless completely necessary")
    Me.btnSearchSettingsSouthMask.UseVisualStyleBackColor = False
    '
    'btnLocateSouthMask
    '
    Me.btnLocateSouthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateSouthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateSouthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateSouthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateSouthMask.Location = New System.Drawing.Point(5, 13)
    Me.btnLocateSouthMask.Name = "btnLocateSouthMask"
    Me.btnLocateSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateSouthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateSouthMask.TabIndex = 61
    Me.btnLocateSouthMask.TabStop = False
    Me.btnLocateSouthMask.Text = "Locate With Snap"
    Me.ToolTip1.SetToolTip(Me.btnLocateSouthMask, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateSouthMask.UseVisualStyleBackColor = False
    '
    'btnLocateOnlySouthMask
    '
    Me.btnLocateOnlySouthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateOnlySouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateOnlySouthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateOnlySouthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateOnlySouthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateOnlySouthMask.Location = New System.Drawing.Point(5, 39)
    Me.btnLocateOnlySouthMask.Name = "btnLocateOnlySouthMask"
    Me.btnLocateOnlySouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateOnlySouthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateOnlySouthMask.TabIndex = 166
    Me.btnLocateOnlySouthMask.TabStop = False
    Me.btnLocateOnlySouthMask.Text = "Locate Only"
    Me.ToolTip1.SetToolTip(Me.btnLocateOnlySouthMask, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateOnlySouthMask.UseVisualStyleBackColor = False
    '
    'btnTrainExistingNorthGlass
    '
    Me.btnTrainExistingNorthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainExistingNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainExistingNorthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainExistingNorthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainExistingNorthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainExistingNorthGlass.Location = New System.Drawing.Point(7, 65)
    Me.btnTrainExistingNorthGlass.Name = "btnTrainExistingNorthGlass"
    Me.btnTrainExistingNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainExistingNorthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainExistingNorthGlass.TabIndex = 58
    Me.btnTrainExistingNorthGlass.TabStop = False
    Me.btnTrainExistingNorthGlass.Text = "Train Existing"
    Me.ToolTip1.SetToolTip(Me.btnTrainExistingNorthGlass, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
        "o the current model without discarding any previous data.")
    Me.btnTrainExistingNorthGlass.UseVisualStyleBackColor = False
    '
    'btnTrainNewNorthGlass
    '
    Me.btnTrainNewNorthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainNewNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainNewNorthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainNewNorthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainNewNorthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainNewNorthGlass.Location = New System.Drawing.Point(7, 91)
    Me.btnTrainNewNorthGlass.Name = "btnTrainNewNorthGlass"
    Me.btnTrainNewNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainNewNorthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainNewNorthGlass.TabIndex = 59
    Me.btnTrainNewNorthGlass.TabStop = False
    Me.btnTrainNewNorthGlass.Text = "Train New"
    Me.ToolTip1.SetToolTip(Me.btnTrainNewNorthGlass, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
        "is used to locate the glass on the incoming position and determine its pick up p" &
        "oint.")
    Me.btnTrainNewNorthGlass.UseVisualStyleBackColor = False
    '
    'btnLocateNorthGlass
    '
    Me.btnLocateNorthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateNorthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateNorthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateNorthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateNorthGlass.Location = New System.Drawing.Point(7, 13)
    Me.btnLocateNorthGlass.Name = "btnLocateNorthGlass"
    Me.btnLocateNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateNorthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateNorthGlass.TabIndex = 61
    Me.btnLocateNorthGlass.TabStop = False
    Me.btnLocateNorthGlass.Text = "Locate with Snap"
    Me.ToolTip1.SetToolTip(Me.btnLocateNorthGlass, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateNorthGlass.UseVisualStyleBackColor = False
    '
    'btnLocateOnlyNorthGlass
    '
    Me.btnLocateOnlyNorthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateOnlyNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateOnlyNorthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateOnlyNorthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateOnlyNorthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateOnlyNorthGlass.Location = New System.Drawing.Point(7, 39)
    Me.btnLocateOnlyNorthGlass.Name = "btnLocateOnlyNorthGlass"
    Me.btnLocateOnlyNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateOnlyNorthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateOnlyNorthGlass.TabIndex = 83
    Me.btnLocateOnlyNorthGlass.TabStop = False
    Me.btnLocateOnlyNorthGlass.Text = "Locate Only"
    Me.ToolTip1.SetToolTip(Me.btnLocateOnlyNorthGlass, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateOnlyNorthGlass.UseVisualStyleBackColor = False
    '
    'btnSearchSettingsNorthGlass
    '
    Me.btnSearchSettingsNorthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnSearchSettingsNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSearchSettingsNorthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnSearchSettingsNorthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSearchSettingsNorthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSearchSettingsNorthGlass.Location = New System.Drawing.Point(7, 117)
    Me.btnSearchSettingsNorthGlass.Name = "btnSearchSettingsNorthGlass"
    Me.btnSearchSettingsNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSearchSettingsNorthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnSearchSettingsNorthGlass.TabIndex = 62
    Me.btnSearchSettingsNorthGlass.Text = "Search Settings"
    Me.ToolTip1.SetToolTip(Me.btnSearchSettingsNorthGlass, "Search Settings - Advanced settings for the search process can by modified here. " &
        " Should not be modified unless completely necessary")
    Me.btnSearchSettingsNorthGlass.UseVisualStyleBackColor = False
    '
    'btnSnapNorth
    '
    Me.btnSnapNorth.BackColor = System.Drawing.Color.Transparent
    Me.btnSnapNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSnapNorth.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnSnapNorth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSnapNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSnapNorth.Location = New System.Drawing.Point(5, 18)
    Me.btnSnapNorth.Name = "btnSnapNorth"
    Me.btnSnapNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSnapNorth.Size = New System.Drawing.Size(99, 26)
    Me.btnSnapNorth.TabIndex = 73
    Me.btnSnapNorth.TabStop = False
    Me.btnSnapNorth.Text = "Take a Picture"
    Me.ToolTip1.SetToolTip(Me.btnSnapNorth, "Momentarily turns on the light and snaps a picture.  Will repeat as long as the r" &
        "epeat box is checked next to it. ")
    Me.btnSnapNorth.UseVisualStyleBackColor = False
    '
    'updnExposureNorth
    '
    Me.updnExposureNorth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
    Me.updnExposureNorth.Location = New System.Drawing.Point(101, 75)
    Me.updnExposureNorth.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
    Me.updnExposureNorth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.updnExposureNorth.Name = "updnExposureNorth"
    Me.updnExposureNorth.Size = New System.Drawing.Size(49, 20)
    Me.updnExposureNorth.TabIndex = 142
    Me.ToolTip1.SetToolTip(Me.updnExposureNorth, "The amount of time to allow light into the camera for each frame")
    Me.updnExposureNorth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnExposureNorth.Value = New Decimal(New Integer() {10, 0, 0, 0})
    '
    'updnContrastNorth
    '
    Me.updnContrastNorth.Location = New System.Drawing.Point(101, 97)
    Me.updnContrastNorth.Name = "updnContrastNorth"
    Me.updnContrastNorth.Size = New System.Drawing.Size(49, 20)
    Me.updnContrastNorth.TabIndex = 145
    Me.ToolTip1.SetToolTip(Me.updnContrastNorth, "Further distinguish white grey levels from black")
    Me.updnContrastNorth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnContrastNorth.Value = New Decimal(New Integer() {10, 0, 0, 0})
    '
    'btnLocateBoth
    '
    Me.btnLocateBoth.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateBoth.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateBoth.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateBoth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateBoth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateBoth.Location = New System.Drawing.Point(5, 13)
    Me.btnLocateBoth.Name = "btnLocateBoth"
    Me.btnLocateBoth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateBoth.Size = New System.Drawing.Size(138, 26)
    Me.btnLocateBoth.TabIndex = 61
    Me.btnLocateBoth.TabStop = False
    Me.btnLocateBoth.Text = "Locate Both with Snap"
    Me.ToolTip1.SetToolTip(Me.btnLocateBoth, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateBoth.UseVisualStyleBackColor = False
    '
    'btnSnapBoth
    '
    Me.btnSnapBoth.BackColor = System.Drawing.Color.Transparent
    Me.btnSnapBoth.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSnapBoth.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnSnapBoth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSnapBoth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSnapBoth.Location = New System.Drawing.Point(5, 45)
    Me.btnSnapBoth.Name = "btnSnapBoth"
    Me.btnSnapBoth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSnapBoth.Size = New System.Drawing.Size(137, 26)
    Me.btnSnapBoth.TabIndex = 158
    Me.btnSnapBoth.TabStop = False
    Me.btnSnapBoth.Text = "Snap Both"
    Me.ToolTip1.SetToolTip(Me.btnSnapBoth, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnSnapBoth.UseVisualStyleBackColor = False
    '
    'btnClearMarkersBoth
    '
    Me.btnClearMarkersBoth.BackColor = System.Drawing.Color.Transparent
    Me.btnClearMarkersBoth.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnClearMarkersBoth.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnClearMarkersBoth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnClearMarkersBoth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnClearMarkersBoth.Location = New System.Drawing.Point(5, 77)
    Me.btnClearMarkersBoth.Name = "btnClearMarkersBoth"
    Me.btnClearMarkersBoth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnClearMarkersBoth.Size = New System.Drawing.Size(138, 26)
    Me.btnClearMarkersBoth.TabIndex = 160
    Me.btnClearMarkersBoth.TabStop = False
    Me.btnClearMarkersBoth.Text = "Clear Markers"
    Me.ToolTip1.SetToolTip(Me.btnClearMarkersBoth, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnClearMarkersBoth.UseVisualStyleBackColor = False
    '
    'btnLocateOnlyNorthMask
    '
    Me.btnLocateOnlyNorthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateOnlyNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateOnlyNorthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateOnlyNorthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateOnlyNorthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateOnlyNorthMask.Location = New System.Drawing.Point(5, 40)
    Me.btnLocateOnlyNorthMask.Name = "btnLocateOnlyNorthMask"
    Me.btnLocateOnlyNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateOnlyNorthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateOnlyNorthMask.TabIndex = 83
    Me.btnLocateOnlyNorthMask.TabStop = False
    Me.btnLocateOnlyNorthMask.Text = "Locate Only"
    Me.ToolTip1.SetToolTip(Me.btnLocateOnlyNorthMask, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateOnlyNorthMask.UseVisualStyleBackColor = False
    '
    'btnLocateNorthMask
    '
    Me.btnLocateNorthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateNorthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateNorthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateNorthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateNorthMask.Location = New System.Drawing.Point(5, 13)
    Me.btnLocateNorthMask.Name = "btnLocateNorthMask"
    Me.btnLocateNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateNorthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateNorthMask.TabIndex = 61
    Me.btnLocateNorthMask.TabStop = False
    Me.btnLocateNorthMask.Text = "Locate with Snap"
    Me.ToolTip1.SetToolTip(Me.btnLocateNorthMask, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateNorthMask.UseVisualStyleBackColor = False
    '
    'btnSearchSettingsNorthMask
    '
    Me.btnSearchSettingsNorthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnSearchSettingsNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSearchSettingsNorthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnSearchSettingsNorthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSearchSettingsNorthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSearchSettingsNorthMask.Location = New System.Drawing.Point(5, 121)
    Me.btnSearchSettingsNorthMask.Name = "btnSearchSettingsNorthMask"
    Me.btnSearchSettingsNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSearchSettingsNorthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnSearchSettingsNorthMask.TabIndex = 163
    Me.btnSearchSettingsNorthMask.Text = "Search Settings"
    Me.ToolTip1.SetToolTip(Me.btnSearchSettingsNorthMask, "Search Settings - Advanced settings for the search process can by modified here. " &
        " Should not be modified unless completely necessary")
    Me.btnSearchSettingsNorthMask.UseVisualStyleBackColor = False
    '
    'btnTrainNewNorthMask
    '
    Me.btnTrainNewNorthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainNewNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainNewNorthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainNewNorthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainNewNorthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainNewNorthMask.Location = New System.Drawing.Point(5, 94)
    Me.btnTrainNewNorthMask.Name = "btnTrainNewNorthMask"
    Me.btnTrainNewNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainNewNorthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainNewNorthMask.TabIndex = 162
    Me.btnTrainNewNorthMask.TabStop = False
    Me.btnTrainNewNorthMask.Text = "Train New"
    Me.ToolTip1.SetToolTip(Me.btnTrainNewNorthMask, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
        "is used to locate the glass on the incoming position and determine its pick up p" &
        "oint.")
    Me.btnTrainNewNorthMask.UseVisualStyleBackColor = False
    '
    'btnTrainExistingNorthMask
    '
    Me.btnTrainExistingNorthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainExistingNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainExistingNorthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainExistingNorthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainExistingNorthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainExistingNorthMask.Location = New System.Drawing.Point(5, 67)
    Me.btnTrainExistingNorthMask.Name = "btnTrainExistingNorthMask"
    Me.btnTrainExistingNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainExistingNorthMask.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainExistingNorthMask.TabIndex = 161
    Me.btnTrainExistingNorthMask.TabStop = False
    Me.btnTrainExistingNorthMask.Text = "Train Existing"
    Me.ToolTip1.SetToolTip(Me.btnTrainExistingNorthMask, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
        "o the current model without discarding any previous data.")
    Me.btnTrainExistingNorthMask.UseVisualStyleBackColor = False
    '
    'btnLocateOnlySouthGlass
    '
    Me.btnLocateOnlySouthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateOnlySouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateOnlySouthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateOnlySouthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateOnlySouthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateOnlySouthGlass.Location = New System.Drawing.Point(5, 39)
    Me.btnLocateOnlySouthGlass.Name = "btnLocateOnlySouthGlass"
    Me.btnLocateOnlySouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateOnlySouthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateOnlySouthGlass.TabIndex = 166
    Me.btnLocateOnlySouthGlass.TabStop = False
    Me.btnLocateOnlySouthGlass.Text = "Locate Only"
    Me.ToolTip1.SetToolTip(Me.btnLocateOnlySouthGlass, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateOnlySouthGlass.UseVisualStyleBackColor = False
    '
    'btnLocateSouthGlass
    '
    Me.btnLocateSouthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnLocateSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnLocateSouthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnLocateSouthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLocateSouthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnLocateSouthGlass.Location = New System.Drawing.Point(5, 13)
    Me.btnLocateSouthGlass.Name = "btnLocateSouthGlass"
    Me.btnLocateSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnLocateSouthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnLocateSouthGlass.TabIndex = 61
    Me.btnLocateSouthGlass.TabStop = False
    Me.btnLocateSouthGlass.Text = "Locate w Snap"
    Me.ToolTip1.SetToolTip(Me.btnLocateSouthGlass, "Will locate the glass based on the trained model associated with the part.  Will " &
        "continuously repeat if the repeat box is checked")
    Me.btnLocateSouthGlass.UseVisualStyleBackColor = False
    '
    'btnSearchSettingsSouthGlass
    '
    Me.btnSearchSettingsSouthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnSearchSettingsSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnSearchSettingsSouthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnSearchSettingsSouthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSearchSettingsSouthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnSearchSettingsSouthGlass.Location = New System.Drawing.Point(5, 117)
    Me.btnSearchSettingsSouthGlass.Name = "btnSearchSettingsSouthGlass"
    Me.btnSearchSettingsSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnSearchSettingsSouthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnSearchSettingsSouthGlass.TabIndex = 62
    Me.btnSearchSettingsSouthGlass.Text = "Search Settings"
    Me.ToolTip1.SetToolTip(Me.btnSearchSettingsSouthGlass, "Search Settings - Advanced settings for the search process can by modified here. " &
        " Should not be modified unless completely necessary")
    Me.btnSearchSettingsSouthGlass.UseVisualStyleBackColor = False
    '
    'btnTrainNewSouthGlass
    '
    Me.btnTrainNewSouthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainNewSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainNewSouthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainNewSouthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainNewSouthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainNewSouthGlass.Location = New System.Drawing.Point(5, 91)
    Me.btnTrainNewSouthGlass.Name = "btnTrainNewSouthGlass"
    Me.btnTrainNewSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainNewSouthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainNewSouthGlass.TabIndex = 59
    Me.btnTrainNewSouthGlass.TabStop = False
    Me.btnTrainNewSouthGlass.Text = "Train New"
    Me.ToolTip1.SetToolTip(Me.btnTrainNewSouthGlass, "Train New - Discards the old model and takes a picture to teach a new one.  This " &
        "is used to locate the glass on the incoming position and determine its pick up p" &
        "oint.")
    Me.btnTrainNewSouthGlass.UseVisualStyleBackColor = False
    '
    'btnTrainExistingSouthGlass
    '
    Me.btnTrainExistingSouthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnTrainExistingSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnTrainExistingSouthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnTrainExistingSouthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnTrainExistingSouthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnTrainExistingSouthGlass.Location = New System.Drawing.Point(5, 65)
    Me.btnTrainExistingSouthGlass.Name = "btnTrainExistingSouthGlass"
    Me.btnTrainExistingSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnTrainExistingSouthGlass.Size = New System.Drawing.Size(114, 22)
    Me.btnTrainExistingSouthGlass.TabIndex = 58
    Me.btnTrainExistingSouthGlass.TabStop = False
    Me.btnTrainExistingSouthGlass.Text = "Train Existing"
    Me.ToolTip1.SetToolTip(Me.btnTrainExistingSouthGlass, "Train Existing - Edits the existing model in the database.  Changes can be made t" &
        "o the current model without discarding any previous data.")
    Me.btnTrainExistingSouthGlass.UseVisualStyleBackColor = False
    '
    'btnDetailsSouthGlass
    '
    Me.btnDetailsSouthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnDetailsSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnDetailsSouthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnDetailsSouthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDetailsSouthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnDetailsSouthGlass.Location = New System.Drawing.Point(11, 65)
    Me.btnDetailsSouthGlass.Name = "btnDetailsSouthGlass"
    Me.btnDetailsSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnDetailsSouthGlass.Size = New System.Drawing.Size(54, 24)
    Me.btnDetailsSouthGlass.TabIndex = 144
    Me.btnDetailsSouthGlass.Text = "Details"
    Me.ToolTip1.SetToolTip(Me.btnDetailsSouthGlass, "Click for the full description of the vision status of the most recent locate att" &
        "empt")
    Me.btnDetailsSouthGlass.UseVisualStyleBackColor = False
    '
    'lblVisionMessageSouthGlass
    '
    Me.lblVisionMessageSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionMessageSouthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionMessageSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionMessageSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionMessageSouthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblVisionMessageSouthGlass.Location = New System.Drawing.Point(9, 18)
    Me.lblVisionMessageSouthGlass.Name = "lblVisionMessageSouthGlass"
    Me.lblVisionMessageSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionMessageSouthGlass.Size = New System.Drawing.Size(299, 43)
    Me.lblVisionMessageSouthGlass.TabIndex = 56
    Me.lblVisionMessageSouthGlass.TextAlign = System.Drawing.ContentAlignment.TopCenter
    Me.ToolTip1.SetToolTip(Me.lblVisionMessageSouthGlass, "The status of the most recent locate attempt.  Click the Details button for more " &
        "information. ")
    '
    'TmrPassword
    '
    Me.TmrPassword.Interval = 600000
    '
    'tmrDisplayUpdate
    '
    Me.tmrDisplayUpdate.Interval = 500
    '
    'ErrorProvider1
    '
    Me.ErrorProvider1.ContainerControl = Me
    '
    'GrpRobot
    '
    Me.GrpRobot.BackColor = System.Drawing.Color.LightSteelBlue
    Me.GrpRobot.Controls.Add(Me.lblPhone)
    Me.GrpRobot.Controls.Add(Me.picLogo)
    Me.GrpRobot.Controls.Add(Me.tabCameraControls)
    Me.GrpRobot.Controls.Add(Me.grpCombinedOffset)
    Me.GrpRobot.Controls.Add(Me.grpVBErrors)
    Me.GrpRobot.Location = New System.Drawing.Point(0, 28)
    Me.GrpRobot.Name = "GrpRobot"
    Me.GrpRobot.Size = New System.Drawing.Size(1892, 1013)
    Me.GrpRobot.TabIndex = 165
    Me.GrpRobot.TabStop = False
    '
    'lblPhone
    '
    Me.lblPhone.AutoSize = True
    Me.lblPhone.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPhone.Location = New System.Drawing.Point(100, 109)
    Me.lblPhone.Name = "lblPhone"
    Me.lblPhone.Size = New System.Drawing.Size(163, 24)
    Me.lblPhone.TabIndex = 169
    Me.lblPhone.Text = "1-888-774-5306"
    '
    'picLogo
    '
    Me.picLogo.ErrorImage = CType(resources.GetObject("picLogo.ErrorImage"), System.Drawing.Image)
    Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
    Me.picLogo.InitialImage = CType(resources.GetObject("picLogo.InitialImage"), System.Drawing.Image)
    Me.picLogo.Location = New System.Drawing.Point(0, 19)
    Me.picLogo.Name = "picLogo"
    Me.picLogo.Size = New System.Drawing.Size(361, 117)
    Me.picLogo.TabIndex = 170
    Me.picLogo.TabStop = False
    '
    'tabCameraControls
    '
    Me.tabCameraControls.Controls.Add(Me.tabVisionBoth)
    Me.tabCameraControls.Controls.Add(Me.tabVisionNorth)
    Me.tabCameraControls.Controls.Add(Me.tabVisionSouth)
    Me.tabCameraControls.Controls.Add(Me.tabVisionDebug)
    Me.tabCameraControls.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tabCameraControls.Location = New System.Drawing.Point(367, 21)
    Me.tabCameraControls.Name = "tabCameraControls"
    Me.tabCameraControls.SelectedIndex = 0
    Me.tabCameraControls.Size = New System.Drawing.Size(1517, 992)
    Me.tabCameraControls.TabIndex = 165
    '
    'tabVisionBoth
    '
    Me.tabVisionBoth.BackColor = System.Drawing.SystemColors.Control
    Me.tabVisionBoth.Controls.Add(Me.lblSouthMaskScore)
    Me.tabVisionBoth.Controls.Add(Me.lblSouthGlassScore)
    Me.tabVisionBoth.Controls.Add(Me.lblNorthGlassScore)
    Me.tabVisionBoth.Controls.Add(Me.lblNorthMaskScore)
    Me.tabVisionBoth.Controls.Add(Me.GroupBox1)
    Me.tabVisionBoth.Controls.Add(Me.lblSouthGlassPlaceHolder)
    Me.tabVisionBoth.Controls.Add(Me.lblSouthMaskPlaceHolder)
    Me.tabVisionBoth.Controls.Add(Me.lblNorthGlassPlaceHolder)
    Me.tabVisionBoth.Controls.Add(Me.lblNorthMaskPlaceHolder)
    Me.tabVisionBoth.Controls.Add(Me._Frame1_1)
    Me.tabVisionBoth.Controls.Add(Me._Frame1_0)
    Me.tabVisionBoth.Controls.Add(Me.grpSouth)
    Me.tabVisionBoth.Controls.Add(Me.grpNorth)
    Me.tabVisionBoth.Location = New System.Drawing.Point(4, 25)
    Me.tabVisionBoth.Name = "tabVisionBoth"
    Me.tabVisionBoth.Size = New System.Drawing.Size(1509, 963)
    Me.tabVisionBoth.TabIndex = 2
    Me.tabVisionBoth.Text = "Both Cameras"
    '
    'lblSouthMaskScore
    '
    Me.lblSouthMaskScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblSouthMaskScore.Location = New System.Drawing.Point(1436, 264)
    Me.lblSouthMaskScore.Name = "lblSouthMaskScore"
    Me.lblSouthMaskScore.Size = New System.Drawing.Size(59, 23)
    Me.lblSouthMaskScore.TabIndex = 192
    Me.lblSouthMaskScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblSouthGlassScore
    '
    Me.lblSouthGlassScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblSouthGlassScore.Location = New System.Drawing.Point(1436, 874)
    Me.lblSouthGlassScore.Name = "lblSouthGlassScore"
    Me.lblSouthGlassScore.Size = New System.Drawing.Size(59, 23)
    Me.lblSouthGlassScore.TabIndex = 191
    Me.lblSouthGlassScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblNorthGlassScore
    '
    Me.lblNorthGlassScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblNorthGlassScore.Location = New System.Drawing.Point(9, 858)
    Me.lblNorthGlassScore.Name = "lblNorthGlassScore"
    Me.lblNorthGlassScore.Size = New System.Drawing.Size(59, 23)
    Me.lblNorthGlassScore.TabIndex = 190
    Me.lblNorthGlassScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblNorthMaskScore
    '
    Me.lblNorthMaskScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblNorthMaskScore.Location = New System.Drawing.Point(9, 217)
    Me.lblNorthMaskScore.Name = "lblNorthMaskScore"
    Me.lblNorthMaskScore.Size = New System.Drawing.Size(59, 23)
    Me.lblNorthMaskScore.TabIndex = 189
    Me.lblNorthMaskScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
    Me.GroupBox1.Controls.Add(Me.lblFinalStatus)
    Me.GroupBox1.Controls.Add(Me.btnClearMarkersBoth)
    Me.GroupBox1.Controls.Add(Me.chkRepeatSnapBoth)
    Me.GroupBox1.Controls.Add(Me.btnSnapBoth)
    Me.GroupBox1.Controls.Add(Me.btnLocateBoth)
    Me.GroupBox1.Controls.Add(Me.chkRepeatLocateBoth)
    Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
    Me.GroupBox1.Location = New System.Drawing.Point(627, 16)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
    Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.GroupBox1.Size = New System.Drawing.Size(277, 142)
    Me.GroupBox1.TabIndex = 188
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Locator Controls"
    '
    'lblFinalStatus
    '
    Me.lblFinalStatus.BackColor = System.Drawing.SystemColors.Control
    Me.lblFinalStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblFinalStatus.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblFinalStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFinalStatus.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblFinalStatus.Location = New System.Drawing.Point(7, 106)
    Me.lblFinalStatus.Name = "lblFinalStatus"
    Me.lblFinalStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblFinalStatus.Size = New System.Drawing.Size(264, 29)
    Me.lblFinalStatus.TabIndex = 161
    Me.lblFinalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'chkRepeatSnapBoth
    '
    Me.chkRepeatSnapBoth.BackColor = System.Drawing.SystemColors.Control
    Me.chkRepeatSnapBoth.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkRepeatSnapBoth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkRepeatSnapBoth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkRepeatSnapBoth.Location = New System.Drawing.Point(148, 46)
    Me.chkRepeatSnapBoth.Name = "chkRepeatSnapBoth"
    Me.chkRepeatSnapBoth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkRepeatSnapBoth.Size = New System.Drawing.Size(64, 24)
    Me.chkRepeatSnapBoth.TabIndex = 159
    Me.chkRepeatSnapBoth.TabStop = False
    Me.chkRepeatSnapBoth.Text = "Repeat"
    Me.chkRepeatSnapBoth.UseVisualStyleBackColor = False
    '
    'chkRepeatLocateBoth
    '
    Me.chkRepeatLocateBoth.BackColor = System.Drawing.SystemColors.Control
    Me.chkRepeatLocateBoth.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkRepeatLocateBoth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkRepeatLocateBoth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkRepeatLocateBoth.Location = New System.Drawing.Point(149, 14)
    Me.chkRepeatLocateBoth.Name = "chkRepeatLocateBoth"
    Me.chkRepeatLocateBoth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkRepeatLocateBoth.Size = New System.Drawing.Size(64, 24)
    Me.chkRepeatLocateBoth.TabIndex = 60
    Me.chkRepeatLocateBoth.TabStop = False
    Me.chkRepeatLocateBoth.Text = "Repeat"
    Me.chkRepeatLocateBoth.UseVisualStyleBackColor = False
    '
    'lblSouthGlassPlaceHolder
    '
    Me.lblSouthGlassPlaceHolder.BackColor = System.Drawing.SystemColors.Control
    Me.lblSouthGlassPlaceHolder.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblSouthGlassPlaceHolder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSouthGlassPlaceHolder.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblSouthGlassPlaceHolder.Location = New System.Drawing.Point(1445, 861)
    Me.lblSouthGlassPlaceHolder.Name = "lblSouthGlassPlaceHolder"
    Me.lblSouthGlassPlaceHolder.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblSouthGlassPlaceHolder.Size = New System.Drawing.Size(50, 13)
    Me.lblSouthGlassPlaceHolder.TabIndex = 187
    Me.lblSouthGlassPlaceHolder.Text = "Glass Score"
    '
    'lblSouthMaskPlaceHolder
    '
    Me.lblSouthMaskPlaceHolder.BackColor = System.Drawing.SystemColors.Control
    Me.lblSouthMaskPlaceHolder.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblSouthMaskPlaceHolder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSouthMaskPlaceHolder.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblSouthMaskPlaceHolder.Location = New System.Drawing.Point(1447, 247)
    Me.lblSouthMaskPlaceHolder.Name = "lblSouthMaskPlaceHolder"
    Me.lblSouthMaskPlaceHolder.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblSouthMaskPlaceHolder.Size = New System.Drawing.Size(48, 14)
    Me.lblSouthMaskPlaceHolder.TabIndex = 185
    Me.lblSouthMaskPlaceHolder.Text = "Mask Score"
    '
    'lblNorthGlassPlaceHolder
    '
    Me.lblNorthGlassPlaceHolder.BackColor = System.Drawing.SystemColors.Control
    Me.lblNorthGlassPlaceHolder.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblNorthGlassPlaceHolder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNorthGlassPlaceHolder.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblNorthGlassPlaceHolder.Location = New System.Drawing.Point(20, 844)
    Me.lblNorthGlassPlaceHolder.Name = "lblNorthGlassPlaceHolder"
    Me.lblNorthGlassPlaceHolder.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblNorthGlassPlaceHolder.Size = New System.Drawing.Size(48, 14)
    Me.lblNorthGlassPlaceHolder.TabIndex = 182
    Me.lblNorthGlassPlaceHolder.Text = "Glass Score"
    '
    'lblNorthMaskPlaceHolder
    '
    Me.lblNorthMaskPlaceHolder.BackColor = System.Drawing.SystemColors.Control
    Me.lblNorthMaskPlaceHolder.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblNorthMaskPlaceHolder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNorthMaskPlaceHolder.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblNorthMaskPlaceHolder.Location = New System.Drawing.Point(21, 203)
    Me.lblNorthMaskPlaceHolder.Name = "lblNorthMaskPlaceHolder"
    Me.lblNorthMaskPlaceHolder.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblNorthMaskPlaceHolder.Size = New System.Drawing.Size(39, 14)
    Me.lblNorthMaskPlaceHolder.TabIndex = 179
    Me.lblNorthMaskPlaceHolder.Text = "Score"
    '
    '_Frame1_1
    '
    Me._Frame1_1.BackColor = System.Drawing.SystemColors.Control
    Me._Frame1_1.Controls.Add(Me.txtSouthSecondClick)
    Me._Frame1_1.Controls.Add(Me.txtSouthFirstClick)
    Me._Frame1_1.Controls.Add(Me.txtSouthDistance)
    Me._Frame1_1.Controls.Add(Me._lblPoint_5)
    Me._Frame1_1.Controls.Add(Me._lblPoint_4)
    Me._Frame1_1.Controls.Add(Me._lblPoint_3)
    Me._Frame1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._Frame1_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Frame1_1.Location = New System.Drawing.Point(1246, 67)
    Me._Frame1_1.Name = "_Frame1_1"
    Me._Frame1_1.Padding = New System.Windows.Forms.Padding(0)
    Me._Frame1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Frame1_1.Size = New System.Drawing.Size(260, 91)
    Me._Frame1_1.TabIndex = 175
    Me._Frame1_1.TabStop = False
    Me._Frame1_1.Text = "Distance Measurement (Double Click on Display)"
    '
    'txtSouthSecondClick
    '
    Me.txtSouthSecondClick.AcceptsReturn = True
    Me.txtSouthSecondClick.BackColor = System.Drawing.SystemColors.Window
    Me.txtSouthSecondClick.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtSouthSecondClick.Enabled = False
    Me.txtSouthSecondClick.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSouthSecondClick.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtSouthSecondClick.Location = New System.Drawing.Point(94, 38)
    Me.txtSouthSecondClick.MaxLength = 0
    Me.txtSouthSecondClick.Name = "txtSouthSecondClick"
    Me.txtSouthSecondClick.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtSouthSecondClick.Size = New System.Drawing.Size(85, 20)
    Me.txtSouthSecondClick.TabIndex = 124
    '
    'txtSouthFirstClick
    '
    Me.txtSouthFirstClick.AcceptsReturn = True
    Me.txtSouthFirstClick.BackColor = System.Drawing.SystemColors.Window
    Me.txtSouthFirstClick.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtSouthFirstClick.Enabled = False
    Me.txtSouthFirstClick.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSouthFirstClick.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtSouthFirstClick.Location = New System.Drawing.Point(94, 14)
    Me.txtSouthFirstClick.MaxLength = 0
    Me.txtSouthFirstClick.Name = "txtSouthFirstClick"
    Me.txtSouthFirstClick.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtSouthFirstClick.Size = New System.Drawing.Size(85, 20)
    Me.txtSouthFirstClick.TabIndex = 123
    '
    'txtSouthDistance
    '
    Me.txtSouthDistance.AcceptsReturn = True
    Me.txtSouthDistance.BackColor = System.Drawing.SystemColors.Window
    Me.txtSouthDistance.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtSouthDistance.Enabled = False
    Me.txtSouthDistance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSouthDistance.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtSouthDistance.Location = New System.Drawing.Point(94, 62)
    Me.txtSouthDistance.MaxLength = 0
    Me.txtSouthDistance.Name = "txtSouthDistance"
    Me.txtSouthDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtSouthDistance.Size = New System.Drawing.Size(85, 20)
    Me.txtSouthDistance.TabIndex = 122
    '
    '_lblPoint_5
    '
    Me._lblPoint_5.BackColor = System.Drawing.SystemColors.Control
    Me._lblPoint_5.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblPoint_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblPoint_5.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblPoint_5.Location = New System.Drawing.Point(14, 43)
    Me._lblPoint_5.Name = "_lblPoint_5"
    Me._lblPoint_5.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblPoint_5.Size = New System.Drawing.Size(69, 27)
    Me._lblPoint_5.TabIndex = 127
    Me._lblPoint_5.Text = "Second Click"
    Me._lblPoint_5.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    '_lblPoint_4
    '
    Me._lblPoint_4.BackColor = System.Drawing.SystemColors.Control
    Me._lblPoint_4.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblPoint_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblPoint_4.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblPoint_4.Location = New System.Drawing.Point(28, 20)
    Me._lblPoint_4.Name = "_lblPoint_4"
    Me._lblPoint_4.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblPoint_4.Size = New System.Drawing.Size(55, 21)
    Me._lblPoint_4.TabIndex = 126
    Me._lblPoint_4.Text = "First Click"
    Me._lblPoint_4.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    '_lblPoint_3
    '
    Me._lblPoint_3.BackColor = System.Drawing.SystemColors.Control
    Me._lblPoint_3.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblPoint_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblPoint_3.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblPoint_3.Location = New System.Drawing.Point(33, 68)
    Me._lblPoint_3.Name = "_lblPoint_3"
    Me._lblPoint_3.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblPoint_3.Size = New System.Drawing.Size(50, 21)
    Me._lblPoint_3.TabIndex = 125
    Me._lblPoint_3.Text = "Distance"
    Me._lblPoint_3.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    '_Frame1_0
    '
    Me._Frame1_0.BackColor = System.Drawing.SystemColors.Control
    Me._Frame1_0.Controls.Add(Me.txtCombinedOneHalf)
    Me._Frame1_0.Controls.Add(Me.txtNorthDistance)
    Me._Frame1_0.Controls.Add(Me.txtNorthFirstClick)
    Me._Frame1_0.Controls.Add(Me.txtNorthSecondClick)
    Me._Frame1_0.Controls.Add(Me.Label5)
    Me._Frame1_0.Controls.Add(Me._lblPoint_2)
    Me._Frame1_0.Controls.Add(Me._lblPoint_0)
    Me._Frame1_0.Controls.Add(Me._lblPoint_1)
    Me._Frame1_0.Font = New System.Drawing.Font("Arial", 8.0!)
    Me._Frame1_0.ForeColor = System.Drawing.Color.Navy
    Me._Frame1_0.Location = New System.Drawing.Point(14, 67)
    Me._Frame1_0.Name = "_Frame1_0"
    Me._Frame1_0.Padding = New System.Windows.Forms.Padding(0)
    Me._Frame1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Frame1_0.Size = New System.Drawing.Size(255, 91)
    Me._Frame1_0.TabIndex = 174
    Me._Frame1_0.TabStop = False
    Me._Frame1_0.Text = "Distance Measurement (Double Click on Display)"
    '
    'txtCombinedOneHalf
    '
    Me.txtCombinedOneHalf.AcceptsReturn = True
    Me.txtCombinedOneHalf.BackColor = System.Drawing.SystemColors.Window
    Me.txtCombinedOneHalf.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtCombinedOneHalf.Enabled = False
    Me.txtCombinedOneHalf.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCombinedOneHalf.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtCombinedOneHalf.Location = New System.Drawing.Point(184, 62)
    Me.txtCombinedOneHalf.MaxLength = 0
    Me.txtCombinedOneHalf.Name = "txtCombinedOneHalf"
    Me.txtCombinedOneHalf.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtCombinedOneHalf.Size = New System.Drawing.Size(45, 20)
    Me.txtCombinedOneHalf.TabIndex = 180
    '
    'txtNorthDistance
    '
    Me.txtNorthDistance.AcceptsReturn = True
    Me.txtNorthDistance.BackColor = System.Drawing.SystemColors.Window
    Me.txtNorthDistance.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtNorthDistance.Enabled = False
    Me.txtNorthDistance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNorthDistance.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtNorthDistance.Location = New System.Drawing.Point(94, 62)
    Me.txtNorthDistance.MaxLength = 0
    Me.txtNorthDistance.Name = "txtNorthDistance"
    Me.txtNorthDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtNorthDistance.Size = New System.Drawing.Size(85, 20)
    Me.txtNorthDistance.TabIndex = 116
    '
    'txtNorthFirstClick
    '
    Me.txtNorthFirstClick.AcceptsReturn = True
    Me.txtNorthFirstClick.BackColor = System.Drawing.SystemColors.Window
    Me.txtNorthFirstClick.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtNorthFirstClick.Enabled = False
    Me.txtNorthFirstClick.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNorthFirstClick.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtNorthFirstClick.Location = New System.Drawing.Point(94, 14)
    Me.txtNorthFirstClick.MaxLength = 0
    Me.txtNorthFirstClick.Name = "txtNorthFirstClick"
    Me.txtNorthFirstClick.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtNorthFirstClick.Size = New System.Drawing.Size(85, 20)
    Me.txtNorthFirstClick.TabIndex = 113
    '
    'txtNorthSecondClick
    '
    Me.txtNorthSecondClick.AcceptsReturn = True
    Me.txtNorthSecondClick.BackColor = System.Drawing.SystemColors.Window
    Me.txtNorthSecondClick.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtNorthSecondClick.Enabled = False
    Me.txtNorthSecondClick.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNorthSecondClick.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtNorthSecondClick.Location = New System.Drawing.Point(94, 38)
    Me.txtNorthSecondClick.MaxLength = 0
    Me.txtNorthSecondClick.Name = "txtNorthSecondClick"
    Me.txtNorthSecondClick.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtNorthSecondClick.Size = New System.Drawing.Size(85, 20)
    Me.txtNorthSecondClick.TabIndex = 112
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.SystemColors.Control
    Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label5.Location = New System.Drawing.Point(184, 20)
    Me.Label5.Name = "Label5"
    Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label5.Size = New System.Drawing.Size(59, 41)
    Me.Label5.TabIndex = 179
    Me.Label5.Text = "One Half of Distance Difference"
    '
    '_lblPoint_2
    '
    Me._lblPoint_2.BackColor = System.Drawing.SystemColors.Control
    Me._lblPoint_2.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblPoint_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblPoint_2.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblPoint_2.Location = New System.Drawing.Point(33, 64)
    Me._lblPoint_2.Name = "_lblPoint_2"
    Me._lblPoint_2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblPoint_2.Size = New System.Drawing.Size(50, 21)
    Me._lblPoint_2.TabIndex = 117
    Me._lblPoint_2.Text = "Distance"
    Me._lblPoint_2.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    '_lblPoint_0
    '
    Me._lblPoint_0.BackColor = System.Drawing.SystemColors.Control
    Me._lblPoint_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblPoint_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblPoint_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblPoint_0.Location = New System.Drawing.Point(28, 20)
    Me._lblPoint_0.Name = "_lblPoint_0"
    Me._lblPoint_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblPoint_0.Size = New System.Drawing.Size(55, 21)
    Me._lblPoint_0.TabIndex = 115
    Me._lblPoint_0.Text = "First Click"
    Me._lblPoint_0.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    '_lblPoint_1
    '
    Me._lblPoint_1.BackColor = System.Drawing.SystemColors.Control
    Me._lblPoint_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblPoint_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblPoint_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblPoint_1.Location = New System.Drawing.Point(14, 42)
    Me._lblPoint_1.Name = "_lblPoint_1"
    Me._lblPoint_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblPoint_1.Size = New System.Drawing.Size(69, 27)
    Me._lblPoint_1.TabIndex = 114
    Me._lblPoint_1.Text = "Second Click"
    Me._lblPoint_1.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'grpSouth
    '
    Me.grpSouth.Location = New System.Drawing.Point(759, 163)
    Me.grpSouth.Name = "grpSouth"
    Me.grpSouth.Size = New System.Drawing.Size(666, 791)
    Me.grpSouth.TabIndex = 172
    Me.grpSouth.TabStop = False
    Me.grpSouth.Text = "South Camera"
    '
    'grpNorth
    '
    Me.grpNorth.Location = New System.Drawing.Point(76, 164)
    Me.grpNorth.Name = "grpNorth"
    Me.grpNorth.Size = New System.Drawing.Size(667, 790)
    Me.grpNorth.TabIndex = 171
    Me.grpNorth.TabStop = False
    Me.grpNorth.Text = "North Camera"
    '
    'tabVisionNorth
    '
    Me.tabVisionNorth.Controls.Add(Me.grpVisionNorth)
    Me.tabVisionNorth.Location = New System.Drawing.Point(4, 25)
    Me.tabVisionNorth.Name = "tabVisionNorth"
    Me.tabVisionNorth.Padding = New System.Windows.Forms.Padding(3)
    Me.tabVisionNorth.Size = New System.Drawing.Size(1509, 963)
    Me.tabVisionNorth.TabIndex = 0
    Me.tabVisionNorth.Text = "North Camera"
    Me.tabVisionNorth.UseVisualStyleBackColor = True
    '
    'grpVisionNorth
    '
    Me.grpVisionNorth.BackColor = System.Drawing.SystemColors.Control
    Me.grpVisionNorth.Controls.Add(Me.grpVisionStatusNorthMask)
    Me.grpVisionNorth.Controls.Add(Me.GroupBox2)
    Me.grpVisionNorth.Controls.Add(Me.GroupBox6)
    Me.grpVisionNorth.Controls.Add(Me.grpCameraControlsNorth)
    Me.grpVisionNorth.Controls.Add(Me.grpVisionStatusNorthGlass)
    Me.grpVisionNorth.Controls.Add(Me.grpHSDisplayNorth)
    Me.grpVisionNorth.Controls.Add(Me.grpLocatorControlsNorth)
    Me.grpVisionNorth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpVisionNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grpVisionNorth.Location = New System.Drawing.Point(1, 4)
    Me.grpVisionNorth.Name = "grpVisionNorth"
    Me.grpVisionNorth.Padding = New System.Windows.Forms.Padding(0)
    Me.grpVisionNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpVisionNorth.Size = New System.Drawing.Size(1508, 947)
    Me.grpVisionNorth.TabIndex = 49
    Me.grpVisionNorth.TabStop = False
    '
    'grpVisionStatusNorthMask
    '
    Me.grpVisionStatusNorthMask.BackColor = System.Drawing.SystemColors.Control
    Me.grpVisionStatusNorthMask.Controls.Add(Me.lblScoreLimitNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.updnScoreLimitNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.lblVisionPoseScoreNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.lblVisionPoseTimeNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.lblVisionPoseRNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.lblVisionPoseYNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.lblVisionPoseXNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.btnDetailsNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.lblVisionMessageNorthMask)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.Label38)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.Label39)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.Label40)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.Label41)
    Me.grpVisionStatusNorthMask.Controls.Add(Me.Label42)
    Me.grpVisionStatusNorthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpVisionStatusNorthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpVisionStatusNorthMask.Location = New System.Drawing.Point(213, 178)
    Me.grpVisionStatusNorthMask.Name = "grpVisionStatusNorthMask"
    Me.grpVisionStatusNorthMask.Padding = New System.Windows.Forms.Padding(0)
    Me.grpVisionStatusNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpVisionStatusNorthMask.Size = New System.Drawing.Size(320, 151)
    Me.grpVisionStatusNorthMask.TabIndex = 86
    Me.grpVisionStatusNorthMask.TabStop = False
    Me.grpVisionStatusNorthMask.Text = "Status"
    '
    'lblScoreLimitNorthMask
    '
    Me.lblScoreLimitNorthMask.AutoSize = True
    Me.lblScoreLimitNorthMask.Location = New System.Drawing.Point(184, 75)
    Me.lblScoreLimitNorthMask.Name = "lblScoreLimitNorthMask"
    Me.lblScoreLimitNorthMask.Size = New System.Drawing.Size(70, 14)
    Me.lblScoreLimitNorthMask.TabIndex = 160
    Me.lblScoreLimitNorthMask.Text = "Score Limit"
    '
    'updnScoreLimitNorthMask
    '
    Me.updnScoreLimitNorthMask.Enabled = False
    Me.updnScoreLimitNorthMask.Location = New System.Drawing.Point(258, 73)
    Me.updnScoreLimitNorthMask.Minimum = New Decimal(New Integer() {75, 0, 0, 0})
    Me.updnScoreLimitNorthMask.Name = "updnScoreLimitNorthMask"
    Me.updnScoreLimitNorthMask.Size = New System.Drawing.Size(49, 20)
    Me.updnScoreLimitNorthMask.TabIndex = 159
    Me.updnScoreLimitNorthMask.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnScoreLimitNorthMask.Value = New Decimal(New Integer() {75, 0, 0, 0})
    '
    'lblVisionPoseScoreNorthMask
    '
    Me.lblVisionPoseScoreNorthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseScoreNorthMask.Location = New System.Drawing.Point(249, 114)
    Me.lblVisionPoseScoreNorthMask.Name = "lblVisionPoseScoreNorthMask"
    Me.lblVisionPoseScoreNorthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseScoreNorthMask.TabIndex = 149
    '
    'lblVisionPoseTimeNorthMask
    '
    Me.lblVisionPoseTimeNorthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseTimeNorthMask.Location = New System.Drawing.Point(189, 114)
    Me.lblVisionPoseTimeNorthMask.Name = "lblVisionPoseTimeNorthMask"
    Me.lblVisionPoseTimeNorthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseTimeNorthMask.TabIndex = 148
    '
    'lblVisionPoseRNorthMask
    '
    Me.lblVisionPoseRNorthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseRNorthMask.Location = New System.Drawing.Point(129, 114)
    Me.lblVisionPoseRNorthMask.Name = "lblVisionPoseRNorthMask"
    Me.lblVisionPoseRNorthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseRNorthMask.TabIndex = 147
    '
    'lblVisionPoseYNorthMask
    '
    Me.lblVisionPoseYNorthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseYNorthMask.Location = New System.Drawing.Point(69, 114)
    Me.lblVisionPoseYNorthMask.Name = "lblVisionPoseYNorthMask"
    Me.lblVisionPoseYNorthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseYNorthMask.TabIndex = 146
    '
    'lblVisionPoseXNorthMask
    '
    Me.lblVisionPoseXNorthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseXNorthMask.Location = New System.Drawing.Point(9, 114)
    Me.lblVisionPoseXNorthMask.Name = "lblVisionPoseXNorthMask"
    Me.lblVisionPoseXNorthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseXNorthMask.TabIndex = 145
    '
    'btnDetailsNorthMask
    '
    Me.btnDetailsNorthMask.BackColor = System.Drawing.Color.Transparent
    Me.btnDetailsNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnDetailsNorthMask.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnDetailsNorthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDetailsNorthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnDetailsNorthMask.Location = New System.Drawing.Point(11, 65)
    Me.btnDetailsNorthMask.Name = "btnDetailsNorthMask"
    Me.btnDetailsNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnDetailsNorthMask.Size = New System.Drawing.Size(54, 24)
    Me.btnDetailsNorthMask.TabIndex = 144
    Me.btnDetailsNorthMask.Text = "Details"
    Me.btnDetailsNorthMask.UseVisualStyleBackColor = False
    '
    'lblVisionMessageNorthMask
    '
    Me.lblVisionMessageNorthMask.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionMessageNorthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionMessageNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionMessageNorthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionMessageNorthMask.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblVisionMessageNorthMask.Location = New System.Drawing.Point(11, 17)
    Me.lblVisionMessageNorthMask.Name = "lblVisionMessageNorthMask"
    Me.lblVisionMessageNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionMessageNorthMask.Size = New System.Drawing.Size(299, 43)
    Me.lblVisionMessageNorthMask.TabIndex = 56
    Me.lblVisionMessageNorthMask.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label38
    '
    Me.Label38.BackColor = System.Drawing.SystemColors.Control
    Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label38.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label38.Location = New System.Drawing.Point(27, 95)
    Me.Label38.Name = "Label38"
    Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label38.Size = New System.Drawing.Size(34, 17)
    Me.Label38.TabIndex = 55
    Me.Label38.Text = "X"
    '
    'Label39
    '
    Me.Label39.BackColor = System.Drawing.SystemColors.Control
    Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label39.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label39.Location = New System.Drawing.Point(87, 95)
    Me.Label39.Name = "Label39"
    Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label39.Size = New System.Drawing.Size(34, 17)
    Me.Label39.TabIndex = 54
    Me.Label39.Text = "Y"
    '
    'Label40
    '
    Me.Label40.BackColor = System.Drawing.SystemColors.Control
    Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label40.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label40.Location = New System.Drawing.Point(138, 95)
    Me.Label40.Name = "Label40"
    Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label40.Size = New System.Drawing.Size(50, 17)
    Me.Label40.TabIndex = 53
    Me.Label40.Text = "Angle"
    '
    'Label41
    '
    Me.Label41.BackColor = System.Drawing.SystemColors.Control
    Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label41.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label41.Location = New System.Drawing.Point(199, 95)
    Me.Label41.Name = "Label41"
    Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label41.Size = New System.Drawing.Size(50, 17)
    Me.Label41.TabIndex = 52
    Me.Label41.Text = "Time"
    '
    'Label42
    '
    Me.Label42.BackColor = System.Drawing.SystemColors.Control
    Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label42.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label42.Location = New System.Drawing.Point(258, 95)
    Me.Label42.Name = "Label42"
    Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label42.Size = New System.Drawing.Size(50, 17)
    Me.Label42.TabIndex = 50
    Me.Label42.Text = "Score"
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
    Me.GroupBox2.Controls.Add(Me.btnSearchSettingsNorthMask)
    Me.GroupBox2.Controls.Add(Me.btnTrainNewNorthMask)
    Me.GroupBox2.Controls.Add(Me.btnTrainExistingNorthMask)
    Me.GroupBox2.Controls.Add(Me.btnLocateOnlyNorthMask)
    Me.GroupBox2.Controls.Add(Me.btnLocateNorthMask)
    Me.GroupBox2.Controls.Add(Me.chkLocateRepeatNorthMask)
    Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
    Me.GroupBox2.Location = New System.Drawing.Point(5, 178)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
    Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.GroupBox2.Size = New System.Drawing.Size(195, 151)
    Me.GroupBox2.TabIndex = 85
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Locator Controls for Mask"
    '
    'chkLocateRepeatNorthMask
    '
    Me.chkLocateRepeatNorthMask.BackColor = System.Drawing.SystemColors.Control
    Me.chkLocateRepeatNorthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkLocateRepeatNorthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkLocateRepeatNorthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkLocateRepeatNorthMask.Location = New System.Drawing.Point(125, 14)
    Me.chkLocateRepeatNorthMask.Name = "chkLocateRepeatNorthMask"
    Me.chkLocateRepeatNorthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkLocateRepeatNorthMask.Size = New System.Drawing.Size(61, 24)
    Me.chkLocateRepeatNorthMask.TabIndex = 60
    Me.chkLocateRepeatNorthMask.TabStop = False
    Me.chkLocateRepeatNorthMask.Text = "Repeat"
    Me.chkLocateRepeatNorthMask.UseVisualStyleBackColor = False
    '
    'GroupBox6
    '
    Me.GroupBox6.Controls.Add(Me.lblCameraStatusNorth)
    Me.GroupBox6.Controls.Add(Me.lblTemperatureNorth)
    Me.GroupBox6.Controls.Add(Me.pctTemperatureNorth)
    Me.GroupBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GroupBox6.ForeColor = System.Drawing.SystemColors.Highlight
    Me.GroupBox6.Location = New System.Drawing.Point(5, 9)
    Me.GroupBox6.Name = "GroupBox6"
    Me.GroupBox6.Size = New System.Drawing.Size(173, 151)
    Me.GroupBox6.TabIndex = 84
    Me.GroupBox6.TabStop = False
    Me.GroupBox6.Text = "Camera Status"
    '
    'lblCameraStatusNorth
    '
    Me.lblCameraStatusNorth.AutoSize = True
    Me.lblCameraStatusNorth.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCameraStatusNorth.ForeColor = System.Drawing.Color.DarkRed
    Me.lblCameraStatusNorth.Location = New System.Drawing.Point(37, 21)
    Me.lblCameraStatusNorth.Name = "lblCameraStatusNorth"
    Me.lblCameraStatusNorth.Size = New System.Drawing.Size(114, 51)
    Me.lblCameraStatusNorth.TabIndex = 159
    Me.lblCameraStatusNorth.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
    Me.lblCameraStatusNorth.Visible = False
    '
    'lblTemperatureNorth
    '
    Me.lblTemperatureNorth.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.lblTemperatureNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblTemperatureNorth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTemperatureNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblTemperatureNorth.Location = New System.Drawing.Point(6, 97)
    Me.lblTemperatureNorth.Name = "lblTemperatureNorth"
    Me.lblTemperatureNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblTemperatureNorth.Size = New System.Drawing.Size(39, 48)
    Me.lblTemperatureNorth.TabIndex = 158
    Me.lblTemperatureNorth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'pctTemperatureNorth
    '
    Me.pctTemperatureNorth.Image = CType(resources.GetObject("pctTemperatureNorth.Image"), System.Drawing.Image)
    Me.pctTemperatureNorth.Location = New System.Drawing.Point(11, 32)
    Me.pctTemperatureNorth.Name = "pctTemperatureNorth"
    Me.pctTemperatureNorth.Size = New System.Drawing.Size(25, 60)
    Me.pctTemperatureNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pctTemperatureNorth.TabIndex = 157
    Me.pctTemperatureNorth.TabStop = False
    '
    'grpCameraControlsNorth
    '
    Me.grpCameraControlsNorth.BackColor = System.Drawing.SystemColors.Control
    Me.grpCameraControlsNorth.Controls.Add(Me.Label12)
    Me.grpCameraControlsNorth.Controls.Add(Me.lblContrastValueNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.lblBrightnessValueNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.lblExposureValueNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.lblContrastNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.lblExposureNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.updnContrastNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.updnExposureNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.btnSnapNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.chkSnapRepeatNorth)
    Me.grpCameraControlsNorth.Controls.Add(Me.lblCameraTimeNorth)
    Me.grpCameraControlsNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpCameraControlsNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpCameraControlsNorth.Location = New System.Drawing.Point(184, 9)
    Me.grpCameraControlsNorth.Name = "grpCameraControlsNorth"
    Me.grpCameraControlsNorth.Padding = New System.Windows.Forms.Padding(0)
    Me.grpCameraControlsNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpCameraControlsNorth.Size = New System.Drawing.Size(187, 151)
    Me.grpCameraControlsNorth.TabIndex = 68
    Me.grpCameraControlsNorth.TabStop = False
    Me.grpCameraControlsNorth.Text = "Camera Controls"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(36, 54)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(59, 14)
    Me.Label12.TabIndex = 164
    Me.Label12.Text = "Acq Time"
    '
    'lblContrastValueNorth
    '
    Me.lblContrastValueNorth.AutoSize = True
    Me.lblContrastValueNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblContrastValueNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblContrastValueNorth.Location = New System.Drawing.Point(178, 114)
    Me.lblContrastValueNorth.Name = "lblContrastValueNorth"
    Me.lblContrastValueNorth.Size = New System.Drawing.Size(0, 14)
    Me.lblContrastValueNorth.TabIndex = 153
    '
    'lblBrightnessValueNorth
    '
    Me.lblBrightnessValueNorth.AutoSize = True
    Me.lblBrightnessValueNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBrightnessValueNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblBrightnessValueNorth.Location = New System.Drawing.Point(178, 82)
    Me.lblBrightnessValueNorth.Name = "lblBrightnessValueNorth"
    Me.lblBrightnessValueNorth.Size = New System.Drawing.Size(0, 14)
    Me.lblBrightnessValueNorth.TabIndex = 152
    '
    'lblExposureValueNorth
    '
    Me.lblExposureValueNorth.AutoSize = True
    Me.lblExposureValueNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblExposureValueNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblExposureValueNorth.Location = New System.Drawing.Point(178, 54)
    Me.lblExposureValueNorth.Name = "lblExposureValueNorth"
    Me.lblExposureValueNorth.Size = New System.Drawing.Size(0, 14)
    Me.lblExposureValueNorth.TabIndex = 151
    '
    'lblContrastNorth
    '
    Me.lblContrastNorth.AutoSize = True
    Me.lblContrastNorth.Location = New System.Drawing.Point(40, 99)
    Me.lblContrastNorth.Name = "lblContrastNorth"
    Me.lblContrastNorth.Size = New System.Drawing.Size(55, 14)
    Me.lblContrastNorth.TabIndex = 148
    Me.lblContrastNorth.Text = "Contrast"
    '
    'lblExposureNorth
    '
    Me.lblExposureNorth.AutoSize = True
    Me.lblExposureNorth.Location = New System.Drawing.Point(36, 77)
    Me.lblExposureNorth.Name = "lblExposureNorth"
    Me.lblExposureNorth.Size = New System.Drawing.Size(59, 14)
    Me.lblExposureNorth.TabIndex = 146
    Me.lblExposureNorth.Text = "Exposure"
    '
    'chkSnapRepeatNorth
    '
    Me.chkSnapRepeatNorth.BackColor = System.Drawing.SystemColors.Control
    Me.chkSnapRepeatNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkSnapRepeatNorth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkSnapRepeatNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkSnapRepeatNorth.Location = New System.Drawing.Point(115, 14)
    Me.chkSnapRepeatNorth.Name = "chkSnapRepeatNorth"
    Me.chkSnapRepeatNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkSnapRepeatNorth.Size = New System.Drawing.Size(69, 24)
    Me.chkSnapRepeatNorth.TabIndex = 72
    Me.chkSnapRepeatNorth.TabStop = False
    Me.chkSnapRepeatNorth.Text = "Repeat"
    Me.chkSnapRepeatNorth.UseVisualStyleBackColor = False
    '
    'lblCameraTimeNorth
    '
    Me.lblCameraTimeNorth.BackColor = System.Drawing.SystemColors.Control
    Me.lblCameraTimeNorth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblCameraTimeNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblCameraTimeNorth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCameraTimeNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblCameraTimeNorth.Location = New System.Drawing.Point(101, 52)
    Me.lblCameraTimeNorth.Name = "lblCameraTimeNorth"
    Me.lblCameraTimeNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblCameraTimeNorth.Size = New System.Drawing.Size(48, 18)
    Me.lblCameraTimeNorth.TabIndex = 75
    '
    'grpVisionStatusNorthGlass
    '
    Me.grpVisionStatusNorthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblScoreLimitNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.updnScoreLimitNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionPoseScoreNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionPoseTimeNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionPoseRNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionPoseYNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionPoseXNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.btnDetailsNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionMessageNorthGlass)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionXNorth)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionYNorth)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionAngleNorth)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionTimeNorth)
    Me.grpVisionStatusNorthGlass.Controls.Add(Me.lblVisionScoreNorth)
    Me.grpVisionStatusNorthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpVisionStatusNorthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpVisionStatusNorthGlass.Location = New System.Drawing.Point(207, 538)
    Me.grpVisionStatusNorthGlass.Name = "grpVisionStatusNorthGlass"
    Me.grpVisionStatusNorthGlass.Padding = New System.Windows.Forms.Padding(0)
    Me.grpVisionStatusNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpVisionStatusNorthGlass.Size = New System.Drawing.Size(320, 151)
    Me.grpVisionStatusNorthGlass.TabIndex = 48
    Me.grpVisionStatusNorthGlass.TabStop = False
    Me.grpVisionStatusNorthGlass.Text = "Status"
    '
    'lblScoreLimitNorthGlass
    '
    Me.lblScoreLimitNorthGlass.AutoSize = True
    Me.lblScoreLimitNorthGlass.Location = New System.Drawing.Point(184, 70)
    Me.lblScoreLimitNorthGlass.Name = "lblScoreLimitNorthGlass"
    Me.lblScoreLimitNorthGlass.Size = New System.Drawing.Size(70, 14)
    Me.lblScoreLimitNorthGlass.TabIndex = 162
    Me.lblScoreLimitNorthGlass.Text = "Score Limit"
    '
    'updnScoreLimitNorthGlass
    '
    Me.updnScoreLimitNorthGlass.Enabled = False
    Me.updnScoreLimitNorthGlass.Location = New System.Drawing.Point(258, 68)
    Me.updnScoreLimitNorthGlass.Minimum = New Decimal(New Integer() {75, 0, 0, 0})
    Me.updnScoreLimitNorthGlass.Name = "updnScoreLimitNorthGlass"
    Me.updnScoreLimitNorthGlass.Size = New System.Drawing.Size(49, 20)
    Me.updnScoreLimitNorthGlass.TabIndex = 161
    Me.updnScoreLimitNorthGlass.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnScoreLimitNorthGlass.Value = New Decimal(New Integer() {75, 0, 0, 0})
    '
    'lblVisionPoseScoreNorthGlass
    '
    Me.lblVisionPoseScoreNorthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseScoreNorthGlass.Location = New System.Drawing.Point(249, 114)
    Me.lblVisionPoseScoreNorthGlass.Name = "lblVisionPoseScoreNorthGlass"
    Me.lblVisionPoseScoreNorthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseScoreNorthGlass.TabIndex = 149
    '
    'lblVisionPoseTimeNorthGlass
    '
    Me.lblVisionPoseTimeNorthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseTimeNorthGlass.Location = New System.Drawing.Point(189, 114)
    Me.lblVisionPoseTimeNorthGlass.Name = "lblVisionPoseTimeNorthGlass"
    Me.lblVisionPoseTimeNorthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseTimeNorthGlass.TabIndex = 148
    '
    'lblVisionPoseRNorthGlass
    '
    Me.lblVisionPoseRNorthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseRNorthGlass.Location = New System.Drawing.Point(129, 114)
    Me.lblVisionPoseRNorthGlass.Name = "lblVisionPoseRNorthGlass"
    Me.lblVisionPoseRNorthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseRNorthGlass.TabIndex = 147
    '
    'lblVisionPoseYNorthGlass
    '
    Me.lblVisionPoseYNorthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseYNorthGlass.Location = New System.Drawing.Point(69, 114)
    Me.lblVisionPoseYNorthGlass.Name = "lblVisionPoseYNorthGlass"
    Me.lblVisionPoseYNorthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseYNorthGlass.TabIndex = 146
    '
    'lblVisionPoseXNorthGlass
    '
    Me.lblVisionPoseXNorthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseXNorthGlass.Location = New System.Drawing.Point(9, 114)
    Me.lblVisionPoseXNorthGlass.Name = "lblVisionPoseXNorthGlass"
    Me.lblVisionPoseXNorthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseXNorthGlass.TabIndex = 145
    '
    'btnDetailsNorthGlass
    '
    Me.btnDetailsNorthGlass.BackColor = System.Drawing.Color.Transparent
    Me.btnDetailsNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnDetailsNorthGlass.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.btnDetailsNorthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDetailsNorthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnDetailsNorthGlass.Location = New System.Drawing.Point(11, 65)
    Me.btnDetailsNorthGlass.Name = "btnDetailsNorthGlass"
    Me.btnDetailsNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.btnDetailsNorthGlass.Size = New System.Drawing.Size(54, 24)
    Me.btnDetailsNorthGlass.TabIndex = 144
    Me.btnDetailsNorthGlass.Text = "Details"
    Me.btnDetailsNorthGlass.UseVisualStyleBackColor = False
    '
    'lblVisionMessageNorthGlass
    '
    Me.lblVisionMessageNorthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionMessageNorthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionMessageNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionMessageNorthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionMessageNorthGlass.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblVisionMessageNorthGlass.Location = New System.Drawing.Point(11, 17)
    Me.lblVisionMessageNorthGlass.Name = "lblVisionMessageNorthGlass"
    Me.lblVisionMessageNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionMessageNorthGlass.Size = New System.Drawing.Size(299, 43)
    Me.lblVisionMessageNorthGlass.TabIndex = 56
    Me.lblVisionMessageNorthGlass.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'lblVisionXNorth
    '
    Me.lblVisionXNorth.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionXNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionXNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionXNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionXNorth.Location = New System.Drawing.Point(27, 95)
    Me.lblVisionXNorth.Name = "lblVisionXNorth"
    Me.lblVisionXNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionXNorth.Size = New System.Drawing.Size(34, 17)
    Me.lblVisionXNorth.TabIndex = 55
    Me.lblVisionXNorth.Text = "X"
    '
    'lblVisionYNorth
    '
    Me.lblVisionYNorth.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionYNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionYNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionYNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionYNorth.Location = New System.Drawing.Point(87, 95)
    Me.lblVisionYNorth.Name = "lblVisionYNorth"
    Me.lblVisionYNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionYNorth.Size = New System.Drawing.Size(34, 17)
    Me.lblVisionYNorth.TabIndex = 54
    Me.lblVisionYNorth.Text = "Y"
    '
    'lblVisionAngleNorth
    '
    Me.lblVisionAngleNorth.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionAngleNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionAngleNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionAngleNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionAngleNorth.Location = New System.Drawing.Point(138, 95)
    Me.lblVisionAngleNorth.Name = "lblVisionAngleNorth"
    Me.lblVisionAngleNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionAngleNorth.Size = New System.Drawing.Size(50, 17)
    Me.lblVisionAngleNorth.TabIndex = 53
    Me.lblVisionAngleNorth.Text = "Angle"
    '
    'lblVisionTimeNorth
    '
    Me.lblVisionTimeNorth.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionTimeNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionTimeNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionTimeNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionTimeNorth.Location = New System.Drawing.Point(199, 95)
    Me.lblVisionTimeNorth.Name = "lblVisionTimeNorth"
    Me.lblVisionTimeNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionTimeNorth.Size = New System.Drawing.Size(50, 17)
    Me.lblVisionTimeNorth.TabIndex = 52
    Me.lblVisionTimeNorth.Text = "Time"
    '
    'lblVisionScoreNorth
    '
    Me.lblVisionScoreNorth.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionScoreNorth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionScoreNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionScoreNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionScoreNorth.Location = New System.Drawing.Point(258, 95)
    Me.lblVisionScoreNorth.Name = "lblVisionScoreNorth"
    Me.lblVisionScoreNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionScoreNorth.Size = New System.Drawing.Size(50, 17)
    Me.lblVisionScoreNorth.TabIndex = 50
    Me.lblVisionScoreNorth.Text = "Score"
    '
    'grpHSDisplayNorth
    '
    Me.grpHSDisplayNorth.BackColor = System.Drawing.SystemColors.Control
    Me.grpHSDisplayNorth.Controls.Add(Me.cboCameras)
    Me.grpHSDisplayNorth.Controls.Add(Me.HSDisplayNorth)
    Me.grpHSDisplayNorth.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.grpHSDisplayNorth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpHSDisplayNorth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grpHSDisplayNorth.Location = New System.Drawing.Point(539, 174)
    Me.grpHSDisplayNorth.Name = "grpHSDisplayNorth"
    Me.grpHSDisplayNorth.Padding = New System.Windows.Forms.Padding(0)
    Me.grpHSDisplayNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpHSDisplayNorth.Size = New System.Drawing.Size(961, 776)
    Me.grpHSDisplayNorth.TabIndex = 77
    Me.grpHSDisplayNorth.TabStop = False
    '
    'cboCameras
    '
    Me.cboCameras.FormattingEnabled = True
    Me.cboCameras.Location = New System.Drawing.Point(-162, 1)
    Me.cboCameras.Name = "cboCameras"
    Me.cboCameras.Size = New System.Drawing.Size(121, 27)
    Me.cboCameras.Sorted = True
    Me.cboCameras.TabIndex = 157
    '
    'HSDisplayNorth
    '
    Me.HSDisplayNorth.Enabled = True
    Me.HSDisplayNorth.Location = New System.Drawing.Point(10, 20)
    Me.HSDisplayNorth.Name = "HSDisplayNorth"
    Me.HSDisplayNorth.OcxState = CType(resources.GetObject("HSDisplayNorth.OcxState"), System.Windows.Forms.AxHost.State)
    Me.HSDisplayNorth.Size = New System.Drawing.Size(355, 341)
    Me.HSDisplayNorth.TabIndex = 80
    '
    'grpLocatorControlsNorth
    '
    Me.grpLocatorControlsNorth.BackColor = System.Drawing.SystemColors.Control
    Me.grpLocatorControlsNorth.Controls.Add(Me.btnSearchSettingsNorthGlass)
    Me.grpLocatorControlsNorth.Controls.Add(Me.btnLocateOnlyNorthGlass)
    Me.grpLocatorControlsNorth.Controls.Add(Me.btnLocateNorthGlass)
    Me.grpLocatorControlsNorth.Controls.Add(Me.chkLocateRepeatNorthGlass)
    Me.grpLocatorControlsNorth.Controls.Add(Me.btnTrainNewNorthGlass)
    Me.grpLocatorControlsNorth.Controls.Add(Me.btnTrainExistingNorthGlass)
    Me.grpLocatorControlsNorth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpLocatorControlsNorth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpLocatorControlsNorth.Location = New System.Drawing.Point(5, 538)
    Me.grpLocatorControlsNorth.Name = "grpLocatorControlsNorth"
    Me.grpLocatorControlsNorth.Padding = New System.Windows.Forms.Padding(0)
    Me.grpLocatorControlsNorth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpLocatorControlsNorth.Size = New System.Drawing.Size(196, 151)
    Me.grpLocatorControlsNorth.TabIndex = 57
    Me.grpLocatorControlsNorth.TabStop = False
    Me.grpLocatorControlsNorth.Text = "Locator Controls for Glass"
    '
    'chkLocateRepeatNorthGlass
    '
    Me.chkLocateRepeatNorthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.chkLocateRepeatNorthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkLocateRepeatNorthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkLocateRepeatNorthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkLocateRepeatNorthGlass.Location = New System.Drawing.Point(123, 14)
    Me.chkLocateRepeatNorthGlass.Name = "chkLocateRepeatNorthGlass"
    Me.chkLocateRepeatNorthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkLocateRepeatNorthGlass.Size = New System.Drawing.Size(65, 24)
    Me.chkLocateRepeatNorthGlass.TabIndex = 60
    Me.chkLocateRepeatNorthGlass.TabStop = False
    Me.chkLocateRepeatNorthGlass.Text = "Repeat"
    Me.chkLocateRepeatNorthGlass.UseVisualStyleBackColor = False
    '
    'tabVisionSouth
    '
    Me.tabVisionSouth.Controls.Add(Me.grpVisionSouth)
    Me.tabVisionSouth.Location = New System.Drawing.Point(4, 25)
    Me.tabVisionSouth.Name = "tabVisionSouth"
    Me.tabVisionSouth.Padding = New System.Windows.Forms.Padding(3)
    Me.tabVisionSouth.Size = New System.Drawing.Size(1509, 963)
    Me.tabVisionSouth.TabIndex = 1
    Me.tabVisionSouth.Text = "South Camera"
    Me.tabVisionSouth.UseVisualStyleBackColor = True
    '
    'grpVisionSouth
    '
    Me.grpVisionSouth.BackColor = System.Drawing.SystemColors.Control
    Me.grpVisionSouth.Controls.Add(Me.grpLocatorControlsSouthGlass)
    Me.grpVisionSouth.Controls.Add(Me.grpVisionStatusSouthGlass)
    Me.grpVisionSouth.Controls.Add(Me.grpCameraStatusSouth)
    Me.grpVisionSouth.Controls.Add(Me.grpLocatorControlsSouthMask)
    Me.grpVisionSouth.Controls.Add(Me.grpHSDisplaySouth)
    Me.grpVisionSouth.Controls.Add(Me.grpCameraControlsSouth)
    Me.grpVisionSouth.Controls.Add(Me.grpVisionStatusSouthMask)
    Me.grpVisionSouth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpVisionSouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grpVisionSouth.Location = New System.Drawing.Point(3, 4)
    Me.grpVisionSouth.Name = "grpVisionSouth"
    Me.grpVisionSouth.Padding = New System.Windows.Forms.Padding(0)
    Me.grpVisionSouth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpVisionSouth.Size = New System.Drawing.Size(1506, 947)
    Me.grpVisionSouth.TabIndex = 50
    Me.grpVisionSouth.TabStop = False
    '
    'grpLocatorControlsSouthGlass
    '
    Me.grpLocatorControlsSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.grpLocatorControlsSouthGlass.Controls.Add(Me.btnLocateOnlySouthGlass)
    Me.grpLocatorControlsSouthGlass.Controls.Add(Me.btnLocateSouthGlass)
    Me.grpLocatorControlsSouthGlass.Controls.Add(Me.chkLocateRepeatSouthGlass)
    Me.grpLocatorControlsSouthGlass.Controls.Add(Me.btnSearchSettingsSouthGlass)
    Me.grpLocatorControlsSouthGlass.Controls.Add(Me.btnTrainNewSouthGlass)
    Me.grpLocatorControlsSouthGlass.Controls.Add(Me.btnTrainExistingSouthGlass)
    Me.grpLocatorControlsSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpLocatorControlsSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpLocatorControlsSouthGlass.Location = New System.Drawing.Point(5, 597)
    Me.grpLocatorControlsSouthGlass.Name = "grpLocatorControlsSouthGlass"
    Me.grpLocatorControlsSouthGlass.Padding = New System.Windows.Forms.Padding(0)
    Me.grpLocatorControlsSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpLocatorControlsSouthGlass.Size = New System.Drawing.Size(203, 151)
    Me.grpLocatorControlsSouthGlass.TabIndex = 85
    Me.grpLocatorControlsSouthGlass.TabStop = False
    Me.grpLocatorControlsSouthGlass.Text = "Locator Controls for Glass"
    '
    'chkLocateRepeatSouthGlass
    '
    Me.chkLocateRepeatSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.chkLocateRepeatSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkLocateRepeatSouthGlass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkLocateRepeatSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkLocateRepeatSouthGlass.Location = New System.Drawing.Point(123, 14)
    Me.chkLocateRepeatSouthGlass.Name = "chkLocateRepeatSouthGlass"
    Me.chkLocateRepeatSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkLocateRepeatSouthGlass.Size = New System.Drawing.Size(68, 24)
    Me.chkLocateRepeatSouthGlass.TabIndex = 60
    Me.chkLocateRepeatSouthGlass.TabStop = False
    Me.chkLocateRepeatSouthGlass.Text = "Repeat"
    Me.chkLocateRepeatSouthGlass.UseVisualStyleBackColor = False
    '
    'grpVisionStatusSouthGlass
    '
    Me.grpVisionStatusSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblScoreLimitSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.updnScoreLimitSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblVisionPoseScoreSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblVisionPoseTimeSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblVisionPoseRSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblVisionPoseYSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblVisionPoseXSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.btnDetailsSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblVisionMessageSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblXVisionSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblYVisionSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblRVisionSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblTimeVisionSouthGlass)
    Me.grpVisionStatusSouthGlass.Controls.Add(Me.lblScoreVisionSouthGlass)
    Me.grpVisionStatusSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpVisionStatusSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpVisionStatusSouthGlass.Location = New System.Drawing.Point(213, 597)
    Me.grpVisionStatusSouthGlass.Name = "grpVisionStatusSouthGlass"
    Me.grpVisionStatusSouthGlass.Padding = New System.Windows.Forms.Padding(0)
    Me.grpVisionStatusSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpVisionStatusSouthGlass.Size = New System.Drawing.Size(320, 151)
    Me.grpVisionStatusSouthGlass.TabIndex = 84
    Me.grpVisionStatusSouthGlass.TabStop = False
    Me.grpVisionStatusSouthGlass.Text = "Status"
    '
    'lblScoreLimitSouthGlass
    '
    Me.lblScoreLimitSouthGlass.AutoSize = True
    Me.lblScoreLimitSouthGlass.Location = New System.Drawing.Point(186, 72)
    Me.lblScoreLimitSouthGlass.Name = "lblScoreLimitSouthGlass"
    Me.lblScoreLimitSouthGlass.Size = New System.Drawing.Size(70, 14)
    Me.lblScoreLimitSouthGlass.TabIndex = 158
    Me.lblScoreLimitSouthGlass.Text = "Score Limit"
    '
    'updnScoreLimitSouthGlass
    '
    Me.updnScoreLimitSouthGlass.Enabled = False
    Me.updnScoreLimitSouthGlass.Location = New System.Drawing.Point(261, 70)
    Me.updnScoreLimitSouthGlass.Minimum = New Decimal(New Integer() {75, 0, 0, 0})
    Me.updnScoreLimitSouthGlass.Name = "updnScoreLimitSouthGlass"
    Me.updnScoreLimitSouthGlass.Size = New System.Drawing.Size(49, 20)
    Me.updnScoreLimitSouthGlass.TabIndex = 157
    Me.updnScoreLimitSouthGlass.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnScoreLimitSouthGlass.Value = New Decimal(New Integer() {75, 0, 0, 0})
    '
    'lblVisionPoseScoreSouthGlass
    '
    Me.lblVisionPoseScoreSouthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseScoreSouthGlass.Location = New System.Drawing.Point(249, 114)
    Me.lblVisionPoseScoreSouthGlass.Name = "lblVisionPoseScoreSouthGlass"
    Me.lblVisionPoseScoreSouthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseScoreSouthGlass.TabIndex = 154
    '
    'lblVisionPoseTimeSouthGlass
    '
    Me.lblVisionPoseTimeSouthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseTimeSouthGlass.Location = New System.Drawing.Point(189, 114)
    Me.lblVisionPoseTimeSouthGlass.Name = "lblVisionPoseTimeSouthGlass"
    Me.lblVisionPoseTimeSouthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseTimeSouthGlass.TabIndex = 153
    '
    'lblVisionPoseRSouthGlass
    '
    Me.lblVisionPoseRSouthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseRSouthGlass.Location = New System.Drawing.Point(129, 114)
    Me.lblVisionPoseRSouthGlass.Name = "lblVisionPoseRSouthGlass"
    Me.lblVisionPoseRSouthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseRSouthGlass.TabIndex = 152
    '
    'lblVisionPoseYSouthGlass
    '
    Me.lblVisionPoseYSouthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseYSouthGlass.Location = New System.Drawing.Point(69, 114)
    Me.lblVisionPoseYSouthGlass.Name = "lblVisionPoseYSouthGlass"
    Me.lblVisionPoseYSouthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseYSouthGlass.TabIndex = 151
    '
    'lblVisionPoseXSouthGlass
    '
    Me.lblVisionPoseXSouthGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseXSouthGlass.Location = New System.Drawing.Point(9, 114)
    Me.lblVisionPoseXSouthGlass.Name = "lblVisionPoseXSouthGlass"
    Me.lblVisionPoseXSouthGlass.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseXSouthGlass.TabIndex = 150
    '
    'lblXVisionSouthGlass
    '
    Me.lblXVisionSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.lblXVisionSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblXVisionSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblXVisionSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblXVisionSouthGlass.Location = New System.Drawing.Point(27, 95)
    Me.lblXVisionSouthGlass.Name = "lblXVisionSouthGlass"
    Me.lblXVisionSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblXVisionSouthGlass.Size = New System.Drawing.Size(34, 17)
    Me.lblXVisionSouthGlass.TabIndex = 55
    Me.lblXVisionSouthGlass.Text = "X"
    '
    'lblYVisionSouthGlass
    '
    Me.lblYVisionSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.lblYVisionSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblYVisionSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblYVisionSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblYVisionSouthGlass.Location = New System.Drawing.Point(87, 95)
    Me.lblYVisionSouthGlass.Name = "lblYVisionSouthGlass"
    Me.lblYVisionSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblYVisionSouthGlass.Size = New System.Drawing.Size(34, 17)
    Me.lblYVisionSouthGlass.TabIndex = 54
    Me.lblYVisionSouthGlass.Text = "Y"
    '
    'lblRVisionSouthGlass
    '
    Me.lblRVisionSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.lblRVisionSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblRVisionSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblRVisionSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblRVisionSouthGlass.Location = New System.Drawing.Point(138, 95)
    Me.lblRVisionSouthGlass.Name = "lblRVisionSouthGlass"
    Me.lblRVisionSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblRVisionSouthGlass.Size = New System.Drawing.Size(50, 17)
    Me.lblRVisionSouthGlass.TabIndex = 53
    Me.lblRVisionSouthGlass.Text = "Angle"
    '
    'lblTimeVisionSouthGlass
    '
    Me.lblTimeVisionSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.lblTimeVisionSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblTimeVisionSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTimeVisionSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblTimeVisionSouthGlass.Location = New System.Drawing.Point(199, 95)
    Me.lblTimeVisionSouthGlass.Name = "lblTimeVisionSouthGlass"
    Me.lblTimeVisionSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblTimeVisionSouthGlass.Size = New System.Drawing.Size(50, 17)
    Me.lblTimeVisionSouthGlass.TabIndex = 52
    Me.lblTimeVisionSouthGlass.Text = "Time"
    '
    'lblScoreVisionSouthGlass
    '
    Me.lblScoreVisionSouthGlass.BackColor = System.Drawing.SystemColors.Control
    Me.lblScoreVisionSouthGlass.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblScoreVisionSouthGlass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblScoreVisionSouthGlass.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblScoreVisionSouthGlass.Location = New System.Drawing.Point(258, 95)
    Me.lblScoreVisionSouthGlass.Name = "lblScoreVisionSouthGlass"
    Me.lblScoreVisionSouthGlass.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblScoreVisionSouthGlass.Size = New System.Drawing.Size(50, 17)
    Me.lblScoreVisionSouthGlass.TabIndex = 50
    Me.lblScoreVisionSouthGlass.Text = "Score"
    '
    'grpCameraStatusSouth
    '
    Me.grpCameraStatusSouth.Controls.Add(Me.lblCameraStatusSouth)
    Me.grpCameraStatusSouth.Controls.Add(Me.lblTemperatureSouth)
    Me.grpCameraStatusSouth.Controls.Add(Me.pctTemperatureSouth)
    Me.grpCameraStatusSouth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
    Me.grpCameraStatusSouth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpCameraStatusSouth.Location = New System.Drawing.Point(3, 9)
    Me.grpCameraStatusSouth.Name = "grpCameraStatusSouth"
    Me.grpCameraStatusSouth.Size = New System.Drawing.Size(173, 151)
    Me.grpCameraStatusSouth.TabIndex = 83
    Me.grpCameraStatusSouth.TabStop = False
    Me.grpCameraStatusSouth.Text = "Camera Status"
    '
    'lblCameraStatusSouth
    '
    Me.lblCameraStatusSouth.AutoSize = True
    Me.lblCameraStatusSouth.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCameraStatusSouth.ForeColor = System.Drawing.Color.DarkRed
    Me.lblCameraStatusSouth.Location = New System.Drawing.Point(37, 21)
    Me.lblCameraStatusSouth.Name = "lblCameraStatusSouth"
    Me.lblCameraStatusSouth.Size = New System.Drawing.Size(114, 51)
    Me.lblCameraStatusSouth.TabIndex = 161
    Me.lblCameraStatusSouth.Text = "       Warning! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  The Camera is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  not connected"
    Me.lblCameraStatusSouth.Visible = False
    '
    'lblTemperatureSouth
    '
    Me.lblTemperatureSouth.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.lblTemperatureSouth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblTemperatureSouth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTemperatureSouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblTemperatureSouth.Location = New System.Drawing.Point(6, 97)
    Me.lblTemperatureSouth.Name = "lblTemperatureSouth"
    Me.lblTemperatureSouth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblTemperatureSouth.Size = New System.Drawing.Size(39, 48)
    Me.lblTemperatureSouth.TabIndex = 160
    Me.lblTemperatureSouth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'pctTemperatureSouth
    '
    Me.pctTemperatureSouth.Image = CType(resources.GetObject("pctTemperatureSouth.Image"), System.Drawing.Image)
    Me.pctTemperatureSouth.Location = New System.Drawing.Point(11, 32)
    Me.pctTemperatureSouth.Name = "pctTemperatureSouth"
    Me.pctTemperatureSouth.Size = New System.Drawing.Size(25, 60)
    Me.pctTemperatureSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pctTemperatureSouth.TabIndex = 159
    Me.pctTemperatureSouth.TabStop = False
    '
    'grpLocatorControlsSouthMask
    '
    Me.grpLocatorControlsSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.grpLocatorControlsSouthMask.Controls.Add(Me.btnLocateOnlySouthMask)
    Me.grpLocatorControlsSouthMask.Controls.Add(Me.btnLocateSouthMask)
    Me.grpLocatorControlsSouthMask.Controls.Add(Me.chkLocateRepeatSouthMask)
    Me.grpLocatorControlsSouthMask.Controls.Add(Me.btnSearchSettingsSouthMask)
    Me.grpLocatorControlsSouthMask.Controls.Add(Me.btnTrainNewSouthMask)
    Me.grpLocatorControlsSouthMask.Controls.Add(Me.btnTrainExistingSouthMask)
    Me.grpLocatorControlsSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpLocatorControlsSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpLocatorControlsSouthMask.Location = New System.Drawing.Point(5, 178)
    Me.grpLocatorControlsSouthMask.Name = "grpLocatorControlsSouthMask"
    Me.grpLocatorControlsSouthMask.Padding = New System.Windows.Forms.Padding(0)
    Me.grpLocatorControlsSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpLocatorControlsSouthMask.Size = New System.Drawing.Size(203, 151)
    Me.grpLocatorControlsSouthMask.TabIndex = 82
    Me.grpLocatorControlsSouthMask.TabStop = False
    Me.grpLocatorControlsSouthMask.Text = "Locator Controls for Mask"
    '
    'chkLocateRepeatSouthMask
    '
    Me.chkLocateRepeatSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.chkLocateRepeatSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkLocateRepeatSouthMask.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkLocateRepeatSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkLocateRepeatSouthMask.Location = New System.Drawing.Point(123, 14)
    Me.chkLocateRepeatSouthMask.Name = "chkLocateRepeatSouthMask"
    Me.chkLocateRepeatSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkLocateRepeatSouthMask.Size = New System.Drawing.Size(68, 24)
    Me.chkLocateRepeatSouthMask.TabIndex = 60
    Me.chkLocateRepeatSouthMask.TabStop = False
    Me.chkLocateRepeatSouthMask.Text = "Repeat"
    Me.chkLocateRepeatSouthMask.UseVisualStyleBackColor = False
    '
    'grpHSDisplaySouth
    '
    Me.grpHSDisplaySouth.BackColor = System.Drawing.SystemColors.Control
    Me.grpHSDisplaySouth.Controls.Add(Me.HSDisplaySouth)
    Me.grpHSDisplaySouth.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.grpHSDisplaySouth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpHSDisplaySouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grpHSDisplaySouth.Location = New System.Drawing.Point(539, 174)
    Me.grpHSDisplaySouth.Name = "grpHSDisplaySouth"
    Me.grpHSDisplaySouth.Padding = New System.Windows.Forms.Padding(0)
    Me.grpHSDisplaySouth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpHSDisplaySouth.Size = New System.Drawing.Size(920, 773)
    Me.grpHSDisplaySouth.TabIndex = 77
    Me.grpHSDisplaySouth.TabStop = False
    '
    'HSDisplaySouth
    '
    Me.HSDisplaySouth.Enabled = True
    Me.HSDisplaySouth.Location = New System.Drawing.Point(10, 20)
    Me.HSDisplaySouth.Name = "HSDisplaySouth"
    Me.HSDisplaySouth.OcxState = CType(resources.GetObject("HSDisplaySouth.OcxState"), System.Windows.Forms.AxHost.State)
    Me.HSDisplaySouth.Size = New System.Drawing.Size(355, 341)
    Me.HSDisplaySouth.TabIndex = 81
    '
    'grpCameraControlsSouth
    '
    Me.grpCameraControlsSouth.BackColor = System.Drawing.SystemColors.Control
    Me.grpCameraControlsSouth.Controls.Add(Me.Label31)
    Me.grpCameraControlsSouth.Controls.Add(Me.lblContrastValueSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.lblBrightnessValueSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.lblExposureValueSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.lblContrastSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.lblExposureSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.updnContrastSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.updnExposureSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.btnSnapSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.chkSnapRepeatSouth)
    Me.grpCameraControlsSouth.Controls.Add(Me.lblCameraTimeSouth)
    Me.grpCameraControlsSouth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpCameraControlsSouth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpCameraControlsSouth.Location = New System.Drawing.Point(182, 9)
    Me.grpCameraControlsSouth.Name = "grpCameraControlsSouth"
    Me.grpCameraControlsSouth.Padding = New System.Windows.Forms.Padding(0)
    Me.grpCameraControlsSouth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpCameraControlsSouth.Size = New System.Drawing.Size(187, 151)
    Me.grpCameraControlsSouth.TabIndex = 68
    Me.grpCameraControlsSouth.TabStop = False
    Me.grpCameraControlsSouth.Text = "Camera Controls"
    '
    'Label31
    '
    Me.Label31.AutoSize = True
    Me.Label31.Location = New System.Drawing.Point(36, 54)
    Me.Label31.Name = "Label31"
    Me.Label31.Size = New System.Drawing.Size(59, 14)
    Me.Label31.TabIndex = 165
    Me.Label31.Text = "Acq Time"
    '
    'lblContrastValueSouth
    '
    Me.lblContrastValueSouth.AutoSize = True
    Me.lblContrastValueSouth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblContrastValueSouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblContrastValueSouth.Location = New System.Drawing.Point(169, 116)
    Me.lblContrastValueSouth.Name = "lblContrastValueSouth"
    Me.lblContrastValueSouth.Size = New System.Drawing.Size(0, 14)
    Me.lblContrastValueSouth.TabIndex = 152
    '
    'lblBrightnessValueSouth
    '
    Me.lblBrightnessValueSouth.AutoSize = True
    Me.lblBrightnessValueSouth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBrightnessValueSouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblBrightnessValueSouth.Location = New System.Drawing.Point(169, 83)
    Me.lblBrightnessValueSouth.Name = "lblBrightnessValueSouth"
    Me.lblBrightnessValueSouth.Size = New System.Drawing.Size(0, 14)
    Me.lblBrightnessValueSouth.TabIndex = 151
    '
    'lblExposureValueSouth
    '
    Me.lblExposureValueSouth.AutoSize = True
    Me.lblExposureValueSouth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblExposureValueSouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblExposureValueSouth.Location = New System.Drawing.Point(169, 56)
    Me.lblExposureValueSouth.Name = "lblExposureValueSouth"
    Me.lblExposureValueSouth.Size = New System.Drawing.Size(0, 14)
    Me.lblExposureValueSouth.TabIndex = 150
    '
    'lblContrastSouth
    '
    Me.lblContrastSouth.AutoSize = True
    Me.lblContrastSouth.Location = New System.Drawing.Point(40, 99)
    Me.lblContrastSouth.Name = "lblContrastSouth"
    Me.lblContrastSouth.Size = New System.Drawing.Size(55, 14)
    Me.lblContrastSouth.TabIndex = 148
    Me.lblContrastSouth.Text = "Contrast"
    '
    'lblExposureSouth
    '
    Me.lblExposureSouth.AutoSize = True
    Me.lblExposureSouth.Location = New System.Drawing.Point(36, 77)
    Me.lblExposureSouth.Name = "lblExposureSouth"
    Me.lblExposureSouth.Size = New System.Drawing.Size(59, 14)
    Me.lblExposureSouth.TabIndex = 146
    Me.lblExposureSouth.Text = "Exposure"
    '
    'updnContrastSouth
    '
    Me.updnContrastSouth.Location = New System.Drawing.Point(101, 97)
    Me.updnContrastSouth.Name = "updnContrastSouth"
    Me.updnContrastSouth.Size = New System.Drawing.Size(49, 20)
    Me.updnContrastSouth.TabIndex = 145
    Me.updnContrastSouth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnContrastSouth.Value = New Decimal(New Integer() {100, 0, 0, 65536})
    '
    'updnExposureSouth
    '
    Me.updnExposureSouth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
    Me.updnExposureSouth.Location = New System.Drawing.Point(101, 75)
    Me.updnExposureSouth.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
    Me.updnExposureSouth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.updnExposureSouth.Name = "updnExposureSouth"
    Me.updnExposureSouth.Size = New System.Drawing.Size(49, 20)
    Me.updnExposureSouth.TabIndex = 142
    Me.updnExposureSouth.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnExposureSouth.Value = New Decimal(New Integer() {10, 0, 0, 0})
    '
    'chkSnapRepeatSouth
    '
    Me.chkSnapRepeatSouth.BackColor = System.Drawing.SystemColors.Control
    Me.chkSnapRepeatSouth.Cursor = System.Windows.Forms.Cursors.Default
    Me.chkSnapRepeatSouth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkSnapRepeatSouth.ForeColor = System.Drawing.SystemColors.Highlight
    Me.chkSnapRepeatSouth.Location = New System.Drawing.Point(115, 14)
    Me.chkSnapRepeatSouth.Name = "chkSnapRepeatSouth"
    Me.chkSnapRepeatSouth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.chkSnapRepeatSouth.Size = New System.Drawing.Size(62, 24)
    Me.chkSnapRepeatSouth.TabIndex = 72
    Me.chkSnapRepeatSouth.TabStop = False
    Me.chkSnapRepeatSouth.Text = "Repeat"
    Me.chkSnapRepeatSouth.UseVisualStyleBackColor = False
    '
    'lblCameraTimeSouth
    '
    Me.lblCameraTimeSouth.BackColor = System.Drawing.SystemColors.Control
    Me.lblCameraTimeSouth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblCameraTimeSouth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblCameraTimeSouth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCameraTimeSouth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblCameraTimeSouth.Location = New System.Drawing.Point(101, 52)
    Me.lblCameraTimeSouth.Name = "lblCameraTimeSouth"
    Me.lblCameraTimeSouth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblCameraTimeSouth.Size = New System.Drawing.Size(48, 18)
    Me.lblCameraTimeSouth.TabIndex = 75
    '
    'grpVisionStatusSouthMask
    '
    Me.grpVisionStatusSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblScoreLimitSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.updnScoreLimitSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionPoseScoreSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionPoseTimeSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionPoseRSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionPoseYSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionPoseXSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.btnDetailsSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionMessageSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionXSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionYSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionAngleSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionTimeSouthMask)
    Me.grpVisionStatusSouthMask.Controls.Add(Me.lblVisionScoreSouthMask)
    Me.grpVisionStatusSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpVisionStatusSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpVisionStatusSouthMask.Location = New System.Drawing.Point(213, 178)
    Me.grpVisionStatusSouthMask.Name = "grpVisionStatusSouthMask"
    Me.grpVisionStatusSouthMask.Padding = New System.Windows.Forms.Padding(0)
    Me.grpVisionStatusSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpVisionStatusSouthMask.Size = New System.Drawing.Size(320, 151)
    Me.grpVisionStatusSouthMask.TabIndex = 48
    Me.grpVisionStatusSouthMask.TabStop = False
    Me.grpVisionStatusSouthMask.Text = "Status"
    '
    'lblScoreLimitSouthMask
    '
    Me.lblScoreLimitSouthMask.AutoSize = True
    Me.lblScoreLimitSouthMask.Location = New System.Drawing.Point(180, 70)
    Me.lblScoreLimitSouthMask.Name = "lblScoreLimitSouthMask"
    Me.lblScoreLimitSouthMask.Size = New System.Drawing.Size(70, 14)
    Me.lblScoreLimitSouthMask.TabIndex = 156
    Me.lblScoreLimitSouthMask.Text = "Score Limit"
    '
    'updnScoreLimitSouthMask
    '
    Me.updnScoreLimitSouthMask.Location = New System.Drawing.Point(254, 68)
    Me.updnScoreLimitSouthMask.Minimum = New Decimal(New Integer() {75, 0, 0, 0})
    Me.updnScoreLimitSouthMask.Name = "updnScoreLimitSouthMask"
    Me.updnScoreLimitSouthMask.Size = New System.Drawing.Size(49, 20)
    Me.updnScoreLimitSouthMask.TabIndex = 155
    Me.updnScoreLimitSouthMask.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnScoreLimitSouthMask.Value = New Decimal(New Integer() {75, 0, 0, 0})
    '
    'lblVisionPoseScoreSouthMask
    '
    Me.lblVisionPoseScoreSouthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseScoreSouthMask.Location = New System.Drawing.Point(249, 114)
    Me.lblVisionPoseScoreSouthMask.Name = "lblVisionPoseScoreSouthMask"
    Me.lblVisionPoseScoreSouthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseScoreSouthMask.TabIndex = 154
    '
    'lblVisionPoseTimeSouthMask
    '
    Me.lblVisionPoseTimeSouthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseTimeSouthMask.Location = New System.Drawing.Point(189, 114)
    Me.lblVisionPoseTimeSouthMask.Name = "lblVisionPoseTimeSouthMask"
    Me.lblVisionPoseTimeSouthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseTimeSouthMask.TabIndex = 153
    '
    'lblVisionPoseRSouthMask
    '
    Me.lblVisionPoseRSouthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseRSouthMask.Location = New System.Drawing.Point(129, 114)
    Me.lblVisionPoseRSouthMask.Name = "lblVisionPoseRSouthMask"
    Me.lblVisionPoseRSouthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseRSouthMask.TabIndex = 152
    '
    'lblVisionPoseYSouthMask
    '
    Me.lblVisionPoseYSouthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseYSouthMask.Location = New System.Drawing.Point(69, 114)
    Me.lblVisionPoseYSouthMask.Name = "lblVisionPoseYSouthMask"
    Me.lblVisionPoseYSouthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseYSouthMask.TabIndex = 151
    '
    'lblVisionPoseXSouthMask
    '
    Me.lblVisionPoseXSouthMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblVisionPoseXSouthMask.Location = New System.Drawing.Point(9, 114)
    Me.lblVisionPoseXSouthMask.Name = "lblVisionPoseXSouthMask"
    Me.lblVisionPoseXSouthMask.Size = New System.Drawing.Size(59, 23)
    Me.lblVisionPoseXSouthMask.TabIndex = 150
    '
    'lblVisionXSouthMask
    '
    Me.lblVisionXSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionXSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionXSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionXSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionXSouthMask.Location = New System.Drawing.Point(27, 95)
    Me.lblVisionXSouthMask.Name = "lblVisionXSouthMask"
    Me.lblVisionXSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionXSouthMask.Size = New System.Drawing.Size(34, 17)
    Me.lblVisionXSouthMask.TabIndex = 55
    Me.lblVisionXSouthMask.Text = "X"
    '
    'lblVisionYSouthMask
    '
    Me.lblVisionYSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionYSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionYSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionYSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionYSouthMask.Location = New System.Drawing.Point(87, 95)
    Me.lblVisionYSouthMask.Name = "lblVisionYSouthMask"
    Me.lblVisionYSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionYSouthMask.Size = New System.Drawing.Size(34, 17)
    Me.lblVisionYSouthMask.TabIndex = 54
    Me.lblVisionYSouthMask.Text = "Y"
    '
    'lblVisionAngleSouthMask
    '
    Me.lblVisionAngleSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionAngleSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionAngleSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionAngleSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionAngleSouthMask.Location = New System.Drawing.Point(138, 95)
    Me.lblVisionAngleSouthMask.Name = "lblVisionAngleSouthMask"
    Me.lblVisionAngleSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionAngleSouthMask.Size = New System.Drawing.Size(50, 17)
    Me.lblVisionAngleSouthMask.TabIndex = 53
    Me.lblVisionAngleSouthMask.Text = "Angle"
    '
    'lblVisionTimeSouthMask
    '
    Me.lblVisionTimeSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionTimeSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionTimeSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionTimeSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionTimeSouthMask.Location = New System.Drawing.Point(199, 95)
    Me.lblVisionTimeSouthMask.Name = "lblVisionTimeSouthMask"
    Me.lblVisionTimeSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionTimeSouthMask.Size = New System.Drawing.Size(50, 17)
    Me.lblVisionTimeSouthMask.TabIndex = 52
    Me.lblVisionTimeSouthMask.Text = "Time"
    '
    'lblVisionScoreSouthMask
    '
    Me.lblVisionScoreSouthMask.BackColor = System.Drawing.SystemColors.Control
    Me.lblVisionScoreSouthMask.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionScoreSouthMask.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVisionScoreSouthMask.ForeColor = System.Drawing.SystemColors.Highlight
    Me.lblVisionScoreSouthMask.Location = New System.Drawing.Point(258, 95)
    Me.lblVisionScoreSouthMask.Name = "lblVisionScoreSouthMask"
    Me.lblVisionScoreSouthMask.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionScoreSouthMask.Size = New System.Drawing.Size(50, 17)
    Me.lblVisionScoreSouthMask.TabIndex = 50
    Me.lblVisionScoreSouthMask.Text = "Score"
    '
    'tabVisionDebug
    '
    Me.tabVisionDebug.Controls.Add(Me.grpMisc)
    Me.tabVisionDebug.Controls.Add(Me.grpMaskCombined)
    Me.tabVisionDebug.Controls.Add(Me.grpGlassCombined)
    Me.tabVisionDebug.Location = New System.Drawing.Point(4, 25)
    Me.tabVisionDebug.Name = "tabVisionDebug"
    Me.tabVisionDebug.Size = New System.Drawing.Size(1509, 963)
    Me.tabVisionDebug.TabIndex = 3
    Me.tabVisionDebug.Text = "Debug"
    Me.tabVisionDebug.UseVisualStyleBackColor = True
    '
    'grpMisc
    '
    Me.grpMisc.BackColor = System.Drawing.SystemColors.Control
    Me.grpMisc.Controls.Add(Me.updnRLimit)
    Me.grpMisc.Controls.Add(Me.Label2)
    Me.grpMisc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpMisc.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpMisc.Location = New System.Drawing.Point(16, 304)
    Me.grpMisc.Name = "grpMisc"
    Me.grpMisc.Padding = New System.Windows.Forms.Padding(0)
    Me.grpMisc.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpMisc.Size = New System.Drawing.Size(320, 130)
    Me.grpMisc.TabIndex = 89
    Me.grpMisc.TabStop = False
    Me.grpMisc.Text = "Settings"
    '
    'updnRLimit
    '
    Me.updnRLimit.DecimalPlaces = 1
    Me.updnRLimit.Location = New System.Drawing.Point(91, 30)
    Me.updnRLimit.Name = "updnRLimit"
    Me.updnRLimit.Size = New System.Drawing.Size(56, 20)
    Me.updnRLimit.TabIndex = 238
    Me.updnRLimit.Tag = ""
    Me.updnRLimit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnRLimit.Value = New Decimal(New Integer() {25, 0, 0, 0})
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label2.Location = New System.Drawing.Point(8, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label2.Size = New System.Drawing.Size(83, 13)
    Me.Label2.TabIndex = 237
    Me.Label2.Text = "Rotation Limit"
    '
    'grpMaskCombined
    '
    Me.grpMaskCombined.BackColor = System.Drawing.SystemColors.Control
    Me.grpMaskCombined.Controls.Add(Me.lblMaskCombinedR)
    Me.grpMaskCombined.Controls.Add(Me.lblMaskCombinedY)
    Me.grpMaskCombined.Controls.Add(Me.lblMaskCombinedX)
    Me.grpMaskCombined.Controls.Add(Me.lblMaskCombinedStatus)
    Me.grpMaskCombined.Controls.Add(Me.Label35)
    Me.grpMaskCombined.Controls.Add(Me.Label36)
    Me.grpMaskCombined.Controls.Add(Me.Label37)
    Me.grpMaskCombined.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpMaskCombined.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpMaskCombined.Location = New System.Drawing.Point(16, 168)
    Me.grpMaskCombined.Name = "grpMaskCombined"
    Me.grpMaskCombined.Padding = New System.Windows.Forms.Padding(0)
    Me.grpMaskCombined.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpMaskCombined.Size = New System.Drawing.Size(320, 130)
    Me.grpMaskCombined.TabIndex = 88
    Me.grpMaskCombined.TabStop = False
    Me.grpMaskCombined.Text = "Mask Combined Offset"
    '
    'lblMaskCombinedR
    '
    Me.lblMaskCombinedR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblMaskCombinedR.Location = New System.Drawing.Point(130, 93)
    Me.lblMaskCombinedR.Name = "lblMaskCombinedR"
    Me.lblMaskCombinedR.Size = New System.Drawing.Size(59, 23)
    Me.lblMaskCombinedR.TabIndex = 147
    '
    'lblMaskCombinedY
    '
    Me.lblMaskCombinedY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblMaskCombinedY.Location = New System.Drawing.Point(70, 93)
    Me.lblMaskCombinedY.Name = "lblMaskCombinedY"
    Me.lblMaskCombinedY.Size = New System.Drawing.Size(59, 23)
    Me.lblMaskCombinedY.TabIndex = 146
    '
    'lblMaskCombinedX
    '
    Me.lblMaskCombinedX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblMaskCombinedX.Location = New System.Drawing.Point(10, 93)
    Me.lblMaskCombinedX.Name = "lblMaskCombinedX"
    Me.lblMaskCombinedX.Size = New System.Drawing.Size(59, 23)
    Me.lblMaskCombinedX.TabIndex = 145
    '
    'lblMaskCombinedStatus
    '
    Me.lblMaskCombinedStatus.BackColor = System.Drawing.SystemColors.Control
    Me.lblMaskCombinedStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblMaskCombinedStatus.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblMaskCombinedStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMaskCombinedStatus.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblMaskCombinedStatus.Location = New System.Drawing.Point(11, 17)
    Me.lblMaskCombinedStatus.Name = "lblMaskCombinedStatus"
    Me.lblMaskCombinedStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblMaskCombinedStatus.Size = New System.Drawing.Size(299, 45)
    Me.lblMaskCombinedStatus.TabIndex = 56
    Me.lblMaskCombinedStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label35
    '
    Me.Label35.BackColor = System.Drawing.SystemColors.Control
    Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label35.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label35.Location = New System.Drawing.Point(28, 74)
    Me.Label35.Name = "Label35"
    Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label35.Size = New System.Drawing.Size(34, 17)
    Me.Label35.TabIndex = 55
    Me.Label35.Text = "X"
    '
    'Label36
    '
    Me.Label36.BackColor = System.Drawing.SystemColors.Control
    Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label36.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label36.Location = New System.Drawing.Point(88, 74)
    Me.Label36.Name = "Label36"
    Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label36.Size = New System.Drawing.Size(34, 17)
    Me.Label36.TabIndex = 54
    Me.Label36.Text = "Y"
    '
    'Label37
    '
    Me.Label37.BackColor = System.Drawing.SystemColors.Control
    Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label37.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label37.Location = New System.Drawing.Point(139, 74)
    Me.Label37.Name = "Label37"
    Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label37.Size = New System.Drawing.Size(50, 17)
    Me.Label37.TabIndex = 53
    Me.Label37.Text = "Angle"
    '
    'grpGlassCombined
    '
    Me.grpGlassCombined.BackColor = System.Drawing.SystemColors.Control
    Me.grpGlassCombined.Controls.Add(Me.lblGlassCombinedR)
    Me.grpGlassCombined.Controls.Add(Me.lblGlassCombinedY)
    Me.grpGlassCombined.Controls.Add(Me.lblGlassCombinedX)
    Me.grpGlassCombined.Controls.Add(Me.lblGlassCombinedStatus)
    Me.grpGlassCombined.Controls.Add(Me.Label30)
    Me.grpGlassCombined.Controls.Add(Me.Label32)
    Me.grpGlassCombined.Controls.Add(Me.Label33)
    Me.grpGlassCombined.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpGlassCombined.ForeColor = System.Drawing.SystemColors.Highlight
    Me.grpGlassCombined.Location = New System.Drawing.Point(16, 17)
    Me.grpGlassCombined.Name = "grpGlassCombined"
    Me.grpGlassCombined.Padding = New System.Windows.Forms.Padding(0)
    Me.grpGlassCombined.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpGlassCombined.Size = New System.Drawing.Size(320, 130)
    Me.grpGlassCombined.TabIndex = 87
    Me.grpGlassCombined.TabStop = False
    Me.grpGlassCombined.Text = "Glass Combined Offset"
    '
    'lblGlassCombinedR
    '
    Me.lblGlassCombinedR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblGlassCombinedR.Location = New System.Drawing.Point(130, 93)
    Me.lblGlassCombinedR.Name = "lblGlassCombinedR"
    Me.lblGlassCombinedR.Size = New System.Drawing.Size(59, 23)
    Me.lblGlassCombinedR.TabIndex = 147
    '
    'lblGlassCombinedY
    '
    Me.lblGlassCombinedY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblGlassCombinedY.Location = New System.Drawing.Point(70, 93)
    Me.lblGlassCombinedY.Name = "lblGlassCombinedY"
    Me.lblGlassCombinedY.Size = New System.Drawing.Size(59, 23)
    Me.lblGlassCombinedY.TabIndex = 146
    '
    'lblGlassCombinedX
    '
    Me.lblGlassCombinedX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblGlassCombinedX.Location = New System.Drawing.Point(10, 93)
    Me.lblGlassCombinedX.Name = "lblGlassCombinedX"
    Me.lblGlassCombinedX.Size = New System.Drawing.Size(59, 23)
    Me.lblGlassCombinedX.TabIndex = 145
    '
    'lblGlassCombinedStatus
    '
    Me.lblGlassCombinedStatus.BackColor = System.Drawing.SystemColors.Control
    Me.lblGlassCombinedStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblGlassCombinedStatus.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblGlassCombinedStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGlassCombinedStatus.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblGlassCombinedStatus.Location = New System.Drawing.Point(11, 17)
    Me.lblGlassCombinedStatus.Name = "lblGlassCombinedStatus"
    Me.lblGlassCombinedStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblGlassCombinedStatus.Size = New System.Drawing.Size(299, 45)
    Me.lblGlassCombinedStatus.TabIndex = 56
    Me.lblGlassCombinedStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label30
    '
    Me.Label30.BackColor = System.Drawing.SystemColors.Control
    Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label30.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label30.Location = New System.Drawing.Point(28, 74)
    Me.Label30.Name = "Label30"
    Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label30.Size = New System.Drawing.Size(34, 17)
    Me.Label30.TabIndex = 55
    Me.Label30.Text = "X"
    '
    'Label32
    '
    Me.Label32.BackColor = System.Drawing.SystemColors.Control
    Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label32.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label32.Location = New System.Drawing.Point(88, 74)
    Me.Label32.Name = "Label32"
    Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label32.Size = New System.Drawing.Size(34, 17)
    Me.Label32.TabIndex = 54
    Me.Label32.Text = "Y"
    '
    'Label33
    '
    Me.Label33.BackColor = System.Drawing.SystemColors.Control
    Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label33.ForeColor = System.Drawing.SystemColors.Highlight
    Me.Label33.Location = New System.Drawing.Point(139, 74)
    Me.Label33.Name = "Label33"
    Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label33.Size = New System.Drawing.Size(50, 17)
    Me.Label33.TabIndex = 53
    Me.Label33.Text = "Angle"
    '
    'grpCombinedOffset
    '
    Me.grpCombinedOffset.BackColor = System.Drawing.Color.LightSteelBlue
    Me.grpCombinedOffset.Controls.Add(Me.SSTab1)
    Me.grpCombinedOffset.Controls.Add(Me.grpCommStatus)
    Me.grpCombinedOffset.Controls.Add(Me.grpShiftOffset)
    Me.grpCombinedOffset.Controls.Add(Me.grpCombinedOffsetDetail)
    Me.grpCombinedOffset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpCombinedOffset.ForeColor = System.Drawing.Color.DarkRed
    Me.grpCombinedOffset.Location = New System.Drawing.Point(7, 138)
    Me.grpCombinedOffset.Name = "grpCombinedOffset"
    Me.grpCombinedOffset.Padding = New System.Windows.Forms.Padding(0)
    Me.grpCombinedOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpCombinedOffset.Size = New System.Drawing.Size(354, 475)
    Me.grpCombinedOffset.TabIndex = 1
    Me.grpCombinedOffset.TabStop = False
    '
    'SSTab1
    '
    Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
    Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
    Me.SSTab1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
    Me.SSTab1.Location = New System.Drawing.Point(3, 334)
    Me.SSTab1.Name = "SSTab1"
    Me.SSTab1.SelectedIndex = 0
    Me.SSTab1.Size = New System.Drawing.Size(352, 142)
    Me.SSTab1.TabIndex = 161
    '
    '_SSTab1_TabPage0
    '
    Me._SSTab1_TabPage0.Controls.Add(Me.Label1)
    Me._SSTab1_TabPage0.Controls.Add(Me.Label29)
    Me._SSTab1_TabPage0.Controls.Add(Me.txtRLimit)
    Me._SSTab1_TabPage0.Controls.Add(Me.cmdOKLimits)
    Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
    Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
    Me._SSTab1_TabPage0.Size = New System.Drawing.Size(344, 116)
    Me._SSTab1_TabPage0.TabIndex = 0
    Me._SSTab1_TabPage0.Text = "Limits"
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.SystemColors.Control
    Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.Location = New System.Drawing.Point(204, 74)
    Me.Label1.Name = "Label1"
    Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label1.Size = New System.Drawing.Size(66, 15)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "degrees"
    '
    'Label29
    '
    Me.Label29.BackColor = System.Drawing.SystemColors.Control
    Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label29.Location = New System.Drawing.Point(13, 74)
    Me.Label29.Name = "Label29"
    Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label29.Size = New System.Drawing.Size(133, 15)
    Me.Label29.TabIndex = 9
    Me.Label29.Text = "Rotation Offset Limit Value"
    '
    'txtRLimit
    '
    Me.txtRLimit.AcceptsReturn = True
    Me.txtRLimit.BackColor = System.Drawing.SystemColors.Window
    Me.txtRLimit.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtRLimit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRLimit.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtRLimit.Location = New System.Drawing.Point(150, 72)
    Me.txtRLimit.MaxLength = 0
    Me.txtRLimit.Name = "txtRLimit"
    Me.txtRLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtRLimit.Size = New System.Drawing.Size(48, 20)
    Me.txtRLimit.TabIndex = 3
    '
    'cmdOKLimits
    '
    Me.cmdOKLimits.BackColor = System.Drawing.SystemColors.Control
    Me.cmdOKLimits.Cursor = System.Windows.Forms.Cursors.Default
    Me.cmdOKLimits.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdOKLimits.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmdOKLimits.Location = New System.Drawing.Point(7, 263)
    Me.cmdOKLimits.Name = "cmdOKLimits"
    Me.cmdOKLimits.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cmdOKLimits.Size = New System.Drawing.Size(81, 25)
    Me.cmdOKLimits.TabIndex = 19
    Me.cmdOKLimits.Text = "OK"
    Me.cmdOKLimits.UseVisualStyleBackColor = False
    '
    '_SSTab1_TabPage1
    '
    Me._SSTab1_TabPage1.Controls.Add(Me.cmdOKGeneralSettings)
    Me._SSTab1_TabPage1.Controls.Add(Me.txtRetryCountLimit)
    Me._SSTab1_TabPage1.Controls.Add(Me.txtSnapAfterLocate)
    Me._SSTab1_TabPage1.Controls.Add(Me._lblSnapAfterLocate_0)
    Me._SSTab1_TabPage1.Controls.Add(Me._Label8_3)
    Me._SSTab1_TabPage1.Controls.Add(Me._Label8_2)
    Me._SSTab1_TabPage1.Controls.Add(Me._lblSnapAfterLocate_1)
    Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
    Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
    Me._SSTab1_TabPage1.Size = New System.Drawing.Size(344, 116)
    Me._SSTab1_TabPage1.TabIndex = 1
    Me._SSTab1_TabPage1.Text = "General Settings"
    '
    'cmdOKGeneralSettings
    '
    Me.cmdOKGeneralSettings.BackColor = System.Drawing.SystemColors.Control
    Me.cmdOKGeneralSettings.Cursor = System.Windows.Forms.Cursors.Default
    Me.cmdOKGeneralSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdOKGeneralSettings.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmdOKGeneralSettings.Location = New System.Drawing.Point(5, 263)
    Me.cmdOKGeneralSettings.Name = "cmdOKGeneralSettings"
    Me.cmdOKGeneralSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cmdOKGeneralSettings.Size = New System.Drawing.Size(81, 25)
    Me.cmdOKGeneralSettings.TabIndex = 30
    Me.cmdOKGeneralSettings.Text = "OK"
    Me.cmdOKGeneralSettings.UseVisualStyleBackColor = False
    '
    'txtRetryCountLimit
    '
    Me.txtRetryCountLimit.AcceptsReturn = True
    Me.txtRetryCountLimit.BackColor = System.Drawing.SystemColors.Window
    Me.txtRetryCountLimit.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtRetryCountLimit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRetryCountLimit.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtRetryCountLimit.Location = New System.Drawing.Point(151, 60)
    Me.txtRetryCountLimit.MaxLength = 0
    Me.txtRetryCountLimit.Name = "txtRetryCountLimit"
    Me.txtRetryCountLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtRetryCountLimit.Size = New System.Drawing.Size(48, 20)
    Me.txtRetryCountLimit.TabIndex = 27
    '
    'txtSnapAfterLocate
    '
    Me.txtSnapAfterLocate.AcceptsReturn = True
    Me.txtSnapAfterLocate.BackColor = System.Drawing.SystemColors.Window
    Me.txtSnapAfterLocate.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtSnapAfterLocate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSnapAfterLocate.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtSnapAfterLocate.Location = New System.Drawing.Point(152, 4)
    Me.txtSnapAfterLocate.MaxLength = 0
    Me.txtSnapAfterLocate.Name = "txtSnapAfterLocate"
    Me.txtSnapAfterLocate.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtSnapAfterLocate.Size = New System.Drawing.Size(48, 20)
    Me.txtSnapAfterLocate.TabIndex = 10
    '
    '_lblSnapAfterLocate_0
    '
    Me._lblSnapAfterLocate_0.BackColor = System.Drawing.SystemColors.Control
    Me._lblSnapAfterLocate_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblSnapAfterLocate_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblSnapAfterLocate_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblSnapAfterLocate_0.Location = New System.Drawing.Point(14, 57)
    Me._lblSnapAfterLocate_0.Name = "_lblSnapAfterLocate_0"
    Me._lblSnapAfterLocate_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblSnapAfterLocate_0.Size = New System.Drawing.Size(133, 43)
    Me._lblSnapAfterLocate_0.TabIndex = 29
    Me._lblSnapAfterLocate_0.Text = "Number of times to try to find a contour before reporting an error"
    '
    '_Label8_3
    '
    Me._Label8_3.BackColor = System.Drawing.SystemColors.Control
    Me._Label8_3.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label8_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._Label8_3.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label8_3.Location = New System.Drawing.Point(204, 115)
    Me._Label8_3.Name = "_Label8_3"
    Me._Label8_3.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label8_3.Size = New System.Drawing.Size(66, 15)
    Me._Label8_3.TabIndex = 28
    Me._Label8_3.Text = "counts"
    '
    '_Label8_2
    '
    Me._Label8_2.BackColor = System.Drawing.SystemColors.Control
    Me._Label8_2.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label8_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._Label8_2.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label8_2.Location = New System.Drawing.Point(205, 6)
    Me._Label8_2.Name = "_Label8_2"
    Me._Label8_2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label8_2.Size = New System.Drawing.Size(66, 15)
    Me._Label8_2.TabIndex = 12
    Me._Label8_2.Text = "milliseconds"
    '
    '_lblSnapAfterLocate_1
    '
    Me._lblSnapAfterLocate_1.BackColor = System.Drawing.SystemColors.Control
    Me._lblSnapAfterLocate_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._lblSnapAfterLocate_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me._lblSnapAfterLocate_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me._lblSnapAfterLocate_1.Location = New System.Drawing.Point(15, 6)
    Me._lblSnapAfterLocate_1.Name = "_lblSnapAfterLocate_1"
    Me._lblSnapAfterLocate_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._lblSnapAfterLocate_1.Size = New System.Drawing.Size(133, 69)
    Me._lblSnapAfterLocate_1.TabIndex = 11
    Me._lblSnapAfterLocate_1.Text = "Time to wait after vision locaton before snapping a picture."
    '
    'grpCommStatus
    '
    Me.grpCommStatus.Controls.Add(Me.txtCommStatus)
    Me.grpCommStatus.Location = New System.Drawing.Point(6, 17)
    Me.grpCommStatus.Name = "grpCommStatus"
    Me.grpCommStatus.Size = New System.Drawing.Size(343, 121)
    Me.grpCommStatus.TabIndex = 219
    Me.grpCommStatus.TabStop = False
    Me.grpCommStatus.Text = "Serial Communication Status"
    '
    'txtCommStatus
    '
    Me.txtCommStatus.AcceptsReturn = True
    Me.txtCommStatus.BackColor = System.Drawing.SystemColors.Window
    Me.txtCommStatus.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtCommStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCommStatus.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtCommStatus.Location = New System.Drawing.Point(2, 21)
    Me.txtCommStatus.MaxLength = 0
    Me.txtCommStatus.Multiline = True
    Me.txtCommStatus.Name = "txtCommStatus"
    Me.txtCommStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtCommStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtCommStatus.Size = New System.Drawing.Size(337, 93)
    Me.txtCommStatus.TabIndex = 89
    '
    'grpShiftOffset
    '
    Me.grpShiftOffset.Controls.Add(Me.updnXShift)
    Me.grpShiftOffset.Controls.Add(Me.updnYShift)
    Me.grpShiftOffset.Controls.Add(Me.Label21)
    Me.grpShiftOffset.Controls.Add(Me.Label20)
    Me.grpShiftOffset.Controls.Add(Me.Label18)
    Me.grpShiftOffset.Controls.Add(Me.updnRLinear)
    Me.grpShiftOffset.Controls.Add(Me.Label19)
    Me.grpShiftOffset.Controls.Add(Me.Label8)
    Me.grpShiftOffset.Controls.Add(Me.Label7)
    Me.grpShiftOffset.Controls.Add(Me.Label14)
    Me.grpShiftOffset.Controls.Add(Me.updnRShift)
    Me.grpShiftOffset.Controls.Add(Me.Label15)
    Me.grpShiftOffset.Controls.Add(Me.Label13)
    Me.grpShiftOffset.Controls.Add(Me.Label23)
    Me.grpShiftOffset.ForeColor = System.Drawing.Color.Navy
    Me.grpShiftOffset.Location = New System.Drawing.Point(8, 226)
    Me.grpShiftOffset.Name = "grpShiftOffset"
    Me.grpShiftOffset.Size = New System.Drawing.Size(343, 102)
    Me.grpShiftOffset.TabIndex = 218
    Me.grpShiftOffset.TabStop = False
    Me.grpShiftOffset.Text = "Shift Offset"
    '
    'updnXShift
    '
    Me.updnXShift.DecimalPlaces = 1
    Me.updnXShift.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
    Me.updnXShift.Location = New System.Drawing.Point(2, 32)
    Me.updnXShift.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
    Me.updnXShift.Minimum = New Decimal(New Integer() {500, 0, 0, -2147483648})
    Me.updnXShift.Name = "updnXShift"
    Me.updnXShift.Size = New System.Drawing.Size(67, 22)
    Me.updnXShift.TabIndex = 237
    Me.updnXShift.Tag = ""
    Me.updnXShift.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnXShift.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'updnYShift
    '
    Me.updnYShift.DecimalPlaces = 1
    Me.updnYShift.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
    Me.updnYShift.Location = New System.Drawing.Point(114, 32)
    Me.updnYShift.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
    Me.updnYShift.Minimum = New Decimal(New Integer() {500, 0, 0, -2147483648})
    Me.updnYShift.Name = "updnYShift"
    Me.updnYShift.Size = New System.Drawing.Size(67, 22)
    Me.updnYShift.TabIndex = 236
    Me.updnYShift.Tag = ""
    Me.updnYShift.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnYShift.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label21
    '
    Me.Label21.BackColor = System.Drawing.Color.Transparent
    Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.Label21.ForeColor = System.Drawing.Color.Navy
    Me.Label21.Location = New System.Drawing.Point(107, 55)
    Me.Label21.Name = "Label21"
    Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label21.Size = New System.Drawing.Size(74, 25)
    Me.Label21.TabIndex = 227
    Me.Label21.Text = "+ is West"
    '
    'Label20
    '
    Me.Label20.BackColor = System.Drawing.Color.Transparent
    Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.Label20.ForeColor = System.Drawing.Color.Navy
    Me.Label20.Location = New System.Drawing.Point(1, 55)
    Me.Label20.Name = "Label20"
    Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label20.Size = New System.Drawing.Size(74, 25)
    Me.Label20.TabIndex = 226
    Me.Label20.Text = "+ is North"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.Location = New System.Drawing.Point(300, 78)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(32, 16)
    Me.Label18.TabIndex = 225
    Me.Label18.Text = "mm"
    '
    'updnRLinear
    '
    Me.updnRLinear.DecimalPlaces = 1
    Me.updnRLinear.Location = New System.Drawing.Point(229, 75)
    Me.updnRLinear.Name = "updnRLinear"
    Me.updnRLinear.Size = New System.Drawing.Size(66, 22)
    Me.updnRLinear.TabIndex = 224
    Me.updnRLinear.Tag = ""
    Me.updnRLinear.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnRLinear.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label19
    '
    Me.Label19.BackColor = System.Drawing.Color.Transparent
    Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.Label19.ForeColor = System.Drawing.Color.Navy
    Me.Label19.Location = New System.Drawing.Point(229, 56)
    Me.Label19.Name = "Label19"
    Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label19.Size = New System.Drawing.Size(120, 16)
    Me.Label19.TabIndex = 223
    Me.Label19.Text = "Linear Rotation"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(301, 34)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(32, 16)
    Me.Label8.TabIndex = 219
    Me.Label8.Text = "deg"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(184, 36)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(32, 16)
    Me.Label7.TabIndex = 218
    Me.Label7.Text = "mm"
    '
    'Label14
    '
    Me.Label14.BackColor = System.Drawing.Color.Transparent
    Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label14.Location = New System.Drawing.Point(145, 13)
    Me.Label14.Name = "Label14"
    Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label14.Size = New System.Drawing.Size(34, 17)
    Me.Label14.TabIndex = 8
    Me.Label14.Text = "Y"
    '
    'updnRShift
    '
    Me.updnRShift.DecimalPlaces = 3
    Me.updnRShift.Location = New System.Drawing.Point(228, 32)
    Me.updnRShift.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
    Me.updnRShift.Name = "updnRShift"
    Me.updnRShift.Size = New System.Drawing.Size(67, 22)
    Me.updnRShift.TabIndex = 217
    Me.updnRShift.Tag = ""
    Me.updnRShift.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    Me.updnRShift.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label15
    '
    Me.Label15.BackColor = System.Drawing.Color.Transparent
    Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label15.Location = New System.Drawing.Point(28, 15)
    Me.Label15.Name = "Label15"
    Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label15.Size = New System.Drawing.Size(34, 17)
    Me.Label15.TabIndex = 9
    Me.Label15.Text = "X"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.Location = New System.Drawing.Point(72, 35)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(32, 16)
    Me.Label13.TabIndex = 212
    Me.Label13.Text = "mm"
    '
    'Label23
    '
    Me.Label23.BackColor = System.Drawing.Color.Transparent
    Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label23.Location = New System.Drawing.Point(248, 13)
    Me.Label23.Name = "Label23"
    Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label23.Size = New System.Drawing.Size(34, 16)
    Me.Label23.TabIndex = 169
    Me.Label23.Text = "R"
    '
    'grpCombinedOffsetDetail
    '
    Me.grpCombinedOffsetDetail.Controls.Add(Me.txtRCombined)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.txtYCombined)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.Label28)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.txtXCombined)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.Label9)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.lblVisionTimeBoth)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.Label27)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.Label25)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.Label24)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.Label22)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.lblPiece2DescY)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.lblPiece2DescX)
    Me.grpCombinedOffsetDetail.Controls.Add(Me.lblPiece2DescR)
    Me.grpCombinedOffsetDetail.ForeColor = System.Drawing.Color.Navy
    Me.grpCombinedOffsetDetail.Location = New System.Drawing.Point(8, 144)
    Me.grpCombinedOffsetDetail.Name = "grpCombinedOffsetDetail"
    Me.grpCombinedOffsetDetail.Size = New System.Drawing.Size(343, 72)
    Me.grpCombinedOffsetDetail.TabIndex = 201
    Me.grpCombinedOffsetDetail.TabStop = False
    Me.grpCombinedOffsetDetail.Text = "Final Offset"
    '
    'txtRCombined
    '
    Me.txtRCombined.AcceptsReturn = True
    Me.txtRCombined.BackColor = System.Drawing.SystemColors.Control
    Me.txtRCombined.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtRCombined.Enabled = False
    Me.txtRCombined.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRCombined.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtRCombined.Location = New System.Drawing.Point(188, 31)
    Me.txtRCombined.MaxLength = 0
    Me.txtRCombined.Name = "txtRCombined"
    Me.txtRCombined.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtRCombined.Size = New System.Drawing.Size(65, 20)
    Me.txtRCombined.TabIndex = 236
    '
    'txtYCombined
    '
    Me.txtYCombined.AcceptsReturn = True
    Me.txtYCombined.BackColor = System.Drawing.SystemColors.Control
    Me.txtYCombined.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtYCombined.Enabled = False
    Me.txtYCombined.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtYCombined.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtYCombined.Location = New System.Drawing.Point(96, 31)
    Me.txtYCombined.MaxLength = 0
    Me.txtYCombined.Name = "txtYCombined"
    Me.txtYCombined.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtYCombined.Size = New System.Drawing.Size(65, 20)
    Me.txtYCombined.TabIndex = 235
    '
    'Label28
    '
    Me.Label28.AutoSize = True
    Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label28.Location = New System.Drawing.Point(331, 33)
    Me.Label28.Name = "Label28"
    Me.Label28.Size = New System.Drawing.Size(14, 16)
    Me.Label28.TabIndex = 224
    Me.Label28.Text = "s"
    '
    'txtXCombined
    '
    Me.txtXCombined.AcceptsReturn = True
    Me.txtXCombined.BackColor = System.Drawing.SystemColors.Control
    Me.txtXCombined.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.txtXCombined.Enabled = False
    Me.txtXCombined.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtXCombined.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtXCombined.Location = New System.Drawing.Point(2, 31)
    Me.txtXCombined.MaxLength = 0
    Me.txtXCombined.Name = "txtXCombined"
    Me.txtXCombined.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.txtXCombined.Size = New System.Drawing.Size(65, 20)
    Me.txtXCombined.TabIndex = 234
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(348, 32)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(32, 16)
    Me.Label9.TabIndex = 223
    Me.Label9.Text = "deg"
    '
    'lblVisionTimeBoth
    '
    Me.lblVisionTimeBoth.BackColor = System.Drawing.Color.Transparent
    Me.lblVisionTimeBoth.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblVisionTimeBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.lblVisionTimeBoth.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblVisionTimeBoth.Location = New System.Drawing.Point(291, 14)
    Me.lblVisionTimeBoth.Name = "lblVisionTimeBoth"
    Me.lblVisionTimeBoth.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblVisionTimeBoth.Size = New System.Drawing.Size(42, 16)
    Me.lblVisionTimeBoth.TabIndex = 222
    Me.lblVisionTimeBoth.Text = "Time"
    '
    'Label27
    '
    Me.Label27.BackColor = System.Drawing.SystemColors.Control
    Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label27.Location = New System.Drawing.Point(288, 31)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(44, 20)
    Me.Label27.TabIndex = 221
    Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label25.Location = New System.Drawing.Point(254, 32)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(32, 16)
    Me.Label25.TabIndex = 220
    Me.Label25.Text = "deg"
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label24.Location = New System.Drawing.Point(160, 33)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(32, 16)
    Me.Label24.TabIndex = 214
    Me.Label24.Text = "mm"
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label22.Location = New System.Drawing.Point(66, 32)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(32, 16)
    Me.Label22.TabIndex = 213
    Me.Label22.Text = "mm"
    '
    'lblPiece2DescY
    '
    Me.lblPiece2DescY.BackColor = System.Drawing.Color.Transparent
    Me.lblPiece2DescY.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblPiece2DescY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.lblPiece2DescY.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblPiece2DescY.Location = New System.Drawing.Point(125, 13)
    Me.lblPiece2DescY.Name = "lblPiece2DescY"
    Me.lblPiece2DescY.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblPiece2DescY.Size = New System.Drawing.Size(34, 17)
    Me.lblPiece2DescY.TabIndex = 177
    Me.lblPiece2DescY.Text = "Y"
    '
    'lblPiece2DescX
    '
    Me.lblPiece2DescX.BackColor = System.Drawing.Color.Transparent
    Me.lblPiece2DescX.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblPiece2DescX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.lblPiece2DescX.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblPiece2DescX.Location = New System.Drawing.Point(28, 13)
    Me.lblPiece2DescX.Name = "lblPiece2DescX"
    Me.lblPiece2DescX.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblPiece2DescX.Size = New System.Drawing.Size(34, 17)
    Me.lblPiece2DescX.TabIndex = 178
    Me.lblPiece2DescX.Text = "X"
    '
    'lblPiece2DescR
    '
    Me.lblPiece2DescR.BackColor = System.Drawing.Color.Transparent
    Me.lblPiece2DescR.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblPiece2DescR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.lblPiece2DescR.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblPiece2DescR.Location = New System.Drawing.Point(217, 13)
    Me.lblPiece2DescR.Name = "lblPiece2DescR"
    Me.lblPiece2DescR.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lblPiece2DescR.Size = New System.Drawing.Size(34, 16)
    Me.lblPiece2DescR.TabIndex = 183
    Me.lblPiece2DescR.Text = "R"
    '
    'grpVBErrors
    '
    Me.grpVBErrors.BackColor = System.Drawing.Color.LightSteelBlue
    Me.grpVBErrors.Controls.Add(Me.lstVBError)
    Me.grpVBErrors.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpVBErrors.ForeColor = System.Drawing.Color.DarkRed
    Me.grpVBErrors.Location = New System.Drawing.Point(7, 647)
    Me.grpVBErrors.Name = "grpVBErrors"
    Me.grpVBErrors.Padding = New System.Windows.Forms.Padding(0)
    Me.grpVBErrors.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.grpVBErrors.Size = New System.Drawing.Size(359, 286)
    Me.grpVBErrors.TabIndex = 23
    Me.grpVBErrors.TabStop = False
    Me.grpVBErrors.Text = "Program Notifications   (Double Click to Clear)"
    '
    'lstVBError
    '
    Me.lstVBError.BackColor = System.Drawing.Color.LightSteelBlue
    Me.lstVBError.Cursor = System.Windows.Forms.Cursors.Default
    Me.lstVBError.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstVBError.ForeColor = System.Drawing.SystemColors.WindowText
    Me.lstVBError.HorizontalScrollbar = True
    Me.lstVBError.ItemHeight = 14
    Me.lstVBError.Location = New System.Drawing.Point(13, 17)
    Me.lstVBError.Name = "lstVBError"
    Me.lstVBError.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.lstVBError.ScrollAlwaysVisible = True
    Me.lstVBError.Size = New System.Drawing.Size(340, 256)
    Me.lstVBError.TabIndex = 24
    Me.lstVBError.TabStop = False
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.CausesValidation = False
    Me.ClientSize = New System.Drawing.Size(1904, 1041)
    Me.Controls.Add(Me.GrpRobot)
    Me.Controls.Add(Me.lblPartLoaded)
    Me.Controls.Add(Me.lblPartTitle)
    Me.Controls.Add(Me.MainMenu1)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.MaximumSize = New System.Drawing.Size(1920, 1080)
    Me.Name = "frmMain"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Line 8 Mask Unload"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.MainMenu1.ResumeLayout(False)
    Me.MainMenu1.PerformLayout()
    CType(Me.updnExposureNorth, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.updnContrastNorth, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpRobot.ResumeLayout(False)
    Me.GrpRobot.PerformLayout()
    CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tabCameraControls.ResumeLayout(False)
    Me.tabVisionBoth.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me._Frame1_1.ResumeLayout(False)
    Me._Frame1_1.PerformLayout()
    Me._Frame1_0.ResumeLayout(False)
    Me._Frame1_0.PerformLayout()
    Me.tabVisionNorth.ResumeLayout(False)
    Me.grpVisionNorth.ResumeLayout(False)
    Me.grpVisionStatusNorthMask.ResumeLayout(False)
    Me.grpVisionStatusNorthMask.PerformLayout()
    CType(Me.updnScoreLimitNorthMask, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox6.ResumeLayout(False)
    Me.GroupBox6.PerformLayout()
    CType(Me.pctTemperatureNorth, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpCameraControlsNorth.ResumeLayout(False)
    Me.grpCameraControlsNorth.PerformLayout()
    Me.grpVisionStatusNorthGlass.ResumeLayout(False)
    Me.grpVisionStatusNorthGlass.PerformLayout()
    CType(Me.updnScoreLimitNorthGlass, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpHSDisplayNorth.ResumeLayout(False)
    CType(Me.HSDisplayNorth, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpLocatorControlsNorth.ResumeLayout(False)
    Me.tabVisionSouth.ResumeLayout(False)
    Me.grpVisionSouth.ResumeLayout(False)
    Me.grpLocatorControlsSouthGlass.ResumeLayout(False)
    Me.grpVisionStatusSouthGlass.ResumeLayout(False)
    Me.grpVisionStatusSouthGlass.PerformLayout()
    CType(Me.updnScoreLimitSouthGlass, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpCameraStatusSouth.ResumeLayout(False)
    Me.grpCameraStatusSouth.PerformLayout()
    CType(Me.pctTemperatureSouth, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpLocatorControlsSouthMask.ResumeLayout(False)
    Me.grpHSDisplaySouth.ResumeLayout(False)
    CType(Me.HSDisplaySouth, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpCameraControlsSouth.ResumeLayout(False)
    Me.grpCameraControlsSouth.PerformLayout()
    CType(Me.updnContrastSouth, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.updnExposureSouth, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpVisionStatusSouthMask.ResumeLayout(False)
    Me.grpVisionStatusSouthMask.PerformLayout()
    CType(Me.updnScoreLimitSouthMask, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tabVisionDebug.ResumeLayout(False)
    Me.grpMisc.ResumeLayout(False)
    CType(Me.updnRLimit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpMaskCombined.ResumeLayout(False)
    Me.grpGlassCombined.ResumeLayout(False)
    Me.grpCombinedOffset.ResumeLayout(False)
    Me.SSTab1.ResumeLayout(False)
    Me._SSTab1_TabPage0.ResumeLayout(False)
    Me._SSTab1_TabPage0.PerformLayout()
    Me._SSTab1_TabPage1.ResumeLayout(False)
    Me._SSTab1_TabPage1.PerformLayout()
    Me.grpCommStatus.ResumeLayout(False)
    Me.grpCommStatus.PerformLayout()
    Me.grpShiftOffset.ResumeLayout(False)
    Me.grpShiftOffset.PerformLayout()
    CType(Me.updnXShift, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.updnYShift, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.updnRLinear, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.updnRShift, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpCombinedOffsetDetail.ResumeLayout(False)
    Me.grpCombinedOffsetDetail.PerformLayout()
    Me.grpVBErrors.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Public WithEvents tmrDelay As System.Windows.Forms.Timer
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Public WithEvents mnuSeperator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuVerifyVisionAccuracy As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents TmrPassword As System.Windows.Forms.Timer
  Friend WithEvents tmrDisplayUpdate As System.Windows.Forms.Timer
  Friend WithEvents mnuCalibration As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuModifyHexsightControls As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCalibrateNorth As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ErrorProvider1 As ErrorProvider
  Friend WithEvents mnuCalibrateSouth As ToolStripMenuItem
  Friend WithEvents GrpRobot As System.Windows.Forms.GroupBox
  Friend WithEvents lblPhone As System.Windows.Forms.Label
  Friend WithEvents picLogo As System.Windows.Forms.PictureBox
  Friend WithEvents tabCameraControls As System.Windows.Forms.TabControl
  Friend WithEvents tabVisionBoth As System.Windows.Forms.TabPage
  Friend WithEvents grpSouth As System.Windows.Forms.GroupBox
  Friend WithEvents grpNorth As System.Windows.Forms.GroupBox
  Friend WithEvents tabVisionNorth As System.Windows.Forms.TabPage
  Public WithEvents grpVisionNorth As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
  Friend WithEvents lblCameraStatusNorth As System.Windows.Forms.Label
  Public WithEvents lblTemperatureNorth As System.Windows.Forms.Label
  Friend WithEvents pctTemperatureNorth As System.Windows.Forms.PictureBox
  Public WithEvents grpCameraControlsNorth As System.Windows.Forms.GroupBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents lblContrastValueNorth As System.Windows.Forms.Label
  Friend WithEvents lblBrightnessValueNorth As System.Windows.Forms.Label
  Friend WithEvents lblExposureValueNorth As System.Windows.Forms.Label
  Friend WithEvents lblContrastNorth As System.Windows.Forms.Label
  Friend WithEvents lblExposureNorth As System.Windows.Forms.Label
  Public WithEvents updnContrastNorth As System.Windows.Forms.NumericUpDown
  Public WithEvents updnExposureNorth As System.Windows.Forms.NumericUpDown
  Public WithEvents btnSnapNorth As System.Windows.Forms.Button
  Public WithEvents chkSnapRepeatNorth As System.Windows.Forms.CheckBox
  Public WithEvents lblCameraTimeNorth As System.Windows.Forms.Label
  Public WithEvents grpVisionStatusNorthGlass As System.Windows.Forms.GroupBox
  Friend WithEvents lblVisionPoseScoreNorthGlass As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseTimeNorthGlass As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseRNorthGlass As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseYNorthGlass As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseXNorthGlass As System.Windows.Forms.Label
  Public WithEvents btnDetailsNorthGlass As System.Windows.Forms.Button
  Public WithEvents lblVisionMessageNorthGlass As System.Windows.Forms.Label
  Public WithEvents lblVisionXNorth As System.Windows.Forms.Label
  Public WithEvents lblVisionYNorth As System.Windows.Forms.Label
  Public WithEvents lblVisionAngleNorth As System.Windows.Forms.Label
  Public WithEvents lblVisionTimeNorth As System.Windows.Forms.Label
  Public WithEvents lblVisionScoreNorth As System.Windows.Forms.Label
  Public WithEvents grpHSDisplayNorth As System.Windows.Forms.GroupBox
  Friend WithEvents cboCameras As System.Windows.Forms.ComboBox
  Public WithEvents HSDisplayNorth As AxHSDISPLAYLib.AxHSDisplay
  Public WithEvents grpLocatorControlsNorth As System.Windows.Forms.GroupBox
  Public WithEvents btnSearchSettingsNorthGlass As System.Windows.Forms.Button
  Public WithEvents btnLocateOnlyNorthGlass As System.Windows.Forms.Button
  Public WithEvents btnLocateNorthGlass As System.Windows.Forms.Button
  Public WithEvents chkLocateRepeatNorthGlass As System.Windows.Forms.CheckBox
  Public WithEvents btnTrainNewNorthGlass As System.Windows.Forms.Button
  Public WithEvents btnTrainExistingNorthGlass As System.Windows.Forms.Button
  Friend WithEvents tabVisionSouth As System.Windows.Forms.TabPage
  Public WithEvents grpVisionSouth As System.Windows.Forms.GroupBox
  Friend WithEvents grpCameraStatusSouth As System.Windows.Forms.GroupBox
  Friend WithEvents lblCameraStatusSouth As System.Windows.Forms.Label
  Public WithEvents lblTemperatureSouth As System.Windows.Forms.Label
  Friend WithEvents pctTemperatureSouth As System.Windows.Forms.PictureBox
  Public WithEvents grpLocatorControlsSouthMask As System.Windows.Forms.GroupBox
  Public WithEvents btnLocateOnlySouthMask As System.Windows.Forms.Button
  Public WithEvents btnLocateSouthMask As System.Windows.Forms.Button
  Public WithEvents chkLocateRepeatSouthMask As System.Windows.Forms.CheckBox
  Public WithEvents btnSearchSettingsSouthMask As System.Windows.Forms.Button
  Public WithEvents btnTrainNewSouthMask As System.Windows.Forms.Button
  Public WithEvents btnTrainExistingSouthMask As System.Windows.Forms.Button
  Public WithEvents grpHSDisplaySouth As System.Windows.Forms.GroupBox
  Public WithEvents HSDisplaySouth As AxHSDISPLAYLib.AxHSDisplay
  Public WithEvents grpCameraControlsSouth As System.Windows.Forms.GroupBox
  Friend WithEvents Label31 As System.Windows.Forms.Label
  Friend WithEvents lblContrastValueSouth As System.Windows.Forms.Label
  Friend WithEvents lblBrightnessValueSouth As System.Windows.Forms.Label
  Friend WithEvents lblExposureValueSouth As System.Windows.Forms.Label
  Friend WithEvents lblContrastSouth As System.Windows.Forms.Label
  Friend WithEvents lblExposureSouth As System.Windows.Forms.Label
  Public WithEvents updnContrastSouth As System.Windows.Forms.NumericUpDown
  Public WithEvents updnExposureSouth As System.Windows.Forms.NumericUpDown
  Public WithEvents btnSnapSouth As System.Windows.Forms.Button
  Public WithEvents chkSnapRepeatSouth As System.Windows.Forms.CheckBox
  Public WithEvents lblCameraTimeSouth As System.Windows.Forms.Label
  Public WithEvents grpVisionStatusSouthMask As System.Windows.Forms.GroupBox
  Friend WithEvents lblVisionPoseScoreSouthMask As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseTimeSouthMask As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseRSouthMask As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseYSouthMask As System.Windows.Forms.Label
  Friend WithEvents lblVisionPoseXSouthMask As System.Windows.Forms.Label
  Public WithEvents btnDetailsSouthMask As System.Windows.Forms.Button
  Public WithEvents lblVisionMessageSouthMask As System.Windows.Forms.Label
  Public WithEvents lblVisionXSouthMask As System.Windows.Forms.Label
  Public WithEvents lblVisionYSouthMask As System.Windows.Forms.Label
  Public WithEvents lblVisionAngleSouthMask As System.Windows.Forms.Label
  Public WithEvents lblVisionTimeSouthMask As System.Windows.Forms.Label
  Public WithEvents lblVisionScoreSouthMask As System.Windows.Forms.Label
  Public WithEvents grpCombinedOffset As System.Windows.Forms.GroupBox
  Friend WithEvents grpShiftOffset As System.Windows.Forms.GroupBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Public WithEvents Label14 As System.Windows.Forms.Label
  Public WithEvents updnRShift As System.Windows.Forms.NumericUpDown
  Public WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Public WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents grpCombinedOffsetDetail As System.Windows.Forms.GroupBox
  Public WithEvents lblPiece2DescY As System.Windows.Forms.Label
  Public WithEvents lblPiece2DescX As System.Windows.Forms.Label
  Public WithEvents lblPiece2DescR As System.Windows.Forms.Label
  Public WithEvents grpVBErrors As System.Windows.Forms.GroupBox
  Public WithEvents lstVBError As System.Windows.Forms.ListBox
  Public WithEvents lblSouthGlassPlaceHolder As Label
  Public WithEvents lblSouthMaskPlaceHolder As Label
  Public WithEvents lblNorthGlassPlaceHolder As Label
  Public WithEvents lblNorthMaskPlaceHolder As Label
  Public WithEvents _Frame1_1 As GroupBox
  Public WithEvents txtSouthSecondClick As TextBox
  Public WithEvents txtSouthFirstClick As TextBox
  Public WithEvents txtSouthDistance As TextBox
  Public WithEvents _lblPoint_5 As Label
  Public WithEvents _lblPoint_4 As Label
  Public WithEvents _lblPoint_3 As Label
  Public WithEvents _Frame1_0 As GroupBox
  Public WithEvents txtCombinedOneHalf As TextBox
  Public WithEvents txtNorthDistance As TextBox
  Public WithEvents txtNorthFirstClick As TextBox
  Public WithEvents txtNorthSecondClick As TextBox
  Public WithEvents Label5 As Label
  Public WithEvents _lblPoint_2 As Label
  Public WithEvents _lblPoint_0 As Label
  Public WithEvents _lblPoint_1 As Label
  Public WithEvents txtCommStatus As TextBox
  Friend WithEvents Label18 As Label
  Public WithEvents updnRLinear As NumericUpDown
  Public WithEvents Label19 As Label
  Public WithEvents Label21 As Label
  Public WithEvents Label20 As Label
  Friend WithEvents Label25 As Label
  Friend WithEvents Label24 As Label
  Friend WithEvents Label22 As Label
  Public WithEvents GroupBox1 As GroupBox
  Public WithEvents btnClearMarkersBoth As Button
  Public WithEvents chkRepeatSnapBoth As CheckBox
  Public WithEvents btnSnapBoth As Button
  Public WithEvents btnLocateBoth As Button
  Public WithEvents chkRepeatLocateBoth As CheckBox
  Friend WithEvents grpCommStatus As GroupBox
  Friend WithEvents Label28 As Label
  Friend WithEvents Label9 As Label
  Public WithEvents lblVisionTimeBoth As Label
  Friend WithEvents Label27 As Label
  Public WithEvents SSTab1 As TabControl
  Public WithEvents _SSTab1_TabPage0 As TabPage
  Public WithEvents Label1 As Label
  Public WithEvents Label29 As Label
  Public WithEvents txtRLimit As TextBox
  Public WithEvents cmdOKLimits As Button
  Public WithEvents _SSTab1_TabPage1 As TabPage
  Public WithEvents cmdOKGeneralSettings As Button
  Public WithEvents txtRetryCountLimit As TextBox
  Public WithEvents txtSnapAfterLocate As TextBox
  Public WithEvents _lblSnapAfterLocate_0 As Label
  Public WithEvents _Label8_3 As Label
  Public WithEvents _Label8_2 As Label
  Public WithEvents _lblSnapAfterLocate_1 As Label
  Public WithEvents txtRCombined As TextBox
  Public WithEvents txtYCombined As TextBox
  Public WithEvents txtXCombined As TextBox
  Friend WithEvents mnuUseSouthCameraOnly As ToolStripMenuItem
  Public WithEvents grpVisionStatusNorthMask As GroupBox
  Friend WithEvents lblVisionPoseScoreNorthMask As Label
  Friend WithEvents lblVisionPoseTimeNorthMask As Label
  Friend WithEvents lblVisionPoseRNorthMask As Label
  Friend WithEvents lblVisionPoseYNorthMask As Label
  Friend WithEvents lblVisionPoseXNorthMask As Label
  Public WithEvents btnDetailsNorthMask As Button
  Public WithEvents lblVisionMessageNorthMask As Label
  Public WithEvents Label38 As Label
  Public WithEvents Label39 As Label
  Public WithEvents Label40 As Label
  Public WithEvents Label41 As Label
  Public WithEvents Label42 As Label
  Public WithEvents GroupBox2 As GroupBox
  Public WithEvents btnSearchSettingsNorthMask As Button
  Public WithEvents btnTrainNewNorthMask As Button
  Public WithEvents btnTrainExistingNorthMask As Button
  Public WithEvents btnLocateOnlyNorthMask As Button
  Public WithEvents btnLocateNorthMask As Button
  Public WithEvents chkLocateRepeatNorthMask As CheckBox
  Public WithEvents grpLocatorControlsSouthGlass As GroupBox
  Public WithEvents btnLocateOnlySouthGlass As Button
  Public WithEvents btnLocateSouthGlass As Button
  Public WithEvents chkLocateRepeatSouthGlass As CheckBox
  Public WithEvents btnSearchSettingsSouthGlass As Button
  Public WithEvents btnTrainNewSouthGlass As Button
  Public WithEvents btnTrainExistingSouthGlass As Button
  Public WithEvents grpVisionStatusSouthGlass As GroupBox
  Friend WithEvents lblVisionPoseScoreSouthGlass As Label
  Friend WithEvents lblVisionPoseTimeSouthGlass As Label
  Friend WithEvents lblVisionPoseRSouthGlass As Label
  Friend WithEvents lblVisionPoseYSouthGlass As Label
  Friend WithEvents lblVisionPoseXSouthGlass As Label
  Public WithEvents btnDetailsSouthGlass As Button
  Public WithEvents lblVisionMessageSouthGlass As Label
  Public WithEvents lblXVisionSouthGlass As Label
  Public WithEvents lblYVisionSouthGlass As Label
  Public WithEvents lblRVisionSouthGlass As Label
  Public WithEvents lblTimeVisionSouthGlass As Label
  Public WithEvents lblScoreVisionSouthGlass As Label
  Friend WithEvents lblScoreLimitSouthMask As Label
  Public WithEvents updnScoreLimitSouthMask As NumericUpDown
  Friend WithEvents lblScoreLimitNorthMask As Label
  Public WithEvents updnScoreLimitNorthMask As NumericUpDown
  Friend WithEvents lblScoreLimitNorthGlass As Label
  Public WithEvents updnScoreLimitNorthGlass As NumericUpDown
  Friend WithEvents lblScoreLimitSouthGlass As Label
  Public WithEvents updnScoreLimitSouthGlass As NumericUpDown
  Friend WithEvents tabVisionDebug As TabPage
  Public WithEvents grpMaskCombined As GroupBox
  Friend WithEvents lblMaskCombinedR As Label
  Friend WithEvents lblMaskCombinedY As Label
  Friend WithEvents lblMaskCombinedX As Label
  Public WithEvents lblMaskCombinedStatus As Label
  Public WithEvents Label35 As Label
  Public WithEvents Label36 As Label
  Public WithEvents Label37 As Label
  Public WithEvents grpGlassCombined As GroupBox
  Friend WithEvents lblGlassCombinedR As Label
  Friend WithEvents lblGlassCombinedY As Label
  Friend WithEvents lblGlassCombinedX As Label
  Public WithEvents lblGlassCombinedStatus As Label
  Public WithEvents Label30 As Label
  Public WithEvents Label32 As Label
  Public WithEvents Label33 As Label
  Public WithEvents grpMisc As GroupBox
  Public WithEvents updnRLimit As NumericUpDown
  Public WithEvents Label2 As Label
  Public WithEvents lblFinalStatus As Label
  Public WithEvents updnXShift As NumericUpDown
  Public WithEvents updnYShift As NumericUpDown
  Friend WithEvents lblSouthMaskScore As Label
  Friend WithEvents lblSouthGlassScore As Label
  Friend WithEvents lblNorthGlassScore As Label
  Friend WithEvents lblNorthMaskScore As Label
#End Region
End Class