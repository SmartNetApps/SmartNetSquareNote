<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NoteForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteForm))
        Me.NoteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseNoteButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerCetteNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormDragger = New System.Windows.Forms.PictureBox()
        Me.FormResizer = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FormDragger, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CloseNoteButton.Image = Global.SmartNet_Square_Note.My.Resources.Resources.BlackCross
        Me.CloseNoteButton.Name = "CloseNoteButton"
        '
        'ToolStripMenu
        '
        resources.ApplyResources(Me.ToolStripMenu, "ToolStripMenu")
        Me.ToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesNotesToolStripMenuItem, Me.ToolStripSeparator1, Me.SupprimerCetteNoteToolStripMenuItem})
        Me.ToolStripMenu.Image = Global.SmartNet_Square_Note.My.Resources.Resources.MenuBlack
        Me.ToolStripMenu.Name = "ToolStripMenu"
        '
        'ListeDesNotesToolStripMenuItem
        '
        resources.ApplyResources(Me.ListeDesNotesToolStripMenuItem, "ListeDesNotesToolStripMenuItem")
        Me.ListeDesNotesToolStripMenuItem.Name = "ListeDesNotesToolStripMenuItem"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'SupprimerCetteNoteToolStripMenuItem
        '
        resources.ApplyResources(Me.SupprimerCetteNoteToolStripMenuItem, "SupprimerCetteNoteToolStripMenuItem")
        Me.SupprimerCetteNoteToolStripMenuItem.Image = Global.SmartNet_Square_Note.My.Resources.Resources.Delete
        Me.SupprimerCetteNoteToolStripMenuItem.Name = "SupprimerCetteNoteToolStripMenuItem"
        '
        'FormDragger
        '
        resources.ApplyResources(Me.FormDragger, "FormDragger")
        Me.FormDragger.BackColor = System.Drawing.Color.Gold
        Me.FormDragger.Name = "FormDragger"
        Me.FormDragger.TabStop = False
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
        CType(Me.FormResizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoteRichTextBox As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseNoteButton As ToolStripMenuItem
    Friend WithEvents ToolStripMenu As ToolStripMenuItem
    Friend WithEvents FormDragger As PictureBox
    Friend WithEvents FormResizer As PictureBox
    Friend WithEvents ListeDesNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SupprimerCetteNoteToolStripMenuItem As ToolStripMenuItem
End Class
