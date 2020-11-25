Module ManagerObject

    Public Class Joueur
        Private Id As Integer
        Private nom As String
        Private nbArgent As Integer

        Public Sub New(idJ As Integer, n As String, nbA As Integer)
            Id = idJ
            nom = n
            nbArgent = nbA
        End Sub

        Public Function getId() As Integer
            Return Id
        End Function

        Public Function getNom() As String
            Return nom
        End Function

        Public Function getArgent() As Integer
            Return nbArgent
        End Function

        Public Sub addArgent(a As Integer)
            nbArgent += a
        End Sub

        Public Sub setNom(s As String)
            nom = s
        End Sub



    End Class
    Public Class Preference
        Private ID As Integer
        Private nom As String
        Private lignes As Integer
        Private colonnes As Integer
        Private heures As Integer
        Private minutes As Integer
        Private secondes As Integer
        Private unlimited As Boolean
        Private imagePath As String

        Public Sub New(IdPref As Integer, l As Integer, c As Integer, h As Integer, m As Integer, sec As Integer, illimite As Boolean, pathImage As String)
            ID = IdPref
            lignes = l
            colonnes = c
            heures = h
            minutes = m
            secondes = sec
            unlimited = illimite
            imagePath = pathImage
        End Sub

        Public Sub New()
            lignes = 0
            colonnes = 0
            heures = 0
            minutes = 0
            secondes = 0
            unlimited = False
        End Sub


        Public Function getLignes() As Integer
            Return lignes
        End Function
        Public Function getColonnes() As Integer
            Return colonnes
        End Function
        Public Function getHeures() As Integer
            Return heures
        End Function
        Public Function getMin() As Integer
            Return minutes
        End Function
        Public Function getSeconde() As Integer
            Return secondes
        End Function

        Public Function getImagePath() As String
            Return imagePath
        End Function
        Public Function getUnlimitedMode() As Boolean
            Return unlimited
        End Function

        Public Function getID() As Integer
            Return ID
        End Function

        Public Sub setId(Ident As Integer)
            ID = Ident
        End Sub
        Public Sub setModeTime(b As Boolean)
            unlimited = b
        End Sub

        Public Sub setLignes(v As Integer)
            lignes = v
        End Sub

        Public Sub setColonnes(v As Integer)
            colonnes = v
        End Sub

        Public Sub setHeure(v As Integer)
            heures = v
        End Sub

        Public Sub setMin(v As Integer)
            minutes = v
        End Sub

        Public Sub setSec(v As Integer)
            secondes = v
        End Sub

        Public Sub setPath(s As String)
            imagePath = s
        End Sub
    End Class


    Public Class Statistiques

        Private ID As Integer
        Private nbPartie As Integer
        Private nbPartieGagner As Integer
        Private nbPartiePerdu As Integer

        Private nbAbandon As Integer
        Private totalSecJouer As Integer
        Private nombreCoup As Integer

        Private meilleurTemps As Integer


        Public Sub New(idd As Integer, nbP As Integer, nbPG As Integer, nbPP As Integer, nbA As Integer, nbC As Integer, nbMt As Integer, nbTJ As Integer)
            ID = idd
            nbPartie = nbP
            nbPartieGagner = nbPG
            nbPartiePerdu = nbPP
            nbAbandon = nbA
            nombreCoup = nbC
            meilleurTemps = nbMt
            totalSecJouer = nbTJ
        End Sub



        Public Overrides Function toString() As String

            Return "ID :" & ID & Chr(10) & Chr(13) &
                "Nombre de parties: " & nbPartie & Chr(10) & Chr(13) &
                "Nombre de parties gagnées: " & nbPartieGagner & Chr(10) & Chr(13) &
                "Nombre parties perdues: " & nbPartiePerdu & Chr(10) & Chr(13) &
                "Nombre Abandons: " & nbAbandon & Chr(10) & Chr(13) &
                "Nombre de coups: " & nombreCoup & Chr(10) & Chr(13) &
                "Meilleur temps: " & IIf(meilleurTemps = -1, "Indéfini", meilleurTemps & " sec") & Chr(10) & Chr(13) &
                "Nombre de sec jouées: " & totalSecJouer

        End Function


        Public Sub addPartieJouer()
            nbPartie += 1
        End Sub

        Public Sub setMeilleurTemps(nveTps As Integer)
            meilleurTemps = nveTps
        End Sub
        Public Sub addCoupJouer()
            nombreCoup += 1
        End Sub

        Public Sub addPartiePerdu()
            nbPartiePerdu += 1
        End Sub

        Public Sub addPartieGagner()
            nbPartieGagner += 1
        End Sub

        Public Sub addAbandon()
            nbAbandon += 1
        End Sub

        Public Sub addSecondeJouer()
            totalSecJouer += 1
        End Sub


        Public Function getMeilleurTemps() As Integer
            Return meilleurTemps
        End Function

        Public Function getNbPartieGagner() As Integer
            Return nbPartieGagner
        End Function

        Public Function getnbCoupJouer() As Integer
            Return nombreCoup
        End Function

        Public Function getnbPartiePerdu() As Integer
            Return nbPartiePerdu
        End Function


        Public Function getnbAbandon() As Integer
            Return nbAbandon
        End Function

        Public Function getNbPartieJouer() As Integer
            Return nbPartie
        End Function


        Public Function getTotalSecJouer() As Integer
            Return totalSecJouer
        End Function

        Public Function getID() As Integer
            Return ID
        End Function
    End Class


    Public Class Partie

        Private ID As Integer
        Private lignes As Integer
        Private colonnes As Integer
        Private idJ1 As Integer
        Private idJ2 As Integer

        Private plateauJ1 As String
        Private plateauJ2 As String

        Private heures As Integer
        Private minutes As Integer
        Private secondes As Integer
        Private mise As Integer

        Public Sub New(IDP As Integer, id1 As Integer, id2 As Integer, plateau1 As String, plateau2 As String, l As Integer, c As Integer, h As Integer, m As Integer, s As Integer, mis As Integer)
            ID = IDP
            plateauJ1 = plateau1
            plateauJ2 = plateau2
            idJ1 = id1
            idJ2 = id2
            lignes = l
            colonnes = c
            heures = h
            minutes = m
            secondes = s
            mise = mis
        End Sub

        Public Function getId() As Integer
            Return ID
        End Function

        Public Function getlignes() As Integer
            Return lignes
        End Function

        Public Function getColonnes() As Integer
            Return colonnes
        End Function

        Public Function getHeures() As Integer
            Return heures
        End Function

        Public Function getMinute() As Integer
            Return minutes
        End Function


        Public Function getSeconde() As Integer
            Return secondes
        End Function

        Public Function getIdJ1() As Integer
            Return idJ1
        End Function


        Public Function getIdJ2() As Integer
            Return idJ2
        End Function

        Public Function getPlateauJ1() As String
            Return plateauJ1
        End Function

        Public Function getPlateauJ2() As String
            Return plateauJ2
        End Function

        Public Function getMise() As Integer
            Return mise
        End Function


        Public Overrides Function toString() As String
            Return "lignes du taquin: " & lignes & Chr(10) & Chr(13) &
                "colonnes du taquin: " & colonnes & Chr(10) & Chr(13) &
                "Temps : " & heures & "h " & minutes & "min " & secondes & "sec" & Chr(10) & Chr(13) &
                "Mise :" & mise
        End Function

    End Class


End Module

