Imports System.Data.OleDb
Public Class EditBookfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet
    Private Sub EditBookfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BookIDTextBox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(0).Text
        BookTitleTextBox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(1).Text
        AuthorTextBox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(2).Text
        DateAddedDateTimePicker.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(3).Text
        CopiesTextBox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(4).Text
        InStockTextBox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(5).Text
        BorrowedTextBox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(6).Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()

        cmd = New OleDbCommand("UPDATE tblBook set BookTitle = '" & BookTitleTextBox.Text & "', Author ='" & AuthorTextBox.Text & "',DateAdded = '" & DateAddedDateTimePicker.Text & "',Copies='" & CopiesTextBox.Text & "',InStock='" & InStockTextBox.Text & "',Borrowed='" & BorrowedTextBox.Text & "' WHERE BookID='" & BookIDTextBox.Text & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Book record updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        con.Close()
        RecordBookfrm.showdata()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class