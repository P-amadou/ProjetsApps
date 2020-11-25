Imports System.ComponentModel

Public Class Jeu

    Public nombreMelange As Integer = 10

    Dim lignes As Integer = 0
    Dim colonnes As Integer = 0
    Dim secRestant As Integer = 0
    Dim minRestant As Integer = 0
    Dim heureRestant As Integer = 0
    Dim useProgramme As Boolean
    Dim modeMulti As Boolean = False
    Dim idPartie As Integer = -1

    'Ctrl + D
    Dim modeAdmin As Boolean = False
    'Variable qui va nous permettre d'échanger 2 cases même si le coup n'est pas réglementaire
    Dim clickPrecedent As TableLayoutPanelCellPosition




    Public Function Initialisation() As Boolean
        'Pour la tranparence on met une couleur en font d'ecran qu'on
        'utilise après comme filtre de transparence
        'BackColor = Color.White
        'TransparencyKey = Color.White

        'On supprime tout les contrôle
        grille.Controls.Clear()

        'On vide les tableau RowStyles et ColumnStyles qui contienne les config pour chaque colonne et ligne
        grille.RowStyles.Clear()
        grille.ColumnStyles.Clear()

        'On initialise les paramètre selon le fait qu'on soit en mode en ligne ou pas
        If (modeMulti) Then
            'On récupère l'objet partie avec l'ID correspondant
            Dim partie As Partie = ManagerData.getPartieObject(idPartie)

            If (partie Is Nothing) Then
                timeLeft.Enabled = False
                Return False
            End If
            'On récupère les paramètre dans le formulaire settings
            secRestant = partie.getSeconde()
            minRestant = partie.getMinute()
            heureRestant = partie.getHeures()

            lignes = partie.getlignes()
            colonnes = partie.getColonnes()

        Else
            'On récupère les paramètre dans le formulaire settings
            secRestant = ManagerData.prefs.getSeconde()
            minRestant = ManagerData.prefs.getMin()
            heureRestant = ManagerData.prefs.getHeures()

            'Paramétrage des dimensions cases 
            lignes = ManagerData.prefs.getLignes()
            colonnes = ManagerData.prefs.getColonnes()
        End If

        grille.RowCount = lignes
        grille.ColumnCount = colonnes

        grilleAdversaire.RowCount = lignes
        grilleAdversaire.ColumnCount = colonnes
        grilleBackEnd.RowCount = lignes
        grilleBackEnd.ColumnCount = colonnes

        ' On ajoute lignes fois une nouvelle config dont la taille est jugé en pourcent 
        For i As Integer = 0 To lignes - 1
            grille.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / lignes))
        Next

        ' On ajoute colonnes fois une nouvelle config dont la taille est jugé en pourcent 
        For i As Integer = 0 To colonnes - 1
            grille.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / colonnes))
        Next
        ' Fin paramétrage

        ' On crée les buttons ainsi que leurs images et numéros
        'On fait que la grille s'initialise avec une liste car en mode multi sa sera comme sa (sa évite de faire une autre fonction)
        Dim chaine = ""
        For i As Integer = 0 To grille.RowCount - 1
            For j As Integer = 0 To grille.ColumnCount - 1
                'Cette condition veut dire qu'on est dans le coin inférieur gauche
                If (i = grille.RowCount - 1 And j = grille.ColumnCount - 1) Then
                    chaine += "#"
                Else
                    chaine += (i * grille.ColumnCount + j + 1) & ";"
                End If
            Next
        Next

        setupButton(grille, chaine.Split(";"))


        'On mélange le taquin
        melangerTaquin()

        'Si on pas en mode illimité ou si on est en mode multi on affiche le temps
        If (Not ManagerData.prefs.getUnlimitedMode() Or modeMulti) Then
            'On lance le chrono si on est pas en mode illimité
            timeLeft.Enabled = True
            'On initialise le label du temps
            champTemps.Text = If(heureRestant <= 9, "0" & heureRestant, heureRestant) &
           ":" & If(minRestant <= 9, "0" & minRestant, minRestant) &
           ":" & If(secRestant <= 9, "0" & secRestant, secRestant)
        Else
            timeLeft.Enabled = False
            champTemps.Text = " ....."
        End If


        If modeMulti Then
            timerRefeshMulti.Enabled = True
        End If

        'Pour cette partie la personne n'a pas utilisé d'aide
        useProgramme = False

        '=====================================================================================================
        'Si on est en mode multi on doit aussi initialiser la 2ème grille 
        If (modeMulti) Then
            'On supprime tout les contrôle
            grilleAdversaire.Controls.Clear()
            grilleBackEnd.Controls.Clear()

            'On vide les tableau RowStyles et ColumnStyles qui contienne les config pour chaque colonne et ligne
            grilleAdversaire.RowStyles.Clear()
            grilleAdversaire.ColumnStyles.Clear()

            'On initialise aussi le style de la grille bacjEnd
            grilleBackEnd.RowStyles.Clear()
            grilleBackEnd.ColumnStyles.Clear()

            ' On ajoute lignes fois une nouvelle config dont la taille est jugé en pourcent 
            For i As Integer = 0 To lignes - 1
                grilleAdversaire.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / lignes))
                grilleBackEnd.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / lignes))
            Next

            ' On ajoute colonnes fois une nouvelle config dont la taille est jugé en pourcent 
            For i As Integer = 0 To colonnes - 1
                grilleAdversaire.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / colonnes))
                grilleBackEnd.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / colonnes))
            Next
            ' Fin paramétrage les bouttons pour l'adversaire se mettrons au première appel de refresh.tick


        End If
        '=====================================================================================================
        labelName.Text = ManagerData.joueur.getNom()
        Return True

    End Function
    Private Sub buttonsClick(sender As Object, e As EventArgs)

        If modeAdmin Then
            'Si on a pas cliquer on met la position du bouton dans la variable et on attent le prochain clique
            If (clickPrecedent = Nothing) Then
                clickPrecedent = grille.GetPositionFromControl(sender)
                CType(sender, Button).BackColor = Color.Red
                Exit Sub
            Else
                'On recupère le premier bouton cliquer
                Dim bouton As Button = grille.GetControlFromPosition(clickPrecedent.Column, clickPrecedent.Row)
                bouton.BackColor = Me.BackColor

                Dim positionB2 As TableLayoutPanelCellPosition = grille.GetPositionFromControl(sender)
                Dim boutton2 As Button = sender

                grille.SetRow(bouton, positionB2.Row)
                grille.SetColumn(bouton, positionB2.Column)

                grille.SetRow(boutton2, clickPrecedent.Row)
                grille.SetColumn(boutton2, clickPrecedent.Column)
                clickPrecedent = Nothing
            End If
        End If

        ' On recupère la position dans la grille de l'objet qui  a été cliquer
        Dim point As TableLayoutPanelCellPosition = getNextPosition(grille, grille.GetPositionFromControl(sender))
        If (point.Column = -1 And point.Row = -1) Then
            ' MsgBox("impossible")
            Return
        ElseIf point.Column <> -1 And point.Row <> -1 Or modeAdmin Then
            'On incrémente le nombre de coup jouer 
            ManagerData.stats.addCoupJouer()
            If (Not modeAdmin) Then
                grille.SetRow(sender, point.Row)
                grille.SetColumn(sender, point.Column)
            End If
            If (aGagner(grille)) Then


                'Si on est en mode multi on va aller inscrire son id Sur la colonne idGagant et on envoie un dernier message de configuration
                If (modeMulti) Then
                    Dim partie As Partie = ManagerData.getPartieObject(idPartie)
                    ManagerData.setWinnerPartie(idPartie, ManagerData.joueur.getId())
                    ManagerData.updateDamier(idPartie, getConfig(grille), partie.getIdJ1() = ManagerData.joueur.getId())
                    'On ajoute la mise de la partie fois 2
                    ManagerData.joueur.addArgent(partie.getMise() * 2)
                    MsgBox("Félicitation vous avez remporté " & partie.getMise() & " crédit")
                End If
                timeLeft.Enabled = False
                timerRefeshMulti.Enabled = False
                'On incrémente le nombre de partie gagner
                ManagerData.stats.addPartieGagner()
                'Si on est pas en mode illimité on voit si on a battu un nouveau record
                If (Not ManagerData.prefs.getUnlimitedMode()) Then
                    'On met à jour le meilleur temps si besoins
                    Dim tempsTotal As Integer = ManagerData.prefs.getSeconde() + ManagerData.prefs.getMin() * 60 + ManagerData.prefs.getHeures() * 3600
                    Dim temps As Integer = secRestant + minRestant * 60 + heureRestant * 3600

                    If (ManagerData.stats.getMeilleurTemps() > (tempsTotal - temps) Or ManagerData.stats.getMeilleurTemps() = -1) Then
                        ManagerData.stats.setMeilleurTemps(tempsTotal - temps)
                    End If
                End If
                'On ajoute l'argent correspond à la victoire si la personne n'a pas utilisé le programme de résolution
                If (Not useProgramme And Not modeMulti) Then
                    ManagerData.joueur.addArgent(lignes * colonnes)
                End If

                ManagerData.UpdateStats()
                ManagerData.UpdateJoueur()
                'Si on est pas en mode multi on propose de faire une autre partie
                If (Not modeMulti AndAlso MsgBox(IIf(useProgramme, "", "Félicitation Vous avez gagné " & lignes * colonnes & " crédits " & Chr(10)) & "Voulez vous rejouer ?", vbYesNo) = vbYes) Then
                    timeLeft.Enabled = Not ManagerData.prefs.getUnlimitedMode()
                    melangerTaquin()
                    secRestant = ManagerData.prefs.getSeconde()
                    minRestant = ManagerData.prefs.getMin()
                    heureRestant = ManagerData.prefs.getHeures()

                Else
                    Me.Hide()
                    MenuPrincipal.setArgent(ManagerData.joueur.getArgent())
                    ManagerData.setSetPlayerOccuper(False)
                    MenuPrincipal.actualisationDemandeDefie.Enabled = True
                    MenuPrincipal.Show()
                    Return
                End If
            End If
        End If

    End Sub

    Private Function aGagner(grille As TableLayoutPanel) As Boolean
        'On vérifie dabord que la première ligne est valide sinon la vérification d'après ne vaut rien
        'On cherche d'abord le 1 sur la ligne
        For j As Integer = 0 To grille.ColumnCount - 1
            If (grille.GetControlFromPosition(j, 0) Is Nothing) Then
                Return False
            End If

            If CType(grille.GetControlFromPosition(j, 0).Tag, Label).Text = 1 Then

                'Quand on la trouvé on va faire un parcourt circulaire jusqu'a arrivé a j-1 et véfier à chaque fois que 
                'Control(i).text + 1 = Control(i+1).text 
                Dim iteration As Integer = grille.ColumnCount - 2
                For x As Integer = 1 To iteration
                    If (grille.GetControlFromPosition((j + x) Mod grille.ColumnCount, 0) Is Nothing OrElse grille.GetControlFromPosition((j + x + 1) Mod grille.ColumnCount, 0) Is Nothing) Then
                        Return False
                    End If


                    Dim val1 As Integer = CType(grille.GetControlFromPosition((j + x) Mod grille.ColumnCount, 0).Tag, Label).Text
                    Dim val2 As Integer = CType(grille.GetControlFromPosition((j + x + 1) Mod grille.ColumnCount, 0).Tag, Label).Text
                    If val2 <> val1 + 1 Then
                        Return False
                    End If
                Next


            End If
        Next

        'On regarde pour chaque case si la case d'en dessous vaut sa valeur + le nombre de colonne
        For j As Integer = 0 To grille.ColumnCount - 1
            For i As Integer = 0 To grille.RowCount - 2

                If (grille.GetControlFromPosition(j, i) Is Nothing) Then
                    Return False
                ElseIf (grille.GetControlFromPosition(j, i + 1) Is Nothing And i + 1 = grille.RowCount - 1) Then
                    Continue For
                ElseIf (grille.GetControlFromPosition(j, i + 1) Is Nothing And i + 1 <> grille.RowCount - 1) Then
                    Return False
                End If

                Dim valeur1 As Integer = CType(grille.GetControlFromPosition(j, i).Tag, Label).Text
                Dim valeur2 As Integer = CType(grille.GetControlFromPosition(j, i + 1).Tag, Label).Text

                If (valeur2 <> valeur1 + grille.ColumnCount) Then
                    Return False
                End If

            Next
        Next

        Return True

    End Function

    'Un taquin est impossible si le niveau de mélange initiale est un nombre impair
    'Lien vidéo youtube explicative :https://www.youtube.com/watch?v=-3IsCOJieCc
    Private Function isTaquinImpossible(grille As TableLayoutPanel)

        Dim melange As Integer = 0
        'Pour chacune des cases on va regarder toute celle en dessous et voir si on en trouve une avec un chiffre plus petit
        'Si c'est le cas on augmente le niveau de mélange augmente de 1
        'On ignore à chaque fois la case vide
        For i As Integer = 0 To grille.RowCount - 1
            For j As Integer = 0 To grille.ColumnCount - 1
                If grille.GetControlFromPosition(j, i) Is Nothing Then
                    Continue For
                End If
                Dim valeur1 As Integer = CType(grille.GetControlFromPosition(j, i).Tag, Label).Text
                'On va jusqu'au bout de la ligne courante
                For jP As Integer = j + 1 To grille.ColumnCount - 1

                    If grille.GetControlFromPosition(jP, i) Is Nothing Then
                        Continue For
                    End If

                    Dim valeur2 As Integer = CType(grille.GetControlFromPosition(jP, i).Tag, Label).Text
                    If valeur1 > valeur2 Then
                        melange += 1
                    End If
                Next
                'Si on est pas sur la dernière ligne on regarde celle de en dessous
                If (i <> grille.ColumnCount - 1) Then

                    For iP As Integer = i + 1 To grille.RowCount - 1
                        For jP = 0 To grille.ColumnCount - -1
                            If grille.GetControlFromPosition(jP, iP) Is Nothing Then
                                Continue For
                            End If
                            Dim valeur2 As Integer = CType(grille.GetControlFromPosition(jP, iP).Tag, Label).Text
                            If valeur1 > valeur2 Then
                                melange += 1
                            End If
                        Next
                    Next

                End If
            Next
        Next
        Return melange Mod 2 = 1
    End Function
    Private Sub melangerTaquin()
        Randomize()
        For i As Integer = 0 To nombreMelange
            ' On choisit 2 indice aléatoire et on échange leurs texte
            Dim iStart As Integer
            Dim jStart As Integer
            Dim iEnd As Integer
            Dim jEnd As Integer

            Do
                iStart = Int(Rnd() * lignes)
                jStart = Int(Rnd() * colonnes)
            Loop While grille.GetControlFromPosition(jStart, iStart) Is Nothing
            Do
                iEnd = Int(Rnd() * lignes)
                jEnd = Int(Rnd() * colonnes)
            Loop While grille.GetControlFromPosition(jEnd, iEnd) Is Nothing



            Dim button1 As Button = grille.GetControlFromPosition(jStart, iStart)
            Dim button2 As Button = grille.GetControlFromPosition(jEnd, iEnd)


            Dim tmpL As Label = button1.Tag
            button1.Tag = button2.Tag
            button2.Tag = tmpL


            'Si on est en mode image perso on switch aussi les images
            If (ManagerData.prefs.getImagePath() <> "") Then
                Dim tmpI As Image = button1.Image
                button1.Image = button2.Image
                button2.Image = tmpI
                'Sinon on echange les Text
            Else
                Dim tmp As String = button1.Text
                button1.Text = button2.Text
                button2.Text = tmp
            End If
        Next
        'Si le taquin est résolu après le mélange on recommence

        If (aGagner(grille) Or isTaquinImpossible(grille)) Then
            melangerTaquin()
        End If


    End Sub

    Private Function setupButton(grille As TableLayoutPanel, tableauValeur As String()) As Boolean
        'Image sur laquelle on va se baser
        Dim img As Bitmap
        'Si l'utilisateur a une image en pref on charge cette images ( si c'est la grille de l'adversaire on garde la config par défaut)
        If (ManagerData.prefs.getImagePath() = "" Or grille Is grilleAdversaire Or grille Is grilleBackEnd) Then
            img = My.Resources.ResourceManager.GetObject("bloc2")
            'On désactive le bouton qui permet de voir l'image complète quand on est en mode image choisi
            btnVueC.Enabled = False
            btnVueC.Visible = False
        Else
            img = Image.FromFile(ManagerData.prefs.getImagePath())
            img = New Bitmap(img, grille.Width, grille.Height)
            'on set aussi l'image de la picture box caché (on l'utilise pour voir l'image dans le bonne ordre'
            pictureImgComplet.Image = New Bitmap(img, pictureImgComplet.Width, pictureImgComplet.Height)

            btnVueC.Enabled = True
            btnVueC.Visible = True
        End If


        For i As Integer = 0 To grille.RowCount - 1
            For j As Integer = 0 To grille.ColumnCount - 1
                'Valeur actuelle du tableau d'initialsation
                Dim chaine As String = tableauValeur(i * grille.ColumnCount + j)
                'Si la valeur en question est le # On ne met rien
                If chaine = "#" Then
                    Continue For
                End If
                'Sinon crée un nouveau bouton et on lui attribue son image
                'ainsi que la valeur qu'il porte , on le placera dans le champ tag (et eventuellement sur le texte)
                Dim button As Button = New Button()

                With button
                    .Width = grille.Width / colonnes
                    .Height = grille.Height / lignes
                    'On planque un label avec la valeur dans le Tag car on ne veut pas de texte si on est en mode image choisi
                    Dim valeur As New Label()
                    valeur.Text = chaine
                    .Tag = valeur
                    If (ManagerData.prefs.getImagePath() = "" Or grille Is grilleAdversaire Or grille Is grilleBackEnd) Then
                        'Si aucun fichier n'a été choisie dans les fichier pref
                        'On doit ici redimensionner l'image pour quelle s'affiche complétement dans le bouton
                        'On est ici obliger de le faire en 2 étapes (bizare...)
                        .Image = My.Resources.ResourceManager.GetObject("bloc2")
                        .Image = New Bitmap(button.Image, button.Width * 0.8, button.Height * 0.8)
                        .Text = chaine
                    Else
                        'Si un fichier à été choisi on découpe l'image
                        'On definit la taille du rectangle 

                        Dim blocLargeur = img.Width / colonnes
                        Dim blocHauteur = img.Height / lignes
                        Dim rect As Rectangle = New Rectangle(Math.Floor(blocLargeur * j), Math.Floor(blocHauteur * i), blocLargeur, blocHauteur)
                        .Image = img.Clone(rect, img.PixelFormat)

                    End If


                    .BackColor = Me.BackColor
                    'On change la font du texte 
                    Dim average As Single = (.Width + .Height) / 10
                    button.Font = New System.Drawing.Font("Shocard gothic", average, FontStyle.Regular)
                    button.FlatAppearance.BorderSize = 0
                End With

                'On récupère le contexte graphic du bouton


                'On ajoute le button dans la grille à x = j et y = i
                grille.Controls.Add(button, j, i)
                'On parapètre aussi les évènements onClick pour les button
                AddHandler button.Click, AddressOf buttonsClick
            Next
        Next

        Return True
    End Function

    Private Sub timeLeft_Tick(sender As Object, e As EventArgs) Handles timeLeft.Tick
        ManagerData.stats.addSecondeJouer()



        If (secRestant = 0) Then
            If minRestant > 0 Or heureRestant > 0 Then
                secRestant = 59
                If minRestant > 0 Then
                    minRestant -= 1
                Else
                    If heureRestant > 0 Then
                        minRestant = 59
                        heureRestant -= 1
                    End If
                End If
            Else
                secRestant = 0
            End If
        Else
            secRestant -= 1
        End If

        champTemps.Text = If(heureRestant <= 9, "0" & heureRestant, heureRestant) &
            ":" & If(minRestant <= 9, "0" & minRestant, minRestant) &
            ":" & If(secRestant <= 9, "0" & secRestant, secRestant)

        If secRestant = 0 And minRestant = 0 And heureRestant = 0 Then
            timeLeft.Enabled = False
            timerRefeshMulti.Enabled = False
            'Si on est en mode multi on regarde si eventellement l'adversaire n'a pas gagné sinon c'est un match nul
            If modeMulti Then
                If Not aGagner(grilleAdversaire) Then
                    ManagerData.setMatchNul(idPartie)
                    MsgBox("Match nul")
                    'On rembourse la mise
                    ManagerData.joueur.addArgent(ManagerData.getPartieObject(idPartie).getMise())
                Else
                    MsgBox("Perdu")
                    ManagerData.stats.addPartiePerdu()
                End If
            Else
                MsgBox("Perdu")
                ManagerData.stats.addPartiePerdu()
            End If


            Me.Hide()
            ManagerData.UpdateStats()
            ManagerData.UpdateJoueur()
            MenuPrincipal.setArgent(ManagerData.joueur.getArgent())
            ManagerData.setSetPlayerOccuper(False)
            MenuPrincipal.actualisationDemandeDefie.Enabled = True
            MenuPrincipal.Show()
        End If


    End Sub

    Private Sub buttonAbandonner_Click(sender As Object, e As EventArgs) Handles buttonQuit.Click

        If (MsgBox("Voulez vous vraiment abandonner ?", vbYesNo) = vbYes) Then
            'On ouvre le menuPrincipal
            Me.Hide()
            'Si on est en mode multi on va aller supprimer la ligne de la partie 
            If (modeMulti) Then
                ManagerData.cancelPartie(idPartie)
            End If
            timeLeft.Enabled = False
            timerRefeshMulti.Enabled = False
            ManagerData.stats.addAbandon()
            ManagerData.UpdateStats()
            ManagerData.UpdateJoueur()
            MenuPrincipal.setArgent(ManagerData.joueur.getArgent())
            ManagerData.setSetPlayerOccuper(False)
            MenuPrincipal.actualisationDemandeDefie.Enabled = True
            MenuPrincipal.Show()
        End If

    End Sub

    Private Sub Jeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (modeMulti) Then
            ManagerData.cancelPartie(idPartie)
        End If
        PageAccueil.Close()
    End Sub

    Private Sub Pictures_MouseHover(sender As Object, e As EventArgs) Handles buttonQuit.MouseHover, buttonAide.MouseHover
        Cursor = Cursors.Hand
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles buttonQuit.MouseLeave, buttonAide.MouseLeave
        Cursor = Cursors.Default

        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.None

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If (MsgBox("Voulez vous vraiment abandonner la partie ? ", vbYesNo) = vbYes) Then
            timeLeft.Enabled = False
            Me.Hide()
            If (modeMulti) Then
                ManagerData.cancelPartie(idPartie)
            End If
            ManagerData.stats.addAbandon()
            ManagerData.UpdateStats()
            ManagerData.UpdateJoueur()
            MenuPrincipal.actualisationDemandeDefie.Enabled = True
            MenuPrincipal.setArgent(ManagerData.joueur.getArgent())
            ManagerData.setSetPlayerOccuper(False)
            MenuPrincipal.actualisationDemandeDefie.Enabled = True
            MenuPrincipal.Show()
        End If

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles buttonAide.Click
        'Le coût à payer dépend des dimmension du tableau
        Dim cout As Integer = lignes * colonnes
        If (ManagerData.joueur.getArgent() < cout) Then
            MsgBox("Désolé vous n'avez pas assez d'argent")
            Exit Sub
        Else
            If (MsgBox("Le coût à payer est de " & cout & " crédit voulez vous continuez ?", vbYesNo) = vbYes Or modeAdmin) Then
                ManagerData.joueur.addArgent(-cout)
                'On met a jour le fichier
                ManagerData.UpdateStats()
                ManagerData.UpdateJoueur()
            Else
                Exit Sub
            End If
        End If

        'On desactive tout les controle sur la page 
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = False
        Next
        'On active l'image veuillez patientez
        patientez.Visible = True
        patientez.Enabled = True


        'Dabord tu demmarre ton process
        ProgrammeTaquin.Start()

        'Ensuite tu recup son entré dans une variable (c'est comme genre un fichier et on va écrire dedans)
        Dim inputProgram = ProgrammeTaquin.StandardInput

        'Après tu construit ta longue chaîne de caractères genre 1 2 3 4 5 #
        Dim input As String = ""

        input = lignes & " " & colonnes & " "
        'On construit la chaîne de caractètre à passer en argument
        For i As Integer = 0 To grille.RowCount - 1
            For j As Integer = 0 To grille.ColumnCount - 1

                Dim button As Button = grille.GetControlFromPosition(j, i)
                If (button Is Nothing) Then
                    input = input & "# "
                Else
                    input = input & CType(button.Tag, Label).Text & " "
                End If
            Next
        Next

        'A la fin tu écrit dans son entré standard
        inputProgram.WriteLine(input)
        'T'attend la fin
        ProgrammeTaquin.WaitForExit()

        Dim listeCoup As New ArrayList()
        'On se débarrase des 2 premères lignes
        ProgrammeTaquin.StandardOutput.ReadLine()
        ProgrammeTaquin.StandardOutput.ReadLine()

        While (Not ProgrammeTaquin.StandardOutput.EndOfStream)
            For i As Integer = 0 To lignes - 1
                'On se débarrase à chaque fois de l'affichage de la situation dans présent dans le out
                ProgrammeTaquin.StandardOutput.ReadLine()
            Next
            listeCoup.Add(ProgrammeTaquin.StandardOutput.ReadLine())
        End While

        'On réactive tout les controle sur la page 
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = True
        Next

        'On désactive l'image veuillez patientezdd
        patientez.Visible = False
        patientez.Enabled = False

        useProgramme = True
        For Each coup As String In listeCoup
            Application.DoEvents()
            Threading.Thread.Sleep(700)
            executeClick(coup)
        Next






    End Sub
    Private Sub executeClick(direction As String)
        Dim caseVide As Point = getEmptyCasePosition()

        If direction = "NORD" Then
            CType(grille.GetControlFromPosition(caseVide.X, caseVide.Y - 1), Button).PerformClick()
        ElseIf direction = "SUD" Then
            CType(grille.GetControlFromPosition(caseVide.X, caseVide.Y + 1), Button).PerformClick()
        ElseIf direction = "OUEST" Then
            CType(grille.GetControlFromPosition((caseVide.X - 1 + grille.ColumnCount) Mod grille.ColumnCount, caseVide.Y), Button).PerformClick()
        ElseIf direction = "EST" Then
            CType(grille.GetControlFromPosition((caseVide.X + 1) Mod grille.ColumnCount, caseVide.Y), Button).PerformClick()
        End If

    End Sub

    Private Function getEmptyCasePosition() As Point

        For i As Integer = 0 To grille.RowCount - 1
            For j As Integer = 0 To grille.ColumnCount - 1
                If (grille.GetControlFromPosition(j, i) Is Nothing) Then
                    Return New Point(j, i)
                End If
            Next
        Next


    End Function

    Private Sub btnVueC_Click(sender As Object, e As EventArgs) Handles btnVueC.Click
        pictureImgComplet.Visible = Not pictureImgComplet.Visible
        pictureImgComplet.Enabled = Not pictureImgComplet.Enabled
    End Sub

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgrammeTaquin.StartInfo.FileName = ManagerConstante.pathPrograme
        Me.KeyPreview = True
    End Sub

    Public Sub activeModeMulti(id As Integer)

        idPartie = id
        modeMulti = True
        'On agrandit la fênetre
        Me.Width = 1100
        Me.MaximumSize = New System.Drawing.Size(1100, Me.Height)
        Me.MinimumSize = New System.Drawing.Size(1100, Me.Height)
        'On désactive le bouton indice
        buttonAide.Enabled = False
        buttonAide.Visible = False


    End Sub


    Public Sub desactiveModeMulti()
        idPartie = -1
        modeMulti = False
        Me.Width = 700
        Me.MaximumSize = New System.Drawing.Size(700, Me.Height)
        Me.MinimumSize = New System.Drawing.Size(700, Me.Height)
        buttonAide.Enabled = True
        buttonAide.Visible = True
        timerRefeshMulti.Enabled = False

    End Sub

    Private Sub timerRefeshMulti_Tick(sender As Object, e As EventArgs) Handles timerRefeshMulti.Tick

        'Si on est mode multi on doit récuperer la configuration actuelle du taquin de l'adversaire et envoyer sa configuration
        Dim partie As Partie = ManagerData.getPartieObject(idPartie)

        'Si la partie = nothing sa veut dire que nous avons rencontré un problème (par ex : l'autre personne à quitter la partie, car la procédure quand on abandonne c'est d'aller supprimer la ligne)
        If (partie Is Nothing) Then
            'On désactive la boucle de rafraichissement
            timerRefeshMulti.Enabled = False
            timeLeft.Enabled = False
            MsgBox("Une erreur est survenue votre adversaire à probablement quité la partie")
            Me.Hide()
            ManagerData.UpdateStats()
            ManagerData.UpdateJoueur()
            MenuPrincipal.setArgent(ManagerData.joueur.getArgent())
            ManagerData.setSetPlayerOccuper(False)
            MenuPrincipal.actualisationDemandeDefie.Enabled = True
            MenuPrincipal.Show()
            Exit Sub
        End If

        'Avant de faire quoi que ce soit on regarde si la partie à été remporté par l'autre joueur
        If (aGagner(grilleAdversaire)) Then
            timeLeft.Enabled = False
            timerRefeshMulti.Enabled = False
            MsgBox("Vous avez perdu")
            ManagerData.stats.addPartiePerdu()
            Me.Hide()
            MenuPrincipal.setArgent(ManagerData.joueur.getArgent())
            ManagerData.setSetPlayerOccuper(False)
            MenuPrincipal.actualisationDemandeDefie.Enabled = True
            MenuPrincipal.Show()

        End If


        'Si notre id est celui du joueur1 on doit récuperer la config du joueur 2
        Dim config As String = ""
        If (partie.getIdJ1() = ManagerData.joueur.getId()) Then
            config = partie.getPlateauJ2()
        Else
            config = partie.getPlateauJ1()
        End If
        If (config.Count > 1) Then
            'Avant de mettre les nouveaux boutons on vide les anciens
            For i As Integer = 0 To grille.RowCount - 1
                For j As Integer = 0 To grille.ColumnCount - 1
                    grilleBackEnd.Controls.Remove(grilleBackEnd.GetControlFromPosition(j, i))
                Next
            Next
            setupButton(grilleBackEnd, config.Split(";"))
            'On utilise une grille qui ne se voit pas elle permet de charger les donnée proprement sans que l'utilisateur ne voit les cases se vider et de 
            'ReRemplir
            cpyGrille(grilleAdversaire, grilleBackEnd)
        End If


        'On va envoyer notre configuration
        'Ici on va mettre à jour la ligne de la table et le dernier paramètre permet de savoir si on est le l'hôte 
        'Si elle est valider on va mettre a jour  le damier du joueur 1  sinon celui du joueur2
        ManagerData.updateDamier(idPartie, getConfig(grille), partie.getIdJ1() = ManagerData.joueur.getId())

    End Sub

    Public Sub cpyGrille(dest As TableLayoutPanel, source As TableLayoutPanel)
        For i As Integer = 0 To dest.RowCount - 1
            For j As Integer = 0 To dest.ColumnCount - 1
                Dim bouttonSource As Button = source.GetControlFromPosition(j, i)
                Dim bouttonDest As Button = dest.GetControlFromPosition(j, i)

                'Si le bouton qui se trouve à la dest et différent de celui qui se trouve à la source on fait une rectification
                If (bouttonSource Is Nothing Or bouttonDest Is Nothing OrElse CType(bouttonDest.Tag, Label).Text <> CType(bouttonSource.Tag, Label).Text) Then
                    dest.Controls.Remove(dest.GetControlFromPosition(j, i))
                    If (Not bouttonSource Is Nothing) Then
                        dest.Controls.Add(bouttonSource, j, i)
                    End If
                End If
            Next
        Next
    End Sub

    Public Function getConfig(grille As TableLayoutPanel) As String

        Dim myConfig = ""
        For i As Integer = 0 To grille.RowCount - 1
            For j As Integer = 0 To grille.ColumnCount - 1
                Dim b As Button = grille.GetControlFromPosition(j, i)
                If (b Is Nothing) Then
                    myConfig += "#"
                Else
                    myConfig += CType(b.Tag, Label).Text
                End If

                If (Not (i = grille.RowCount - 1 And j = grille.ColumnCount - 1)) Then
                    myConfig += ";"
                End If
            Next
        Next

        Return myConfig
    End Function

    Private Sub Jeu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.D AndAlso e.Modifiers = Keys.Control) Then
            MsgBox("Mode admin " & IIf(modeAdmin, "Désactivé", "Activé"))
            modeAdmin = Not modeAdmin
            If (modeMulti) Then
                buttonAide.Visible = Not buttonAide.Visible
                buttonAide.Enabled = Not buttonAide.Enabled
            End If
        End If
    End Sub

    Private Sub Jeu_Click(sender As Object, e As EventArgs) Handles Me.Click
        If modeAdmin Then
            Dim bouton As Button = grille.GetControlFromPosition(clickPrecedent.Column, clickPrecedent.Row)
            bouton.BackColor = Me.BackColor
            clickPrecedent = Nothing
        End If
    End Sub

    Public Function getNextPosition(grille As TableLayoutPanel, current As TableLayoutPanelCellPosition) As TableLayoutPanelCellPosition
        Dim vecteurs() As Point = {New Point(1, 0), New Point(-1, 0), New Point(0, 1), New Point(0, -1)}

        Dim p As Point = New Point(current.Column, current.Row)

        For Each deplacement As Point In vecteurs

            Dim XCheck As Integer = (p.X + deplacement.X + grille.ColumnCount) Mod grille.ColumnCount
            Dim YCkeck As Integer = (p.Y + deplacement.Y)

            If (YCkeck >= grille.RowCount Or YCkeck < 0) Then
                Continue For
            End If

            If (grille.GetControlFromPosition(XCheck, YCkeck) Is Nothing) Then

                Return New TableLayoutPanelCellPosition(XCheck, YCkeck)
            End If

        Next
        Return New TableLayoutPanelCellPosition(-1, -1)
    End Function
End Class

