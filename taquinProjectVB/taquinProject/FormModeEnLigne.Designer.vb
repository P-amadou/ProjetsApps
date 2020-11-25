<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModeEnLigne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModeEnLigne))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.champRecherche = New System.Windows.Forms.TextBox()
        Me.rafraichissement = New System.Windows.Forms.Timer(Me.components)
        Me.listeRichesse = New System.Windows.Forms.ListBox()
        Me.labelNom = New System.Windows.Forms.Label()
        Me.labelRichesse = New System.Windows.Forms.Label()
        Me.btnDefier = New System.Windows.Forms.Button()
        Me.listeOccuper = New System.Windows.Forms.ListBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.colonne = New System.Windows.Forms.TextBox()
        Me.ligne = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.TextBox()
        Me.min = New System.Windows.Forms.TextBox()
        Me.heures = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.buttonHome = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mise = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.listeNom = New System.Windows.Forms.ListBox()
        Me.modeForm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listeMatch = New System.Windows.Forms.ListBox()
        Me.labelMatchCours = New System.Windows.Forms.Label()
        Me.buttonAnnuler = New System.Windows.Forms.PictureBox()
        Me.patientez = New System.Windows.Forms.PictureBox()
        Me.lblArgent = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.buttonHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonAnnuler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.patientez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 28)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Rechercher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Recherche :"
        '
        'champRecherche
        '
        Me.champRecherche.Location = New System.Drawing.Point(74, 174)
        Me.champRecherche.Name = "champRecherche"
        Me.champRecherche.Size = New System.Drawing.Size(163, 22)
        Me.champRecherche.TabIndex = 52
        '
        'rafraichissement
        '
        Me.rafraichissement.Enabled = True
        Me.rafraichissement.Interval = 1500
        '
        'listeRichesse
        '
        Me.listeRichesse.FormattingEnabled = True
        Me.listeRichesse.ItemHeight = 16
        Me.listeRichesse.Location = New System.Drawing.Point(482, 174)
        Me.listeRichesse.Name = "listeRichesse"
        Me.listeRichesse.Size = New System.Drawing.Size(163, 148)
        Me.listeRichesse.TabIndex = 59
        '
        'labelNom
        '
        Me.labelNom.AutoSize = True
        Me.labelNom.Location = New System.Drawing.Point(378, 154)
        Me.labelNom.Name = "labelNom"
        Me.labelNom.Size = New System.Drawing.Size(37, 17)
        Me.labelNom.TabIndex = 60
        Me.labelNom.Text = "Nom"
        '
        'labelRichesse
        '
        Me.labelRichesse.AutoSize = True
        Me.labelRichesse.Location = New System.Drawing.Point(538, 154)
        Me.labelRichesse.Name = "labelRichesse"
        Me.labelRichesse.Size = New System.Drawing.Size(66, 17)
        Me.labelRichesse.TabIndex = 61
        Me.labelRichesse.Text = "Richesse"
        '
        'btnDefier
        '
        Me.btnDefier.Location = New System.Drawing.Point(74, 236)
        Me.btnDefier.Name = "btnDefier"
        Me.btnDefier.Size = New System.Drawing.Size(163, 28)
        Me.btnDefier.TabIndex = 62
        Me.btnDefier.Text = "Défier"
        Me.btnDefier.UseVisualStyleBackColor = True
        '
        'listeOccuper
        '
        Me.listeOccuper.FormattingEnabled = True
        Me.listeOccuper.ItemHeight = 16
        Me.listeOccuper.Location = New System.Drawing.Point(651, 174)
        Me.listeOccuper.Name = "listeOccuper"
        Me.listeOccuper.Size = New System.Drawing.Size(95, 148)
        Me.listeOccuper.TabIndex = 63
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Location = New System.Drawing.Point(675, 154)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(48, 17)
        Me.labelStatus.TabIndex = 64
        Me.labelStatus.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 17)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "X"
        '
        'colonne
        '
        Me.colonne.Location = New System.Drawing.Point(202, 305)
        Me.colonne.Name = "colonne"
        Me.colonne.Size = New System.Drawing.Size(40, 22)
        Me.colonne.TabIndex = 69
        Me.colonne.Text = "3"
        Me.colonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ligne
        '
        Me.ligne.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ligne.Location = New System.Drawing.Point(134, 304)
        Me.ligne.Name = "ligne"
        Me.ligne.Size = New System.Drawing.Size(40, 22)
        Me.ligne.TabIndex = 68
        Me.ligne.Text = "3"
        Me.ligne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Dimension"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "sec"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 17)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "min"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(180, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 17)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "h"
        '
        'sec
        '
        Me.sec.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(284, 337)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(40, 22)
        Me.sec.TabIndex = 73
        Me.sec.Text = "0"
        Me.sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'min
        '
        Me.min.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.Location = New System.Drawing.Point(202, 337)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(40, 22)
        Me.min.TabIndex = 72
        Me.min.Text = "1"
        Me.min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'heures
        '
        Me.heures.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heures.Location = New System.Drawing.Point(134, 337)
        Me.heures.Name = "heures"
        Me.heures.Size = New System.Drawing.Size(40, 22)
        Me.heures.TabIndex = 71
        Me.heures.Text = "0"
        Me.heures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Temps max"
        '
        'buttonHome
        '
        Me.buttonHome.Image = CType(resources.GetObject("buttonHome.Image"), System.Drawing.Image)
        Me.buttonHome.Location = New System.Drawing.Point(541, 338)
        Me.buttonHome.Name = "buttonHome"
        Me.buttonHome.Size = New System.Drawing.Size(205, 69)
        Me.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonHome.TabIndex = 56
        Me.buttonHome.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(331, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 42)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 365)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 49
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(752, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 365)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 48
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 405)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(803, 46)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 47
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 46
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 370)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 17)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Mise"
        '
        'mise
        '
        Me.mise.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mise.Location = New System.Drawing.Point(134, 370)
        Me.mise.Name = "mise"
        Me.mise.Size = New System.Drawing.Size(40, 22)
        Me.mise.TabIndex = 81
        Me.mise.Text = "0"
        Me.mise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(180, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 17)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Crédit "
        '
        'listeNom
        '
        Me.listeNom.FormattingEnabled = True
        Me.listeNom.ItemHeight = 16
        Me.listeNom.Location = New System.Drawing.Point(314, 173)
        Me.listeNom.Name = "listeNom"
        Me.listeNom.Size = New System.Drawing.Size(163, 148)
        Me.listeNom.TabIndex = 83
        '
        'modeForm
        '
        Me.modeForm.FormattingEnabled = True
        Me.modeForm.Items.AddRange(New Object() {"Création match", "Visiteur"})
        Me.modeForm.Location = New System.Drawing.Point(74, 127)
        Me.modeForm.Name = "modeForm"
        Me.modeForm.Size = New System.Drawing.Size(163, 24)
        Me.modeForm.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Mode"
        '
        'listeMatch
        '
        Me.listeMatch.Enabled = False
        Me.listeMatch.FormattingEnabled = True
        Me.listeMatch.ItemHeight = 16
        Me.listeMatch.Location = New System.Drawing.Point(314, 173)
        Me.listeMatch.Name = "listeMatch"
        Me.listeMatch.Size = New System.Drawing.Size(432, 148)
        Me.listeMatch.TabIndex = 88
        Me.listeMatch.Visible = False
        '
        'labelMatchCours
        '
        Me.labelMatchCours.AutoSize = True
        Me.labelMatchCours.Location = New System.Drawing.Point(499, 154)
        Me.labelMatchCours.Name = "labelMatchCours"
        Me.labelMatchCours.Size = New System.Drawing.Size(105, 17)
        Me.labelMatchCours.TabIndex = 91
        Me.labelMatchCours.Text = "Match en cours"
        Me.labelMatchCours.Visible = False
        '
        'buttonAnnuler
        '
        Me.buttonAnnuler.Enabled = False
        Me.buttonAnnuler.Image = CType(resources.GetObject("buttonAnnuler.Image"), System.Drawing.Image)
        Me.buttonAnnuler.Location = New System.Drawing.Point(336, 232)
        Me.buttonAnnuler.Name = "buttonAnnuler"
        Me.buttonAnnuler.Size = New System.Drawing.Size(204, 84)
        Me.buttonAnnuler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonAnnuler.TabIndex = 93
        Me.buttonAnnuler.TabStop = False
        Me.buttonAnnuler.Visible = False
        '
        'patientez
        '
        Me.patientez.Enabled = False
        Me.patientez.Image = CType(resources.GetObject("patientez.Image"), System.Drawing.Image)
        Me.patientez.Location = New System.Drawing.Point(301, 163)
        Me.patientez.Name = "patientez"
        Me.patientez.Size = New System.Drawing.Size(251, 53)
        Me.patientez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.patientez.TabIndex = 92
        Me.patientez.TabStop = False
        Me.patientez.Visible = False
        '
        'lblArgent
        '
        Me.lblArgent.AutoSize = True
        Me.lblArgent.Location = New System.Drawing.Point(119, 70)
        Me.lblArgent.Name = "lblArgent"
        Me.lblArgent.Size = New System.Drawing.Size(50, 17)
        Me.lblArgent.TabIndex = 95
        Me.lblArgent.Text = "Argent"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'FormModeEnLigne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblArgent)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buttonAnnuler)
        Me.Controls.Add(Me.patientez)
        Me.Controls.Add(Me.labelMatchCours)
        Me.Controls.Add(Me.listeMatch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.modeForm)
        Me.Controls.Add(Me.listeNom)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.mise)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.heures)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.colonne)
        Me.Controls.Add(Me.ligne)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.listeOccuper)
        Me.Controls.Add(Me.btnDefier)
        Me.Controls.Add(Me.labelRichesse)
        Me.Controls.Add(Me.labelNom)
        Me.Controls.Add(Me.listeRichesse)
        Me.Controls.Add(Me.buttonHome)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.champRecherche)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormModeEnLigne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormModeEnLigne"
        CType(Me.buttonHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonAnnuler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.patientez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents champRecherche As TextBox
    Friend WithEvents buttonHome As PictureBox
    Friend WithEvents rafraichissement As Timer
    Friend WithEvents listeRichesse As ListBox
    Friend WithEvents labelNom As Label
    Friend WithEvents labelRichesse As Label
    Friend WithEvents btnDefier As Button
    Friend WithEvents listeOccuper As ListBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents colonne As TextBox
    Friend WithEvents ligne As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents sec As TextBox
    Friend WithEvents min As TextBox
    Friend WithEvents heures As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents mise As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents listeNom As ListBox
    Friend WithEvents modeForm As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listeMatch As ListBox
    Friend WithEvents labelMatchCours As Label
    Friend WithEvents buttonAnnuler As PictureBox
    Friend WithEvents patientez As PictureBox
    Friend WithEvents lblArgent As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
