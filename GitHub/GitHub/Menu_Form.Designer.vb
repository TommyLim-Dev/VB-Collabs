<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Form
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
        Me.Tugas1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tugas2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pertemuan1ToolStripMenuItem, Me.Pertemuan2ToolStripMenuItem, Me.Pertemuan3ToolStripMenuItem, Me.Pertemuan4ToolStripMenuItem, Me.Pertemuan5ToolStripMenuItem, Me.Pertemuan6ToolStripMenuItem, Me.Pertemuan8ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Pertemuan1ToolStripMenuItem
        '
        Me.Pertemuan1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tugas1ToolStripMenuItem, Me.Tugas2ToolStripMenuItem})
        Me.Pertemuan1ToolStripMenuItem.Name = "Pertemuan1ToolStripMenuItem"
        Me.Pertemuan1ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan1ToolStripMenuItem.Text = "Pertemuan 1"
        '
        'Tugas1ToolStripMenuItem
        '
        Me.Tugas1ToolStripMenuItem.Name = "Tugas1ToolStripMenuItem"
        Me.Tugas1ToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.Tugas1ToolStripMenuItem.Text = "Tugas 1"
        '
        'Tugas2ToolStripMenuItem
        '
        Me.Tugas2ToolStripMenuItem.Name = "Tugas2ToolStripMenuItem"
        Me.Tugas2ToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.Tugas2ToolStripMenuItem.Text = "Tugas 2"
        '
        'Pertemuan2ToolStripMenuItem
        '
        Me.Pertemuan2ToolStripMenuItem.Name = "Pertemuan2ToolStripMenuItem"
        Me.Pertemuan2ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan2ToolStripMenuItem.Text = "Pertemuan 2"
        '
        'Pertemuan3ToolStripMenuItem
        '
        Me.Pertemuan3ToolStripMenuItem.Name = "Pertemuan3ToolStripMenuItem"
        Me.Pertemuan3ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan3ToolStripMenuItem.Text = "Pertemuan 3"
        '
        'Pertemuan4ToolStripMenuItem
        '
        Me.Pertemuan4ToolStripMenuItem.Name = "Pertemuan4ToolStripMenuItem"
        Me.Pertemuan4ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan4ToolStripMenuItem.Text = "Pertemuan 4"
        '
        'Pertemuan5ToolStripMenuItem
        '
        Me.Pertemuan5ToolStripMenuItem.Name = "Pertemuan5ToolStripMenuItem"
        Me.Pertemuan5ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan5ToolStripMenuItem.Text = "Pertemuan 5"
        '
        'Pertemuan6ToolStripMenuItem
        '
        Me.Pertemuan6ToolStripMenuItem.Name = "Pertemuan6ToolStripMenuItem"
        Me.Pertemuan6ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan6ToolStripMenuItem.Text = "Pertemuan 6"
        '
        'Pertemuan8ToolStripMenuItem
        '
        Me.Pertemuan8ToolStripMenuItem.Name = "Pertemuan8ToolStripMenuItem"
        Me.Pertemuan8ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan8ToolStripMenuItem.Text = "Pertemuan 8"
        '
        'Menu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 366)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu_Form"
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
    Friend WithEvents Pertemuan3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan8ToolStripMenuItem As ToolStripMenuItem
End Class
