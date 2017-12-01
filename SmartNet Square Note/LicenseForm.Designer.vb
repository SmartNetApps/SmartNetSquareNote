<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicenseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LicenseForm))
        Me.LicenseRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'LicenseRichTextBox
        '
        Me.LicenseRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LicenseRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LicenseRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.LicenseRichTextBox.Name = "LicenseRichTextBox"
        Me.LicenseRichTextBox.Size = New System.Drawing.Size(451, 438)
        Me.LicenseRichTextBox.TabIndex = 0
        Me.LicenseRichTextBox.Text = resources.GetString("LicenseRichTextBox.Text")
        '
        'LicenseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 438)
        Me.Controls.Add(Me.LicenseRichTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LicenseForm"
        Me.Text = "Licence"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LicenseRichTextBox As RichTextBox
End Class
