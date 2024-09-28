'Zachary Christensen
'Fall 2024; 09/22/24
'Card Game of War Mechanics Module
'https://github.com/Minidude140/GameOfWar

'This Module Will Handle the Game Mechanics including, Shuffling the Deck, Drawing Cards, and Comparing Hands

'TODO
'[*]Keep Track of Card Value and Drawn Status (Array Location Tells Value)
'[*]Create Draw Card Function (Returns Card Drawn Array Location)
'[*]Give Drawn Card to Chosen Player
'[*]Compare Cards
'[*]Game Reset
'[*]Game End


Module GameMechanicsModule
    Dim cardDeck(12, 3) As Boolean
    '       HRT     DIA     CLB     SPD
    'A      0,0     0,1     0,2     0,3
    '2      1,0
    '3      2,0
    '4      3,0
    '5      4,0
    '6      5,0
    '7      6,0
    '8      7,0
    '9      8,0
    '10     9,0
    'J      10,0
    'Q      11,0
    'K      12,0
    Public playerHands(1, 1) As Integer
    '          1stCardValue     1stCardSuit
    'Player 1       0,0             0,1
    'Player 2       1,0             1,1
    Dim player1Score As Integer = 0
    Dim player2Score As Integer = 0

    ''' <summary>
    ''' Draws Random Card Returns Card array Coordinates.  Tests if card is already drawn.  Tests if Deck is Empty
    ''' </summary>
    ''' <returns></returns>
    Function DrawCard() As Integer()
        Dim cardDrawn(1) As Integer
        'Checks if all Cards are Drawn
        If CardCount() < 52 Then
                'Draw Random Card Until One that has not already been drawn is found
                Do
                    'Draw a Random Value Card
                    cardDrawn(0) = RandomNumber(12)
                    'Draw a Random Suit Card
                    cardDrawn(1) = RandomNumber(3)
                Loop Until cardDeck(cardDrawn(0), cardDrawn(1)) = False
                'Sets The Card as Drawn in the Array
                cardDeck(cardDrawn(0), cardDrawn(1)) = True
                'increment cards drawn count
                CardCount(False, True)
            Else
                'All Cards Drawn Initiate Game End
            End If
            Return cardDrawn
    End Function

    ''' <summary>
    ''' Returns a Random Number from 0 to the given max value
    ''' </summary>
    ''' <param name="maxNumber"></param>
    ''' <returns></returns>
    Function RandomNumber(maxNumber As Integer) As Integer
        Randomize()
        Return CInt(Rnd() * maxNumber)
    End Function

    ''' <summary>
    ''' Default Check the number of cards drawn(false, false), Reset(True, False), or increment count (False, True)
    ''' </summary>
    ''' <param name="reset"></param>
    ''' <param name="drawCard"></param>
    ''' <returns></returns>
    Function CardCount(Optional reset As Boolean = False, Optional drawCard As Boolean = False) As Integer
        Static count As Integer
        'Check if the Game Count Should Be Reset
        If reset = True Then
            'Reset the Count
            count = 0
        Else
            'Check if a Card is Drawn
            If drawCard Then
                'Increment Count
                count += 1
            End If
        End If
        'Return Number of Cards Drawn
        Return count
    End Function

    ''' <summary>
    ''' Populates PlayerHands Array to Given Player and Card
    ''' </summary>
    ''' <param name="player"></param>
    ''' <param name="playerCard"></param>
    Sub GivePlayerCard(player As Integer, playerCard() As Integer)
        Select Case player
            Case = 1
                'Give card to player 1 value then suit
                playerHands(0, 0) = playerCard(0)
                playerHands(0, 1) = playerCard(1)
            Case = 2
                'Give card to player 2 value then suit
                playerHands(1, 0) = playerCard(0)
                playerHands(1, 1) = playerCard(1)
            Case Else
                'Not enough players, Do nothing (need to expand playerHandsArray and this Case Statement for more players)
        End Select
    End Sub

    ''' <summary>
    ''' Compares Player Hand Card Values and optionally Increments Score.  Returns 1 for Player 1 Won, 2 for Player 2 Won, and 0 for Tie
    ''' </summary>
    ''' <returns></returns>
    Function CompareCardValues(Optional increaseScore As Boolean = False) As Integer()
        Dim whoWon As Integer
        Dim currentScore As Integer
        'Examine Player 1's First Card's Value
        Select Case playerHands(0, 0)
            Case > playerHands(1, 0)
                'Player 1 Has a Higher Value Card
                If increaseScore = True Then
                    player1Score += 1
                End If
                whoWon = 1
                currentScore = player1Score
            Case = playerHands(1, 0)
                'Players Have Equal Cards
                whoWon = 0
            Case < playerHands(1, 0)
                'Player 2 Has a Higher Value Card
                If increaseScore = True Then
                    player2Score += 1
                End If
                whoWon = 2
                currentScore = player2Score
        End Select
        Return {whoWon, currentScore}
    End Function

    ''' <summary>
    ''' Resets the Card Deck, Player Hands, and Player Scores
    ''' </summary>
    Sub ResestGame()
        'Reshuffle the Deck
        ReDim cardDeck(12, 3)
        'Reset Card Count
        CardCount(True, False)
        'Reset Player Hands
        ReDim playerHands(1, 1)
        'Reset Player Scores
        player1Score = 0
        player2Score = 0
    End Sub

    ''' <summary>
    ''' Checks player score and returns the winner.  1 = player 1 wins, 2 = player 2 wins, 0 = Tie Game
    ''' </summary>
    ''' <returns></returns>
    Function GameEnd() As Integer
        Dim whowins As Integer
        If player1Score > player2Score Then
            'Player 1 wins
            whowins = 1
        ElseIf player1Score = player2Score Then
            'Tie Game
            whowins = 0
        Else
            'Player 2 wins
            whowins = 2
        End If
        Return whowins
    End Function

    ''' <summary>
    ''' Returns a players score
    ''' </summary>
    ''' <param name="player"></param>
    ''' <returns></returns>
    Function CheckPlayerScore(player As Integer) As Integer
        Dim score As Integer
        If player = 1 Then
            'requested player 1 score
            score = player1Score
        ElseIf player = 2 Then
            'requested player 2 score
            score = player2Score
        Else
            'should not be called we do not know whose score
            score = 0
        End If
        'return the score requested for
        Return score
    End Function

    ''' <summary>
    ''' Interprets the dimensions of the array and returns value and suit as strings
    ''' </summary>
    ''' <param name="value"></param>
    ''' <param name="suit"></param>
    ''' <returns></returns>
    Function DetermineCard(value As Integer, suit As Integer) As String()
        Dim card(1) As String
        'Determine suite of the card and set into card array
        Select Case suit
            Case = 0
                'card is Hearts
                card(1) = "Hearts"
            Case = 1
                'card is Diamonds
                card(1) = "Diamonds"
            Case = 2
                'card is Clubs
                card(1) = "Clubs"
            Case = 3
                'card is spades
                card(1) = "Spades"
        End Select
        'Determine Value of card and set into array
        Select Case value
            Case = 0
                'Card is Ace
                card(0) = "ACE"
            Case = 1
                'Card is 2
                card(0) = "2"
            Case = 2
                'Card is 3
                card(0) = "3"
            Case = 3
                'Card is 4
                card(0) = "4"
            Case = 4
                'Card is 5
                card(0) = "5"
            Case = 5
                'Card is 6
                card(0) = "6"
            Case = 6
                'Card is 7
                card(0) = "7"
            Case = 7
                'Card is 8
                card(0) = "8"
            Case = 8
                'Card is 9
                card(0) = "9"
            Case = 9
                'Card is 10
                card(0) = "10"
            Case = 10
                'Card is Jack
                card(0) = "Jack"
            Case = 11
                'Card is Queen
                card(0) = "Queen"
            Case = 12
                'Card is King
                card(0) = "King"
        End Select
        'Return value, suit 
        Return {card(0), card(1)}
    End Function

    ''' <summary>
    ''' Returns player card array location.  (give 1 or 2 for player number)
    ''' </summary>
    ''' <param name="player"></param>
    ''' <returns></returns>
    Function CheckPlayerCard(player As Integer) As Integer()
        Dim card(1) As Integer
        card(0) = playerHands((player - 1), 0)
        card(1) = playerHands((player - 1), 1)
        Return {card(0), card(1)}
    End Function
End Module
