Public Class Simulation1


    'Declaring the variables and arrays 
    Dim ParameterValues() As Array
    Private OriginalParameterValues(2) As Decimal
    Private StartingParameterValues(2) As Decimal
    Dim m1 As Decimal
    Dim m2 As Decimal
    Dim µ As Decimal
    Dim FirstLoad As Boolean = True



    'Buttons
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Hide()
    End Sub





    'Drawing all the constant shapes needed
    Private Sub Simulation1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'editing, animation, description, and information boxes
        e.Graphics.DrawRectangle(Pens.Black, 12, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 168, 48, 800, 500)
        e.Graphics.DrawRectangle(Pens.Black, 974, 48, 150, 500)
        e.Graphics.DrawRectangle(Pens.Black, 12, 554, 1112, 150)
        'table
        e.Graphics.DrawLine(Pens.Black, 168, 218, 768, 218) 'horizontal line
        e.Graphics.DrawLine(Pens.Black, 768, 218, 768, 548) 'vertical line
        'pulley
        e.Graphics.DrawEllipse(Pens.Black, 778, 198, 20, 20)
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
                MsgBox("Input a value between " & tkbar.Minimum & " and " & tkbar.Maximum)

            End If

        Else
            MsgBox("Input only numbers") 'output a message to inform the user that he input an invalid charachter
            e.Handled = True 'forbid any other key

        End If
        Return FinishInput
    End Function


    Sub StopAnimation()
        lorry.Left = 180
        hString.Left = 250
        hString.Width = 538
        vString.Height = 100
        hangingMass.Top = 308
        Friction.Left = lorry.Left + 35 - Friction.Width
        Reaction.Left = lorry.Left + 35
        Weight1.Left = lorry.Left + 35
        Weight2.Left = lorry.Left + 35
        t = 0
        Timer.Enabled = False
    End Sub

    Sub MoveItems(t As Decimal)
        lorry.Left = 180 + 0.005 * a * t * t
        Friction.Left = lorry.Left + 35 - Friction.Width
        Reaction.Left = lorry.Left + 35
        Weight1.Left = lorry.Left + 35
        Weight2.Left = lorry.Left + 35
        hString.Left = 250 + 0.005 * a * t * t
        hString.Width = 538 - 0.005 * a * t * t
        hangingMass.Top = 308 + 0.005 * a * t * t
        vString.Height = 100 + 0.005 * a * t * t
    End Sub



    'Editting box
    Private Sub tkbarM1_Scroll(sender As Object, e As EventArgs) Handles tkbarM1.Scroll
        m1 = tkbarM1.Value
        AccordValues(tkbarM1, txtBxM1, True)
        Weight1.Height = m1 * 9.81
        Reaction.Height = Weight1.Height
        Reaction.Top = 199 - Reaction.Height
        If µ * Reaction.Height <= Weight2.Width Then
            Friction.Width = µ * Reaction.Height
            Friction.Left = lorry.Left + 35 - Friction.Width

        Else
            Friction.Width = Weight2.Width
            Friction.Left = lorry.Left + 35 - Friction.Width

        End If
        lblForcesVectors.Text = "W1 = m1 ∙ g = " & Weight1.Height & Environment.NewLine & "W2 = m2 ∙ g = " & Weight2.Width & Environment.NewLine & "R = W1 = " & Weight1.Height & Environment.NewLine & "Friction = µ ∙ R = " & Friction.Width
        lblResultantForce.Text = "ΣF = W2 - Fr = " & Weight2.Width - Friction.Width
        lblAcceleration.Text = "a = ΣF / (m1+m2)" & Environment.NewLine & "   = " & (Weight2.Width - Friction.Width) / (m1 + m2)
        StopAnimation()
    End Sub

    Private Sub txtBxM1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxM1.KeyPress
        Dim FinishInput As Boolean = False

        ValidateItem(e, tkbarM1, txtBxM1, "0.0")
        If FinishInput Then
            m1 = txtBxM1.Text
            AccordValues(tkbarM1, txtBxM1, False)
            Weight1.Height = m1 * 9.81
            Reaction.Height = Weight1.Height
            If µ * Reaction.Height <= Weight2.Width Then
                Friction.Width = µ * Reaction.Height
                Friction.Left = lorry.Left + 35 - Friction.Width

            Else
                Friction.Width = Weight2.Width
                Friction.Left = lorry.Left + 35 - Friction.Width

            End If
            lblForcesVectors.Text = "W1 = m1 ∙ g = " & Weight1.Height & Environment.NewLine & "W2 = m2 ∙ g = " & Weight2.Width & Environment.NewLine & "R = W1 = " & Weight1.Height & Environment.NewLine & "Friction = µ ∙ R = " & Friction.Width
            lblResultantForce.Text = "ΣF = W2 - Fr = " & Weight2.Width - Friction.Width
            lblAcceleration.Text = "a = ΣF / (m1+m2)" & Environment.NewLine & "   = " & (Weight2.Width - Friction.Width) / (m1 + m2)
            StopAnimation()
        End If
    End Sub

    Private Sub tkbarM2_Scroll(sender As Object, e As EventArgs) Handles tkbarM2.Scroll
        m2 = tkbarM2.Value
        AccordValues(tkbarM2, txtBxM2, True)
        Weight2.Width = m2 * 9.81
        If µ * Reaction.Height <= Weight2.Width Then
            Friction.Width = µ * Reaction.Height
            Friction.Left = lorry.Left + 35 - Friction.Width

        Else
            Friction.Width = Weight2.Width
            Friction.Left = lorry.Left + 35 - Friction.Width

        End If
        lblForcesVectors.Text = "W1 = m1 ∙ g = " & Weight1.Height & Environment.NewLine & "W2 = m2 ∙ g = " & Weight2.Width & Environment.NewLine & "R = W1 = " & Weight1.Height & Environment.NewLine & "Friction = µ ∙ R = " & Friction.Width
        lblResultantForce.Text = "ΣF = W2 - Fr = " & Weight2.Width - Friction.Width
        lblAcceleration.Text = "a = ΣF / (m1+m2)" & Environment.NewLine & "   = " & (Weight2.Width - Friction.Width) / (m1 + m2)
        StopAnimation()
    End Sub

    Private Sub txtBxM2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxM2.KeyPress
        Dim FinishInput As Boolean = False
        FinishInput = ValidateItem(e, tkbarM2, txtBxM2, "0.0")
        If FinishInput Then
            m2 = txtBxM2.Text
            AccordValues(tkbarM2, txtBxM2, False)
            Weight2.Width = m2 * 9.81
            If µ * Reaction.Height <= Weight2.Width Then
                Friction.Width = µ * Reaction.Height
                Friction.Left = lorry.Left + 35 - Friction.Width

            Else
                Friction.Width = Weight2.Width
                Friction.Left = lorry.Left + 35 - Friction.Width

            End If
            lblForcesVectors.Text = "W1 = m1 ∙ g = " & Weight1.Height & Environment.NewLine & "W2 = m2 ∙ g = " & Weight2.Width & Environment.NewLine & "R = W1 = " & Weight1.Height & Environment.NewLine & "Friction = µ ∙ R = " & Friction.Width
            lblResultantForce.Text = "ΣF = W2 - Fr = " & Weight2.Width - Friction.Width
            lblAcceleration.Text = "a = ΣF / (m1+m2)" & Environment.NewLine & "   = " & (Weight2.Width - Friction.Width) / (m1 + m2)
            StopAnimation()
        End If
    End Sub

    Private Sub tkbarMu_Scroll(sender As Object, e As EventArgs) Handles tkbarMu.Scroll
        µ = (tkbarMu.Value) / 10
        AccordValues(tkbarMu, txtBxMu, True)
        txtBxMu.Text = µ
        If µ * Reaction.Height <= Weight2.Width Then
            Friction.Width = µ * Reaction.Height
            Friction.Left = lorry.Left + 35 - Friction.Width

        Else
            Friction.Width = Weight2.Width
            Friction.Left = lorry.Left + 35 - Friction.Width
        End If
        lblForcesVectors.Text = "W1 = m1 ∙ g = " & Weight1.Height & Environment.NewLine & "W2 = m2 ∙ g = " & Weight2.Width & Environment.NewLine & "R = W1 = " & Weight1.Height & Environment.NewLine & "Friction = µ ∙ R = " & Friction.Width
        lblResultantForce.Text = "ΣF = W2 - Fr = " & Weight2.Width - Friction.Width
        lblAcceleration.Text = "a = ΣF / (m1+m2)" & Environment.NewLine & "   = " & (Weight2.Width - Friction.Width) / (m1 + m2)
        StopAnimation()
    End Sub


    Private Sub txtBxMu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxMu.KeyPress
        Dim FinishInput As Boolean = False

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then

            'between 48 and 57 are numbers and 8 is for backspace and 46 is the dot (.)
            'allow the input event


        ElseIf (Asc(e.KeyChar) = 13) Then

            txtBxMu.Text = Format(Val(txtBxMu.Text), "0.0") 'round the input value to the accuracy input in the procedure
            'check the validity within the range of the track bar
            If (txtBxMu.Text <= 1 And txtBxMu.Text >= 0) Then
                tkbarMu.Value = txtBxMu.Text
                FinishInput = True
            Else
                MsgBox("Input a value between " & 0 & " and " & 1)

            End If

        Else
            MsgBox("Input only numbers") 'output a message to inform the user that he input an invalid charachter
            e.Handled = True 'forbid any other key

        End If
        If FinishInput Then
            µ = txtBxMu.Text
            txtBxMu.Text = txtBxMu.Text * 10
            AccordValues(tkbarMu, txtBxMu, False)
            txtBxMu.Text = txtBxMu.Text / 10
            If µ * Reaction.Height <= Weight2.Width Then
                Friction.Width = µ * Reaction.Height
                Friction.Left = lorry.Left + 35 - Friction.Width
            Else
                Friction.Width = Weight2.Width
                Friction.Left = lorry.Left + 35 - Friction.Width
            End If
            lblForcesVectors.Text = "W1 = m1 ∙ g = " & Weight1.Height & Environment.NewLine & "W2 = m2 ∙ g = " & Weight2.Width & Environment.NewLine & "R = W1 = " & Weight1.Height & Environment.NewLine & "Friction = µ ∙ R = " & Friction.Width
            lblResultantForce.Text = "ΣF = W2 - Fr = " & Weight2.Width - Friction.Width
            lblAcceleration.Text = "a = ΣF / (m1+m2)" & Environment.NewLine & "   = " & (Weight2.Width - Friction.Width) / (m1 + m2)
            StopAnimation()

        End If
    End Sub






    'Information box
    Dim ForcesVectorsChecked As Boolean = False
    Private Sub ckbxForcesVectors_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxForcesVectors.CheckedChanged
        If ForcesVectorsChecked = False Then
            ForcesVectorsChecked = True
            Weight1.Visible = True
            Weight2.Visible = True
            Reaction.Visible = True
            Friction.Visible = True
            lblForcesVectors.Visible = True
        ElseIf ForcesVectorsChecked = True Then '
            ForcesVectorsChecked = False
            Weight1.Visible = False
            Weight2.Visible = False
            Reaction.Visible = False
            Friction.Visible = False
            lblForcesVectors.Visible = False
        End If
    End Sub

    Dim ResultantForceChecked As Boolean = False
    Private Sub ckbxResultantForce_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxResultantForce.CheckedChanged
        If ResultantForceChecked = False Then
            ResultantForceChecked = True
            lblResultantForce.Visible = True
        ElseIf ResultantForceChecked = True Then
            ResultantForceChecked = False
            lblResultantForce.Visible = False
        End If
    End Sub

    Dim AccelerationChecked As Boolean = False
    Private Sub ckbxAcceleration_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxAcceleration.CheckedChanged
        If AccelerationChecked = False Then
            AccelerationChecked = True
            lblAcceleration.Visible = True
        ElseIf AccelerationChecked = True Then
            AccelerationChecked = False
            lblAcceleration.Visible = False
        End If

    End Sub




    'first load and reset buttons
    Private Sub Simulation1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        OriginalParameterValues(0) = 5
        OriginalParameterValues(1) = 7
        OriginalParameterValues(2) = 0.5
        If FirstLoad Then
            FirstLoad = False
            m1 = OriginalParameterValues(0)
            m2 = OriginalParameterValues(1)
            µ = OriginalParameterValues(2)
            tkbarM1.Value = m1
            txtBxM1.Text = m1
            tkbarM2.Value = m2
            txtBxM2.Text = m2
            tkbarMu.Value = µ * 10
            txtBxMu.Text = µ
            Weight1.Height = m1 * 9.81
            Weight2.Width = m2 * 9.81
            Reaction.Height = Weight1.Height
            Reaction.Top = 199 - Reaction.Height
            ckbxAcceleration.Checked = False
            ckbxForcesVectors.Checked = False
            ckbxResultantForce.Checked = False

            If µ * Reaction.Height <= Weight2.Width Then
                Friction.Width = µ * Reaction.Height
                Friction.Left = lorry.Left + 35 - Friction.Width
            Else
                Friction.Width = Weight2.Width
                Friction.Left = lorry.Left + 35 - Friction.Width
            End If
        End If
        StopAnimation()
    End Sub



    'Start button
    Dim t As Decimal
    Dim a As Decimal
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StopAnimation()
        Timer.Enabled = True
        a = (Weight2.Width - Friction.Width) / (m1 + m2)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        t += Timer.Interval
        MoveItems(t)
        If lorry.Left >= 698 Then
            Timer.Enabled = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        StopAnimation()
        FirstLoad = True
        Me.Visible = False
        Me.Visible = True

    End Sub
End Class