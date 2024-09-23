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
'**[]Reset Game Button
'[]Game End Screen
'[]About Form
'[]Menu Strips
'[]Tool Tips
'[]Tab Stops

Public Class GameGUIForm
    Private Sub GameGUIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawCard()
    End Sub
End Class
