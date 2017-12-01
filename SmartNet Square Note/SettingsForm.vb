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
        If My.Settings.NoteColor = 1 Then
            YellowNoteColorRadioButton1.Checked = True
            RedNoteColorRadioButton2.Checked = False
            GreenNoteColorRadioButton3.Checked = False
            GreyNoteColorRadioButton4.Checked = False
            BlueNoteColorRadioButton5.Checked = False
            OrangeNoteColorRadioButton6.Checked = False
        End If
        If My.Settings.NoteColor = 2 Then
            YellowNoteColorRadioButton1.Checked = False
            RedNoteColorRadioButton2.Checked = True
            GreenNoteColorRadioButton3.Checked = False
            GreyNoteColorRadioButton4.Checked = False
            BlueNoteColorRadioButton5.Checked = False
            OrangeNoteColorRadioButton6.Checked = False
        End If
        If My.Settings.NoteColor = 3 Then
            YellowNoteColorRadioButton1.Checked = False
            RedNoteColorRadioButton2.Checked = False
            GreenNoteColorRadioButton3.Checked = True
            GreyNoteColorRadioButton4.Checked = False
            BlueNoteColorRadioButton5.Checked = False
            OrangeNoteColorRadioButton6.Checked = False
        End If
        If My.Settings.NoteColor = 4 Then
            YellowNoteColorRadioButton1.Checked = False
            RedNoteColorRadioButton2.Checked = False
            GreenNoteColorRadioButton3.Checked = False
            GreyNoteColorRadioButton4.Checked = True
            BlueNoteColorRadioButton5.Checked = False
            OrangeNoteColorRadioButton6.Checked = False
        End If
        If My.Settings.NoteColor = 5 Then
            YellowNoteColorRadioButton1.Checked = False
            RedNoteColorRadioButton2.Checked = False
            GreenNoteColorRadioButton3.Checked = False
            GreyNoteColorRadioButton4.Checked = False
            BlueNoteColorRadioButton5.Checked = True
            OrangeNoteColorRadioButton6.Checked = False
        End If
        If My.Settings.NoteColor = 6 Then
            YellowNoteColorRadioButton1.Checked = False
            RedNoteColorRadioButton2.Checked = False
            GreenNoteColorRadioButton3.Checked = False
            GreyNoteColorRadioButton4.Checked = False
            BlueNoteColorRadioButton5.Checked = False
            OrangeNoteColorRadioButton6.Checked = True
        End If
        If My.Settings.TextInWhite = True Then
            TextInWhiteCheckBox.Checked = True
        Else
            TextInWhiteCheckBox.Checked = False
        End If
        If My.Settings.AutoUpdates = True Then
            AutoUpdateCheckBox.Checked = True
        Else
            AutoUpdateCheckBox.Checked = False
        End If
        RestartWarningLabel.Visible = False
    End Sub

    Private Sub YellowNoteColorRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles YellowNoteColorRadioButton1.CheckedChanged
        My.Settings.NoteColor = 1
        NoteForm.BackColor = Color.Gold
        NoteForm.NoteRichTextBox.BackColor = Color.Gold
        NoteForm.FormDragger.BackColor = Color.Gold
        NoteForm.MenuStrip1.BackColor = Color.Gold
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub RedNoteColorRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RedNoteColorRadioButton2.CheckedChanged
        My.Settings.NoteColor = 2
        NoteForm.BackColor = Color.IndianRed
        NoteForm.NoteRichTextBox.BackColor = Color.IndianRed
        NoteForm.FormDragger.BackColor = Color.IndianRed
        NoteForm.MenuStrip1.BackColor = Color.IndianRed
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub GreenNoteColorRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles GreenNoteColorRadioButton3.CheckedChanged
        My.Settings.NoteColor = 3
        NoteForm.BackColor = Color.LightGreen
        NoteForm.NoteRichTextBox.BackColor = Color.LightGreen
        NoteForm.FormDragger.BackColor = Color.LightGreen
        NoteForm.MenuStrip1.BackColor = Color.LightGreen
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub GreyNoteColorRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles GreyNoteColorRadioButton4.CheckedChanged
        My.Settings.NoteColor = 4
        NoteForm.BackColor = Color.LightGray
        NoteForm.NoteRichTextBox.BackColor = Color.LightGray
        NoteForm.FormDragger.BackColor = Color.LightGray
        NoteForm.MenuStrip1.BackColor = Color.LightGray
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub BlueNoteColorRadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles BlueNoteColorRadioButton5.CheckedChanged
        My.Settings.NoteColor = 5
        NoteForm.BackColor = Color.LightBlue
        NoteForm.NoteRichTextBox.BackColor = Color.LightBlue
        NoteForm.FormDragger.BackColor = Color.LightBlue
        NoteForm.MenuStrip1.BackColor = Color.LightBlue
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub OrangeNoteColorRadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles OrangeNoteColorRadioButton6.CheckedChanged
        My.Settings.NoteColor = 6
        NoteForm.BackColor = Color.Orange
        NoteForm.NoteRichTextBox.BackColor = Color.Orange
        NoteForm.FormDragger.BackColor = Color.Orange
        NoteForm.MenuStrip1.BackColor = Color.Orange
        RestartWarningLabel.Visible = True
    End Sub

    Private Sub TextInWhiteCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TextInWhiteCheckBox.CheckedChanged
        If TextInWhiteCheckBox.Checked = True Then
            My.Settings.TextInWhite = True
            NoteForm.NoteRichTextBox.ForeColor = Color.White
        Else
            My.Settings.TextInWhite = False
            NoteForm.NoteRichTextBox.ForeColor = Color.Black
        End If
        RestartWarningLabel.Visible = True
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
End Class