<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConnexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConnexion))
        Me.retour = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ImageConnexion = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.erreurIndication = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.ComboBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.connexion = New System.Windows.Forms.Button()
        CType(Me.retour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageConnexion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'retour
        '
        Me.retour.Image = CType(resources.GetObject("retour.Image"), System.Drawing.Image)
        Me.retour.Location = New System.Drawing.Point(79, 336)
        Me.retour.Name = "retour"
        Me.retour.Size = New System.Drawing.Size(70, 49)
        Me.retour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.retour.TabIndex = 25
        Me.retour.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 42)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 365)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(735, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 365)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 405)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(803, 46)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'ImageConnexion
        '
        Me.ImageConnexion.Image = CType(resources.GetObject("ImageConnexion.Image"), System.Drawing.Image)
        Me.ImageConnexion.Location = New System.Drawing.Point(291, 71)
        Me.ImageConnexion.Name = "ImageConnexion"
        Me.ImageConnexion.Size = New System.Drawing.Size(243, 86)
        Me.ImageConnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageConnexion.TabIndex = 26
        Me.ImageConnexion.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Entrez votre mot de passe *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Pseudo *"
        '
        'erreurIndication
        '
        Me.erreurIndication.AutoSize = True
        Me.erreurIndication.Location = New System.Drawing.Point(327, 274)
        Me.erreurIndication.Name = "erreurIndication"
        Me.erreurIndication.Size = New System.Drawing.Size(0, 17)
        Me.erreurIndication.TabIndex = 40
        Me.erreurIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'username
        '
        Me.username.AllowDrop = True
        Me.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.username.FormattingEnabled = True
        Me.username.Location = New System.Drawing.Point(330, 192)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(180, 24)
        Me.username.Sorted = True
        Me.username.TabIndex = 41
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(330, 249)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(180, 22)
        Me.password.TabIndex = 42
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(530, 250)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(182, 21)
        Me.CheckBox1.TabIndex = 44
        Me.CheckBox1.Text = "Afficher le mot de passe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'connexion
        '
        Me.connexion.Location = New System.Drawing.Point(360, 310)
        Me.connexion.Name = "connexion"
        Me.connexion.Size = New System.Drawing.Size(127, 24)
        Me.connexion.TabIndex = 45
        Me.connexion.Text = "Connexion"
        Me.connexion.UseVisualStyleBackColor = True
        '
        'FormConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.connexion)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.erreurIndication)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImageConnexion)
        Me.Controls.Add(Me.retour)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(800, 495)
        Me.MinimumSize = New System.Drawing.Size(800, 495)
        Me.Name = "FormConnexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormConnexion"
        CType(Me.retour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageConnexion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents retour As PictureBox
    Friend WithEvents ImageConnexion As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents erreurIndication As Label
    Friend WithEvents username As ComboBox
    Friend WithEvents password As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents connexion As Button
End Class
