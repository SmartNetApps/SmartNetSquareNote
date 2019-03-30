Imports System.Net
Public Class FormUpdater

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub RefuserMAJButton_Click(sender As Object, e As EventArgs) Handles DeclineUpdateButton.Click
        Me.Close()
    End Sub

    Private Sub AcceptUpdateButton_Click(sender As Object, e As EventArgs) Handles AcceptUpdateButton.Click
        Dim downloader As New WebClient
        AddHandler downloader.DownloadProgressChanged, AddressOf Downloader_DownloadProgressChanged
        AddHandler downloader.DownloadFileCompleted, AddressOf Downloader_DownloadFileCompleted

        Try
            AcceptUpdateButton.Enabled = False
            DeclineUpdateButton.Enabled = False
            DownloadProgressBar.Visible = True

            downloader.DownloadFileAsync(New Uri(UpdateAgent.DownloadLink()), My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\smartnetsquarenote-update-" + UpdateAgent.LastVersionNumberAvailable() + ".exe")
        Catch ex As Exception
            MsgBox("Téléchargement impossible : " + ex.Message, MessageBoxIcon.Error, "Téléchargement de la mise à jour")
        End Try
    End Sub

    Private Sub Downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        DownloadProgressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub Downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\smartnetsquarenote-update-" + UpdateAgent.LastVersionNumberAvailable() + ".exe", "/SILENT /NOCANCEL /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS")
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub FormUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewsRichTextBox.Text = UpdateAgent.ReleaseNotes()
    End Sub
End Class