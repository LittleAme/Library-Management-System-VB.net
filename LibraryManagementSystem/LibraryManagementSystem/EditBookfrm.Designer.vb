<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBookfrm
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
        Dim BookIDLabel As System.Windows.Forms.Label
        Dim BookTitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim DateAddedLabel As System.Windows.Forms.Label
        Dim CopiesLabel As System.Windows.Forms.Label
        Dim InStockLabel As System.Windows.Forms.Label
        Dim BorrowedLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBookfrm))
        Me.Button1 = New System.Windows.Forms.Button
        Me.BookIDTextBox = New System.Windows.Forms.TextBox
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox
        Me.AuthorTextBox = New System.Windows.Forms.TextBox
        Me.DateAddedDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.CopiesTextBox = New System.Windows.Forms.TextBox
        Me.InStockTextBox = New System.Windows.Forms.TextBox
        Me.BorrowedTextBox = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        BookIDLabel = New System.Windows.Forms.Label
        BookTitleLabel = New System.Windows.Forms.Label
        AuthorLabel = New System.Windows.Forms.Label
        DateAddedLabel = New System.Windows.Forms.Label
        CopiesLabel = New System.Windows.Forms.Label
        InStockLabel = New System.Windows.Forms.Label
        BorrowedLabel = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(13, 30)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(67, 21)
        BookIDLabel.TabIndex = 16
        BookIDLabel.Text = "Book ID:"
        '
        'BookTitleLabel
        '
        BookTitleLabel.AutoSize = True
        BookTitleLabel.Location = New System.Drawing.Point(13, 65)
        BookTitleLabel.Name = "BookTitleLabel"
        BookTitleLabel.Size = New System.Drawing.Size(81, 21)
        BookTitleLabel.TabIndex = 18
        BookTitleLabel.Text = "Book Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(13, 100)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(61, 21)
        AuthorLabel.TabIndex = 20
        AuthorLabel.Text = "Author:"
        '
        'DateAddedLabel
        '
        DateAddedLabel.AutoSize = True
        DateAddedLabel.Location = New System.Drawing.Point(13, 136)
        DateAddedLabel.Name = "DateAddedLabel"
        DateAddedLabel.Size = New System.Drawing.Size(94, 21)
        DateAddedLabel.TabIndex = 22
        DateAddedLabel.Text = "Date Added:"
        '
        'CopiesLabel
        '
        CopiesLabel.AutoSize = True
        CopiesLabel.Location = New System.Drawing.Point(22, 34)
        CopiesLabel.Name = "CopiesLabel"
        CopiesLabel.Size = New System.Drawing.Size(60, 21)
        CopiesLabel.TabIndex = 24
        CopiesLabel.Text = "Copies:"
        '
        'InStockLabel
        '
        InStockLabel.AutoSize = True
        InStockLabel.Location = New System.Drawing.Point(22, 69)
        InStockLabel.Name = "InStockLabel"
        InStockLabel.Size = New System.Drawing.Size(68, 21)
        InStockLabel.TabIndex = 26
        InStockLabel.Text = "In Stock:"
        '
        'BorrowedLabel
        '
        BorrowedLabel.AutoSize = True
        BorrowedLabel.Location = New System.Drawing.Point(22, 104)
        BorrowedLabel.Name = "BorrowedLabel"
        BorrowedLabel.Size = New System.Drawing.Size(81, 21)
        BorrowedLabel.TabIndex = 28
        BorrowedLabel.Text = "Borrowed:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 37)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.Enabled = False
        Me.BookIDTextBox.Location = New System.Drawing.Point(113, 27)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(63, 29)
        Me.BookIDTextBox.TabIndex = 17
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Location = New System.Drawing.Point(113, 62)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(242, 29)
        Me.BookTitleTextBox.TabIndex = 19
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(113, 97)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(145, 29)
        Me.AuthorTextBox.TabIndex = 21
        '
        'DateAddedDateTimePicker
        '
        Me.DateAddedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateAddedDateTimePicker.Location = New System.Drawing.Point(113, 132)
        Me.DateAddedDateTimePicker.Name = "DateAddedDateTimePicker"
        Me.DateAddedDateTimePicker.Size = New System.Drawing.Size(105, 29)
        Me.DateAddedDateTimePicker.TabIndex = 23
        '
        'CopiesTextBox
        '
        Me.CopiesTextBox.Location = New System.Drawing.Point(122, 31)
        Me.CopiesTextBox.Name = "CopiesTextBox"
        Me.CopiesTextBox.Size = New System.Drawing.Size(46, 29)
        Me.CopiesTextBox.TabIndex = 25
        '
        'InStockTextBox
        '
        Me.InStockTextBox.Location = New System.Drawing.Point(122, 66)
        Me.InStockTextBox.Name = "InStockTextBox"
        Me.InStockTextBox.Size = New System.Drawing.Size(46, 29)
        Me.InStockTextBox.TabIndex = 27
        '
        'BorrowedTextBox
        '
        Me.BorrowedTextBox.Location = New System.Drawing.Point(122, 101)
        Me.BorrowedTextBox.Name = "BorrowedTextBox"
        Me.BorrowedTextBox.Size = New System.Drawing.Size(46, 29)
        Me.BorrowedTextBox.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 37)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(88, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(372, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(BookIDLabel)
        Me.GroupBox1.Controls.Add(Me.BookIDTextBox)
        Me.GroupBox1.Controls.Add(BookTitleLabel)
        Me.GroupBox1.Controls.Add(Me.BookTitleTextBox)
        Me.GroupBox1.Controls.Add(AuthorLabel)
        Me.GroupBox1.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox1.Controls.Add(DateAddedLabel)
        Me.GroupBox1.Controls.Add(Me.DateAddedDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 172)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(CopiesLabel)
        Me.GroupBox2.Controls.Add(Me.CopiesTextBox)
        Me.GroupBox2.Controls.Add(InStockLabel)
        Me.GroupBox2.Controls.Add(Me.InStockTextBox)
        Me.GroupBox2.Controls.Add(BorrowedLabel)
        Me.GroupBox2.Controls.Add(Me.BorrowedTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(389, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 172)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Stock"
        '
        'EditBookfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 372)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditBookfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditBookfrm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BookIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateAddedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CopiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
