Public Class AboutForm

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LicenseLinkLabel.LinkClicked, LicensePictureBox.Click
        LicenseForm.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HomepageLinkLabel.LinkClicked
        Process.Start("https://smartnetapps.quentinpugeat.fr/squarenote/index.html")
    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = "Version " + My.Application.Info.Version.ToString()
    End Sub

    Private Sub LinkLabelReleaseNotes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelReleaseNotes.LinkClicked
        Process.Start("https://smartnetapps.quentinpugeat.fr/squarenote/releasenotes.html")
    End Sub

    Private Sub LinkLabelSource_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSource.LinkClicked
        Process.Start("https://github.com/RNbowKing/SmartNetSquareNote")
    End Sub
End Class