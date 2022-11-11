Public Class AboutForm

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LicenseLinkLabel.LinkClicked, LicensePictureBox.Click
        LicenseForm.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HomepageLinkLabel.LinkClicked
        Process.Start("https://www.lesmajesticiels.org/squarenote/")
    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = "Version " + My.Application.Info.Version.ToString()
    End Sub

    Private Sub LinkLabelReleaseNotes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelReleaseNotes.LinkClicked
        Process.Start("https://www.lesmajesticiels.org/squarenote/releasenotes")
    End Sub

    Private Sub LinkLabelSource_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSource.LinkClicked
        Process.Start("https://github.com/SmartNetApps/SmartNetSquareNote")
    End Sub
End Class