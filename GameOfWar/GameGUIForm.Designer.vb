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
        Me.Player1ScoreLabel = New System.Windows.Forms.Label()
        Me.Player2ScoreLabel = New System.Windows.Forms.Label()
        Me.CardsLeftLabel = New System.Windows.Forms.Label()
        Me.GameToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.WarMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GameActionsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Player1DrawCardMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Player2DrawCardMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevealCardsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReShuffleDeckMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Player2CardPictureBox = New System.Windows.Forms.PictureBox()
        Me.Player1CardPictureBox = New System.Windows.Forms.PictureBox()
        Me.DeckOfCardsPictureBox = New System.Windows.Forms.PictureBox()
        Me.WarMenuStrip.SuspendLayout()
        CType(Me.Player2CardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1CardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeckOfCardsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player1Button
        '
        Me.Player1Button.Location = New System.Drawing.Point(2, 154)
        Me.Player1Button.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Player2Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Player2Button.Name = "Player2Button"
        Me.Player2Button.Size = New System.Drawing.Size(116, 43)
        Me.Player2Button.TabIndex = 1
        Me.Player2Button.Text = "Player 2" & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Card"
        Me.GameToolTip.SetToolTip(Me.Player2Button, "Draw a Card for Player 2")
        Me.Player2Button.UseVisualStyleBackColor = True
        '
        'ShowCardsButton
        '
        Me.ShowCardsButton.Location = New System.Drawing.Point(296, 26)
        Me.ShowCardsButton.Margin = New System.Windows.Forms.Padding(2)
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
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(116, 43)
        Me.QuitButton.TabIndex = 9
        Me.QuitButton.Text = "Quit"
        Me.GameToolTip.SetToolTip(Me.QuitButton, "Exit this Program")
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ResetGameButton
        '
        Me.ResetGameButton.Location = New System.Drawing.Point(296, 313)
        Me.ResetGameButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetGameButton.Name = "ResetGameButton"
        Me.ResetGameButton.Size = New System.Drawing.Size(116, 43)
        Me.ResetGameButton.TabIndex = 8
        Me.ResetGameButton.Text = "Re-Shuffle Deck"
        Me.GameToolTip.SetToolTip(Me.ResetGameButton, "Shuffle the Deck and Restart the Game.")
        Me.ResetGameButton.UseVisualStyleBackColor = True
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
        Me.CardsLeftLabel.Location = New System.Drawing.Point(338, 115)
        Me.CardsLeftLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CardsLeftLabel.Name = "CardsLeftLabel"
        Me.CardsLeftLabel.Size = New System.Drawing.Size(19, 13)
        Me.CardsLeftLabel.TabIndex = 9
        Me.CardsLeftLabel.Text = "52"
        '
        'WarMenuStrip
        '
        Me.WarMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameActionsMenuItem, Me.AboutMenuItem, Me.QuitMenuItem})
        Me.WarMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.WarMenuStrip.Name = "WarMenuStrip"
        Me.WarMenuStrip.Size = New System.Drawing.Size(715, 24)
        Me.WarMenuStrip.TabIndex = 10
        Me.WarMenuStrip.Text = "MenuStrip1"
        '
        'GameActionsMenuItem
        '
        Me.GameActionsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Player1DrawCardMenuItem, Me.Player2DrawCardMenuItem, Me.RevealCardsMenuItem, Me.ReShuffleDeckMenuItem})
        Me.GameActionsMenuItem.Name = "GameActionsMenuItem"
        Me.GameActionsMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.GameActionsMenuItem.Text = "Game Actions"
        '
        'Player1DrawCardMenuItem
        '
        Me.Player1DrawCardMenuItem.Name = "Player1DrawCardMenuItem"
        Me.Player1DrawCardMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.Player1DrawCardMenuItem.Text = "Player 1 Draw Card"
        '
        'Player2DrawCardMenuItem
        '
        Me.Player2DrawCardMenuItem.Name = "Player2DrawCardMenuItem"
        Me.Player2DrawCardMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.Player2DrawCardMenuItem.Text = "Player 2 Draw Card"
        '
        'RevealCardsMenuItem
        '
        Me.RevealCardsMenuItem.Name = "RevealCardsMenuItem"
        Me.RevealCardsMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RevealCardsMenuItem.Text = "Reveal Cards"
        '
        'ReShuffleDeckMenuItem
        '
        Me.ReShuffleDeckMenuItem.Name = "ReShuffleDeckMenuItem"
        Me.ReShuffleDeckMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ReShuffleDeckMenuItem.Text = "Re-Shuffle Deck"
        '
        'AboutMenuItem
        '
        Me.AboutMenuItem.Name = "AboutMenuItem"
        Me.AboutMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutMenuItem.Text = "About"
        '
        'QuitMenuItem
        '
        Me.QuitMenuItem.Name = "QuitMenuItem"
        Me.QuitMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.QuitMenuItem.Text = "Quit"
        '
        'Player2CardPictureBox
        '
        Me.Player2CardPictureBox.Location = New System.Drawing.Point(506, 142)
        Me.Player2CardPictureBox.Name = "Player2CardPictureBox"
        Me.Player2CardPictureBox.Size = New System.Drawing.Size(62, 93)
        Me.Player2CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player2CardPictureBox.TabIndex = 13
        Me.Player2CardPictureBox.TabStop = False
        '
        'Player1CardPictureBox
        '
        Me.Player1CardPictureBox.Location = New System.Drawing.Point(136, 142)
        Me.Player1CardPictureBox.Name = "Player1CardPictureBox"
        Me.Player1CardPictureBox.Size = New System.Drawing.Size(62, 93)
        Me.Player1CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player1CardPictureBox.TabIndex = 12
        Me.Player1CardPictureBox.TabStop = False
        '
        'DeckOfCardsPictureBox
        '
        Me.DeckOfCardsPictureBox.Location = New System.Drawing.Point(316, 154)
        Me.DeckOfCardsPictureBox.Name = "DeckOfCardsPictureBox"
        Me.DeckOfCardsPictureBox.Size = New System.Drawing.Size(62, 93)
        Me.DeckOfCardsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DeckOfCardsPictureBox.TabIndex = 11
        Me.DeckOfCardsPictureBox.TabStop = False
        '
        'GameGUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 366)
        Me.Controls.Add(Me.Player2CardPictureBox)
        Me.Controls.Add(Me.Player1CardPictureBox)
        Me.Controls.Add(Me.DeckOfCardsPictureBox)
        Me.Controls.Add(Me.CardsLeftLabel)
        Me.Controls.Add(Me.Player2ScoreLabel)
        Me.Controls.Add(Me.Player1ScoreLabel)
        Me.Controls.Add(Me.ResetGameButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ShowCardsButton)
        Me.Controls.Add(Me.Player2Button)
        Me.Controls.Add(Me.Player1Button)
        Me.Controls.Add(Me.WarMenuStrip)
        Me.MainMenuStrip = Me.WarMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GameGUIForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Game of War"
        Me.WarMenuStrip.ResumeLayout(False)
        Me.WarMenuStrip.PerformLayout()
        CType(Me.Player2CardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1CardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeckOfCardsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player1Button As Button
    Friend WithEvents Player2Button As Button
    Friend WithEvents ShowCardsButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents ResetGameButton As Button
    Friend WithEvents Player1ScoreLabel As Label
    Friend WithEvents Player2ScoreLabel As Label
    Friend WithEvents CardsLeftLabel As Label
    Friend WithEvents GameToolTip As ToolTip
    Friend WithEvents WarMenuStrip As MenuStrip
    Friend WithEvents GameActionsMenuItem As ToolStripMenuItem
    Friend WithEvents Player1DrawCardMenuItem As ToolStripMenuItem
    Friend WithEvents Player2DrawCardMenuItem As ToolStripMenuItem
    Friend WithEvents RevealCardsMenuItem As ToolStripMenuItem
    Friend WithEvents ReShuffleDeckMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMenuItem As ToolStripMenuItem
    Friend WithEvents QuitMenuItem As ToolStripMenuItem
    Friend WithEvents DeckOfCardsPictureBox As PictureBox
    Friend WithEvents Player1CardPictureBox As PictureBox
    Friend WithEvents Player2CardPictureBox As PictureBox
End Class
