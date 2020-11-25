Imports System.ComponentModel

Public Class PageAccueil
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles connexion.Click
        Me.Hide()
        FormConnexion.clearTextField()
        FormConnexion.loadPlayerName()
        FormConnexion.Show()
    End Sub


    Private Sub nveCompte_Click(sender As Object, e As EventArgs) Handles nveCompte.Click
        Me.Hide()
        FormNveCompte.clearTextField()
        FormNveCompte.Show()
    End Sub
    Private Sub Pictures_MouseHover(sender As Object, e As EventArgs) Handles connexion.MouseHover, nveCompte.MouseHover, bntQuit.MouseHover
        Cursor = Cursors.Hand
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles connexion.MouseLeave, nveCompte.MouseLeave, bntQuit.MouseLeave
        Cursor = Cursors.Default
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ManagerData.connect()

    End Sub

    Private Sub PageAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On se connecte à la base de donnée
        If (Not ManagerData.connect()) Then
            MsgBox("Une erreur est survenue lors de l'ouverture, vérifier votre connection internet")
            Me.Close()
        End If


    End Sub

    Private Sub PageAccueil_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (Not ManagerData.joueur Is Nothing) Then
            ManagerData.setSetPlayerOccuper(False)
            ManagerData.disconnectPlayer(ManagerData.joueur.getNom())
        End If
        ManagerData.disconnect()
    End Sub

    Private Sub verifConnexion_Tick(sender As Object, e As EventArgs) Handles verifConnexion.Tick
        'On vérifie tout le temps si on est en ligne à modifier
        If (Not ManagerData.isConnect()) Then

            If (Form.ActiveForm Is Nothing) Then
                Me.Close()
            Else
                Form.ActiveForm.Close()
            End If
            MsgBox("Connexion perdu")
            End If
    End Sub

    Private Sub bntQuit_Click(sender As Object, e As EventArgs) Handles bntQuit.Click
        If MsgBox("Voulez vous quitter l'application", vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub
End Class