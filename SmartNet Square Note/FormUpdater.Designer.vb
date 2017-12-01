<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdater
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdater))
        Me.AcceptUpdateButton = New System.Windows.Forms.Button()
        Me.DeclineUpdateButton = New System.Windows.Forms.Button()
        Me.DownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.NewsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'AcceptUpdateButton
        '
        Me.AcceptUpdateButton.Location = New System.Drawing.Point(12, 266)
        Me.AcceptUpdateButton.Name = "AcceptUpdateButton"
        Me.AcceptUpdateButton.Size = New System.Drawing.Size(247, 23)
        Me.AcceptUpdateButton.TabIndex = 0
        Me.AcceptUpdateButton.Text = "Installer la mise à jour maintenant"
        Me.AcceptUpdateButton.UseVisualStyleBackColor = True
        '
        'DeclineUpdateButton
        '
        Me.DeclineUpdateButton.Location = New System.Drawing.Point(265, 266)
        Me.DeclineUpdateButton.Name = "DeclineUpdateButton"
        Me.DeclineUpdateButton.Size = New System.Drawing.Size(115, 23)
        Me.DeclineUpdateButton.TabIndex = 1
        Me.DeclineUpdateButton.Text = "Plus tard"
        Me.DeclineUpdateButton.UseVisualStyleBackColor = True
        '
        'DownloadProgressBar
        '
        Me.DownloadProgressBar.Location = New System.Drawing.Point(12, 237)
        Me.DownloadProgressBar.Name = "DownloadProgressBar"
        Me.DownloadProgressBar.Size = New System.Drawing.Size(367, 23)
        Me.DownloadProgressBar.TabIndex = 2
        Me.DownloadProgressBar.Visible = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(368, 19)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Une mise à jour est disponible pour SmartNet Square Note"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NewsRichTextBox
        '
        Me.NewsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NewsRichTextBox.Location = New System.Drawing.Point(12, 36)
        Me.NewsRichTextBox.Name = "NewsRichTextBox"
        Me.NewsRichTextBox.Size = New System.Drawing.Size(367, 224)
        Me.NewsRichTextBox.TabIndex = 4
        Me.NewsRichTextBox.Text = ""
        '
        'FormUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 301)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.DownloadProgressBar)
        Me.Controls.Add(Me.DeclineUpdateButton)
        Me.Controls.Add(Me.AcceptUpdateButton)
        Me.Controls.Add(Me.NewsRichTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdater"
        Me.ShowInTaskbar = False
        Me.Text = "Nouvelle mise à jour disponible"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AcceptUpdateButton As Button
    Friend WithEvents DeclineUpdateButton As Button
    Friend WithEvents DownloadProgressBar As ProgressBar
    Friend WithEvents TitleLabel As Label
    Friend WithEvents NewsRichTextBox As RichTextBox
End Class
