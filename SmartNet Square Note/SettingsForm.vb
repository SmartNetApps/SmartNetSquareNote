Imports System.ComponentModel
Imports System.Net
Imports System.IO.File
Imports IWshRuntimeLibrary

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

        Try
            Dim PathStartup As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
            If Exists(PathStartup & "\SmartNet Square Note.lnk") = True Then
                AutoStartupCheckBox.Checked = True
            Else
                AutoStartupCheckBox.Checked = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute le raccourci de démarrage automatique à l'ordinateur de l'utilisateur.
    ''' </summary>
    Sub AddStartup()
        'Dim Shell = New WshShell
        Dim StartupDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim objShell = New WshShell
        Dim objShortcut = objShell.CreateShortcut(StartupDir + "\SmartNet Square Note.lnk")
        objShortcut.TargetPath = """" + Application.ExecutablePath + """ -hide"
        objShortcut.Save()
    End Sub

    ''' <summary>
    ''' Supprime le raccourci de démarrage automatique de l'ordinateur de l'utilisateur.
    ''' </summary>
    Sub RemoveStartup()
        Dim PathStartup As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        System.IO.File.Delete(PathStartup & "\SmartNet Square Note.lnk")
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
        My.Settings.Save()
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
            RestartWarningLabel.Visible = True
        End If
    End Sub

    Private Sub ChangeTextColorButton_Click(sender As Object, e As EventArgs) Handles ChangeTextColorButton.Click
        If TextColorDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.TextColor = TextColorDialog.Color
            RestartWarningLabel.Visible = True
        End If
    End Sub

    Private Sub ChangeTextFontButton_Click(sender As Object, e As EventArgs) Handles ChangeTextFontButton.Click
        If TextFontDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.TextFont = TextFontDialog.Font
            RestartWarningLabel.Visible = True
        End If
    End Sub

    Private Sub RestoreDefaultNoteColorLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RestoreDefaultNoteColorLinkLabel.LinkClicked
        My.Settings.NoteColor = Color.FromArgb(255, 255, 192)
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub RestoreTextStyleLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RestoreTextStyleLinkLabel.LinkClicked
        My.Settings.TextColor = Color.Black
        My.Settings.TextFont = New Font("Comic Sans MS", 11.25)
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub SettingsForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub

    Private Sub AutoStartupCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutoStartupCheckBox.CheckedChanged
        If AutoStartupCheckBox.Checked = True Then
            AddStartup()
        Else
            RemoveStartup()
        End If
    End Sub
End Class