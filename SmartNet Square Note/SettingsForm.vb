Imports System.ComponentModel
Imports System.Net

Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = "Version installée : " + My.Application.Info.Version.ToString

        Select Case UpdateAgent.IsUpdateAvailable()
            Case UpdateAgent.UpdateStatus.UpdateAvailable
                UpdatesSearchButton.Text = "Nouvelle mise à jour disponible !"
                UpdatesSearchButton.Enabled = True
            Case Else
                UpdatesSearchButton.Text = "SmartNet Square Note est à jour"
                UpdatesSearchButton.Enabled = False
        End Select

        AutoUpdateCheckBox.Checked = My.Settings.AutoUpdates

        RestartWarningLabel.Visible = False
    End Sub

    Private Sub AutoUpdateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutoUpdateCheckBox.CheckedChanged
        If AutoUpdateCheckBox.Checked = True Then
            Select Case UpdateAgent.IsUpdateAvailable()
                Case UpdateAgent.UpdateStatus.OSNotSupported
                    MessageBox.Show("Votre système d'exploitation n'est plus supporté. Consultez le site d'assistance SmartNet Apps pour en apprendre plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    My.Settings.AutoUpdates = False
                    AutoUpdateCheckBox.Checked = False
                Case UpdateAgent.UpdateStatus.SupportStatusOff
                    MessageBox.Show("Ce logiciel a été abandonné. Consultez le site d'assistance SmartNet Apps pour en apprendre plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    My.Settings.AutoUpdates = False
                    AutoUpdateCheckBox.Checked = False
                Case Else
                    My.Settings.AutoUpdates = True
            End Select
        Else
            If My.Settings.AutoUpdates = True Then
                If MessageBox.Show("Les mises à jour permettent d'avoir les dernières fonctionnalités et assurent le meilleur fonctionnement possible du logiciel. Si vous désactivez la recherche automatique des mises à jour, vous ne recevrez plus les mises à jour dès leur parution, et vous risquez de conserver un logiciel obsolète. Êtes-vous sûr.e de vouloir les désactiver ?", "SmartNet Apps Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    My.Settings.AutoUpdates = False
                Else
                    My.Settings.AutoUpdates = True
                    AutoUpdateCheckBox.Checked = True
                End If
            Else
                My.Settings.AutoUpdates = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RestorePreviousSettingsButton.Click
        My.Settings.Upgrade()
        RestorePreviousSettingsButton.Text = "Importation terminée"
        RestorePreviousSettingsButton.Enabled = False
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub UpdatesSearchButton_Click(sender As Object, e As EventArgs) Handles UpdatesSearchButton.Click
        If UpdateAgent.IsUpdateAvailable = UpdateAgent.UpdateStatus.UpdateAvailable Then
            FormUpdater.ShowDialog()
        End If
    End Sub

    Private Sub ChangeNoteColorButton_Click(sender As Object, e As EventArgs) Handles ChangeNoteColorButton.Click
        If NoteColorDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.NoteColor = NoteColorDialog.Color
            NoteForm.BackColor = My.Settings.NoteColor
            NoteForm.NoteRichTextBox.BackColor = My.Settings.NoteColor
            NoteForm.FormDragger.BackColor = My.Settings.NoteColor
            NoteForm.MenuStrip1.BackColor = My.Settings.NoteColor
            RestartWarningLabel.Visible = True
        End If
    End Sub

    Private Sub ChangeTextColorButton_Click(sender As Object, e As EventArgs) Handles ChangeTextColorButton.Click
        If TextColorDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.TextColor = TextColorDialog.Color
            NoteForm.NoteRichTextBox.ForeColor = My.Settings.TextColor
            RestartWarningLabel.Visible = True
        End If
    End Sub

    Private Sub ChangeTextFontButton_Click(sender As Object, e As EventArgs) Handles ChangeTextFontButton.Click
        If TextFontDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.TextFont = TextFontDialog.Font
            NoteForm.NoteRichTextBox.Font = My.Settings.TextFont
            RestartWarningLabel.Visible = True
        End If
    End Sub

    Private Sub RestoreDefaultNoteColorLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RestoreDefaultNoteColorLinkLabel.LinkClicked
        My.Settings.NoteColor = Color.FromArgb(255, 255, 192)
        NoteForm.BackColor = My.Settings.NoteColor
        NoteForm.NoteRichTextBox.BackColor = My.Settings.NoteColor
        NoteForm.FormDragger.BackColor = My.Settings.NoteColor
        NoteForm.MenuStrip1.BackColor = My.Settings.NoteColor
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub RestoreTextStyleLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RestoreTextStyleLinkLabel.LinkClicked
        My.Settings.TextColor = Color.Black
        NoteForm.NoteRichTextBox.ForeColor = My.Settings.TextColor
        My.Settings.TextFont = New Font("Comic Sans MS", 11.25)
        NoteForm.NoteRichTextBox.Font = My.Settings.TextFont
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub SettingsForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
        Me.Close()
    End Sub
End Class