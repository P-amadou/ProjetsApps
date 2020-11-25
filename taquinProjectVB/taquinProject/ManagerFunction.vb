Module ManagerFunction

    Dim vecteurs() As Point = {New Point(1, 0), New Point(-1, 0), New Point(0, 1), New Point(0, -1)}
    Public Function getNextPosition(grille As TableLayoutPanel, current As TableLayoutPanelCellPosition) As TableLayoutPanelCellPosition

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
End Module
