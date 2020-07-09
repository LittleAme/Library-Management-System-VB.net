Imports System.Data.OleDb

Public Class ReportUserfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet


    Private Sub TblUserBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseSystemDataSet)

    End Sub

    Private Sub ReportUserfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseSystemDataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.DatabaseSystemDataSet.tblUser)
        Label3.Text = TblUserDataGridView.RowCount()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TblUserBindingSource.Filter = "DateAdded >= '" & Trim(DateTimePicker1.Text) & "' and DateAdded <= '" & Trim(DateTimePicker2.Text) & "'"
        Label3.Text = TblUserDataGridView.RowCount()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TblUserBindingSource.Filter = String.Empty
        Label3.Text = TblUserDataGridView.RowCount()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Mainmenufrm.Show()
    End Sub
End Class