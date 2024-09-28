Public Class GameEndForm
    Function CreateCongratsLabel(winner As Integer) As String
        Dim label As String
        'create congrats message
        label = "Congratulations "
        If winner = 1 Then
            'concatenate player 1
            label = label + "Player 1. "
        ElseIf winner = 2 Then
            'concatenate player 2
            label = label + "Player 2. "
        End If
        ' concatenate you won
        label = label + "YOU HAVE WON!"
        'return as full message
        Return label
    End Function

    Private Sub GameEndRestartButton_Click(sender As Object, e As EventArgs) Handles GameEndRestartButton.Click
        Me.Close()
    End Sub

    Private Sub GameEndForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Display Player Score
        Player1ScoreLabel.Text = $"{CheckPlayerScore(1)}"
        Player2ScoreLabel.Text = $"{CheckPlayerScore(2)}"
        If GameEnd() = 1 Then
            'player 1 won display placement labels
            Player1PlacementLabel.Text = "1st"
            Player2PlacementLabel.Text = "2nd"
            'display congrats label
            CongratsLabel.Text = CreateCongratsLabel(1)
        ElseIf GameEnd() = 2 Then
            'player 2 won display placement labels
            Player1PlacementLabel.Text = "2nd"
            Player2PlacementLabel.Text = "1st"
            'display congrats label
            CongratsLabel.Text = CreateCongratsLabel(2)
        Else
            'its a tie
            Player1PlacementLabel.Text = "1st"
            Player2PlacementLabel.Text = "1st"
            CongratsLabel.Text = "This Game Ended In a Tie! You are both winners!"
        End If
    End Sub

End Class