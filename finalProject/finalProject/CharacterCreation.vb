Public Class CharacterCreation

   
   
    Private Sub btnCcContinue_Click(sender As Object, e As EventArgs) Handles btnCcContinue.Click
        Dim box = New lairOfDench
        box.Show()
        Me.Close()

    End Sub

    Private Sub btnCharacter_Click(sender As Object, e As EventArgs) Handles btnCharacter.Click
        btnCcContinue.Visible = True
        lblCharacter.Visible = True
        lblCharacter.Text = "You are playing as a " + cboSex.Text + " " + cboRace.Text +
            ". You are " + cboAge.Text + ". And you are terrifying. When you were little, you " +
            "came out of your mother with flailing arms and legs. Your favorite weapon to wield is " + cboWeapons.Text + ". You run around with (an) " + cboArmor.Text + ". Your favorite style of combat is " + cboClass.Text + "."
    End Sub
End Class