Option Strict Off
Option Explicit On
Module mVars
  'General Constants
  Public Const Rad As Double = 180 / Math.PI
  Public NorthSide As Short = 0
  Public SouthSide As Short = 1

  Public Const LocNorthGlass As Short = 0
  Public Const LocNorthMask As Short = 1
  Public Const LocSouthGlass As Short = 2
  Public Const LocSouthMask As Short = 3
  Public Const FinalGlassOffset As Short = 4
  Public Const FinalMaskOffset As Short = 5
  Public Const FinalOffset As Short = 6
  Public Const Glass As Short = 0
  Public Const Mask As Short = 1
  Public Const Output As Short = 2
  Public Const Shift As Short = 3
  'Paths
  Public AppPath As String = My.Application.Info.DirectoryPath
	Public OpenOfficePath As String = "C:\Program Files\OpenOffice.org 2.4\program\swriter.exe "
	Public ConfigPath As String = AppPath & "\..\..\Config Data\" 'AppPath.Replace("\VB Code\bin", "") & "\Config Data\"
	Public PartsPath As String = AppPath & "\..\..\Parts\" 'AppPath.Replace("\VB Code\bin", "") & "\Parts\"
	Public HelpPath As String = AppPath & "\..\..\Help\" 'AppPath.Replace("\VB Code\bin", "") & "\Help\"
	Public CurrentFilePath As String
	Public CurrentImagePath As String
	Public SideName(3) As String
  Public AcquisitionName(1) As String
  Public Devicename(1) As String
	'General Variables
	Public PartName As String
	Public TableName As String
	Public UseScreenShot As Boolean
	Public s32Cam As Integer
  Public ConnectionFlag As Boolean
  Public SerialPortReadIsDone As Boolean = False
  Public Comm As New clsSerialHandler
  '
  Public Deposit As PointData
	Public SavedDeposit As PointData
	Public OriginalDeposit As PointData
	'
	Public Side As PointGroup
	Public Pick As PointGroup
  '
  Public LocatorResults(6) As VisionData
  Public Offset2 As OffsetType
  '
  'Servo related
  Public PickupLimit As LimitStruct

  '
  ' Camera Related
  Public InitSuccessNorth As Boolean
	Public InitSuccessSouth As Boolean
  '
  '
  Public Temp_Recipe_Array(10) As String
	Public PickPlate_Mode As String
  Public Recipe_Delay_Counter As Integer = 0
  Public DebugValue As String
  Public debugtime As Integer
	'
	'used in FrmCalc
	Public Origin As Point_
	Public RefAnchor As Point_
	Public Offset As Point_
	'
	'Verify program completion
	Public isdone As Double
	Public SaveImages As Boolean
  'used in frmMain
  Public Ref0 As Point_
	Public Ref1 As Point_
	Public Ref2 As Point_
	Public Corner As Point_
	Public NewRef As Point_
	Public NNominal As Point_
  Public SNominal As Point_
  '
  'Search Areas
  Public NorthMask As SearchArea
  Public NorthGlass As SearchArea
  Public SouthMask As SearchArea
  Public SouthGlass As SearchArea
  '
  'User defined types
  Public Structure Point_
		Dim X As Single
		Dim Y As Single
		Dim R As Single
	End Structure

	Public Structure PointData
		Dim Point As Point_
		Dim Angle As Single
		Dim Length As Single
		Dim Height As Single
	End Structure

	Public Structure PointGroup
		Dim Original As PointData
		Dim Zeroed As PointData
		Dim Shifted As PointData
		Dim Difference As PointData
	End Structure

	Public Structure VisionData
    Dim X As Single
    Dim Y As Single
    Dim R As Single
    Dim Xstr As String
    Dim Ystr As String
    Dim Rstr As String
    Dim Status As String
    Dim Success As Boolean
    Dim Score As Single
    Dim Length As Single
  End Structure

	Public Structure LimitStruct
		Dim XUpper As Single
		Dim XLower As Single
		Dim YUpper As Single
		Dim YLower As Single
		Dim RUpper As Single
		Dim Rlower As Single
	End Structure

  Public Structure SearchArea
    Dim CenterX As Single
    Dim CenterY As Single
    Dim CenterR As Single
    Dim Width As Single
    Dim Height As Single
  End Structure

  Public Structure PointStruct
		Dim Row As Integer
		Dim Column As Integer
	End Structure

	Public Structure Rectangle_
		Dim Row As Double
		Dim Column As Double
		Dim Phi As Double
		Dim Length1 As Double
		Dim Length2 As Double
		Dim Rectangle1 As Boolean
	End Structure

  'User Defined Types
  Public Structure OffsetType
    Dim Xoff As Single
    Dim Yoff As Single
    Dim Roff As Single
    Dim Length As Single
    Dim Xstr As String
    Dim Ystr As String
    Dim Rstr As String
    Dim Found As Boolean
    Dim Status As String
  End Structure

  Public Structure CoordType
    Dim Image As OffsetType
    Dim World As OffsetType
  End Structure

  Public Structure LocatorData
    Dim AcquisitionName As String
    Dim CameraName As String
    Dim CameraIndex As Short
    Dim Locator As HSLOCATORLib.HSLocator
    Dim LocatorName As String
    Dim ModelFileName As String
    Dim Offset As OffsetType
    Dim Score As Single
  End Structure

  Public Structure CamSetupType
    Dim CameraName As String
    Dim CameraGuid As String
    Dim DeviceNumber As String
    Dim DeviceName As String
  End Structure

  Public Enum Reg
    BackCorner = 10
    OperatorCorner = 11
    SideToSide = 12
    ApplyOffset = 13
    LoadPartName = 14
  End Enum


End Module