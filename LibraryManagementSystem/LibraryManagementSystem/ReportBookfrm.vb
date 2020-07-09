Public Class ReportBookfrm

    Private Sub TblBookBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblBookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseSystemDataSet)

    End Sub

    Private Sub ReportBookfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseSystemDataSet.tblBook' table. You can move, or remove it, as needed.
        Me.TblBookTableAdapter.Fill(Me.DatabaseSystemDataSet.tblBook)
        Label3.Text = TblBookDataGridView.RowCount() - 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TblBookBindingSource.Filter = "DateAdded >= '" & Trim(DateTimePicker1.Text) & "' and DateAdded <= '" & Trim(DateTimePicker2.Text) & "'"
        Label3.Text = TblBookDataGridView.RowCount() - 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TblBookBindingSource.Filter = String.Empty
        Label3.Text = TblBookDataGridView.RowCount() - 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Mainmenufrm.Show()

    End Sub
End Class