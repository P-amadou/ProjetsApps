<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistique
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistique))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nbPartie = New System.Windows.Forms.Label()
        Me.nbWin = New System.Windows.Forms.Label()
        Me.nbLose = New System.Windows.Forms.Label()
        Me.nbQuit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.coup = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.meilleursTps = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.buttonHome = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.buttonHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre de partie jouée"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre de partie gagnée"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nombre de partie perdus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nombre d'abandon"
        '
        'nbPartie
        '
        Me.nbPartie.AutoSize = True
        Me.nbPartie.Location = New System.Drawing.Point(311, 83)
        Me.nbPartie.Name = "nbPartie"
        Me.nbPartie.Size = New System.Drawing.Size(51, 17)
        Me.nbPartie.TabIndex = 30
        Me.nbPartie.Text = "Label6"
        '
        'nbWin
        '
        Me.nbWin.AutoSize = True
        Me.nbWin.Location = New System.Drawing.Point(311, 136)
        Me.nbWin.Name = "nbWin"
        Me.nbWin.Size = New System.Drawing.Size(51, 17)
        Me.nbWin.TabIndex = 31
        Me.nbWin.Text = "Label6"
        '
        'nbLose
        '
        Me.nbLose.AutoSize = True
        Me.nbLose.Location = New System.Drawing.Point(311, 184)
        Me.nbLose.Name = "nbLose"
        Me.nbLose.Size = New System.Drawing.Size(51, 17)
        Me.nbLose.TabIndex = 32
        Me.nbLose.Text = "Label6"
        '
        'nbQuit
        '
        Me.nbQuit.AutoSize = True
        Me.nbQuit.Location = New System.Drawing.Point(311, 232)
        Me.nbQuit.Name = "nbQuit"
        Me.nbQuit.Size = New System.Drawing.Size(51, 17)
        Me.nbQuit.TabIndex = 33
        Me.nbQuit.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Temps cumulé"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Location = New System.Drawing.Point(311, 330)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(51, 17)
        Me.time.TabIndex = 34
        Me.time.Text = "Label6"
        '
        'coup
        '
        Me.coup.AutoSize = True
        Me.coup.Location = New System.Drawing.Point(311, 266)
        Me.coup.Name = "coup"
        Me.coup.Size = New System.Drawing.Size(51, 17)
        Me.coup.TabIndex = 37
        Me.coup.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Nombre coup "
        '
        'meilleursTps
        '
        Me.meilleursTps.AccessibleDescription = ""
        Me.meilleursTps.AutoSize = True
        Me.meilleursTps.Location = New System.Drawing.Point(311, 302)
        Me.meilleursTps.Name = "meilleursTps"
        Me.meilleursTps.Size = New System.Drawing.Size(51, 17)
        Me.meilleursTps.TabIndex = 39
        Me.meilleursTps.Text = "Label6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Meilleur temps"
        '
        'buttonHome
        '
        Me.buttonHome.Image = CType(resources.GetObject("buttonHome.Image"), System.Drawing.Image)
        Me.buttonHome.Location = New System.Drawing.Point(541, 330)
        Me.buttonHome.Name = "buttonHome"
        Me.buttonHome.Size = New System.Drawing.Size(205, 69)
        Me.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonHome.TabIndex = 35
        Me.buttonHome.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 42)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 365)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(752, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 365)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 23
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 405)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(803, 46)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'Statistique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.meilleursTps)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.coup)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.buttonHome)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.nbQuit)
        Me.Controls.Add(Me.nbLose)
        Me.Controls.Add(Me.nbWin)
        Me.Controls.Add(Me.nbPartie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "Statistique"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Statistique"
        CType(Me.buttonHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nbPartie As Label
    Friend WithEvents nbWin As Label
    Friend WithEvents nbLose As Label
    Friend WithEvents nbQuit As Label
    Friend WithEvents buttonHome As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents time As Label
    Friend WithEvents coup As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents meilleursTps As Label
    Friend WithEvents Label8 As Label
End Class
