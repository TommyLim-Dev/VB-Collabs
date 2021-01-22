<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pert12
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.cmbjurusan = New System.Windows.Forms.ComboBox()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bexit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.binput = New System.Windows.Forms.Button()
        Me.bedit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(113, 50)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(187, 20)
        Me.txtnim.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(113, 84)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(187, 20)
        Me.txtnama.TabIndex = 5
        '
        'txtalamat
        '
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(113, 123)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(187, 66)
        Me.txtalamat.TabIndex = 6
        '
        'cmbjurusan
        '
        Me.cmbjurusan.FormattingEnabled = True
        Me.cmbjurusan.Items.AddRange(New Object() {"Akuntansi", "Manajemen", "Sastra Inggris", "Sistem Informasi", "Teknik Informatika"})
        Me.cmbjurusan.Location = New System.Drawing.Point(113, 207)
        Me.cmbjurusan.Name = "cmbjurusan"
        Me.cmbjurusan.Size = New System.Drawing.Size(155, 21)
        Me.cmbjurusan.TabIndex = 7
        '
        'bsimpan
        '
        Me.bsimpan.Location = New System.Drawing.Point(113, 250)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(66, 25)
        Me.bsimpan.TabIndex = 8
        Me.bsimpan.Text = "Simpan"
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Location = New System.Drawing.Point(301, 249)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(66, 25)
        Me.bhapus.TabIndex = 9
        Me.bhapus.Text = "Hapus"
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'bexit
        '
        Me.bexit.Location = New System.Drawing.Point(392, 248)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(66, 25)
        Me.bexit.TabIndex = 10
        Me.bexit.Text = "Exit"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 292)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(422, 146)
        Me.DataGridView1.TabIndex = 11
        '
        'binput
        '
        Me.binput.Location = New System.Drawing.Point(24, 251)
        Me.binput.Name = "binput"
        Me.binput.Size = New System.Drawing.Size(70, 23)
        Me.binput.TabIndex = 12
        Me.binput.Text = "Input"
        Me.binput.UseVisualStyleBackColor = True
        '
        'bedit
        '
        Me.bedit.Location = New System.Drawing.Point(206, 251)
        Me.bedit.Name = "bedit"
        Me.bedit.Size = New System.Drawing.Size(70, 23)
        Me.bedit.TabIndex = 13
        Me.bedit.Text = "Edit"
        Me.bedit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 450)
        Me.Controls.Add(Me.bedit)
        Me.Controls.Add(Me.binput)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.cmbjurusan)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnim As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents cmbjurusan As ComboBox
    Friend WithEvents bsimpan As Button
    Friend WithEvents bhapus As Button
    Friend WithEvents bexit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents binput As Button
    Friend WithEvents bedit As Button
End Class
