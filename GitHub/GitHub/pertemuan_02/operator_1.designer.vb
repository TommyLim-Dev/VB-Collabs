<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class operator_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pertama = New System.Windows.Forms.TextBox()
        Me.kedua = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.hasil = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka Pertama"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(25, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Kedua"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pertama
        '
        Me.pertama.Location = New System.Drawing.Point(200, 25)
        Me.pertama.Name = "pertama"
        Me.pertama.Size = New System.Drawing.Size(150, 22)
        Me.pertama.TabIndex = 2
        '
        'kedua
        '
        Me.kedua.Location = New System.Drawing.Point(200, 75)
        Me.kedua.Name = "kedua"
        Me.kedua.Size = New System.Drawing.Size(150, 22)
        Me.kedua.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 110)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operator"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(185, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(115, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(25, 310)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(200, 310)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 40)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'hasil
        '
        Me.hasil.Location = New System.Drawing.Point(200, 260)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(150, 22)
        Me.hasil.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(377, 100)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "OPERATOR 1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.hasil)
        Me.Panel1.Controls.Add(Me.pertama)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.kedua)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 368)
        Me.Panel1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(25, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hasil Dari Operator"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'operator_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "operator_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pertama As TextBox
    Friend WithEvents kedua As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents hasil As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
