<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Pertemuan1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tugas1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tugas2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pertemuan1ToolStripMenuItem, Me.Pertemuan2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Pertemuan1ToolStripMenuItem
        '
        Me.Pertemuan1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tugas1ToolStripMenuItem, Me.Tugas2ToolStripMenuItem})
        Me.Pertemuan1ToolStripMenuItem.Name = "Pertemuan1ToolStripMenuItem"
        Me.Pertemuan1ToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.Pertemuan1ToolStripMenuItem.Text = "Pertemuan 1"
        '
        'Pertemuan2ToolStripMenuItem
        '
        Me.Pertemuan2ToolStripMenuItem.Name = "Pertemuan2ToolStripMenuItem"
        Me.Pertemuan2ToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.Pertemuan2ToolStripMenuItem.Text = "Pertemuan 2"
        '
        'Tugas1ToolStripMenuItem
        '
        Me.Tugas1ToolStripMenuItem.Name = "Tugas1ToolStripMenuItem"
        Me.Tugas1ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Tugas1ToolStripMenuItem.Text = "Tugas 1"
        '
        'Tugas2ToolStripMenuItem
        '
        Me.Tugas2ToolStripMenuItem.Name = "Tugas2ToolStripMenuItem"
        Me.Tugas2ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Tugas2ToolStripMenuItem.Text = "Tugas 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Pertemuan1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tugas1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tugas2ToolStripMenuItem As ToolStripMenuItem
End Class
