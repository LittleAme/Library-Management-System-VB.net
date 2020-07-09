Imports System.Data.OleDb
Public Class BorrowedBookfrm
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
            .CommandText = "SELECT *  FROM tblBorrowList"
        End With
        ListView1.Items.Clear()

        dr = cmd.ExecuteReader
        While dr.Read
            With ListView1
                .Items.Add(dr.Item(0))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dr(1))
                    .Add(dr(2))
                    .Add(dr(3))
                    .Add(dr(4))
                    .Add(dr(5))
                    .Add(dr(6))
                   

                End With
            End With
        End While
        con.Close()
    End Sub
   

    Private Sub BorrowedBookfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdata()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mainmenufrm.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ReturnBookfrm.Show()

    End Sub

 
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer

        con.Open()

        cmd = New OleDbCommand("DELETE * FROM tblBorrowList WHERE ReturnedDate LIKE '%" & "Returned" & "%'  ", con)

        If MessageBox.Show("Are you sure want to delete all the returned book record? ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            i = cmd.ExecuteNonQuery()
        End If
        con.Close()
        showdata()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        con.Open()

        If ComboBox1.Text = "Borrower Name" Then
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM tblBorrowlist WHERE BorrowerName LIKE   '%" & TextBox1.Text & "%'"
            End With
            ListView1.Items.Clear()

            dr = cmd.ExecuteReader
            While dr.Read
                With ListView1
                    .Items.Add(dr.Item(0))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dr(1))
                        .Add(dr(2))
                        .Add(dr(3))
                        .Add(dr(4))
                        .Add(dr(5))
                        .Add(dr(6))
                     
                    End With
                End With
            End While
        End If

        If ComboBox1.Text = "Book Name" Then
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM tblBorrowlist WHERE BookName LIKE   '%" & TextBox1.Text & "%'"
            End With
            ListView1.Items.Clear()

            dr = cmd.ExecuteReader
            While dr.Read
                With ListView1
                    .Items.Add(dr.Item(0))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dr(1))
                        .Add(dr(2))
                        .Add(dr(3))
                        .Add(dr(4))
                        .Add(dr(5))
                        .Add(dr(6))

                    End With
                End With
            End While



        End If


        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Receiptfrm.Show()
    End Sub

   

End Class