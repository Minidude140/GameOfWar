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
        Me.Player1ScoreTitleLabel = New System.Windows.Forms.Label()
        Me.Player2ScoreTitleLabel = New System.Windows.Forms.Label()
        Me.Player1CardsWonPictureBox = New System.Windows.Forms.PictureBox()
        Me.Player2CardsWonPictureBox = New System.Windows.Forms.PictureBox()
        Me.CardsLeftTitleLabel = New System.Windows.Forms.Label()
        Me.WarMenuStrip.SuspendLayout()
        CType(Me.Player2CardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1CardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeckOfCardsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1CardsWonPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2CardsWonPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player1Button
        '
        Me.Player1Button.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Player1Button.Location = New System.Drawing.Point(3, 165)
        Me.Player1Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Player1Button.Name = "Player1Button"
        Me.Player1Button.Size = New System.Drawing.Size(155, 53)
        Me.Player1Button.TabIndex = 0
        Me.Player1Button.Text = "Player &1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Card"
        Me.GameToolTip.SetToolTip(Me.Player1Button, "Draw a card for Player 1")
        Me.Player1Button.UseVisualStyleBackColor = True
        '
        'Player2Button
        '
        Me.Player2Button.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Player2Button.Location = New System.Drawing.Point(709, 165)
        Me.Player2Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Player2Button.Name = "Player2Button"
        Me.Player2Button.Size = New System.Drawing.Size(155, 53)
        Me.Player2Button.TabIndex = 1
        Me.Player2Button.Text = "Player &2" & Global.Microsoft.VisualBasic.ChrW(10) & "Draw Card"
        Me.GameToolTip.SetToolTip(Me.Player2Button, "Draw a Card for Player 2")
        Me.Player2Button.UseVisualStyleBackColor = True
        '
        'ShowCardsButton
        '
        Me.ShowCardsButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowCardsButton.Location = New System.Drawing.Point(395, 32)
        Me.ShowCardsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShowCardsButton.Name = "ShowCardsButton"
        Me.ShowCardsButton.Size = New System.Drawing.Size(77, 53)
        Me.ShowCardsButton.TabIndex = 2
        Me.ShowCardsButton.Text = "&Reveal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cards"
        Me.GameToolTip.SetToolTip(Me.ShowCardsButton, "Flip over The Cards.")
        Me.ShowCardsButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuitButton.Location = New System.Drawing.Point(709, 336)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(155, 53)
        Me.QuitButton.TabIndex = 9
        Me.QuitButton.Text = "&Quit"
        Me.GameToolTip.SetToolTip(Me.QuitButton, "Exit this Program")
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ResetGameButton
        '
        Me.ResetGameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ResetGameButton.Location = New System.Drawing.Point(356, 336)
        Me.ResetGameButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResetGameButton.Name = "ResetGameButton"
        Me.ResetGameButton.Size = New System.Drawing.Size(155, 53)
        Me.ResetGameButton.TabIndex = 8
        Me.ResetGameButton.Text = "Re-&Shuffle Deck"
        Me.GameToolTip.SetToolTip(Me.ResetGameButton, "Shuffle the Deck and Restart the Game.")
        Me.ResetGameButton.UseVisualStyleBackColor = True
        '
        'Player1ScoreLabel
        '
        Me.Player1ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Player1ScoreLabel.AutoSize = True
        Me.Player1ScoreLabel.Location = New System.Drawing.Point(204, 65)
        Me.Player1ScoreLabel.Name = "Player1ScoreLabel"
        Me.Player1ScoreLabel.Size = New System.Drawing.Size(16, 17)
        Me.Player1ScoreLabel.TabIndex = 7
        Me.Player1ScoreLabel.Text = "0"
        '
        'Player2ScoreLabel
        '
        Me.Player2ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Player2ScoreLabel.AutoSize = True
        Me.Player2ScoreLabel.Location = New System.Drawing.Point(637, 65)
        Me.Player2ScoreLabel.Name = "Player2ScoreLabel"
        Me.Player2ScoreLabel.Size = New System.Drawing.Size(16, 17)
        Me.Player2ScoreLabel.TabIndex = 8
        Me.Player2ScoreLabel.Text = "0"
        '
        'CardsLeftLabel
        '
        Me.CardsLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CardsLeftLabel.AutoSize = True
        Me.CardsLeftLabel.Location = New System.Drawing.Point(421, 153)
        Me.CardsLeftLabel.Name = "CardsLeftLabel"
        Me.CardsLeftLabel.Size = New System.Drawing.Size(24, 17)
        Me.CardsLeftLabel.TabIndex = 9
        Me.CardsLeftLabel.Text = "52"
        '
        'WarMenuStrip
        '
        Me.WarMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.WarMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameActionsMenuItem, Me.AboutMenuItem, Me.QuitMenuItem})
        Me.WarMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.WarMenuStrip.Name = "WarMenuStrip"
        Me.WarMenuStrip.Size = New System.Drawing.Size(876, 28)
        Me.WarMenuStrip.TabIndex = 10
        Me.WarMenuStrip.Text = "MenuStrip1"
        '
        'GameActionsMenuItem
        '
        Me.GameActionsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Player1DrawCardMenuItem, Me.Player2DrawCardMenuItem, Me.RevealCardsMenuItem, Me.ReShuffleDeckMenuItem})
        Me.GameActionsMenuItem.Name = "GameActionsMenuItem"
        Me.GameActionsMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.GameActionsMenuItem.Text = "Game Actions"
        '
        'Player1DrawCardMenuItem
        '
        Me.Player1DrawCardMenuItem.Name = "Player1DrawCardMenuItem"
        Me.Player1DrawCardMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.Player1DrawCardMenuItem.Text = "Player 1 Draw Card"
        '
        'Player2DrawCardMenuItem
        '
        Me.Player2DrawCardMenuItem.Name = "Player2DrawCardMenuItem"
        Me.Player2DrawCardMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.Player2DrawCardMenuItem.Text = "Player 2 Draw Card"
        '
        'RevealCardsMenuItem
        '
        Me.RevealCardsMenuItem.Name = "RevealCardsMenuItem"
        Me.RevealCardsMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.RevealCardsMenuItem.Text = "Reveal Cards"
        '
        'ReShuffleDeckMenuItem
        '
        Me.ReShuffleDeckMenuItem.Name = "ReShuffleDeckMenuItem"
        Me.ReShuffleDeckMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ReShuffleDeckMenuItem.Text = "Re-Shuffle Deck"
        '
        'AboutMenuItem
        '
        Me.AboutMenuItem.Name = "AboutMenuItem"
        Me.AboutMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutMenuItem.Text = "About"
        '
        'QuitMenuItem
        '
        Me.QuitMenuItem.Name = "QuitMenuItem"
        Me.QuitMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.QuitMenuItem.Text = "Quit"
        '
        'Player2CardPictureBox
        '
        Me.Player2CardPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Player2CardPictureBox.Location = New System.Drawing.Point(597, 150)
        Me.Player2CardPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2CardPictureBox.Name = "Player2CardPictureBox"
        Me.Player2CardPictureBox.Size = New System.Drawing.Size(83, 114)
        Me.Player2CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player2CardPictureBox.TabIndex = 13
        Me.Player2CardPictureBox.TabStop = False
        '
        'Player1CardPictureBox
        '
        Me.Player1CardPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Player1CardPictureBox.Location = New System.Drawing.Point(181, 150)
        Me.Player1CardPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1CardPictureBox.Name = "Player1CardPictureBox"
        Me.Player1CardPictureBox.Size = New System.Drawing.Size(83, 114)
        Me.Player1CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player1CardPictureBox.TabIndex = 12
        Me.Player1CardPictureBox.TabStop = False
        '
        'DeckOfCardsPictureBox
        '
        Me.DeckOfCardsPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeckOfCardsPictureBox.Location = New System.Drawing.Point(391, 191)
        Me.DeckOfCardsPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeckOfCardsPictureBox.Name = "DeckOfCardsPictureBox"
        Me.DeckOfCardsPictureBox.Size = New System.Drawing.Size(83, 114)
        Me.DeckOfCardsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DeckOfCardsPictureBox.TabIndex = 11
        Me.DeckOfCardsPictureBox.TabStop = False
        '
        'Player1ScoreTitleLabel
        '
        Me.Player1ScoreTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Player1ScoreTitleLabel.AutoSize = True
        Me.Player1ScoreTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1ScoreTitleLabel.Location = New System.Drawing.Point(156, 33)
        Me.Player1ScoreTitleLabel.Name = "Player1ScoreTitleLabel"
        Me.Player1ScoreTitleLabel.Size = New System.Drawing.Size(108, 17)
        Me.Player1ScoreTitleLabel.TabIndex = 14
        Me.Player1ScoreTitleLabel.Text = "Player 1s Score"
        '
        'Player2ScoreTitleLabel
        '
        Me.Player2ScoreTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Player2ScoreTitleLabel.AutoSize = True
        Me.Player2ScoreTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2ScoreTitleLabel.Location = New System.Drawing.Point(593, 33)
        Me.Player2ScoreTitleLabel.Name = "Player2ScoreTitleLabel"
        Me.Player2ScoreTitleLabel.Size = New System.Drawing.Size(108, 17)
        Me.Player2ScoreTitleLabel.TabIndex = 15
        Me.Player2ScoreTitleLabel.Text = "Player 2s Score"
        '
        'Player1CardsWonPictureBox
        '
        Me.Player1CardsWonPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Player1CardsWonPictureBox.Location = New System.Drawing.Point(32, 33)
        Me.Player1CardsWonPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player1CardsWonPictureBox.Name = "Player1CardsWonPictureBox"
        Me.Player1CardsWonPictureBox.Size = New System.Drawing.Size(83, 114)
        Me.Player1CardsWonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player1CardsWonPictureBox.TabIndex = 16
        Me.Player1CardsWonPictureBox.TabStop = False
        '
        'Player2CardsWonPictureBox
        '
        Me.Player2CardsWonPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Player2CardsWonPictureBox.Location = New System.Drawing.Point(752, 33)
        Me.Player2CardsWonPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Player2CardsWonPictureBox.Name = "Player2CardsWonPictureBox"
        Me.Player2CardsWonPictureBox.Size = New System.Drawing.Size(83, 114)
        Me.Player2CardsWonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Player2CardsWonPictureBox.TabIndex = 17
        Me.Player2CardsWonPictureBox.TabStop = False
        '
        'CardsLeftTitleLabel
        '
        Me.CardsLeftTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CardsLeftTitleLabel.AutoSize = True
        Me.CardsLeftTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardsLeftTitleLabel.Location = New System.Drawing.Point(400, 119)
        Me.CardsLeftTitleLabel.Name = "CardsLeftTitleLabel"
        Me.CardsLeftTitleLabel.Size = New System.Drawing.Size(73, 17)
        Me.CardsLeftTitleLabel.TabIndex = 18
        Me.CardsLeftTitleLabel.Text = "Cards Left"
        '
        'GameGUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 401)
        Me.Controls.Add(Me.CardsLeftTitleLabel)
        Me.Controls.Add(Me.Player2CardsWonPictureBox)
        Me.Controls.Add(Me.Player1CardsWonPictureBox)
        Me.Controls.Add(Me.Player2ScoreTitleLabel)
        Me.Controls.Add(Me.Player1ScoreTitleLabel)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(891, 438)
        Me.Name = "GameGUIForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Game of War"
        Me.WarMenuStrip.ResumeLayout(False)
        Me.WarMenuStrip.PerformLayout()
        CType(Me.Player2CardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1CardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeckOfCardsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1CardsWonPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2CardsWonPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Player1ScoreTitleLabel As Label
    Friend WithEvents Player2ScoreTitleLabel As Label
    Friend WithEvents Player1CardsWonPictureBox As PictureBox
    Friend WithEvents Player2CardsWonPictureBox As PictureBox
    Friend WithEvents CardsLeftTitleLabel As Label
End Class
