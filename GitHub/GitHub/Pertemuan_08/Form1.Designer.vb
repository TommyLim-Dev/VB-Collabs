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
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.DTglLhr = New System.Windows.Forms.DateTimePicker()
        Me.cmbBgn = New System.Windows.Forms.ComboBox()
        Me.cmbPend = New System.Windows.Forms.ComboBox()
        Me.RBlmKwn = New System.Windows.Forms.RadioButton()
        Me.RKwn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BExit = New System.Windows.Forms.Button()
        Me.BCancel = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.BEdit = New System.Windows.Forms.Button()
        Me.BSave = New System.Windows.Forms.Button()
        Me.BCari = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(197, 32)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(100, 20)
        Me.txtNIP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAMA PEGAWAI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "BAGIAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TGL LAHIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ALAMAT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PENDIDIKAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "STATUS"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(197, 61)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 20)
        Me.txtNama.TabIndex = 10
        '
        'DTglLhr
        '
        Me.DTglLhr.Location = New System.Drawing.Point(197, 125)
        Me.DTglLhr.Name = "DTglLhr"
        Me.DTglLhr.Size = New System.Drawing.Size(200, 20)
        Me.DTglLhr.TabIndex = 12
        '
        'cmbBgn
        '
        Me.cmbBgn.FormattingEnabled = True
        Me.cmbBgn.Items.AddRange(New Object() {"Admin" & Global.Microsoft.VisualBasic.ChrW(9), "Finance", "Direktur", "Manager"})
        Me.cmbBgn.Location = New System.Drawing.Point(197, 93)
        Me.cmbBgn.Name = "cmbBgn"
        Me.cmbBgn.Size = New System.Drawing.Size(121, 21)
        Me.cmbBgn.TabIndex = 13
        '
        'cmbPend
        '
        Me.cmbPend.FormattingEnabled = True
        Me.cmbPend.Items.AddRange(New Object() {"SMP", "SMA", "S1", "S2"})
        Me.cmbPend.Location = New System.Drawing.Point(197, 255)
        Me.cmbPend.Name = "cmbPend"
        Me.cmbPend.Size = New System.Drawing.Size(121, 21)
        Me.cmbPend.TabIndex = 14
        '
        'RBlmKwn
        '
        Me.RBlmKwn.AutoSize = True
        Me.RBlmKwn.Location = New System.Drawing.Point(14, 23)
        Me.RBlmKwn.Name = "RBlmKwn"
        Me.RBlmKwn.Size = New System.Drawing.Size(86, 17)
        Me.RBlmKwn.TabIndex = 15
        Me.RBlmKwn.TabStop = True
        Me.RBlmKwn.Text = "Belum Kawin"
        Me.RBlmKwn.UseVisualStyleBackColor = True
        '
        'RKwn
        '
        Me.RKwn.AutoSize = True
        Me.RKwn.Location = New System.Drawing.Point(133, 23)
        Me.RKwn.Name = "RKwn"
        Me.RKwn.Size = New System.Drawing.Size(54, 17)
        Me.RKwn.TabIndex = 16
        Me.RKwn.TabStop = True
        Me.RKwn.Text = "Kawin"
        Me.RKwn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBlmKwn)
        Me.GroupBox1.Controls.Add(Me.RKwn)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 57)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox2.Controls.Add(Me.BExit)
        Me.GroupBox2.Controls.Add(Me.BCancel)
        Me.GroupBox2.Controls.Add(Me.BDelete)
        Me.GroupBox2.Controls.Add(Me.BEdit)
        Me.GroupBox2.Controls.Add(Me.BSave)
        Me.GroupBox2.Location = New System.Drawing.Point(476, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 377)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'BExit
        '
        Me.BExit.Location = New System.Drawing.Point(52, 333)
        Me.BExit.Name = "BExit"
        Me.BExit.Size = New System.Drawing.Size(75, 23)
        Me.BExit.TabIndex = 5
        Me.BExit.Text = "Exit"
        Me.BExit.UseVisualStyleBackColor = True
        '
        'BCancel
        '
        Me.BCancel.Location = New System.Drawing.Point(52, 130)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(75, 23)
        Me.BCancel.TabIndex = 4
        Me.BCancel.Text = "Cancel"
        Me.BCancel.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Enabled = False
        Me.BDelete.Location = New System.Drawing.Point(52, 94)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(75, 23)
        Me.BDelete.TabIndex = 3
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BEdit
        '
        Me.BEdit.Enabled = False
        Me.BEdit.Location = New System.Drawing.Point(52, 53)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(75, 23)
        Me.BEdit.TabIndex = 2
        Me.BEdit.Text = "Edit"
        Me.BEdit.UseVisualStyleBackColor = True
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(52, 16)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(75, 23)
        Me.BSave.TabIndex = 1
        Me.BSave.Text = "Save"
        Me.BSave.UseVisualStyleBackColor = True
        '
        'BCari
        '
        Me.BCari.Location = New System.Drawing.Point(322, 32)
        Me.BCari.Name = "BCari"
        Me.BCari.Size = New System.Drawing.Size(75, 23)
        Me.BCari.TabIndex = 0
        Me.BCari.Text = "Cari"
        Me.BCari.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(197, 161)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 78)
        Me.txtAlamat.TabIndex = 18
        Me.txtAlamat.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbPend)
        Me.Controls.Add(Me.cmbBgn)
        Me.Controls.Add(Me.DTglLhr)
        Me.Controls.Add(Me.BCari)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNIP)
        Me.Name = "Form1"
        Me.Text = "Data Pegawai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents DTglLhr As DateTimePicker
    Friend WithEvents cmbBgn As ComboBox
    Friend WithEvents cmbPend As ComboBox
    Friend WithEvents RBlmKwn As RadioButton
    Friend WithEvents RKwn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BExit As Button
    Friend WithEvents BCancel As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents BEdit As Button
    Friend WithEvents BSave As Button
    Friend WithEvents BCari As Button
    Friend WithEvents txtAlamat As RichTextBox
End Class
