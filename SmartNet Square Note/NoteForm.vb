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
        If My.Settings.TextInWhite = True Then
            NoteRichTextBox.ForeColor = Color.White
        Else
            NoteRichTextBox.ForeColor = Color.Black
        End If
        Select Case My.Settings.NoteColor
            Case 1
                Me.BackColor = Color.Gold
                NoteRichTextBox.BackColor = Color.Gold
                FormDragger.BackColor = Color.Gold
                MenuStrip1.BackColor = Color.Gold
            Case 2
                Me.BackColor = Color.IndianRed
                NoteRichTextBox.BackColor = Color.IndianRed
                FormDragger.BackColor = Color.IndianRed
                MenuStrip1.BackColor = Color.IndianRed
            Case 3
                Me.BackColor = Color.LightGreen
                NoteRichTextBox.BackColor = Color.LightGreen
                FormDragger.BackColor = Color.LightGreen
                MenuStrip1.BackColor = Color.LightGreen
            Case 4
                Me.BackColor = Color.LightGray
                NoteRichTextBox.BackColor = Color.LightGray
                FormDragger.BackColor = Color.LightGray
                MenuStrip1.BackColor = Color.LightGray
            Case 5
                Me.BackColor = Color.LightBlue
                NoteRichTextBox.BackColor = Color.LightBlue
                FormDragger.BackColor = Color.LightBlue
                MenuStrip1.BackColor = Color.LightBlue
            Case 6
                Me.BackColor = Color.Orange
                NoteRichTextBox.BackColor = Color.Orange
                FormDragger.BackColor = Color.Orange
                MenuStrip1.BackColor = Color.Orange
        End Select
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
        Process.Start("https://quentinpugeat.wixsite.com/apps/squarenote-support")
    End Sub

    Private Sub ContacterLeSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContacterLeSupportToolStripMenuItem.Click
        Process.Start("https://quentinpugeat.wixsite.com/lesiteofficiel/contact")
    End Sub

    Private Sub EnvoyeznousVosCommentairesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvoyeznousVosCommentairesToolStripMenuItem.Click
        Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfMOL6Pdmu2Cz18m0Rr82cNwOz1M4PpLGmzQGFZgIf2odMwyg/viewform?usp=sf_link")
    End Sub
End Class
