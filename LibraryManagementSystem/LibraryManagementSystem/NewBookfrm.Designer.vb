<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBookfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewBookfrm))
        Me.BookIDTextBox = New System.Windows.Forms.TextBox
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox
        Me.AuthorTextBox = New System.Windows.Forms.TextBox
        Me.DateAddedDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.CopiesTextBox = New System.Windows.Forms.TextBox
        Me.InStockTextBox = New System.Windows.Forms.TextBox
        Me.BorrowedTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        BookIDLabel = New System.Windows.Forms.Label
        BookTitleLabel = New System.Windows.Forms.Label
        AuthorLabel = New System.Windows.Forms.Label
        DateAddedLabel = New System.Windows.Forms.Label
        CopiesLabel = New System.Windows.Forms.Label
        InStockLabel = New System.Windows.Forms.Label
        BorrowedLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(13, 44)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(67, 21)
        BookIDLabel.TabIndex = 17
        BookIDLabel.Text = "Book ID:"
        '
        'BookTitleLabel
        '
        BookTitleLabel.AutoSize = True
        BookTitleLabel.Location = New System.Drawing.Point(13, 79)
        BookTitleLabel.Name = "BookTitleLabel"
        BookTitleLabel.Size = New System.Drawing.Size(81, 21)
        BookTitleLabel.TabIndex = 19
        BookTitleLabel.Text = "Book Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(13, 114)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(61, 21)
        AuthorLabel.TabIndex = 21
        AuthorLabel.Text = "Author:"
        '
        'DateAddedLabel
        '
        DateAddedLabel.AutoSize = True
        DateAddedLabel.Location = New System.Drawing.Point(13, 160)
        DateAddedLabel.Name = "DateAddedLabel"
        DateAddedLabel.Size = New System.Drawing.Size(94, 21)
        DateAddedLabel.TabIndex = 23
        DateAddedLabel.Text = "Date Added:"
        '
        'CopiesLabel
        '
        CopiesLabel.AutoSize = True
        CopiesLabel.Location = New System.Drawing.Point(39, 49)
        CopiesLabel.Name = "CopiesLabel"
        CopiesLabel.Size = New System.Drawing.Size(60, 21)
        CopiesLabel.TabIndex = 25
        CopiesLabel.Text = "Copies:"
        '
        'InStockLabel
        '
        InStockLabel.AutoSize = True
        InStockLabel.Location = New System.Drawing.Point(31, 95)
        InStockLabel.Name = "InStockLabel"
        InStockLabel.Size = New System.Drawing.Size(68, 21)
        InStockLabel.TabIndex = 27
        InStockLabel.Text = "In Stock:"
        '
        'BorrowedLabel
        '
        BorrowedLabel.AutoSize = True
        BorrowedLabel.Location = New System.Drawing.Point(18, 135)
        BorrowedLabel.Name = "BorrowedLabel"
        BorrowedLabel.Size = New System.Drawing.Size(81, 21)
        BorrowedLabel.TabIndex = 29
        BorrowedLabel.Text = "Borrowed:"
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.Location = New System.Drawing.Point(113, 41)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(60, 29)
        Me.BookIDTextBox.TabIndex = 18
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Location = New System.Drawing.Point(113, 76)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(251, 29)
        Me.BookTitleTextBox.TabIndex = 20
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(113, 111)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(200, 29)
        Me.AuthorTextBox.TabIndex = 22
        '
        'DateAddedDateTimePicker
        '
        Me.DateAddedDateTimePicker.CustomFormat = "d/MM/yyyy"
        Me.DateAddedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAddedDateTimePicker.Location = New System.Drawing.Point(113, 157)
        Me.DateAddedDateTimePicker.Name = "DateAddedDateTimePicker"
        Me.DateAddedDateTimePicker.Size = New System.Drawing.Size(129, 29)
        Me.DateAddedDateTimePicker.TabIndex = 24
        '
        'CopiesTextBox
        '
        Me.CopiesTextBox.Location = New System.Drawing.Point(118, 49)
        Me.CopiesTextBox.Name = "CopiesTextBox"
        Me.CopiesTextBox.Size = New System.Drawing.Size(48, 29)
        Me.CopiesTextBox.TabIndex = 26
        '
        'InStockTextBox
        '
        Me.InStockTextBox.Location = New System.Drawing.Point(118, 92)
        Me.InStockTextBox.Name = "InStockTextBox"
        Me.InStockTextBox.Size = New System.Drawing.Size(48, 29)
        Me.InStockTextBox.TabIndex = 28
        '
        'BorrowedTextBox
        '
        Me.BorrowedTextBox.Location = New System.Drawing.Point(118, 135)
        Me.BorrowedTextBox.Name = "BorrowedTextBox"
        Me.BorrowedTextBox.Size = New System.Drawing.Size(48, 29)
        Me.BorrowedTextBox.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(390, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 32)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 197)
        Me.GroupBox1.TabIndex = 32
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
        Me.GroupBox2.Location = New System.Drawing.Point(410, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 197)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Stock"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(84, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(442, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'NewBookfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 391)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "NewBookfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BookIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateAddedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CopiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
