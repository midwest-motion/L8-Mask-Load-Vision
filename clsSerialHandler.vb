Option Strict Off
Imports System.Text
Imports System.IO.Ports

Public Class clsSerialHandler
  Public ReceiveBuffer As New StringBuilder(32768)
  Public StringFromRobot As String
  Public CommErrorString As String
  Private WithEvents SerialPort As New DesktopSerialIO.SerialIO.SerialPort
  'Public WithEvents Com3 As New SerialPort("COM3")

  Public Function InitComm() As String
    Try
      With SerialPort
        'Close the port
        Try
          .PortOpen = False
        Catch
        End Try
        'Set the port number
        Try
          .CommPort = 5
        Catch ex As Exception
          InitComm = "Unable to Assign Comm Port " & .CommPort.ToString
        End Try
        'Set the other data
        .BitRate = 9600
        .StopBits = 1
        .RTSEnable = False
        .DTREnable = False
        .DataBits = 8
        .EnableOnComm = True
        .Timeout = 500
        'Open the port
        .PortOpen = True
        frmMain.DelayTimer(500)
        If Not .PortOpen Then
          InitComm = "Unable to Open Comm Port " & .CommPort.ToString
        Else
          InitComm = "Success"
        End If
      End With
    Catch ex As Exception
      frmMain.ShowVBErrors(ex.Message)
      InitComm = "Runtime Error"
    End Try
  End Function

  Public Function TestComm() As String
    With SerialPort
      If Not .PortOpen Then
        'Open the port
        .PortOpen = True
        If Not .PortOpen Then
          TestComm = "Unable to Open Comm Port 3"
        Else
          TestComm = "Success"
        End If
      Else
        TestComm = "Success"
      End If
    End With
  End Function

  Public Sub SendDataToRobot(ByRef Data As String)
    '
    'send the offset string
    Try
      SerialPort.Output((UCase(Data)) & vbCr)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub SerialPort_OnComm() Handles SerialPort.OnComm
    Static BigString As String
    '
    'Read data.
    System.Threading.Thread.Sleep(10)
    BigString = BigString + SerialPort.InputString
    If BigString.Contains(vbLf) Then
      StringFromRobot = BigString
      BigString = ""
      SerialPortReadIsDone = True
    End If
  End Sub

  Private Sub SerialPort_CommError(ByVal ErrorFlag As DesktopSerialIO.SerialIO.SerialPort.CommErrorFlags) Handles SerialPort.CommError
    CommErrorString = ErrorFlag.ToString
  End Sub




  'Using the built in Windows Serial IO Namespace
  '
  '

  'Public Function InitComm() As String
  '  With Com3
  '    'Close the port
  '    Try
  '      .Close()
  '    Catch
  '    End Try
  '    'Set the port number
  '    Try
  '      '.PortName = "COM3"
  '      .Open()
  '    Catch ex As Exception
  '      InitComm = "Unable to Assign Comm Port 3"
  '    End Try
  '    'Set the other data
  '    .BaudRate = 9600
  '    .StopBits = IO.Ports.StopBits.One
  '    .Parity = IO.Ports.Parity.None
  '    '.Handshake = Handshake.RequestToSend
  '    '.RtsEnable = True
  '    '.DtrEnable = True
  '    .DataBits = 8
  '    '.ReadTimeout = 2500
  '    .ReadTimeout = SerialPort.InfiniteTimeout
  '    'Open the port
  '    If Not .IsOpen Then
  '      InitComm = "Unable to Open Comm Port 3"
  '    Else
  '      InitComm = "Success"
  '    End If
  '    'Dim dummy() As String = SerialPort.GetPortNames()
  '  End With
  'End Function

  'Public Function TestComm() As String
  '  With Com3
  '    If Not .IsOpen Then
  '      'Open the port
  '      .Open()
  '      If Not .IsOpen Then
  '        TestComm = "Unable to Open Comm Port 3"
  '      Else
  '        TestComm = "Success"
  '      End If
  '    Else
  '      TestComm = "Success"
  '    End If
  '  End With
  'End Function

  'Public Sub SendDataToRobot(ByRef Data As String)
  '  '
  '  'send the offset string
  '  Try
  '    ' SerialPort.Output((UCase(Data)) & vbCr)
  '    Com3.WriteLine((UCase(Data)) & vbCr)
  '  Catch ex As Exception
  '    MsgBox("Error writing to the robot")
  '  End Try
  'End Sub

  'Private Sub Com3_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Com3.DataReceived
  '  Static BigString As String
  '  '
  '  'Read data.
  '  System.Threading.Thread.Sleep(10)
  '  Dim indata As String = sender.readexisting()
  '  BigString = BigString + indata
  '  If BigString.Contains(vbLf) Then
  '    StringFromRobot = BigString
  '    BigString = ""
  '    SerialPortReadIsDone = True
  '  End If
  'End Sub

  'Private Sub Com3_ErrorReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles Com3.ErrorReceived
  '  CommErrorString = e.ToString
  'End Sub


  'Private Sub Com3_PinChanged(ByVal sender As Object, ByVal e As System.IO.Ports.SerialPinChangedEventArgs) Handles Com3.PinChanged

  'End Sub
End Class
