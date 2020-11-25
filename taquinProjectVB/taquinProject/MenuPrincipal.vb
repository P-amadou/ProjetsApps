Imports AxWMPLib

Public Class MenuPrincipal

    Private Sub MenuPrincipal_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each ctrl In panelButton.Controls
            AddHandler CType(ctrl, PictureBox).MouseHover, AddressOf Pictures_MouseHover
            AddHandler CType(ctrl, PictureBox).MouseLeave, AddressOf PictureBox3_MouseLeave
        Next


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles jouer.Click
        'On demande explicitement au form jeu de se mettre à jour
        Jeu.desactiveModeMulti()
        If (Jeu.Initialisation()) Then
            Me.Hide()
            ManagerData.setSetPlayerOccuper(True)
            ManagerData.stats.addPartieJouer()
            'Pendant qu'on joue on désactive la boucle d'actualisation
            actualisationDemandeDefie.Enabled = False
            'On met le formulaire en mode solo 
            Jeu.Show()
        End If
    End Sub

    Private Sub Pictures_MouseHover(sender As Object, e As EventArgs)
        Cursor = Cursors.Hand
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
        Cursor = Cursors.Default

        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.None

    End Sub

    Private Sub param_Click(sender As Object, e As EventArgs) Handles param.Click
        Me.Hide()
        parametres.changementEffectué = False
        parametres.initPreferences()
        parametres.Show()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        PageAccueil.Close()
    End Sub


    Public Sub setUserName(nom As String)
        labelName.Text = nom
    End Sub

    Public Sub setArgent(a As Integer)
        lblArgent.Text = a
    End Sub
    Public Sub setUserInfos()

        labelName.Text = ManagerData.joueur.getNom()
        lblArgent.Text = ManagerData.joueur.getArgent()

        actualisationDemandeDefie.Enabled = True

        parametres.initPreferences()
        Statistique.initStatistiques()

    End Sub

    Private Sub deconnexion_Click(sender As Object, e As EventArgs) Handles deconnexion.Click

        If (MsgBox("Voulez vous vraiment vous déconnecter", vbYesNo) = vbYes) Then
            Me.Hide()
            ManagerData.UpdateJoueur()
            ManagerData.UpdateStats()
            actualisationDemandeDefie.Enabled = False
            ManagerData.disconnectPlayer(ManagerData.joueur.getNom())
            'On nettoie tout avant de quitter la session
            lecteurMp3.Ctlcontrols.pause()
            lecteurMp3.URL = ""
            parametres.listeMusique.Items.Clear()
            PageAccueil.Show()
        End If
    End Sub

    Private Sub score_Click(sender As Object, e As EventArgs) Handles stats.Click
        Me.Hide()
        Statistique.initStatistiques()
        Statistique.Show()
    End Sub

    Private Sub classement_Click(sender As Object, e As EventArgs) Handles classementButton.Click
        Me.Hide()
        Classement.setListes()
        Classement.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs)
        lecteurMp3.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs)
        lecteurMp3.Ctlcontrols.pause()
    End Sub

    Private Sub btnSuiv_Click(sender As Object, e As EventArgs)
        lecteurMp3.Ctlcontrols.next()
    End Sub

    Private Sub btnPre_Click(sender As Object, e As EventArgs)
        lecteurMp3.Ctlcontrols.previous()
    End Sub


    Private Sub btnPause_Click_1(sender As Object, e As EventArgs) Handles btnPause.Click
        lecteurMp3.Ctlcontrols.pause()
    End Sub

    Private Sub btnSuiv_Click_1(sender As Object, e As EventArgs) Handles btnSuiv.Click
        If (parametres.listeMusique.Items.Count = 0) Then
            Exit Sub
        End If
        'On doit charger la  musique précedente

        parametres.listeMusique.SelectedIndex = Math.Min(parametres.listeMusique.SelectedIndex + 1, parametres.listeMusique.Items.Count - 1)
        lecteurMp3.URL = parametres.listeMusique.SelectedItem
    End Sub

    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click
        If (lecteurMp3.URL = "") Then
            MsgBox("Aucune musique en mémoire allez chargez votre playlist dans les paramètres")
            Exit Sub
        End If
        lecteurMp3.Ctlcontrols.play()
    End Sub

    Private Sub btnPre_Click_1(sender As Object, e As EventArgs) Handles btnPre.Click
        If (parametres.listeMusique.Items.Count = 0) Then
            Exit Sub
        End If
        'On doit charger la  musique précedente

        parametres.listeMusique.SelectedIndex = Math.Max(parametres.listeMusique.SelectedIndex - 1, 0)
        lecteurMp3.URL = parametres.listeMusique.SelectedItem
    End Sub

    Private Sub lecteurMp3_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles lecteurMp3.PlayStateChange
        'Le 8 est le num de l'état quand on a finit de jouer une musique
        If e.newState = 8 Then
            If (parametres.listeMusique.Items.Count = 0) Then
                Exit Sub
            End If
            'On doit charger la prochaine musique
            If (parametres.listeMusique.SelectedIndex < parametres.listeMusique.Items.Count - 1) Then
                parametres.listeMusique.SelectedIndex += 1
                lecteurMp3.URL = parametres.listeMusique.SelectedItem
            End If

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        FormModeEnLigne.setArgent(lblArgent.Text)
        FormModeEnLigne.setListePlayerConnected()
        FormModeEnLigne.modeForm.SelectedIndex = 0
        FormModeEnLigne.Show()
    End Sub

    Private Sub actualisationDemandeDefie_Tick(sender As Object, e As EventArgs) Handles actualisationDemandeDefie.Tick
        'Toute les 2 seconde on regarde si on à pas une demande de défie 
        'Le return de hasDefie est une liste qui contient (idPartie,idJ1) et une liste avec (-1,-1) sinon
        Dim infos As Integer() = ManagerData.hasDefie(ManagerData.joueur.getNom())
        Dim partie As Partie = ManagerData.getPartieObject(infos(0))



        If (Not infos(0) = -1) Then
            actualisationDemandeDefie.Enabled = False
            If (MsgBox("Vous avez reçu une demande de défie " & ManagerData.getNom(infos(1)) & "  voulez vous rejoindre la partie ?" & Chr(10) & Chr(13) &
                       "Infos de la partie : " & Chr(10) & Chr(13) & partie.toString(), vbYesNo) = vbYes) Then
                'On accepte le défie avec l'ID suivant

                Jeu.activeModeMulti(infos(0))
                'On initialise le formulaire Jeu
                If (Not Jeu.Initialisation()) Then
                    MsgBox("Une erreur est survenue")
                    Jeu.desactiveModeMulti()
                    Exit Sub
                End If

                'On va accepter le defie
                ManagerData.setDefieStatus(infos(0), True)
                Me.Hide()
                ManagerData.setSetPlayerOccuper(True)
                ManagerData.stats.addPartieJouer()
                'Pendant qu'on joue on désactive la boucle d'actualisation
                actualisationDemandeDefie.Enabled = False
                'On met le formulaire de jeu en mode multi 

                'Avant d'entrer dans le jeu on enlève la mise de la partie
                ManagerData.joueur.addArgent(-partie.getMise())
                ManagerData.UpdateJoueur()
                Jeu.Show()
            Else
                'On va refuser le défie
                ManagerData.setDefieStatus(infos(0), False)
            End If
            actualisationDemandeDefie.Enabled = True
        End If

    End Sub

End Class