<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Simulation4
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtBxR = New System.Windows.Forms.TextBox()
        Me.tkbarR = New System.Windows.Forms.TrackBar()
        Me.lblR = New System.Windows.Forms.Label()
        Me.txtBxF = New System.Windows.Forms.TextBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.tkbarF = New System.Windows.Forms.TrackBar()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.acceleration = New System.Windows.Forms.PictureBox()
        Me.velocity = New System.Windows.Forms.PictureBox()
        Me.ckbxVectors = New System.Windows.Forms.CheckBox()
        Me.lblVectors = New System.Windows.Forms.Label()
        Me.ckbxCircle = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tkbarR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbarF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acceleration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.velocity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(314, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(509, 38)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Circular Motion on a horizontal plane"
        '
        'txtBxR
        '
        Me.txtBxR.Location = New System.Drawing.Point(107, 182)
        Me.txtBxR.Name = "txtBxR"
        Me.txtBxR.Size = New System.Drawing.Size(50, 27)
        Me.txtBxR.TabIndex = 25
        '
        'tkbarR
        '
        Me.tkbarR.Location = New System.Drawing.Point(20, 215)
        Me.tkbarR.Maximum = 20
        Me.tkbarR.Name = "tkbarR"
        Me.tkbarR.Size = New System.Drawing.Size(130, 56)
        Me.tkbarR.TabIndex = 24
        '
        'lblR
        '
        Me.lblR.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblR.Location = New System.Drawing.Point(28, 184)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(76, 38)
        Me.lblR.TabIndex = 23
        Me.lblR.Text = "R (radius)"
        '
        'txtBxF
        '
        Me.txtBxF.Location = New System.Drawing.Point(107, 82)
        Me.txtBxF.Name = "txtBxF"
        Me.txtBxF.Size = New System.Drawing.Size(50, 27)
        Me.txtBxF.TabIndex = 22
        '
        'lblF
        '
        Me.lblF.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblF.Location = New System.Drawing.Point(27, 82)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(85, 37)
        Me.lblF.TabIndex = 21
        Me.lblF.Text = "f (frequency)"
        '
        'tkbarF
        '
        Me.tkbarF.Location = New System.Drawing.Point(20, 115)
        Me.tkbarF.Name = "tkbarF"
        Me.tkbarF.Size = New System.Drawing.Size(130, 56)
        Me.tkbarF.TabIndex = 20
        '
        'Ball
        '
        Me.Ball.Image = Global.Computer_Science_Project3.My.Resources.Resources.circle
        Me.Ball.Location = New System.Drawing.Point(283, 233)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(70, 70)
        Me.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ball.TabIndex = 26
        Me.Ball.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(18, 560)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(994, 80)
        Me.lblDescription.TabIndex = 27
        Me.lblDescription.Text = "Description:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This simulation represents the circular motion of an object attac" &
    "hed to a light string of negligible mass, rotating at a constant velocity on a h" &
    "orizontal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plane." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'acceleration
        '
        Me.acceleration.Image = Global.Computer_Science_Project3.My.Resources.Resources.right_arrow
        Me.acceleration.Location = New System.Drawing.Point(314, 264)
        Me.acceleration.Name = "acceleration"
        Me.acceleration.Size = New System.Drawing.Size(293, 7)
        Me.acceleration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.acceleration.TabIndex = 28
        Me.acceleration.TabStop = False
        Me.acceleration.Visible = False
        '
        'velocity
        '
        Me.velocity.Image = Global.Computer_Science_Project3.My.Resources.Resources.up_arrow
        Me.velocity.Location = New System.Drawing.Point(314, 99)
        Me.velocity.Name = "velocity"
        Me.velocity.Size = New System.Drawing.Size(7, 172)
        Me.velocity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.velocity.TabIndex = 29
        Me.velocity.TabStop = False
        Me.velocity.Visible = False
        '
        'ckbxVectors
        '
        Me.ckbxVectors.AutoSize = True
        Me.ckbxVectors.Location = New System.Drawing.Point(980, 82)
        Me.ckbxVectors.Name = "ckbxVectors"
        Me.ckbxVectors.Size = New System.Drawing.Size(79, 24)
        Me.ckbxVectors.TabIndex = 30
        Me.ckbxVectors.Text = "Vectors"
        Me.ckbxVectors.UseVisualStyleBackColor = True
        '
        'lblVectors
        '
        Me.lblVectors.AutoSize = True
        Me.lblVectors.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVectors.Location = New System.Drawing.Point(980, 109)
        Me.lblVectors.Name = "lblVectors"
        Me.lblVectors.Size = New System.Drawing.Size(109, 38)
        Me.lblVectors.TabIndex = 31
        Me.lblVectors.Text = "v = 2πR·f = 314" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a = v²/R = 9870" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblVectors.Visible = False
        '
        'ckbxCircle
        '
        Me.ckbxCircle.AutoSize = True
        Me.ckbxCircle.Location = New System.Drawing.Point(980, 162)
        Me.ckbxCircle.Name = "ckbxCircle"
        Me.ckbxCircle.Size = New System.Drawing.Size(108, 24)
        Me.ckbxCircle.TabIndex = 32
        Me.ckbxCircle.Text = "Show Circle"
        Me.ckbxCircle.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(571, 500)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(391, 42)
        Me.btnReset.TabIndex = 33
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(174, 500)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(391, 42)
        Me.btnStart.TabIndex = 34
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'Simulation4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 716)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.ckbxCircle)
        Me.Controls.Add(Me.lblVectors)
        Me.Controls.Add(Me.ckbxVectors)
        Me.Controls.Add(Me.tkbarR)
        Me.Controls.Add(Me.tkbarF)
        Me.Controls.Add(Me.velocity)
        Me.Controls.Add(Me.acceleration)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.txtBxR)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.txtBxF)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Simulation4"
        Me.Text = "Simulation4"
        CType(Me.tkbarR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbarF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acceleration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.velocity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtBxR As TextBox
    Friend WithEvents tkbarR As TrackBar
    Friend WithEvents lblR As Label
    Friend WithEvents txtBxF As TextBox
    Friend WithEvents lblF As Label
    Friend WithEvents tkbarF As TrackBar
    Friend WithEvents Ball As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents acceleration As PictureBox
    Friend WithEvents velocity As PictureBox
    Friend WithEvents ckbxVectors As CheckBox
    Friend WithEvents lblVectors As Label
    Friend WithEvents ckbxCircle As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Timer As Timer
End Class
