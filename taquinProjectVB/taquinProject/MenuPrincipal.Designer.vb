<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.labelName = New System.Windows.Forms.Label()
        Me.lecteurMp3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.panelButton = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSuiv = New System.Windows.Forms.PictureBox()
        Me.btnPause = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnPre = New System.Windows.Forms.PictureBox()
        Me.classementButton = New System.Windows.Forms.PictureBox()
        Me.deconnexion = New System.Windows.Forms.PictureBox()
        Me.stats = New System.Windows.Forms.PictureBox()
        Me.param = New System.Windows.Forms.PictureBox()
        Me.jouer = New System.Windows.Forms.PictureBox()
        Me.lblArgent = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.actualisationDemandeDefie = New System.Windows.Forms.Timer(Me.components)
        CType(Me.lecteurMp3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelButton.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSuiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.classementButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deconnexion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.param, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jouer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(102, 63)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(37, 17)
        Me.labelName.TabIndex = 10
        Me.labelName.Text = "Nom"
        '
        'lecteurMp3
        '
        Me.lecteurMp3.Enabled = True
        Me.lecteurMp3.Location = New System.Drawing.Point(65, 353)
        Me.lecteurMp3.Name = "lecteurMp3"
        Me.lecteurMp3.OcxState = CType(resources.GetObject("lecteurMp3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.lecteurMp3.Size = New System.Drawing.Size(10, 46)
        Me.lecteurMp3.TabIndex = 37
        Me.lecteurMp3.Visible = False
        '
        'panelButton
        '
        Me.panelButton.Controls.Add(Me.PictureBox2)
        Me.panelButton.Controls.Add(Me.btnSuiv)
        Me.panelButton.Controls.Add(Me.btnPause)
        Me.panelButton.Controls.Add(Me.btnPlay)
        Me.panelButton.Controls.Add(Me.btnPre)
        Me.panelButton.Controls.Add(Me.classementButton)
        Me.panelButton.Controls.Add(Me.deconnexion)
        Me.panelButton.Controls.Add(Me.stats)
        Me.panelButton.Controls.Add(Me.param)
        Me.panelButton.Controls.Add(Me.jouer)
        Me.panelButton.Location = New System.Drawing.Point(62, 133)
        Me.panelButton.Name = "panelButton"
        Me.panelButton.Size = New System.Drawing.Size(681, 258)
        Me.panelButton.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 109)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'btnSuiv
        '
        Me.btnSuiv.Image = CType(resources.GetObject("btnSuiv.Image"), System.Drawing.Image)
        Me.btnSuiv.Location = New System.Drawing.Point(438, 199)
        Me.btnSuiv.Name = "btnSuiv"
        Me.btnSuiv.Size = New System.Drawing.Size(77, 53)
        Me.btnSuiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSuiv.TabIndex = 45
        Me.btnSuiv.TabStop = False
        '
        'btnPause
        '
        Me.btnPause.Image = CType(resources.GetObject("btnPause.Image"), System.Drawing.Image)
        Me.btnPause.Location = New System.Drawing.Point(355, 199)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(77, 53)
        Me.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPause.TabIndex = 44
        Me.btnPause.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.Location = New System.Drawing.Point(272, 199)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(77, 53)
        Me.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPlay.TabIndex = 43
        Me.btnPlay.TabStop = False
        '
        'btnPre
        '
        Me.btnPre.Image = CType(resources.GetObject("btnPre.Image"), System.Drawing.Image)
        Me.btnPre.Location = New System.Drawing.Point(189, 199)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(77, 53)
        Me.btnPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPre.TabIndex = 42
        Me.btnPre.TabStop = False
        '
        'classementButton
        '
        Me.classementButton.BackColor = System.Drawing.Color.Transparent
        Me.classementButton.Image = CType(resources.GetObject("classementButton.Image"), System.Drawing.Image)
        Me.classementButton.Location = New System.Drawing.Point(244, 109)
        Me.classementButton.Name = "classementButton"
        Me.classementButton.Size = New System.Drawing.Size(204, 84)
        Me.classementButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.classementButton.TabIndex = 13
        Me.classementButton.TabStop = False
        '
        'deconnexion
        '
        Me.deconnexion.BackColor = System.Drawing.Color.Transparent
        Me.deconnexion.Image = CType(resources.GetObject("deconnexion.Image"), System.Drawing.Image)
        Me.deconnexion.Location = New System.Drawing.Point(469, 109)
        Me.deconnexion.Name = "deconnexion"
        Me.deconnexion.Size = New System.Drawing.Size(204, 84)
        Me.deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deconnexion.TabIndex = 12
        Me.deconnexion.TabStop = False
        '
        'stats
        '
        Me.stats.BackColor = System.Drawing.Color.Transparent
        Me.stats.Image = CType(resources.GetObject("stats.Image"), System.Drawing.Image)
        Me.stats.Location = New System.Drawing.Point(469, 3)
        Me.stats.Name = "stats"
        Me.stats.Size = New System.Drawing.Size(204, 84)
        Me.stats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stats.TabIndex = 5
        Me.stats.TabStop = False
        '
        'param
        '
        Me.param.BackColor = System.Drawing.Color.Transparent
        Me.param.Image = CType(resources.GetObject("param.Image"), System.Drawing.Image)
        Me.param.Location = New System.Drawing.Point(244, 3)
        Me.param.Name = "param"
        Me.param.Size = New System.Drawing.Size(204, 84)
        Me.param.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.param.TabIndex = 4
        Me.param.TabStop = False
        '
        'jouer
        '
        Me.jouer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.jouer.BackColor = System.Drawing.Color.Transparent
        Me.jouer.Image = CType(resources.GetObject("jouer.Image"), System.Drawing.Image)
        Me.jouer.Location = New System.Drawing.Point(18, 3)
        Me.jouer.Name = "jouer"
        Me.jouer.Size = New System.Drawing.Size(204, 84)
        Me.jouer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.jouer.TabIndex = 3
        Me.jouer.TabStop = False
        '
        'lblArgent
        '
        Me.lblArgent.AutoSize = True
        Me.lblArgent.Location = New System.Drawing.Point(102, 96)
        Me.lblArgent.Name = "lblArgent"
        Me.lblArgent.Size = New System.Drawing.Size(50, 17)
        Me.lblArgent.TabIndex = 39
        Me.lblArgent.Text = "Argent"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(57, 54)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(753, 48)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 360)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, 391)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(803, 61)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-15, 48)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 404)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'actualisationDemandeDefie
        '
        Me.actualisationDemandeDefie.Enabled = True
        Me.actualisationDemandeDefie.Interval = 2000
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblArgent)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lecteurMp3)
        Me.Controls.Add(Me.panelButton)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(818, 476)
        Me.MinimumSize = New System.Drawing.Size(818, 476)
        Me.Name = "MenuPrincipal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MenuPrincipal"
        CType(Me.lecteurMp3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelButton.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSuiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.classementButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deconnexion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.param, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jouer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents labelName As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lecteurMp3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents jouer As PictureBox
    Friend WithEvents param As PictureBox
    Friend WithEvents stats As PictureBox
    Friend WithEvents deconnexion As PictureBox
    Friend WithEvents classementButton As PictureBox
    Friend WithEvents panelButton As Panel
    Friend WithEvents btnSuiv As PictureBox
    Friend WithEvents btnPause As PictureBox
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents btnPre As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblArgent As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents actualisationDemandeDefie As Timer
End Class
