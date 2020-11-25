Imports System.ComponentModel

Public Class Statistique


    Dim pathStats As String
    Private Sub Statistique_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PageAccueil.Close()
    End Sub

    Private Sub buttonHome_Click(sender As Object, e As EventArgs) Handles buttonHome.Click
        Me.Hide()
        MenuPrincipal.Show()

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

    Public Sub initStatistiques()
        nbPartie.Text = ManagerData.stats.getNbPartieJouer()
        nbLose.Text = ManagerData.stats.getnbPartiePerdu()
        nbQuit.Text = ManagerData.stats.getnbAbandon()
        nbWin.Text = ManagerData.stats.getNbPartieGagner()
        coup.Text = ManagerData.stats.getnbCoupJouer()
        meilleursTps.Text = IIf(ManagerData.stats.getMeilleurTemps() = -1, "Non définie", ManagerData.stats.getMeilleurTemps() & " sec")
        time.Text = ManagerData.stats.getTotalSecJouer() & " sec "
    End Sub
End Class