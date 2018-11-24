Imports System.Net
Public Class FormUpdater
    Dim agent As UpdateAgent
    Dim client As WebClient
    Dim DownloadLink As String
    Dim NewVersion As String
    Dim ReleaseNotes As String

    Public Sub New()
        InitializeComponent()

        agent = New UpdateAgent()
        client = New WebClient()
        DownloadLink = agent.DownloadLink()
        NewVersion = agent.LastVersionNumberAvailable()
        ReleaseNotes = agent.ReleaseNotes()

        AddHandler client.DownloadProgressChanged, AddressOf Client_DownloadProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf Client_DownloadFileCompleted
    End Sub

    Private Sub RefuserMAJButton_Click(sender As Object, e As EventArgs) Handles DeclineUpdateButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AcceptUpdateButton.Click
        Try
            AcceptUpdateButton.Enabled = False
            DeclineUpdateButton.Enabled = False
            DownloadProgressBar.Visible = True
            'Dim MAJ As New WebClient
            'Dim MAJ2 As New WebClient
            'AddHandler MAJ2.DownloadProgressChanged, AddressOf MAJ2_ProgressChanged
            'AddHandler MAJ2.DownloadFileCompleted, AddressOf MAJ2_DownloadCompleted
            DownloadLink = agent.DownloadLink()
            'Dim DownloadLink As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/squarenote/windows/download.txt")
            client.DownloadFileAsync(New Uri(DownloadLink), My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\smartnetsquarenote-update-" + My.Application.Info.Version.ToString + ".exe")
        Catch ex As Exception
            MsgBox("Téléchargement impossible : " + ex.Message, MessageBoxIcon.Error, "Téléchargement de la mise à jour")
        End Try
    End Sub

    'Private Sub MAJ2_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
    '    Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
    '    Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
    '    Dim percentage As Double = bytesIn / totalBytes * 100
    '    DownloadProgressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    'End Sub

    'Private Sub MAJ2_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    '    Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\smartnetsquarenote-update-" + My.Application.Info.Version.ToString + ".exe", "/SILENT /NOCANCEL /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS")
    '    Me.Close()
    '    Application.Exit()
    'End Sub

    Private Sub Client_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        DownloadProgressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub Client_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\smartnetsquarenote-update-" + My.Application.Info.Version.ToString + ".exe", "/SILENT /NOCANCEL /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS")
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub FormUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim MAJ As New WebClient
        'Dim Nouveautes As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/squarenote/windows/releasenotes.txt")
        NewsRichTextBox.Text = ReleaseNotes
    End Sub
End Class