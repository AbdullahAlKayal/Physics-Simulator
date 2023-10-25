<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Simulation1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulation1))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tkbarM1 = New System.Windows.Forms.TrackBar()
        Me.lblM1 = New System.Windows.Forms.Label()
        Me.txtBxM1 = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblM2 = New System.Windows.Forms.Label()
        Me.txtBxM2 = New System.Windows.Forms.TextBox()
        Me.tkbarM2 = New System.Windows.Forms.TrackBar()
        Me.txtBxMu = New System.Windows.Forms.TextBox()
        Me.tkbarMu = New System.Windows.Forms.TrackBar()
        Me.lblMu = New System.Windows.Forms.Label()
        Me.hString = New System.Windows.Forms.PictureBox()
        Me.vString = New System.Windows.Forms.PictureBox()
        Me.lorry = New System.Windows.Forms.PictureBox()
        Me.hangingMass = New System.Windows.Forms.PictureBox()
        Me.Weight1 = New System.Windows.Forms.PictureBox()
        Me.Reaction = New System.Windows.Forms.PictureBox()
        Me.Weight2 = New System.Windows.Forms.PictureBox()
        Me.Friction = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.ckbxForcesVectors = New System.Windows.Forms.CheckBox()
        Me.lblForcesVectors = New System.Windows.Forms.Label()
        Me.ckbxResultantForce = New System.Windows.Forms.CheckBox()
        Me.lblResultantForce = New System.Windows.Forms.Label()
        Me.ckbxAcceleration = New System.Windows.Forms.CheckBox()
        Me.lblAcceleration = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.tkbarM1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbarM2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbarMu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lorry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hangingMass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weight1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weight2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Friction, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tkbarM1
        '
        Me.tkbarM1.Location = New System.Drawing.Point(20, 115)
        Me.tkbarM1.Minimum = 1
        Me.tkbarM1.Name = "tkbarM1"
        Me.tkbarM1.Size = New System.Drawing.Size(130, 56)
        Me.tkbarM1.TabIndex = 1
        Me.tkbarM1.Value = 1
        '
        'lblM1
        '
        Me.lblM1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblM1.Location = New System.Drawing.Point(28, 74)
        Me.lblM1.Name = "lblM1"
        Me.lblM1.Size = New System.Drawing.Size(85, 37)
        Me.lblM1.TabIndex = 2
        Me.lblM1.Text = "m1 (first mass)"
        '
        'txtBxM1
        '
        Me.txtBxM1.Location = New System.Drawing.Point(107, 82)
        Me.txtBxM1.Name = "txtBxM1"
        Me.txtBxM1.Size = New System.Drawing.Size(50, 27)
        Me.txtBxM1.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(309, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(532, 38)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Representation of Newton's second law"
        '
        'lblM2
        '
        Me.lblM2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblM2.Location = New System.Drawing.Point(28, 174)
        Me.lblM2.Name = "lblM2"
        Me.lblM2.Size = New System.Drawing.Size(76, 38)
        Me.lblM2.TabIndex = 5
        Me.lblM2.Text = "m2 (second mass)"
        '
        'txtBxM2
        '
        Me.txtBxM2.Location = New System.Drawing.Point(107, 182)
        Me.txtBxM2.Name = "txtBxM2"
        Me.txtBxM2.Size = New System.Drawing.Size(50, 27)
        Me.txtBxM2.TabIndex = 7
        '
        'tkbarM2
        '
        Me.tkbarM2.Location = New System.Drawing.Point(20, 215)
        Me.tkbarM2.Minimum = 1
        Me.tkbarM2.Name = "tkbarM2"
        Me.tkbarM2.Size = New System.Drawing.Size(130, 56)
        Me.tkbarM2.TabIndex = 6
        Me.tkbarM2.Value = 1
        '
        'txtBxMu
        '
        Me.txtBxMu.Location = New System.Drawing.Point(107, 280)
        Me.txtBxMu.Name = "txtBxMu"
        Me.txtBxMu.Size = New System.Drawing.Size(50, 27)
        Me.txtBxMu.TabIndex = 9
        '
        'tkbarMu
        '
        Me.tkbarMu.Location = New System.Drawing.Point(20, 313)
        Me.tkbarMu.Name = "tkbarMu"
        Me.tkbarMu.Size = New System.Drawing.Size(130, 56)
        Me.tkbarMu.TabIndex = 8
        '
        'lblMu
        '
        Me.lblMu.AutoSize = True
        Me.lblMu.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMu.Location = New System.Drawing.Point(27, 272)
        Me.lblMu.Name = "lblMu"
        Me.lblMu.Size = New System.Drawing.Size(74, 38)
        Me.lblMu.TabIndex = 10
        Me.lblMu.Text = "μ (friction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "coefficient)"
        '
        'hString
        '
        Me.hString.Image = Global.Computer_Science_Project3.My.Resources.Resources._24676_7_horizontal_line_transparent_background
        Me.hString.Location = New System.Drawing.Point(250, 197)
        Me.hString.Name = "hString"
        Me.hString.Size = New System.Drawing.Size(538, 2)
        Me.hString.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.hString.TabIndex = 11
        Me.hString.TabStop = False
        '
        'vString
        '
        Me.vString.Image = Global.Computer_Science_Project3.My.Resources.Resources.our_technologies_miracle_black_line_vertical_11563037021rbincxxlwk
        Me.vString.Location = New System.Drawing.Point(798, 208)
        Me.vString.Name = "vString"
        Me.vString.Size = New System.Drawing.Size(1, 100)
        Me.vString.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.vString.TabIndex = 12
        Me.vString.TabStop = False
        '
        'lorry
        '
        Me.lorry.Image = Global.Computer_Science_Project3.My.Resources.Resources.lorry
        Me.lorry.Location = New System.Drawing.Point(180, 173)
        Me.lorry.Name = "lorry"
        Me.lorry.Size = New System.Drawing.Size(70, 45)
        Me.lorry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lorry.TabIndex = 13
        Me.lorry.TabStop = False
        '
        'hangingMass
        '
        Me.hangingMass.Image = Global.Computer_Science_Project3.My.Resources.Resources.hanging_mass
        Me.hangingMass.Location = New System.Drawing.Point(773, 308)
        Me.hangingMass.Name = "hangingMass"
        Me.hangingMass.Size = New System.Drawing.Size(50, 50)
        Me.hangingMass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hangingMass.TabIndex = 14
        Me.hangingMass.TabStop = False
        '
        'Weight1
        '
        Me.Weight1.Image = CType(resources.GetObject("Weight1.Image"), System.Drawing.Image)
        Me.Weight1.Location = New System.Drawing.Point(210, 197)
        Me.Weight1.Name = "Weight1"
        Me.Weight1.Size = New System.Drawing.Size(7, 172)
        Me.Weight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Weight1.TabIndex = 15
        Me.Weight1.TabStop = False
        Me.Weight1.Visible = False
        '
        'Reaction
        '
        Me.Reaction.Image = CType(resources.GetObject("Reaction.Image"), System.Drawing.Image)
        Me.Reaction.Location = New System.Drawing.Point(210, 27)
        Me.Reaction.Name = "Reaction"
        Me.Reaction.Size = New System.Drawing.Size(7, 172)
        Me.Reaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Reaction.TabIndex = 16
        Me.Reaction.TabStop = False
        Me.Reaction.Visible = False
        '
        'Weight2
        '
        Me.Weight2.Image = CType(resources.GetObject("Weight2.Image"), System.Drawing.Image)
        Me.Weight2.Location = New System.Drawing.Point(214, 195)
        Me.Weight2.Name = "Weight2"
        Me.Weight2.Size = New System.Drawing.Size(293, 7)
        Me.Weight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Weight2.TabIndex = 17
        Me.Weight2.TabStop = False
        Me.Weight2.Visible = False
        '
        'Friction
        '
        Me.Friction.Image = CType(resources.GetObject("Friction.Image"), System.Drawing.Image)
        Me.Friction.Location = New System.Drawing.Point(-72, 195)
        Me.Friction.Name = "Friction"
        Me.Friction.Size = New System.Drawing.Size(284, 7)
        Me.Friction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Friction.TabIndex = 18
        Me.Friction.TabStop = False
        Me.Friction.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(18, 560)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(1064, 100)
        Me.lblDescription.TabIndex = 19
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'ckbxForcesVectors
        '
        Me.ckbxForcesVectors.AutoSize = True
        Me.ckbxForcesVectors.Location = New System.Drawing.Point(980, 74)
        Me.ckbxForcesVectors.Name = "ckbxForcesVectors"
        Me.ckbxForcesVectors.Size = New System.Drawing.Size(125, 24)
        Me.ckbxForcesVectors.TabIndex = 20
        Me.ckbxForcesVectors.Text = "Forces Vectors"
        Me.ckbxForcesVectors.UseVisualStyleBackColor = True
        '
        'lblForcesVectors
        '
        Me.lblForcesVectors.AutoSize = True
        Me.lblForcesVectors.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblForcesVectors.Location = New System.Drawing.Point(980, 101)
        Me.lblForcesVectors.Name = "lblForcesVectors"
        Me.lblForcesVectors.Size = New System.Drawing.Size(133, 76)
        Me.lblForcesVectors.TabIndex = 21
        Me.lblForcesVectors.Text = "W1 = m1 ∙ g = 49" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W2 = m2 ∙ g = 69" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R = W1 = 49" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Friction = µ ∙ R = 24"
        Me.lblForcesVectors.Visible = False
        '
        'ckbxResultantForce
        '
        Me.ckbxResultantForce.AutoSize = True
        Me.ckbxResultantForce.Location = New System.Drawing.Point(980, 188)
        Me.ckbxResultantForce.Name = "ckbxResultantForce"
        Me.ckbxResultantForce.Size = New System.Drawing.Size(132, 24)
        Me.ckbxResultantForce.TabIndex = 22
        Me.ckbxResultantForce.Text = "Resultant Force"
        Me.ckbxResultantForce.UseVisualStyleBackColor = True
        '
        'lblResultantForce
        '
        Me.lblResultantForce.AutoSize = True
        Me.lblResultantForce.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResultantForce.Location = New System.Drawing.Point(980, 215)
        Me.lblResultantForce.Name = "lblResultantForce"
        Me.lblResultantForce.Size = New System.Drawing.Size(122, 19)
        Me.lblResultantForce.TabIndex = 23
        Me.lblResultantForce.Text = "ΣF = W2 - Fr = 44"
        Me.lblResultantForce.Visible = False
        '
        'ckbxAcceleration
        '
        Me.ckbxAcceleration.AutoSize = True
        Me.ckbxAcceleration.Location = New System.Drawing.Point(980, 247)
        Me.ckbxAcceleration.Name = "ckbxAcceleration"
        Me.ckbxAcceleration.Size = New System.Drawing.Size(114, 24)
        Me.ckbxAcceleration.TabIndex = 24
        Me.ckbxAcceleration.Text = "Acceleration"
        Me.ckbxAcceleration.UseVisualStyleBackColor = True
        '
        'lblAcceleration
        '
        Me.lblAcceleration.AutoSize = True
        Me.lblAcceleration.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAcceleration.Location = New System.Drawing.Point(980, 274)
        Me.lblAcceleration.Name = "lblAcceleration"
        Me.lblAcceleration.Size = New System.Drawing.Size(123, 38)
        Me.lblAcceleration.TabIndex = 25
        Me.lblAcceleration.Text = "a = ΣF / (m1+m2) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   = 3.7"
        Me.lblAcceleration.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(174, 500)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(391, 42)
        Me.btnStart.TabIndex = 26
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(571, 500)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(391, 42)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Simulation1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1136, 716)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblAcceleration)
        Me.Controls.Add(Me.ckbxAcceleration)
        Me.Controls.Add(Me.lblResultantForce)
        Me.Controls.Add(Me.ckbxResultantForce)
        Me.Controls.Add(Me.lblForcesVectors)
        Me.Controls.Add(Me.ckbxForcesVectors)
        Me.Controls.Add(Me.Weight1)
        Me.Controls.Add(Me.Reaction)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Friction)
        Me.Controls.Add(Me.Weight2)
        Me.Controls.Add(Me.hangingMass)
        Me.Controls.Add(Me.lorry)
        Me.Controls.Add(Me.vString)
        Me.Controls.Add(Me.hString)
        Me.Controls.Add(Me.lblMu)
        Me.Controls.Add(Me.txtBxMu)
        Me.Controls.Add(Me.tkbarMu)
        Me.Controls.Add(Me.txtBxM2)
        Me.Controls.Add(Me.tkbarM2)
        Me.Controls.Add(Me.lblM2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtBxM1)
        Me.Controls.Add(Me.lblM1)
        Me.Controls.Add(Me.tkbarM1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Simulation1"
        Me.Text = "Simulation 1"
        CType(Me.tkbarM1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbarM2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbarMu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lorry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hangingMass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weight1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weight2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Friction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents tkbarM1 As TrackBar
    Friend WithEvents lblM1 As Label
    Friend WithEvents txtBxM1 As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents firstMass As Graphics
    Friend WithEvents lblM2 As Label
    Friend WithEvents txtBxM2 As TextBox
    Friend WithEvents tkbarM2 As TrackBar
    Friend WithEvents txtBxMu As TextBox
    Friend WithEvents tkbarMu As TrackBar
    Friend WithEvents lblMu As Label
    Friend WithEvents hString As PictureBox
    Friend WithEvents vString As PictureBox
    Friend WithEvents lorry As PictureBox
    Friend WithEvents hangingMass As PictureBox
    Friend WithEvents Weight1 As PictureBox
    Friend WithEvents Reaction As PictureBox
    Friend WithEvents Weight2 As PictureBox
    Friend WithEvents Friction As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents ckbxForcesVectors As CheckBox
    Friend WithEvents lblForcesVectors As Label
    Friend WithEvents ckbxResultantForce As CheckBox
    Friend WithEvents lblResultantForce As Label
    Friend WithEvents ckbxAcceleration As CheckBox
    Friend WithEvents lblAcceleration As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents btnReset As Button
End Class
