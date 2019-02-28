
Imports System.IO


Public Class SnapshotHelper
  '  Public m_hCamera As Integer
  Public camera As New uEye.Camera()
  Public CameraId As Integer
  Private s32MemID As Int32
  Private s32Width As Integer
  Private s32height As Integer
  Dim CameraList(1) As uEye.Types.CameraInformation

  ''// Constructor
  'Public Sub New(ByVal hCamera As Integer)
  '  CameraId = hCamera
  'End Sub

  Public Function InitCamera() As Boolean
    Try
      Dim statusRet As uEye.Defines.Status
      Dim s32Min, s32max, s32inc As Integer
      'Open Camera
      statusRet = camera.Init(CameraId)
      camera.PixelFormat.Set(uEye.Defines.ColorMode.Mono8)
      camera.Timing.PixelClock.GetRange(s32Min, s32max, s32inc)
      camera.Timing.PixelClock.Set(s32max)
      If (statusRet <> uEye.Defines.Status.Success) Then
        MessageBox.Show("Camera initializing failed")
        Return False
      End If
      camera.PixelFormat.Set(uEye.Defines.ColorMode.Mono8)
      'Allocate Memory
      statusRet = camera.Memory.Allocate(s32MemID, True)
      If (statusRet <> uEye.Defines.Status.Success) Then
        MessageBox.Show("Allocate Memory failed")
        Return False
      End If
      ' all good
      Return True
    Catch ex As Exception
      frmMain.ShowVBErrors("InitCamera" & CameraId, ex.Message) ', "Failed to InitCamera " & CameraId & " ")
      Return False
    End Try

  End Function
  Public Sub ExitCamera()
    camera.Exit()
  End Sub

  Private Function GetNumPixels() As Integer
    'Determine the number of pixels in a frame
    '
    '# pixels = height * width
    'When we query the ROI feature, the camera reports the undecimated ROI
    'Therefore we have to take the camera's current decimation (pixel addressing value)
    'mode into account
    Try
      camera.Memory.GetSize(s32MemID, s32Width, s32height)
      Return s32Width * s32height
    Catch ex As Exception
      frmMain.ShowVBErrors("GetNumPixels", ex.Message)
    End Try
  End Function

  Private Function DetermineRawImageSize() As Integer
    Try
      Dim bytesPerPixel As Integer
      camera.PixelFormat.GetBytesPerPixel(bytesPerPixel)
      Return bytesPerPixel * GetNumPixels()
    Catch ex As Exception
      frmMain.ShowVBErrors("DetermineRawImageSize", ex.Message)
    End Try

  End Function

  Public Function GetSnapshot(ByRef image As HSCLASSLIBRARYLib.HSImage) As Boolean
    Dim rawImageSize As Integer
    Try
      rawImageSize = DetermineRawImageSize()
      Dim buf(rawImageSize - 1) As Byte
      'Successful initialization of camera
      'Freeze Video
      If Not isOnline() Then Return False
      camera.Acquisition.Freeze(uEye.Defines.DeviceParameter.Wait)
      'Get memory id number
      camera.Memory.GetActive(s32MemID)
      'copy data
      camera.Memory.CopyToArray(s32MemID, buf)
      'Set the Image Size and Width for the Hexsight Import Image process
      image.Width = s32Width
      image.Height = s32height
      image.CopyFromSafeArray(buf, True)
      Return True
    Catch ex As Exception
      frmMain.ShowVBErrors("GetSnapshot - Camera ID =" & CameraId, ex.Message)
      Return False
    End Try
  End Function

  Private Function byteArrayToImage(byteArrayIn As Byte()) As Image
    Dim ms As New MemoryStream(byteArrayIn)
    Dim returnImage As Image = Image.FromStream(ms)
    Return returnImage
  End Function

  Public Function SetSimpleFeature(ByVal featureid As String, ByVal param0 As Single) As Boolean
    Try
      Dim statusRet As uEye.Defines.Status
      featureid = LCase(featureid)
      Select Case featureid
        Case "exposure"
          camera.Timing.Exposure.Set(param0 / 10)
        Case "gain"
          camera.Gain.Hardware.Boost.SetEnable(True)
          camera.Gain.Hardware.Scaled.SetMaster(CInt(param0))
      End Select
      If (statusRet = uEye.Defines.Status.Success) Then
        Return True
      Else
        Return False
      End If
    Catch ex As Exception
      frmMain.ShowVBErrors("SetSimpleFeature", ex.Message) ', " Failed to SetSimpleFeature. Camera ID= " & CameraId)
      Return False
    End Try
  End Function

  Public Function GetSimpleFeature(ByVal featureId As String) As Integer
    Try
      Dim info As uEye.Types.ETH.DeviceInformation
      Dim statusRet As uEye.Defines.Status
      Dim FeatureValue As Integer
      Select Case featureId
        Case "Temperature"
          statusRet = camera.Information.GetDeviceInfo(info)
          FeatureValue = CInt(info.DeviceHeartbeat.Temperature)
      End Select
      Return FeatureValue
    Catch ex As Exception
      frmMain.ShowVBErrors("GetSimpleFeature", ex.Message) ', " Failed to GetSimpleFeature. CameraID =" & CameraId)
    End Try
  End Function

  Public Function isOnline() As Boolean
    'Dim nInfo As Long
    'Dim RetCode As Long
    'Dim statusRet As uEye.Defines.Status

    '' Show error image and try reinit cam

    'RetCode = uEye.Info.Camera.
    '  'uEye.Info.Camera.GetCameraStatus(nInfo)
    'If (uEyeCam_3.GetCameraStatus(nInfo)) <> 0 Then
    '  FileCopy App.Path & "\Camera_Images\NoImage.bmp", App.Path & "\Camera_Images\Image_Cam_3.bmp"
    '           uEyeCam_3.ExitCamera
    '  uEyeCam_3.InitCamera(3)
    'End If

    Dim Count As Integer
    Dim statusRet As uEye.Defines.Status
    Dim CamID As String
    Dim Message As String
    Try
      statusRet = uEye.Info.Camera.GetNumberOfDevices(Count)
      If Count <> 2 Then
        If Count = 0 Then
          frmShowError.Show()
          frmShowError.lblErrorMessage.Text = "Both Cameras Not Detected"
        End If
        For Count = 0 To Count - 1
          statusRet = uEye.Info.Camera.GetCameraList(CameraList)
          CamID = CameraList(Count).CameraID.ToString
          Select Case CamID
            Case "1"
              Message = "Southside Camera Not Detected"
              'frmMain.lblCameraStatusSouth.Visible = True
              frmShowError.Show()
              frmShowError.lblErrorMessage.Text = Message
              frmMain.ImageSouth.Load(ConfigPath & "NoImage.bmp")
              Return False
            Case "2"
              Message = "Northside Camera Not Detected"
              'frmMain.lblCameraStatusNorth.Visible = True
              frmShowError.Show()
              frmShowError.lblErrorMessage.Text = Message
              frmMain.ImageNorth.Load(ConfigPath & "NoImage.bmp")
              Return False
          End Select
        Next Count
      Else
        'frmMain.lblCameraStatusNorth.Visible = False
        'frmMain.lblCameraStatusSouth.Visible = False
        Return True
      End If
      Return True
    Catch ex As Exception
      frmMain.ShowVBErrors("isOnline", ex.Message) ', " Camera IsOnline, cameraID=" & CameraId)
    End Try
  End Function

End Class
