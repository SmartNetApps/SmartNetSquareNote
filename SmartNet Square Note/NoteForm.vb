Imports System.ComponentModel
Imports System.Drawing

Public Class NoteForm
    Dim IsDraggingForm As Boolean
    Dim MousePos As Point
    Public theNote As Note

    Public Sub New()
        InitializeComponent()
        Me.IsDraggingForm = False
        Me.MousePos = New Point(0, 0)

        Dim theCollection As NoteCollection = NoteCollection.FromJsonCollection(My.Settings.NoteCollection)
        Me.theNote = New Note(theCollection.GetHigherId() + 1)
    End Sub

    Public Sub New(_note As Note)
        InitializeComponent()
        Me.IsDraggingForm = False
        Me.MousePos = New Point(0, 0)
        Me.theNote = _note
    End Sub

    Private Sub NoteForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        theNote.isVisible = True
        NoteRichTextBox.Text = theNote.noteText
        Me.Text = theNote.noteText
        NoteRichTextBox.ForeColor = My.Settings.TextColor
        NoteRichTextBox.Font = My.Settings.TextFont
        Me.BackColor = My.Settings.NoteColor
        NoteRichTextBox.BackColor = My.Settings.NoteColor
        FormDragger.BackColor = My.Settings.NoteColor
        MenuStrip1.BackColor = My.Settings.NoteColor
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

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NoteRichTextBox.TextChanged
        Me.Text = NoteRichTextBox.Text
        theNote.noteText = NoteRichTextBox.Text
    End Sub

    Private Sub FormResizer_MouseClick(sender As Object, e As MouseEventArgs) Handles FormResizer.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.PointToClient(MousePosition).X, Me.PointToClient(MousePosition).Y)
        End If
    End Sub

    Private Sub NoteForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        theNote.isVisible = False
    End Sub

    Private Sub ListeDesNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesNotesToolStripMenuItem.Click
        MainForm.Visible = True
        MainForm.RefreshListBox()
        MainForm.Activate()
    End Sub

    Private Sub SupprimerCetteNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerCetteNoteToolStripMenuItem.Click
        Dim theCollection As NoteCollection = NoteCollection.FromJsonCollection(My.Settings.NoteCollection)
        theCollection.RemoveNote(theNote)
        My.Settings.NoteCollection = theCollection.ToJsonCollection()
        My.Settings.Save()
        MainForm.RefreshListBox()
        Me.Dispose()
    End Sub
End Class
