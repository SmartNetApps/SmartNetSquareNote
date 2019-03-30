<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.DescriptionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.HomepageLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LicenseLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LicensePictureBox = New System.Windows.Forms.PictureBox()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabelSource = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelReleaseNotes = New System.Windows.Forms.LinkLabel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicensePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        resources.ApplyResources(Me.LogoPictureBox, "LogoPictureBox")
        Me.LogoPictureBox.Image = Global.SmartNet_Square_Note.My.Resources.Resources._2019_SmartNetSquareNote_1024
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.TabStop = False
        '
        'VersionLabel
        '
        resources.ApplyResources(Me.VersionLabel, "VersionLabel")
        Me.VersionLabel.Name = "VersionLabel"
        '
        'CopyrightLabel
        '
        resources.ApplyResources(Me.CopyrightLabel, "CopyrightLabel")
        Me.CopyrightLabel.Name = "CopyrightLabel"
        '
        'DescriptionRichTextBox
        '
        resources.ApplyResources(Me.DescriptionRichTextBox, "DescriptionRichTextBox")
        Me.DescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.ReadOnly = True
        '
        'HomepageLinkLabel
        '
        resources.ApplyResources(Me.HomepageLinkLabel, "HomepageLinkLabel")
        Me.HomepageLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.HomepageLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.HomepageLinkLabel.Name = "HomepageLinkLabel"
        Me.HomepageLinkLabel.TabStop = True
        Me.HomepageLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'LicenseLinkLabel
        '
        resources.ApplyResources(Me.LicenseLinkLabel, "LicenseLinkLabel")
        Me.LicenseLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LicenseLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LicenseLinkLabel.Name = "LicenseLinkLabel"
        Me.LicenseLinkLabel.TabStop = True
        Me.LicenseLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'LicensePictureBox
        '
        resources.ApplyResources(Me.LicensePictureBox, "LicensePictureBox")
        Me.LicensePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LicensePictureBox.Name = "LicensePictureBox"
        Me.LicensePictureBox.TabStop = False
        '
        'PanelColor
        '
        resources.ApplyResources(Me.PanelColor, "PanelColor")
        Me.PanelColor.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelColor.BackgroundImage = Global.SmartNet_Square_Note.My.Resources.Resources.wordmark_white_36
        Me.PanelColor.Name = "PanelColor"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LinkLabelSource)
        Me.Panel1.Controls.Add(Me.LinkLabelReleaseNotes)
        Me.Panel1.Controls.Add(Me.HomepageLinkLabel)
        Me.Panel1.Controls.Add(Me.LicensePictureBox)
        Me.Panel1.Controls.Add(Me.LicenseLinkLabel)
        Me.Panel1.Name = "Panel1"
        '
        'LinkLabelSource
        '
        resources.ApplyResources(Me.LinkLabelSource, "LinkLabelSource")
        Me.LinkLabelSource.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelSource.BackColor = System.Drawing.Color.White
        Me.LinkLabelSource.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelSource.Name = "LinkLabelSource"
        Me.LinkLabelSource.TabStop = True
        Me.LinkLabelSource.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'LinkLabelReleaseNotes
        '
        resources.ApplyResources(Me.LinkLabelReleaseNotes, "LinkLabelReleaseNotes")
        Me.LinkLabelReleaseNotes.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelReleaseNotes.BackColor = System.Drawing.Color.White
        Me.LinkLabelReleaseNotes.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelReleaseNotes.Name = "LinkLabelReleaseNotes"
        Me.LinkLabelReleaseNotes.TabStop = True
        Me.LinkLabelReleaseNotes.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'AboutForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DescriptionRichTextBox)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.PanelColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicensePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents CopyrightLabel As Label
    Friend WithEvents DescriptionRichTextBox As RichTextBox
    Friend WithEvents HomepageLinkLabel As LinkLabel
    Friend WithEvents LicenseLinkLabel As LinkLabel
    Friend WithEvents LicensePictureBox As PictureBox
    Friend WithEvents PanelColor As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabelReleaseNotes As LinkLabel
    Friend WithEvents LinkLabelSource As LinkLabel
End Class
