<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Simulation2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulation2))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTheta = New System.Windows.Forms.Label()
        Me.txtBxTheta = New System.Windows.Forms.TextBox()
        Me.tkbarTheta = New System.Windows.Forms.TrackBar()
        Me.txtBxU = New System.Windows.Forms.TextBox()
        Me.tkbarU = New System.Windows.Forms.TrackBar()
        Me.lblU = New System.Windows.Forms.Label()
        Me.txtBxM = New System.Windows.Forms.TextBox()
        Me.lblM = New System.Windows.Forms.Label()
        Me.tkbarM = New System.Windows.Forms.TrackBar()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Projectile = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.InitialVelocity = New System.Windows.Forms.PictureBox()
        Me.horizontal = New System.Windows.Forms.PictureBox()
        Me.Weight = New System.Windows.Forms.PictureBox()
        Me.ckbxVelocity = New System.Windows.Forms.CheckBox()
        Me.lblVelocity = New System.Windows.Forms.Label()
        Me.ckbxDisplacement = New System.Windows.Forms.CheckBox()
        Me.lblDisplacement = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.tkbarTheta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbarU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbarM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Projectile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InitialVelocity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weight, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblTheta
        '
        Me.lblTheta.AutoSize = True
        Me.lblTheta.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTheta.Location = New System.Drawing.Point(27, 271)
        Me.lblTheta.Name = "lblTheta"
        Me.lblTheta.Size = New System.Drawing.Size(81, 38)
        Me.lblTheta.TabIndex = 19
        Me.lblTheta.Text = "Θ (angle of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "projection)"
        '
        'txtBxTheta
        '
        Me.txtBxTheta.Location = New System.Drawing.Point(107, 279)
        Me.txtBxTheta.Name = "txtBxTheta"
        Me.txtBxTheta.Size = New System.Drawing.Size(50, 27)
        Me.txtBxTheta.TabIndex = 18
        '
        'tkbarTheta
        '
        Me.tkbarTheta.Location = New System.Drawing.Point(20, 312)
        Me.tkbarTheta.Maximum = 90
        Me.tkbarTheta.Name = "tkbarTheta"
        Me.tkbarTheta.Size = New System.Drawing.Size(130, 56)
        Me.tkbarTheta.TabIndex = 17
        '
        'txtBxU
        '
        Me.txtBxU.Location = New System.Drawing.Point(107, 181)
        Me.txtBxU.Name = "txtBxU"
        Me.txtBxU.Size = New System.Drawing.Size(50, 27)
        Me.txtBxU.TabIndex = 16
        '
        'tkbarU
        '
        Me.tkbarU.Location = New System.Drawing.Point(20, 214)
        Me.tkbarU.Maximum = 15
        Me.tkbarU.Name = "tkbarU"
        Me.tkbarU.Size = New System.Drawing.Size(130, 56)
        Me.tkbarU.TabIndex = 15
        '
        'lblU
        '
        Me.lblU.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblU.Location = New System.Drawing.Point(28, 173)
        Me.lblU.Name = "lblU"
        Me.lblU.Size = New System.Drawing.Size(76, 38)
        Me.lblU.TabIndex = 14
        Me.lblU.Text = "u (initial velocity)"
        '
        'txtBxM
        '
        Me.txtBxM.Location = New System.Drawing.Point(107, 81)
        Me.txtBxM.Name = "txtBxM"
        Me.txtBxM.Size = New System.Drawing.Size(50, 27)
        Me.txtBxM.TabIndex = 13
        '
        'lblM
        '
        Me.lblM.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblM.Location = New System.Drawing.Point(28, 73)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(85, 37)
        Me.lblM.TabIndex = 12
        Me.lblM.Text = "m (mass)"
        '
        'tkbarM
        '
        Me.tkbarM.Location = New System.Drawing.Point(20, 114)
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
        Me.lblTitle.Location = New System.Drawing.Point(473, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(245, 38)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Projectile Motion"
        '
        'Projectile
        '
        Me.Projectile.Image = Global.Computer_Science_Project3.My.Resources.Resources.circle
        Me.Projectile.Location = New System.Drawing.Point(178, 348)
        Me.Projectile.Name = "Projectile"
        Me.Projectile.Size = New System.Drawing.Size(70, 70)
        Me.Projectile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Projectile.TabIndex = 21
        Me.Projectile.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(18, 560)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(999, 100)
        Me.lblDescription.TabIndex = 22
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'InitialVelocity
        '
        Me.InitialVelocity.Image = Global.Computer_Science_Project3.My.Resources.Resources.up_right_arrow
        Me.InitialVelocity.Location = New System.Drawing.Point(245, 324)
        Me.InitialVelocity.Name = "InitialVelocity"
        Me.InitialVelocity.Size = New System.Drawing.Size(60, 60)
        Me.InitialVelocity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InitialVelocity.TabIndex = 24
        Me.InitialVelocity.TabStop = False
        Me.InitialVelocity.Visible = False
        '
        'horizontal
        '
        Me.horizontal.Image = Global.Computer_Science_Project3.My.Resources.Resources.dotted_line
        Me.horizontal.Location = New System.Drawing.Point(248, 383)
        Me.horizontal.Name = "horizontal"
        Me.horizontal.Size = New System.Drawing.Size(200, 1)
        Me.horizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.horizontal.TabIndex = 25
        Me.horizontal.TabStop = False
        Me.horizontal.Visible = False
        '
        'Weight
        '
        Me.Weight.Image = Global.Computer_Science_Project3.My.Resources.Resources.down_arrow
        Me.Weight.Location = New System.Drawing.Point(243, 383)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(7, 172)
        Me.Weight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Weight.TabIndex = 26
        Me.Weight.TabStop = False
        Me.Weight.Visible = False
        '
        'ckbxVelocity
        '
        Me.ckbxVelocity.AutoSize = True
        Me.ckbxVelocity.Location = New System.Drawing.Point(980, 73)
        Me.ckbxVelocity.Name = "ckbxVelocity"
        Me.ckbxVelocity.Size = New System.Drawing.Size(83, 24)
        Me.ckbxVelocity.TabIndex = 27
        Me.ckbxVelocity.Text = "Velocity"
        Me.ckbxVelocity.UseVisualStyleBackColor = True
        '
        'lblVelocity
        '
        Me.lblVelocity.AutoSize = True
        Me.lblVelocity.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVelocity.Location = New System.Drawing.Point(980, 100)
        Me.lblVelocity.Name = "lblVelocity"
        Me.lblVelocity.Size = New System.Drawing.Size(107, 57)
        Me.lblVelocity.TabIndex = 28
        Me.lblVelocity.Text = "horizontal = 8.7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vertical = 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "total = 10"
        Me.lblVelocity.Visible = False
        '
        'ckbxDisplacement
        '
        Me.ckbxDisplacement.AutoSize = True
        Me.ckbxDisplacement.Location = New System.Drawing.Point(980, 173)
        Me.ckbxDisplacement.Name = "ckbxDisplacement"
        Me.ckbxDisplacement.Size = New System.Drawing.Size(122, 24)
        Me.ckbxDisplacement.TabIndex = 29
        Me.ckbxDisplacement.Text = "Displacement"
        Me.ckbxDisplacement.UseVisualStyleBackColor = True
        '
        'lblDisplacement
        '
        Me.lblDisplacement.AutoSize = True
        Me.lblDisplacement.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDisplacement.Location = New System.Drawing.Point(980, 200)
        Me.lblDisplacement.Name = "lblDisplacement"
        Me.lblDisplacement.Size = New System.Drawing.Size(96, 38)
        Me.lblDisplacement.TabIndex = 30
        Me.lblDisplacement.Text = "horizontal = 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vertical = 0"
        Me.lblDisplacement.Visible = False
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(174, 500)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(391, 42)
        Me.btnStart.TabIndex = 31
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(571, 500)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(391, 42)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Simulation2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 716)
        Me.Controls.Add(Me.InitialVelocity)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDisplacement)
        Me.Controls.Add(Me.ckbxDisplacement)
        Me.Controls.Add(Me.lblVelocity)
        Me.Controls.Add(Me.ckbxVelocity)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.horizontal)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtBxTheta)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTheta)
        Me.Controls.Add(Me.tkbarTheta)
        Me.Controls.Add(Me.txtBxU)
        Me.Controls.Add(Me.tkbarU)
        Me.Controls.Add(Me.lblU)
        Me.Controls.Add(Me.txtBxM)
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.tkbarM)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Projectile)
        Me.Name = "Simulation2"
        Me.Text = "Simulation 2"
        CType(Me.tkbarTheta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbarU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbarM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Projectile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InitialVelocity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horizontal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblTheta As Label
    Friend WithEvents txtBxTheta As TextBox
    Friend WithEvents tkbarTheta As TrackBar
    Friend WithEvents txtBxU As TextBox
    Friend WithEvents tkbarU As TrackBar
    Friend WithEvents lblU As Label
    Friend WithEvents txtBxM As TextBox
    Friend WithEvents lblM As Label
    Friend WithEvents tkbarM As TrackBar
    Friend WithEvents lblTitle As Label
    Friend WithEvents Projectile As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents InitialVelocity As PictureBox
    Friend WithEvents horizontal As PictureBox
    Friend WithEvents Weight As PictureBox
    Friend WithEvents ckbxVelocity As CheckBox
    Friend WithEvents lblVelocity As Label
    Friend WithEvents ckbxDisplacement As CheckBox
    Friend WithEvents lblDisplacement As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnReset As Button
End Class
