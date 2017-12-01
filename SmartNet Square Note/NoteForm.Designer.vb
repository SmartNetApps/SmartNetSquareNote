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
        Me.EnvoyeznousVosCommentairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FormDragger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FormResizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoteRichTextBox
        '
        Me.NoteRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoteRichTextBox.BackColor = System.Drawing.Color.Gold
        Me.NoteRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NoteRichTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteRichTextBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.NoteRichTextBox.Location = New System.Drawing.Point(4, 27)
        Me.NoteRichTextBox.Name = "NoteRichTextBox"
        Me.NoteRichTextBox.Size = New System.Drawing.Size(192, 169)
        Me.NoteRichTextBox.TabIndex = 0
        Me.NoteRichTextBox.Text = "Nouvelle Square Note"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseNoteButton, Me.ToolStripMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(200, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseNoteButton
        '
        Me.CloseNoteButton.Image = CType(resources.GetObject("CloseNoteButton.Image"), System.Drawing.Image)
        Me.CloseNoteButton.Name = "CloseNoteButton"
        Me.CloseNoteButton.Size = New System.Drawing.Size(28, 20)
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleNoteToolStripMenuItem, Me.ToolStripSeparator1, Me.ParamètresToolStripMenuItem, Me.NouvelleVersionDisponibleToolStripMenuItem, Me.SupportToolStripMenuItem, Me.ToolStripSeparator3, Me.FermerToutesLesNotesToolStripMenuItem})
        Me.ToolStripMenu.Image = CType(resources.GetObject("ToolStripMenu.Image"), System.Drawing.Image)
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(28, 20)
        '
        'NouvelleNoteToolStripMenuItem
        '
        Me.NouvelleNoteToolStripMenuItem.Image = CType(resources.GetObject("NouvelleNoteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouvelleNoteToolStripMenuItem.Name = "NouvelleNoteToolStripMenuItem"
        Me.NouvelleNoteToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NouvelleNoteToolStripMenuItem.Text = "Nouvelle Note"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(217, 6)
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = CType(resources.GetObject("ParamètresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'NouvelleVersionDisponibleToolStripMenuItem
        '
        Me.NouvelleVersionDisponibleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TéléchargerLaMiseÀJourToolStripMenuItem})
        Me.NouvelleVersionDisponibleToolStripMenuItem.Image = CType(resources.GetObject("NouvelleVersionDisponibleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NouvelleVersionDisponibleToolStripMenuItem.Name = "NouvelleVersionDisponibleToolStripMenuItem"
        Me.NouvelleVersionDisponibleToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NouvelleVersionDisponibleToolStripMenuItem.Text = "Nouvelle version disponible"
        '
        'TéléchargerLaMiseÀJourToolStripMenuItem
        '
        Me.TéléchargerLaMiseÀJourToolStripMenuItem.Image = CType(resources.GetObject("TéléchargerLaMiseÀJourToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TéléchargerLaMiseÀJourToolStripMenuItem.Name = "TéléchargerLaMiseÀJourToolStripMenuItem"
        Me.TéléchargerLaMiseÀJourToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.TéléchargerLaMiseÀJourToolStripMenuItem.Text = "Télécharger la mise à jour..."
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AideEnLigneToolStripMenuItem, Me.ContacterLeSupportToolStripMenuItem, Me.EnvoyeznousVosCommentairesToolStripMenuItem, Me.ToolStripSeparator2, Me.ÀProposDeSmartNetSquareNoteToolStripMenuItem})
        Me.SupportToolStripMenuItem.Image = CType(resources.GetObject("SupportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SupportToolStripMenuItem.Text = "Support"
        '
        'AideEnLigneToolStripMenuItem
        '
        Me.AideEnLigneToolStripMenuItem.Name = "AideEnLigneToolStripMenuItem"
        Me.AideEnLigneToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.AideEnLigneToolStripMenuItem.Text = "Aide en ligne..."
        '
        'ContacterLeSupportToolStripMenuItem
        '
        Me.ContacterLeSupportToolStripMenuItem.Name = "ContacterLeSupportToolStripMenuItem"
        Me.ContacterLeSupportToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.ContacterLeSupportToolStripMenuItem.Text = "Contacter le support..."
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
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(217, 6)
        '
        'FermerToutesLesNotesToolStripMenuItem
        '
        Me.FermerToutesLesNotesToolStripMenuItem.Image = CType(resources.GetObject("FermerToutesLesNotesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FermerToutesLesNotesToolStripMenuItem.Name = "FermerToutesLesNotesToolStripMenuItem"
        Me.FermerToutesLesNotesToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FermerToutesLesNotesToolStripMenuItem.Text = "Fermer toutes les notes"
        '
        'FormDragger
        '
        Me.FormDragger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormDragger.BackColor = System.Drawing.Color.Gold
        Me.FormDragger.ErrorImage = Nothing
        Me.FormDragger.InitialImage = Nothing
        Me.FormDragger.Location = New System.Drawing.Point(64, 0)
        Me.FormDragger.Name = "FormDragger"
        Me.FormDragger.Size = New System.Drawing.Size(136, 24)
        Me.FormDragger.TabIndex = 2
        Me.FormDragger.TabStop = False
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "SmartNet Square Note"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewNoteToolStripMenuItem, Me.CloseAllNotesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(197, 48)
        '
        'NewNoteToolStripMenuItem
        '
        Me.NewNoteToolStripMenuItem.Image = CType(resources.GetObject("NewNoteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewNoteToolStripMenuItem.Name = "NewNoteToolStripMenuItem"
        Me.NewNoteToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NewNoteToolStripMenuItem.Text = "Nouvelle Note"
        '
        'CloseAllNotesToolStripMenuItem
        '
        Me.CloseAllNotesToolStripMenuItem.Image = CType(resources.GetObject("CloseAllNotesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseAllNotesToolStripMenuItem.Name = "CloseAllNotesToolStripMenuItem"
        Me.CloseAllNotesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CloseAllNotesToolStripMenuItem.Text = "Fermer toutes les notes"
        '
        'FormResizer
        '
        Me.FormResizer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormResizer.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.FormResizer.ErrorImage = Nothing
        Me.FormResizer.InitialImage = Nothing
        Me.FormResizer.Location = New System.Drawing.Point(190, 190)
        Me.FormResizer.Name = "FormResizer"
        Me.FormResizer.Size = New System.Drawing.Size(10, 10)
        Me.FormResizer.TabIndex = 3
        Me.FormResizer.TabStop = False
        '
        'EnvoyeznousVosCommentairesToolStripMenuItem
        '
        Me.EnvoyeznousVosCommentairesToolStripMenuItem.Name = "EnvoyeznousVosCommentairesToolStripMenuItem"
        Me.EnvoyeznousVosCommentairesToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.EnvoyeznousVosCommentairesToolStripMenuItem.Text = "Envoyez-nous vos commentaires !"
        '
        'NoteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(200, 200)
        Me.Controls.Add(Me.FormResizer)
        Me.Controls.Add(Me.FormDragger)
        Me.Controls.Add(Me.NoteRichTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NoteForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Square Note"
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
