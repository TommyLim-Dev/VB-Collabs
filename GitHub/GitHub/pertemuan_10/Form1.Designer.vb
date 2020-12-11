<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TxtUser = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Blogin = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtUser
        '
        Me.TxtUser.AutoSize = True
        Me.TxtUser.Location = New System.Drawing.Point(16, 11)
        Me.TxtUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(79, 17)
        Me.TxtUser.TabIndex = 0
        Me.TxtUser.Text = "User Name"
        '
        'TxtPassword
        '
        Me.TxtPassword.AutoSize = True
        Me.TxtPassword.Location = New System.Drawing.Point(16, 55)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(69, 17)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 11)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 52)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(159, 22)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Blogin
        '
        Me.Blogin.Location = New System.Drawing.Point(20, 107)
        Me.Blogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Blogin.Name = "Blogin"
        Me.Blogin.Size = New System.Drawing.Size(100, 28)
        Me.Blogin.TabIndex = 4
        Me.Blogin.Text = "Login"
        Me.Blogin.UseVisualStyleBackColor = True
        '
        'Bexit
        '
        Me.Bexit.Location = New System.Drawing.Point(184, 107)
        Me.Bexit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(100, 28)
        Me.Bexit.TabIndex = 5
        Me.Bexit.Text = "Exit"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 176)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.Blogin)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUser)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUser As Label
    Friend WithEvents TxtPassword As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Blogin As Button
    Friend WithEvents Bexit As Button
End Class
