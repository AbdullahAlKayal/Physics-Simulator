Public Class Simulation2

    'Declaring the variables and arrays 
    Private ParameterValues(2) As Decimal
    Private OriginalParameterValues(2) As Decimal
    Private StartingParameterValues(2) As Decimal
    Dim m As Decimal
    Dim u As Decimal
    Dim θ As Decimal
    Dim FirstLoad As Boolean = True
    Dim VelocityChecked As Boolean = False






    'Drawing all the constant shape that are needed for the simulation 
    Private Sub Simulation1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'editing, animation, description, and information boxes
        e.Graphics.DrawRectangle(Pens.Black, 12, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 168, 48, 800, 500)
        e.Graphics.DrawRectangle(Pens.Black, 974, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 12, 554, 1112, 150)
        'ground
        e.Graphics.DrawLine(Pens.Black, 168, 418, 968, 418)
    End Sub



    'buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Hide()
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
        Projectile.Left = 178
        Projectile.Top = 348
        InitialVelocity.Left = Projectile.Left + 70
        InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        If tkbarTheta.Value = 0 Then
            InitialVelocity.Image = My.Resources.right_arrow
            InitialVelocity.Width = u * 10
            InitialVelocity.Height = 7
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        ElseIf tkbarTheta.Value = 90 Then
            InitialVelocity.Image = My.Resources.up_arrow
            InitialVelocity.Height = u * 10
            InitialVelocity.Width = 7
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        Else
            InitialVelocity.Image = My.Resources.up_right_arrow
            InitialVelocity.Width = u * 10 * Math.Cos(θ)
            InitialVelocity.Height = u * 10 * Math.Sin(θ)
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        End If
        Weight.Left = Projectile.Left + 70
        Weight.Top = Projectile.Top + 35
        horizontal.Left = Projectile.Left + 70
        horizontal.Top = Projectile.Top + 35
        t = 0
        Timer.Enabled = False
    End Sub


    Sub MoveItems(t As Decimal)
        'vertically
        Projectile.Top = 348 - u * 100 * Math.Sin(θ) * t + 9.81 * t * t * 5 * 10
        test = u * 10 * Math.Sin(θ) - 98.1 * t
        If test > 0 Then
            InitialVelocity.Height = test
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        ElseIf test < 0 Then
            If Projectile.Left = 178 Then
                InitialVelocity.Image = My.Resources.down_arrow
            Else
                InitialVelocity.Image = My.Resources.down_right_arrow
            End If
            InitialVelocity.Height = -test
            InitialVelocity.Top = Projectile.Top + 35
        End If
        Weight.Top = Projectile.Top + 35
        horizontal.Top = Projectile.Top + 35
        lblVelocity.Text = "horizontal = " & Format(u * Math.Cos(θ), "0.0") & Environment.NewLine & "vertical = " & Format(u * Math.Sin(θ) - 9.81 * t, "0.0") & Environment.NewLine & "total = " & Format(Math.Sqrt((u * Math.Sin(θ) - 9.81 * t) * (u * Math.Sin(θ) - 9.81 * t) + (u * Math.Cos(θ)) * (u * Math.Cos(θ))), "0.0")
        lblDisplacement.Text = "horizontally = " & Format(u * Math.Cos(θ) * t, "0.0") & Environment.NewLine & "vertically = " & Format(u * Math.Sin(θ) * t - 9.81 * t * t * 0.5, "0.0")


        'horizontally
        Projectile.Left = 178 + u * 100 * Math.Cos(θ) * t
        InitialVelocity.Left = Projectile.Left + 70
        Weight.Left = InitialVelocity.Left - 4
        horizontal.Left = InitialVelocity.Left
    End Sub


    'Edditing box
    Private Sub tkbarM_Scroll(sender As Object, e As EventArgs) Handles tkbarM.Scroll
        m = tkbarM.Value
        AccordValues(tkbarM, txtBxM, True)
        Weight.Height = m * 9.81
        StopAnimation()
    End Sub

    Private Sub txtBxM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxM.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarM, txtBxM, "0.0")
        If FinishInput Then
            m = txtBxM.Text
            AccordValues(tkbarM, txtBxM, False)
            Weight.Height = m * 9.81
            StopAnimation()
        End If
    End Sub

    Private Sub tkbarU_Scroll(sender As Object, e As EventArgs) Handles tkbarU.Scroll
        u = tkbarU.Value
        AccordValues(tkbarU, txtBxU, True)
        If tkbarTheta.Value = 0 Then
            InitialVelocity.Image = My.Resources.right_arrow
            InitialVelocity.Width = u * 10
            InitialVelocity.Height = 7
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        ElseIf tkbarTheta.Value = 90 Then
            InitialVelocity.Image = My.Resources.up_arrow
            InitialVelocity.Height = u * 10
            InitialVelocity.Width = 7
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        Else
            InitialVelocity.Image = My.Resources.up_right_arrow
            InitialVelocity.Width = u * 10 * Math.Cos(θ)
            InitialVelocity.Height = u * 10 * Math.Sin(θ)
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        End If
        lblVelocity.Text = "horizontal = " & u * Math.Cos(θ) & Environment.NewLine & "vertical = " & u * Math.Sin(θ) & Environment.NewLine & "total = " & u
        StopAnimation()
    End Sub

    Private Sub txtBxU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxU.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarU, txtBxU, "0.0")
        If FinishInput Then
            u = txtBxU.Text
            AccordValues(tkbarU, txtBxU, False)
            If tkbarTheta.Value = 0 Then
                InitialVelocity.Image = My.Resources.right_arrow
                InitialVelocity.Width = u * 10
                InitialVelocity.Height = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            ElseIf tkbarTheta.Value = 90 Then
                InitialVelocity.Image = My.Resources.up_arrow
                InitialVelocity.Height = u * 10
                InitialVelocity.Width = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            Else
                InitialVelocity.Image = My.Resources.up_right_arrow
                InitialVelocity.Width = u * 10 * Math.Cos(θ)
                InitialVelocity.Height = u * 10 * Math.Sin(θ)
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            End If
            lblVelocity.Text = "horizontal = " & u * Math.Cos(θ) & Environment.NewLine & "vertical = " & u * Math.Sin(θ) & Environment.NewLine & "total = " & u
            StopAnimation()
        End If
    End Sub

    Private Sub tkbarTheta_Scroll(sender As Object, e As EventArgs) Handles tkbarTheta.Scroll
        θ = (tkbarTheta.Value / 180) * Math.PI
        AccordValues(tkbarTheta, txtBxTheta, True)
        If tkbarTheta.Value = 0 Then
            InitialVelocity.Image = My.Resources.right_arrow
            InitialVelocity.Width = u * 10
            InitialVelocity.Height = 7
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        ElseIf tkbarTheta.Value = 90 Then
            InitialVelocity.Image = My.Resources.up_arrow
            InitialVelocity.Height = u * 10
            InitialVelocity.Width = 7
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        Else
            InitialVelocity.Image = My.Resources.up_right_arrow
            InitialVelocity.Width = u * 10 * Math.Cos(θ)
            InitialVelocity.Height = u * 10 * Math.Sin(θ)
            InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
        End If
        lblVelocity.Text = "horizontal = " & u * Math.Cos(θ) & Environment.NewLine & "vertical = " & u * Math.Sin(θ) & Environment.NewLine & "total = " & u
        StopAnimation()
    End Sub

    Private Sub txtBxTheta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxTheta.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarTheta, txtBxTheta, "0.0")
        If FinishInput Then
            θ = (txtBxTheta.Text / 180) * Math.PI
            AccordValues(tkbarTheta, txtBxTheta, False)
            If tkbarTheta.Value = 0 Then
                InitialVelocity.Image = My.Resources.right_arrow
                InitialVelocity.Width = u * 10
                InitialVelocity.Height = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            ElseIf tkbarTheta.Value = 90 Then
                InitialVelocity.Image = My.Resources.up_arrow
                InitialVelocity.Height = u * 10
                InitialVelocity.Width = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            Else
                InitialVelocity.Image = My.Resources.up_right_arrow
                InitialVelocity.Width = u * 10 * Math.Cos(θ)
                InitialVelocity.Height = u * 10 * Math.Sin(θ)
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            End If
            lblVelocity.Text = "horizontal = " & u * Math.Cos(θ) & Environment.NewLine & "vertical = " & u * Math.Sin(θ) & Environment.NewLine & "total = " & u
            StopAnimation()

        End If
    End Sub



    'information box
    Dim AccelerationChecked As Boolean = False
    Private Sub ckbxVelocity_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxVelocity.CheckedChanged
        If VelocityChecked = True Then
            VelocityChecked = False
            InitialVelocity.Visible = False
            horizontal.Visible = False
            Weight.Visible = False
            lblVelocity.Visible = False
        ElseIf VelocityChecked = False Then
            VelocityChecked = True
            InitialVelocity.Visible = True
            horizontal.Visible = True
            Weight.Visible = True
            lblVelocity.Visible = True
        End If
    End Sub

    Dim DisplacementChecked As Boolean = False
    Private Sub ckbxDisplacement_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxDisplacement.CheckedChanged
        If DisplacementChecked = True Then
            DisplacementChecked = False
            lblDisplacement.Visible = False
        ElseIf DisplacementChecked = False Then
            DisplacementChecked = True
            lblDisplacement.Visible = True

        End If
    End Sub


    'first load and reset button
    Private Sub Simulation2_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        OriginalParameterValues(0) = 7
        OriginalParameterValues(1) = 10
        OriginalParameterValues(2) = 30
        If FirstLoad Then 'checking if the load is the first one'
            FirstLoad = False 'making the flag false'

            'setting the original values to the parameters'
            m = OriginalParameterValues(0)
            u = OriginalParameterValues(1)
            θ = (OriginalParameterValues(2) / 180) * Math.PI

            'changing the sliders position in the track bars and the content in the input boxes'
            tkbarM.Value = m
            txtBxM.Text = m
            tkbarU.Value = u
            txtBxU.Text = u
            tkbarTheta.Value = OriginalParameterValues(2)
            txtBxTheta.Text = OriginalParameterValues(2)

            'changing the positions and sizes of relevant items'
            Weight.Height = m * 9.81
            If tkbarTheta.Value = 0 Then
                InitialVelocity.Image = My.Resources.right_arrow
                InitialVelocity.Width = u * 10
                InitialVelocity.Height = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
                InitialVelocity.Image = My.Resources.right_arrow
                InitialVelocity.Width = u * 10
                InitialVelocity.Height = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            ElseIf tkbarTheta.Value = 90 Then
                InitialVelocity.Image = My.Resources.up_arrow
                InitialVelocity.Height = u * 10
                InitialVelocity.Width = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
                InitialVelocity.Image = My.Resources.up_arrow
                InitialVelocity.Height = u * 10
                InitialVelocity.Width = 7
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            Else
                InitialVelocity.Image = My.Resources.up_right_arrow
                InitialVelocity.Width = u * 10 * Math.Cos(θ)
                InitialVelocity.Height = u * 10 * Math.Sin(θ)
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
                InitialVelocity.Image = My.Resources.up_right_arrow
                InitialVelocity.Width = u * 10 * Math.Cos(θ)
                InitialVelocity.Height = u * 10 * Math.Sin(θ)
                InitialVelocity.Top = Projectile.Top + 35 - InitialVelocity.Height
            End If
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
    Dim t As Decimal = 0
    Dim test As Integer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        t = t + (Timer.Interval / 100)

        MoveItems(t)

        If u * 10 * Math.Sin(θ) * t - 10 * 9.81 * t * t * 0.5 <= 0 Then
            Timer.Enabled = False
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StopAnimation()
        Timer.Enabled = True
    End Sub

End Class