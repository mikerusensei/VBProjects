Public Class Form2
    Dim total_grand As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Display_Choice(choice)
        Dim chicken_img, spag_img, juice_img, eggpie_img As Image
        chicken_img = My.Resources.chicken
        spag_img = My.Resources.spaghetti
        juice_img = My.Resources.juice
        eggpie_img = My.Resources.eggpie

        If choice = "Chicken" Then
            PictureBox1.Image = chicken_img
        ElseIf choice = "Spaghetti" Then
            PictureBox1.Image = spag_img
        ElseIf choice = "Juice" Then
            PictureBox1.Image = juice_img
        ElseIf choice = "Egg Pie" Then
            PictureBox1.Image = eggpie_img
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim choice As String

        choice = ComboBox1.Text
        Display_Choice(choice)
    End Sub

    Private Sub cmd_return_Click(sender As Object, e As EventArgs) Handles cmd_return.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        prod_listbox.Items.Clear()
        qty_listbox.Items.Clear()
        price_listbox.Items.Clear()
        total_listbox.Items.Clear()
        grand_total.Text = "0"
        total_grand = 0
    End Sub

    Private Sub addtolistbox(choice)
        Dim price, total As Integer

        If choice = "Chicken" Then
            price = 50
            total = price * Val(TextBox1.Text)
            prod_listbox.Items.Add(choice)
            qty_listbox.Items.Add(TextBox1.Text)
            price_listbox.Items.Add(price)
            total_listbox.Items.Add(total)
            total_grand += total
        ElseIf choice = "Spaghetti" Then
            price = 50
            total = price * Val(TextBox1.Text)
            prod_listbox.Items.Add(choice)
            qty_listbox.Items.Add(TextBox1.Text)
            price_listbox.Items.Add(price)
            total_listbox.Items.Add(total)
            total_grand += total
        ElseIf choice = "Juice" Then
            price = 30
            total = price * Val(TextBox1.Text)
            prod_listbox.Items.Add(choice)
            qty_listbox.Items.Add(TextBox1.Text)
            price_listbox.Items.Add(price)
            total_listbox.Items.Add(total)
            total_grand += total
        ElseIf choice = "Egg Pie" Then
            price = 25
            total = price * Val(TextBox1.Text)
            prod_listbox.Items.Add(choice)
            qty_listbox.Items.Add(TextBox1.Text)
            price_listbox.Items.Add(price)
            total_listbox.Items.Add(total)
            total_grand += total
        End If
    End Sub
    Private Sub cmd_post_Click(sender As Object, e As EventArgs) Handles cmd_post.Click
        Dim choice As String

        choice = ComboBox1.Text
        addtolistbox(choice)
        grand_total.Text = total_grand
    End Sub
End Class