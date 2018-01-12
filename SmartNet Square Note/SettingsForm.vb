Imports System.Net

Public Class SettingsForm
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub AutoUpdateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutoUpdateCheckBox.CheckedChanged
        If AutoUpdateCheckBox.Checked = True Then
            My.Settings.AutoUpdates = True
        Else
            My.Settings.AutoUpdates = False
            MsgBox("Avertissement : Les mises à jour permettent d'avoir les dernières fonctionnalités et assurent le meilleur fonctionnement possible du logiciel. Si vous désactivez la recherche automatique des mises à jour, vous ne recevrez plus les mises à jour dès leur parution, et vous risquez de conserver un logiciel obsolète. Ceci est déconseillé.", MsgBoxStyle.Exclamation, "SmartNet Apps Updater")
        End If
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = "Version installée : " + My.Application.Info.Version.ToString
        NoteForm.BackColor = My.Settings.NoteColor
        NoteForm.NoteRichTextBox.BackColor = My.Settings.NoteColor
        NoteForm.FormDragger.BackColor = My.Settings.NoteColor
        NoteForm.MenuStrip1.BackColor = My.Settings.NoteColor
        If My.Settings.AutoUpdates = True Then
            AutoUpdateCheckBox.Checked = True
        Else
            AutoUpdateCheckBox.Checked = False
        End If
        RestartWarningLabel.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RestorePreviousSettingsButton.Click
        My.Settings.Upgrade()
        RestorePreviousSettingsButton.Text = "Importation terminée"
        RestorePreviousSettingsButton.Enabled = False
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub UpdatesSearchButton_Click(sender As Object, e As EventArgs) Handles UpdatesSearchButton.Click
        Try
            Dim MiniNTVersionChecker As New WebClient
            Dim NTActualVersion As Version = Environment.OSVersion.Version
            Dim MiniNTVersion As Version = New Version(MiniNTVersionChecker.DownloadString("http://quentinpugeat.pagesperso-orange.fr/downloads/smartnet-squarenote/MinimumNTVersion.txt"))
            Dim MAJ As New WebClient
            Dim VersionActuelle As Version = My.Application.Info.Version
            Dim DerniereVersion As Version = New Version(MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/downloads/smartnet-squarenote/squarenote-version.txt"))
            Dim SupportStatus As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/downloads/smartnet-squarenote/support-status.txt")
            If VersionActuelle > DerniereVersion Then
                MsgBox("Il semblerait que vous utilisez une version de SmartNet Square Note non publique, réservée aux développeurs du logiciel. Cette utilisation n'est pas autorisée, veuillez retélécharger le logiciel sur SmartNet Apps. Veuillez nous contacter si vous pensez qu'il s'agit d'une erreur.", MsgBoxStyle.Exclamation, "Utilisation non autorisée")
            End If
            If NTActualVersion < MiniNTVersion Then
                MsgBox("Votre système d'exploitation n'est plus pris en charge par SmartNet Apps. Visitez le site SmartNet Apps pour en savoir plus à ce sujet. La recherche automatique de mises à jour à été désactivée.", MsgBoxStyle.Exclamation, "Avertissement")
                My.Settings.AutoUpdates = False
                My.Settings.Save()
                My.Settings.UpdateAvailable = False
                NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = False
                NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = False
                GoTo StopVersionChecking
            End If
            If SupportStatus = "on" Then
                If VersionActuelle < DerniereVersion Then
                    FormUpdater.Show()
                    My.Settings.UpdateAvailable = True
                    NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = True
                    NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = True
                    NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Text = "Télécharger la version " + DerniereVersion.ToString
                Else
                    My.Settings.UpdateAvailable = False
                    NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = False
                    NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = False
                    GoTo StopVersionChecking
                End If
            Else
                My.Settings.UpdateAvailable = False
                NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = False
                NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = False
                MsgBox("Le support et le développement de ce produit ont été interrompus. Visitez le site SmartNet Apps pour en savoir plus.", MsgBoxStyle.Critical, "Service interrompu")
                GoTo StopVersionChecking
            End If
StopVersionChecking:
        Catch ex As Exception
            MsgBox("La connexion à SmartNet Apps Updater a échoué : " + ex.Message, MsgBoxStyle.Critical, "SmartNet Apps Updater")
        End Try
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
End Class