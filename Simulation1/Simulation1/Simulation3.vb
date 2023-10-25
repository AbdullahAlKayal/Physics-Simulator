Public Class Simulation3

    'Declaring variables and arrays
    Private ParameterValues(2) As Decimal
    Private OriginalParameterValues(2) As Decimal
    Private StartingParameterValues(2) As Decimal
    Dim m As Decimal
    Dim k As Decimal
    Dim A As Decimal
    Dim FirstLoad As Boolean = True
    Dim DisplacementChecked As Boolean = False
    Dim VectorsChecked As Boolean = False


    'buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Hide()
    End Sub



    'Drawing all the constant shape that are needed for the simulation
    Private Sub Simulation1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'editing, animation, description, and information boxes
        e.Graphics.DrawRectangle(Pens.Black, 12, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 168, 48, 800, 500)
        e.Graphics.DrawRectangle(Pens.Black, 974, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 12, 554, 1112, 150)
        'ground
        e.Graphics.DrawLine(Pens.Black, 168, 418, 968, 418)
        'wall
        e.Graphics.DrawLine(Pens.Black, 188, 418, 188, 328)
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
        Timer.Enabled = False
        t = 0
        OscillationBorder.Left = EquilibriumLine.Left + A * 10
        Mass.Left = OscillationBorder.Left - 90
        spring.Width = Mass.Left - 188
        Aarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
        lblinitialDiplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblinitialDiplacement.Width) / 2
        Xarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
        Xarrow.Left = EquilibriumLine.Left + EquilibriumLine.Width
        lblDisplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblDisplacement.Width) / 2
        acceleration.Width = (k * Xarrow.Width) / (10 * m)
        acceleration.Left = Mass.Left + 45 - acceleration.Width
        lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
        Velocity.Left = Mass.Left + 45
        acceleration.Image = My.Resources.left_arrow
        Velocity.Width = 0
        lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)
        lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & A & Environment.NewLine & "ω = √(k/m) = " & Math.Sqrt(k / m)
        lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Environment.NewLine & "a = -ω²·x = " & -(k / m) * A
    End Sub

    Sub MoveItems(t As Decimal)
        spring.Width = A * 10 * Math.Cos(Math.Sqrt(k / m) * t) + EquilibriumLine.Left - spring.Left - Mass.Width
        Mass.Left = A * 10 * Math.Cos(Math.Sqrt(k / m) * t) - Mass.Width + EquilibriumLine.Left
        Xtest = A * 10 * Math.Cos(Math.Sqrt(k / m) * t)
        Vtest = -Math.Sqrt(k / m) * A * 10 * Math.Sin(Math.Sqrt(k / m) * t) / 10
        Atest = -(k / m) * A * 10 * Math.Cos(Math.Sqrt(k / m) * t) / 10
        If Atest < 0 Then
            acceleration.Image = My.Resources.left_arrow
            acceleration.Width = -Atest
            acceleration.Left = Mass.Left + 35 - acceleration.Width
        ElseIf Atest > 0 Then
            acceleration.Image = My.Resources.right_arrow
            acceleration.Width = Atest
            acceleration.Left = Mass.Left + 35
        End If
        If Vtest < 0 Then
            Velocity.Image = My.Resources.left_arrow
            Velocity.Width = -Vtest
            Velocity.Left = Mass.Left + 34 - Velocity.Width
        ElseIf Vtest > 0 Then
            Velocity.Image = My.Resources.right_arrow
            Velocity.Width = Vtest
            Velocity.Left = Mass.Left + 36
        End If
        If Xtest < 0 Then
            Xarrow.Width = -Xtest
            Xarrow.Left = EquilibriumLine.Left - Xarrow.Width
        ElseIf Xtest > 0 Then
            Xarrow.Width = Xtest
            Xarrow.Left = EquilibriumLine.Left
        End If
        lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
        lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)
        lblDisplacement.Left = EquilibriumLine.Left + (Xtest - lblDisplacement.Width) / 2

        lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & Format(A * Math.Cos(Math.Sqrt(k / m) * t), "0.0") & Environment.NewLine & "ω = √(k/m) = " & Format(Math.Sqrt(k / m), "0.0")
        lblVectors.Text = "v = ±ω·√(A²-x²) = " & Format(-Math.Sqrt(k / m) * A * Math.Sin(Math.Sqrt(k / m) * t), "0.0") & Environment.NewLine & "a = -ω²·x = " & Format(-(k / m) * A * Math.Cos(Math.Sqrt(k / m) * t), "0.0")

    End Sub


    'Edditing box
    Private Sub tkbarM_Scroll(sender As Object, e As EventArgs) Handles tkbarM.Scroll
        m = tkbarM.Value
        AccordValues(tkbarM, txtBxM, True)
        acceleration.Width = (k * Xarrow.Width) / (10 * m)
        acceleration.Left = Mass.Left + 45 - acceleration.Width
        lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
        Velocity.Left = Mass.Left + 45
        lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)
        lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & A & Environment.NewLine & "ω = √(k/m) = " & Math.Sqrt(k / m)
        lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Environment.NewLine & "a = -ω²·x = " & -(k / m) * A
        StopAnimation()

    End Sub

    Private Sub txtBxM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxM.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarM, txtBxM, "0.0")
        If FinishInput Then
            m = txtBxM.Text
            AccordValues(tkbarM, txtBxM, False)
            acceleration.Width = (k * Xarrow.Width) / (10 * m)
            acceleration.Left = Mass.Left + 45 - acceleration.Width
            lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
            Velocity.Left = Mass.Left + 45
            lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)
            lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & A & Environment.NewLine & "ω = √(k/m) = " & Math.Sqrt(k / m)
            lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Environment.NewLine & "a = -ω²·x = " & -(k / m) * A
            StopAnimation()

        End If
    End Sub

    Private Sub tkbarK_Scroll(sender As Object, e As EventArgs) Handles tkbarK.Scroll
        k = tkbarK.Value
        AccordValues(tkbarK, txtBxK, True)
        acceleration.Width = (k * Xarrow.Width) / (10 * m)
        acceleration.Left = Mass.Left + 45 - acceleration.Width
        lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & A & Environment.NewLine & "ω = √(k/m) = " & Math.Sqrt(k / m)
        lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Environment.NewLine & "a = -ω²·x = " & -(k / m) * A
        StopAnimation()

    End Sub

    Private Sub txtBxK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxK.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarK, txtBxK, "0.0")
        If FinishInput Then
            k = txtBxK.Text
            AccordValues(tkbarK, txtBxK, False)
            acceleration.Width = (k * Xarrow.Width) / (10 * m)
            acceleration.Left = Mass.Left + 45 - acceleration.Width
            lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
            Velocity.Left = Mass.Left + 45
            lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)
            lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & A & Environment.NewLine & "ω = √(k/m) = " & Math.Sqrt(k / m)
            lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Environment.NewLine & "a = -ω²·x = " & -(k / m) * A
            StopAnimation()

        End If
    End Sub

    Private Sub tkbarA_Scroll(sender As Object, e As EventArgs) Handles tkbarA.Scroll
        A = tkbarA.Value
        AccordValues(tkbarA, txtBxA, True)
        OscillationBorder.Left = EquilibriumLine.Left + A * 10
        Mass.Left = OscillationBorder.Left - 90
        spring.Width = Mass.Left - 188
        Aarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
        lblinitialDiplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblinitialDiplacement.Width) / 2
        Xarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
        lblDisplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblDisplacement.Width) / 2
        acceleration.Width = (k * Xarrow.Width) / (10 * m)
        acceleration.Left = Mass.Left + 45 - acceleration.Width
        lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
        Velocity.Left = Mass.Left + 45
        lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)
        lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & A & Environment.NewLine & "ω = √(k/m) = " & Math.Sqrt(k / m)
        lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Environment.NewLine & "a = -ω²·x = " & -(k / m) * A
        StopAnimation()

    End Sub

    Private Sub txtBxA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxA.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarA, txtBxA, "0.0")
        If FinishInput Then
            A = tkbarA.Value
            AccordValues(tkbarA, txtBxA, False)
            OscillationBorder.Left = EquilibriumLine.Left + A * 10
            Mass.Left = OscillationBorder.Left - 90
            spring.Width = Mass.Left - 188
            Aarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
            lblinitialDiplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblinitialDiplacement.Width) / 2
            Xarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
            lblDisplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblDisplacement.Width) / 2
            acceleration.Width = (k * Xarrow.Width) / (10 * m)
            acceleration.Left = Mass.Left + 45 - acceleration.Width
            lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
            Velocity.Left = Mass.Left + 45
            lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)
            lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = " & A & Environment.NewLine & "ω = √(k/m) = " & Math.Sqrt(k / m)
            lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Environment.NewLine & "a = -ω²·x = " & -(k / m) * A
            StopAnimation()

        End If
    End Sub



    'information box
    Private Sub ckbxDisplacemet_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxDisplacemet.CheckedChanged
        If DisplacementChecked = True Then
            DisplacementChecked = False
            Aarrow.Visible = False
            Xarrow.Visible = False
            EquilibriumLine.Visible = False
            OscillationBorder.Visible = False
            lblinitialDiplacement.Visible = False
            lblDisplacement.Visible = False
            lblckbxDisplacement.Visible = False
        ElseIf DisplacementChecked = False Then
            DisplacementChecked = True
            Aarrow.Visible = True
            Xarrow.Visible = True
            EquilibriumLine.Visible = True
            OscillationBorder.Visible = True
            lblinitialDiplacement.Visible = True
            lblDisplacement.Visible = True
            lblckbxDisplacement.Visible = True
        End If
    End Sub

    Private Sub ckbxVectors_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxVectors.CheckedChanged
        If VectorsChecked = True Then
            VectorsChecked = False
            lblAcceleration.Visible = False
            lblVelocity.Visible = False
            lblVectors.Visible = False
            acceleration.Visible = False
            Velocity.Visible = False
        ElseIf VectorsChecked = False Then
            VectorsChecked = True
            lblAcceleration.Visible = True
            lblVelocity.Visible = True
            lblVectors.Visible = True
            acceleration.Visible = True
            Velocity.Visible = True
        End If
    End Sub


    'first load and reset button
    Private Sub Simulation3_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        OriginalParameterValues(0) = 5
        OriginalParameterValues(1) = 35
        OriginalParameterValues(2) = 10
        If FirstLoad Then 'checking if the load is the first one'
            FirstLoad = False 'making the flag false'

            'setting the original values to the parameters'
            m = OriginalParameterValues(0)
            k = OriginalParameterValues(1)
            A = OriginalParameterValues(2)

            'changing the sliders position in the track bars and the content in the input boxes'
            tkbarM.Value = m
            txtBxM.Text = m
            tkbarK.Value = k
            txtBxK.Text = k
            tkbarA.Value = A
            txtBxA.Text = A

            'changing the positions and sizes of relevant items'
            OscillationBorder.Left = EquilibriumLine.Left + A * 10
            Mass.Left = OscillationBorder.Left - 90
            spring.Width = Mass.Left - 188
            Aarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
            lblinitialDiplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblinitialDiplacement.Width) / 2
            Xarrow.Width = OscillationBorder.Left - EquilibriumLine.Left
            lblDisplacement.Left = EquilibriumLine.Left + (Aarrow.Width - lblDisplacement.Width) / 2
            acceleration.Width = (k * Xarrow.Width) / (10 * m)
            acceleration.Left = Mass.Left + 45 - acceleration.Width
            lblAcceleration.Left = acceleration.Left + ((acceleration.Width - lblAcceleration.Width) / 2)
            Velocity.Left = Mass.Left + 45
            lblVelocity.Left = Velocity.Left + ((Velocity.Width - lblVelocity.Width) / 2)

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
    Dim t As Decimal
    Dim Atest As Decimal
    Dim Vtest As Decimal
    Dim Xtest As Decimal
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        t += Timer.Interval / 20
        MoveItems(t)
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Timer.Enabled = False Then
            StopAnimation()
            Timer.Enabled = True
        Else
            Timer.Enabled = False
        End If
    End Sub
End Class