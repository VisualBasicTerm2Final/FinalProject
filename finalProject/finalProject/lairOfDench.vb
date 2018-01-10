Public Class lairOfDench

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWarCry.Click
        MessageBox.Show("Dench laughed in your face with his gutteral tone and pulled out his mace, only minorly threatened by your attempts.")
    End Sub

    Private Sub lairOfDench_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnAcceptYourFate_Click(sender As Object, e As EventArgs) Handles btnAcceptYourFate.Click
        MessageBox.Show("The mighty orc slaps you in the face with his hammer. You have failed. Returning to the main menu...")
        Me.Close()

    End Sub

    Private Sub btnRunPast_Click(sender As Object, e As EventArgs) Handles btnRunPast.Click
        MessageBox.Show("He smashes his foot down in front of you. You cannot escape this.")
    End Sub

    Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click
        MessageBox.Show("Those muscles were all for show. He used those inflatable muscle sleeves from season 1 episode 22 on Spongebob Squarepants. You may proceed, master.")
        Me.Close()
        Dim box = New prolouge
        box.Show()
    End Sub

    Private Sub btnInsultHim_Click(sender As Object, e As EventArgs) Handles btnInsultHim.Click

        MessageBox.Show("Wow you made him cry. He says in a somber tone. You shall pass. He looks aways, trying to hold back the tears. SCRUB!")
        Me.Close()
        Dim box = New prolouge
        box.Show()
    End Sub

End Class