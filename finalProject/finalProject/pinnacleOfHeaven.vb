Public Class pinnacleOfHeaven

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim box = New runningAway
        box.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPunch.Click
        MessageBox.Show("I think you should think about your actions. You just went to punch a 20ft tall demon that can breathe fire, and destroy crusaders. Returning to the main menu...")
        Me.Close()

    End Sub

    Private Sub btnKamehameha_Click(sender As Object, e As EventArgs) Handles btnKamehameha.Click
        Dim box = New kamehameha
        box.Show()

    End Sub

    Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click
        MessageBox.Show("You can't fight a demon")
        Me.Close()
    End Sub

    Private Sub btnMeme_Click(sender As Object, e As EventArgs) Handles btnMeme.Click
        Dim box = New
    End Sub
End Class