Public Class Form1
    Private Sub cmd_order_Click(sender As Object, e As EventArgs) Handles cmd_order.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub cms_about_Click(sender As Object, e As EventArgs) Handles cms_about.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub
End Class
