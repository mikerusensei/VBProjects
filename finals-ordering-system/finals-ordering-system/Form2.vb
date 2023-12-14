Public Class Form2
    Private Sub cmd_home_Click(sender As Object, e As EventArgs) Handles cmd_home.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load zero the side
        txtbx_qty_bread_sticks.Text = 0
        txtbx_qty_chicken_wings.Text = 0

        'Load zero the drinks
        txtbx_qty_soda_in_can.Text = 0
        txtbx_qty_soda_8_oz.Text = 0
        txtbx_qty_soda_15L.Text = 0
        txtbx_qty_juice.Text = 0
        txtbx_qty_water_120_mL.Text = 0

    End Sub

    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        txtbx_total_orders.Text = ""

        'Clear Pizza Size Radiobutton
        rad_size_small.Checked = False
        rad_size_medium.Checked = False
        rad_size_large.Checked = False

        'Clear Toppings Checkbox and Textbox
        chckbx_cheese.CheckState = 0
        chckbx_peperoni.CheckState = 0
        chckbx_sausage.CheckState = 0
        chckbx_onions.CheckState = 0
        chckbx_olives.CheckState = 0
        txtbx_total_toppings.Text = ""

        'Clear Side Textbox
        txtbx_qty_bread_sticks.Text = 0
        txtbx_qty_chicken_wings.Text = 0
        txtbx_subtotal_bread_sticks.Text = ""
        txtbx_subtotal_chicken_wings.Text = ""
        txtbx_total_side_orders.Text = ""

        'Clear Drinks Textbox
        txtbx_qty_soda_in_can.Text = 0
        txtbx_qty_soda_8_oz.Text = 0
        txtbx_qty_soda_15L.Text = 0
        txtbx_qty_juice.Text = 0
        txtbx_qty_water_120_mL.Text = 0
        txtbx_subtotal_soda_in_can.Text = ""
        txtbx_subtotal_soda_8_oz.Text = ""
        txtbx_subtotal_soda_15L.Text = ""
        txtbx_subtotal_juice.Text = ""
        txtbx_subtotal_water_120mL.Text = ""
        txtbx_total_drinks.Text = ""
    End Sub

    Private Sub cmd_compute_Click(sender As Object, e As EventArgs) Handles cmd_compute.Click
        Dim pizza_size_price, total_toppings_price, total_side_price, total_drinks_price, total_orders As Integer

        pizza_size_price = pizza_size()
        total_orders += pizza_size_price

        total_toppings_price = additional_toppings()
        txtbx_total_toppings.Text = total_toppings_price
        total_orders += total_toppings_price

        total_side_price = side_orders()
        txtbx_total_side_orders.Text = total_side_price
        total_orders += total_side_price

        total_drinks_price = drinks()
        txtbx_total_drinks.Text = total_drinks_price
        total_orders += total_drinks_price

        txtbx_total_orders.Text = total_orders
    End Sub

    Private Function pizza_size() As Integer
        Dim pizza_price As Integer

        If rad_size_small.Checked Then
            pizza_price += 150
        End If
        If rad_size_medium.Checked Then
            pizza_price += 250
        End If
        If rad_size_large.Checked Then
            pizza_price += 400
        End If

        Return pizza_price
    End Function

    Private Function additional_toppings() As Integer
        Dim total_toppings As Integer
        If chckbx_cheese.Checked Then
            total_toppings += 25
        End If

        If chckbx_peperoni.Checked Then
            total_toppings += 50
        End If

        If chckbx_sausage.Checked Then
            total_toppings += 40
        End If

        If chckbx_onions.Checked Then
            total_toppings += 15
        End If

        If chckbx_olives.Checked Then
            total_toppings += 25
        End If

        Return total_toppings
    End Function

    Private Function side_orders() As Integer
        Dim total_side, bread_stick_subtotal, chicken_wings_subtotal As Integer

        bread_stick_subtotal = Int(txtbx_qty_bread_sticks.Text) * Int(lbl_price_bread_stick.Text)
        txtbx_subtotal_bread_sticks.Text = bread_stick_subtotal
        total_side += bread_stick_subtotal

        chicken_wings_subtotal = Int(txtbx_qty_chicken_wings.Text) * Int(lbl_price_chicken_wings.Text)
        txtbx_subtotal_chicken_wings.Text = chicken_wings_subtotal
        total_side += chicken_wings_subtotal

        Return total_side
    End Function

    Private Function drinks() As Integer
        Dim total_drinks, soda_in_can_subtotal, soda_8_oz_subtotal, soda_15L_subtotal, juice_subtotal, water_120mL_subtotal As Integer

        soda_in_can_subtotal = Int(txtbx_qty_soda_in_can.Text) * Int(lbl_price_soda_in_can.Text)
        txtbx_subtotal_soda_in_can.Text = soda_in_can_subtotal
        total_drinks += soda_in_can_subtotal

        soda_8_oz_subtotal = Int(txtbx_qty_soda_8_oz.Text) * Int(lbl_price_soda_8_oz.Text)
        txtbx_subtotal_soda_8_oz.Text = soda_8_oz_subtotal
        total_drinks += soda_8_oz_subtotal

        soda_15L_subtotal = Int(txtbx_qty_soda_15L.Text) * Int(lbl_price_soda_15L.Text)
        txtbx_subtotal_soda_15L.Text = soda_15L_subtotal
        total_drinks += soda_15L_subtotal

        juice_subtotal = Int(txtbx_qty_juice.Text) * Int(lbl_price_juice.Text)
        txtbx_subtotal_juice.Text = juice_subtotal
        total_drinks += juice_subtotal

        water_120mL_subtotal = Int(txtbx_qty_water_120_mL.Text) * Int(lbl_price_water_120mL.Text)
        txtbx_subtotal_water_120mL.Text = water_120mL_subtotal
        total_drinks += water_120mL_subtotal

        Return total_drinks
    End Function
End Class