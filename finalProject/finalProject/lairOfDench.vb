Public Class lairOfDench

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timeLeft.Tick

        Dim timeLeft As New Integer
        If timeLeft > 0 Then
            timeLeft = timeLeft - 1000
            lblTime.Text = timeLeft.ToString + " seconds left."

        Else
            lblTime.Text = "Time's Up!"
            MessageBox.Show("You didn't finish in time you idiot. He turned you into a failure pancake.")
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWarCry.Click

    End Sub
End Class