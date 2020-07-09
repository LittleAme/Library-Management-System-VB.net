Public NotInheritable Class splashscreenfrm

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 10) Then
            Label1.Text = "Reading modules.."
        ElseIf (ProgressBar1.Value = 20) Then
            Label1.Text = "Turning on modules."
        ElseIf (ProgressBar1.Value = 40) Then
            Label1.Text = "Starting modules.."
        ElseIf (ProgressBar1.Value = 60) Then
            Label1.Text = "Loading modules.."
        ElseIf (ProgressBar1.Value = 80) Then
            Label1.Text = "Done Loading modules.."
        ElseIf (ProgressBar1.Value = 100) Then

            Loginfrm.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub


    Private Sub SplashScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'splash in screen code
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next

        Timer1.Start() 'start the timer when the window open
    End Sub
End Class
