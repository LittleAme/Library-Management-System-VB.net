Public Class ReportMenu

    Private Sub exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReportUserfrm.Show()
        Me.Hide()
        Mainmenufrm.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportBookfrm.Show()
        Me.Hide()
        Mainmenufrm.Hide()

    End Sub
End Class