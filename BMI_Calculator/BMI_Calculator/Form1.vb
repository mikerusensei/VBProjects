Public Class Form1
    Private Sub cmd_novince_Click(sender As Object, e As EventArgs) Handles cmd_novince.Click
        Form2.Show()
        Hide()
    End Sub

    Private Sub cmd_intermidiate_Click(sender As Object, e As EventArgs) Handles cmd_intermidiate.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub cmd_expert_Click(sender As Object, e As EventArgs) Handles cmd_expert.Click
        Form4.Show()
        Hide()
    End Sub
End Class
