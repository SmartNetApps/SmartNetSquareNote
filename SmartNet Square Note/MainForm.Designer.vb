<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MainNotifyIconContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AfficherSmartNetSquareNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MettreÀJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportEnLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContacterLassistanceTechniqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvoyerUnCommentaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveNotesTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotesListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader_NoteID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_NoteText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_isVisible = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MainNotifyIconContextMenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainNotifyIcon
        '
        Me.MainNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.MainNotifyIcon, "MainNotifyIcon")
        Me.MainNotifyIcon.ContextMenuStrip = Me.MainNotifyIconContextMenuStrip
        '
        'MainNotifyIconContextMenuStrip
        '
        Me.MainNotifyIconContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherSmartNetSquareNoteToolStripMenuItem, Me.QuitterToolStripMenuItem1})
        Me.MainNotifyIconContextMenuStrip.Name = "MainNotifyIconContextMenuStrip"
        resources.ApplyResources(Me.MainNotifyIconContextMenuStrip, "MainNotifyIconContextMenuStrip")
        '
        'AfficherSmartNetSquareNoteToolStripMenuItem
        '
        resources.ApplyResources(Me.AfficherSmartNetSquareNoteToolStripMenuItem, "AfficherSmartNetSquareNoteToolStripMenuItem")
        Me.AfficherSmartNetSquareNoteToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources._2019_SmartNetSquareNote_1024
        Me.AfficherSmartNetSquareNoteToolStripMenuItem.Name = "AfficherSmartNetSquareNoteToolStripMenuItem"
        '
        'QuitterToolStripMenuItem1
        '
        Me.QuitterToolStripMenuItem1.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Close
        Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
        resources.ApplyResources(Me.QuitterToolStripMenuItem1, "QuitterToolStripMenuItem1")
        '
        'UpdateNotifyIcon
        '
        Me.UpdateNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.UpdateNotifyIcon, "UpdateNotifyIcon")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.NotesToolStripMenuItem, Me.AideToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParamètresToolStripMenuItem, Me.MettreÀJourToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        resources.ApplyResources(Me.ApplicationToolStripMenuItem, "ApplicationToolStripMenuItem")
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Settings
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        resources.ApplyResources(Me.ParamètresToolStripMenuItem, "ParamètresToolStripMenuItem")
        '
        'MettreÀJourToolStripMenuItem
        '
        Me.MettreÀJourToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources._2019_SmartNetAppsUpdater_1024
        Me.MettreÀJourToolStripMenuItem.Name = "MettreÀJourToolStripMenuItem"
        resources.ApplyResources(Me.MettreÀJourToolStripMenuItem, "MettreÀJourToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Close
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        resources.ApplyResources(Me.QuitterToolStripMenuItem, "QuitterToolStripMenuItem")
        '
        'NotesToolStripMenuItem
        '
        Me.NotesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleNoteToolStripMenuItem})
        Me.NotesToolStripMenuItem.Name = "NotesToolStripMenuItem"
        resources.ApplyResources(Me.NotesToolStripMenuItem, "NotesToolStripMenuItem")
        '
        'NouvelleNoteToolStripMenuItem
        '
        Me.NouvelleNoteToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.NewNote
        Me.NouvelleNoteToolStripMenuItem.Name = "NouvelleNoteToolStripMenuItem"
        resources.ApplyResources(Me.NouvelleNoteToolStripMenuItem, "NouvelleNoteToolStripMenuItem")
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupportEnLigneToolStripMenuItem, Me.ContacterLassistanceTechniqueToolStripMenuItem, Me.EnvoyerUnCommentaireToolStripMenuItem, Me.ToolStripSeparator2, Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        resources.ApplyResources(Me.AideToolStripMenuItem, "AideToolStripMenuItem")
        '
        'SupportEnLigneToolStripMenuItem
        '
        Me.SupportEnLigneToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Help
        Me.SupportEnLigneToolStripMenuItem.Name = "SupportEnLigneToolStripMenuItem"
        resources.ApplyResources(Me.SupportEnLigneToolStripMenuItem, "SupportEnLigneToolStripMenuItem")
        '
        'ContacterLassistanceTechniqueToolStripMenuItem
        '
        Me.ContacterLassistanceTechniqueToolStripMenuItem.Name = "ContacterLassistanceTechniqueToolStripMenuItem"
        resources.ApplyResources(Me.ContacterLassistanceTechniqueToolStripMenuItem, "ContacterLassistanceTechniqueToolStripMenuItem")
        '
        'EnvoyerUnCommentaireToolStripMenuItem
        '
        Me.EnvoyerUnCommentaireToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.SendFeedback
        Me.EnvoyerUnCommentaireToolStripMenuItem.Name = "EnvoyerUnCommentaireToolStripMenuItem"
        resources.ApplyResources(Me.EnvoyerUnCommentaireToolStripMenuItem, "EnvoyerUnCommentaireToolStripMenuItem")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ÀProposDeSmartNetSquareNoteToolStripMenuItem
        '
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem.Name = "ÀProposDeSmartNetSquareNoteToolStripMenuItem"
        resources.ApplyResources(Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem, "ÀProposDeSmartNetSquareNoteToolStripMenuItem")
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'SaveNotesTimer
        '
        Me.SaveNotesTimer.Enabled = True
        Me.SaveNotesTimer.Interval = 2000
        '
        'NotesListView
        '
        Me.NotesListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_NoteID, Me.ColumnHeader_NoteText, Me.ColumnHeader_isVisible})
        resources.ApplyResources(Me.NotesListView, "NotesListView")
        Me.NotesListView.FullRowSelect = True
        Me.NotesListView.Name = "NotesListView"
        Me.NotesListView.UseCompatibleStateImageBehavior = False
        Me.NotesListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_NoteID
        '
        resources.ApplyResources(Me.ColumnHeader_NoteID, "ColumnHeader_NoteID")
        '
        'ColumnHeader_NoteText
        '
        resources.ApplyResources(Me.ColumnHeader_NoteText, "ColumnHeader_NoteText")
        '
        'ColumnHeader_isVisible
        '
        resources.ApplyResources(Me.ColumnHeader_isVisible, "ColumnHeader_isVisible")
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.NotesListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.MainNotifyIconContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainNotifyIcon As NotifyIcon
    Friend WithEvents UpdateNotifyIcon As NotifyIcon
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MettreÀJourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportEnLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContacterLassistanceTechniqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ÀProposDeSmartNetSquareNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvoyerUnCommentaireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents MainNotifyIconContextMenuStrip As ContextMenuStrip
    Friend WithEvents AfficherSmartNetSquareNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveNotesTimer As Timer
    Friend WithEvents NotesListView As ListView
    Friend WithEvents ColumnHeader_NoteID As ColumnHeader
    Friend WithEvents ColumnHeader_NoteText As ColumnHeader
    Friend WithEvents ColumnHeader_isVisible As ColumnHeader
End Class
