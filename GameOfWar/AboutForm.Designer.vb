<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.AboutCloseButton = New System.Windows.Forms.Button()
        Me.AboutTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AboutCloseButton
        '
        Me.AboutCloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutCloseButton.Location = New System.Drawing.Point(142, 158)
        Me.AboutCloseButton.Name = "AboutCloseButton"
        Me.AboutCloseButton.Size = New System.Drawing.Size(181, 49)
        Me.AboutCloseButton.TabIndex = 0
        Me.AboutCloseButton.Text = "Close"
        Me.AboutCloseButton.UseVisualStyleBackColor = True
        '
        'AboutTextBox
        '
        Me.AboutTextBox.Location = New System.Drawing.Point(21, 17)
        Me.AboutTextBox.Multiline = True
        Me.AboutTextBox.Name = "AboutTextBox"
        Me.AboutTextBox.Size = New System.Drawing.Size(436, 130)
        Me.AboutTextBox.TabIndex = 1
        Me.AboutTextBox.Text = resources.GetString("AboutTextBox.Text")
        Me.AboutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 219)
        Me.Controls.Add(Me.AboutTextBox)
        Me.Controls.Add(Me.AboutCloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About This Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutCloseButton As Button
    Friend WithEvents AboutTextBox As TextBox
End Class
