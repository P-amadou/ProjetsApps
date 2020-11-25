<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNveCompte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNveCompte))
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.nveCompte = New System.Windows.Forms.PictureBox()
        Me.retour = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.erreurIndication = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.confirmPass = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.buttonCompte = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nveCompte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.retour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 42)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 365)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(735, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 365)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 15
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 405)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(803, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Entrez votre mot de passe *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Pseudo *"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(320, 233)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(174, 22)
        Me.password.TabIndex = 30
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(320, 184)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(174, 22)
        Me.username.TabIndex = 29
        '
        'nveCompte
        '
        Me.nveCompte.Image = CType(resources.GetObject("nveCompte.Image"), System.Drawing.Image)
        Me.nveCompte.Location = New System.Drawing.Point(280, 73)
        Me.nveCompte.Name = "nveCompte"
        Me.nveCompte.Size = New System.Drawing.Size(243, 86)
        Me.nveCompte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nveCompte.TabIndex = 35
        Me.nveCompte.TabStop = False
        '
        'retour
        '
        Me.retour.Image = CType(resources.GetObject("retour.Image"), System.Drawing.Image)
        Me.retour.Location = New System.Drawing.Point(64, 340)
        Me.retour.Name = "retour"
        Me.retour.Size = New System.Drawing.Size(70, 49)
        Me.retour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.retour.TabIndex = 36
        Me.retour.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(317, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Confirmer votre mot de passe *"
        '
        'erreurIndication
        '
        Me.erreurIndication.AutoSize = True
        Me.erreurIndication.Location = New System.Drawing.Point(317, 322)
        Me.erreurIndication.Name = "erreurIndication"
        Me.erreurIndication.Size = New System.Drawing.Size(0, 17)
        Me.erreurIndication.TabIndex = 39
        Me.erreurIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Entrez votre mot de passe *"
        '
        'confirmPass
        '
        Me.confirmPass.Location = New System.Drawing.Point(320, 286)
        Me.confirmPass.Name = "confirmPass"
        Me.confirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPass.Size = New System.Drawing.Size(174, 22)
        Me.confirmPass.TabIndex = 40
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(526, 286)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(182, 21)
        Me.CheckBox1.TabIndex = 45
        Me.CheckBox1.Text = "Afficher le mot de passe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'buttonCompte
        '
        Me.buttonCompte.Location = New System.Drawing.Point(343, 340)
        Me.buttonCompte.Name = "buttonCompte"
        Me.buttonCompte.Size = New System.Drawing.Size(127, 24)
        Me.buttonCompte.TabIndex = 46
        Me.buttonCompte.Text = "Valider"
        Me.buttonCompte.UseVisualStyleBackColor = True
        '
        'FormNveCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.buttonCompte)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.confirmPass)
        Me.Controls.Add(Me.erreurIndication)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.retour)
        Me.Controls.Add(Me.nveCompte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormNveCompte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormNveCompte"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nveCompte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.retour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents nveCompte As PictureBox
    Friend WithEvents retour As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents erreurIndication As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents confirmPass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents buttonCompte As Button
End Class
