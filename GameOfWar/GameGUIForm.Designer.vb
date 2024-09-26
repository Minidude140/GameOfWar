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
        Me.SuspendLayout()
        '
        'Player1Button
        '
        Me.Player1Button.Location = New System.Drawing.Point(3, 190)
        Me.Player1Button.Name = "Player1Button"
        Me.Player1Button.Size = New System.Drawing.Size(154, 53)
        Me.Player1Button.TabIndex = 0
        Me.Player1Button.Text = "Player 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Card"
        Me.Player1Button.UseVisualStyleBackColor = True
        '
        'Player2Button
        '
        Me.Player2Button.Location = New System.Drawing.Point(787, 190)
        Me.Player2Button.Name = "Player2Button"
        Me.Player2Button.Size = New System.Drawing.Size(154, 53)
        Me.Player2Button.TabIndex = 1
        Me.Player2Button.Text = "Player 2" & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Card"
        Me.Player2Button.UseVisualStyleBackColor = True
        '
        'ShowCardsButton
        '
        Me.ShowCardsButton.Location = New System.Drawing.Point(394, 12)
        Me.ShowCardsButton.Name = "ShowCardsButton"
        Me.ShowCardsButton.Size = New System.Drawing.Size(154, 53)
        Me.ShowCardsButton.TabIndex = 2
        Me.ShowCardsButton.Text = "Reveal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cards"
        Me.ShowCardsButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(787, 385)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(154, 53)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ResetGameButton
        '
        Me.ResetGameButton.Location = New System.Drawing.Point(394, 385)
        Me.ResetGameButton.Name = "ResetGameButton"
        Me.ResetGameButton.Size = New System.Drawing.Size(154, 53)
        Me.ResetGameButton.TabIndex = 4
        Me.ResetGameButton.Text = "Re-Shuffle Deck"
        Me.ResetGameButton.UseVisualStyleBackColor = True
        '
        'Player1CardLabel
        '
        Me.Player1CardLabel.AutoSize = True
        Me.Player1CardLabel.Location = New System.Drawing.Point(197, 189)
        Me.Player1CardLabel.Name = "Player1CardLabel"
        Me.Player1CardLabel.Size = New System.Drawing.Size(51, 17)
        Me.Player1CardLabel.TabIndex = 5
        Me.Player1CardLabel.Text = "Label1"
        '
        'Player2CardLabel
        '
        Me.Player2CardLabel.AutoSize = True
        Me.Player2CardLabel.Location = New System.Drawing.Point(699, 189)
        Me.Player2CardLabel.Name = "Player2CardLabel"
        Me.Player2CardLabel.Size = New System.Drawing.Size(51, 17)
        Me.Player2CardLabel.TabIndex = 6
        Me.Player2CardLabel.Text = "Label1"
        '
        'Player1ScoreLabel
        '
        Me.Player1ScoreLabel.AutoSize = True
        Me.Player1ScoreLabel.Location = New System.Drawing.Point(27, 58)
        Me.Player1ScoreLabel.Name = "Player1ScoreLabel"
        Me.Player1ScoreLabel.Size = New System.Drawing.Size(16, 17)
        Me.Player1ScoreLabel.TabIndex = 7
        Me.Player1ScoreLabel.Text = "0"
        '
        'Player2ScoreLabel
        '
        Me.Player2ScoreLabel.AutoSize = True
        Me.Player2ScoreLabel.Location = New System.Drawing.Point(856, 58)
        Me.Player2ScoreLabel.Name = "Player2ScoreLabel"
        Me.Player2ScoreLabel.Size = New System.Drawing.Size(16, 17)
        Me.Player2ScoreLabel.TabIndex = 8
        Me.Player2ScoreLabel.Text = "0"
        '
        'CardsLeftLabel
        '
        Me.CardsLeftLabel.AutoSize = True
        Me.CardsLeftLabel.Location = New System.Drawing.Point(447, 190)
        Me.CardsLeftLabel.Name = "CardsLeftLabel"
        Me.CardsLeftLabel.Size = New System.Drawing.Size(24, 17)
        Me.CardsLeftLabel.TabIndex = 9
        Me.CardsLeftLabel.Text = "52"
        '
        'GameGUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 450)
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
End Class
