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
        Me.TextColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextInWhiteCheckBox = New System.Windows.Forms.CheckBox()
        Me.NoteColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.BlueNoteColorRadioButton5 = New System.Windows.Forms.RadioButton()
        Me.OrangeNoteColorRadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GreyNoteColorRadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GreenNoteColorRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RedNoteColorRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.YellowNoteColorRadioButton1 = New System.Windows.Forms.RadioButton()
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
        Me.SettingsTabControl.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.TextColorGroupBox.SuspendLayout()
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
        Me.GeneralTabPage.Controls.Add(Me.TextColorGroupBox)
        Me.GeneralTabPage.Controls.Add(Me.NoteColorGroupBox)
        Me.GeneralTabPage.Location = New System.Drawing.Point(4, 24)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralTabPage.Size = New System.Drawing.Size(484, 256)
        Me.GeneralTabPage.TabIndex = 0
        Me.GeneralTabPage.Text = "Général"
        Me.GeneralTabPage.UseVisualStyleBackColor = True
        '
        'TextColorGroupBox
        '
        Me.TextColorGroupBox.Controls.Add(Me.TextInWhiteCheckBox)
        Me.TextColorGroupBox.Location = New System.Drawing.Point(7, 109)
        Me.TextColorGroupBox.Name = "TextColorGroupBox"
        Me.TextColorGroupBox.Size = New System.Drawing.Size(471, 53)
        Me.TextColorGroupBox.TabIndex = 1
        Me.TextColorGroupBox.TabStop = False
        Me.TextColorGroupBox.Text = "Couleur du texte"
        '
        'TextInWhiteCheckBox
        '
        Me.TextInWhiteCheckBox.AutoSize = True
        Me.TextInWhiteCheckBox.Location = New System.Drawing.Point(7, 23)
        Me.TextInWhiteCheckBox.Name = "TextInWhiteCheckBox"
        Me.TextInWhiteCheckBox.Size = New System.Drawing.Size(222, 19)
        Me.TextInWhiteCheckBox.TabIndex = 0
        Me.TextInWhiteCheckBox.Text = "Écrire le texte en blanc au lieu du noir"
        Me.TextInWhiteCheckBox.UseVisualStyleBackColor = True
        '
        'NoteColorGroupBox
        '
        Me.NoteColorGroupBox.Controls.Add(Me.BlueNoteColorRadioButton5)
        Me.NoteColorGroupBox.Controls.Add(Me.OrangeNoteColorRadioButton6)
        Me.NoteColorGroupBox.Controls.Add(Me.GreyNoteColorRadioButton4)
        Me.NoteColorGroupBox.Controls.Add(Me.GreenNoteColorRadioButton3)
        Me.NoteColorGroupBox.Controls.Add(Me.RedNoteColorRadioButton2)
        Me.NoteColorGroupBox.Controls.Add(Me.YellowNoteColorRadioButton1)
        Me.NoteColorGroupBox.Location = New System.Drawing.Point(7, 7)
        Me.NoteColorGroupBox.Name = "NoteColorGroupBox"
        Me.NoteColorGroupBox.Size = New System.Drawing.Size(471, 95)
        Me.NoteColorGroupBox.TabIndex = 0
        Me.NoteColorGroupBox.TabStop = False
        Me.NoteColorGroupBox.Text = "Couleur des notes"
        '
        'BlueNoteColorRadioButton5
        '
        Me.BlueNoteColorRadioButton5.AutoSize = True
        Me.BlueNoteColorRadioButton5.Location = New System.Drawing.Point(143, 43)
        Me.BlueNoteColorRadioButton5.Name = "BlueNoteColorRadioButton5"
        Me.BlueNoteColorRadioButton5.Size = New System.Drawing.Size(48, 19)
        Me.BlueNoteColorRadioButton5.TabIndex = 5
        Me.BlueNoteColorRadioButton5.TabStop = True
        Me.BlueNoteColorRadioButton5.Text = "Bleu"
        Me.BlueNoteColorRadioButton5.UseVisualStyleBackColor = True
        '
        'OrangeNoteColorRadioButton6
        '
        Me.OrangeNoteColorRadioButton6.AutoSize = True
        Me.OrangeNoteColorRadioButton6.Location = New System.Drawing.Point(143, 64)
        Me.OrangeNoteColorRadioButton6.Name = "OrangeNoteColorRadioButton6"
        Me.OrangeNoteColorRadioButton6.Size = New System.Drawing.Size(64, 19)
        Me.OrangeNoteColorRadioButton6.TabIndex = 4
        Me.OrangeNoteColorRadioButton6.TabStop = True
        Me.OrangeNoteColorRadioButton6.Text = "Orange"
        Me.OrangeNoteColorRadioButton6.UseVisualStyleBackColor = True
        '
        'GreyNoteColorRadioButton4
        '
        Me.GreyNoteColorRadioButton4.AutoSize = True
        Me.GreyNoteColorRadioButton4.Location = New System.Drawing.Point(143, 22)
        Me.GreyNoteColorRadioButton4.Name = "GreyNoteColorRadioButton4"
        Me.GreyNoteColorRadioButton4.Size = New System.Drawing.Size(45, 19)
        Me.GreyNoteColorRadioButton4.TabIndex = 3
        Me.GreyNoteColorRadioButton4.TabStop = True
        Me.GreyNoteColorRadioButton4.Text = "Gris"
        Me.GreyNoteColorRadioButton4.UseVisualStyleBackColor = True
        '
        'GreenNoteColorRadioButton3
        '
        Me.GreenNoteColorRadioButton3.AutoSize = True
        Me.GreenNoteColorRadioButton3.Location = New System.Drawing.Point(6, 64)
        Me.GreenNoteColorRadioButton3.Name = "GreenNoteColorRadioButton3"
        Me.GreenNoteColorRadioButton3.Size = New System.Drawing.Size(45, 19)
        Me.GreenNoteColorRadioButton3.TabIndex = 2
        Me.GreenNoteColorRadioButton3.TabStop = True
        Me.GreenNoteColorRadioButton3.Text = "Vert"
        Me.GreenNoteColorRadioButton3.UseVisualStyleBackColor = True
        '
        'RedNoteColorRadioButton2
        '
        Me.RedNoteColorRadioButton2.AutoSize = True
        Me.RedNoteColorRadioButton2.Location = New System.Drawing.Point(6, 43)
        Me.RedNoteColorRadioButton2.Name = "RedNoteColorRadioButton2"
        Me.RedNoteColorRadioButton2.Size = New System.Drawing.Size(59, 19)
        Me.RedNoteColorRadioButton2.TabIndex = 1
        Me.RedNoteColorRadioButton2.TabStop = True
        Me.RedNoteColorRadioButton2.Text = "Rouge"
        Me.RedNoteColorRadioButton2.UseVisualStyleBackColor = True
        '
        'YellowNoteColorRadioButton1
        '
        Me.YellowNoteColorRadioButton1.AutoSize = True
        Me.YellowNoteColorRadioButton1.Location = New System.Drawing.Point(6, 22)
        Me.YellowNoteColorRadioButton1.Name = "YellowNoteColorRadioButton1"
        Me.YellowNoteColorRadioButton1.Size = New System.Drawing.Size(120, 19)
        Me.YellowNoteColorRadioButton1.TabIndex = 0
        Me.YellowNoteColorRadioButton1.TabStop = True
        Me.YellowNoteColorRadioButton1.Text = "Jaune (par défaut)"
        Me.YellowNoteColorRadioButton1.UseVisualStyleBackColor = True
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
        Me.TextColorGroupBox.ResumeLayout(False)
        Me.TextColorGroupBox.PerformLayout()
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
    Friend WithEvents TextColorGroupBox As GroupBox
    Friend WithEvents TextInWhiteCheckBox As CheckBox
    Friend WithEvents NoteColorGroupBox As GroupBox
    Friend WithEvents BlueNoteColorRadioButton5 As RadioButton
    Friend WithEvents OrangeNoteColorRadioButton6 As RadioButton
    Friend WithEvents GreyNoteColorRadioButton4 As RadioButton
    Friend WithEvents GreenNoteColorRadioButton3 As RadioButton
    Friend WithEvents RedNoteColorRadioButton2 As RadioButton
    Friend WithEvents YellowNoteColorRadioButton1 As RadioButton
    Friend WithEvents RestartWarningLabel As Label
    Friend WithEvents SettingsRestoreGroupBox As GroupBox
    Friend WithEvents RestorePreviousSettingsButton As Button
End Class
