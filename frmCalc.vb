Option Strict Off
Option Explicit On
Imports vb = Microsoft.VisualBasic
Friend Class frmCalc
	Inherits System.Windows.Forms.Form

  Public Function CalcPickUp(ByRef LocSouth As PointData, ByRef locNorth As PointData) As PointData
    Dim ZeroShifted As Point_
    CalcPickUp.Point = CalcMidpoint(LocSouth.Point, locNorth.Point)
    ZeroShifted.X = locNorth.Point.X - LocSouth.Point.X
    ZeroShifted.Y = locNorth.Point.Y - LocSouth.Point.Y
    CalcPickUp.Angle = GetAngle(ZeroShifted)
	End Function

	Public Function CalcAbsAngle(ByRef LocSouth As Point_, ByRef locNorth As Point_) As Single
		Dim ZeroShifted As Point_
		Try
			ZeroShifted.X = locNorth.X - LocSouth.X
			ZeroShifted.Y = locNorth.Y - LocSouth.Y
			CalcAbsAngle = GetAngle(ZeroShifted)
		Catch ex As Exception
      frmMain.ShowVBErrors(ex.Message)
    End Try
	End Function

  Private Function CalcMidpoint(ByRef SouthXY As Point_, ByRef NorthXY As Point_) As Point_
    CalcMidpoint.X = (SouthXY.X + NorthXY.X) / 2
    CalcMidpoint.Y = (SouthXY.Y + NorthXY.Y) / 2
  End Function

  Private Function GetAngle(ByRef XY As Point_) As Single
    If (XY.X = 0) And (XY.Y > 0) Then 'Quadrant 1
      GetAngle = 90
    ElseIf (XY.X = 0) And (XY.Y < 0) Then  'Quadrant 4
      GetAngle = -90
    Else
			GetAngle = System.Math.Atan(XY.Y / XY.X) * (180 / Math.PI)
      If (XY.X < 0) And (XY.Y > 0) Then 'Quadrant 2
        GetAngle = GetAngle + 180
      ElseIf (XY.X < 0) And (XY.Y < 0) Then  'Quadrant 3
        GetAngle = GetAngle - 180
      End If
    End If
  End Function

  Private Function SubPoints(ByRef Subtractor As Point_, ByRef Subtractee As Point_) As Point_
    SubPoints.X = Subtractor.X - Subtractee.X
    SubPoints.Y = Subtractor.Y - Subtractee.Y
  End Function

  Private Function AddPoints(ByRef First As Point_, ByRef Second_Renamed As Point_) As Point_
    AddPoints.X = First.X + Second_Renamed.X
    AddPoints.Y = First.Y + Second_Renamed.Y
  End Function

  Public Function GetLength(ByRef First As Point_, ByRef Second_Renamed As Point_) As Single
    GetLength = System.Math.Sqrt(((Second_Renamed.X - First.X) ^ 2) + ((Second_Renamed.Y - First.Y) ^ 2))
  End Function

  Private Sub CalcAnchorShift()
    Dim AngleChange As Single
    'This routine is only ran when ever the operator wishes to shift the glass by using one of the stops
    'as an anchor and shifting the other stop by a + or - X direction.
    '
    'subtract the anchor point from the side point for the original side without the offset
    With Side.Zeroed
      .Point = SubPoints(Side.Original.Point, RefAnchor)          ', Anchor)
      'find the angle of the original side point before the offset is applied after subtracting the anchor point
      .Angle = GetAngle(.Point)
      'find the length from the origin to the zeroed out original side position
      .Length = GetLength(Origin, .Point)
    End With
    '
    'add the offset to the original side point and find its vector info
    With Side.Shifted
      .Point = AddPoints(Side.Zeroed.Point, Offset)
      'find the angle of the shifted side point after subtracting the anchor point
      .Angle = GetAngle(.Point)
      'find the length from the origin to the zeroed out shifted side position
      .Length = GetLength(Origin, .Point)
      'find the angular amount that the point has shifted
      AngleChange = .Angle - Side.Zeroed.Angle
    End With
    '
    'subtract the anchor point from the pick point and find it vector info
    With Pick.Zeroed
      .Point = SubPoints(Pick.Original.Point, RefAnchor)
      'find the angle of the pickup point after subtracting the anchor point
      .Angle = GetAngle(.Point)
      'find the length from the origin to the zeroed out pick point
      .Length = GetLength(Origin, .Point)
    End With
    '
    'Find new Pick Point by shifting its angle by the angle difference
    With Pick.Shifted
      .Length = Pick.Zeroed.Length
      .Angle = Pick.Zeroed.Angle + AngleChange
			.Point.X = System.Math.Cos((.Angle) * (Math.PI / 180)) * .Length
			.Point.Y = System.Math.Sin((.Angle) * (Math.PI / 180)) * .Length
    End With
    '
    'Find the difference between the old pick position and the new one
    With Pick.Difference
      .Point.X = Pick.Shifted.Point.X - Pick.Zeroed.Point.X
      .Point.Y = Pick.Shifted.Point.Y - Pick.Zeroed.Point.Y
      .Angle = AngleChange
    End With
    'calculate the deposit offset from the Pick.Difference point
    'X and Y have to be modified based on what quadrant the deposit position is in based on rotation.  This isnt the best way to make this work, but it seems sufficient.
    'If mobjVars.Item("PickSide").value = NorthSide Then
    With Deposit
      ' First Quadrant
      If .Angle <= 45 And .Angle >= -45 Then
        .Point.X = .Point.X + Pick.Difference.Point.X
        .Point.Y = .Point.Y + Pick.Difference.Point.Y
        'Third Quadrant
      ElseIf .Angle <= 225 And .Angle >= 135 Then
        .Point.X = .Point.X + Pick.Difference.Point.X
        .Point.Y = .Point.Y + Pick.Difference.Point.Y
        'Second Quadrant
      ElseIf .Angle > 45 Then
        .Point.X = .Point.X - Pick.Difference.Point.Y
        .Point.Y = .Point.Y + Pick.Difference.Point.X
        'Fourth Quadrant
      ElseIf .Angle < -45 Then
        .Point.X = .Point.X - Pick.Difference.Point.Y
        .Point.Y = .Point.Y + Pick.Difference.Point.X
      End If
      If AngleChange < -300 Then AngleChange = AngleChange + 360
      If AngleChange > 300 Then AngleChange = AngleChange - 360
      .Angle = .Angle + AngleChange
    End With
    'Else
    'With SOffset
    'End With
    'End If
  End Sub
  Private Sub InitPoints()
    'Origin
    'Always 0,0
    Origin.X = 0
    Origin.Y = 0
    'Offset is amount to shift the Non-Anchor side point.
    'Offset.X = -1
    'Offset.Y = 0
    'Anchor is defined as the hexsight reference point thats absolute value of its offset is smallest in X
    'RefAnchor.X = 1
    'RefAnchor.Y = 3
    '
    'Side.Original is defined as the hexsight reference point thats absolute value of its offset is largest in X
    'Side.Original.Point.X = 1
    'Side.Original.Point.Y = 1
    '
    'The Pick Point
    'Pick.Original.Point.X = 1
    'Pick.Original.Point.Y = 1
    '
    'The Deposit Position
    'Deposit.Point.X = 0
    'Deposit.Point.Y = 0
    'Deposit.Angle = 0
  End Sub

  Public Sub btnCalcAnchorShift_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCalcAnchorShift.Click
    InitPoints()
    CalcAnchorShift()
  End Sub

  Private Sub frmCalc_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    InitPoints()
  End Sub

  Private Sub btnCalcAngle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcAngle.Click
    Dim TestPoint As Point_
    TestPoint.X = CDbl(txtX.Text)
    TestPoint.Y = CDbl(txtY.Text)
    txtAngle.Text = CStr(GetAngle(TestPoint))
  End Sub
  Public Shared Function GetSignX(ByRef First As Point_, ByRef Second_Renamed As Point_) As Integer
    GetSignX = Math.Sign(Second_Renamed.X - First.X)
  End Function
End Class