Imports System.Data.OleDb
Public Class Borrowfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet


   



    Public Sub showdata()
        con.Open()

        With cmd
            .Connection = con
            .CommandText = "SELECT Name FROM tblUser"
        End With
        ListView1.Items.Clear()

        dr = cmd.ExecuteReader
        While dr.Read
            With ListView1
                .Items.Add(dr.Item(0))
                With .Items(.Items.Count - 1).SubItems



                End With
            End With
        End While
        con.Close()

    End Sub


    Private Sub Borrowfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdata()
        bookauthortxtbox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(2).Text
        BookTitleTextBox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(1).Text
        copiestxtbox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(4).Text
        stocktxtbox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(5).Text
        borrowedtxtbox.Text = RecordBookfrm.ListView1.SelectedItems(0).SubItems(6).Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        con.Open()

        With cmd
            .Connection = con
            .CommandText = "SELECT Name FROM tblUser WHERE Name LIKE   '%" & TextBox1.Text & "%'"
        End With
        ListView1.Items.Clear()

        dr = cmd.ExecuteReader
        While dr.Read
            With ListView1
                .Items.Add(dr.Item(0))
                With .Items(.Items.Count - 1).SubItems


                End With
            End With
        End While
        con.Close()
    End Sub

    Private Sub borrowbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrowbtn.Click
        Dim i As Integer
        Dim stocktotal As Single
        Dim borrowertotal As Single



        stocktotal = Val(stocktxtbox.Text) - 1
        borrowertotal = Val(borrowedtxtbox.Text) + 1


        con.Open()


        cmd = New OleDbCommand("UPDATE tblBook Set [InStock] = " & stocktotal & " WHERE BookTitle ='" & BookTitleTextBox.Text & "'", con)
        cmd.ExecuteNonQuery()

        cmd = New OleDbCommand("UPDATE tblBook Set [Borrowed] = " & borrowertotal & " WHERE BookTitle ='" & BookTitleTextBox.Text & "'", con)
        cmd.ExecuteNonQuery()

        With cmd
            .Connection = con
            .CommandText = "INSERT INTO tblBorrowList(BorrowerName,BookAuthor,BookName,DateBorrow,DueDate,ReturnedDate) VALUES ('" & ListView1.SelectedItems(0).SubItems(0).Text & "','" & bookauthortxtbox.Text & "','" & BookTitleTextBox.Text & "', '" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & "-" & "')"

            i = .ExecuteNonQuery
        End With

        If i > 0 Then
            MsgBox("Succesful")
        End If
        con.Close()

        Me.Close()
        RecordBookfrm.showdata()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class