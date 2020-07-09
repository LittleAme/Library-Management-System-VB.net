Public Class Mainmenufrm

    Private Sub bookrecordbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bookrecordbutton.Click
        RecordBookfrm.Show()
        Me.Hide()

    End Sub

    Private Sub userrecordbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userrecordbutton.Click
        RecordUserfrm.Show()
        Me.Hide()

    End Sub

    Private Sub borrowedbookbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrowedbookbutton.Click
        BorrowedBookfrm.Show()
        Me.Hide()

    End Sub

    Private Sub exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        If MessageBox.Show("Are you sure want to quit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Loginfrm.Close()

        End If
    End Sub

    Private Sub logoutbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logoutbutton.Click
        MessageBox.Show("Logout Successful!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Loginfrm.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReportMenu.Show()


    End Sub
End Class