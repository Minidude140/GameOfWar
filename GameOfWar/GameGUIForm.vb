'Zachary Christensen
'Fall 2024; 09/22/24
'Card Game of War GUI Form
'https://github.com/Minidude140/GameOfWar

'This Form Handles the GUI Input and Output to and from the User

'TODO
'[*]Graphics for Deck
'**[*]Display Deck Full
'**[*]Display Deck Empty
'[*]Graphics for Player Cards
'**[*]Display Back of Cards When Drawn
'**[*]Display Cards Shown
'**[*]Display Cards Won (Stack)
'[*]User input
'**[*]Player 1 Draw Card Button
'**[*]Player 2 Draw Card Button
'**[*]SHow Hands Button
'**[*]Reset Game Button
'[*]Game End Screen
'[*]About Form
'[*]Menu Strips
'[*]Tool Tips
'[*]Tab Stops

Imports System.Threading
Public Class GameGUIForm
    ''' <summary>
    ''' Changed the background image to the current players card
    ''' </summary>
    ''' <param name="player"></param>
    Sub SetPlayerCardImage(player As Integer)
        Dim value As String = "1"
        Dim suit As String = "1"
        If player = 1 Then
            'Grab Player 1 card
            value = DetermineCard(CheckPlayerCard(1)(0), CheckPlayerCard(1)(1))(0)
            suit = DetermineCard(CheckPlayerCard(1)(0), CheckPlayerCard(1)(1))(1)
            'Set background image for player 1
            'Check suit
            Select Case suit
                Case = "Hearts"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_1
                        Case = "2"
                            'Set image to 2 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_2
                        Case = "3"
                            'Set image to 4 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_3
                        Case = "4"
                            'Set image to 4 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_4
                        Case = "5"
                            'Set image to 5 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_5
                        Case = "6"
                            'Set image to 6 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_6
                        Case = "7"
                            'Set image to 7 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_7
                        Case = "8"
                            'Set image to 8 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_8
                        Case = "9"
                            'Set image to 9 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_9
                        Case = "10"
                            'Set image to 10 of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_10
                        Case = "Jack"
                            'Set image to jack of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_11
                        Case = "Queen"
                            'Set image to queen of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_12
                        Case = "King"
                            'Set image to king of hearts
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_13
                    End Select
                Case = "Diamonds"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_1
                        Case = "2"
                            'Set image to 2 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_2
                        Case = "3"
                            'Set image to 4 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_3
                        Case = "4"
                            'Set image to 4 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_4
                        Case = "5"
                            'Set image to 5 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_5
                        Case = "6"
                            'Set image to 6 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_6
                        Case = "7"
                            'Set image to 7 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_7
                        Case = "8"
                            'Set image to 8 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_8
                        Case = "9"
                            'Set image to 9 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_9
                        Case = "10"
                            'Set image to 10 of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_10
                        Case = "Jack"
                            'Set image to jack of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_11
                        Case = "Queen"
                            'Set image to queen of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_12
                        Case = "King"
                            'Set image to king of diamonds
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_13
                    End Select
                Case = "Clubs"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_1
                        Case = "2"
                            'Set image to 2 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_2
                        Case = "3"
                            'Set image to 4 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_3
                        Case = "4"
                            'Set image to 4 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_4
                        Case = "5"
                            'Set image to 5 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_5
                        Case = "6"
                            'Set image to 6 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_6
                        Case = "7"
                            'Set image to 7 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_7
                        Case = "8"
                            'Set image to 8 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_8
                        Case = "9"
                            'Set image to 9 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_9
                        Case = "10"
                            'Set image to 10 of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_10
                        Case = "Jack"
                            'Set image to jack of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_11
                        Case = "Queen"
                            'Set image to queen of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_12
                        Case = "King"
                            'Set image to king of clubs
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_13
                    End Select
                Case = "Spades"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_1
                        Case = "2"
                            'Set image to 2 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_2
                        Case = "3"
                            'Set image to 4 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_3
                        Case = "4"
                            'Set image to 4 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_4
                        Case = "5"
                            'Set image to 5 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_5
                        Case = "6"
                            'Set image to 6 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_6
                        Case = "7"
                            'Set image to 7 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_7
                        Case = "8"
                            'Set image to 8 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_8
                        Case = "9"
                            'Set image to 9 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_9
                        Case = "10"
                            'Set image to 10 of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_10
                        Case = "Jack"
                            'Set image to jack of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_11
                        Case = "Queen"
                            'Set image to queen of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_12
                        Case = "King"
                            'Set image to king of spades
                            Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_13
                    End Select
            End Select
        ElseIf player = 2 Then
            'Grab Player 2 card
            value = DetermineCard(CheckPlayerCard(2)(0), CheckPlayerCard(2)(1))(0)
            suit = DetermineCard(CheckPlayerCard(2)(0), CheckPlayerCard(2)(1))(1)
            'Set background image for player 2
            'Check suit
            Select Case suit
                Case = "Hearts"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_1
                        Case = "2"
                            'Set image to 2 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_2
                        Case = "3"
                            'Set image to 4 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_3
                        Case = "4"
                            'Set image to 4 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_4
                        Case = "5"
                            'Set image to 5 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_5
                        Case = "6"
                            'Set image to 6 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_6
                        Case = "7"
                            'Set image to 7 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_7
                        Case = "8"
                            'Set image to 8 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_8
                        Case = "9"
                            'Set image to 9 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_9
                        Case = "10"
                            'Set image to 10 of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_10
                        Case = "Jack"
                            'Set image to jack of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_11
                        Case = "Queen"
                            'Set image to queen of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_12
                        Case = "King"
                            'Set image to king of hearts
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Hearts_13
                    End Select
                Case = "Diamonds"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_1
                        Case = "2"
                            'Set image to 2 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_2
                        Case = "3"
                            'Set image to 4 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_3
                        Case = "4"
                            'Set image to 4 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_4
                        Case = "5"
                            'Set image to 5 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_5
                        Case = "6"
                            'Set image to 6 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_6
                        Case = "7"
                            'Set image to 7 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_7
                        Case = "8"
                            'Set image to 8 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_8
                        Case = "9"
                            'Set image to 9 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_9
                        Case = "10"
                            'Set image to 10 of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_10
                        Case = "Jack"
                            'Set image to jack of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_11
                        Case = "Queen"
                            'Set image to queen of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_12
                        Case = "King"
                            'Set image to king of diamonds
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Diamonds_13
                    End Select
                Case = "Clubs"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_1
                        Case = "2"
                            'Set image to 2 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_2
                        Case = "3"
                            'Set image to 4 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_3
                        Case = "4"
                            'Set image to 4 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_4
                        Case = "5"
                            'Set image to 5 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_5
                        Case = "6"
                            'Set image to 6 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_6
                        Case = "7"
                            'Set image to 7 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_7
                        Case = "8"
                            'Set image to 8 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_8
                        Case = "9"
                            'Set image to 9 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_9
                        Case = "10"
                            'Set image to 10 of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_10
                        Case = "Jack"
                            'Set image to jack of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_11
                        Case = "Queen"
                            'Set image to queen of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_12
                        Case = "King"
                            'Set image to king of clubs
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Clubs_13
                    End Select
                Case = "Spades"
                    Select Case value
                        Case = "ACE"
                            'Set image to ace of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_1
                        Case = "2"
                            'Set image to 2 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_2
                        Case = "3"
                            'Set image to 4 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_3
                        Case = "4"
                            'Set image to 4 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_4
                        Case = "5"
                            'Set image to 5 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_5
                        Case = "6"
                            'Set image to 6 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_6
                        Case = "7"
                            'Set image to 7 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_7
                        Case = "8"
                            'Set image to 8 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_8
                        Case = "9"
                            'Set image to 9 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_9
                        Case = "10"
                            'Set image to 10 of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_10
                        Case = "Jack"
                            'Set image to jack of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_11
                        Case = "Queen"
                            'Set image to queen of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_12
                        Case = "King"
                            'Set image to king of spades
                            Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.Spades_13
                    End Select
            End Select
        End If
    End Sub
    Sub ResetGUI()
        'Allow player 1 to draw a card
        Player1Button.Enabled = True
        Player1DrawCardMenuItem.Enabled = True
        'Disable Player 2 drawing a card and Showing Cards
        Player2Button.Enabled = False
        Player2DrawCardMenuItem.Enabled = False
        ShowCardsButton.Enabled = False
        RevealCardsMenuItem.Enabled = False
        'Reset player score labels
        Player1ScoreLabel.Text = "0"
        Player1CardsWonPictureBox.BackgroundImage = GameOfWar.My.Resources.CardDeckEmpty
        Player2ScoreLabel.Text = "0"
        Player2CardsWonPictureBox.BackgroundImage = GameOfWar.My.Resources.CardDeckEmpty
        'Reset Players Hands Label
        Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.CardDeckEmpty
        Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.CardDeckEmpty
        'Reset Remaining number of cards
        CardsLeftLabel.Text = $"{52 - CardCount()}"
        DeckOfCardsPictureBox.BackgroundImage = GameOfWar.My.Resources.Resources.CardBack1
    End Sub

    Private Sub GameGUIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset Game Mechanics (card deck and scores)
        ResestGame()
        'Reset GUI (Player Labels and cards left)
        ResetGUI()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click,
                                                                           QuitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ResetGameButton_Click(sender As Object, e As EventArgs) Handles ResetGameButton.Click,
                                                                                ReShuffleDeckMenuItem.Click
        'Reset Game Mechanics (card deck and scores)
        ResestGame()
        'Reset GUI (Player Labels and cards left)
        ResetGUI()
    End Sub

    Private Sub Player1Button_Click(sender As Object, e As EventArgs) Handles Player1Button.Click,
                                                                              Player1DrawCardMenuItem.Click
        'Draw a card and give to player 1
        GivePlayerCard(1, DrawCard())
        'Decrement the number of cards remaining and update label
        CardsLeftLabel.Text = $"{52 - CardCount()}"
        'Display Player 1's card
        Player1CardPictureBox.BackgroundImage = GameOfWar.My.Resources.CardBack1
        'Allow player 2 to draw a card
        Player1Button.Enabled = False
        Player1DrawCardMenuItem.Enabled = False
        Player2Button.Enabled = True
        Player2DrawCardMenuItem.Enabled = True
    End Sub

    Private Sub Player2Button_Click(sender As Object, e As EventArgs) Handles Player2Button.Click,
                                                                              Player2DrawCardMenuItem.Click
        'Draw a card and give it to player 2
        GivePlayerCard(2, DrawCard())
        'Decrement the number of cards remaining and update label
        CardsLeftLabel.Text = $"{52 - CardCount()}"
        'Display Player 2's card
        Player2CardPictureBox.BackgroundImage = GameOfWar.My.Resources.CardBack1
        'Allow user to Reveal cards
        Player2Button.Enabled = False
        Player2DrawCardMenuItem.Enabled = False
        ShowCardsButton.Enabled = True
        RevealCardsMenuItem.Enabled = True
    End Sub

    Private Sub ShowCardsButton_Click(sender As Object, e As EventArgs) Handles ShowCardsButton.Click,
                                                                                RevealCardsMenuItem.Click
        'Show Player Cards
        SetPlayerCardImage(1)
        SetPlayerCardImage(2)
        'Compare Card Values and increment score the first time it is called
        If CompareCardValues(True)(0) = 1 Then
            'Player 1 has won display updated score
            Player1ScoreLabel.Text = $"{CompareCardValues()(1)}"
            'display cards won stack
            Player1CardsWonPictureBox.BackgroundImage = GameOfWar.My.Resources.CardBack1
        ElseIf CompareCardValues()(0) = 2 Then
            'Player 2 has won display updated score
            Player2ScoreLabel.Text = $"{CompareCardValues()(1)}"
            'display cards won stack
            Player2CardsWonPictureBox.BackgroundImage = GameOfWar.My.Resources.CardBack1
        Else
            'Round is a tie.  Report to User
            MsgBox("This round is a tie!")
        End If
        'If there are no more cards initiate Game End
        If CardCount() = 52 Then
            DeckOfCardsPictureBox.BackgroundImage = GameOfWar.My.Resources.CardDeckEmpty
            Thread.Sleep(500)
            GameEndForm.Show()
            'Reset Card Deck, Player hands, and scores
            ResestGame()
            'Enable and Disable Start Game Buttons
            ResetGUI()
        End If
        'Allow Player 1 to Draw another Card
        ShowCardsButton.Enabled = False
        RevealCardsMenuItem.Enabled = False
        Player1Button.Enabled = True
        Player1DrawCardMenuItem.Enabled = True
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click
        'open the about this program form
        AboutForm.Show()
    End Sub
End Class
