<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameGUIForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Player1Button = New System.Windows.Forms.Button()
        Me.Player2Button = New System.Windows.Forms.Button()
        Me.ShowCardsButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ResetGameButton = New System.Windows.Forms.Button()
        Me.Player1CardLabel = New System.Windows.Forms.Label()
        Me.Player2CardLabel = New System.Windows.Forms.Label()
        Me.Player1ScoreLabel = New System.Windows.Forms.Label()
        Me.Player2ScoreLabel = New System.Windows.Forms.Label()
        Me.CardsLeftLabel = New System.Windows.Forms.Label()
        Me.GameToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Player1Button
        '
        Me.Player1Button.Location = New System.Drawing.Point(2, 154)
        Me.Player1Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Player1Button.Name = "Player1Button"
        Me.Player1Button.Size = New System.Drawing.Size(116, 43)
        Me.Player1Button.TabIndex = 0
        Me.Player1Button.Text = "Player 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Card"
        Me.GameToolTip.SetToolTip(Me.Player1Button, "Draw a card for Player 1")
        Me.Player1Button.UseVisualStyleBackColor = True
        '
        'Player2Button
        '
        Me.Player2Button.Location = New System.Drawing.Point(590, 154)
        Me.Player2Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Player2Button.Name = "Player2Button"
        Me.Player2Button.Size = New System.Drawing.Size(116, 43)
        Me.Player2Button.TabIndex = 1
        Me.Player2Button.Text = "Player 2" & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Card"
        Me.GameToolTip.SetToolTip(Me.Player2Button, "Draw a Card for Player 2")
        Me.Player2Button.UseVisualStyleBackColor = True
        '
        'ShowCardsButton
        '
        Me.ShowCardsButton.Location = New System.Drawing.Point(296, 10)
        Me.ShowCardsButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ShowCardsButton.Name = "ShowCardsButton"
        Me.ShowCardsButton.Size = New System.Drawing.Size(116, 43)
        Me.ShowCardsButton.TabIndex = 2
        Me.ShowCardsButton.Text = "Reveal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cards"
        Me.GameToolTip.SetToolTip(Me.ShowCardsButton, "Flip over The Cards.")
        Me.ShowCardsButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(590, 313)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(116, 43)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "Quit"
        Me.GameToolTip.SetToolTip(Me.QuitButton, "Exit this Program")
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ResetGameButton
        '
        Me.ResetGameButton.Location = New System.Drawing.Point(296, 313)
        Me.ResetGameButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ResetGameButton.Name = "ResetGameButton"
        Me.ResetGameButton.Size = New System.Drawing.Size(116, 43)
        Me.ResetGameButton.TabIndex = 4
        Me.ResetGameButton.Text = "Re-Shuffle Deck"
        Me.GameToolTip.SetToolTip(Me.ResetGameButton, "Shuffle the Deck and Restart the Game.")
        Me.ResetGameButton.UseVisualStyleBackColor = True
        '
        'Player1CardLabel
        '
        Me.Player1CardLabel.AutoSize = True
        Me.Player1CardLabel.Location = New System.Drawing.Point(170, 154)
        Me.Player1CardLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player1CardLabel.Name = "Player1CardLabel"
        Me.Player1CardLabel.Size = New System.Drawing.Size(39, 13)
        Me.Player1CardLabel.TabIndex = 5
        Me.Player1CardLabel.Text = "Label1"
        '
        'Player2CardLabel
        '
        Me.Player2CardLabel.AutoSize = True
        Me.Player2CardLabel.Location = New System.Drawing.Point(483, 154)
        Me.Player2CardLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player2CardLabel.Name = "Player2CardLabel"
        Me.Player2CardLabel.Size = New System.Drawing.Size(39, 13)
        Me.Player2CardLabel.TabIndex = 6
        Me.Player2CardLabel.Text = "Label1"
        '
        'Player1ScoreLabel
        '
        Me.Player1ScoreLabel.AutoSize = True
        Me.Player1ScoreLabel.Location = New System.Drawing.Point(20, 47)
        Me.Player1ScoreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player1ScoreLabel.Name = "Player1ScoreLabel"
        Me.Player1ScoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.Player1ScoreLabel.TabIndex = 7
        Me.Player1ScoreLabel.Text = "0"
        '
        'Player2ScoreLabel
        '
        Me.Player2ScoreLabel.AutoSize = True
        Me.Player2ScoreLabel.Location = New System.Drawing.Point(642, 47)
        Me.Player2ScoreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Player2ScoreLabel.Name = "Player2ScoreLabel"
        Me.Player2ScoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.Player2ScoreLabel.TabIndex = 8
        Me.Player2ScoreLabel.Text = "0"
        '
        'CardsLeftLabel
        '
        Me.CardsLeftLabel.AutoSize = True
        Me.CardsLeftLabel.Location = New System.Drawing.Point(335, 154)
        Me.CardsLeftLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CardsLeftLabel.Name = "CardsLeftLabel"
        Me.CardsLeftLabel.Size = New System.Drawing.Size(19, 13)
        Me.CardsLeftLabel.TabIndex = 9
        Me.CardsLeftLabel.Text = "52"
        '
        'GameGUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 366)
        Me.Controls.Add(Me.CardsLeftLabel)
        Me.Controls.Add(Me.Player2ScoreLabel)
        Me.Controls.Add(Me.Player1ScoreLabel)
        Me.Controls.Add(Me.Player2CardLabel)
        Me.Controls.Add(Me.Player1CardLabel)
        Me.Controls.Add(Me.ResetGameButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ShowCardsButton)
        Me.Controls.Add(Me.Player2Button)
        Me.Controls.Add(Me.Player1Button)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GameGUIForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player1Button As Button
    Friend WithEvents Player2Button As Button
    Friend WithEvents ShowCardsButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents ResetGameButton As Button
    Friend WithEvents Player1CardLabel As Label
    Friend WithEvents Player2CardLabel As Label
    Friend WithEvents Player1ScoreLabel As Label
    Friend WithEvents Player2ScoreLabel As Label
    Friend WithEvents CardsLeftLabel As Label
    Friend WithEvents GameToolTip As ToolTip
End Class
