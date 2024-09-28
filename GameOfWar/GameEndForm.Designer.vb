<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameEndForm
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
        Me.GameEndRestartButton = New System.Windows.Forms.Button()
        Me.CongratsLabel = New System.Windows.Forms.Label()
        Me.Player1Label = New System.Windows.Forms.Label()
        Me.Player2Label = New System.Windows.Forms.Label()
        Me.Player1ScoreLabel = New System.Windows.Forms.Label()
        Me.Player2ScoreLabel = New System.Windows.Forms.Label()
        Me.Player1PlacementLabel = New System.Windows.Forms.Label()
        Me.Player2PlacementLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GameEndRestartButton
        '
        Me.GameEndRestartButton.Location = New System.Drawing.Point(74, 211)
        Me.GameEndRestartButton.Name = "GameEndRestartButton"
        Me.GameEndRestartButton.Size = New System.Drawing.Size(391, 43)
        Me.GameEndRestartButton.TabIndex = 0
        Me.GameEndRestartButton.Text = "Play Again"
        Me.GameEndRestartButton.UseVisualStyleBackColor = True
        '
        'CongratsLabel
        '
        Me.CongratsLabel.AutoSize = True
        Me.CongratsLabel.Location = New System.Drawing.Point(154, 27)
        Me.CongratsLabel.Name = "CongratsLabel"
        Me.CongratsLabel.Size = New System.Drawing.Size(221, 13)
        Me.CongratsLabel.TabIndex = 1
        Me.CongratsLabel.Text = "Congratulations Player 1.  YOU  HAVE WON!"
        '
        'Player1Label
        '
        Me.Player1Label.AutoSize = True
        Me.Player1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1Label.Location = New System.Drawing.Point(85, 79)
        Me.Player1Label.Name = "Player1Label"
        Me.Player1Label.Size = New System.Drawing.Size(76, 13)
        Me.Player1Label.TabIndex = 2
        Me.Player1Label.Text = "Player 1 Score"
        '
        'Player2Label
        '
        Me.Player2Label.AutoSize = True
        Me.Player2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2Label.Location = New System.Drawing.Point(403, 79)
        Me.Player2Label.Name = "Player2Label"
        Me.Player2Label.Size = New System.Drawing.Size(76, 13)
        Me.Player2Label.TabIndex = 3
        Me.Player2Label.Text = "Player 2 Score"
        '
        'Player1ScoreLabel
        '
        Me.Player1ScoreLabel.AutoSize = True
        Me.Player1ScoreLabel.Location = New System.Drawing.Point(116, 100)
        Me.Player1ScoreLabel.Name = "Player1ScoreLabel"
        Me.Player1ScoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.Player1ScoreLabel.TabIndex = 4
        Me.Player1ScoreLabel.Text = "0"
        '
        'Player2ScoreLabel
        '
        Me.Player2ScoreLabel.AutoSize = True
        Me.Player2ScoreLabel.Location = New System.Drawing.Point(432, 100)
        Me.Player2ScoreLabel.Name = "Player2ScoreLabel"
        Me.Player2ScoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.Player2ScoreLabel.TabIndex = 5
        Me.Player2ScoreLabel.Text = "0"
        '
        'Player1PlacementLabel
        '
        Me.Player1PlacementLabel.AutoSize = True
        Me.Player1PlacementLabel.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1PlacementLabel.Location = New System.Drawing.Point(98, 123)
        Me.Player1PlacementLabel.Name = "Player1PlacementLabel"
        Me.Player1PlacementLabel.Size = New System.Drawing.Size(54, 34)
        Me.Player1PlacementLabel.TabIndex = 6
        Me.Player1PlacementLabel.Text = "1st"
        Me.Player1PlacementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Player2PlacementLabel
        '
        Me.Player2PlacementLabel.AutoSize = True
        Me.Player2PlacementLabel.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2PlacementLabel.Location = New System.Drawing.Point(413, 123)
        Me.Player2PlacementLabel.Name = "Player2PlacementLabel"
        Me.Player2PlacementLabel.Size = New System.Drawing.Size(66, 34)
        Me.Player2PlacementLabel.TabIndex = 7
        Me.Player2PlacementLabel.Text = "2nd"
        Me.Player2PlacementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameEndForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 266)
        Me.Controls.Add(Me.Player2PlacementLabel)
        Me.Controls.Add(Me.Player1PlacementLabel)
        Me.Controls.Add(Me.Player2ScoreLabel)
        Me.Controls.Add(Me.Player1ScoreLabel)
        Me.Controls.Add(Me.Player2Label)
        Me.Controls.Add(Me.Player1Label)
        Me.Controls.Add(Me.CongratsLabel)
        Me.Controls.Add(Me.GameEndRestartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GameEndForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Over!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameEndRestartButton As Button
    Friend WithEvents CongratsLabel As Label
    Friend WithEvents Player1Label As Label
    Friend WithEvents Player2Label As Label
    Friend WithEvents Player1ScoreLabel As Label
    Friend WithEvents Player2ScoreLabel As Label
    Friend WithEvents Player1PlacementLabel As Label
    Friend WithEvents Player2PlacementLabel As Label
End Class
