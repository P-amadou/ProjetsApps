<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.timeLeft = New System.Windows.Forms.Timer(Me.components)
        Me.grille = New System.Windows.Forms.TableLayoutPanel()
        Me.labelTemps = New System.Windows.Forms.Label()
        Me.champTemps = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonAide = New System.Windows.Forms.PictureBox()
        Me.buttonQuit = New System.Windows.Forms.PictureBox()
        Me.ProgrammeTaquin = New System.Diagnostics.Process()
        Me.aideLabel = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.btnVueC = New System.Windows.Forms.Button()
        Me.patientez = New System.Windows.Forms.PictureBox()
        Me.pictureImgComplet = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grilleAdversaire = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.timerRefeshMulti = New System.Windows.Forms.Timer(Me.components)
        Me.grilleBackEnd = New System.Windows.Forms.TableLayoutPanel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.buttonAide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.patientez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureImgComplet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeLeft
        '
        Me.timeLeft.Enabled = True
        Me.timeLeft.Interval = 1000
        '
        'grille
        '
        Me.grille.BackColor = System.Drawing.Color.Transparent
        Me.grille.ColumnCount = 3
        Me.grille.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.39336!))
        Me.grille.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.60664!))
        Me.grille.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267.0!))
        Me.grille.Location = New System.Drawing.Point(102, 112)
        Me.grille.Name = "grille"
        Me.grille.RowCount = 3
        Me.grille.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.grille.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.grille.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.grille.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.grille.Size = New System.Drawing.Size(340, 352)
        Me.grille.TabIndex = 4
        '
        'labelTemps
        '
        Me.labelTemps.AutoSize = True
        Me.labelTemps.Location = New System.Drawing.Point(54, 20)
        Me.labelTemps.Name = "labelTemps"
        Me.labelTemps.Size = New System.Drawing.Size(91, 17)
        Me.labelTemps.TabIndex = 5
        Me.labelTemps.Text = "Tems restant"
        '
        'champTemps
        '
        Me.champTemps.AutoSize = True
        Me.champTemps.Location = New System.Drawing.Point(164, 20)
        Me.champTemps.Name = "champTemps"
        Me.champTemps.Size = New System.Drawing.Size(64, 17)
        Me.champTemps.TabIndex = 6
        Me.champTemps.Text = "00:00:00"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.buttonAide)
        Me.Panel1.Controls.Add(Me.buttonQuit)
        Me.Panel1.Controls.Add(Me.champTemps)
        Me.Panel1.Controls.Add(Me.labelTemps)
        Me.Panel1.Location = New System.Drawing.Point(610, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 324)
        Me.Panel1.TabIndex = 8
        '
        'buttonAide
        '
        Me.buttonAide.Image = CType(resources.GetObject("buttonAide.Image"), System.Drawing.Image)
        Me.buttonAide.Location = New System.Drawing.Point(39, 173)
        Me.buttonAide.Name = "buttonAide"
        Me.buttonAide.Size = New System.Drawing.Size(224, 84)
        Me.buttonAide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonAide.TabIndex = 10
        Me.buttonAide.TabStop = False
        '
        'buttonQuit
        '
        Me.buttonQuit.Image = CType(resources.GetObject("buttonQuit.Image"), System.Drawing.Image)
        Me.buttonQuit.Location = New System.Drawing.Point(39, 83)
        Me.buttonQuit.Name = "buttonQuit"
        Me.buttonQuit.Size = New System.Drawing.Size(224, 84)
        Me.buttonQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonQuit.TabIndex = 8
        Me.buttonQuit.TabStop = False
        '
        'ProgrammeTaquin
        '
        Me.ProgrammeTaquin.StartInfo.CreateNoWindow = True
        Me.ProgrammeTaquin.StartInfo.Domain = ""
        Me.ProgrammeTaquin.StartInfo.FileName = "C:\Users\Dabi\Documents\ISN\IUT\Projet\ProjetVBA\taquinProject\taquinProject\Reso" &
    "urces\taquinC++\Sprint5.exe"
        Me.ProgrammeTaquin.StartInfo.LoadUserProfile = False
        Me.ProgrammeTaquin.StartInfo.Password = Nothing
        Me.ProgrammeTaquin.StartInfo.RedirectStandardInput = True
        Me.ProgrammeTaquin.StartInfo.RedirectStandardOutput = True
        Me.ProgrammeTaquin.StartInfo.StandardErrorEncoding = Nothing
        Me.ProgrammeTaquin.StartInfo.StandardOutputEncoding = Nothing
        Me.ProgrammeTaquin.StartInfo.UserName = ""
        Me.ProgrammeTaquin.StartInfo.UseShellExecute = False
        Me.ProgrammeTaquin.SynchronizingObject = Me
        '
        'aideLabel
        '
        Me.aideLabel.AutoSize = True
        Me.aideLabel.Location = New System.Drawing.Point(598, 94)
        Me.aideLabel.Name = "aideLabel"
        Me.aideLabel.Size = New System.Drawing.Size(0, 17)
        Me.aideLabel.TabIndex = 11
        Me.aideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(674, 32)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(0, 17)
        Me.labelName.TabIndex = 15
        '
        'btnVueC
        '
        Me.btnVueC.Location = New System.Drawing.Point(667, 456)
        Me.btnVueC.Name = "btnVueC"
        Me.btnVueC.Size = New System.Drawing.Size(166, 29)
        Me.btnVueC.TabIndex = 17
        Me.btnVueC.Text = "Voir l'image complète"
        Me.btnVueC.UseVisualStyleBackColor = True
        '
        'patientez
        '
        Me.patientez.Enabled = False
        Me.patientez.Image = CType(resources.GetObject("patientez.Image"), System.Drawing.Image)
        Me.patientez.Location = New System.Drawing.Point(383, 226)
        Me.patientez.Name = "patientez"
        Me.patientez.Size = New System.Drawing.Size(251, 53)
        Me.patientez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.patientez.TabIndex = 11
        Me.patientez.TabStop = False
        Me.patientez.Visible = False
        '
        'pictureImgComplet
        '
        Me.pictureImgComplet.Enabled = False
        Me.pictureImgComplet.Location = New System.Drawing.Point(88, 112)
        Me.pictureImgComplet.Name = "pictureImgComplet"
        Me.pictureImgComplet.Size = New System.Drawing.Size(370, 363)
        Me.pictureImgComplet.TabIndex = 18
        Me.pictureImgComplet.TabStop = False
        Me.pictureImgComplet.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(610, 23)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(58, 53)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 16
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(48, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(453, 450)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'grilleAdversaire
        '
        Me.grilleAdversaire.BackColor = System.Drawing.Color.Transparent
        Me.grilleAdversaire.ColumnCount = 3
        Me.grilleAdversaire.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.39336!))
        Me.grilleAdversaire.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.60664!))
        Me.grilleAdversaire.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267.0!))
        Me.grilleAdversaire.Enabled = False
        Me.grilleAdversaire.Location = New System.Drawing.Point(1002, 103)
        Me.grilleAdversaire.Name = "grilleAdversaire"
        Me.grilleAdversaire.RowCount = 3
        Me.grilleAdversaire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.grilleAdversaire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.grilleAdversaire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.grilleAdversaire.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.grilleAdversaire.Size = New System.Drawing.Size(337, 352)
        Me.grilleAdversaire.TabIndex = 20
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(948, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(453, 450)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'timerRefeshMulti
        '
        '
        'grilleBackEnd
        '
        Me.grilleBackEnd.BackColor = System.Drawing.Color.Transparent
        Me.grilleBackEnd.ColumnCount = 3
        Me.grilleBackEnd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.39336!))
        Me.grilleBackEnd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.60664!))
        Me.grilleBackEnd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267.0!))
        Me.grilleBackEnd.Enabled = False
        Me.grilleBackEnd.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.grilleBackEnd.Location = New System.Drawing.Point(558, 503)
        Me.grilleBackEnd.Name = "grilleBackEnd"
        Me.grilleBackEnd.RowCount = 3
        Me.grilleBackEnd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.grilleBackEnd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.grilleBackEnd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.grilleBackEnd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.grilleBackEnd.Size = New System.Drawing.Size(387, 406)
        Me.grilleBackEnd.TabIndex = 21
        Me.grilleBackEnd.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1373, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.grilleBackEnd)
        Me.Controls.Add(Me.grilleAdversaire)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.patientez)
        Me.Controls.Add(Me.pictureImgComplet)
        Me.Controls.Add(Me.btnVueC)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.aideLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grille)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(2000, 565)
        Me.MinimumSize = New System.Drawing.Size(18, 565)
        Me.Name = "Jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Taquin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.buttonAide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonQuit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.patientez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureImgComplet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timeLeft As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grille As TableLayoutPanel
    Friend WithEvents labelTemps As Label
    Friend WithEvents champTemps As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents buttonQuit As PictureBox
    Friend WithEvents buttonAide As PictureBox
    Friend WithEvents aideLabel As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents labelName As Label
    Friend WithEvents btnVueC As Button
    Friend WithEvents pictureImgComplet As PictureBox
    Friend WithEvents ProgrammeTaquin As Process
    Friend WithEvents patientez As PictureBox
    Friend WithEvents grilleAdversaire As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents timerRefeshMulti As Timer
    Friend WithEvents grilleBackEnd As TableLayoutPanel
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
