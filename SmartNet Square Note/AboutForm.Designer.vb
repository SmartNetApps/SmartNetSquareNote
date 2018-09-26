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
        Me.LogoPictureBox.ErrorImage = CType(resources.GetObject("LogoPictureBox.ErrorImage"), System.Drawing.Image)
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.InitialImage = CType(resources.GetObject("LogoPictureBox.InitialImage"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(7, 94)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(137, 137)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(150, 94)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(116, 21)
        Me.VersionLabel.TabIndex = 2
        Me.VersionLabel.Text = "Version 0.0.0.0"
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyrightLabel.Location = New System.Drawing.Point(150, 115)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(199, 19)
        Me.CopyrightLabel.TabIndex = 3
        Me.CopyrightLabel.Text = "© 2016-2018, Quentin Pugeat"
        '
        'DescriptionRichTextBox
        '
        Me.DescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DescriptionRichTextBox.Enabled = False
        Me.DescriptionRichTextBox.Location = New System.Drawing.Point(154, 137)
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.ReadOnly = True
        Me.DescriptionRichTextBox.Size = New System.Drawing.Size(532, 94)
        Me.DescriptionRichTextBox.TabIndex = 4
        Me.DescriptionRichTextBox.Text = "Rédigez et collez des petits penses-bêtes sur votre Bureau Windows !"
        '
        'HomepageLinkLabel
        '
        Me.HomepageLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.HomepageLinkLabel.AutoSize = True
        Me.HomepageLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.HomepageLinkLabel.Location = New System.Drawing.Point(60, 21)
        Me.HomepageLinkLabel.Name = "HomepageLinkLabel"
        Me.HomepageLinkLabel.Size = New System.Drawing.Size(167, 15)
        Me.HomepageLinkLabel.TabIndex = 5
        Me.HomepageLinkLabel.TabStop = True
        Me.HomepageLinkLabel.Text = "Page d'accueil de l'application"
        Me.HomepageLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'LicenseLinkLabel
        '
        Me.LicenseLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LicenseLinkLabel.AutoSize = True
        Me.LicenseLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LicenseLinkLabel.Location = New System.Drawing.Point(361, 21)
        Me.LicenseLinkLabel.Name = "LicenseLinkLabel"
        Me.LicenseLinkLabel.Size = New System.Drawing.Size(47, 15)
        Me.LicenseLinkLabel.TabIndex = 7
        Me.LicenseLinkLabel.TabStop = True
        Me.LicenseLinkLabel.Text = "Licence"
        Me.LicenseLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'LicensePictureBox
        '
        Me.LicensePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LicensePictureBox.ErrorImage = CType(resources.GetObject("LicensePictureBox.ErrorImage"), System.Drawing.Image)
        Me.LicensePictureBox.Image = CType(resources.GetObject("LicensePictureBox.Image"), System.Drawing.Image)
        Me.LicensePictureBox.InitialImage = CType(resources.GetObject("LicensePictureBox.InitialImage"), System.Drawing.Image)
        Me.LicensePictureBox.Location = New System.Drawing.Point(404, 21)
        Me.LicensePictureBox.Name = "LicensePictureBox"
        Me.LicensePictureBox.Size = New System.Drawing.Size(44, 15)
        Me.LicensePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LicensePictureBox.TabIndex = 8
        Me.LicensePictureBox.TabStop = False
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.Orange
        Me.PanelColor.BackgroundImage = Global.SmartNet_Square_Note.My.Resources.Resources.wordmark_white_36
        Me.PanelColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelColor.Location = New System.Drawing.Point(0, 0)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(698, 88)
        Me.PanelColor.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LinkLabelSource)
        Me.Panel1.Controls.Add(Me.LinkLabelReleaseNotes)
        Me.Panel1.Controls.Add(Me.HomepageLinkLabel)
        Me.Panel1.Controls.Add(Me.LicensePictureBox)
        Me.Panel1.Controls.Add(Me.LicenseLinkLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 58)
        Me.Panel1.TabIndex = 10
        '
        'LinkLabelSource
        '
        Me.LinkLabelSource.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelSource.AutoSize = True
        Me.LinkLabelSource.BackColor = System.Drawing.Color.White
        Me.LinkLabelSource.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelSource.Location = New System.Drawing.Point(473, 21)
        Me.LinkLabelSource.Name = "LinkLabelSource"
        Me.LinkLabelSource.Size = New System.Drawing.Size(73, 15)
        Me.LinkLabelSource.TabIndex = 9
        Me.LinkLabelSource.TabStop = True
        Me.LinkLabelSource.Text = "Code source"
        Me.LinkLabelSource.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'LinkLabelReleaseNotes
        '
        Me.LinkLabelReleaseNotes.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelReleaseNotes.AutoSize = True
        Me.LinkLabelReleaseNotes.BackColor = System.Drawing.Color.White
        Me.LinkLabelReleaseNotes.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabelReleaseNotes.Location = New System.Drawing.Point(245, 21)
        Me.LinkLabelReleaseNotes.Name = "LinkLabelReleaseNotes"
        Me.LinkLabelReleaseNotes.Size = New System.Drawing.Size(95, 15)
        Me.LinkLabelReleaseNotes.TabIndex = 9
        Me.LinkLabelReleaseNotes.TabStop = True
        Me.LinkLabelReleaseNotes.Text = "Notes de version"
        Me.LinkLabelReleaseNotes.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 296)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DescriptionRichTextBox)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.PanelColor)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "À propos de SmartNet Square Note"
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
