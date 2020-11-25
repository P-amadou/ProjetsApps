
Imports MySql.Data.MySqlClient

Module ManagerData

    Public prefs As Preference
    Public stats As Statistiques
    Public joueur As Joueur


    'On fait notre objet de connection
    Dim flux As MySqlConnection

    Public Function connect() As Boolean

        flux = New MySqlConnection("server=" & ManagerConstante.nomServeur &
                                         ";port=" & ManagerConstante.port &
                                         ";database=" & ManagerConstante.nomBDD &
                                         ";uid=" & ManagerConstante.user &
                                       ";pwd=" & ManagerConstante.pwd)

        If flux.State = ConnectionState.Open Then
            MsgBox("Déja connecter à la BDD")
            Return True
        Else
            Dim maxEssaie As Integer = 6
            Dim essaie As Integer = 1
            'Ici tant que la connection n'est pas ouverte et qu'on a pas atteint le max de tentative on tente de se connecter
            While (flux.State <> ConnectionState.Open And essaie < maxEssaie)
                Try
                    flux.Open()
                    Return True
                Catch ex As Exception
                    essaie += 1
                    Continue While
                End Try
            End While
        End If

        Return False
    End Function

    Public Function isConnect() As Boolean
        Return flux.State = ConnectionState.Open
    End Function
    Public Function disconnect() As Boolean
        If (flux.State = ConnectionState.Open) Then
            Try
                flux.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If


        Return False
    End Function


    Public Function nouvelleUser(nom As String, password As String) As Boolean

        If (flux.State = ConnectionState.Open) Then
            'On vérifie que le pseudo n'est pas déja utilisé
            Dim sqlCommand As New MySqlCommand("Select ID From Joueur where Nom=@Nom", flux)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)
            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If L.HasRows Then
                    'MsgBox("Nom d'utilisateur déja utilisé")
                    Return False
                End If

            End Using





            sqlCommand = New MySqlCommand("Insert into Joueur(Nom,Pwd) values(@Nom,@Pwd)", flux)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)
            sqlCommand.Parameters.AddWithValue("@Pwd", password)
            sqlCommand.ExecuteNonQuery()

            'On récupère l'id qui vient d'être attribuer
            sqlCommand = New MySqlCommand("Select ID From Joueur Where Nom=@nom", flux)
            sqlCommand.Parameters.AddWithValue("@nom", nom)
            'On lit ensuite la reponse
            Dim IDJoueur As Integer
            Using L As MySqlDataReader = sqlCommand.ExecuteReader()

                While L.Read()
                    IDJoueur = L("ID")
                End While
            End Using


            'On a déja mis les valeurs par défaut des paramètre lignes,colonnes ect au niveau de la BDD
            sqlCommand = New MySqlCommand("Insert into Preferences(IdJoueur) values(@IdJoueur)", flux)
            sqlCommand.Parameters.AddWithValue("@IdJoueur", IDJoueur)
            sqlCommand.ExecuteNonQuery()
            '
            'On récupère l'id qui vient d'être attribuer
            sqlCommand = New MySqlCommand("Select ID From Preferences Where IdJoueur=@IdJoueur", flux)
            sqlCommand.Parameters.AddWithValue("@IdJoueur", IDJoueur)
            'On lit ensuite la reponse
            Dim IDPref As Integer
            Using L As MySqlDataReader = sqlCommand.ExecuteReader()

                While L.Read()
                    IDPref = L("ID")
                End While
            End Using

            'On initialise aussi une ligne pour les statistque, encore une fois les valeur par défaut son déjà là
            sqlCommand = New MySqlCommand("Insert into Statistiques(IdJoueur) values(@IdJoueur)", flux)
            sqlCommand.Parameters.AddWithValue("@IdJoueur", IDJoueur)
            sqlCommand.ExecuteNonQuery()

            'On récupère l'id qui vient d'être attribuer
            sqlCommand = New MySqlCommand("Select ID From Statistiques Where IdJoueur=@IdJoueur", flux)
            sqlCommand.Parameters.AddWithValue("@IdJoueur", IDJoueur)
            'On lit ensuite la reponse
            Dim IDStats As Integer
            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                While L.Read()
                    IDStats = L("ID")
                End While
            End Using


            'Maintenant on va update les valeur de idPref et idStats dans la table Joueur
            sqlCommand = New MySqlCommand("Update Joueur Set IdPref=@IdPref,IdStats=@IdStats where ID=@ID", flux)
            sqlCommand.Parameters.AddWithValue("@IdPref", IDPref)
            sqlCommand.Parameters.AddWithValue("@IdStats", IDStats)
            sqlCommand.Parameters.AddWithValue("@ID", IDJoueur)
            sqlCommand.ExecuteNonQuery()

            MsgBox("Joueur Créé")
            Return True
        End If

        Return False
    End Function

    Public Sub updatePrefs(preference As Preference)
        prefs = preference

        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Update Preferences Set lignes=@lignes" &
                                                ",colonnes=@colonnes" &
                                                ",heures=@heures" &
                                               ",minutes=@minutes" &
                                               ",secondes=@secondes" &
                                               ",unlimited=@unlimited" &
                                               ",cheminImage=@cheminImage Where ID=@ID", flux)

            sqlCommand.Parameters.AddWithValue("@lignes", preference.getLignes())
            sqlCommand.Parameters.AddWithValue("@colonnes", preference.getColonnes())
            sqlCommand.Parameters.AddWithValue("@heures", preference.getHeures())
            sqlCommand.Parameters.AddWithValue("@minutes", preference.getMin())
            sqlCommand.Parameters.AddWithValue("@secondes", preference.getSeconde())
            sqlCommand.Parameters.AddWithValue("@unlimited", preference.getUnlimitedMode())
            sqlCommand.Parameters.AddWithValue("@cheminImage", preference.getImagePath())
            sqlCommand.Parameters.AddWithValue("@ID", preference.getID())
            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Sub UpdateStats()
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Update Statistiques Set nbPartie=@nbPartie" &
                                                ",nbLose=@nbLose" &
                                                ",nbAbandon=@nbAbandon" &
                                               ",totalSec=@totalSec" &
                                               ",nbCoup=@nbCoup" &
                                               ",meilleurTps=@meilleurTps" &
                                               ",nbPartieWin=@nbPartieWin Where ID=@ID", flux)

            sqlCommand.Parameters.AddWithValue("@nbPartie", stats.getNbPartieJouer())
            sqlCommand.Parameters.AddWithValue("@nbLose", stats.getnbPartiePerdu())
            sqlCommand.Parameters.AddWithValue("@nbAbandon", stats.getnbAbandon())
            sqlCommand.Parameters.AddWithValue("@totalSec", stats.getTotalSecJouer())
            sqlCommand.Parameters.AddWithValue("@nbCoup", stats.getnbCoupJouer())
            sqlCommand.Parameters.AddWithValue("@meilleurTps", stats.getMeilleurTemps())
            sqlCommand.Parameters.AddWithValue("@nbPartieWin", stats.getNbPartieGagner())
            sqlCommand.Parameters.AddWithValue("@ID", stats.getID())
            sqlCommand.ExecuteNonQuery()
        End If


    End Sub

    Public Sub UpdateJoueur()
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Update Joueur Set nbArgent=@nbArgent Where ID=@ID", flux)

            sqlCommand.Parameters.AddWithValue("@nbArgent", joueur.getArgent())
            sqlCommand.Parameters.AddWithValue("@ID", joueur.getId())

            sqlCommand.ExecuteNonQuery()
        End If
    End Sub




    Public Sub setSetPlayerOccuper(b As Boolean)
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Update Joueur Set estOccuper=@estOccuper Where ID=@ID", flux)

            sqlCommand.Parameters.AddWithValue("@estOccuper", b)
            sqlCommand.Parameters.AddWithValue("@ID", joueur.getId())

            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Function isOccuper(nom As String) As Boolean
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Select estOccuper From Joueur Where Nom=@Nom", flux)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()

                While L.Read()
                    Return L("estOccuper")
                End While

            End Using
        End If

        Return Nothing

    End Function


    Public Sub setPreferenceObject(Nom As String)
        If (flux.State = ConnectionState.Open) Then


            Dim idJoueur As Integer = getID(Nom)
            If (idJoueur = -1) Then
                Exit Sub
            End If

            Dim sqlCommand As New MySqlCommand("Select * From Preferences Where IdJoueur=@ID", flux)
            sqlCommand.Parameters.AddWithValue("@ID", IDJoueur)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If (L.HasRows) Then
                    While L.Read()
                        prefs = New Preference()
                        prefs.setLignes(L("lignes"))
                        prefs.setColonnes(L("colonnes"))
                        prefs.setHeure(L("heures"))
                        prefs.setMin(L("minutes"))
                        prefs.setSec(L("secondes"))
                        prefs.setModeTime(L("unlimited"))
                        If (IsDBNull(L("cheminImage"))) Then
                            prefs.setPath("")
                        Else
                            prefs.setPath(L("cheminImage"))
                        End If
                        prefs.setId(L("ID"))
                    End While
                Else
                End If
            End Using
        End If
    End Sub


    Public Sub setStatObject(Nom As String)
        stats = getStatObject(Nom)
    End Sub



    Public Function getStatObject(Nom As String) As Statistiques
        If (flux.State = ConnectionState.Open) Then

            Dim idJoueur As Integer = getID(Nom)
            If (idJoueur = -1) Then
                Return Nothing
            End If


            Dim sqlCommand As New MySqlCommand("Select * From Statistiques Where IdJoueur=@ID", flux)
            sqlCommand.Parameters.AddWithValue("@ID", idJoueur)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()

                While L.Read()
                        Return New Statistiques(L("ID"), L("nbPartie"), L("nbPartieWin"), L("nbLose"), L("nbAbandon"), L("nbCoup"), L("meilleurTps"), L("totalSec"))
                End While

            End Using
        End If

        Return Nothing
    End Function


    Public Sub setPlayerObject(nom As String)

        If (flux.State = ConnectionState.Open) Then




            Dim sqlCommand As New MySqlCommand("Select * From Joueur Where Nom=@Nom", flux)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If (L.HasRows) Then
                    While L.Read()
                        joueur = New Joueur(L("ID"), L("Nom"), L("nbArgent"))
                    End While
                Else
                End If
            End Using
        End If

    End Sub





    Public Function getPassword(nom As String) As String
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Select Pwd From Joueur Where Nom=@Nom", flux)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If (L.HasRows) Then
                    While L.Read()
                        Return L("Pwd")
                    End While
                Else
                    Return ""
                End If
            End Using
        End If

        Return ""

    End Function

    Public Function existPlayer(nom As String) As Boolean
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Select ID From Joueur Where Nom=@Nom", flux)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If (L.HasRows) Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End If

        Return False
    End Function


    Public Function getID(nom As String) As Integer

        Dim sqlCommand As New MySqlCommand("Select ID From Joueur Where Nom=@nom", flux)
        sqlCommand.Parameters.AddWithValue("@nom", nom)
        'On lit ensuite la reponse
        Using L As MySqlDataReader = sqlCommand.ExecuteReader()
            While L.Read()
                Return L("ID")
            End While
        End Using

        Return -1
    End Function



    Public Function getAllStatistique() As ArrayList
        If (flux.State = ConnectionState.Open) Then

            Dim liste As New ArrayList()
            Dim sqlCommand As New MySqlCommand("Select * From Statistique", flux)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If (L.HasRows) Then
                    While L.Read()
                        Dim statistique As New Statistiques(L("ID"), L("nbPartie"), L("nbPartieWin"), L("nbLose"), L("nbAbandon"), L("nbCoup"), L("meilleurTps"), L("totalSec"))
                        liste.Add(statistique)
                    End While
                Else
                End If
            End Using
            Return liste
        End If
        Return Nothing
    End Function


    Public Function getAllJoueurName() As ArrayList
        If (flux.State = ConnectionState.Open) Then

            Dim liste As New ArrayList()
            Dim sqlCommand As New MySqlCommand("Select Nom From Joueur", flux)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If (L.HasRows) Then
                    While L.Read()
                        liste.Add(L("Nom"))
                    End While
                Else
                End If
            End Using
            Return liste
        End If
        Return Nothing
    End Function

    Public Sub connectPlayer(nom As String)
        If (flux.State = ConnectionState.Open) Then

            Dim liste As New ArrayList()
            Dim sqlCommand As New MySqlCommand("Update Joueur set estConnecter=@value where Nom=@Nom", flux)
            sqlCommand.Parameters.AddWithValue("@value", True)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)
            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Sub disconnectPlayer(nom As String)
        If (flux.State = ConnectionState.Open) Then

            Dim liste As New ArrayList()
            Dim sqlCommand As New MySqlCommand("Update Joueur set estConnecter=@value where Nom=@Nom", flux)
            sqlCommand.Parameters.AddWithValue("@value", False)
            sqlCommand.Parameters.AddWithValue("@Nom", nom)
            sqlCommand.ExecuteNonQuery()
            'On met la valeur de joueur à nothing car on le déconnecte  
            joueur = Nothing
        End If
    End Sub

    Public Function getPlayerConnected() As ArrayList
        If (flux.State = ConnectionState.Open) Then

            Dim liste As New ArrayList()
            Dim sqlCommand As New MySqlCommand("Select * From Joueur where estConnecter=@value", flux)
            sqlCommand.Parameters.AddWithValue("@value", True)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                While L.Read()
                    liste.Add(New Joueur(L("ID"), L("Nom"), L("nbArgent")))
                End While
                Return liste
            End Using
        End If
        Return Nothing

    End Function

    'Renvoie une pair (idDéfie,idJoueur1)
    Public Function hasDefie(nom As String) As Integer()
        If (flux.State = ConnectionState.Open) Then


            'On regarde si on il n'y a pas de ligne avec notre id dessus et qui n'est pas fini
            Dim sqlCommand As New MySqlCommand("Select * From Partie where Idj2=@value and Idgagant IS NULL and accepter=@accepter And refuser=@refuser", flux)
            sqlCommand.Parameters.AddWithValue("@value", joueur.getId())
            sqlCommand.Parameters.AddWithValue("@accepter", False)
            sqlCommand.Parameters.AddWithValue("@refuser", False)


            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                If L.HasRows Then
                    While L.Read()
                        Return New Integer() {L("IdPartie"), L("IdJ1")}
                    End While
                End If
            End Using
        End If
        Return New Integer() {-1, -1}
    End Function

    Public Sub sendDefie(idAdversaire As Integer, lignes As Integer, colonnes As Integer, heures As Integer, minute As Integer, seconde As Integer, mise As Integer)
        If (flux.State = ConnectionState.Open) Then
            'Les variables heures,minutes,secondes concerne le temps accordé pour la partie

            'On regarde si on il n'y a pas de ligne avec notre id dessus et qui n'est pas fini
            Dim sqlCommand As New MySqlCommand("Insert into Partie(IdJ1,Idj2,heures,minutes,secondes,lignes,colonnes,mise) " &
                                                                   "values(@idj1,@idj2,@heures,@minutes,@secondes,@lignes,@colonnes,@mise)", flux)
            sqlCommand.Parameters.AddWithValue("@idj1", joueur.getId())
            sqlCommand.Parameters.AddWithValue("@idj2", idAdversaire)
            sqlCommand.Parameters.AddWithValue("@heures", heures)
            sqlCommand.Parameters.AddWithValue("@minutes", minute)
            sqlCommand.Parameters.AddWithValue("@secondes", seconde)
            sqlCommand.Parameters.AddWithValue("@lignes", lignes)
            sqlCommand.Parameters.AddWithValue("@colonnes", colonnes)
            sqlCommand.Parameters.AddWithValue("@mise", mise)

            sqlCommand.ExecuteNonQuery()
        End If

    End Sub


    Public Function getNom(Id As Integer) As String
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Select Nom From Joueur where ID=@id", flux)
            sqlCommand.Parameters.AddWithValue("@id", Id)

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()

                If (L.HasRows) Then
                    While L.Read()
                        Return L("Nom")
                    End While
                End If
            End Using
        End If

        Return Nothing
    End Function


    'Fonction qui va aller accepter ou refuser un défie
    Public Sub setDefieStatus(idPartie As Integer, b As Boolean)
        If (flux.State = ConnectionState.Open) Then
            'On va aller mettre le flag refuser ou valider a vrai et aussi mettre la colonne valider à vraie pour notifier qu'on a vu la demande
            Dim sqlCommand As New MySqlCommand("Update Partie set " & IIf(b, "accepter=@value", "refuser=@value") & " where IdPartie=@idPartie", flux)
            sqlCommand.Parameters.AddWithValue("@value", True)
            sqlCommand.Parameters.AddWithValue("@idPartie", idPartie)
            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Function isDemandeAccepter(idPartie As Integer) As Integer
        If (flux.State = ConnectionState.Open) Then
            'On va regarder les enregistrements qui porte notre id dans Idj1 et qui n'ont pas encore été valider par nous 
            Dim sqlCommand As New MySqlCommand("Select * From Partie where IdPartie=@idP ", flux)
            sqlCommand.Parameters.AddWithValue("@idP", idPartie)

            sqlCommand.ExecuteNonQuery()

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                While L.Read()
                    If (L("accepter")) Then
                        Return 1
                    ElseIf (L("refuser")) Then
                        Return 0
                    End If
                End While
            End Using

        End If
        Return -1
    End Function


    Public Sub SetVuDemande(idPartie As Integer)
        If (flux.State = ConnectionState.Open) Then
            'On va regarder les enregistrements qui porte notre id dans Idj1 et qui n'ont pas encore été valider par nous 
            Dim sqlCommand As New MySqlCommand("Update Partie set valider=@value where IdPartie=@id", flux)
            sqlCommand.Parameters.AddWithValue("@value", True)
            sqlCommand.Parameters.AddWithValue("@id", idPartie)

            sqlCommand.ExecuteNonQuery()



        End If
    End Sub

    Public Function getidDefisDemander(idAdversaire As Integer) As Integer
        If (flux.State = ConnectionState.Open) Then
            'On  recherche un enregistrement qui porte l'id de l'adversaire et le notre et qui n'a pas encore eu de reponse (acceter et valider = false) et que l'on n'a pas valider
            Dim sqlCommand As New MySqlCommand("Select IdPartie From Partie Where IdJ1=@j1 AND IdJ2=@j2 AND accepter=@value AND refuser=@value AND valider=@value", flux)
            sqlCommand.Parameters.AddWithValue("@j1", joueur.getId())
            sqlCommand.Parameters.AddWithValue("@j2", idAdversaire)
            sqlCommand.Parameters.AddWithValue("@value", False)

            sqlCommand.ExecuteNonQuery()

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()
                While L.Read()
                    Return L("IdPartie")
                End While
            End Using

        End If
        Return -1

    End Function


    Public Function getPartieObject(id As Integer) As Partie

        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommmand As New MySqlCommand("Select * from Partie where IdPartie=@id", flux)
            sqlCommmand.Parameters.AddWithValue("@id", id)
            sqlCommmand.ExecuteNonQuery()

            Using L As MySqlDataReader = sqlCommmand.ExecuteReader()
                While L.Read()
                    Dim idPartie As Integer = L("IdPartie")
                    Dim idJ1 As Integer = L("IdJ1")
                    Dim idJ2 As Integer = L("Idj2")
                    Dim plateauJ1 As String = L("damierJ1")
                    Dim plateauJ2 As String = L("damierJ2")
                    Dim lignes As Integer = L("lignes")
                    Dim colonnes As Integer = L("colonnes")
                    Dim heures As Integer = L("heures")
                    Dim minutes As Integer = L("minutes")
                    Dim secondes As Integer = L("secondes")
                    Dim mise As Integer = L("mise")
                    Return New Partie(idPartie, idJ1, idJ2, plateauJ1, plateauJ2, lignes, colonnes, heures, minutes, secondes, mise)
                End While


            End Using
        End If
        Return Nothing
    End Function


    Public Sub updateDamier(idPartie As Integer, config As String, isHote As Boolean)
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Update Partie set " & IIf(isHote, "damierJ1=@config", "damierJ2=@config") & " where IdPartie=@id", flux)
            sqlCommand.Parameters.AddWithValue("@config", config)
            sqlCommand.Parameters.AddWithValue("@id", idPartie)
            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Sub setWinnerPartie(idPartie As Integer, idG As Integer)
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Update Partie set Idgagant=@idG where IdPartie=@id", flux)
            sqlCommand.Parameters.AddWithValue("@idG", idG)
            sqlCommand.Parameters.AddWithValue("@id", idPartie)
            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Sub cancelPartie(id As Integer)
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Delete From Partie where IdPartie=@id", flux)
            sqlCommand.Parameters.AddWithValue("@id", id)
            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Sub setMatchNul(id As Integer)
        If (flux.State = ConnectionState.Open) Then

            Dim sqlCommand As New MySqlCommand("Update Partie set matchNul=@value where IdPartie=@id", flux)
            sqlCommand.Parameters.AddWithValue("@id", id)
            sqlCommand.Parameters.AddWithValue("@value", True)
            sqlCommand.ExecuteNonQuery()
        End If
    End Sub

    Public Function isConnected(nom As String) As Boolean
        If (flux.State = ConnectionState.Open) Then
            Dim sqlCommand As New MySqlCommand("Select estConnecter From Joueur Where Nom=@value", flux)
            sqlCommand.Parameters.AddWithValue("value", nom)
            sqlCommand.ExecuteNonQuery()


            Using L As MySqlDataReader = sqlCommand.ExecuteReader()

                While L.Read()
                    Return L("estConnecter")
                End While
            End Using
        End If
        Return Nothing
    End Function

    Public Function getPartieEnCours() As ArrayList

        If (flux.State = ConnectionState.Open) Then
            Dim sqlCommand As New MySqlCommand("Select * From Partie Where Idgagant IS NULL and matchNul=@value", flux)
            sqlCommand.Parameters.AddWithValue("value", False)
            sqlCommand.ExecuteNonQuery()
            Dim liste As New ArrayList()

            Using L As MySqlDataReader = sqlCommand.ExecuteReader()

                While L.Read()
                    Dim idPartie As Integer = L("IdPartie")
                    Dim idJ1 As Integer = L("IdJ1")
                    Dim idJ2 As Integer = L("Idj2")
                    Dim plateauJ1 As String = L("damierJ1")
                    Dim plateauJ2 As String = L("damierJ2")
                    Dim lignes As Integer = L("lignes")
                    Dim colonnes As Integer = L("colonnes")
                    Dim heures As Integer = L("heures")
                    Dim minutes As Integer = L("minutes")
                    Dim secondes As Integer = L("secondes")
                    Dim mise As Integer = L("mise")
                    liste.Add(New Partie(idPartie, idJ1, idJ2, plateauJ1, plateauJ2, lignes, colonnes, heures, minutes, secondes, mise))
                End While
                Return liste
            End Using
        End If
        Return Nothing

    End Function
End Module
