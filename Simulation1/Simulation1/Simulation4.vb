Public Class Simulation4



    'Declaring arrays and variables
    Dim ParameterValues() As Array
    Dim OriginalParameterValues(2) As Decimal
    Private StartingParameterValues(2) As Decimal
    Dim OriginalTickBoxState(1) As Boolean
    Dim f As Decimal
    Dim R As Decimal
    Dim FirstLoad As Boolean = True
    Dim VectorsChecked As Boolean = False
    Dim CircleChecked As Boolean = False
    Dim EraseColour As Color = Drawing.Color.FromArgb(255, 240, 240, 240)
    Dim PenForCircle As Pen = New Pen(EraseColour)




    'buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Hide()
    End Sub




    'drawing boxes
    Private Sub Simulation1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawRectangle(Pens.Black, 12, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 168, 48, 800, 500)
        e.Graphics.DrawRectangle(Pens.Black, 974, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 12, 554, 1112, 150)

    End Sub


    'functions and procedures
    Private Function AccordValues(tkbar As TrackBar, txtBx As TextBox, tkbarChanged As Boolean)
        If tkbarChanged = True Then
            txtBx.Text = tkbar.Value
        ElseIf tkbarChanged = False Then
            tkbar.Value = Decimal.Parse(txtBx.Text)
        End If
    End Function

    Public Function ValidateItem(ByVal e As KeyPressEventArgs, tkbar As TrackBar, txtBx As TextBox, accuracy As String)
        'this part of the procedure allows only number, dot and back space input
        'this flag is to allow the input of the dot charachter only once
        'Asc(e.KeyChar) evaluates the ascii value of the input character
        Dim FinishInput As Boolean = False

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then

            'between 48 and 57 are numbers and 8 is for backspace and 46 is the dot (.)
            'allow the input event


        ElseIf (Asc(e.KeyChar) = 13) Then

            txtBx.Text = Format(Val(txtBx.Text), accuracy) 'round the input value to the accuracy input in the procedure
            'check the validity within the range of the track bar
            If (txtBx.Text <= tkbar.Maximum And txtBx.Text >= tkbar.Minimum) Then
                tkbar.Value = txtBx.Text
                FinishInput = True
            Else
                MsgBox("Input a value between" & tkbar.Minimum & "and" & tkbar.Maximum)

            End If

        Else
            MsgBox("Input only numbers") 'output a message to inform the user that he input an invalid charachter
            e.Handled = True 'forbid any other key

        End If
        Return FinishInput
    End Function

    Sub StopAnimation()
        'Erase old radius and circle
        Dim g As Graphics = Me.CreateGraphics
        Dim x As Integer = Ball.Left + (Ball.Width) / 2
        Dim y As Integer = Ball.Top + (Ball.Height) / 2
        Dim EraseColour As Color = Drawing.Color.FromArgb(255, 240, 240, 240)
        Dim p As Pen = New Pen(EraseColour)
        g.DrawLine(p, x, y, 553, 268)
        x = 553 - R
        y = 268 - R
        Dim diameter As Integer = 2 * R
        g.DrawEllipse(p, x, y, diameter, diameter)

        'Displacing the ball
        Ball.Left = 553 - R - (Ball.Width) / 2
        Ball.Top = 268 - Ball.Height / 2

        'displacing the acceleration and resetting its direaction
        velocity.Width = 7
        velocity.Height = 2 * Math.PI * f * R / 100
        velocity.Image = My.Resources.up_arrow
        velocity.Left = Ball.Left + Ball.Width / 2
        velocity.Top = Ball.Top + Ball.Height / 2 - velocity.Height

        'displacing the acceleration and resetting its direaction
        acceleration.Height = 7
        acceleration.Width = 4 * Math.PI * Math.PI * f * f * R / 5000
        acceleration.Image = My.Resources.right_arrow
        acceleration.Left = Ball.Left + Ball.Width / 2
        acceleration.Top = Ball.Top + Ball.Height / 2

        'Drawing radius and circle again 
        x = Ball.Left + (Ball.Width) / 2
        y = Ball.Top + (Ball.Height) / 2
        g.DrawLine(Pens.Black, x, y, 553, 268)
        x = 553 - R
        y = 268 - R
        diameter = 2 * R
        g.DrawEllipse(PenForCircle, x, y, diameter, diameter)

        lblVectors.Text = "v = 2πR·f = 314" & Environment.NewLine & "a = v²/R = 9870"

        t = 0
        Timer.Enabled = False
    End Sub

    Dim horizontalVtest As Decimal
    Dim verticalVtest As Decimal
    Dim horizontalAtest As Decimal
    Dim verticalAtest As Decimal

    Sub MoveItems(t As Decimal)

        Ball.Left = -R * Math.Cos(0.002 * Math.PI * f * t) + 553 - Ball.Width / 2
        Ball.Top = -R * Math.Sin(0.002 * Math.PI * f * t) + 268 - Ball.Width / 2

        horizontalAtest = 4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R * Math.Cos(0.002 * Math.PI * f * t)
        verticalAtest = 4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R * Math.Sin(0.002 * Math.PI * f * t)
        horizontalVtest = 2 * 3.1415926535897931 * R * f * Math.Sin(0.002 * Math.PI * f * t)
        verticalVtest = 2 * 3.1415926535897931 * R * f * Math.Cos(0.002 * Math.PI * f * t)

        If Ball.Left >= 553 - Ball.Width / 2 Then
            If Ball.Top >= 268 - Ball.Height / 2 Then
                velocity.Image = My.Resources.down_left_arrow
                velocity.Width = -horizontalVtest / 100
                velocity.Height = -verticalVtest / 100
                velocity.Left = Ball.Left + Ball.Width / 2 - velocity.Width
                velocity.Top = Ball.Top + Ball.Height / 2

                acceleration.Image = My.Resources.up_left_arrow
                acceleration.Width = -horizontalAtest / 5000
                acceleration.Height = -verticalAtest / 5000
                acceleration.Left = Ball.Left + Ball.Width / 2 - acceleration.Width
                acceleration.Top = Ball.Top + Ball.Height / 2 - acceleration.Height

            Else
                velocity.Image = My.Resources.down_right_arrow
                velocity.Width = horizontalVtest / 100
                velocity.Height = -verticalVtest / 100
                velocity.Left = Ball.Left + Ball.Width / 2
                velocity.Top = Ball.Top + Ball.Height / 2

                acceleration.Image = My.Resources.down_left_arrow
                acceleration.Width = -horizontalAtest / 5000
                acceleration.Height = verticalAtest / 5000
                acceleration.Left = Ball.Left + Ball.Width / 2 - acceleration.Width
                acceleration.Top = Ball.Top + Ball.Height / 2

            End If
        Else
            If Ball.Top >= 268 - Ball.Height / 2 Then
                velocity.Image = My.Resources.up_left_arrow
                velocity.Width = -horizontalVtest / 100
                velocity.Height = verticalVtest / 100
                velocity.Left = Ball.Left + Ball.Width / 2 - velocity.Width
                velocity.Top = Ball.Top + Ball.Height / 2 - velocity.Height

                acceleration.Image = My.Resources.up_right_arrow
                acceleration.Width = horizontalAtest / 5000
                acceleration.Height = -verticalAtest / 5000
                acceleration.Left = Ball.Left + Ball.Width / 2
                acceleration.Top = Ball.Top + Ball.Height / 2 - acceleration.Height

            Else
                velocity.Image = My.Resources.up_right_arrow
                velocity.Width = horizontalVtest / 100
                velocity.Height = verticalVtest / 100
                velocity.Left = Ball.Left + Ball.Width / 2 
                velocity.Top = Ball.Top + Ball.Height / 2 - velocity.Height

                acceleration.Image = My.Resources.down_right_arrow
                acceleration.Width = horizontalAtest / 5000
                acceleration.Height = verticalAtest / 5000
                acceleration.Left = Ball.Left + Ball.Width / 2
                acceleration.Top = Ball.Top + Ball.Height / 2

            End If
        End If

        'Drawing new radius and circle
        Dim g As Graphics = Me.CreateGraphics
        Dim x As Integer = -R * Math.Cos(0.002 * Math.PI * f * (t - Timer.Interval)) + 553 - Ball.Width / 2 + (Ball.Width) / 2
        Dim y As Integer = -R * Math.Sin(0.002 * Math.PI * f * (t - Timer.Interval)) + 268 - Ball.Width / 2 + (Ball.Height) / 2
        Dim EraseColour As Color = Drawing.Color.FromArgb(255, 240, 240, 240)
        Dim p As Pen = New Pen(EraseColour)
        g.DrawLine(p, x, y, 553, 268)
        x = Ball.Left + (Ball.Width) / 2
        y = Ball.Top + (Ball.Height) / 2
        g.DrawLine(Pens.Black, x, y, 553, 268)
        x = 553 - R
        y = 268 - R
        Dim diameter As Integer = 2 * R
        g.DrawEllipse(PenForCircle, x, y, diameter, diameter)

    End Sub


    'Edditing box
    Private Sub tkbarF_Scroll(sender As Object, e As EventArgs) Handles tkbarF.Scroll
        f = tkbarF.Value
        AccordValues(tkbarF, txtBxF, True)
        acceleration.Width = (4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R) / 5000
        acceleration.Left = Ball.Left + 35
        acceleration.Top = Ball.Top + 35 - 3.5
        velocity.Height = (2 * 3.1415926535897931 * R * f) / 100
        velocity.Left = Ball.Left + 35
        velocity.Top = Ball.Top + 35 - velocity.Height
        'Drawing radius and circle again 
        Dim x As Integer = Ball.Left + (Ball.Width) / 2
        Dim y As Integer = Ball.Top + (Ball.Height) / 2
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(Pens.Black, x, y, 553, 268)
        x = 553 - R
        y = 268 - R
        Dim diameter As Integer = 2 * R
        g.DrawEllipse(PenForCircle, x, y, diameter, diameter)
        lblVectors.Text = "v = 2πR·f = " & 2 * 3.1415926535897931 * R * f & Environment.NewLine & "a = v²/R = " & 4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R
        StopAnimation()
    End Sub

    Private Sub txtBxF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxF.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarF, txtBxF, "0.0")
        If FinishInput Then
            f = txtBxF.Text
            AccordValues(tkbarF, txtBxF, False)
            acceleration.Width = (4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R) / 5000
            acceleration.Left = Ball.Left + 35
            acceleration.Top = Ball.Top + 35 - 3.5
            velocity.Height = (2 * 3.1415926535897931 * R * f) / 100
            velocity.Left = Ball.Left + 35
            velocity.Top = Ball.Top + 35 - velocity.Height
            'Drawing radius and circle again 
            Dim x As Integer = Ball.Left + (Ball.Width) / 2
            Dim y As Integer = Ball.Top + (Ball.Height) / 2
            Dim g As Graphics = Me.CreateGraphics
            g.DrawLine(Pens.Black, x, y, 553, 268)
            x = 553 - R
            y = 268 - R
            Dim diameter As Integer = 2 * R
            g.DrawEllipse(PenForCircle, x, y, diameter, diameter)
            lblVectors.Text = "v = 2πR·f = " & 2 * 3.1415926535897931 * R * f & Environment.NewLine & "a = v²/R = " & 4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R
            StopAnimation()
        End If
    End Sub


    Private Sub tkbarR_Scroll(sender As Object, e As EventArgs) Handles tkbarR.Scroll
        'Erase old radius and circle
        Dim g As Graphics = Me.CreateGraphics
        Dim x As Integer = Ball.Left + (Ball.Width) / 2
        Dim y As Integer = Ball.Top + (Ball.Height) / 2
        Dim EraseColour As Color = Drawing.Color.FromArgb(255, 240, 240, 240)
        Dim p As Pen = New Pen(EraseColour)
        g.DrawLine(p, x, y, 553, 268)
        x = 553 - R
        y = 268 - R
        Dim diameter As Integer = 2 * R
        g.DrawEllipse(p, x, y, diameter, diameter)

        'Displacing the ball
        R = tkbarR.Value * 10
        AccordValues(tkbarR, txtBxR, True)
        Ball.Left = 553 - R - (Ball.Width) / 2

        'Drawing new radius and circle
        x = Ball.Left + (Ball.Width) / 2
        y = Ball.Top + (Ball.Height) / 2
        g.DrawLine(Pens.Black, x, y, 553, 268)
        x = 553 - R
        y = 268 - R
        diameter = 2 * R
        g.DrawEllipse(PenForCircle, x, y, diameter, diameter)

        'Modify the values, lengths and positions
        acceleration.Width = (4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R) / 5000
        acceleration.Left = Ball.Left + 35
        acceleration.Top = Ball.Top + 35 - 3.5
        velocity.Height = (2 * 3.1415926535897931 * R * f) / 100
        velocity.Left = Ball.Left + 35
        velocity.Top = Ball.Top + 35 - velocity.Height
        lblVectors.Text = "v = 2πR·f = " & 2 * 3.1415926535897931 * R * f & Environment.NewLine & "a = v²/R = " & 4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R

        StopAnimation()
    End Sub

    Private Sub txtBxR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxR.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarR, txtBxR, "0.0")
        If FinishInput Then
            'Erase old radius and circle
            Dim g As Graphics = Me.CreateGraphics
            Dim x As Integer = Ball.Left + (Ball.Width) / 2
            Dim y As Integer = Ball.Top + (Ball.Height) / 2
            Dim EraseColour As Color = Drawing.Color.FromArgb(255, 240, 240, 240)
            Dim p As Pen = New Pen(EraseColour)
            g.DrawLine(p, x, y, 553, 268)
            x = 553 - R
            y = 268 - R
            Dim diameter As Integer = 2 * R
            g.DrawEllipse(p, x, y, diameter, diameter)

            'Displacing the ball
            R = tkbarR.Value * 10
            AccordValues(tkbarR, txtBxR, True)
            Ball.Left = 553 - R - (Ball.Width) / 2

            'Drawing new radius and circle
            x = Ball.Left + (Ball.Width) / 2
            y = Ball.Top + (Ball.Height) / 2
            g.DrawLine(Pens.Black, x, y, 553, 268)
            x = 553 - R
            y = 268 - R
            diameter = 2 * R
            g.DrawEllipse(PenForCircle, x, y, diameter, diameter)

            'Modify the values, lengths and positions
            acceleration.Width = (4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R) / 5000
            acceleration.Left = Ball.Left + 35
            acceleration.Top = Ball.Top + 35 - 3.5
            velocity.Height = (2 * 3.1415926535897931 * R * f) / 100
            velocity.Left = Ball.Left + 35
            velocity.Top = Ball.Top + 35 - velocity.Height
            lblVectors.Text = "v = 2πR·f = " & 2 * 3.1415926535897931 * R * f & Environment.NewLine & "a = v²/R = " & 4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R

            StopAnimation()
        End If
    End Sub



    'editing box
    Private Sub ckbxCircle_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxCircle.CheckedChanged
        Dim g As Graphics = Me.CreateGraphics
        Dim x As Integer = 553 - R
        Dim y As Integer = 268 - R
        Dim diameter As Integer = 2 * R
        If CircleChecked = True Then
            CircleChecked = False
            PenForCircle = New Pen(EraseColour)
            g.DrawEllipse(PenForCircle, x, y, diameter, diameter)
        ElseIf CircleChecked = False Then
            CircleChecked = True
            PenForCircle = Pens.Black
            g.DrawEllipse(PenForCircle, x, y, diameter, diameter)
        End If
    End Sub

    Private Sub ckbxVectors_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxVectors.CheckedChanged
        If VectorsChecked = True Then
            VectorsChecked = False
            lblVectors.Visible = False
            acceleration.Visible = False
            velocity.Visible = False
        ElseIf VectorsChecked = False Then
            VectorsChecked = True
            lblVectors.Visible = True
            acceleration.Visible = True
            velocity.Visible = True
        End If
    End Sub

    'first load and reset button
    Private Sub Simulation3_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        OriginalParameterValues(0) = 5
        OriginalParameterValues(1) = 10
        If FirstLoad Then 'checking if the load is the first one'
            FirstLoad = False 'making the flag false'

            'setting the original values to the parameters'
            f = OriginalParameterValues(0)
            R = OriginalParameterValues(1)

            'changing the sliders position in the track bars and the content in the input boxes'
            tkbarF.Value = f
            txtBxF.Text = f
            tkbarR.Value = R
            txtBxR.Text = R

            'changing the positions and sizes of relevant items'
            'Displacing the ball
            R = tkbarR.Value * 10
            AccordValues(tkbarR, txtBxR, True)
            Ball.Left = 553 - R - (Ball.Width) / 2

            'Drawing new radius and circle
            Dim g As Graphics = Me.CreateGraphics
            Dim x As Integer = Ball.Left + (Ball.Width) / 2
            Dim y As Integer = Ball.Top + (Ball.Height) / 2
            g.DrawLine(Pens.Black, x, y, 553, 268)
            x = 553 - R
            y = 268 - R
            Dim diameter As Integer = 2 * R
            g.DrawEllipse(PenForCircle, x, y, diameter, diameter)





            'Modify the values, lengths and positions
            acceleration.Width = (4 * 3.1415926535897931 * 3.1415926535897931 * f * f * R) / 5000
            acceleration.Left = Ball.Left + 35
            acceleration.Top = Ball.Top + 35 - 3.5
            velocity.Height = (2 * 3.1415926535897931 * R * f) / 100
            velocity.Left = Ball.Left + 35
            velocity.Top = Ball.Top + 35 - velocity.Height
        End If
        StopAnimation()

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        StopAnimation()
        FirstLoad = True
        Me.Visible = False
        Me.Visible = True

    End Sub



    'start button
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        stopAnimation()
        Timer.Enabled = True
    End Sub

    Dim t As Decimal
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        t += Timer.Interval

        MoveItems(t)

    End Sub
End Class