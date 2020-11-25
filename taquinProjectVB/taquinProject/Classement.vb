Imports System.ComponentModel

Public Class Classement
    Dim ArrListeNom As New ArrayList
    Dim ArrListeTemps As New ArrayList



    Public Sub setListes()
        'On netoie les 2 listes

        ArrListeNom.Clear()
        ArrListeTemps.Clear()


        ArrListeNom = ManagerData.getAllJoueurName()

        For Each nom As String In ArrListeNom
            Dim statis As Statistiques = ManagerData.getStatObject(nom)
            ArrListeTemps.Add(IIf(statis.getMeilleurTemps() = -1, "Indéfinie", statis.getMeilleurTemps()))
        Next

        trieLexicographique()

        champSens.SelectedIndex = 0
        champSens.Tag = 0

        champFacteurTrie.SelectedIndex = 0
        champFacteurTrie.Tag = 0
        trieLexicographique()
        If (Not listeNom.DataSource Is Nothing) Then
            bindListeNom()
        End If
        If (Not listeTemps.DataSource Is Nothing) Then
            bindListeTemps()
        Else
            listeNom.DataSource = ArrListeNom
            listeTemps.DataSource = ArrListeTemps
        End If


    End Sub


    Private Sub Classement_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PageAccueil.Close()
    End Sub

    Private Sub Pictures_MouseHover(sender As Object, e As EventArgs) Handles buttonHome.MouseHover
        Cursor = Cursors.Hand
        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles buttonHome.MouseLeave
        Cursor = Cursors.Default

        Dim box As PictureBox = sender
        box.BorderStyle = BorderStyle.None

    End Sub

    Private Sub buttonHome_Click(sender As Object, e As EventArgs) Handles buttonHome.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub champFacteurTrie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles champFacteurTrie.SelectedIndexChanged

        Dim combo As ComboBox = sender
        If (combo.SelectedIndex = combo.Tag) Then
            Exit Sub
        Else
            combo.Tag = combo.SelectedIndex
        End If

        If combo.SelectedIndex = 0 Then
            trieLexicographique()
        Else
            trieTemps()
        End If

        bindListeNom()
        bindListeTemps()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        champRecherche.Text = champRecherche.Text.Trim()

        If champRecherche.Text = "" Then
            MsgBox("Le champ est vide!")
            Return
        End If

        Dim indice = listeNom.FindString(champRecherche.Text)
        If indice = -1 Then
            MsgBox("Aucun résultat")
        Else
            listeNom.SelectedIndex = indice
            listeTemps.SelectedIndex = indice
        End If

    End Sub

    Private Sub liste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listeNom.SelectedIndexChanged, listeTemps.SelectedIndexChanged
        Dim box As ListBox = CType(sender, ListBox)
        If (box.SelectedIndex = -1) Then
            boutonDetail.Enabled = False
            Return
        End If
        If box.SelectedIndex < listeTemps.Items.Count Then
            listeTemps.SelectedIndex = box.SelectedIndex
        End If

        If box.SelectedIndex < listeTemps.Items.Count Then
            listeNom.SelectedIndex = box.SelectedIndex
        End If


        champRecherche.Text = listeNom.Items(box.SelectedIndex)
        boutonDetail.Enabled = True
    End Sub


    'Ici
    Private Sub trieLexicographique()

        For i As Integer = 0 To ArrListeNom.Count - 1
            For j As Integer = 0 To ArrListeNom.Count - 2
                'On trie selon le tableau de nom

                If (ArrListeNom.Item(j) > ArrListeNom.Item(j + 1)) Then
                    Dim tmp = ArrListeNom.Item(j)
                    ArrListeNom.Item(j) = ArrListeNom.Item(j + 1)
                    ArrListeNom.Item(j + 1) = tmp

                    tmp = ArrListeTemps.Item(j)
                    ArrListeTemps.Item(j) = ArrListeTemps.Item(j + 1)
                    ArrListeTemps.Item(j + 1) = tmp

                End If
            Next
        Next

        If champSens.SelectedIndex = 1 Then
            ArrListeNom.Reverse()
            ArrListeTemps.Reverse()
        End If


    End Sub

    'Et Ici 
    Private Sub trieTemps()

        For i As Integer = ArrListeTemps.Count - 1 To 1 Step -1
            For j As Integer = 0 To i - 1

                If (ArrListeTemps.Item(j).ToString() = "Indéfinie") Then
                    Continue For
                End If

                If (ArrListeTemps.Item(j + 1).ToString() = "Indéfinie" OrElse ArrListeTemps.Item(j + 1) > ArrListeTemps.Item(j)) Then
                    'On trie selon le tableau de temps
                    Dim tmp = ArrListeNom.Item(j)
                    ArrListeNom.Item(j) = ArrListeNom.Item(j + 1)
                    ArrListeNom.Item(j + 1) = tmp

                    tmp = ArrListeTemps.Item(j)
                    ArrListeTemps.Item(j) = ArrListeTemps.Item(j + 1)
                    ArrListeTemps.Item(j + 1) = tmp

                End If
            Next
        Next


        If champSens.SelectedIndex = 1 Then
            ArrListeNom.Reverse()
            ArrListeTemps.Reverse()
        End If


    End Sub

    Private Sub bindListeNom()
        listeNom.SelectedIndex = 0
        listeNom.DataSource = Nothing
        listeNom.DataSource = ArrListeNom
    End Sub

    Private Sub bindListeTemps()
        listeTemps.SelectedIndex = 0
        listeTemps.DataSource = Nothing
        listeTemps.DataSource = ArrListeTemps
    End Sub

    Private Sub champSens_SelectedIndexChanged(sender As Object, e As EventArgs) Handles champSens.SelectedIndexChanged
        Dim combo As ComboBox = sender
        If (combo.SelectedIndex = combo.Tag) Then
            Exit Sub
        Else
            combo.Tag = combo.SelectedIndex
        End If


        ArrListeTemps.Reverse()
        bindListeTemps()

        ArrListeNom.Reverse()
        bindListeNom()
    End Sub

    Private Sub listeNom_DoubleClick(sender As Object, e As EventArgs) Handles listeNom.DoubleClick, listeTemps.DoubleClick
        boutonDetail.PerformClick()
    End Sub

    Private Sub boutonDetail_Click(sender As Object, e As EventArgs) Handles boutonDetail.Click
        Dim nom As String = listeNom.Items(listeNom.SelectedIndex)
        MsgBox(ManagerData.getStatObject(nom).toString())
    End Sub

    Private Sub champFacteurTrie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles champFacteurTrie.KeyPress, champSens.KeyPress
        e.Handled = True
    End Sub
End Class