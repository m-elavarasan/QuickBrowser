
Public Class Form2



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MAINDBDataSet.history' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.MAINDBDataSet.history)
        'TODO: This line of code loads data into the 'MAINDBDataSet.history' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class