<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainmenufrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainmenufrm))
        Me.borrowedbookbutton = New System.Windows.Forms.Button
        Me.userrecordbutton = New System.Windows.Forms.Button
        Me.bookrecordbutton = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.exitbutton = New System.Windows.Forms.Button
        Me.logoutbutton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'borrowedbookbutton
        '
        Me.borrowedbookbutton.BackColor = System.Drawing.Color.Transparent
        Me.borrowedbookbutton.BackgroundImage = CType(resources.GetObject("borrowedbookbutton.BackgroundImage"), System.Drawing.Image)
        Me.borrowedbookbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.borrowedbookbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.borrowedbookbutton.Location = New System.Drawing.Point(13, 169)
        Me.borrowedbookbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.borrowedbookbutton.Name = "borrowedbookbutton"
        Me.borrowedbookbutton.Size = New System.Drawing.Size(124, 136)
        Me.borrowedbookbutton.TabIndex = 5
        Me.borrowedbookbutton.Text = "Borrow Book"
        Me.borrowedbookbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.borrowedbookbutton.UseVisualStyleBackColor = False
        '
        'userrecordbutton
        '
        Me.userrecordbutton.BackColor = System.Drawing.Color.Transparent
        Me.userrecordbutton.BackgroundImage = CType(resources.GetObject("userrecordbutton.BackgroundImage"), System.Drawing.Image)
        Me.userrecordbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.userrecordbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.userrecordbutton.Location = New System.Drawing.Point(13, 11)
        Me.userrecordbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.userrecordbutton.Name = "userrecordbutton"
        Me.userrecordbutton.Size = New System.Drawing.Size(126, 136)
        Me.userrecordbutton.TabIndex = 4
        Me.userrecordbutton.Text = "User Record"
        Me.userrecordbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.userrecordbutton.UseVisualStyleBackColor = False
        '
        'bookrecordbutton
        '
        Me.bookrecordbutton.BackColor = System.Drawing.Color.Transparent
        Me.bookrecordbutton.BackgroundImage = CType(resources.GetObject("bookrecordbutton.BackgroundImage"), System.Drawing.Image)
        Me.bookrecordbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bookrecordbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bookrecordbutton.Location = New System.Drawing.Point(160, 11)
        Me.bookrecordbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bookrecordbutton.Name = "bookrecordbutton"
        Me.bookrecordbutton.Size = New System.Drawing.Size(124, 136)
        Me.bookrecordbutton.TabIndex = 3
        Me.bookrecordbutton.Text = "Book Record"
        Me.bookrecordbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bookrecordbutton.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.Location = New System.Drawing.Point(160, 169)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 136)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Report"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(162, 326)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(122, 35)
        Me.exitbutton.TabIndex = 8
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'logoutbutton
        '
        Me.logoutbutton.Location = New System.Drawing.Point(13, 326)
        Me.logoutbutton.Name = "logoutbutton"
        Me.logoutbutton.Size = New System.Drawing.Size(124, 35)
        Me.logoutbutton.TabIndex = 7
        Me.logoutbutton.Text = "Logout"
        Me.logoutbutton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.borrowedbookbutton)
        Me.Panel1.Controls.Add(Me.exitbutton)
        Me.Panel1.Controls.Add(Me.bookrecordbutton)
        Me.Panel1.Controls.Add(Me.logoutbutton)
        Me.Panel1.Controls.Add(Me.userrecordbutton)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(11, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 382)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(90, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(90, 54)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(207, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(11, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 79)
        Me.Panel2.TabIndex = 13
        '
        'Mainmenufrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 493)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Mainmenufrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents borrowedbookbutton As System.Windows.Forms.Button
    Friend WithEvents userrecordbutton As System.Windows.Forms.Button
    Friend WithEvents bookrecordbutton As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents logoutbutton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
