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
        resources.ApplyResources(Me.AcceptUpdateButton, "AcceptUpdateButton")
        Me.AcceptUpdateButton.Name = "AcceptUpdateButton"
        Me.AcceptUpdateButton.UseVisualStyleBackColor = True
        '
        'DeclineUpdateButton
        '
        resources.ApplyResources(Me.DeclineUpdateButton, "DeclineUpdateButton")
        Me.DeclineUpdateButton.Name = "DeclineUpdateButton"
        Me.DeclineUpdateButton.UseVisualStyleBackColor = True
        '
        'DownloadProgressBar
        '
        resources.ApplyResources(Me.DownloadProgressBar, "DownloadProgressBar")
        Me.DownloadProgressBar.Name = "DownloadProgressBar"
        '
        'TitleLabel
        '
        resources.ApplyResources(Me.TitleLabel, "TitleLabel")
        Me.TitleLabel.Name = "TitleLabel"
        '
        'NewsRichTextBox
        '
        resources.ApplyResources(Me.NewsRichTextBox, "NewsRichTextBox")
        Me.NewsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NewsRichTextBox.Name = "NewsRichTextBox"
        '
        'FormUpdater
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.DownloadProgressBar)
        Me.Controls.Add(Me.DeclineUpdateButton)
        Me.Controls.Add(Me.AcceptUpdateButton)
        Me.Controls.Add(Me.NewsRichTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AcceptUpdateButton As Button
    Friend WithEvents DeclineUpdateButton As Button
    Friend WithEvents DownloadProgressBar As ProgressBar
    Friend WithEvents TitleLabel As Label
    Friend WithEvents NewsRichTextBox As RichTextBox
End Class
