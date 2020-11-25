Imports System.ComponentModel

Public Class FormModeEnLigne

    Dim idPartieDemande As Integer = -1

    Private Sub Pictures_MouseHover(sender As Object, e As EventArgs) Handles buttonHome.MouseHover, buttonAnnuler.MouseHover
        Cursor = Cursors.Hand
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles buttonHome.MouseLeave, buttonAnnuler.MouseLeave
        Cursor = Cursors.Default

        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.None

    End Sub

    Private Sub buttonHome_Click(sender As Object, e As EventArgs) Handles buttonHome.Click
        Me.Hide()
        rafraichissement.Enabled = False
        MenuPrincipal.Show()
    End Sub

    Public Sub setListePlayerConnected()

        listeNom.Items.Clear()
        listeRichesse.Items.Clear()
        listeOccuper.Items.Clear()

        rafraichissement.Enabled = True
        Dim listeConnection As ArrayList = ManagerData.getPlayerConnected()
        For Each j As Joueur In listeConnection
            'On ajoute pas notre propre nom à la liste
            If (j.getNom() <> ManagerData.joueur.getNom()) Then
                listeNom.Items.Add(j.getNom())
                listeRichesse.Items.Add(j.getArgent())
                listeOccuper.Items.Add(IIf(ManagerData.isOccuper(j.getNom), "Occuper", "Libre"))
            End If
        Next

        'Cette technique permet de garder le focus sur un item même après le refresh (si la personne est toujours connecté)
        If (listeNom.FindStringExact(champRecherche.Text) <> -1) Then
            listeNom.SelectedIndex = listeNom.FindStringExact(champRecherche.Text)
        End If
    End Sub

    Public Sub setListeMatchEnCours()
        listeMatch.Items.Clear()

        rafraichissement.Enabled = True
        Dim listePartieEnCours As ArrayList = ManagerData.getPartieEnCours()

        For Each partie As Partie In listePartieEnCours
            Dim nomJ1 As String = ManagerData.getNom(partie.getIdJ1())
            Dim nomJ2 As String = ManagerData.getNom(partie.getIdJ2())
            listeMatch.Items.Add(nomJ1 & " Vs " & nomJ2 & " Mise de la partie : " & partie.getMise())
        Next


    End Sub

    Private Sub FormModeEnLigne_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PageAccueil.Close()
    End Sub

    Public Sub setListes()

        rafraichissement.Enabled = True
        'On rafraichis la liste toute les 3 sec selon le mode choisie (visiteur ou création de match)
        If (modeForm.SelectedIndex = 0) Then
            setListePlayerConnected()
        Else
            setListeMatchEnCours()
        End If
    End Sub

    Private Sub refresh_Tick(sender As Object, e As EventArgs) Handles rafraichissement.Tick

        setListes()

        'Si une demande est en cours on va aller vérifier si elle à été accepter
        If (idPartieDemande <> -1) Then
            Dim status As Integer = ManagerData.isDemandeAccepter(idPartieDemande)
            'Si la personnne à repondu
            If status <> -1 Then

                'On va notifier la base qu'on a vu la demande
                ManagerData.SetVuDemande(idPartieDemande)

                'On regarde si elle a accepter ou pas
                If (status = 0) Then
                    idPartieDemande = -1
                    MsgBox("Demande refuser")
                Else
                    'On initialise le mode multi avec l'ID de la partie pour que le formulaire puisse se mettre à jour
                    Jeu.activeModeMulti(idPartieDemande)
                    Jeu.Initialisation()
                    ManagerData.setSetPlayerOccuper(True)
                    ManagerData.stats.addPartieJouer()
                    'Pendant qu'on joue on désactive la boucle d'actualisation
                    MenuPrincipal.actualisationDemandeDefie.Enabled = False
                    'On met le formulaire en mode solo 
                    Me.Hide()
                    ManagerData.joueur.addArgent(-Integer.Parse(mise.Text))
                    'On upadate l'argent du joueur 
                    ManagerData.UpdateJoueur()
                    Jeu.Show()
                End If

                idPartieDemande = -1

                'On reactive les control du formulaire 
                For Each ctrl As Control In Me.Controls
                    ctrl.Enabled = True
                Next

                patientez.Enabled = False
                patientez.Visible = False

                buttonAnnuler.Enabled = False
                buttonAnnuler.Visible = False


            End If

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        champRecherche.Text = champRecherche.Text.Trim


        If (champRecherche.Text = "") Then
            MsgBox("Veuillez saisir un nom")
            Exit Sub
        End If
        Dim indice As Integer = -1
        If modeForm.SelectedIndex = 0 Then
            indice = listeNom.FindStringExact(champRecherche.Text)
        Else
            indice = listeMatch.FindString(champRecherche.Text)
        End If

        If (indice = -1) Then
            MsgBox("Aucun résultat")
        Else
            If modeForm.SelectedIndex = 0 Then
                listeNom.SelectedIndex = indice
            Else
                listeMatch.SelectedIndex = indice
            End If

        End If




    End Sub

    Private Sub listeNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listeRichesse.SelectedIndexChanged, listeOccuper.SelectedIndexChanged, listeNom.SelectedIndexChanged

        listeNom.SelectedIndex = CType(sender, ListBox).SelectedIndex
        listeRichesse.SelectedIndex = CType(sender, ListBox).SelectedIndex
        listeOccuper.SelectedIndex = CType(sender, ListBox).SelectedIndex
        champRecherche.Text = listeNom.SelectedItem
    End Sub

    Private Sub btnDefier_Click(sender As Object, e As EventArgs) Handles btnDefier.Click
        'Envoie de la demande de défi
        If (listeNom.SelectedIndex = -1) Then
            MsgBox("Veuillez choisir un adversaire")
            Exit Sub
        ElseIf listeOccuper.SelectedItem = "Occupé" Then
            MsgBox(listeNom.SelectedItem & " est occuper pour le moment", vbOK)
            Exit Sub
        ElseIf (Integer.Parse(listeRichesse.SelectedItem) < Integer.Parse(mise.Text)) Then
            MsgBox("Votre adversaire n'a pas les fond nécessaire ")
            Exit Sub
        Else
            If MsgBox("Voulez vous envoyer une demande à " & listeNom.SelectedItem, vbYesNo) = vbNo Then
                Exit Sub
            End If

        End If

        Dim idAdversaire = ManagerData.getID(listeNom.SelectedItem)
        Dim l As Integer = ligne.Text
        Dim c As Integer = colonne.Text
        Dim Theure As Integer = heures.Text
        Dim tMinute As Integer = min.Text
        Dim tSec As Integer = sec.Text
        Dim valeurMise As Integer = mise.Text

        ManagerData.sendDefie(idAdversaire, l, c, Theure, tMinute, tSec, valeurMise)


        idPartieDemande = ManagerData.getidDefisDemander(idAdversaire)

        'On doit attendre la réponse de l'adversaire
        'On désactive tout les item actuel
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = False
        Next
        'Et on montre les items cachés
        patientez.Enabled = True
        patientez.Visible = True

        buttonAnnuler.Enabled = True
        buttonAnnuler.Visible = True





    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        'On doit aller retirer la ligne sur dans la table partie
        ManagerData.cancelPartie(idPartieDemande)

        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = True
        Next

        patientez.Enabled = False
        patientez.Visible = False

        buttonAnnuler.Enabled = False
        buttonAnnuler.Visible = False
        idPartieDemande = -1


    End Sub

    Private Sub listeNom_DoubleClick(sender As Object, e As EventArgs) Handles listeOccuper.DoubleClick, listeRichesse.DoubleClick, listeNom.DoubleClick

        If listeNom.SelectedIndex <> -1 Then
            btnDefier.PerformClick()
        End If

    End Sub

    Private Sub champColonne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles colonne.KeyPress, ligne.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Back)) Then
            Return
        End If
        Dim box As TextBox = sender
        If (Not IsNumeric(e.KeyChar)) Then
            e.Handled = True
            Return
        End If

        If (Integer.Parse(sender.Text & "" & e.KeyChar) > maxDim) Then
            MsgBox("La taille maximal est de " & maxDim)
            e.Handled = True
        ElseIf (Integer.Parse(sender.Text & "" & e.KeyChar) < minDim) Then
            MsgBox("La taille min est de " & minDim)
            e.Handled = True
        End If

    End Sub

    Private Sub heures_KeyPress(sender As Object, e As KeyPressEventArgs) Handles heures.KeyPress, min.KeyPress, sec.KeyPress

        If (e.KeyChar = Convert.ToChar(vbBack)) Then
            Return
        End If

        If (Not IsNumeric(e.KeyChar)) Then
            e.Handled = True
            Return
        End If

        Dim box As TextBox = sender
        If (Integer.Parse(box.Text & e.KeyChar) > 59) Then
            e.Handled = True
            Return
        End If
    End Sub


    Private Sub Mise_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mise.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Back)) Then
            Return
        End If
        Dim box As TextBox = sender
        If (Not IsNumeric(e.KeyChar)) Then
            e.Handled = True
            Return
        End If

        If (Integer.Parse(sender.Text & "" & e.KeyChar) > ManagerData.joueur.getArgent()) Then
            MsgBox("Vous n'avez pas " & sender.Text & "" & e.KeyChar & " crédits à votre disposition")
            e.Handled = True
        End If

    End Sub

    Private Sub modeForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modeForm.SelectedIndexChanged
        Dim c As ComboBox = sender
        'Code à changer
        If (c.SelectedIndex = 0) Then
            'On cache la liste qui montre les personnes en ligne
            listeNom.Visible = True
            listeNom.Enabled = True

            listeOccuper.Visible = True
            listeOccuper.Enabled = True

            listeRichesse.Visible = True
            listeRichesse.Enabled = True

            labelNom.Visible = True
            labelRichesse.Visible = True
            labelStatus.Visible = True

            listeMatch.Visible = False
            listeMatch.Enabled = False
            labelMatchCours.Visible = False
        Else
            'Sinon on cache celle  qui montres les match qui cours

            listeNom.Visible = False
            listeNom.Enabled = False

            listeOccuper.Visible = False
            listeOccuper.Enabled = False

            listeRichesse.Visible = False
            listeRichesse.Enabled = False

            labelNom.Visible = False
            labelRichesse.Visible = False
            labelStatus.Visible = False

            listeMatch.Visible = True
            listeMatch.Enabled = True

            labelMatchCours.Visible = True
        End If
    End Sub
    Public Sub setArgent(a As Integer)
        lblArgent.Text = a
    End Sub

    Private Sub buttonAnnuler_Click(sender As Object, e As EventArgs) Handles buttonAnnuler.Click
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = True
        Next
        'Et on montre les items cachés
        patientez.Enabled = False
        patientez.Visible = False

        buttonAnnuler.Enabled = False
        buttonAnnuler.Visible = False
        ManagerData.cancelPartie(idPartieDemande)

    End Sub

    Private Sub modeForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles modeForm.KeyPress
        e.Handled = True
    End Sub
End Class