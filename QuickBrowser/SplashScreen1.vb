Public NotInheritable Class SplashScreen1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With ProgressBar1

            .Minimum = 0
            .Maximum = 100
            .Value = .Value + 10
            If .Value = .Maximum Then
                Timer1.Enabled = False
                Me.Hide()
                Form1.Show()
            End If
        End With
    End Sub

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
