<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUserfrm
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneNoLabel As System.Windows.Forms.Label
        Dim DateAddedLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUserfrm))
        Me.Button1 = New System.Windows.Forms.Button
        Me.UserIDTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.PhoneNoTextBox = New System.Windows.Forms.TextBox
        Me.DateAddedDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        UserIDLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        PhoneNoLabel = New System.Windows.Forms.Label
        DateAddedLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(39, 41)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(64, 21)
        UserIDLabel.TabIndex = 14
        UserIDLabel.Text = "User ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(48, 76)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(55, 21)
        NameLabel.TabIndex = 16
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(34, 111)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(69, 21)
        AddressLabel.TabIndex = 18
        AddressLabel.Text = "Address:"
        '
        'PhoneNoLabel
        '
        PhoneNoLabel.AutoSize = True
        PhoneNoLabel.Location = New System.Drawing.Point(21, 195)
        PhoneNoLabel.Name = "PhoneNoLabel"
        PhoneNoLabel.Size = New System.Drawing.Size(82, 21)
        PhoneNoLabel.TabIndex = 20
        PhoneNoLabel.Text = "Phone No:"
        '
        'DateAddedLabel
        '
        DateAddedLabel.AutoSize = True
        DateAddedLabel.Location = New System.Drawing.Point(9, 270)
        DateAddedLabel.Name = "DateAddedLabel"
        DateAddedLabel.Size = New System.Drawing.Size(94, 21)
        DateAddedLabel.TabIndex = 22
        DateAddedLabel.Text = "Date Added:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(52, 235)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 21)
        EmailLabel.TabIndex = 24
        EmailLabel.Text = "Email:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 33)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Enabled = False
        Me.UserIDTextBox.Location = New System.Drawing.Point(116, 38)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(60, 29)
        Me.UserIDTextBox.TabIndex = 15
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(116, 73)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(268, 29)
        Me.NameTextBox.TabIndex = 17
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(116, 108)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(268, 78)
        Me.AddressTextBox.TabIndex = 19
        '
        'PhoneNoTextBox
        '
        Me.PhoneNoTextBox.Location = New System.Drawing.Point(116, 192)
        Me.PhoneNoTextBox.Name = "PhoneNoTextBox"
        Me.PhoneNoTextBox.Size = New System.Drawing.Size(158, 29)
        Me.PhoneNoTextBox.TabIndex = 21
        '
        'DateAddedDateTimePicker
        '
        Me.DateAddedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateAddedDateTimePicker.Location = New System.Drawing.Point(116, 264)
        Me.DateAddedDateTimePicker.Name = "DateAddedDateTimePicker"
        Me.DateAddedDateTimePicker.Size = New System.Drawing.Size(121, 29)
        Me.DateAddedDateTimePicker.TabIndex = 23
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(116, 227)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(214, 29)
        Me.EmailTextBox.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 33)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(UserIDLabel)
        Me.GroupBox1.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(PhoneNoLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNoTextBox)
        Me.GroupBox1.Controls.Add(DateAddedLabel)
        Me.GroupBox1.Controls.Add(Me.DateAddedDateTimePicker)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 310)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'EditUserfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditUserfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateAddedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
