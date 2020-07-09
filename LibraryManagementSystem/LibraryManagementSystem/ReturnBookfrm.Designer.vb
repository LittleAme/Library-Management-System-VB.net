<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBookfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnBookfrm))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.currentborrow = New System.Windows.Forms.TextBox
        Me.currentstock = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.booknamebox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.borrowdate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.borrowid = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.borrowername = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.returndate = New System.Windows.Forms.DateTimePicker
        Me.duedate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.duedate)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.currentborrow)
        Me.GroupBox2.Controls.Add(Me.currentstock)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.booknamebox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.borrowdate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 212)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Infomation"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.returndate)
        Me.GroupBox3.Location = New System.Drawing.Point(268, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 68)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Returned Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Current Borrower :"
        '
        'currentborrow
        '
        Me.currentborrow.Enabled = False
        Me.currentborrow.Location = New System.Drawing.Point(335, 69)
        Me.currentborrow.Name = "currentborrow"
        Me.currentborrow.Size = New System.Drawing.Size(49, 29)
        Me.currentborrow.TabIndex = 5
        '
        'currentstock
        '
        Me.currentstock.Enabled = False
        Me.currentstock.Location = New System.Drawing.Point(119, 69)
        Me.currentstock.Name = "currentstock"
        Me.currentstock.Size = New System.Drawing.Size(49, 29)
        Me.currentstock.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Stock :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Due Date :"
        '
        'booknamebox
        '
        Me.booknamebox.Enabled = False
        Me.booknamebox.Location = New System.Drawing.Point(119, 28)
        Me.booknamebox.Name = "booknamebox"
        Me.booknamebox.Size = New System.Drawing.Size(210, 29)
        Me.booknamebox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Borrow Date :"
        '
        'borrowdate
        '
        Me.borrowdate.Enabled = False
        Me.borrowdate.Location = New System.Drawing.Point(119, 116)
        Me.borrowdate.Name = "borrowdate"
        Me.borrowdate.Size = New System.Drawing.Size(133, 29)
        Me.borrowdate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.borrowid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.borrowername)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 122)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower Information"
        '
        'borrowid
        '
        Me.borrowid.Enabled = False
        Me.borrowid.Location = New System.Drawing.Point(140, 31)
        Me.borrowid.Name = "borrowid"
        Me.borrowid.Size = New System.Drawing.Size(58, 29)
        Me.borrowid.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Borrower Name : "
        '
        'borrowername
        '
        Me.borrowername.Enabled = False
        Me.borrowername.Location = New System.Drawing.Point(140, 70)
        Me.borrowername.Name = "borrowername"
        Me.borrowername.Size = New System.Drawing.Size(210, 29)
        Me.borrowername.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(375, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 34)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Return Book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(241, 474)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'returndate
        '
        Me.returndate.CustomFormat = "dd/MM/yyyy"
        Me.returndate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.returndate.Location = New System.Drawing.Point(15, 28)
        Me.returndate.Name = "returndate"
        Me.returndate.Size = New System.Drawing.Size(124, 29)
        Me.returndate.TabIndex = 14
        '
        'duedate
        '
        Me.duedate.CustomFormat = "dd/MM/yyyy"
        Me.duedate.Enabled = False
        Me.duedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.duedate.Location = New System.Drawing.Point(119, 161)
        Me.duedate.Name = "duedate"
        Me.duedate.Size = New System.Drawing.Size(124, 29)
        Me.duedate.TabIndex = 15
        '
        'ReturnBookfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 511)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ReturnBookfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReturnBookfrm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents currentborrow As System.Windows.Forms.TextBox
    Friend WithEvents currentstock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents booknamebox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents borrowdate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents borrowername As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents borrowid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents duedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents returndate As System.Windows.Forms.DateTimePicker
End Class
