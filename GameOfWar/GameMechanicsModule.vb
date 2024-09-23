'Zachary Christensen
'Fall 2024; 09/22/24
'Card Game of War Mechanics Module
'https://github.com/Minidude140/GameOfWar

'This Module Will Handle the Game Mechanics including, Shuffling the Deck, Drawing Cards, and Comparing Hands

'TODO
'[*]Keep Track of Card Value and Drawn Status (Array Location Tells Value)
'[*]Create Draw Card Function (Returns Card Drawn Array Location)
'[*]Give Drawn Card to Chosen Player
'[]Compare Cards
'[]Game Reset
'[]Game End


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

    ''' <summary>
    ''' Draws Random Card Returns Card array Coordinates.  Tests if card is already drawn.  Tests if Deck is Empty
    ''' </summary>
    ''' <returns></returns>
    Function DrawCard() As Integer()
        Dim cardDrawn(1) As Integer
        'Checks if all Cards are Drawn
        Dim i As Integer = 0
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

        If reset = True Then
            count = 0
        Else
            If drawCard Then
                count += 1
            End If
        End If
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
End Module
