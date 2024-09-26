'Zachary Christensen
'Fall 2024; 09/22/24
'Card Game of War GUI Form
'https://github.com/Minidude140/GameOfWar

'This Form Handles the GUI Input and Output to and from the User

'TODO
'[]Graphics for Deck
'**[]Display Deck Full
'**[]Display Deck Empty
'[]Graphics for Player Cards
'**[]Display Back of Cards When Drawn
'**[]Display Cards Shown
'**[]Display Cards Won (Stack)
'[]User input
'**[]Player 1 Draw Card Button
'**[]Player 2 Draw Card Button
'**[]SHow Hands Button
'**[*]Reset Game Button
'[]Game End Screen
'[]About Form
'[]Menu Strips
'[]Tool Tips
'[]Tab Stops

Public Class GameGUIForm
    Sub ResetGUI()
        'Allow player 1 to draw a card
        Player1Button.Enabled = True
        'Disable Player 2 drawing a card and Showing Cards
        Player2Button.Enabled = False
        ShowCardsButton.Enabled = False
        'Reset player score labels
        Player1ScoreLabel.Text = "0"
        Player2ScoreLabel.Text = "0"
        'Reset Remaining number of cards
        CardsLeftLabel.Text = $"{52 - CardCount()}"
    End Sub
    Private Sub GameGUIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset Game Mechanics (card deck and scores)
        ResestGame()
        'Reset GUI (Player Labels and cards left)
        ResetGUI()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub ResetGameButton_Click(sender As Object, e As EventArgs) Handles ResetGameButton.Click
        'Reset Game Mechanics (card deck and scores)
        ResestGame()
        'Reset GUI (Player Labels and cards left)
        ResetGUI()
    End Sub

    Private Sub Player1Button_Click(sender As Object, e As EventArgs) Handles Player1Button.Click
        'Draw a card and give to player 1
        GivePlayerCard(1, DrawCard())
        'Decrement the number of cards remaining and update label
        CardsLeftLabel.Text = $"{52 - CardCount()}"
        'Display Player 1's card
        Player1CardLabel.Text = $"{playerHands(0, 0)}  {playerHands(0, 1)}"
        'Allow player 2 to draw a card
        Player1Button.Enabled = False
        Player2Button.Enabled = True
    End Sub

    Private Sub Player2Button_Click(sender As Object, e As EventArgs) Handles Player2Button.Click
        'Draw a card and give it to player 2
        GivePlayerCard(2, DrawCard())
        'Decrement the number of cards remaining and update label
        CardsLeftLabel.Text = $"{52 - CardCount()}"
        'Display Player 2's card
        Player2CardLabel.Text = $"{playerHands(1, 0)}  {playerHands(1, 1)}"
        'Allow user to Reveal cards
        Player1Button.Enabled = False
        Player2Button.Enabled = False
        ShowCardsButton.Enabled = True
    End Sub

    Private Sub ShowCardsButton_Click(sender As Object, e As EventArgs) Handles ShowCardsButton.Click
        'Compare Card Values and increment score the first time it is called
        If CompareCardValues(True)(0) = 1 Then
            'Player 1 has won display updated score
            Player1ScoreLabel.Text = $"{CompareCardValues()(1)}"
        ElseIf CompareCardValues()(0) = 2 Then
            'Player 2 has won display updated score
            Player2ScoreLabel.Text = $"{CompareCardValues()(1)}"
        Else
            'Round is a tie.  Report to User
            MsgBox("This round is a tie!")
        End If
        'If there are no more cards initiate Game End
        If CardCount() = 52 Then
            If GameEnd() = 1 Then
                'player 1 won
                MsgBox("Player 1 has won the game")
            ElseIf GameEnd() = 2 Then
                'player 2 won
                MsgBox("Player 2 has won the game")
            Else
                'its a tie
                MsgBox("The game is a tie!")
            End If
            'Reset Card Deck, Player hands, and scores
            ResestGame()
            'Enable and Disable Start Game Buttons
            ResetGUI()
        End If
        'Allow Player 1 to Draw another Card
        ShowCardsButton.Enabled = False
        Player1Button.Enabled = True
    End Sub
End Class
