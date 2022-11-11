Imports System.ComponentModel

Public Class MainForm
    Friend NoteFormCollection As List(Of NoteForm)

    Public Sub New()
        InitializeComponent()
        NoteFormCollection = New List(Of NoteForm)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If UpdateAgent.IsUpdateAvailable() = UpdateAgent.UpdateStatus.UpdateAvailable Then
            UpdateNotifyIcon.Visible = True
            UpdateNotifyIcon.ShowBalloonTip(10000)
            MettreÀJourToolStripMenuItem.Visible = True
        Else
            UpdateNotifyIcon.Visible = False
            MettreÀJourToolStripMenuItem.Visible = False
        End If

        For Each note In NoteCollection.FromJsonCollection(My.Settings.NoteCollection)
            Dim element As New ListViewItem
            element = CType(NotesListView.Items.Add(note.noteID), ListViewItem)
            element.SubItems.Add(note.noteText)

            If note.isVisible Then
                element.SubItems.Add("Oui")
                Dim newform As New NoteForm(note)
                Me.NoteFormCollection.Add(newform)
                newform.Show()
            Else
                element.SubItems.Add("Non")
            End If
        Next
    End Sub

    Private Sub SaveNotes()
        Dim theCollection As NoteCollection = NoteCollection.FromJsonCollection(My.Settings.NoteCollection)
        For Each form In NoteFormCollection
            theCollection.AddOrUpdate(form.theNote)
        Next
        Dim notecol As Specialized.StringCollection = theCollection.ToJsonCollection()
        My.Settings.NoteCollection = notecol
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Rafraichit la ListBox avec les notes dans My.Settings.NoteCollection.
    ''' </summary>
    Public Sub RefreshListBox()
        NotesListView.Items.Clear()
        For Each note In NoteCollection.FromJsonCollection(My.Settings.NoteCollection)
            Dim element As New ListViewItem
            element = CType(NotesListView.Items.Add(note.noteID), ListViewItem)
            element.SubItems.Add(note.noteText)

            If note.isVisible Then
                element.SubItems.Add("Oui")
            Else
                element.SubItems.Add("Non")
            End If
        Next
    End Sub

    Private Sub ParamètresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        SettingsForm.Show()
    End Sub

    Private Sub MettreÀJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MettreÀJourToolStripMenuItem.Click
        If UpdateAgent.IsUpdateAvailable() = UpdateAgent.UpdateStatus.UpdateAvailable Then
            FormUpdater.Show()
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        MainNotifyIcon.Visible = False
        UpdateNotifyIcon.Visible = False
        SaveNotes()
        Environment.Exit(0)
    End Sub

    Private Sub NouvelleNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleNoteToolStripMenuItem.Click
        Dim newform As New NoteForm()
        NoteFormCollection.Add(newform)
        newform.Show()
    End Sub

    Private Sub SupportEnLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportEnLigneToolStripMenuItem.Click
        Process.Start("https://www.lesmajesticiels.org/support/kb/product/squarenote")
    End Sub

    Private Sub ContacterLassistanceTechniqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContacterLassistanceTechniqueToolStripMenuItem.Click
        Process.Start("https://www.lesmajesticiels.org/contact")
    End Sub

    Private Sub EnvoyerUnCommentaireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvoyerUnCommentaireToolStripMenuItem.Click
        Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfMOL6Pdmu2Cz18m0Rr82cNwOz1M4PpLGmzQGFZgIf2odMwyg/viewform?usp=sf_link")
    End Sub

    Private Sub ÀProposDeSmartNetSquareNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposDeSmartNetSquareNoteToolStripMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub MainNotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MainNotifyIcon.MouseDoubleClick
        Me.Visible = True
        Me.Activate()
    End Sub

    Private Sub UpdateNotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles UpdateNotifyIcon.MouseDoubleClick
        If UpdateAgent.IsUpdateAvailable() = UpdateAgent.UpdateStatus.UpdateAvailable Then
            FormUpdater.Show()
        End If
    End Sub

    Private Sub UpdateNotifyIcon_BalloonTipClicked(sender As Object, e As EventArgs) Handles UpdateNotifyIcon.BalloonTipClicked
        If UpdateAgent.IsUpdateAvailable() = UpdateAgent.UpdateStatus.UpdateAvailable Then
            FormUpdater.Show()
        End If
    End Sub

    Private Sub AfficherSmartNetSquareNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherSmartNetSquareNoteToolStripMenuItem.Click
        Me.Visible = True
        Me.Activate()
    End Sub

    Private Sub QuitterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem1.Click
        MainNotifyIcon.Visible = False
        UpdateNotifyIcon.Visible = False
        SaveNotes()
        Environment.Exit(0)
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub SaveNotesTimer_Tick(sender As Object, e As EventArgs) Handles SaveNotesTimer.Tick
        SaveNotes()
        RefreshListBox()
    End Sub

    Private Sub NotesListView_DoubleClick(sender As Object, e As EventArgs) Handles NotesListView.DoubleClick
        For Each Item As ListViewItem In NotesListView.SelectedItems
            Dim newform As New NoteForm(NoteCollection.FromJsonCollection(My.Settings.NoteCollection).GetNote(Item.SubItems(0).Text))
            Me.NoteFormCollection.Add(newform)
            newform.Show()
        Next
        RefreshListBox()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each arg In Environment.GetCommandLineArgs()
            If arg = "-hide" Then
                Me.Visible = False
            End If
        Next
    End Sub
End Class