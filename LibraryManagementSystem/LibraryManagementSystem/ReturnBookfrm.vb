Imports System.Data.OleDb
Public Class ReturnBookfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet

    Private Sub ReturnBookfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        returndate.Text = Today

        borrowid.Text = BorrowedBookfrm.ListView1.SelectedItems(0).SubItems(0).Text
        borrowername.Text = BorrowedBookfrm.ListView1.SelectedItems(0).SubItems(1).Text
        booknamebox.Text = BorrowedBookfrm.ListView1.SelectedItems(0).SubItems(2).Text
        borrowdate.Text = BorrowedBookfrm.ListView1.SelectedItems(0).SubItems(4).Text
        duedate.Text = BorrowedBookfrm.ListView1.SelectedItems(0).SubItems(5).Text

        con.Open()

        cmd = New OleDbCommand("SELECT InStock FROM tblBook WHERE BookTitle ='" & booknamebox.Text & "'", con)

        currentstock.Text = cmd.ExecuteScalar

        cmd = New OleDbCommand("SELECT Borrowed FROM tblBook WHERE BookTitle ='" & booknamebox.Text & "'", con)

        currentborrow.Text = cmd.ExecuteScalar

        con.Close()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If returndate.Value >= duedate.Value Then

            MsgBox("Borrow Book Late ! Fine RM 10.00")


        End If


        Dim stocktotal As Single
        Dim borrowertotal As Single

        stocktotal = Val(currentstock.Text) + 1
        borrowertotal = Val(currentborrow.Text) - 1

        con.Open()


        cmd = New OleDbCommand("UPDATE tblBook Set [InStock] = '" & stocktotal & "' WHERE BookTitle ='" & booknamebox.Text & "'", con)
        cmd.ExecuteNonQuery()

        cmd = New OleDbCommand("UPDATE tblBook Set [Borrowed] = '" & borrowertotal & "' WHERE BookTitle ='" & booknamebox.Text & "'", con)
        cmd.ExecuteNonQuery()


        cmd = New OleDbCommand("UPDATE tblBorrowList Set [ReturnedDate] = '" & "Returned on - " & returndate.Text & "' WHERE BorrowerID =" & borrowid.Text & "", con)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Book Returned Successfully  ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        Me.Close()

        BorrowedBookfrm.showdata()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class