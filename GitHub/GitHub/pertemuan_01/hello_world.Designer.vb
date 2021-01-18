<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hello_world
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pesan 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Pesan 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(25, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Pesan 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(25, 220)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Pesan 4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(200, 155)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 40)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(200, 220)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 40)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "End"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(200, 25)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(150, 40)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Rubah Text"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(200, 90)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(150, 40)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Hapus Text"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(375, 90)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(150, 40)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Pesan Keluar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(375, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 100)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(547, 100)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "HELLO WORLD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 278)
        Me.Panel2.TabIndex = 11
        '
        'hello_world
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 378)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "hello_world"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class
