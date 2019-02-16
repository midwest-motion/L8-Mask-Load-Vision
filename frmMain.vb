Option Strict Off
Option Explicit On
Imports System.ComponentModel
Imports VB = Microsoft.VisualBasic
Imports System.Math

Imports System.Collections.Generic

Public Class frmMain
  Inherits Windows.Forms.Form

#Region "Declarations"
  '
  'General module level variables
  Public CurrentFilePath As String 'PartsPath + PartName
  Public VisionDatabasePath As String = Application.StartupPath + "\..\..\Config Data\Vision.cfg" 'App.Path + "\..\Config Data\Vision.cfg"
  Private CalibratePath As String = ConfigPath + "Calibration.cal"
  Private NewPickup As PointData
  Public UpdatingPartData As Boolean = True
  Private Calibrating As Boolean
  Public Loading As Boolean
  Public Deleting As Boolean
  Public Message As String
  Public Side As Int16
  Public SouthAlreadySnapped As Boolean
  '
  'Vision system module variables
  Private HSApp As AxHSAPPLICATIONLib.AxHSApplication
  Private HSAcq As HSACQUISITIONDEVICELib.HSAcquisitionDevice
  Public HSDb As HSCLASSLIBRARYLib.HSDatabase
  Public ImageNorth As New HSCLASSLIBRARYLib.HSImage
  Public ImageSouth As New HSCLASSLIBRARYLib.HSImage
  Public FinalImageNorth As New HSCLASSLIBRARYLib.HSImage
  Public FinalImageSouth As New HSCLASSLIBRARYLib.HSImage
  Private HSLoc(3) As HSLOCATORLib.HSLocator
  Private Calibrate As HSACQUISITIONDEVICELib.HSCalibrationDistortionInterface
  'Public NorthCameraId As Int32 = 0
  'Public SouthCameraId As Int32 = 1
  Public helperNorth As New SnapshotHelper
  Public helperSouth As New SnapshotHelper
  Private VisionSuccess As Boolean
  Public RoughSquare As Double
  Public SaveImagePath As String
  'Menu Handling
  Public WithEvents loadABC, loadDEF, loadGHI, loadJKL, loadMNO, loadPQR, loadSTU, loadVWX, loadYZ, loadOther As New Windows.Forms.ToolStripMenuItem
  Public WithEvents deleteABC, deleteDEF, deleteGHI, deleteJKL, deleteMNO, deletePQR, deleteSTU, deleteVWX, deleteYZ, deleteOther As New Windows.Forms.ToolStripMenuItem
  '
  Public CalledFromRobot As Boolean = False
  Public OldOffsetstring As String
  Public OffsetString As String
  Public CheckString As String
  '
  'Timers
  Private WithEvents IOTimer As New Timer
#End Region

#Region "Form Load/Unload"

  Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    '    Dim Status As String
    Dim Success As Boolean
    Dim I As Integer = 0
    Try
      My.Application.Log.WriteEntry(My.Application.Info.DirectoryPath & "SquareLog.txt", 0)
      frmSplash.Show()
      frmSplash.lblStatus.Text = "Loading General Settings"
      Application.DoEvents()
      frmSplash.lblStatus.Text = "Get General Settings"
      GetSettings()
      DelayTimer(250)
      frmSplash.lblStatus.Text = "Initializing Cameras"
      Application.DoEvents()
      Success = InitCameras()
      frmSplash.lblStatus.Text = "Initializing Vision Tools"
      Success = InitVision()
      Application.DoEvents()
      frmSplash.lblStatus.Text = "Loading Part File"
      LoadPart(PartName)
      Application.DoEvents()
      DelayTimer(250) 'Needed to allow the adjustments to be applied to the next frame
      Me.Show()
      Application.DoEvents()
      ' tabCameraControls.SelectTab(tabVisionNorth)
      frmSplash.lblStatus.Text = "Done!"
      Application.DoEvents()
      DelayTimer(250)
      Me.Height = SystemInformation.PrimaryMonitorSize.Height - 40
      Me.Width = SystemInformation.PrimaryMonitorSize.Width
      Me.Show()
      Application.DoEvents()
      lblVisionMessageNorthGlass.Parent = grpVisionStatusNorthGlass
      lblVisionMessageNorthGlass.Left = 8
      lblVisionMessageNorthGlass.Top = 16
      ActivatePassword(False)
      InitializingForm = False
      UpdateUpDownControls()
      ToolTip1.AutoPopDelay = Integer.MaxValue
      Application.DoEvents()
      tmrDisplayUpdate.Enabled = True
      'Snap some pictures
      Snap(NorthSide)
      Snap(SouthSide)
      Application.DoEvents()
      'Start the timer to connect vision and PLC
      IOTimer.Interval = 250
      IOTimer.Start()
      IOTimer.Enabled = True
      'tab controls
      tabCameraControls.SelectTab(tabVisionBoth)
      tabVision(tabVisionBoth, Nothing)
      UpdatingPartData = False
      frmSplash.lblStatus.Text = "Initializing the Serial Port"
      Comm.InitComm()
      Application.DoEvents()
    Catch ex As Exception
      ShowVBErrors(Err.Description)
    Finally
      frmSplash.Hide()
    End Try
  End Sub

  Public Sub frmMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    Try
      'destroy all the vision objects
      IOTimer.Enabled = False
      'tmrTime.Enabled = False
      DelayTimer(IOTimer.Interval + 100)
      HSAcq = Nothing
      HSApp = Nothing
      HSLoc(LocNorthGlass) = Nothing
      HSLoc(LocSouthGlass) = Nothing
      HSLoc(LocNorthMask) = Nothing
      HSLoc(LocSouthMask) = Nothing
      helperNorth.ExitCamera()
      helperSouth.ExitCamera()
      helperNorth = Nothing
      helperSouth = Nothing
      End
    Catch ex As Exception
      If Me.Text <> "Loading" Then
        MsgBox("Errors were encountered While quitting", MsgBoxStyle.SystemModal)
      End If
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

#Region "Application"

  Public Sub CheckAppRunning()
    Try
      If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
        MessageBox.Show("Another Instance Of this process Is already running", "Multiple Instances Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Application.Exit()
        Me.Close()
        End
      End If
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub

  Private Sub UpdateTabs()
    tabCameraControls.Controls.Clear()
    tabCameraControls.Controls.Add(tabVisionSouth)
    tabCameraControls.Controls.Add(tabVisionNorth)
    tabCameraControls.Controls.Add(tabVisionBoth)
    tabCameraControls.Controls.Add(tabVisionDebug)
  End Sub

  Public Sub ActivatePassword(ByRef PasswordValue As Boolean)
    Try
      'tabRobot.TabPages.Clear()
      mnuPassword.Checked = PasswordValue
      mnuConfig.Enabled = PasswordValue
      mnuDeletePart.Enabled = PasswordValue
      mnuNew.Enabled = PasswordValue
      'training
      'North Glass
      btnTrainExistingNorthGlass.Enabled = PasswordValue
      btnTrainNewNorthGlass.Enabled = PasswordValue
      btnSearchSettingsNorthGlass.Enabled = PasswordValue
      'North Mask
      btnTrainExistingNorthmask.Enabled = PasswordValue
      btnTrainNewNorthmask.Enabled = PasswordValue
      btnSearchSettingsNorthmask.Enabled = PasswordValue
      'South Glass
      btnTrainExistingSouthGlass.Enabled = PasswordValue
      btnTrainNewSouthGlass.Enabled = PasswordValue
      btnSearchSettingssouthGlass.Enabled = PasswordValue
      'South Mask
      btnTrainExistingSouthMask.Enabled = PasswordValue
      btnTrainNewSouthMask.Enabled = PasswordValue
      btnSearchSettingsSouthMask.Enabled = PasswordValue
      'labels
      lblExposureNorth.Enabled = PasswordValue
      lblContrastNorth.Enabled = PasswordValue
      lblExposureSouth.Enabled = PasswordValue
      lblContrastSouth.Enabled = PasswordValue
      'undn's
      updnExposureNorth.Enabled = PasswordValue
      updnContrastNorth.Enabled = PasswordValue
      updnExposureSouth.Enabled = PasswordValue
      updnContrastSouth.Enabled = PasswordValue
      updnScoreLimitSouthMask.Enabled = PasswordValue
      updnScoreLimitNorthGlass.Enabled = PasswordValue
      updnScoreLimitNorthMask.Enabled = PasswordValue
      updnScoreLimitSouthGlass.Enabled = PasswordValue
            Exit Sub
        Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Sub ShowVBErrors(ByRef exMessage As String, Optional ByRef Message As String = "")
    Dim TimeStamp As Date
    Dim StackTrace As New Diagnostics.StackFrame(1)
    Dim StackMessage As String
    Dim StackLineNumber As Integer
    StackMessage = StackTrace.GetMethod.Name
    StackLineNumber = StackTrace.GetFileLineNumber()
    Try
      TimeStamp = Now()
      lstVBError.Items.Insert(0, Message & "  " & exMessage)
      lstVBError.Items.Insert(0, "[" & StackMessage & "]")
      'lstVBError.Items.Insert(0, "Line " & StackLineNumber.ToString & " [" & StackMessage & "] ")
      lstVBError.Items.Insert(0, "")
      If lstVBError.Items.Count > 100 Then
        lstVBError.Items.RemoveAt(99)
      End If
      Exit Sub
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub lstVBError_DoubleClick(sender As Object, e As EventArgs) Handles lstVBError.DoubleClick
    Try
      lstVBError.Items.Clear()
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

#Region "Camera"

  Private Sub SetCameraSettings()
    Dim Success As Boolean = False
    Try
      'Settings for North Camera
      Success = helperNorth.SetSimpleFeature("exposure", CSng(updnExposureNorth.Value))
      If Not Success Then ShowVBErrors("Unable To Set North Camera Exposure ")
      Success = helperNorth.SetSimpleFeature("gain", CSng(updnContrastNorth.Value))
      If Not Success Then ShowVBErrors("Unable To Set North Camera Contrast ")
      'Settings for South Camera
      Success = helperSouth.SetSimpleFeature("exposure", CSng(updnExposureSouth.Value))
      If Not Success Then ShowVBErrors("Unable To Set South Camera Exposure")
      Success = helperSouth.SetSimpleFeature("gain", CSng(updnContrastSouth.Value))
      If Not Success Then ShowVBErrors("Unable To Set South Camera Contrast ")
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Function InitCameras() As Boolean
    helperNorth.CameraId = CInt(frmDataBase.GetValue("Settings", "Value", "North Camera ID"))
    helperSouth.CameraId = CInt(frmDataBase.GetValue("Settings", "Value", "South Camera ID"))
    Try
      If helperNorth.InitCamera() Then
        InitSuccessNorth = True
      Else
        MsgBox("Could Not Initialize the North Camera ", MsgBoxStyle.Critical, "Camera Assignment Error")
      End If
      If helperSouth.InitCamera() Then
        InitSuccessSouth = True
      Else
        MsgBox("Could Not Initialize the South Camera ", MsgBoxStyle.Critical, "Camera Assignment Error")
      End If
      If InitSuccessNorth And InitSuccessSouth Then
        Return True
      End If
      Return False
    Catch ex As Exception
      ShowVBErrors(ex.Message)
      Return False
    End Try
  End Function

  Private Function GetCameraImage(ByVal Side As Integer) As Boolean
    Dim Success As Boolean = False
    Try
      If Side = NorthSide Then
        HSDisplayNorth.set_ImageName(0, "IDS Image North")
        Success = helperNorth.GetSnapshot(ImageNorth)
      Else
        HSDisplaySouth.set_ImageName(0, "IDS Image South")
        Success = helperSouth.GetSnapshot(ImageSouth)
      End If
    Catch ex As Exception
      ShowVBErrors(ex.Message)
      Success = False
      AcquisitionError(Side)
    Finally
      Cursor.Current = Cursors.Default
    End Try
    Return Success
  End Function

  Private Sub AcquisitionError(ByVal Side As Int16)
    Try
      Select Case Side
        Case NorthSide
          ImageNorth.Load(ConfigPath & "NoImage.bmp")
        Case SouthSide
          ImageSouth.Load(ConfigPath & "NoImage.bmp")
      End Select
      If InitCameras() Then
        SetCameraSettings()
      End If
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub

  Private Sub GetTemperature(ByVal helper As Object, ByVal tempLabel As Label)
    Dim Temperature As Single
    Try
      Temperature = helper.GetSimpleFeature("Temperature")
      Temperature = Temperature / 10
      tempLabel.Text = Temperature.ToString("N1") & " " & "Deg F"
      If Temperature < 110 Then
        tempLabel.BackColor = Color.AliceBlue
      ElseIf Temperature >= 110 And Temperature <= 121 Then
        tempLabel.BackColor = Color.Yellow
      ElseIf Temperature > 121 Then
        tempLabel.BackColor = Color.Red
      End If
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

#Region "Vision Controls"

  Private Sub btnTrainNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _
    btnTrainNewNorthMask.Click,
    btnTrainNewNorthGlass.Click,
    btnTrainNewSouthMask.Click,
    btnTrainNewSouthGlass.Click
    Dim Result As Short
    Dim HSModel As HSLOCATORLib.HSModelEditorInterface
    ' Dim ModelMask As HSCLASSLIBRARYLib.HSImage
    'Dim RefPick As Point
    Dim Side As Int16
    Dim TextString As String = ""
    Dim InRoutine As Boolean
    If InRoutine Then
      Exit Sub
    End If
    InRoutine = True
    Try
      Select Case eventSender.name
        Case "btnTrainNewNorthMask"
          Side = LocNorthMask
          TextString = "EXISTING mask model"
        Case "btnTrainNewSouthMask"
          Side = LocSouthMask
          TextString = "EXISTING mask model"
        Case "btnTrainNewNorthGlass"
          Side = LocNorthGlass
          TextString = "EXISTING glass model"
        Case "btnTrainNewSouthGlass"
          Side = LocSouthGlass
          TextString = "EXISTING glass model"
      End Select
      Result = MsgBox("Are you sure you want To DELETE the " & TextString & vbCr &
                  "And create a New one In it's place?",
      MsgBoxStyle.OkCancel Or MsgBoxStyle.SystemModal, "Are you Sure?")
      If Result = MsgBoxResult.Ok Then
        HSLoc(Side).NewModelDatabase()
        HSLoc(Side).AddModel(SideName(Side))
        HSModel = HSLoc(Side).ShowModelEditor(False, SideName(Side))
        With HSModel
          .FeatureSelection = HSLOCATORLib.hsModelFeatureSelection.hsFeatureSelectionNone
          .ContrastThresholdMode = HSLOCATORLib.hsContrastThresholdMode.hsContrastThresholdAdaptiveNormalSensitivity
          .AutomaticLevels = 44
          'If Side = NorthSide Then
          '  RefPick.X = 0 : RefPick.Y = -250
          '  .AddReferencePoint(RefPick.X, RefPick.Y)
          'Else
          '  RefPick.X = 0 : RefPick.Y = -250
          '  .AddReferencePoint(RefPick.X, RefPick.Y)
          'End If
          ''
          ''Set the search area to train the model
          '.BoundingAreaBottom = 110
          '.BoundingAreaTop = 2780
          '.BoundingAreaLeft = 807
          '.BoundingAreaRight = 1752
          '
          'Build the model
          .AutomaticLevels = False
          .DetailLevel = 2
          .DisplayCalibrationMode = HSLOCATORLib.hsDisplayCalibrationMode.hsDisplayCalibrated
          .BuildModel()
          Me.Hide()
          .ShowModal()
          Me.Show()
        End With
        HSLoc(Side).SaveModelDatabase(CurrentFilePath & SideName(Side) & ".hdb")
        HSLoc(Side).CompactMemory()
        Find(Side)
      End If
      InRoutine = False
      Exit Sub
    Catch ex As Exception
      MsgBox("Problem creating the model file" & vbCr &
                      "You may need need to create the model" & vbCr &
                      "through the Hexsight Interface" & vbCr &
                      Err.Description, MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal)
      InRoutine = False
    End Try
  End Sub

  Private Sub btnTrainExisting_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _
    btnTrainExistingNorthMask.Click,
    btnTrainExistingNorthGlass.Click,
    btnTrainExistingSouthMask.Click,
    btnTrainExistingSouthGlass.Click
    Dim HSModel As HSLOCATORLib.HSModelEditorInterface
    Dim Side As Int16
    Try
      'This version of the program uses the same model for both sides
      Select Case eventSender.name
        Case "btnTrainExistingNorthMask"
          Side = LocNorthMask
        Case "btnTrainExistingSouthMask"
          Side = LocSouthMask
        Case "btnTrainExistingNorthGlass"
          Side = LocNorthGlass
        Case "btnTrainExistingSouthGlass"
          Side = LocSouthGlass
      End Select
      HSModel = HSLoc(Side).ShowModelEditor(False, SideName(Side))
      With HSModel
        .AutomaticLevels = False
        .DetailLevel = 2
        .DisplayCalibrationMode = HSLOCATORLib.hsDisplayCalibrationMode.hsDisplayCalibrated
        'Show the Model Editor
        .ShowModal()
        '.FeatureSelection = HSLOCATORLib.hsModelFeatureSelection.hsFeatureSelectionNone
      End With
      HSLoc(Side).SaveModelDatabase(CurrentFilePath & SideName(Side) & ".hdb")
      HSLoc(Side).CompactMemory()
      DelayTimer(100)
      Find(Side)
      Exit Sub
    Catch ex As Exception
      MsgBox("Problem accessing the model file" & vbCr &
                          "You may need need to access the model" & vbCr &
                          "through the Hexsight Interface",
                          MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal)
    End Try
  End Sub

  Private Sub btnSnap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    btnSnapNorth.Click,
    btnSnapSouth.Click
    Try
      Select Case sender.name
        Case "btnSnapNorth"
          Do
            Snap(NorthSide)
            If chkSnapRepeatNorth.Checked Then DelayTimer(50)
          Loop While chkSnapRepeatNorth.Checked
        Case "btnSnapSouth"
          Do
            Snap(SouthSide)
            If chkSnapRepeatSouth.Checked Then DelayTimer(50)
          Loop While chkSnapRepeatSouth.Checked
      End Select
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub GetReferencePoints()
    Dim HSModel As HSLOCATORLib.HSModelEditorInterface
    Select Case Side
      Case NorthSide
        Try
          HSModel = HSLoc(NorthSide).ShowModelEditor(False, "North")
          HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
        Catch ex As Exception
          MsgBox("Problem modifying the model file reference point" & vbCr &
                          "You may need need to modify the model" & vbCr &
                          "through the Hexsight Interface" & vbCr &
                          ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
        End Try
      Case SouthSide
        Try
          HSModel = HSLoc(SouthSide).ShowModelEditor(False, "South")
          HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
        Catch ex As Exception
          MsgBox("Problem modifying the model file reference point" & vbCr &
                          "You may need need to modify the model" & vbCr &
                          "through the Hexsight Interface" & vbCr &
                          ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
        End Try
    End Select
  End Sub

  'Private Sub SetReferencePoints()
  '  Dim HSModel As HSLOCATORLib.HSModelEditorInterface
  '  Select Case Side
  '    Case NorthSide
  '      Try
  '        '
  '        'North Side
  '        HSModel = HSLoc(NorthSide).ShowModelEditor(False, "North")
  '        With HSModel
  '          Try
  '            .ReferencePointPositionX(0) = 0
  '            .ReferencePointPositionY(0) = 0
  '          Catch
  '          End Try
  '        End With
  '        HSModel.Apply()
  '        HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
  '        'Save Model Database
  '        HSLoc(NorthSide).SaveModelDatabase(CurrentFilePath & "North.hdb")
  '        HSLoc(NorthSide).CompactMemory()
  '        '
  '      Catch ex As Exception
  '        MsgBox("Problem modifying the model file reference point" & vbCr &
  '                                "You may need need to modify the model" & vbCr &
  '                                "through the Hexsight Interface" & vbCr &
  '                                ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
  '      End Try
  '    Case SouthSide
  '      Try
  '        '
  '        'South Side
  '        HSModel = HSLoc(SouthSide).ShowModelEditor(False, "South")
  '        With HSModel
  '          Try
  '            .ReferencePointPositionX(0) = 0
  '            .ReferencePointPositionY(0) = 0
  '          Catch
  '          End Try
  '        End With
  '        HSModel.Apply()
  '        HSModel.EndDialog(HSLOCATORLib.hsModelDialogResult.hsResultOK)
  '        'Save Model Database
  '        HSLoc(SouthSide).SaveModelDatabase(CurrentFilePath & "South.hdb")
  '        HSLoc(SouthSide).CompactMemory()
  '        '
  '      Catch ex As Exception
  '        MsgBox("Problem modifying the model file reference point" & vbCr &
  '                                "You may need need to modify the model" & vbCr &
  '                                "through the Hexsight Interface" & vbCr &
  '                                ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
  '      End Try
  '  End Select

  'End Sub

  Private Sub btnDetails_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDetailsNorthGlass.Click, btnDetailsSouthMask.Click
    Dim MessageID As Short
    Dim Description As String = ""
    Try
      If eventSender.name = "btnDetailsNorth" Then
        Side = NorthSide
      Else
        Side = SouthSide
      End If
      For MessageID = 0 To HSLoc(Side).MessageCount - 1
        Description = Description & HSLoc(Side).MessageDescription(MessageID) & vbCr
        'Description = Description & HSLoc(Side).get_MessageDescription(MessageID) & vbCr
      Next MessageID
      MsgBox(Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.SystemModal)
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub

  Private Sub btnSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _
    btnSearchSettingsNorthGlass.Click,
    btnSearchSettingsNorthMask.Click,
    btnSearchSettingsSouthGlass.Click,
    btnSearchSettingsSouthMask.Click
    ' Dim Success As Boolean
    Try
      Select Case eventSender.name
        Case "btnSearchSettingsNorthMask"
          HSLoc(LocNorthMask).ShowProperties(True, , 1 + 4 + 8 + 16)
        Case "btnSearchSettingsSouthMask"
          HSLoc(LocSouthMask).ShowProperties(True, , 1 + 4 + 8 + 16)
        Case "btnSearchSettingsNorthGlass"
          HSLoc(LocNorthGlass).ShowProperties(True, , 1 + 4 + 8 + 16)
        Case "btnSearchSettingsSouthGlass"
          HSLoc(LocSouthGlass).ShowProperties(True, , 1 + 4 + 8 + 16)
      End Select
      SaveHexsight()
            SaveSearchBoxesMain()
        Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub
#End Region

    Private Sub SaveSearchBoxesMain()
        SaveSearchBoxes(NorthMask, "NMask", HSLoc(LocNorthMask))
        SaveSearchBoxes(SouthMask, "SMask", HSLoc(LocSouthMask))
        SaveSearchBoxes(NorthGlass, "NGlass", HSLoc(LocNorthGlass))
        SaveSearchBoxes(SouthGlass, "SGlass", HSLoc(LocSouthGlass))
    End Sub

    Private Sub SaveSearchBoxes(SearchArea As SearchArea, DatabaseString As String, Locator As HSLOCATORLib.HSLocator)
        'This saves all of the HexSight Search Box variables
        Try
            SearchArea.CenterX = Locator.ToolPositionX
            frmDataBase.SetValue("Partdata", "Value", DatabaseString & "SearchCenterX", SearchArea.CenterX.ToString("0.00"))
            SearchArea.CenterY = Locator.ToolPositionY
            frmDataBase.SetValue("Partdata", "Value", DatabaseString & "SearchCenterY", SearchArea.CenterY.ToString("0.00"))
            SearchArea.CenterR = Locator.ToolRotation
            frmDataBase.SetValue("Partdata", "Value", DatabaseString & "SearchCenterR", SearchArea.CenterR.ToString("0.00"))
            SearchArea.Width = Locator.ToolWidth
            frmDataBase.SetValue("Partdata", "Value", DatabaseString & "SearchWidth", SearchArea.Width.ToString("0.00"))
            SearchArea.Height = Locator.ToolHeight
            frmDataBase.SetValue("Partdata", "Value", DatabaseString & "SearchWidth", SearchArea.Height.ToString("0.00"))
            ''South Mask
            'SouthMask.CenterX = HSLoc(SouthSide).ToolPositionX
            'frmDataBase.SetValue("Partdata", "Value", "SMaskSearch", SouthMask.CenterX.ToString("0.00"))
            'SouthMask.CenterY = HSLoc(SouthSide).ToolPositionY
            'frmDataBase.SetValue("Partdata", "Value", "SMaskSearchCenterY", SouthMask.CenterY.ToString("0.00"))
            'SouthMask.CenterR = HSLoc(SouthSide).ToolRotation
            'frmDataBase.SetValue("Partdata", "Value", "SMaskSearchCenterR", SouthMask.CenterR.ToString("0.00"))
            'SouthMask.Width = HSLoc(SouthSide).ToolWidth
            'frmDataBase.SetValue("Partdata", "Value", "SMaskSearchWidth", SouthMask.Width.ToString("0.00"))
            'SouthMask.Height = HSLoc(SouthSide).ToolHeight
            'frmDataBase.SetValue("Partdata", "Value", "SMaskSearchWidth", SouthMask.Height.ToString("0.00"))
            ''North Glass
            'NorthGlass.CenterX = HSLoc(NorthSide).ToolPositionX
            'frmDataBase.SetValue("Partdata", "Value", "NGlassSearchCenterX", NorthGlass.CenterX.ToString("0.00"))
            'NorthGlass.CenterY = HSLoc(NorthSide).ToolPositionY
            'frmDataBase.SetValue("Partdata", "Value", "NGlassSearchCenterY", NorthGlass.CenterY.ToString("0.00"))
            'NorthGlass.CenterR = HSLoc(NorthSide).ToolRotation
            'frmDataBase.SetValue("Partdata", "Value", "NGlassSearchCenterR", NorthGlass.CenterR.ToString("0.00"))
            'NorthGlass.Width = HSLoc(NorthSide).ToolWidth
            'frmDataBase.SetValue("Partdata", "Value", "NGlassSearchWidth", NorthGlass.Width.ToString("0.00"))
            'NorthGlass.Height = HSLoc(NorthSide).ToolHeight
            'frmDataBase.SetValue("Partdata", "Value", "NGlassSearchWidth", NorthGlass.Height.ToString("0.00"))
            ''South Glass
            'SouthGlass.CenterX = HSLoc(SouthSide).ToolPositionX
            'frmDataBase.SetValue("Partdata", "Value", "SGlassSearchCenterX", SouthGlass.CenterX.ToString("0.00"))
            'SouthGlass.CenterY = HSLoc(SouthSide).ToolPositionY
            'frmDataBase.SetValue("Partdata", "Value", "SGlassSearchCenterY", SouthGlass.CenterY.ToString("0.00"))
            'SouthGlass.CenterR = HSLoc(SouthSide).ToolRotation
            'frmDataBase.SetValue("Partdata", "Value", "SGlassSearchCenterR", SouthGlass.CenterR.ToString("0.00"))
            'SouthGlass.Width = HSLoc(SouthSide).ToolWidth
            'frmDataBase.SetValue("Partdata", "Value", "SGlassSearchWidth", SouthGlass.Width.ToString("0.00"))
            'SouthGlass.Height = HSLoc(SouthSide).ToolHeight
            'frmDataBase.SetValue("Partdata", "Value", "SGlassSearchWidth", SouthGlass.Height.ToString("0.00"))
        Catch ex As Exception
            ShowVBErrors(ex.Message)
        End Try
    End Sub

#Region "Vision Routines"

    'Public Function FindCamera(CamID) As Boolean
    '  Dim CameraList(1) As uEye.Types.CameraInformation
    '  Dim Status As uEye.Defines.Status
    '  Dim Count As Integer
    '  Dim CamID As Integer
    '  Dim CamIDNorth As Integer
    '  Dim CamIDSouth As Integer
    '  Dim NumberOfCamerasInUse As Integer

    '  Try
    '    'CamIDNorth = CInt(frmDataBase.GetValue("Settings", "Value", "North Camera"))
    '    'CamIDSouth = CInt(frmDataBase.GetValue("Settings", "Value", "South Camera"))
    '    Status = uEye.Info.Camera.GetNumberOfDevices(NumberOfCamerasInUse)
    '    ' NumberOfCamerasInUse = Count
    '    For Count = 0 To Count - 1
    '      Status = uEye.Info.Camera.GetCameraList(CameraList)
    '      CamID = CameraList(Count).CameraID
    '      Select Case CamID
    '        Case CamIDNorth
    '          NorthSide = 0
    '        Case CamIDSouth
    '          SouthSide = 1
    '      End Select
    '    Next Count
    '    FindCameras = True
    '  Catch ex As Exception
    '    FindCameras = False
    '  End Try
    'End Function

    Private Function InitVision() As Boolean
    Dim Success As Boolean
    Try

      'Load the vision database
      HSApp = frmSetupVision.ApplicationControl
      'VisionDatabasePath = ConfigPath & "Vision.cfg"
      Success = HSApp.ProcessManager.LoadConfiguration(0, VisionDatabasePath)
      If Not Success Then
        MsgBox("Could Not locate the Vision Database:    " & vbCr & VisionDatabasePath & vbCr &
                                          "You need to locate this database yourself in the next dialog",
                                              MsgBoxStyle.Critical, "Vision Database Load Error")
        HSApp.ProcessManager.LoadConfiguration(0, "")
      End If
      HSDb = HSApp.Database
      HSDb.AddView("Acquisition")
      ImageNorth = HSDb.AddImage("Acquisition", "IDS Image North", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
      ImageSouth = HSDb.AddImage("Acquisition", "IDS Image South", HSCLASSLIBRARYLib.hsImageType.hsImage8bppGreyScale)
      SideName(LocNorthMask) = "North Mask"
      SideName(LocSouthMask) = "South Mask"
      SideName(LocNorthGlass) = "North Glass"
      SideName(LocSouthGlass) = "South Glass"
      AcquisitionName(NorthSide) = "Acquisition North"
      AcquisitionName(SouthSide) = "Acquisition South"
      '
      'Assign Controls
      HSAcq = HSApp.ProcessManager.Process("Acquisition")
      HSLoc(LocNorthGlass) = HSApp.ProcessManager.Process("Locator North Glass")
      HSLoc(LocSouthGlass) = HSApp.ProcessManager.Process("Locator South Glass")
      HSLoc(LocNorthMask) = HSApp.ProcessManager.Process("Locator North Mask")
      HSLoc(LocSouthMask) = HSApp.ProcessManager.Process("Locator South Mask")
      '
      'Automatically fill the HSDisplay control with data from the Locator
      With HSDisplayNorth
        .Parent = grpHSDisplayNorth
        .set_ImageName(0, ImageNorth.Name)
        .set_SceneViewName(0, HSLoc(LocNorthGlass).OutputInstanceSceneView)
        .set_SceneViewName(1, HSLoc(LocNorthMask).OutputInstanceSceneView)
        .set_SceneViewName(2, HSLoc(LocNorthGlass).OutputDetailSceneView)
        .set_SceneViewName(3, HSLoc(LocNorthMask).OutputDetailSceneView)
        .set_SceneName(0, HSLoc(LocNorthGlass).OutputInstanceScene)
        .set_SceneName(1, HSLoc(LocNorthMask).OutputInstanceScene)
        .set_SceneName(2, HSLoc(LocNorthGlass).OutputDetailScene)
        .set_SceneName(3, HSLoc(LocNorthMask).OutputDetailScene)
        .set_SceneColor(0, HSDISPLAYLib.hsColor.hsGreen)
        .set_SceneColor(1, HSDISPLAYLib.hsColor.hsBlue)
        .set_SceneColor(2, HSDISPLAYLib.hsColor.hsCyan)
        .set_SceneColor(3, HSDISPLAYLib.hsColor.hsCyan)
        .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .set_ScenePenWidth(2, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .set_ScenePenWidth(3, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .Left = 0
        .Top = 0
        .Width = grpHSDisplayNorth.Width
        .Height = grpHSDisplayNorth.Height
        .CalibratedUnitsEnabled = True
        '.set_SceneName(2, "Instance Scene")
      End With
      With HSDisplaySouth
        .Parent = grpHSDisplaySouth
        .set_ImageName(0, ImageSouth.Name)
        .set_ImageName(0, ImageNorth.Name)
        .set_SceneViewName(0, HSLoc(LocSouthGlass).OutputInstanceSceneView)
        .set_SceneViewName(1, HSLoc(LocSouthMask).OutputInstanceSceneView)
        .set_SceneViewName(2, HSLoc(LocSouthGlass).OutputDetailSceneView)
        .set_SceneViewName(3, HSLoc(LocSouthMask).OutputDetailSceneView)
        .set_SceneName(0, HSLoc(LocSouthGlass).OutputInstanceScene)
        .set_SceneName(1, HSLoc(LocSouthMask).OutputInstanceScene)
        .set_SceneName(2, HSLoc(LocSouthGlass).OutputDetailScene)
        .set_SceneName(3, HSLoc(LocSouthMask).OutputDetailScene)
        .set_SceneColor(0, HSDISPLAYLib.hsColor.hsGreen)
        .set_SceneColor(1, HSDISPLAYLib.hsColor.hsBlue)
        .set_SceneColor(2, HSDISPLAYLib.hsColor.hsCyan)
        .set_SceneColor(3, HSDISPLAYLib.hsColor.hsCyan)
        .set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .set_ScenePenWidth(2, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .set_ScenePenWidth(3, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        .Left = 0
        .Top = 0
        .Width = grpHSDisplaySouth.Width
        .Height = grpHSDisplaySouth.Height
        .CalibratedUnitsEnabled = True
        '.set_SceneName(2, "Instance Scene")
      End With
      Return Success
      Exit Function
    Catch ex As Exception
      ShowVBErrors(ex.Message)
      Return False
    End Try
  End Function

  Public Sub SaveHexsight()
    Try
      Dim Status As Boolean
      Status = HSApp.ProcessManager.SaveConfiguration(0, VisionDatabasePath)
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Sub mnuCalibrate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCalibrateNorth.Click, mnuCalibrateSouth.Click
    If eventSender.name = "mnuCalibrateNorth" Then
      Snap(NorthSide)
      CalibrateCam(NorthSide)
    Else
      Snap(SouthSide)
      CalibrateCam(SouthSide)
    End If
  End Sub

  Private Sub CalibrateCam(ByRef Side As Short)
    Dim Yes As Short
    Try
      'Setup the calibration
      Yes = MsgBox("Please enusure a few items are set up before starting the camera calibration." & vbCr & vbCr &
                                  "1.  Write down the existing exposure setting" & vbCr &
                                  "2.  Set the exposure slider so that the image Is crisp And white," & vbCr & vbCr &
                                  "If you have already performed these steps then hit OK to continue, otherwise" & vbCr &
                                  "Hit Cancel to perform these few steps.",
                                  MsgBoxStyle.OkCancel & MsgBoxStyle.SystemModal, "Setup the Calibration")
      If Yes <> MsgBoxResult.Ok Then
        Calibrating = False
        Exit Sub
      End If
      'Start the calibration
      Yes = MsgBox("The Calibration dialog will now appear after you close this dialog box," & vbCr & vbCr &
                                  "The green directional pointer should be on the dot surrounded by dashed circle." & vbCr &
                                  "The X And Y arrows should be pointing in the same direction as the X And Y arrows on calibration grid" & vbCr & vbCr &
                                  "To verify the calibration" & vbCr &
                                  "Copy the X And Y values in the (Axis Origin) boxes to the (World vs Image)World boxes And click on the right arrow." & vbCr &
                                  "The test point should move to the center of hole with a black circle around it" & vbCr & vbCr &
                                  "Hit OK Or Cancel to continue", MsgBoxStyle.OkCancel & MsgBoxStyle.SystemModal, "Calibration Starting")
      If Yes <> MsgBoxResult.Ok Then
        Calibrating = False
        Exit Sub
      End If
      '
      Calibrate = HSAcq.ShowCalibDistortionModelDialog(True)
      With Calibrate
        .DotPitch = 20
        .WorldCoordinateSystemType = HSACQUISITIONDEVICELib.hsCoordinateSystemType.hsLeftHanded
        .MaximumDotRadius = 30
        .MinimumDotRadius = 10
        If Side = NorthSide Then
          .OriginPositionXWorld = 0
          .OriginPositionYWorld = 0
          .OriginPositionX = 3679
          .OriginPositionY = 175
          .AxisXPositionX = 3609
          .AxisXPositionY = 178
          .AxisYPositionX = 3681
          .AxisYPositionY = 247
        Else
          .OriginPositionXWorld = 1000
          .OriginPositionYWorld = 0
          .OriginPositionX = 3662
          .OriginPositionY = 104
          .AxisXPositionX = 3591
          .AxisXPositionY = 106
          .AxisYPositionX = 3662
          .AxisYPositionY = 175
        End If
        .UnitsLength = HSACQUISITIONDEVICELib.hsUnitsLength.hsMillimeter
        .DotConformity = 0.5
        '.EdgeSensitivity.Equals(90) 'Read Only PRoperty
        .Show()
        'See if the operator wants to save the calibration
        Yes = MsgBox("Do you wish to save this calibration to disk?", MsgBoxStyle.YesNo)
        If Yes = MsgBoxResult.Yes Then
          SaveHexsight()
          MsgBox("Database Updated", MsgBoxStyle.SystemModal)
        Else
          MsgBox("Database Update Cancelled", MsgBoxStyle.SystemModal)
        End If
      End With
      Calibrating = False
      System.Windows.Forms.Application.DoEvents()
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Sub btnLocate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _
    btnLocateNorthMask.Click,
    btnLocateNorthGlass.Click,
    btnLocateSouthMask.Click,
    btnLocateSouthGlass.Click,
    btnLocateOnlyNorthMask.Click,
    btnLocateOnlyNorthGlass.Click,
    btnLocateOnlySouthMask.Click,
    btnLocateOnlySouthGlass.Click
    Try
      Select Case eventSender.name
        Case "btnLocateNorthMask"
          Do
            Locate(LocNorthMask, True)
            If chkLocateRepeatNorthMask.Checked Then DelayTimer(50)
          Loop While chkLocateRepeatNorthMask.Checked
        Case "btnLocateNorthGlass"
          Do
            Locate(LocNorthGlass, True)
            If chkLocateRepeatNorthGlass.Checked Then DelayTimer(50)
          Loop While chkLocateRepeatNorthGlass.Checked
        Case "btnLocateSouthMask"
          Do
            Locate(LocSouthMask, True)
            If chkLocateRepeatSouthMask.Checked Then DelayTimer(50)
          Loop While chkLocateRepeatSouthMask.Checked
        Case "btnLocateSouthGlass"
          Do
            Locate(LocSouthGlass, True)
            If chkLocateRepeatSouthGlass.Checked Then DelayTimer(50)
          Loop While chkLocateRepeatSouthGlass.Checked
        Case "btnLocateOnlyNorthMask"
          Locate(LocNorthMask, False)
        Case "btnLocateOnlyNorthGlass"
          Locate(LocNorthGlass, False)
        Case "btnLocateOnlySouthMask"
          Locate(LocSouthMask, False)
        Case "btnLocateOnlySouthGlass"
          Locate(LocSouthGlass, False)
      End Select
      GC.Collect()
      GC.WaitForPendingFinalizers()
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub LocateBoth() Handles btnLocateBoth.Click
    Try
      Do
        '
        btnLocateBoth.Enabled = False
        Locate(LocNorthMask, True)
        Application.DoEvents()
        Locate(LocNorthGlass, True)
        Application.DoEvents()
        Locate(LocSouthMask, True)
        Application.DoEvents()
        Locate(LocSouthGlass, True)
        Application.DoEvents()
        btnLocateBoth.Enabled = True
        CalcFinalOffset()
      Loop While chkRepeatLocateBoth.CheckState
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Function Locate(ByVal Side As Int16, ByVal NewPicture As Boolean) As Boolean
    Dim StartTimer As Single
    Dim InRoutine As Boolean
    Try
      If InRoutine Then
        Return False
        Exit Function
      End If
      InRoutine = True
      Locate = False
      Select Case Side
        Case LocNorthGlass
          btnLocateNorthGlass.Enabled = False
          btnLocateOnlyNorthGlass.Enabled = False
          If NewPicture Then Snap(NorthSide)
          StartTimer = VB.Timer
          Find(LocNorthGlass)
          UpdateVisionStatus(LocNorthGlass)
          CheckVerificationLimits(LocNorthGlass)
          btnLocateNorthGlass.Enabled = True
          btnLocateOnlyNorthGlass.Enabled = True
          HSDisplayNorth.Refresh()
          lblVisionPoseTimeNorthGlass.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
        Case LocNorthMask
          btnLocateNorthMask.Enabled = False
          btnLocateOnlyNorthMask.Enabled = False
          If NewPicture Then Snap(NorthSide)
          StartTimer = VB.Timer
          Find(LocNorthMask)
          UpdateVisionStatus(LocNorthMask)
          CheckVerificationLimits(LocNorthMask)
          btnLocateNorthMask.Enabled = True
          btnLocateOnlyNorthMask.Enabled = True
          HSDisplayNorth.Refresh()
          lblVisionPoseTimeNorthMask.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
        Case LocSouthGlass
          btnLocateSouthMask.Enabled = False
          btnLocateOnlySouthMask.Enabled = False
          If NewPicture Then Snap(SouthSide)
          StartTimer = VB.Timer
          Find(LocSouthGlass)
          UpdateVisionStatus(LocSouthGlass)
          CheckVerificationLimits(LocSouthGlass)
          btnLocateSouthMask.Enabled = True
          btnLocateOnlySouthMask.Enabled = True
          HSDisplaySouth.Refresh()
          lblVisionPoseTimeSouthMask.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
        Case LocSouthMask
          btnLocateSouthMask.Enabled = False
          btnLocateOnlySouthMask.Enabled = False
          If NewPicture Then Snap(SouthSide)
          StartTimer = VB.Timer
          Find(LocSouthMask)
          UpdateVisionStatus(LocSouthMask)
          CheckVerificationLimits(LocSouthMask)
          btnLocateSouthMask.Enabled = True
          btnLocateOnlySouthMask.Enabled = True
          HSDisplaySouth.Refresh()
          lblVisionPoseTimeSouthMask.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
      End Select
      InRoutine = False
      Return True
    Catch ex As Exception
      ShowVBErrors(ex.Message, " Locator " & Side)
      InRoutine = False
      Return False
    End Try
  End Function

  Public Sub Snap(ByVal Side As Int16)
    'snaps a picture of the glass
    Dim StartTimer As Single
    Dim InRoutine As Boolean
    Dim Display As Object
    If InRoutine Then Exit Sub
    Dim TempString As String = ""
    Try
      InRoutine = True
      '
      'Measure the process time
      StartTimer = VB.Timer()
      '
      'Setup the Display and the Camera to use
      HSAcq.ConfigurationDefault = AcquisitionName(Side)
      '
      Select Case Side
        Case NorthSide
          'Clear the background image so that it has to be replaced with a new image
          Display = HSDisplayNorth
          'ImageNorth.BackgroundColor = 60 'display a gray image to override the previous image
          ' ImageNorth.Render()                                                 'display a gray image to override the previous image   
          HSDisplayNorth.RefreshDisplay() 'display a gray image to override the previous image
          btnSnapNorth.Enabled = False
          'Snap the picture, try 2nd time if unsuccessful
          If Not GetCameraImage(Side) Then GetCameraImage(Side)
          HSDisplayNorth.RefreshDisplay()
          btnSnapNorth.Enabled = True
          lblCameraTimeNorth.Text = (VB.Timer - StartTimer).ToString("N2")
        Case SouthSide
          Display = HSDisplaySouth
          ' ImageSouth.BackgroundColor = 60
          ' ImageSouth.Render()
          Display.RefreshDisplay()
          btnSnapSouth.Enabled = False
          'Snap the picture, try 2nd time if unsuccessful
          If Not GetCameraImage(Side) Then GetCameraImage(Side)
          HSDisplaySouth.RefreshDisplay()
          btnSnapSouth.Enabled = True
          lblCameraTimeSouth.Text = (VB.Timer - StartTimer).ToString("N2") & " Secs."
      End Select
      'Snap the picture
      HSAcq.Execute()
      '  Application.DoEvents()
      InRoutine = False
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub Find(ByRef Side As Int32)
    Dim StartTimer As Single
    Dim Temp As Short = 0
    Try
      LocatorResults(Side).Success = 0
      'If the gray scale image was sucessfully acquired
      If HSAcq.ErrorDescription = "" Then
        'Rough or fine locate?
        'If chkLockScalingNorth.Checked Then
        '    HSLoc(Side).NominalScaleFactorEnabled = True
        'Else
        '    HSLoc(Side).NominalScaleFactorEnabled = Not CBool(RoughSquare)
        'End If
        If mnuShowContours.Checked Then
          HSLoc(Side).OutputDetailSceneEnabled = True
        Else
          HSLoc(Side).OutputDetailSceneEnabled = False
        End If
        '
        StartTimer = VB.Timer()
        HSDisplayNorth.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        HSDisplayNorth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        HSDisplaySouth.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        HSDisplaySouth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthThick)
        HSLoc(Side).Execute()
        LocatorResults(Side).Success = 0
        If HSLoc(Side).InstanceCount > 0 Then
          'retreive the results of the locate process.
          LocatorResults(Side).X = HSLoc(Side).InstanceTranslationX(0)
          LocatorResults(Side).Y = HSLoc(Side).InstanceTranslationY(0)
          LocatorResults(Side).R = HSLoc(Side).InstanceRotation(0)
          LocatorResults(Side).Score = (HSLoc(Side).InstanceFitQuality(0) * 100)
          Corner.X = LocatorResults(Side).X
          Corner.Y = LocatorResults(Side).Y
          Corner.R = LocatorResults(Side).R
          'Update labels on the vision controls
          Select Case Side
            Case LocNorthGlass
              lblVisionMessageNorthGlass.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
              lblVisionPoseXNorthGlass.Text = LocatorResults(Side).X.ToString("N2")
              lblVisionPoseYNorthGlass.Text = LocatorResults(Side).Y.ToString("N2")
              lblVisionPoseRNorthGlass.Text = LocatorResults(Side).R.ToString("N2")
              lblVisionPoseScoreNorthGlass.Text = LocatorResults(Side).Score.ToString("N2")
              LocatorResults(Side).Success = True
              '
              'Check Limits
              UpdateAxisMarkers(Side)
              AddRectangleMarker(Side)
              HSDisplayNorth.RefreshMarkers()
            Case LocNorthMask
              lblVisionMessageNorthMask.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
              lblVisionPoseXNorthMask.Text = LocatorResults(Side).X.ToString("N2")
              lblVisionPoseYNorthMask.Text = LocatorResults(Side).Y.ToString("N2")
              lblVisionPoseRNorthMask.Text = LocatorResults(Side).R.ToString("N2")
              lblVisionPoseScoreNorthMask.Text = LocatorResults(Side).Score.ToString("N2")
              LocatorResults(Side).Success = True
              '
              'Check Limits
              UpdateAxisMarkers(Side)
              AddRectangleMarker(Side)
              HSDisplayNorth.RefreshMarkers()
            Case LocSouthMask
              lblVisionMessageSouthMask.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
              lblVisionPoseXSouthMask.Text = LocatorResults(Side).X.ToString("N2")
              lblVisionPoseYSouthMask.Text = LocatorResults(Side).Y.ToString("N2")
              lblVisionPoseRSouthMask.Text = LocatorResults(Side).R.ToString("N2")
              lblVisionPoseScoreSouthMask.Text = LocatorResults(Side).Score.ToString("N2")
              LocatorResults(Side).Success = True
              '
              'Check Limits
              UpdateAxisMarkers(Side)
              AddRectangleMarker(Side)
              HSDisplaySouth.RefreshMarkers()
            Case LocSouthGlass
              lblVisionMessageSouthGlass.Text = HSLoc(Side).MessageNumber(0) & " " & HSLoc(Side).MessageDescription(0)
              lblVisionPoseXSouthGlass.Text = LocatorResults(Side).X.ToString("N2")
              lblVisionPoseYSouthGlass.Text = LocatorResults(Side).Y.ToString("N2")
              lblVisionPoseRSouthGlass.Text = LocatorResults(Side).R.ToString("N2")
              lblVisionPoseScoreSouthGlass.Text = LocatorResults(Side).Score.ToString("N2")
              LocatorResults(Side).Success = True
              '
              'Check Limits
              UpdateAxisMarkers(Side)
              AddRectangleMarker(Side)
              HSDisplaySouth.RefreshMarkers()
          End Select
        Else
          Select Case Side
            Case LocNorthGlass
              lblVisionPoseXNorthGlass.Text = ""
              lblVisionPoseYNorthGlass.Text = ""
              lblVisionPoseRNorthGlass.Text = ""
              lblVisionPoseScoreNorthGlass.Text = ""
              lblVisionMessageNorthGlass.Text = "Model was Not Located - " & CStr(HSLoc(NorthSide).MessageDescription(0))
              lblVisionMessageNorthGlass.BackColor = Color.Red
              LocatorResults(Side).Success = False
            Case LocNorthMask
              lblVisionPoseXNorthMask.Text = ""
              lblVisionPoseYNorthMask.Text = ""
              lblVisionPoseRNorthMask.Text = ""
              lblVisionPoseScoreNorthMask.Text = ""
              lblVisionMessageNorthMask.Text = "Model was Not Located - " & CStr(HSLoc(SouthSide).MessageDescription(0))
              lblVisionMessageNorthMask.BackColor = Color.Red
              LocatorResults(Side).Success = False
            Case LocSouthGlass
              lblVisionPoseXSouthGlass.Text = ""
              lblVisionPoseYSouthGlass.Text = ""
              lblVisionPoseRSouthGlass.Text = ""
              lblVisionPoseScoreSouthGlass.Text = ""
              lblVisionMessageSouthGlass.Text = "Model was Not Located - " & CStr(HSLoc(SouthSide).MessageDescription(0))
              lblVisionMessageSouthGlass.BackColor = Color.Red
              LocatorResults(Side).Success = False
            Case LocSouthMask
              lblVisionPoseXSouthMask.Text = ""
              lblVisionPoseYSouthMask.Text = ""
              lblVisionPoseRSouthMask.Text = ""
              lblVisionPoseScoreSouthMask.Text = ""
              lblVisionMessageSouthMask.Text = "Model was Not Located - " & CStr(HSLoc(SouthSide).MessageDescription(0))
              lblVisionMessageSouthMask.BackColor = Color.Red
              LocatorResults(Side).Success = False
          End Select
          AddRectangleMarker(Side)
        End If
      Else
        'Display the HS error 
        Select Case Side
          Case LocNorthGlass
            HSDisplayNorth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
            lblVisionMessageNorthGlass.Text = CStr(HSAcq.ErrorDescription)
            lblVisionMessageNorthGlass.BackColor = Color.Red
          Case LocNorthMask
            HSDisplayNorth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
            lblVisionMessageNorthMask.Text = CStr(HSAcq.ErrorDescription)
            lblVisionMessageNorthMask.BackColor = Color.Red
          Case LocSouthGlass
            HSDisplaySouth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
            lblVisionMessageSouthGlass.Text = CStr(HSAcq.ErrorDescription)
            lblVisionMessageSouthGlass.BackColor = Color.Red
          Case LocSouthMask
            HSDisplaySouth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
            lblVisionMessageSouthMask.Text = CStr(HSAcq.ErrorDescription)
            lblVisionMessageSouthMask.BackColor = Color.Red
        End Select
        AddRectangleMarker(Side)
        LocatorResults(Side).Success = 2
      End If
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub UpdateVisionStatus(ByRef Side As Integer)
    Try
      'Check Score
      If LocatorResults(Side).Success = False Then Exit Sub
      If LocatorResults(Side).Score >= CDbl(updnScoreLimitSouthMask.Value) Then
        Select Case Side
          Case LocNorthGlass
            lblVisionMessageNorthGlass.Text = "Image was successfully located"
            lblVisionMessageNorthGlass.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseXNorthGlass.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseYNorthGlass.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseRNorthGlass.BackColor = System.Drawing.SystemColors.Control
            LocatorResults(Side).Success = True
          Case LocNorthMask
            lblVisionMessageNorthMask.Text = "Image was successfully located"
            lblVisionMessageNorthMask.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseXNorthMask.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseYNorthMask.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseRNorthMask.BackColor = System.Drawing.SystemColors.Control
            LocatorResults(Side).Success = True
          Case LocSouthGlass
            lblVisionMessageSouthGlass.Text = "Image was successfully located"
            lblVisionMessageSouthGlass.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseXSouthGlass.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseYSouthGlass.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseRSouthGlass.BackColor = System.Drawing.SystemColors.Control
            LocatorResults(Side).Success = True
          Case LocSouthMask
            lblVisionMessageSouthMask.Text = "Image was successfully located"
            lblVisionMessageSouthMask.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseXSouthMask.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseYSouthMask.BackColor = System.Drawing.SystemColors.Control
            lblVisionPoseRSouthMask.BackColor = System.Drawing.SystemColors.Control
            LocatorResults(Side).Success = True
        End Select
      Else
        Select Case Side
          Case LocNorthGlass
            lblVisionMessageNorthGlass.Text = "Score was too low"
            lblVisionMessageNorthGlass.BackColor = System.Drawing.Color.Red
            LocatorResults(Side).Success = False
          Case LocSouthGlass
            lblVisionMessageSouthMask.Text = "Score was too low"
            lblVisionMessageSouthMask.BackColor = System.Drawing.Color.Red
            LocatorResults(Side).Success = False
        End Select
      End If
    Catch ex As Exception
      ShowVBErrors(Err.Description)
    End Try
  End Sub

  Private Sub CheckVerificationLimits(Side As Int16)
    Try
    Catch ex As Exception
      ShowVBErrors(ex.Message, " Locator" & Side)
    End Try
  End Sub

  Private Sub updnlimit_ValueChanged(sender As Object, e As EventArgs) Handles updnRShift.ValueChanged
    Try
      If Not UpdatingPartData Then
        frmDataBase.SetValue("Partdata", "Value", sender.Name, CStr(sender.Value))
      End If
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub CalcGlassOffset()
    CalcCombinedOffset(LocatorResults(LocNorthGlass), LocatorResults(LocSouthGlass), LocatorResults(FinalGlassOffset))
    With LocatorResults(FinalGlassOffset)
      If .Success Then
        'Update the text boxes
        lblGlassCombinedX.Text = .X.ToString("0.00")
        lblGlassCombinedY.Text = .Y.ToString("0.00")
        lblGlassCombinedR.Text = .R.ToString("0.00")
      End If
      lblGlassCombinedStatus.Text = .Status
    End With
  End Sub

  Private Sub CalcMaskOffset()
    CalcCombinedOffset(LocatorResults(LocNorthMask), LocatorResults(LocSouthMask), LocatorResults(FinalMaskOffset))
    With LocatorResults(FinalMaskOffset)
      If .Success Then
        'Update the text boxes
        lblMaskCombinedX.Text = .X.ToString("0.00")
        lblMaskCombinedY.Text = .Y.ToString("0.00")
        lblMaskCombinedR.Text = .R.ToString("0.00")
      End If
      lblMaskCombinedStatus.Text = .Status
    End With
  End Sub

  Private Sub CalcFinalOffset()
    Try
      LocatorResults(LocNorthMask).X = 175.12
      LocatorResults(LocNorthMask).Y = 425.91
      LocatorResults(LocNorthGlass).X = 157.67
      LocatorResults(LocNorthGlass).Y = 98.38
      LocatorResults(LocSouthMask).X = 1401.98
      LocatorResults(LocSouthMask).Y = 431.27
      LocatorResults(LocSouthGlass).X = 1378.63
      LocatorResults(LocSouthGlass).Y = 64.6
      CalcGlassOffset()
      CalcMaskOffset()
      '
      'Update status if either locator is unsucessful
      If Not LocatorResults(LocNorthGlass).Success Or Not LocatorResults(LocNorthMask).Success Then
        LocatorResults(FinalOffset).Status = "Problem with North Side"
        lblFinalStatus.BackColor = Color.Red
      ElseIf Not LocatorResults(LocSouthGlass).Success Or Not LocatorResults(LocSouthMask).Success Then
        LocatorResults(FinalOffset).Status = "Problem with South Side"
        lblFinalStatus.BackColor = Color.Red
      ElseIf Not LocatorResults(LocSouthGlass).Success And Not LocatorResults(LocSouthMask).Success Then
        LocatorResults(FinalOffset).Status = "Problem with Both Sides"
        lblFinalStatus.BackColor = Color.Red
      Else
        lblFinalStatus.BackColor = SystemColors.Control
        LocatorResults(FinalOffset).Status = "Sucessfully Completed the Inspection"
        GenerateFinalOffset()
      End If
      lblFinalStatus.Text = LocatorResults(FinalOffset).Status
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub GenerateFinalOffset()
    Dim XShift As Double, YShift As Double, Angle As Double
    Dim XLength As Double, YLength As Double
    Dim Hypotunse As Double
    Dim XString As String, YString As String, RString As String
    Dim AddSpace As String
    Try
      With LocatorResults(FinalOffset)
        '
        'Calculate the offset by subtracting the glass offset from the mask offset
        .X = LocatorResults(FinalMaskOffset).X - LocatorResults(FinalGlassOffset).X + updnXShift.Value
        .Y = LocatorResults(FinalMaskOffset).Y - LocatorResults(FinalGlassOffset).Y + updnYShift.Value
        If mnuUseSouthCameraOnly.Checked Then
          .R = LocatorResults(FinalMaskOffset).R + LocatorResults(FinalGlassOffset).R + updnRShift.Value
        Else
          .R = LocatorResults(FinalMaskOffset).R - LocatorResults(FinalGlassOffset).R + updnRShift.Value
        End If
        '
        'The following code will create a shift offset that needs to be applied
        'to the offset above.  The offset above will calculate the x,y and rotation
        'values based on the part rotating about the vison system origin point.
        'unfortunately rotating about the vision origin point will cause the x,y
        'values to shift by the hypotunse and angle of the located mask corner.
        'The code below calculates how far the x,y values are off by finding the new
        'lengths of the new angle and subtracting the old lengths from them.
        Angle = Atan(LocatorResults(FinalMaskOffset).Y / LocatorResults(FinalMaskOffset).X) * (180 / PI) + .R
        Hypotunse = Sqrt(LocatorResults(FinalMaskOffset).X ^ 2 + LocatorResults(FinalMaskOffset).Y ^ 2)
        YLength = Sin(Angle * PI / 180) * Hypotunse
        XLength = Cos(Angle * PI / 180) * Hypotunse
        XShift = LocatorResults(FinalMaskOffset).X - XLength
        YShift = LocatorResults(FinalMaskOffset).Y - YLength
        '
        'Shift the polarities so the robot moves in the correct direction
        .X = - .X + XShift
        .Y = - .Y + YShift
        '
        'Update the text boxes
        txtXCombined.Text = .X.ToString("0.00")
        txtYCombined.Text = .Y.ToString("0.00")
        txtRCombined.Text = .R.ToString("0.00")
        '
        'Convert the offset values to Strings
        If .X > 0 Then
          AddSpace = " "
        Else
          AddSpace = "" 'Reserve space for sign
        End If
        XString = AddSpace & Format(.X, "000.00")
        If .Y > 0 Then
          AddSpace = " "
        Else
          AddSpace = "" 'Reserve space for sign
        End If
        YString = AddSpace & Format(.Y, "000.00")
        If .R > 0 Then
          AddSpace = " "
        Else
          AddSpace = "" 'Reserve space for sign
        End If
        RString = AddSpace & Format(.R, "000.00")
        OffsetString = "X = " & XString & " Y = " & YString & " R = " & RString
        txtCommStatus.BackColor = SystemColors.Control
        txtCommStatus.Text = OffsetString
      End With
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub CalcCombinedOffset(ByVal North As VisionData, ByVal South As VisionData, ByRef Final As VisionData)
    'Calculates an offset using the two locator offsets passed to it.  The result is passed to the "Final"  Offsettype.
    Dim strLength As String
    Try
      With Final
        .Success = True
        'Calculate the offset from the input offsets
        If mnuUseSouthCameraOnly.Checked Then
          .X = South.X
          .Y = South.Y
          .R = South.R
        Else
          .X = North.X
          .Y = North.Y
          .R = Atan((South.Y - North.Y) / (South.X - North.X))
          .R = ((.R * (180 / PI)) + 180) * -1
          'Compensate if the rotation is way out of whack
          If .R > 145 Then
            .R = .R - 180
          End If
          If .R < -145 Then
            .R = .R + 180
          End If
        End If
        'Calculate the Length
        .Length = Sqrt(((South.X - North.X) ^ 2) + ((South.X - North.X) ^ 2))
        'Check for Limit Errors
        If Not mnuUseSouthCameraOnly.Checked Then
          If Abs(.R) > updnRLimit.Value Then
            .Status = "R Limit Exceeded"
            .Success = False
          End If
        End If
        If .Success Then
          strLength = Format(.Length, "0.000")
          .Status = "Distance between targets is " & strLength & " millimeters"
        Else
          .Status = "Problem"
        End If
        Debug.Print("Success =  " & .Success)
      End With
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

#Region "Hexsight Display Markers"

  Private Sub UpdateAxisMarkers(ByRef Side As Int32)
    Try
      ' Display an axes marker for pickup
      Select Case Side
        Case LocNorthMask
          With HSDisplayNorth
            .RemoveMarker("Mask Corner")
            .AddAxesMarker("Mask Corner", LocatorResults(Side).X, LocatorResults(Side).Y, 50, 50, LocatorResults(Side).R, 90, True)
            .set_MarkerDisplayName("Mask Corner", False)
            .set_MarkerColor("Mask Corner", HSDISPLAYLib.hsColor.hsBlue)
          End With
        Case LocNorthGlass
          With HSDisplayNorth
            .RemoveMarker("Glass Corner")
            .AddAxesMarker("Glass Corner", LocatorResults(Side).X, LocatorResults(Side).Y, 50, 50, LocatorResults(Side).R, 90, True)
            .set_MarkerDisplayName("Glass Corner", False)
            .set_MarkerColor("Glass Corner", HSDISPLAYLib.hsColor.hsGreen)
          End With
        Case LocSouthMask
          With HSDisplaySouth
            .RemoveMarker("Mask Corner)")
            .AddAxesMarker("Mask Corner", LocatorResults(Side).X, LocatorResults(Side).Y, 50, 50, LocatorResults(Side).R, 90, True)
            .set_MarkerDisplayName("Mask Corner", False)
            .set_MarkerColor("Mask Corner", HSDISPLAYLib.hsColor.hsBlue)
          End With
        Case LocSouthGlass
          With HSDisplaySouth
            .RemoveMarker("Glass Corner")
            .AddAxesMarker("Glass Corner", LocatorResults(Side).X, LocatorResults(Side).Y, 50, 50, LocatorResults(Side).R, 90, True)
            .set_MarkerDisplayName("Glass Corner", False)
            .set_MarkerColor("Glass Corner", HSDISPLAYLib.hsColor.hsGreen)
          End With
      End Select
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub AddTrainingMarker(ByRef Show As Boolean)
    Try
      Dim side As Int16
      Select Case side
        Case NorthSide
          With HSDisplayNorth
            If Show Then
              .AddTargetMarker("Glass CoM", 0, 0, 25, True)
              .set_MarkerDisplayName("Glass CoM", True)
            Else
              .RemoveMarker("Glass CoM")
            End If
          End With
        Case SouthSide
          With HSDisplaySouth
            If Show Then
              .AddTargetMarker("Glass CoM", 0, 0, 25, True)
              .set_MarkerDisplayName("Glass CoM", True)
            Else
              .RemoveMarker("Glass CoM")
            End If
          End With
      End Select
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub AddRectangleMarker(Side As Integer)
    Try
      Select Case Side
        Case NorthSide
          With HSDisplayNorth
            'Mask
            .AddRectangleMarker("Search Area Mask", NorthMask.CenterX, NorthMask.CenterY, NorthMask.Width, NorthMask.Height, True)
            .set_MarkerDisplayName("Search Area Mask", True)
            .set_MarkerLineStyle("Search Area Mask", HSDISPLAYLib.hsMarkerLineStyle.hsDash)
            .set_MarkerColor("Search Area Mask", HSDISPLAYLib.hsColor.hsBlue)
            'Glass
            .AddRectangleMarker("Search Area Glass", NorthGlass.CenterX, NorthGlass.CenterY, NorthGlass.Width, NorthGlass.Height, True)
            .set_MarkerDisplayName("Search Area Glass", True)
            .set_MarkerLineStyle("Search Area Glass", HSDISPLAYLib.hsMarkerLineStyle.hsDash)
            .set_MarkerColor("Search Area Glass", HSDISPLAYLib.hsColor.hsGreen)
          End With
        Case SouthSide
          With HSDisplaySouth
            'Mask
            .AddRectangleMarker("Search Area Mask", SouthMask.CenterX, SouthMask.CenterY, SouthMask.Width, SouthMask.Height, True)
            .set_MarkerDisplayName("Search Area Mask", True)
            .set_MarkerLineStyle("Search Area Mask", HSDISPLAYLib.hsMarkerLineStyle.hsDash)
            .set_MarkerColor("Search Area Mask", HSDISPLAYLib.hsColor.hsBlue)
            'Glass
            .AddRectangleMarker("Search Area Glass", SouthGlass.CenterX, SouthGlass.CenterY, SouthGlass.Width, SouthGlass.Height, True)
            .set_MarkerDisplayName("Search Area Glass", True)
            .set_MarkerLineStyle("Search Area Glass", HSDISPLAYLib.hsMarkerLineStyle.hsDash)
            .set_MarkerColor("Search Area Glass", HSDISPLAYLib.hsColor.hsGreen)
          End With
      End Select
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

#Region "Timers"

  Private Sub tmrDelay_Tick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
    Try
      tmrDelay.Enabled = False
    Catch ex As Exception
      Dim MethodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Sub DelayTimer(ByRef TimeInterval As Integer)
    Try
      tmrDelay.Interval = TimeInterval
      tmrDelay.Enabled = True
      Do
        System.Windows.Forms.Application.DoEvents()
      Loop While tmrDelay.Enabled
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub

  Private Sub tmrDisplayUpdate_Tick(sender As Object, e As EventArgs) Handles tmrDisplayUpdate.Tick
    Try
      If InitSuccessNorth Then GetTemperature(helperNorth, lblTemperatureNorth)
      If InitSuccessSouth Then GetTemperature(helperSouth, lblTemperatureSouth)
      tmrDisplayUpdate.Enabled = True
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub
#End Region

#Region "Up Downs"

  Private Sub updnScoreLimit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
      updnScoreLimitNorthGlass.ValueChanged,
      updnScoreLimitNorthMask.ValueChanged,
      updnScoreLimitSouthGlass.ValueChanged,
      updnScoreLimitSouthMask.ValueChanged
    Dim updn As NumericUpDown
    If UpdatingPartData Then Exit Sub
    updn = DirectCast(sender, NumericUpDown)
    frmDataBase.SetValue("Settings", "Value", updn.Name, updn.Value)
  End Sub

  Private Sub CameraSettings_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updnContrastNorth.ValueChanged, updnExposureNorth.ValueChanged, updnContrastSouth.ValueChanged, updnExposureSouth.ValueChanged
    Dim updn As NumericUpDown
    Dim Success As Boolean
    Static InRoutine As Boolean
    '
    'Initialize
    If InRoutine Then Exit Sub
    If UpdatingPartData Then Exit Sub
    InRoutine = True
    Try
      '
      'Change the camera setting
      updn = DirectCast(sender, NumericUpDown)
      Select Case updn.Name
        Case "updnContrastNorth"
          Success = helperNorth.SetSimpleFeature("Gain", CSng(updn.Value))
        Case "updnExposureNorth"
          Success = helperNorth.SetSimpleFeature("exposure", (CSng(updn.Value)))
        Case "updnContrastSouth"
          Success = helperSouth.SetSimpleFeature("Gain", CSng(updn.Value))
        Case "updnExposureSouth"
          Success = helperSouth.SetSimpleFeature("exposure", (CSng(updn.Value)))
      End Select
      frmDataBase.SetValue("PartData", "Value", updn.Name, Str(updn.Value))
      DelayTimer(250)
      InRoutine = False
      Exit Sub
    Catch ex As Exception
      InRoutine = False
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

#Region "Menus"

  Public Sub mnuDeletePart_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles _
      deleteABC.DropDownItemClicked,
      deleteDEF.DropDownItemClicked,
      deleteGHI.DropDownItemClicked,
      deleteJKL.DropDownItemClicked,
      deleteMNO.DropDownItemClicked,
      deletePQR.DropDownItemClicked,
      deleteSTU.DropDownItemClicked,
      deleteVWX.DropDownItemClicked,
      deleteYZ.DropDownItemClicked,
      deleteOther.DropDownItemClicked
    '
    Dim DeleteName As String
    Dim Answer As Integer
    Dim KillPath As String
    Dim FSO As Scripting.FileSystemObject
    'See if this is the current part
    mnuFile.HideDropDown()
    DeleteName = e.ClickedItem.Text
    If PartName = DeleteName Then
      MsgBox("You can't delete the current part file", MsgBoxStyle.Exclamation)
      Exit Sub
    End If
    'Are you sure
    Answer = MsgBox("Are you sure you want to delete the part " & DeleteName, MsgBoxStyle.OkCancel)
    If Answer = MsgBoxResult.Ok Then
      KillPath = PartsPath & DeleteName
      FSO = New Scripting.FileSystemObject
      Try
        FSO.DeleteFolder(KillPath, True)
      Catch ex As Exception
        ShowVBErrors(ex.Message, "Error Deleting the Directory")
        Exit Sub
      End Try
      MsgBox("Part was permanently deleted", MsgBoxStyle.OkOnly)
    Else
      MsgBox("No files were deleted", MsgBoxStyle.OkOnly)
    End If
  End Sub

  Private Sub mnuLoadPart_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles _
          loadABC.DropDownItemClicked,
          loadDEF.DropDownItemClicked,
          loadGHI.DropDownItemClicked,
          loadJKL.DropDownItemClicked,
          loadMNO.DropDownItemClicked,
          loadPQR.DropDownItemClicked,
          loadSTU.DropDownItemClicked,
          loadVWX.DropDownItemClicked,
          loadYZ.DropDownItemClicked,
          loadOther.DropDownItemClicked
    mnuFile.HideDropDown()
    LoadPart(e.ClickedItem.Text)
  End Sub

  Public Sub mnuQuit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuQuit.Click
    End
  End Sub

  Public Sub mnuFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFile.Click
    PartList.GetFileList()
  End Sub

  Public Sub mnuNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNew.Click
    Dim FSO As Scripting.FileSystemObject
    Dim TempPartName As String
    Dim OldPath As String
    Dim NewPath As String
    'Store the old part path
    OldPath = VB.Left(CurrentFilePath, Len(CurrentFilePath) - 1)
    'Get the new part name
    TempPartName = InputBox("Enter the new part name" & vbCr & "The part name will be truncated to 25 characters" & vbCr & "Case is not important.  The part name will be converted to upper case.", "Create a New Part")
    'Verify the new part name is good
    TempPartName = UCase(TempPartName)
    'Create the vision database
    Try
      If TempPartName <> "" Then
        PartName = TempPartName
        lblPartTitle.Text = PartName
        CurrentFilePath = PartsPath & PartName & "\"
        FSO = New Scripting.FileSystemObject
        NewPath = VB.Left(CurrentFilePath, Len(CurrentFilePath) - 1)
        FSO.CreateFolder(NewPath)
        FSO.CopyFile(OldPath & "\Partdata.sdf", NewPath & "\Partdata.sdf")
        FSO.CopyFile(OldPath & "\North Mask.hdb", NewPath & "\North Mask.hdb")
        FSO.CopyFile(OldPath & "\North Glass.hdb", NewPath & "\North Glass.hdb")
        FSO.CopyFile(OldPath & "\South Mask.hdb", NewPath & "\South Mask.hdb")
        FSO.CopyFile(OldPath & "\South Glass.hdb", NewPath & "\South Glass.hdb")
        frmDataBase.SetValue("Settings", "Value", "Current Part Name", PartName)
      End If
    Catch ex As Exception
      MsgBox("There was a problem creating the new directory, no changes were made" & vbCr &
                                      "Error: " & Err.Description, MsgBoxStyle.SystemModal, "New Part Creation Error")
    End Try
  End Sub

  Public Sub mnuPassword_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPassword.Click
    If mnuPassword.Checked Then
      mnuPassword.Checked = False
      ActivatePassword(False)
    Else
      frmPassword.Show()
      frmPassword.txtPassword.Focus()
    End If
  End Sub

  Private Sub TmrPassword_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrPassword.Tick
    ActivatePassword(False)
  End Sub
#End Region

#Region "Configuration"

  Public Sub mnuGeneralSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGeneralSettings.Click
    Try
      TableName = "Settings"
      frmDataBase.Show()
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Sub mnuPartSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPositionalSettings.Click
    Try
      TableName = "PartData"
      frmDataBase.Show()
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub

  Private Sub mnuModifyHexsightControls_Click_1(sender As Object, e As EventArgs) Handles mnuModifyHexsightControls.Click
    Try
      frmSetupVision.Show()
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub


#End Region

#Region "Help"

  Private Sub StartHelp(ByRef HelpFile As String, Optional ByRef ShowNote As Boolean = True)
    Try
      If ShowNote Then
        MsgBox("Note : Click on the page number in the table" & vbCr &
                                          " of contents to jump to that item.", MsgBoxStyle.SystemModal)
      End If
      Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process()
      myProcess.StartInfo.FileName = HelpFile
      myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
      myProcess.Start()

    Catch ex As Exception
      ShowVBErrors(ex.Message)
      MsgBox("The file that you tried to open was not available" & vbCr &
                                  "It should be located:" & vbCr & HelpFile, MsgBoxStyle.SystemModal)
    End Try
  End Sub

  Public Sub mnuHowToCalibrateHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    Try
      StartHelp(HelpPath & "Calibration.pdf", False)
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub btnSnapBoth_Click(sender As Object, e As EventArgs) Handles btnSnapBoth.Click
    Do
      Try
        While chkRepeatSnapBoth.Checked
          Snap(NorthSide)
          Snap(SouthSide)
          If chkRepeatSnapBoth.Checked Then DelayTimer(50)
        End While
      Catch ex As Exception
        ShowVBErrors(ex.Message)
      End Try
    Loop While chkRepeatSnapBoth.Checked = True
  End Sub

  Public Sub mnuSystemDocumentation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSystemDocumentation.Click
    Try
      StartHelp(HelpPath & "line2Manual.pdf", False)
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Sub mnuTrainingVisionHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    Try
      StartHelp(HelpPath & "TrainVisionHelp.pdf", False)
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Public Sub mnuSquaringTrainingProcedure_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    Try
      StartHelp(HelpPath & "SquaringTrainingProcedure.pdf", False)
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub

  Public Sub mnuHexsightUserGuideHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    Try
      StartHelp("C:\Program Files\HexSight 4.1\Documentation\4.1.1.28-HexSight_User_Guide.pdf", False)
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub
#End Region

#Region "File System"

  Public Sub LoadPart(Optional ByVal TempPartName As String = "")
    Dim Success As Boolean
    Try
      If Not PartList.CheckforFile(TempPartName) Then
        MsgBox("The Part Name '" & TempPartName & "' does not exist on this computer" & vbCr &
                                        "You will need to manually load the correct part", MsgBoxStyle.SystemModal)
        Exit Sub
      Else
        PartName = TempPartName
      End If
      lblPartTitle.Text = "'" & PartName & "'"
      CurrentFilePath = PartsPath & PartName & "\"
      frmDataBase.SetValue("Settings", "Value", "Current Part Name", PartName)
      'Load the model files
      Try
        Success = HSLoc(NorthSide).LoadModelDatabase(CurrentFilePath & "North Mask.hdb")
      Catch ex As Exception
        ShowVBErrors(ex.Message, "Unable to load the model file for the North Mask")
      End Try
      Try
        Success = HSLoc(SouthSide).LoadModelDatabase(CurrentFilePath & "South Mask.hdb")
      Catch ex As Exception
        ShowVBErrors(ex.Message, "Unable to load the model file for the South Mask")
      End Try
      Try
        Success = HSLoc(NorthSide).LoadModelDatabase(CurrentFilePath & "North Glass.hdb")
      Catch ex As Exception
        ShowVBErrors(ex.Message, "Unable to load the model file for the North Glass")
      End Try
      Try
        Success = HSLoc(NorthSide).LoadModelDatabase(CurrentFilePath & "South Glass.hdb")
      Catch ex As Exception
        ShowVBErrors(ex.Message, "Unable to load the model file for the South Glass")
      End Try
      HSDisplayNorth.RemoveAllMarker()
      frmSplash.lblStatus.Text = "Camera Settings"
      'Update Camera Images with current exposures, contrast, gain
      UpdateUpDownControls()
      SetCameraSettings()
      UpdateSearchBoxes()
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub UpdateUpDownControls()
    'Dim UpDown As NumericUpDown
    'This updates all of the slider values and labels
    Try
      updnExposureNorth.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnExposureNorth.Name))
      updnExposureSouth.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnExposureSouth.Name))
      updnContrastNorth.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnContrastNorth.Name))
      updnContrastSouth.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnContrastSouth.Name))
      updnXShift.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnXShift.Name))
      updnYShift.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnYShift.Name))
      updnRShift.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnRShift.Name))
      updnRLinear.Value = CSng(frmDataBase.GetValue("Partdata", "Value", updnRLinear.Name))

      'For Each GroupBox As Windows.Forms.GroupBox In grpCombinedOffset.Controls
      '  For Each Obj As Object In GroupBox.Controls
      '    If Obj.GetType.Name = "NumericUpDown" Then
      '      UpDown = DirectCast(Obj, NumericUpDown)
      '      Try
      '        UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
      '      Catch
      '        MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
      '      End Try
      '    End If
      '  Next Obj
      'Next GroupBox
      'For Each GroupBox As Windows.Forms.GroupBox In grpVisionSouth.Controls
      '  For Each Obj As Object In GroupBox.Controls
      '    If Obj.GetType.Name = "NumericUpDown" Then
      '      UpDown = DirectCast(Obj, NumericUpDown)
      '      Try
      '        UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
      '      Catch
      '        MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
      '      End Try
      '    End If
      '  Next Obj
      'Next GroupBox
      'For Each GroupBox As Windows.Forms.GroupBox In grpVisionNorth.Controls
      '  For Each Obj As Object In GroupBox.Controls
      '    If Obj.GetType.Name = "NumericUpDown" Then
      '      UpDown = DirectCast(Obj, NumericUpDown)
      '      Try
      '        UpDown.Value = CSng(frmDataBase.GetValue("Partdata", "Value", UpDown.Name))
      '      Catch
      '        MsgBox("Error Updating Up Down Control " & UpDown.Name & Err.Description, MsgBoxStyle.SystemModal)
      '      End Try
      '    End If
      '  Next Obj
      'Next GroupBox
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub updateSearchBoxesMain()
    UpdateSearchBoxes(NorthMask, "NMask", HSLoc(LocNorthMask))
    UpdateSearchBoxes(SouthMask, "SMask", HSLoc(LocSouthMask))
    UpdateSearchBoxes(NorthGlass, "NGlass", HSLoc(LocNorthGlass))
    UpdateSearchBoxes(SouthGlass, "SGlass", HSLoc(LocSouthGlass))
  End Sub

  Private Sub UpdateSearchBoxes(SearchArea As SearchArea, DataBaseString As String, Locator As HSLOCATORLib.HSLocator)
    'This updates all of the slider values and labels
    Try
      'North Mask
      SearchArea.CenterX = CSng(frmDataBase.GetValue("Partdata", "Value", DataBaseString & "SearchCenterX"))
      Locator.ToolPositionX = SearchArea.CenterX
      SearchArea.CenterY = CSng(frmDataBase.GetValue("Partdata", "Value", DataBaseString & "SearchCenterY"))
      Locator.ToolPositionX = SearchArea.CenterY
      SearchArea.CenterR = CSng(frmDataBase.GetValue("Partdata", "Value", DataBaseString & "SearchCenterR"))
      Locator.ToolPositionX = SearchArea.CenterR
      SearchArea.Width = CSng(frmDataBase.GetValue("Partdata", "Value", DataBaseString & "SearchWidth"))
      Locator.ToolWidth = SearchArea.Width
      SearchArea.Height = CSng(frmDataBase.GetValue("Partdata", "Value", DataBaseString & "SearchHeight"))
      Locator.ToolHeight = SearchArea.Height
      'South Mask
      SouthMask.CenterX = CSng(frmDataBase.GetValue("Partdata", "Value", "SMaskSearchCenterX"))
      HSLoc(SouthSide).ToolPositionX = SouthMask.CenterX
      SouthMask.CenterY = CSng(frmDataBase.GetValue("Partdata", "Value", "SMaskSearchCenterY"))
      HSLoc(SouthSide).ToolPositionY = SouthMask.CenterY
      SouthMask.CenterR = CSng(frmDataBase.GetValue("Partdata", "Value", "SMaskSearchCenterR"))
      HSLoc(SouthSide).ToolPositionR = SouthMask.CenterR
      SouthMask.Width = CSng(frmDataBase.GetValue("Partdata", "Value", "SMaskSearchWidth"))
      HSLoc(SouthSide).ToolWidth = SouthMask.Width
      SouthMask.Height = CSng(frmDataBase.GetValue("Partdata", "Value", "SMaskSearchHeight"))
      HSLoc(SouthSide).ToolHeight = SouthMask.Height
      'North Glass
      NorthGlass.CenterX = CSng(frmDataBase.GetValue("Partdata", "Value", "NGlassSearchCenterX"))
      HSLoc(NorthSide).ToolPositionX = NorthGlass.CenterX
      NorthGlass.CenterY = CSng(frmDataBase.GetValue("Partdata", "Value", "NGlassSearchCenterY"))
      HSLoc(NorthSide).ToolPositionY = NorthGlass.CenterY
      NorthGlass.CenterR = CSng(frmDataBase.GetValue("Partdata", "Value", "NGlassSearchCenterR"))
      HSLoc(NorthSide).ToolPositionR = NorthGlass.CenterR
      NorthGlass.Width = CSng(frmDataBase.GetValue("Partdata", "Value", "NGlassSearchWidth"))
      HSLoc(NorthSide).ToolWidth = NorthGlass.Width
      NorthGlass.Height = CSng(frmDataBase.GetValue("Partdata", "Value", "NGlassSearchHeight"))
      HSLoc(NorthSide).ToolHeight = NorthGlass.Height
      'South Glass
      SouthGlass.CenterX = CSng(frmDataBase.GetValue("Partdata", "Value", "SGlassSearchCenterX"))
      HSLoc(SouthSide).ToolPositionX = SouthGlass.CenterX
      SouthGlass.CenterY = CSng(frmDataBase.GetValue("Partdata", "Value", "SGlassSearchCenterY"))
      HSLoc(SouthSide).ToolPositionY = SouthGlass.CenterY
      SouthGlass.CenterR = CSng(frmDataBase.GetValue("Partdata", "Value", "SGlassSearchCenterR"))
      HSLoc(SouthSide).ToolPositionR = SouthGlass.CenterR
      SouthGlass.Width = CSng(frmDataBase.GetValue("Partdata", "Value", "SGlassSearchWidth"))
      HSLoc(SouthSide).ToolWidth = SouthGlass.Width
      SouthGlass.Height = CSng(frmDataBase.GetValue("Partdata", "Value", "SGlassSearchHeight"))
      HSLoc(SouthSide).ToolHeight = SouthGlass.Height
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

  Private Sub GetSettings()
    Try
      PartName = frmDataBase.GetValue("Settings", "Value", "Current Part Name")
      CurrentFilePath = PartsPath & PartName & "\"
      updnScoreLimitNorthGlass.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnScoreLimitNorthGlass.Name))
      updnScoreLimitSouthGlass.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnScoreLimitSouthGlass.Name))
      updnScoreLimitNorthMask.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnScoreLimitNorthMask.Name))
      updnScoreLimitSouthMask.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnScoreLimitSouthMask.Name))
      updnExposureNorth.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnExposureNorth.Name))
      updnExposureSouth.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnExposureSouth.Name))
      updnContrastNorth.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnContrastNorth.Name))
      updnContrastSouth.Value = CSng(frmDataBase.GetValue("Settings", "Value", updnContrastSouth.Name))
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

#Region "Robot"

  Private Sub ClearPositionData()
    Try
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try

  End Sub

  Private Sub tabVision(sender As Object, e As EventArgs) Handles tabCameraControls.Click
    '
    '
    'South 
    Try
      If tabCameraControls.SelectedTab.Equals(tabVisionSouth) Then
        'With grpVisionStatusSouthMask
        '  .Parent = grpVisionSouth
        '  .Left = 630
        '  .Top = 9
        'End With
        'lblScoreLimitSouthMask.Parent = grpLocatorControlsSouthMask
        'updnScoreLimitSouthMask.Parent = grpLocatorControlsSouthMask
        With HSDisplaySouth
          .Parent = grpHSDisplaySouth
          .Left = 0
          .Top = 0
          .Width = grpHSDisplaySouth.Width
          .Height = grpHSDisplaySouth.Height
        End With
      End If
      '
      'North
      If tabCameraControls.SelectedTab.Equals(tabVisionNorth) Then
        'With grpVisionStatusNorthGlass
        '  .Parent = grpVisionNorth
        '  .Left = 630
        '  .Top = 9
        'End With
        'lblScoreLimitSouthMask.Parent = grpLocatorControlsNorth
        'updnScoreLimitSouthMask.Parent = grpLocatorControlsNorth
        With HSDisplayNorth
          .Parent = grpHSDisplayNorth
          .Left = 0
          .Top = 0
          .Width = grpHSDisplayNorth.Width
          .Height = grpHSDisplayNorth.Height
        End With
      End If
      '
      'Both
      If tabCameraControls.SelectedTab.Equals(tabVisionBoth) Then
        'With grpVisionStatusNorthGlass
        '  .Parent = tabVisionBoth
        '  .Top = 3
        '  .Left = grpNorth.Left + ((grpNorth.Width - .Width) / 2)
        'End With
        'With grpVisionStatusSouthMask
        '  .Parent = tabVisionBoth
        '  .Top = 3
        '  .Left = grpSouth.Left + ((grpSouth.Width - .Width) / 2)
        'End With
        With HSDisplaySouth
          .Parent = grpSouth
          .Top = 20
          .Left = 0
          .Width = grpSouth.Width
          .Height = grpSouth.Height - 100
        End With
        With HSDisplayNorth
          .Parent = grpNorth
          .Top = 20
          .Left = 0
          .Width = grpNorth.Width
          .Height = grpNorth.Height - 100
        End With
      End If
    Catch ex As Exception
      ShowVBErrors(ex.Message)
    End Try
  End Sub

#End Region

  Private Sub btnClearMarkersBoth_Click(sender As Object, e As EventArgs) Handles btnClearMarkersBoth.Click
    HSDisplayNorth.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
    HSDisplayNorth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
    HSDisplayNorth.RemoveAllMarker()
    HSDisplaySouth.set_ScenePenWidth(0, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
    HSDisplaySouth.set_ScenePenWidth(1, HSDISPLAYLib.hsPenWidth.hsPenWidthNone)
    HSDisplaySouth.RemoveAllMarker()
  End Sub

End Class
