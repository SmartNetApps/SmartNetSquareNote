Public Class AboutForm

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LicenseLinkLabel.LinkClicked, LicensePictureBox.Click
        LicenseForm.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HomepageLinkLabel.LinkClicked
        Process.Start("http://quentinpugeat.wixsite.com/apps/square-note")
    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = "Version " + My.Application.Info.Version.ToString
    End Sub
End Class