<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class parametres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(parametres))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ligne = New System.Windows.Forms.TextBox()
        Me.colonne = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.heures = New System.Windows.Forms.TextBox()
        Me.min = New System.Windows.Forms.TextBox()
        Me.sec = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.unlimitedTime = New System.Windows.Forms.CheckBox()
        Me.btnFileEx = New System.Windows.Forms.Button()
        Me.path = New System.Windows.Forms.TextBox()
        Me.fileExplorer = New System.Windows.Forms.OpenFileDialog()
        Me.choiceDefault = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnZic = New System.Windows.Forms.Button()
        Me.listeMusique = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(52, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Dimension"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Temps max"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 26)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(433, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 26)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ligne
        '
        Me.ligne.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ligne.Location = New System.Drawing.Point(157, 84)
        Me.ligne.Name = "ligne"
        Me.ligne.Size = New System.Drawing.Size(50, 22)
        Me.ligne.TabIndex = 21
        Me.ligne.Text = "3"
        Me.ligne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colonne
        '
        Me.colonne.Location = New System.Drawing.Point(256, 84)
        Me.colonne.Name = "colonne"
        Me.colonne.Size = New System.Drawing.Size(50, 22)
        Me.colonne.TabIndex = 22
        Me.colonne.Text = "3"
        Me.colonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "X"
        '
        'heures
        '
        Me.heures.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heures.Location = New System.Drawing.Point(157, 145)
        Me.heures.Name = "heures"
        Me.heures.Size = New System.Drawing.Size(50, 22)
        Me.heures.TabIndex = 25
        Me.heures.Text = "0"
        Me.heures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'min
        '
        Me.min.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.Location = New System.Drawing.Point(237, 145)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(50, 22)
        Me.min.TabIndex = 26
        Me.min.Text = "1"
        Me.min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sec
        '
        Me.sec.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(329, 145)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(50, 22)
        Me.sec.TabIndex = 27
        Me.sec.Text = "0"
        Me.sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "h"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "min"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(385, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "sec"
        '
        'unlimitedTime
        '
        Me.unlimitedTime.AutoSize = True
        Me.unlimitedTime.Location = New System.Drawing.Point(433, 147)
        Me.unlimitedTime.Name = "unlimitedTime"
        Me.unlimitedTime.Size = New System.Drawing.Size(68, 21)
        Me.unlimitedTime.TabIndex = 31
        Me.unlimitedTime.Text = "Illimité"
        Me.unlimitedTime.UseVisualStyleBackColor = True
        '
        'btnFileEx
        '
        Me.btnFileEx.Location = New System.Drawing.Point(461, 209)
        Me.btnFileEx.Name = "btnFileEx"
        Me.btnFileEx.Size = New System.Drawing.Size(35, 23)
        Me.btnFileEx.TabIndex = 32
        Me.btnFileEx.Text = "..."
        Me.btnFileEx.UseVisualStyleBackColor = True
        '
        'path
        '
        Me.path.Location = New System.Drawing.Point(157, 209)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(285, 22)
        Me.path.TabIndex = 33
        '
        'fileExplorer
        '
        Me.fileExplorer.FileName = "OpenFileDialog1"
        Me.fileExplorer.Multiselect = True
        '
        'choiceDefault
        '
        Me.choiceDefault.AutoSize = True
        Me.choiceDefault.Location = New System.Drawing.Point(528, 211)
        Me.choiceDefault.Name = "choiceDefault"
        Me.choiceDefault.Size = New System.Drawing.Size(117, 21)
        Me.choiceDefault.TabIndex = 35
        Me.choiceDefault.Text = "Default image"
        Me.choiceDefault.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Chemin image"
        '
        'btnZic
        '
        Me.btnZic.Location = New System.Drawing.Point(433, 249)
        Me.btnZic.Name = "btnZic"
        Me.btnZic.Size = New System.Drawing.Size(300, 30)
        Me.btnZic.TabIndex = 37
        Me.btnZic.Text = "Ajouter une musique à la liste d'attente"
        Me.btnZic.UseVisualStyleBackColor = True
        '
        'listeMusique
        '
        Me.listeMusique.FormattingEnabled = True
        Me.listeMusique.HorizontalScrollbar = True
        Me.listeMusique.ItemHeight = 16
        Me.listeMusique.Location = New System.Drawing.Point(52, 249)
        Me.listeMusique.Name = "listeMusique"
        Me.listeMusique.Size = New System.Drawing.Size(375, 148)
        Me.listeMusique.TabIndex = 38
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(433, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(300, 32)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Enlever une musique à la liste d'attente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'buttonHome
        '
        Me.buttonHome.Image = CType(resources.GetObject("buttonHome.Image"), System.Drawing.Image)
        Me.buttonHome.Location = New System.Drawing.Point(539, 329)
        Me.buttonHome.Name = "buttonHome"
        Me.buttonHome.Size = New System.Drawing.Size(205, 69)
        Me.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonHome.TabIndex = 24
        Me.buttonHome.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-3, 41)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 365)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(750, 41)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 365)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-3, 404)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(803, 46)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'parametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.listeMusique)
        Me.Controls.Add(Me.btnZic)
        Me.Controls.Add(Me.choiceDefault)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.path)
        Me.Controls.Add(Me.btnFileEx)
        Me.Controls.Add(Me.unlimitedTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.heures)
        Me.Controls.Add(Me.buttonHome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.colonne)
        Me.Controls.Add(Me.ligne)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(818, 490)
        Me.MinimumSize = New System.Drawing.Size(818, 490)
        Me.Name = "parametres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Paramètres"
        CType(Me.buttonHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ligne As TextBox
    Friend WithEvents colonne As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents buttonHome As PictureBox
    Friend WithEvents heures As TextBox
    Friend WithEvents min As TextBox
    Friend WithEvents sec As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents unlimitedTime As CheckBox
    Friend WithEvents btnFileEx As Button
    Friend WithEvents path As TextBox
    Friend WithEvents fileExplorer As OpenFileDialog
    Friend WithEvents choiceDefault As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnZic As Button
    Friend WithEvents listeMusique As ListBox
    Friend WithEvents Button3 As Button
End Class
