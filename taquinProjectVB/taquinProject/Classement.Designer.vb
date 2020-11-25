<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Classement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Classement))
        Me.listeTemps = New System.Windows.Forms.ListBox()
        Me.champFacteurTrie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.champSens = New System.Windows.Forms.ComboBox()
        Me.champRecherche = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listeNom = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.classementButton = New System.Windows.Forms.PictureBox()
        Me.buttonHome = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.boutonDetail = New System.Windows.Forms.Button()
        CType(Me.classementButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listeTemps
        '
        Me.listeTemps.FormattingEnabled = True
        Me.listeTemps.ItemHeight = 16
        Me.listeTemps.Location = New System.Drawing.Point(509, 184)
        Me.listeTemps.Name = "listeTemps"
        Me.listeTemps.Size = New System.Drawing.Size(202, 148)
        Me.listeTemps.TabIndex = 37
        '
        'champFacteurTrie
        '
        Me.champFacteurTrie.FormattingEnabled = True
        Me.champFacteurTrie.Items.AddRange(New Object() {"Ordre alphabétique", "Meilleur score"})
        Me.champFacteurTrie.Location = New System.Drawing.Point(57, 152)
        Me.champFacteurTrie.Name = "champFacteurTrie"
        Me.champFacteurTrie.Size = New System.Drawing.Size(163, 24)
        Me.champFacteurTrie.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Trie par :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Sens :"
        '
        'champSens
        '
        Me.champSens.FormattingEnabled = True
        Me.champSens.Items.AddRange(New Object() {"Croissant", "Décroissant"})
        Me.champSens.Location = New System.Drawing.Point(57, 202)
        Me.champSens.Name = "champSens"
        Me.champSens.Size = New System.Drawing.Size(163, 24)
        Me.champSens.TabIndex = 42
        '
        'champRecherche
        '
        Me.champRecherche.Location = New System.Drawing.Point(57, 256)
        Me.champRecherche.Name = "champRecherche"
        Me.champRecherche.Size = New System.Drawing.Size(163, 22)
        Me.champRecherche.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Recherche :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 28)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Rechercher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'listeNom
        '
        Me.listeNom.FormattingEnabled = True
        Me.listeNom.ItemHeight = 16
        Me.listeNom.Location = New System.Drawing.Point(294, 184)
        Me.listeNom.Name = "listeNom"
        Me.listeNom.Size = New System.Drawing.Size(202, 148)
        Me.listeNom.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Nom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(566, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Meilleur temps"
        '
        'classementButton
        '
        Me.classementButton.BackColor = System.Drawing.Color.Transparent
        Me.classementButton.Image = CType(resources.GetObject("classementButton.Image"), System.Drawing.Image)
        Me.classementButton.Location = New System.Drawing.Point(313, 53)
        Me.classementButton.Name = "classementButton"
        Me.classementButton.Size = New System.Drawing.Size(204, 84)
        Me.classementButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.classementButton.TabIndex = 39
        Me.classementButton.TabStop = False
        '
        'buttonHome
        '
        Me.buttonHome.Image = CType(resources.GetObject("buttonHome.Image"), System.Drawing.Image)
        Me.buttonHome.Location = New System.Drawing.Point(541, 338)
        Me.buttonHome.Name = "buttonHome"
        Me.buttonHome.Size = New System.Drawing.Size(205, 69)
        Me.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonHome.TabIndex = 38
        Me.buttonHome.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 42)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 365)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(752, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 365)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 34
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 405)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(803, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 33
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'boutonDetail
        '
        Me.boutonDetail.Location = New System.Drawing.Point(57, 318)
        Me.boutonDetail.Name = "boutonDetail"
        Me.boutonDetail.Size = New System.Drawing.Size(163, 28)
        Me.boutonDetail.TabIndex = 50
        Me.boutonDetail.Text = "Afficher détails"
        Me.boutonDetail.UseVisualStyleBackColor = True
        '
        'Classement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.boutonDetail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.listeNom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.champRecherche)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.champSens)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.champFacteurTrie)
        Me.Controls.Add(Me.classementButton)
        Me.Controls.Add(Me.buttonHome)
        Me.Controls.Add(Me.listeTemps)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(800, 505)
        Me.MinimumSize = New System.Drawing.Size(800, 505)
        Me.Name = "Classement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Classement"
        CType(Me.classementButton, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents listeTemps As ListBox
    Friend WithEvents buttonHome As PictureBox
    Friend WithEvents classementButton As PictureBox
    Friend WithEvents champFacteurTrie As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents champSens As ComboBox
    Friend WithEvents champRecherche As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents listeNom As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents boutonDetail As Button
End Class
