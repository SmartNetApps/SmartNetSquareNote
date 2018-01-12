<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SettingsTabControl = New System.Windows.Forms.TabControl()
        Me.GeneralTabPage = New System.Windows.Forms.TabPage()
        Me.TextFontAndColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.NoteColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdatesTabPage = New System.Windows.Forms.TabPage()
        Me.VersionNumberGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdatesSearchButton = New System.Windows.Forms.Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.AutoUpdateGroupBox = New System.Windows.Forms.GroupBox()
        Me.AutoUpdateCheckBox = New System.Windows.Forms.CheckBox()
        Me.AdvancedTabPage = New System.Windows.Forms.TabPage()
        Me.SettingsRestoreGroupBox = New System.Windows.Forms.GroupBox()
        Me.RestorePreviousSettingsButton = New System.Windows.Forms.Button()
        Me.RestartWarningLabel = New System.Windows.Forms.Label()
        Me.NoteColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ChangeNoteColorButton = New System.Windows.Forms.Button()
        Me.RestoreDefaultNoteColorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TextColorDialog = New System.Windows.Forms.ColorDialog()
        Me.TextFontDialog = New System.Windows.Forms.FontDialog()
        Me.ChangeTextColorButton = New System.Windows.Forms.Button()
        Me.RestoreTextStyleLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ChangeTextFontButton = New System.Windows.Forms.Button()
        Me.SettingsTabControl.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.TextFontAndColorGroupBox.SuspendLayout()
        Me.NoteColorGroupBox.SuspendLayout()
        Me.UpdatesTabPage.SuspendLayout()
        Me.VersionNumberGroupBox.SuspendLayout()
        Me.AutoUpdateGroupBox.SuspendLayout()
        Me.AdvancedTabPage.SuspendLayout()
        Me.SettingsRestoreGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(419, 296)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SettingsTabControl
        '
        Me.SettingsTabControl.Controls.Add(Me.GeneralTabPage)
        Me.SettingsTabControl.Controls.Add(Me.UpdatesTabPage)
        Me.SettingsTabControl.Controls.Add(Me.AdvancedTabPage)
        Me.SettingsTabControl.Location = New System.Drawing.Point(6, 6)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.SelectedIndex = 0
        Me.SettingsTabControl.Size = New System.Drawing.Size(492, 284)
        Me.SettingsTabControl.TabIndex = 1
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Controls.Add(Me.TextFontAndColorGroupBox)
        Me.GeneralTabPage.Controls.Add(Me.NoteColorGroupBox)
        Me.GeneralTabPage.Location = New System.Drawing.Point(4, 24)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralTabPage.Size = New System.Drawing.Size(484, 256)
        Me.GeneralTabPage.TabIndex = 0
        Me.GeneralTabPage.Text = "Général"
        Me.GeneralTabPage.UseVisualStyleBackColor = True
        '
        'TextFontAndColorGroupBox
        '
        Me.TextFontAndColorGroupBox.Controls.Add(Me.ChangeTextFontButton)
        Me.TextFontAndColorGroupBox.Controls.Add(Me.RestoreTextStyleLinkLabel)
        Me.TextFontAndColorGroupBox.Controls.Add(Me.ChangeTextColorButton)
        Me.TextFontAndColorGroupBox.Location = New System.Drawing.Point(7, 86)
        Me.TextFontAndColorGroupBox.Name = "TextFontAndColorGroupBox"
        Me.TextFontAndColorGroupBox.Size = New System.Drawing.Size(471, 106)
        Me.TextFontAndColorGroupBox.TabIndex = 1
        Me.TextFontAndColorGroupBox.TabStop = False
        Me.TextFontAndColorGroupBox.Text = "Police et couleur du texte"
        '
        'NoteColorGroupBox
        '
        Me.NoteColorGroupBox.Controls.Add(Me.RestoreDefaultNoteColorLinkLabel)
        Me.NoteColorGroupBox.Controls.Add(Me.ChangeNoteColorButton)
        Me.NoteColorGroupBox.Location = New System.Drawing.Point(7, 7)
        Me.NoteColorGroupBox.Name = "NoteColorGroupBox"
        Me.NoteColorGroupBox.Size = New System.Drawing.Size(471, 73)
        Me.NoteColorGroupBox.TabIndex = 0
        Me.NoteColorGroupBox.TabStop = False
        Me.NoteColorGroupBox.Text = "Couleur des notes"
        '
        'UpdatesTabPage
        '
        Me.UpdatesTabPage.Controls.Add(Me.VersionNumberGroupBox)
        Me.UpdatesTabPage.Controls.Add(Me.AutoUpdateGroupBox)
        Me.UpdatesTabPage.Location = New System.Drawing.Point(4, 24)
        Me.UpdatesTabPage.Name = "UpdatesTabPage"
        Me.UpdatesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdatesTabPage.Size = New System.Drawing.Size(484, 256)
        Me.UpdatesTabPage.TabIndex = 1
        Me.UpdatesTabPage.Text = "Mises à jour"
        Me.UpdatesTabPage.UseVisualStyleBackColor = True
        '
        'VersionNumberGroupBox
        '
        Me.VersionNumberGroupBox.Controls.Add(Me.UpdatesSearchButton)
        Me.VersionNumberGroupBox.Controls.Add(Me.VersionLabel)
        Me.VersionNumberGroupBox.Location = New System.Drawing.Point(7, 66)
        Me.VersionNumberGroupBox.Name = "VersionNumberGroupBox"
        Me.VersionNumberGroupBox.Size = New System.Drawing.Size(471, 70)
        Me.VersionNumberGroupBox.TabIndex = 1
        Me.VersionNumberGroupBox.TabStop = False
        Me.VersionNumberGroupBox.Text = "Gérer les mises à jour"
        '
        'UpdatesSearchButton
        '
        Me.UpdatesSearchButton.Location = New System.Drawing.Point(7, 39)
        Me.UpdatesSearchButton.Name = "UpdatesSearchButton"
        Me.UpdatesSearchButton.Size = New System.Drawing.Size(240, 23)
        Me.UpdatesSearchButton.TabIndex = 1
        Me.UpdatesSearchButton.Text = "Rechercher les mises à jour maintenant"
        Me.UpdatesSearchButton.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(4, 21)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(133, 15)
        Me.VersionLabel.TabIndex = 0
        Me.VersionLabel.Text = "Version installée : 0.0.0.0"
        '
        'AutoUpdateGroupBox
        '
        Me.AutoUpdateGroupBox.Controls.Add(Me.AutoUpdateCheckBox)
        Me.AutoUpdateGroupBox.Location = New System.Drawing.Point(7, 7)
        Me.AutoUpdateGroupBox.Name = "AutoUpdateGroupBox"
        Me.AutoUpdateGroupBox.Size = New System.Drawing.Size(471, 52)
        Me.AutoUpdateGroupBox.TabIndex = 0
        Me.AutoUpdateGroupBox.TabStop = False
        Me.AutoUpdateGroupBox.Text = "Recherche automatique"
        '
        'AutoUpdateCheckBox
        '
        Me.AutoUpdateCheckBox.AutoSize = True
        Me.AutoUpdateCheckBox.Location = New System.Drawing.Point(7, 23)
        Me.AutoUpdateCheckBox.Name = "AutoUpdateCheckBox"
        Me.AutoUpdateCheckBox.Size = New System.Drawing.Size(349, 19)
        Me.AutoUpdateCheckBox.TabIndex = 0
        Me.AutoUpdateCheckBox.Text = "Rechercher les mises à jour automatiquement (recommandé)"
        Me.AutoUpdateCheckBox.UseVisualStyleBackColor = True
        '
        'AdvancedTabPage
        '
        Me.AdvancedTabPage.Controls.Add(Me.SettingsRestoreGroupBox)
        Me.AdvancedTabPage.Location = New System.Drawing.Point(4, 24)
        Me.AdvancedTabPage.Name = "AdvancedTabPage"
        Me.AdvancedTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AdvancedTabPage.Size = New System.Drawing.Size(484, 256)
        Me.AdvancedTabPage.TabIndex = 2
        Me.AdvancedTabPage.Text = "Paramètres avancés"
        Me.AdvancedTabPage.UseVisualStyleBackColor = True
        '
        'SettingsRestoreGroupBox
        '
        Me.SettingsRestoreGroupBox.Controls.Add(Me.RestorePreviousSettingsButton)
        Me.SettingsRestoreGroupBox.Location = New System.Drawing.Point(7, 7)
        Me.SettingsRestoreGroupBox.Name = "SettingsRestoreGroupBox"
        Me.SettingsRestoreGroupBox.Size = New System.Drawing.Size(471, 57)
        Me.SettingsRestoreGroupBox.TabIndex = 0
        Me.SettingsRestoreGroupBox.TabStop = False
        Me.SettingsRestoreGroupBox.Text = "Restaurer les paramètres établis avant mise à jour"
        '
        'RestorePreviousSettingsButton
        '
        Me.RestorePreviousSettingsButton.Location = New System.Drawing.Point(7, 23)
        Me.RestorePreviousSettingsButton.Name = "RestorePreviousSettingsButton"
        Me.RestorePreviousSettingsButton.Size = New System.Drawing.Size(298, 23)
        Me.RestorePreviousSettingsButton.TabIndex = 0
        Me.RestorePreviousSettingsButton.Text = "Restaurer les paramètres de la version précédente"
        Me.RestorePreviousSettingsButton.UseVisualStyleBackColor = True
        '
        'RestartWarningLabel
        '
        Me.RestartWarningLabel.AutoSize = True
        Me.RestartWarningLabel.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartWarningLabel.Location = New System.Drawing.Point(100, 302)
        Me.RestartWarningLabel.Name = "RestartWarningLabel"
        Me.RestartWarningLabel.Size = New System.Drawing.Size(313, 12)
        Me.RestartWarningLabel.TabIndex = 2
        Me.RestartWarningLabel.Text = "*Certains paramètres seront appliqués à l'ouverture de nouvelles notes."
        Me.RestartWarningLabel.Visible = False
        '
        'ChangeNoteColorButton
        '
        Me.ChangeNoteColorButton.Location = New System.Drawing.Point(7, 22)
        Me.ChangeNoteColorButton.Name = "ChangeNoteColorButton"
        Me.ChangeNoteColorButton.Size = New System.Drawing.Size(193, 23)
        Me.ChangeNoteColorButton.TabIndex = 0
        Me.ChangeNoteColorButton.Text = "Changer la couleur des notes..."
        Me.ChangeNoteColorButton.UseVisualStyleBackColor = True
        '
        'RestoreDefaultNoteColorLinkLabel
        '
        Me.RestoreDefaultNoteColorLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultNoteColorLinkLabel.AutoSize = True
        Me.RestoreDefaultNoteColorLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultNoteColorLinkLabel.Location = New System.Drawing.Point(6, 48)
        Me.RestoreDefaultNoteColorLinkLabel.Name = "RestoreDefaultNoteColorLinkLabel"
        Me.RestoreDefaultNoteColorLinkLabel.Size = New System.Drawing.Size(168, 15)
        Me.RestoreDefaultNoteColorLinkLabel.TabIndex = 1
        Me.RestoreDefaultNoteColorLinkLabel.TabStop = True
        Me.RestoreDefaultNoteColorLinkLabel.Text = "Restaurer la couleur par défaut"
        Me.RestoreDefaultNoteColorLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'ChangeTextColorButton
        '
        Me.ChangeTextColorButton.Location = New System.Drawing.Point(7, 22)
        Me.ChangeTextColorButton.Name = "ChangeTextColorButton"
        Me.ChangeTextColorButton.Size = New System.Drawing.Size(193, 23)
        Me.ChangeTextColorButton.TabIndex = 0
        Me.ChangeTextColorButton.Text = "Changer la couleur du texte..."
        Me.ChangeTextColorButton.UseVisualStyleBackColor = True
        '
        'RestoreTextStyleLinkLabel
        '
        Me.RestoreTextStyleLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreTextStyleLinkLabel.AutoSize = True
        Me.RestoreTextStyleLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreTextStyleLinkLabel.Location = New System.Drawing.Point(6, 77)
        Me.RestoreTextStyleLinkLabel.Name = "RestoreTextStyleLinkLabel"
        Me.RestoreTextStyleLinkLabel.Size = New System.Drawing.Size(197, 15)
        Me.RestoreTextStyleLinkLabel.TabIndex = 1
        Me.RestoreTextStyleLinkLabel.TabStop = True
        Me.RestoreTextStyleLinkLabel.Text = "Restaurer le style du texte par défaut"
        Me.RestoreTextStyleLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'ChangeTextFontButton
        '
        Me.ChangeTextFontButton.Location = New System.Drawing.Point(7, 51)
        Me.ChangeTextFontButton.Name = "ChangeTextFontButton"
        Me.ChangeTextFontButton.Size = New System.Drawing.Size(193, 23)
        Me.ChangeTextFontButton.TabIndex = 2
        Me.ChangeTextFontButton.Text = "Personnaliser la police du texte..."
        Me.ChangeTextFontButton.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 331)
        Me.Controls.Add(Me.RestartWarningLabel)
        Me.Controls.Add(Me.SettingsTabControl)
        Me.Controls.Add(Me.OKButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.Text = "Paramètres"
        Me.SettingsTabControl.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.TextFontAndColorGroupBox.ResumeLayout(False)
        Me.TextFontAndColorGroupBox.PerformLayout()
        Me.NoteColorGroupBox.ResumeLayout(False)
        Me.NoteColorGroupBox.PerformLayout()
        Me.UpdatesTabPage.ResumeLayout(False)
        Me.VersionNumberGroupBox.ResumeLayout(False)
        Me.VersionNumberGroupBox.PerformLayout()
        Me.AutoUpdateGroupBox.ResumeLayout(False)
        Me.AutoUpdateGroupBox.PerformLayout()
        Me.AdvancedTabPage.ResumeLayout(False)
        Me.SettingsRestoreGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OKButton As Button
    Friend WithEvents SettingsTabControl As TabControl
    Friend WithEvents GeneralTabPage As TabPage
    Friend WithEvents UpdatesTabPage As TabPage
    Friend WithEvents AdvancedTabPage As TabPage
    Friend WithEvents AutoUpdateGroupBox As GroupBox
    Friend WithEvents AutoUpdateCheckBox As CheckBox
    Friend WithEvents VersionNumberGroupBox As GroupBox
    Friend WithEvents UpdatesSearchButton As Button
    Friend WithEvents VersionLabel As Label
    Friend WithEvents TextFontAndColorGroupBox As GroupBox
    Friend WithEvents NoteColorGroupBox As GroupBox
    Friend WithEvents RestartWarningLabel As Label
    Friend WithEvents SettingsRestoreGroupBox As GroupBox
    Friend WithEvents RestorePreviousSettingsButton As Button
    Friend WithEvents RestoreDefaultNoteColorLinkLabel As LinkLabel
    Friend WithEvents ChangeNoteColorButton As Button
    Friend WithEvents NoteColorDialog As ColorDialog
    Friend WithEvents TextColorDialog As ColorDialog
    Friend WithEvents TextFontDialog As FontDialog
    Friend WithEvents ChangeTextFontButton As Button
    Friend WithEvents RestoreTextStyleLinkLabel As LinkLabel
    Friend WithEvents ChangeTextColorButton As Button
End Class
