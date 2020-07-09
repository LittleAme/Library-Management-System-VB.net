Imports System.Data.OleDb
Public Class Loginfrm
    'connection to database access
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LibraryManagementSystem\databaseSystem.accdb")
    Dim cmd As New OleDbCommand  'mysql syntax

    'manipulate table in vb
    Dim da As OleDbDataAdapter ' Link table with dataset
    Dim ds As New DataSet 'Temporary  hold database record
    Dim dt As New DataTable 'Travesing the table row
    Dim dr As OleDbDataReader 'To read the dataSet

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        splashscreenfrm.Close()


    End Sub

    Private Sub Loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New OleDbCommand("SELECT * FROM tblAdmin", con)

        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "tblAdmin")
        dt = ds.Tables("tblAdmin")

        'count user in the system
        Dim maxRow As Integer = dt.Rows.Count - 1

        Dim i As Integer
        For i = 0 To maxRow
            If UsernameTextBox.Text = dt.Rows(i).Item(0) And PasswordTextBox.Text = dt.Rows(i).Item(1) Then
                MessageBox.Show("Login successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Mainmenufrm.Show()


                Me.Hide()
                Exit For
            Else
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        Next
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class
