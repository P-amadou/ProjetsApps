<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageAccueil))
        Me.nveCompte = New System.Windows.Forms.PictureBox()
        Me.connexion = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.verifConnexion = New System.Windows.Forms.Timer(Me.components)
        Me.bntQuit = New System.Windows.Forms.PictureBox()
        CType(Me.nveCompte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.connexion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bntQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nveCompte
        '
        Me.nveCompte.Image = CType(resources.GetObject("nveCompte.Image"), System.Drawing.Image)
        Me.nveCompte.Location = New System.Drawing.Point(280, 242)
        Me.nveCompte.Name = "nveCompte"
        Me.nveCompte.Size = New System.Drawing.Size(257, 98)
        Me.nveCompte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nveCompte.TabIndex = 18
        Me.nveCompte.TabStop = False
        '
        'connexion
        '
        Me.connexion.Image = CType(resources.GetObject("connexion.Image"), System.Drawing.Image)
        Me.connexion.Location = New System.Drawing.Point(280, 124)
        Me.connexion.Name = "connexion"
        Me.connexion.Size = New System.Drawing.Size(257, 98)
        Me.connexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.connexion.TabIndex = 17
        Me.connexion.TabStop = False
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
        Me.PictureBox7.Location = New System.Drawing.Point(752, 42)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(64, 365)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 15
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 388)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(817, 63)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(817, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'verifConnexion
        '
        Me.verifConnexion.Enabled = True
        Me.verifConnexion.Interval = 1000
        '
        'bntQuit
        '
        Me.bntQuit.Image = CType(resources.GetObject("bntQuit.Image"), System.Drawing.Image)
        Me.bntQuit.Location = New System.Drawing.Point(646, 71)
        Me.bntQuit.Name = "bntQuit"
        Me.bntQuit.Size = New System.Drawing.Size(62, 48)
        Me.bntQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bntQuit.TabIndex = 19
        Me.bntQuit.TabStop = False
        '
        'PageAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.bntQuit)
        Me.Controls.Add(Me.nveCompte)
        Me.Controls.Add(Me.connexion)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(818, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(818, 480)
        Me.Name = "PageAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connexion"
        CType(Me.nveCompte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.connexion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bntQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents connexion As PictureBox
    Friend WithEvents nveCompte As PictureBox
    Friend WithEvents verifConnexion As Timer
    Friend WithEvents bntQuit As PictureBox
End Class
