<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Simulation3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulation3))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.txtBxA = New System.Windows.Forms.TextBox()
        Me.tkbarA = New System.Windows.Forms.TrackBar()
        Me.txtBxK = New System.Windows.Forms.TextBox()
        Me.tkbarK = New System.Windows.Forms.TrackBar()
        Me.lblK = New System.Windows.Forms.Label()
        Me.txtBxM = New System.Windows.Forms.TextBox()
        Me.lblM = New System.Windows.Forms.Label()
        Me.tkbarM = New System.Windows.Forms.TrackBar()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.spring = New System.Windows.Forms.PictureBox()
        Me.Mass = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.EquilibriumLine = New System.Windows.Forms.PictureBox()
        Me.OscillationBorder = New System.Windows.Forms.PictureBox()
        Me.Xarrow = New System.Windows.Forms.PictureBox()
        Me.lblinitialDiplacement = New System.Windows.Forms.Label()
        Me.lblDisplacement = New System.Windows.Forms.Label()
        Me.Aarrow = New System.Windows.Forms.PictureBox()
        Me.acceleration = New System.Windows.Forms.PictureBox()
        Me.Velocity = New System.Windows.Forms.PictureBox()
        Me.lblAcceleration = New System.Windows.Forms.Label()
        Me.lblVelocity = New System.Windows.Forms.Label()
        Me.ckbxDisplacemet = New System.Windows.Forms.CheckBox()
        Me.lblckbxDisplacement = New System.Windows.Forms.Label()
        Me.ckbxVectors = New System.Windows.Forms.CheckBox()
        Me.lblVectors = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tkbarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbarK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbarM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquilibriumLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OscillationBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xarrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aarrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acceleration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Velocity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "<Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblA.Location = New System.Drawing.Point(19, 272)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(93, 38)
        Me.lblA.TabIndex = 19
        Me.lblA.Text = "A (maximum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "displacement)"
        '
        'txtBxA
        '
        Me.txtBxA.Location = New System.Drawing.Point(107, 280)
        Me.txtBxA.Name = "txtBxA"
        Me.txtBxA.Size = New System.Drawing.Size(50, 27)
        Me.txtBxA.TabIndex = 18
        '
        'tkbarA
        '
        Me.tkbarA.Location = New System.Drawing.Point(20, 313)
        Me.tkbarA.Maximum = 20
        Me.tkbarA.Name = "tkbarA"
        Me.tkbarA.Size = New System.Drawing.Size(130, 56)
        Me.tkbarA.TabIndex = 17
        '
        'txtBxK
        '
        Me.txtBxK.Location = New System.Drawing.Point(107, 182)
        Me.txtBxK.Name = "txtBxK"
        Me.txtBxK.Size = New System.Drawing.Size(50, 27)
        Me.txtBxK.TabIndex = 16
        '
        'tkbarK
        '
        Me.tkbarK.Location = New System.Drawing.Point(20, 215)
        Me.tkbarK.Maximum = 60
        Me.tkbarK.Minimum = 10
        Me.tkbarK.Name = "tkbarK"
        Me.tkbarK.Size = New System.Drawing.Size(130, 56)
        Me.tkbarK.TabIndex = 15
        Me.tkbarK.Value = 10
        '
        'lblK
        '
        Me.lblK.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblK.Location = New System.Drawing.Point(28, 174)
        Me.lblK.Name = "lblK"
        Me.lblK.Size = New System.Drawing.Size(76, 38)
        Me.lblK.TabIndex = 14
        Me.lblK.Text = "k (spring constant)"
        '
        'txtBxM
        '
        Me.txtBxM.Location = New System.Drawing.Point(107, 82)
        Me.txtBxM.Name = "txtBxM"
        Me.txtBxM.Size = New System.Drawing.Size(50, 27)
        Me.txtBxM.TabIndex = 13
        '
        'lblM
        '
        Me.lblM.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblM.Location = New System.Drawing.Point(28, 74)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(85, 37)
        Me.lblM.TabIndex = 12
        Me.lblM.Text = "m (object mass)"
        '
        'tkbarM
        '
        Me.tkbarM.Location = New System.Drawing.Point(20, 115)
        Me.tkbarM.Minimum = 1
        Me.tkbarM.Name = "tkbarM"
        Me.tkbarM.Size = New System.Drawing.Size(130, 56)
        Me.tkbarM.TabIndex = 11
        Me.tkbarM.Value = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(321, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(457, 38)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Simple Harmonic Motion - spring"
        '
        'spring
        '
        Me.spring.Image = Global.Computer_Science_Project3.My.Resources.Resources.spring
        Me.spring.Location = New System.Drawing.Point(189, 338)
        Me.spring.Name = "spring"
        Me.spring.Size = New System.Drawing.Size(476, 70)
        Me.spring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spring.TabIndex = 21
        Me.spring.TabStop = False
        '
        'Mass
        '
        Me.Mass.Image = Global.Computer_Science_Project3.My.Resources.Resources.square
        Me.Mass.Location = New System.Drawing.Point(660, 328)
        Me.Mass.Name = "Mass"
        Me.Mass.Size = New System.Drawing.Size(90, 90)
        Me.Mass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mass.TabIndex = 22
        Me.Mass.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(18, 560)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(1034, 80)
        Me.lblDescription.TabIndex = 23
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'EquilibriumLine
        '
        Me.EquilibriumLine.Image = Global.Computer_Science_Project3.My.Resources.Resources.dotted_vertical_line1
        Me.EquilibriumLine.Location = New System.Drawing.Point(602, 115)
        Me.EquilibriumLine.Name = "EquilibriumLine"
        Me.EquilibriumLine.Size = New System.Drawing.Size(1, 374)
        Me.EquilibriumLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.EquilibriumLine.TabIndex = 24
        Me.EquilibriumLine.TabStop = False
        Me.EquilibriumLine.Visible = False
        '
        'OscillationBorder
        '
        Me.OscillationBorder.Image = Global.Computer_Science_Project3.My.Resources.Resources.dotted_vertical_line1
        Me.OscillationBorder.Location = New System.Drawing.Point(749, 115)
        Me.OscillationBorder.Name = "OscillationBorder"
        Me.OscillationBorder.Size = New System.Drawing.Size(1, 374)
        Me.OscillationBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.OscillationBorder.TabIndex = 25
        Me.OscillationBorder.TabStop = False
        Me.OscillationBorder.Visible = False
        '
        'Xarrow
        '
        Me.Xarrow.Image = Global.Computer_Science_Project3.My.Resources.Resources.horizontal_double_arrow
        Me.Xarrow.Location = New System.Drawing.Point(602, 215)
        Me.Xarrow.Name = "Xarrow"
        Me.Xarrow.Size = New System.Drawing.Size(148, 14)
        Me.Xarrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Xarrow.TabIndex = 27
        Me.Xarrow.TabStop = False
        Me.Xarrow.Visible = False
        '
        'lblinitialDiplacement
        '
        Me.lblinitialDiplacement.AutoSize = True
        Me.lblinitialDiplacement.ForeColor = System.Drawing.Color.DarkRed
        Me.lblinitialDiplacement.Location = New System.Drawing.Point(602, 136)
        Me.lblinitialDiplacement.Name = "lblinitialDiplacement"
        Me.lblinitialDiplacement.Size = New System.Drawing.Size(165, 20)
        Me.lblinitialDiplacement.TabIndex = 28
        Me.lblinitialDiplacement.Text = "Initial Displacement (A)"
        Me.lblinitialDiplacement.Visible = False
        '
        'lblDisplacement
        '
        Me.lblDisplacement.AutoSize = True
        Me.lblDisplacement.ForeColor = System.Drawing.Color.DarkRed
        Me.lblDisplacement.Location = New System.Drawing.Point(609, 192)
        Me.lblDisplacement.Name = "lblDisplacement"
        Me.lblDisplacement.Size = New System.Drawing.Size(121, 20)
        Me.lblDisplacement.TabIndex = 29
        Me.lblDisplacement.Text = "Displacement (x)"
        Me.lblDisplacement.Visible = False
        '
        'Aarrow
        '
        Me.Aarrow.Image = Global.Computer_Science_Project3.My.Resources.Resources.horizontal_double_arrow
        Me.Aarrow.Location = New System.Drawing.Point(602, 159)
        Me.Aarrow.Name = "Aarrow"
        Me.Aarrow.Size = New System.Drawing.Size(148, 14)
        Me.Aarrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Aarrow.TabIndex = 30
        Me.Aarrow.TabStop = False
        Me.Aarrow.Visible = False
        '
        'acceleration
        '
        Me.acceleration.Image = Global.Computer_Science_Project3.My.Resources.Resources.left_arrow
        Me.acceleration.Location = New System.Drawing.Point(417, 371)
        Me.acceleration.Name = "acceleration"
        Me.acceleration.Size = New System.Drawing.Size(288, 7)
        Me.acceleration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.acceleration.TabIndex = 31
        Me.acceleration.TabStop = False
        Me.acceleration.Visible = False
        '
        'Velocity
        '
        Me.Velocity.Image = Global.Computer_Science_Project3.My.Resources.Resources.right_arrow
        Me.Velocity.Location = New System.Drawing.Point(711, 371)
        Me.Velocity.Name = "Velocity"
        Me.Velocity.Size = New System.Drawing.Size(0, 7)
        Me.Velocity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Velocity.TabIndex = 32
        Me.Velocity.TabStop = False
        Me.Velocity.Visible = False
        '
        'lblAcceleration
        '
        Me.lblAcceleration.AutoSize = True
        Me.lblAcceleration.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAcceleration.Location = New System.Drawing.Point(565, 348)
        Me.lblAcceleration.Name = "lblAcceleration"
        Me.lblAcceleration.Size = New System.Drawing.Size(17, 20)
        Me.lblAcceleration.TabIndex = 33
        Me.lblAcceleration.Text = "a"
        Me.lblAcceleration.Visible = False
        '
        'lblVelocity
        '
        Me.lblVelocity.AutoSize = True
        Me.lblVelocity.ForeColor = System.Drawing.Color.DarkRed
        Me.lblVelocity.Location = New System.Drawing.Point(711, 348)
        Me.lblVelocity.Name = "lblVelocity"
        Me.lblVelocity.Size = New System.Drawing.Size(16, 20)
        Me.lblVelocity.TabIndex = 34
        Me.lblVelocity.Text = "v"
        Me.lblVelocity.Visible = False
        '
        'ckbxDisplacemet
        '
        Me.ckbxDisplacemet.AutoSize = True
        Me.ckbxDisplacemet.Location = New System.Drawing.Point(980, 74)
        Me.ckbxDisplacemet.Name = "ckbxDisplacemet"
        Me.ckbxDisplacemet.Size = New System.Drawing.Size(122, 24)
        Me.ckbxDisplacemet.TabIndex = 35
        Me.ckbxDisplacemet.Text = "Displacement"
        Me.ckbxDisplacemet.UseVisualStyleBackColor = True
        '
        'lblckbxDisplacement
        '
        Me.lblckbxDisplacement.AutoSize = True
        Me.lblckbxDisplacement.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblckbxDisplacement.Location = New System.Drawing.Point(980, 101)
        Me.lblckbxDisplacement.Name = "lblckbxDisplacement"
        Me.lblckbxDisplacement.Size = New System.Drawing.Size(131, 38)
        Me.lblckbxDisplacement.TabIndex = 36
        Me.lblckbxDisplacement.Text = "x = A ∙ cos(ωt) = 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ω = √(k/m) = 2.6"
        Me.lblckbxDisplacement.Visible = False
        '
        'ckbxVectors
        '
        Me.ckbxVectors.AutoSize = True
        Me.ckbxVectors.Location = New System.Drawing.Point(980, 149)
        Me.ckbxVectors.Name = "ckbxVectors"
        Me.ckbxVectors.Size = New System.Drawing.Size(79, 24)
        Me.ckbxVectors.TabIndex = 37
        Me.ckbxVectors.Text = "Vectors"
        Me.ckbxVectors.UseVisualStyleBackColor = True
        '
        'lblVectors
        '
        Me.lblVectors.AutoSize = True
        Me.lblVectors.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVectors.Location = New System.Drawing.Point(980, 176)
        Me.lblVectors.Name = "lblVectors"
        Me.lblVectors.Size = New System.Drawing.Size(132, 38)
        Me.lblVectors.TabIndex = 38
        Me.lblVectors.Text = "v = ±ω·√(A²-x²) = 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a = -ω²·x = 70"
        Me.lblVectors.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(571, 500)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(391, 42)
        Me.btnReset.TabIndex = 39
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(174, 500)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(391, 42)
        Me.btnStart.TabIndex = 40
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'Simulation3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 716)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblVectors)
        Me.Controls.Add(Me.ckbxVectors)
        Me.Controls.Add(Me.lblckbxDisplacement)
        Me.Controls.Add(Me.ckbxDisplacemet)
        Me.Controls.Add(Me.lblVelocity)
        Me.Controls.Add(Me.lblAcceleration)
        Me.Controls.Add(Me.Velocity)
        Me.Controls.Add(Me.acceleration)
        Me.Controls.Add(Me.Aarrow)
        Me.Controls.Add(Me.lblDisplacement)
        Me.Controls.Add(Me.Xarrow)
        Me.Controls.Add(Me.OscillationBorder)
        Me.Controls.Add(Me.EquilibriumLine)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Mass)
        Me.Controls.Add(Me.spring)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtBxA)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.tkbarA)
        Me.Controls.Add(Me.txtBxK)
        Me.Controls.Add(Me.tkbarK)
        Me.Controls.Add(Me.lblK)
        Me.Controls.Add(Me.txtBxM)
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.tkbarM)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblinitialDiplacement)
        Me.Name = "Simulation3"
        Me.Text = "Simulation 3"
        CType(Me.tkbarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbarK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbarM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquilibriumLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OscillationBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xarrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aarrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acceleration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Velocity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblA As Label
    Friend WithEvents txtBxA As TextBox
    Friend WithEvents tkbarA As TrackBar
    Friend WithEvents txtBxK As TextBox
    Friend WithEvents tkbarK As TrackBar
    Friend WithEvents lblK As Label
    Friend WithEvents txtBxM As TextBox
    Friend WithEvents lblM As Label
    Friend WithEvents tkbarM As TrackBar
    Friend WithEvents lblTitle As Label
    Friend WithEvents spring As PictureBox
    Friend WithEvents Mass As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents EquilibriumLine As PictureBox
    Friend WithEvents OscillationBorder As PictureBox
    Friend WithEvents Xarrow As PictureBox
    Friend WithEvents lblinitialDiplacement As Label
    Friend WithEvents lblDisplacement As Label
    Friend WithEvents Aarrow As PictureBox
    Friend WithEvents acceleration As PictureBox
    Friend WithEvents Velocity As PictureBox
    Friend WithEvents lblAcceleration As Label
    Friend WithEvents lblVelocity As Label
    Friend WithEvents ckbxDisplacemet As CheckBox
    Friend WithEvents lblckbxDisplacement As Label
    Friend WithEvents ckbxVectors As CheckBox
    Friend WithEvents lblVectors As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Timer As Timer
End Class
