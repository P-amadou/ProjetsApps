Public Class FormConnexion



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles connexion.Click

        username.Text = username.Text.Trim()
        Dim path As String = ManagerConstante.pathDataJoueur & "\" & username.Text

        If (username.Text = "" Or password.Text = "") Then
            erreurIndication.Text = "Veuillez remplir tout les champs"
            Return
        End If

        If (Not ManagerData.existPlayer(username.Text)) Then
            erreurIndication.Text = "Pseudo inconnu"
            Exit Sub
        End If
        'Si le joueur est connecté avec un autre appareil
        If (ManagerData.isConnected(username.Text)) Then
            MsgBox("Veillez vous deconnecter de vos autres appareils")
            Exit Sub
        End If

        If (ManagerData.getPassword(username.Text) = password.Text) Then
            Me.Hide()
            ManagerData.connectPlayer(username.Text)
            ManagerData.setPreferenceObject(username.Text)
            ManagerData.setStatObject(username.Text)
            ManagerData.setPlayerObject(username.Text)
            MenuPrincipal.setUserInfos()
            MenuPrincipal.Show()
        Else
            erreurIndication.Text = "Mot de passe incorrect"
        End If
    End Sub

    Private Sub FormConnexion_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        PageAccueil.Close()
    End Sub



    Private Sub retour_Click(sender As Object, e As EventArgs) Handles retour.Click
        Me.Hide()
        PageAccueil.Show()
    End Sub

    Private Sub Pictures_MouseHover(sender As Object, e As EventArgs) Handles retour.MouseHover
        Cursor = Cursors.Hand
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles retour.MouseLeave
        Cursor = Cursors.Default
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.None

    End Sub

    Public Sub clearTextField()

        username.Text = ""
        username.Items.Clear()
        password.Text = ""

        erreurIndication.Text = ""
    End Sub

    Public Sub loadPlayerName()
        'On charge le combo box avec les prénom dans le fichier répertoire.txt
        Dim listeNom As New ArrayList()
        listeNom = ManagerData.getAllJoueurName()

        For Each nom As String In listeNom
            username.Items.Add(nom)
        Next

        username.DropDownStyle = ComboBoxStyle.DropDown

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        Dim checkB As CheckBox = sender
        If (checkB.Checked) Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If


    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If (username.Text.Length + 1 > 15) Then
            MsgBox("La longeur max pour le nom est de 15 caractères")
            e.Handled = True
        End If

    End Sub
End Class