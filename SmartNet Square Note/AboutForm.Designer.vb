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
        Me.DesignationPictureBox = New System.Windows.Forms.PictureBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.DescriptionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.HomepageLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LicenseLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LicensePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignationPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicensePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.ErrorImage = CType(resources.GetObject("LogoPictureBox.ErrorImage"), System.Drawing.Image)
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.InitialImage = CType(resources.GetObject("LogoPictureBox.InitialImage"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(173, 172)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'DesignationPictureBox
        '
        Me.DesignationPictureBox.Image = CType(resources.GetObject("DesignationPictureBox.Image"), System.Drawing.Image)
        Me.DesignationPictureBox.Location = New System.Drawing.Point(191, 12)
        Me.DesignationPictureBox.Name = "DesignationPictureBox"
        Me.DesignationPictureBox.Size = New System.Drawing.Size(360, 32)
        Me.DesignationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DesignationPictureBox.TabIndex = 1
        Me.DesignationPictureBox.TabStop = False
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(188, 43)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(99, 19)
        Me.VersionLabel.TabIndex = 2
        Me.VersionLabel.Text = "Version 0.0.0.0"
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.Location = New System.Drawing.Point(189, 62)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(168, 15)
        Me.CopyrightLabel.TabIndex = 3
        Me.CopyrightLabel.Text = "(C) 2016-2017, Quentin Pugeat"
        '
        'DescriptionRichTextBox
        '
        Me.DescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DescriptionRichTextBox.Enabled = False
        Me.DescriptionRichTextBox.Location = New System.Drawing.Point(191, 86)
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.ReadOnly = True
        Me.DescriptionRichTextBox.Size = New System.Drawing.Size(497, 53)
        Me.DescriptionRichTextBox.TabIndex = 4
        Me.DescriptionRichTextBox.Text = "Rédigez et collez des petits penses-bêtes sur votre Bureau Windows !"
        '
        'HomepageLinkLabel
        '
        Me.HomepageLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.HomepageLinkLabel.AutoSize = True
        Me.HomepageLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.HomepageLinkLabel.Location = New System.Drawing.Point(212, 195)
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
        Me.LicenseLinkLabel.Location = New System.Drawing.Point(400, 195)
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
        Me.LicensePictureBox.Location = New System.Drawing.Point(443, 195)
        Me.LicensePictureBox.Name = "LicensePictureBox"
        Me.LicensePictureBox.Size = New System.Drawing.Size(44, 15)
        Me.LicensePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LicensePictureBox.TabIndex = 8
        Me.LicensePictureBox.TabStop = False
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 219)
        Me.Controls.Add(Me.LicensePictureBox)
        Me.Controls.Add(Me.LicenseLinkLabel)
        Me.Controls.Add(Me.HomepageLinkLabel)
        Me.Controls.Add(Me.DescriptionRichTextBox)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.DesignationPictureBox)
        Me.Controls.Add(Me.LogoPictureBox)
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
        CType(Me.DesignationPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicensePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents DesignationPictureBox As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents CopyrightLabel As Label
    Friend WithEvents DescriptionRichTextBox As RichTextBox
    Friend WithEvents HomepageLinkLabel As LinkLabel
    Friend WithEvents LicenseLinkLabel As LinkLabel
    Friend WithEvents LicensePictureBox As PictureBox
End Class
