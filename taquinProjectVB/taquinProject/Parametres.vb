Imports System.ComponentModel

Public Class parametres


    Public changementEffectué As Boolean





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Integer.Parse(ligne.Text) >= maxDim Or Integer.Parse(colonne.Text) >= maxDim) Then
            MsgBox("La taille max est de " & maxDim)
            Return
        End If
        colonne.Text = Integer.Parse(colonne.Text) + 1
        ligne.Text = Integer.Parse(ligne.Text) + 1
        changementEffectué = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Integer.Parse(ligne.Text) <= minDim Or Integer.Parse(colonne.Text) <= minDim) Then
            MsgBox("La taille min est de " & minDim)
            Return
        End If

        colonne.Text = Integer.Parse(colonne.Text) - 1
        ligne.Text = Integer.Parse(ligne.Text) - 1
        changementEffectué = True
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
        changementEffectué = True

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
        'Si le sender est la textBox heure on arrête les controles ici
        If box Is heures Then
            Exit Sub
        End If
        If (Integer.Parse(box.Text & e.KeyChar) > 59) Then
            e.Handled = True
            Return
        End If
        changementEffectué = True
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

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim box As TextBox = ctrl
                If (box Is path And choiceDefault.Checked) Then
                    Continue For
                End If

                If (box.Text = "") Then
                    MsgBox("Veuillez comblez les champs vide")
                    Return
                End If
            End If
        Next

        If min.Text = "0" And sec.Text = "0" And heures.Text = 0 Then
            MsgBox("Veuillez renseigner une durée non nul")
            Exit Sub
        End If

        If (changementEffectué) Then
            If (MsgBox("Voulez vous sauvegarder les changements effectués", vbYesNo) = vbYes) Then

                Dim nvePrefs As New Preference(ManagerData.prefs.getID(), Integer.Parse(ligne.Text), Integer.Parse(colonne.Text), Integer.Parse(heures.Text),
                                               Integer.Parse(min.Text), Integer.Parse(sec.Text), unlimitedTime.Checked, IIf(choiceDefault.Checked, "", path.Text))

                ManagerData.updatePrefs(nvePrefs)

            End If
        End If

        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPrincipal.Close()
    End Sub

    Public Sub initPreferences()
        ligne.Text = ManagerData.prefs.getLignes()
        colonne.Text = ManagerData.prefs.getColonnes()
        sec.Text = ManagerData.prefs.getSeconde()
        min.Text = ManagerData.prefs.getMin()
        heures.Text = ManagerData.prefs.getHeures()
        unlimitedTime.Checked = ManagerData.prefs.getUnlimitedMode()
        path.Text = ManagerData.prefs.getImagePath()
        choiceDefault.Checked = path.Text = ""
        changementEffectué = False
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles unlimitedTime.CheckedChanged

        sec.ReadOnly = CType(sender, CheckBox).Checked
        min.ReadOnly = CType(sender, CheckBox).Checked
        heures.ReadOnly = CType(sender, CheckBox).Checked
        changementEffectué = True

    End Sub

    Private Sub btnFileEx_Click(sender As Object, e As EventArgs) Handles btnFileEx.Click
        fileExplorer.Filter = "|*.png; *.jpg; *.bmp"
        If fileExplorer.ShowDialog() = DialogResult.OK Then
            path.Text = fileExplorer.FileName
            changementEffectué = True
        End If
    End Sub

    Private Sub choiceDefault_CheckedChanged(sender As Object, e As EventArgs) Handles choiceDefault.CheckedChanged

        If CType(sender, CheckBox).Checked Then
            path.Enabled = False
            btnFileEx.Enabled = False
        Else
            path.Enabled = True
            btnFileEx.Enabled = True
        End If

        changementEffectué = True
    End Sub

    Private Sub path_TextChanged(sender As Object, e As EventArgs) Handles path.TextChanged
        changementEffectué = True
    End Sub

    Private Sub btnZic_Click(sender As Object, e As EventArgs) Handles btnZic.Click
        fileExplorer.Filter = "|*.mp3"
        If fileExplorer.ShowDialog() = DialogResult.OK Then
            listeMusique.Items.AddRange(fileExplorer.FileNames)
            MenuPrincipal.lecteurMp3.URL = listeMusique.Items(0)
            listeMusique.SelectedIndex = 0
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        listeMusique.Items.Remove(listeMusique.SelectedItem)
    End Sub

End Class