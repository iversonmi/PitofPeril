Public Class PitofPeril

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSecretName As String = "Michael"
        Dim strNameGuess As String = Me.txtNameGuess.Text
        Dim strSecretQuest As String = "I seek the Holy Grail."
        Dim strQuestGuess As String = Me.txtQuestGuess.Text
        Dim strSecretColor As String = "Green"
        Dim strColorGuess As String = Me.txtColorGuess.Text

        If strSecretName = strNameGuess Then
            Me.lblQ1Answer.Text = "You are correct!"
        Else
            Me.lblQ1Answer.Text = "You Die!"
        End If

        If strSecretQuest = strQuestGuess Then
            Me.lblQ2Answer.Text = "You are correct!"
        Else
            Me.lblQ2Answer.Text = "You Die!"
        End If

        If strSecretColor = strColorGuess Then
            Me.lblQ3Answer.Text = "You are correct! You may cross the Bridge of Death!"
        Else
            Me.lblQ3Answer.Text = "You Die!"
        End If


    End Sub
End Class
