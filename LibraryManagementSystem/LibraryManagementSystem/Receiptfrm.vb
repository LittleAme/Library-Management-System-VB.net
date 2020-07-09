Imports System.Data.OleDb
Public Class Receiptfrm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet
    Private Sub Receiptfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        labeldate.Text = Today()
        labeltime.Text = DateTime.Now.ToShortTimeString()



        con.Open()

        With cmd
            .Connection = con
            .CommandText = "SELECT BookName , BookAuthor , DueDate  FROM tblBorrowList WHERE BorrowerID = " & BorrowedBookfrm.ListView1.SelectedItems.Item(0).SubItems(0).Text & ""
        End With
        ListView1.Items.Clear()

        dr = cmd.ExecuteReader
        While dr.Read
            With ListView1
                .Items.Add(dr.Item(0))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dr(1))
                    .Add(dr(2))
   
                End With
            End With
        End While


        cmd = New OleDbCommand("SELECT BorrowerName FROM tblBorrowList WHERE BorrowerID =" & BorrowedBookfrm.ListView1.SelectedItems.Item(0).SubItems(0).Text, con)

        lblname.Text = cmd.ExecuteScalar

        con.Close()



    End Sub


   
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintForm1.Print()

    End Sub

End Class