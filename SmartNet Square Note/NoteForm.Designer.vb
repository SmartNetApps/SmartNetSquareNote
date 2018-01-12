<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteForm))
        Me.NoteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseNoteButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleVersionDisponibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TéléchargerLaMiseÀJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideEnLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContacterLeSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvoyeznousVosCommentairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FermerToutesLesNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormDragger = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormResizer = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FormDragger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FormResizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoteRichTextBox
        '
        resources.ApplyResources(Me.NoteRichTextBox, "NoteRichTextBox")
        Me.NoteRichTextBox.BackColor = System.Drawing.Color.Gold
        Me.NoteRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NoteRichTextBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.NoteRichTextBox.Name = "NoteRichTextBox"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseNoteButton, Me.ToolStripMenu})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'CloseNoteButton
        '
        resources.ApplyResources(Me.CloseNoteButton, "CloseNoteButton")
        Me.CloseNoteButton.Name = "CloseNoteButton"
        '
        'ToolStripMenu
        '
        resources.ApplyResources(Me.ToolStripMenu, "ToolStripMenu")
        Me.ToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleNoteToolStripMenuItem, Me.ToolStripSeparator1, Me.ParamètresToolStripMenuItem, Me.NouvelleVersionDisponibleToolStripMenuItem, Me.SupportToolStripMenuItem, Me.ToolStripSeparator3, Me.FermerToutesLesNotesToolStripMenuItem})
        Me.ToolStripMenu.Name = "ToolStripMenu"
        '
        'NouvelleNoteToolStripMenuItem
        '
        resources.ApplyResources(Me.NouvelleNoteToolStripMenuItem, "NouvelleNoteToolStripMenuItem")
        Me.NouvelleNoteToolStripMenuItem.Name = "NouvelleNoteToolStripMenuItem"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'ParamètresToolStripMenuItem
        '
        resources.ApplyResources(Me.ParamètresToolStripMenuItem, "ParamètresToolStripMenuItem")
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        '
        'NouvelleVersionDisponibleToolStripMenuItem
        '
        resources.ApplyResources(Me.NouvelleVersionDisponibleToolStripMenuItem, "NouvelleVersionDisponibleToolStripMenuItem")
        Me.NouvelleVersionDisponibleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TéléchargerLaMiseÀJourToolStripMenuItem})
        Me.NouvelleVersionDisponibleToolStripMenuItem.Name = "NouvelleVersionDisponibleToolStripMenuItem"
        '
        'TéléchargerLaMiseÀJourToolStripMenuItem
        '
        resources.ApplyResources(Me.TéléchargerLaMiseÀJourToolStripMenuItem, "TéléchargerLaMiseÀJourToolStripMenuItem")
        Me.TéléchargerLaMiseÀJourToolStripMenuItem.Name = "TéléchargerLaMiseÀJourToolStripMenuItem"
        '
        'SupportToolStripMenuItem
        '
        resources.ApplyResources(Me.SupportToolStripMenuItem, "SupportToolStripMenuItem")
        Me.SupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AideEnLigneToolStripMenuItem, Me.ContacterLeSupportToolStripMenuItem, Me.EnvoyeznousVosCommentairesToolStripMenuItem, Me.ToolStripSeparator2, Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem})
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        '
        'AideEnLigneToolStripMenuItem
        '
        resources.ApplyResources(Me.AideEnLigneToolStripMenuItem, "AideEnLigneToolStripMenuItem")
        Me.AideEnLigneToolStripMenuItem.Name = "AideEnLigneToolStripMenuItem"
        '
        'ContacterLeSupportToolStripMenuItem
        '
        resources.ApplyResources(Me.ContacterLeSupportToolStripMenuItem, "ContacterLeSupportToolStripMenuItem")
        Me.ContacterLeSupportToolStripMenuItem.Name = "ContacterLeSupportToolStripMenuItem"
        '
        'EnvoyeznousVosCommentairesToolStripMenuItem
        '
        resources.ApplyResources(Me.EnvoyeznousVosCommentairesToolStripMenuItem, "EnvoyeznousVosCommentairesToolStripMenuItem")
        Me.EnvoyeznousVosCommentairesToolStripMenuItem.Name = "EnvoyeznousVosCommentairesToolStripMenuItem"
        '
        'ToolStripSeparator2
        '
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        '
        'ÀProposDeSmartNetSquareNoteToolStripMenuItem
        '
        resources.ApplyResources(Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem, "ÀProposDeSmartNetSquareNoteToolStripMenuItem")
        Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem.Name = "ÀProposDeSmartNetSquareNoteToolStripMenuItem"
        '
        'ToolStripSeparator3
        '
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        '
        'FermerToutesLesNotesToolStripMenuItem
        '
        resources.ApplyResources(Me.FermerToutesLesNotesToolStripMenuItem, "FermerToutesLesNotesToolStripMenuItem")
        Me.FermerToutesLesNotesToolStripMenuItem.Name = "FermerToutesLesNotesToolStripMenuItem"
        '
        'FormDragger
        '
        resources.ApplyResources(Me.FormDragger, "FormDragger")
        Me.FormDragger.BackColor = System.Drawing.Color.Gold
        Me.FormDragger.Name = "FormDragger"
        Me.FormDragger.TabStop = False
        '
        'NotifyIcon
        '
        resources.ApplyResources(Me.NotifyIcon, "NotifyIcon")
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip1
        '
        'ContextMenuStrip1
        '
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewNoteToolStripMenuItem, Me.CloseAllNotesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        '
        'NewNoteToolStripMenuItem
        '
        resources.ApplyResources(Me.NewNoteToolStripMenuItem, "NewNoteToolStripMenuItem")
        Me.NewNoteToolStripMenuItem.Name = "NewNoteToolStripMenuItem"
        '
        'CloseAllNotesToolStripMenuItem
        '
        resources.ApplyResources(Me.CloseAllNotesToolStripMenuItem, "CloseAllNotesToolStripMenuItem")
        Me.CloseAllNotesToolStripMenuItem.Name = "CloseAllNotesToolStripMenuItem"
        '
        'FormResizer
        '
        resources.ApplyResources(Me.FormResizer, "FormResizer")
        Me.FormResizer.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.FormResizer.Name = "FormResizer"
        Me.FormResizer.TabStop = False
        '
        'NoteForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.Controls.Add(Me.FormResizer)
        Me.Controls.Add(Me.FormDragger)
        Me.Controls.Add(Me.NoteRichTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NoteForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FormDragger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FormResizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoteRichTextBox As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseNoteButton As ToolStripMenuItem
    Friend WithEvents ToolStripMenu As ToolStripMenuItem
    Friend WithEvents NouvelleNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FormDragger As PictureBox
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleVersionDisponibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TéléchargerLaMiseÀJourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideEnLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContacterLeSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ÀProposDeSmartNetSquareNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FermerToutesLesNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NewNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormResizer As PictureBox
    Friend WithEvents EnvoyeznousVosCommentairesToolStripMenuItem As ToolStripMenuItem
End Class
