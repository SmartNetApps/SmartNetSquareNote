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
        Me.MainNotifyIcon.BalloonTipText = "Double-cliquez sur cette icône pour faire apparaître SmartNet Square Note. Un cli" &
    "c-droit affichera un menu."
        Me.MainNotifyIcon.BalloonTipTitle = "SmartNet Square Note est encore ouvert."
        Me.MainNotifyIcon.ContextMenuStrip = Me.MainNotifyIconContextMenuStrip
        Me.MainNotifyIcon.Icon = CType(resources.GetObject("MainNotifyIcon.Icon"), System.Drawing.Icon)
        Me.MainNotifyIcon.Text = "SmartNet Square Note"
        Me.MainNotifyIcon.Visible = True
        '
        'MainNotifyIconContextMenuStrip
        '
        Me.MainNotifyIconContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherSmartNetSquareNoteToolStripMenuItem, Me.QuitterToolStripMenuItem1})
        Me.MainNotifyIconContextMenuStrip.Name = "MainNotifyIconContextMenuStrip"
        Me.MainNotifyIconContextMenuStrip.Size = New System.Drawing.Size(252, 48)
        '
        'AfficherSmartNetSquareNoteToolStripMenuItem
        '
        Me.AfficherSmartNetSquareNoteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AfficherSmartNetSquareNoteToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources._2019_SmartNetSquareNote_1024
        Me.AfficherSmartNetSquareNoteToolStripMenuItem.Name = "AfficherSmartNetSquareNoteToolStripMenuItem"
        Me.AfficherSmartNetSquareNoteToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.AfficherSmartNetSquareNoteToolStripMenuItem.Text = "Afficher SmartNet Square Note"
        '
        'QuitterToolStripMenuItem1
        '
        Me.QuitterToolStripMenuItem1.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Close
        Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
        Me.QuitterToolStripMenuItem1.Size = New System.Drawing.Size(251, 22)
        Me.QuitterToolStripMenuItem1.Text = "Quitter"
        '
        'UpdateNotifyIcon
        '
        Me.UpdateNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.UpdateNotifyIcon.BalloonTipText = "Une mise à jour est disponible pour SmartNet Square Note."
        Me.UpdateNotifyIcon.BalloonTipTitle = "SmartNet Apps Updater"
        Me.UpdateNotifyIcon.Icon = CType(resources.GetObject("UpdateNotifyIcon.Icon"), System.Drawing.Icon)
        Me.UpdateNotifyIcon.Text = "SmartNet Apps Updater"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.NotesToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(363, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParamètresToolStripMenuItem, Me.MettreÀJourToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Settings
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres..."
        Me.ParamètresToolStripMenuItem.ToolTipText = "Ouvrir les paramètres de l'application."
        '
        'MettreÀJourToolStripMenuItem
        '
        Me.MettreÀJourToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources._2019_SmartNetAppsUpdater_1024
        Me.MettreÀJourToolStripMenuItem.Name = "MettreÀJourToolStripMenuItem"
        Me.MettreÀJourToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.MettreÀJourToolStripMenuItem.Text = "Mettre à jour..."
        Me.MettreÀJourToolStripMenuItem.ToolTipText = "Mettre à jour l'application."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Close
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        Me.QuitterToolStripMenuItem.ToolTipText = "Fermer toutes les notes et quitter l'application."
        '
        'NotesToolStripMenuItem
        '
        Me.NotesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleNoteToolStripMenuItem})
        Me.NotesToolStripMenuItem.Name = "NotesToolStripMenuItem"
        Me.NotesToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.NotesToolStripMenuItem.Text = "Notes"
        '
        'NouvelleNoteToolStripMenuItem
        '
        Me.NouvelleNoteToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.NewNote
        Me.NouvelleNoteToolStripMenuItem.Name = "NouvelleNoteToolStripMenuItem"
        Me.NouvelleNoteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouvelleNoteToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.NouvelleNoteToolStripMenuItem.Text = "Nouvelle note"
        Me.NouvelleNoteToolStripMenuItem.ToolTipText = "Ouvrir une nouvelle note"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupportEnLigneToolStripMenuItem, Me.ContacterLassistanceTechniqueToolStripMenuItem, Me.EnvoyerUnCommentaireToolStripMenuItem, Me.ToolStripSeparator2, Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(24, 20)
        Me.AideToolStripMenuItem.Text = "?"
        '
        'SupportEnLigneToolStripMenuItem
        '
        Me.SupportEnLigneToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Help
        Me.SupportEnLigneToolStripMenuItem.Name = "SupportEnLigneToolStripMenuItem"
        Me.SupportEnLigneToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.SupportEnLigneToolStripMenuItem.Text = "Support en ligne..."
        Me.SupportEnLigneToolStripMenuItem.ToolTipText = "Ouvrir les pages de support sur le site de SmartNet Apps."
        '
        'ContacterLassistanceTechniqueToolStripMenuItem
        '
        Me.ContacterLassistanceTechniqueToolStripMenuItem.Name = "ContacterLassistanceTechniqueToolStripMenuItem"
        Me.ContacterLassistanceTechniqueToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.ContacterLassistanceTechniqueToolStripMenuItem.Text = "Contacter l'assistance technique..."
        Me.ContacterLassistanceTechniqueToolStripMenuItem.ToolTipText = "Ouvrir la page de contact sur le site de SmartNet Apps."
        '
        'EnvoyerUnCommentaireToolStripMenuItem
        '
        Me.EnvoyerUnCommentaireToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.SendFeedback
        Me.EnvoyerUnCommentaireToolStripMenuItem.Name = "EnvoyerUnCommentaireToolStripMenuItem"
        Me.EnvoyerUnCommentaireToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.EnvoyerUnCommentaireToolStripMenuItem.Text = "Envoyer un commentaire..."
        Me.EnvoyerUnCommentaireToolStripMenuItem.ToolTipText = "Accéder au formulaire d'appréciation de SmartNet Square Note."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(265, 6)
        '
        'ÀProposDeSmartNetSquareNoteToolStripMenuItem
        '
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem.Name = "ÀProposDeSmartNetSquareNoteToolStripMenuItem"
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem.Text = "À propos de SmartNet Square Note..."
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem.ToolTipText = "Consulter les détails à propos de l'application."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Notes sauvegardées"
        '
        'SaveNotesTimer
        '
        Me.SaveNotesTimer.Enabled = True
        Me.SaveNotesTimer.Interval = 10000
        '
        'NotesListView
        '
        Me.NotesListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_NoteID, Me.ColumnHeader_NoteText, Me.ColumnHeader_isVisible})
        Me.NotesListView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesListView.FullRowSelect = True
        Me.NotesListView.Location = New System.Drawing.Point(11, 62)
        Me.NotesListView.Name = "NotesListView"
        Me.NotesListView.Size = New System.Drawing.Size(340, 432)
        Me.NotesListView.TabIndex = 3
        Me.NotesListView.UseCompatibleStateImageBehavior = False
        Me.NotesListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_NoteID
        '
        Me.ColumnHeader_NoteID.Text = "ID"
        '
        'ColumnHeader_NoteText
        '
        Me.ColumnHeader_NoteText.Text = "Texte"
        Me.ColumnHeader_NoteText.Width = 215
        '
        'ColumnHeader_isVisible
        '
        Me.ColumnHeader_isVisible.Text = "Ouvert"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 506)
        Me.Controls.Add(Me.NotesListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "SmartNet Square Note"
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
