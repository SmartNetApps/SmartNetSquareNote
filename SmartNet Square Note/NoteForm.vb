Imports System.ComponentModel

Public Class NoteForm
    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)
    Public Sub Noteform()
        InitializeComponent()
    End Sub

    Private Sub StartDraggingForm(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ToolStripMenu.MouseDown, FormDragger.MouseDown, MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub

    Private Sub StopDraggingForm(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ToolStripMenu.MouseUp, FormDragger.MouseUp, MyBase.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub

    Private Sub DraggingForm(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ToolStripMenu.MouseMove, FormDragger.MouseMove, MyBase.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub CloseNoteButton_Click(sender As Object, e As EventArgs) Handles CloseNoteButton.Click
        Me.Close()
    End Sub

    Private Sub NouvelleNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleNoteToolStripMenuItem.Click, NewNoteToolStripMenuItem.Click
        Dim NewNote As New NoteForm
        NewNote.NotifyIcon.Visible = False
        If My.Settings.UpdateAvailable = True Then
            NewNote.NouvelleVersionDisponibleToolStripMenuItem.Visible = True
            NewNote.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = True
        Else
            NewNote.NouvelleVersionDisponibleToolStripMenuItem.Visible = False
            NewNote.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = False
        End If
        NewNote.Show()
    End Sub

    Private Sub ÀProposDeSmartNetSquareNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposDeSmartNetSquareNoteToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NoteRichTextBox.TextChanged
        Me.Text = NoteRichTextBox.Text
    End Sub

    Private Sub NoteForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = NoteRichTextBox.Text
        NoteRichTextBox.ForeColor = My.Settings.TextColor
        NoteRichTextBox.Font = My.Settings.TextFont
        Me.BackColor = My.Settings.NoteColor
        NoteRichTextBox.BackColor = My.Settings.NoteColor
        FormDragger.BackColor = My.Settings.NoteColor
        MenuStrip1.BackColor = My.Settings.NoteColor
    End Sub

    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        SettingsForm.ShowDialog()
    End Sub

    Private Sub FermerToutesLesNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToutesLesNotesToolStripMenuItem.Click, CloseAllNotesToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TéléchargerLaMiseÀJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TéléchargerLaMiseÀJourToolStripMenuItem.Click
        FormUpdater.Show()
    End Sub

    Private Sub FormResizer_MouseClick(sender As Object, e As MouseEventArgs) Handles FormResizer.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.PointToClient(MousePosition).X, Me.PointToClient(MousePosition).Y)
        End If
    End Sub

    Private Sub AideEnLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AideEnLigneToolStripMenuItem.Click
        Process.Start("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/squarenote/support/index.html")
    End Sub

    Private Sub ContacterLeSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContacterLeSupportToolStripMenuItem.Click
        Process.Start("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/contact.html")
    End Sub

    Private Sub EnvoyeznousVosCommentairesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvoyeznousVosCommentairesToolStripMenuItem.Click
        Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfMOL6Pdmu2Cz18m0Rr82cNwOz1M4PpLGmzQGFZgIf2odMwyg/viewform?usp=sf_link")
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        'Me.BringToFront()
    End Sub
End Class
