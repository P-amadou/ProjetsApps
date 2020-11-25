Public Class FormNveCompte
    Private Sub buttonValider_Click(sender As Object, e As EventArgs) Handles buttonCompte.Click
        'On enlève les espaces dans le champ username
        username.Text = username.Text.Trim()

        If (username.Text = "" Or password.Text = "" Or confirmPass.Text = "") Then
            erreurIndication.Text = "Veuillez remplir tout les champs"
            Exit Sub
        End If




        'On définit le chemin du répertoire qu'on va créers

        Dim path As String = ManagerConstante.pathDataJoueur & "\" & username.Text



        'On regarde si les mots de passe sont les mêmes
        If (password.Text <> confirmPass.Text) Then
            erreurIndication.Text = "Les mots de passe sont différents"
            Return
        End If


        If (ManagerData.nouvelleUser(username.Text, password.Text)) Then
            Me.Hide()
            ManagerData.connectPlayer(username.Text)
            ManagerData.setPreferenceObject(username.Text)
            ManagerData.setStatObject(username.Text)
            ManagerData.setPlayerObject(username.Text)
            MenuPrincipal.setUserInfos()
            MenuPrincipal.Show()
        Else
            erreurIndication.Text = "Nom d'utilisateur déjà utilisé"
        End If



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

    Private Sub retour_Click(sender As Object, e As EventArgs) Handles retour.Click
        Me.Hide()
        PageAccueil.Show()
    End Sub

    Private Sub FormNveCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        PageAccueil.Close()
    End Sub

    Public Sub clearTextField()
        For Each ctrl In Me.Controls
            If (TypeOf ctrl Is TextBox) Then
                Dim box As TextBox = ctrl
                box.Text = ""
            End If
        Next
        erreurIndication.Text = ""
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


        Dim checkB As CheckBox = sender
        If (checkB.Checked) Then
            password.PasswordChar = ""
            confirmPass.PasswordChar = ""
        Else
            password.PasswordChar = "*"
            confirmPass.PasswordChar = "*"

        End If
    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If (username.Text.Length + 1 > 15) Then
            MsgBox("La longeur max pour le nom est de 15 caractères")
            e.Handled = True
        End If

    End Sub
End Class