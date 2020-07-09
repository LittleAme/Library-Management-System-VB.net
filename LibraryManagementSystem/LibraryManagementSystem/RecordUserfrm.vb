﻿Imports System.Data.OleDb
Public Class RecordUserfrm
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
            .CommandText = "SELECT * FROM tblUser"
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

                End With
            End With
        End While
        con.Close()


    End Sub



    Private Sub RecordUserfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdata()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer

        con.Open()

        cmd = New OleDbCommand("DELETE * FROM tblUser WHERE UserID ='" & ListView1.SelectedItems.Item(0).SubItems(0).Text & "'", con)

        If MessageBox.Show("Are you sure want to delete " + ListView1.SelectedItems.Item(0).SubItems(1).Text + " ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            i = cmd.ExecuteNonQuery()
        End If
        con.Close()
        showdata()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        con.Open()

        With cmd
            .Connection = con
            .CommandText = "SELECT * FROM tblUser WHERE Name LIKE  '%" & TextBox1.Text & "%'"
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

                End With
            End With
        End While
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NewUserfrm.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        EditUserfrm.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Mainmenufrm.Show()
        Me.Close()

    End Sub
End Class