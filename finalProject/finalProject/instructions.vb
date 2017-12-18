Public Class instructions

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Close()
        Dim box = New CharacterCreation
        box.Show()

    End Sub
End Class