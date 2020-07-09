Imports System.Data.OleDb
Public Class NewBookfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet
    Dim i As Integer

    Private Sub NewBookfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CopiesTextBox.Text = InStockTextBox.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If BookIDTextBox.Text = ("") Or BookTitleTextBox.Text = ("") Or AuthorTextBox.Text = ("") Or CopiesTextBox.Text = ("") Or InStockTextBox.Text = ("") Or BorrowedTextBox.Text = ("") Then
            MessageBox.Show("Please fill the blank space", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else

            con.Open()
            With cmd
                .Connection = con
                .CommandText = "INSERT INTO tblBook(BookID,BookTitle,Author,DateAdded,Copies,InStock,Borrowed) VALUES ('" & BookIDTextBox.Text & "','" & BookTitleTextBox.Text & "','" & AuthorTextBox.Text & "','" & DateAddedDateTimePicker.Text & "','" & CopiesTextBox.Text & "','" & InStockTextBox.Text & "','" & BorrowedTextBox.Text & "')"

                i = .ExecuteNonQuery
            End With

            If i > 0 Then
                MessageBox.Show("New Book Added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

            RecordBookfrm.showdata()
            Me.Close()
            RecordBookfrm.Show()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub CopiesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiesTextBox.TextChanged
        InStockTextBox.Text = CopiesTextBox.Text
        BorrowedTextBox.Text = "0"
    End Sub
End Class