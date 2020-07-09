Imports System.Data.OleDb
Public Class NewUserfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet
    Dim i As Integer

    Private Sub NewUserfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UserIDTextBox.Text = ("") Or NameTextBox.Text = ("") Or AddressTextBox.Text = ("") Or PhoneNoTextBox.Text = ("") Or DateAddedDateTimePicker.Text = ("") Or EmailTextBox.Text = ("") Then
            MessageBox.Show("Please fill the blank space", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "INSERT INTO tblUser(UserID,Name,Address,PhoneNo,DateAdded,Email) VALUES ('" & UserIDTextBox.Text & "','" & NameTextBox.Text & "','" & AddressTextBox.Text & "','" & PhoneNoTextBox.Text & "','" & DateAddedDateTimePicker.Text & "','" & EmailTextBox.Text & "')"

                i = .ExecuteNonQuery
            End With

            If i > 0 Then
                MessageBox.Show("New User Added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

            RecordUserfrm.showdata()
            Me.Close()
            RecordUserfrm.Show()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class