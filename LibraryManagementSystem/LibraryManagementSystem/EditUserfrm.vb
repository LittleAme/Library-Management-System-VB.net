Imports System.Data.OleDb
Public Class EditUserfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet
    Private Sub EditUserfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UserIDTextBox.Text = RecordUserfrm.ListView1.SelectedItems(0).SubItems(0).Text
        NameTextBox.Text = RecordUserfrm.ListView1.SelectedItems(0).SubItems(1).Text
        AddressTextBox.Text = RecordUserfrm.ListView1.SelectedItems(0).SubItems(2).Text
        PhoneNoTextBox.Text = RecordUserfrm.ListView1.SelectedItems(0).SubItems(3).Text
        DateAddedDateTimePicker.Text = RecordUserfrm.ListView1.SelectedItems(0).SubItems(4).Text
        EmailTextBox.Text = RecordUserfrm.ListView1.SelectedItems(0).SubItems(5).Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()

        cmd = New OleDbCommand("UPDATE tblUser set Name = '" & NameTextBox.Text & "', Address ='" & AddressTextBox.Text & "',PhoneNo = '" & PhoneNoTextBox.Text & "',DateAdded='" & DateAddedDateTimePicker.Text & "',Email='" & EmailTextBox.Text & "'  WHERE UserID='" & UserIDTextBox.Text & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("User record updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        con.Close()
        RecordUserfrm.showdata()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class