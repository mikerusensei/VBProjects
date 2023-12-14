<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmd_home = New Button()
        Label1 = New Label()
        rad_size_small = New RadioButton()
        rad_size_medium = New RadioButton()
        rad_size_large = New RadioButton()
        Label2 = New Label()
        chckbx_cheese = New CheckBox()
        chckbx_peperoni = New CheckBox()
        chckbx_sausage = New CheckBox()
        chckbx_onions = New CheckBox()
        chckbx_olives = New CheckBox()
        Label3 = New Label()
        txtbx_total_toppings = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtbx_qty_bread_sticks = New TextBox()
        txtbx_qty_chicken_wings = New TextBox()
        Label8 = New Label()
        lbl_price_bread_stick = New Label()
        lbl_price_chicken_wings = New Label()
        Label11 = New Label()
        txtbx_subtotal_bread_sticks = New TextBox()
        txtbx_subtotal_chicken_wings = New TextBox()
        Label12 = New Label()
        txtbx_total_side_orders = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        txtbx_qty_soda_in_can = New TextBox()
        txtbx_qty_soda_8_oz = New TextBox()
        txtbx_qty_soda_15L = New TextBox()
        txtbx_qty_juice = New TextBox()
        txtbx_qty_water_120_mL = New TextBox()
        lbl_price_soda_in_can = New Label()
        lbl_price_soda_8_oz = New Label()
        lbl_price_soda_15L = New Label()
        lbl_price_juice = New Label()
        lbl_price_water_120mL = New Label()
        txtbx_subtotal_soda_in_can = New TextBox()
        txtbx_subtotal_soda_8_oz = New TextBox()
        txtbx_subtotal_soda_15L = New TextBox()
        txtbx_subtotal_juice = New TextBox()
        txtbx_subtotal_water_120mL = New TextBox()
        Label26 = New Label()
        txtbx_total_drinks = New TextBox()
        Label27 = New Label()
        txtbx_total_orders = New TextBox()
        cmd_compute = New Button()
        cmd_clear = New Button()
        SuspendLayout()
        ' 
        ' cmd_home
        ' 
        cmd_home.Location = New Point(713, 415)
        cmd_home.Name = "cmd_home"
        cmd_home.Size = New Size(75, 23)
        cmd_home.TabIndex = 0
        cmd_home.Text = "Home"
        cmd_home.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 1
        Label1.Text = "Pizza Size"
        ' 
        ' rad_size_small
        ' 
        rad_size_small.AutoSize = True
        rad_size_small.Location = New Point(38, 27)
        rad_size_small.Name = "rad_size_small"
        rad_size_small.Size = New Size(98, 19)
        rad_size_small.TabIndex = 2
        rad_size_small.TabStop = True
        rad_size_small.Text = "Small (150.00)"
        rad_size_small.UseVisualStyleBackColor = True
        ' 
        ' rad_size_medium
        ' 
        rad_size_medium.AutoSize = True
        rad_size_medium.Location = New Point(38, 52)
        rad_size_medium.Name = "rad_size_medium"
        rad_size_medium.Size = New Size(107, 19)
        rad_size_medium.TabIndex = 3
        rad_size_medium.TabStop = True
        rad_size_medium.Text = "Medim (250.00)"
        rad_size_medium.UseVisualStyleBackColor = True
        ' 
        ' rad_size_large
        ' 
        rad_size_large.AutoSize = True
        rad_size_large.Location = New Point(38, 77)
        rad_size_large.Name = "rad_size_large"
        rad_size_large.Size = New Size(98, 19)
        rad_size_large.TabIndex = 4
        rad_size_large.TabStop = True
        rad_size_large.Text = "Large (400.00)"
        rad_size_large.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 15)
        Label2.TabIndex = 5
        Label2.Text = "Additional Toppings"
        ' 
        ' chckbx_cheese
        ' 
        chckbx_cheese.AutoSize = True
        chckbx_cheese.Location = New Point(38, 149)
        chckbx_cheese.Name = "chckbx_cheese"
        chckbx_cheese.Size = New Size(102, 19)
        chckbx_cheese.TabIndex = 6
        chckbx_cheese.Text = "Cheese (25.00)"
        chckbx_cheese.UseVisualStyleBackColor = True
        ' 
        ' chckbx_peperoni
        ' 
        chckbx_peperoni.AutoSize = True
        chckbx_peperoni.Location = New Point(38, 174)
        chckbx_peperoni.Name = "chckbx_peperoni"
        chckbx_peperoni.Size = New Size(111, 19)
        chckbx_peperoni.TabIndex = 7
        chckbx_peperoni.Text = "Peperoni (50.00)"
        chckbx_peperoni.UseVisualStyleBackColor = True
        ' 
        ' chckbx_sausage
        ' 
        chckbx_sausage.AutoSize = True
        chckbx_sausage.Location = New Point(38, 199)
        chckbx_sausage.Name = "chckbx_sausage"
        chckbx_sausage.Size = New Size(107, 19)
        chckbx_sausage.TabIndex = 8
        chckbx_sausage.Text = "Sausage (40.00)"
        chckbx_sausage.UseVisualStyleBackColor = True
        ' 
        ' chckbx_onions
        ' 
        chckbx_onions.AutoSize = True
        chckbx_onions.Location = New Point(38, 224)
        chckbx_onions.Name = "chckbx_onions"
        chckbx_onions.Size = New Size(102, 19)
        chckbx_onions.TabIndex = 9
        chckbx_onions.Text = "Onions (15.00)"
        chckbx_onions.UseVisualStyleBackColor = True
        ' 
        ' chckbx_olives
        ' 
        chckbx_olives.AutoSize = True
        chckbx_olives.Location = New Point(38, 249)
        chckbx_olives.Name = "chckbx_olives"
        chckbx_olives.Size = New Size(96, 19)
        chckbx_olives.TabIndex = 10
        chckbx_olives.Text = "Olives (25.00)"
        chckbx_olives.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 15)
        Label3.TabIndex = 11
        Label3.Text = "Total Toppings:"
        ' 
        ' txtbx_total_toppings
        ' 
        txtbx_total_toppings.Location = New Point(104, 290)
        txtbx_total_toppings.Name = "txtbx_total_toppings"
        txtbx_total_toppings.Size = New Size(100, 23)
        txtbx_total_toppings.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(346, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 13
        Label4.Text = "Side Orders"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(370, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 14
        Label5.Text = "Bread Sticks"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(370, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 15
        Label6.Text = "Chicken Wings"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(505, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(26, 15)
        Label7.TabIndex = 16
        Label7.Text = "Qty"
        ' 
        ' txtbx_qty_bread_sticks
        ' 
        txtbx_qty_bread_sticks.Location = New Point(485, 51)
        txtbx_qty_bread_sticks.Name = "txtbx_qty_bread_sticks"
        txtbx_qty_bread_sticks.Size = New Size(70, 23)
        txtbx_qty_bread_sticks.TabIndex = 17
        ' 
        ' txtbx_qty_chicken_wings
        ' 
        txtbx_qty_chicken_wings.Location = New Point(485, 77)
        txtbx_qty_chicken_wings.Name = "txtbx_qty_chicken_wings"
        txtbx_qty_chicken_wings.Size = New Size(70, 23)
        txtbx_qty_chicken_wings.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(599, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 19
        Label8.Text = "Unit Price"
        ' 
        ' lbl_price_bread_stick
        ' 
        lbl_price_bread_stick.AutoSize = True
        lbl_price_bread_stick.Location = New Point(611, 54)
        lbl_price_bread_stick.Name = "lbl_price_bread_stick"
        lbl_price_bread_stick.Size = New Size(34, 15)
        lbl_price_bread_stick.TabIndex = 20
        lbl_price_bread_stick.Text = "30.00"
        ' 
        ' lbl_price_chicken_wings
        ' 
        lbl_price_chicken_wings.AutoSize = True
        lbl_price_chicken_wings.Location = New Point(611, 81)
        lbl_price_chicken_wings.Name = "lbl_price_chicken_wings"
        lbl_price_chicken_wings.Size = New Size(34, 15)
        lbl_price_chicken_wings.TabIndex = 21
        lbl_price_chicken_wings.Text = "90.00"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(713, 27)
        Label11.Name = "Label11"
        Label11.Size = New Size(55, 15)
        Label11.TabIndex = 22
        Label11.Text = "Sub Total"
        ' 
        ' txtbx_subtotal_bread_sticks
        ' 
        txtbx_subtotal_bread_sticks.Location = New Point(707, 49)
        txtbx_subtotal_bread_sticks.Name = "txtbx_subtotal_bread_sticks"
        txtbx_subtotal_bread_sticks.Size = New Size(70, 23)
        txtbx_subtotal_bread_sticks.TabIndex = 23
        ' 
        ' txtbx_subtotal_chicken_wings
        ' 
        txtbx_subtotal_chicken_wings.Location = New Point(707, 77)
        txtbx_subtotal_chicken_wings.Name = "txtbx_subtotal_chicken_wings"
        txtbx_subtotal_chicken_wings.Size = New Size(70, 23)
        txtbx_subtotal_chicken_wings.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(573, 119)
        Label12.Name = "Label12"
        Label12.Size = New Size(98, 15)
        Label12.TabIndex = 25
        Label12.Text = "Total Side Orders:"
        ' 
        ' txtbx_total_side_orders
        ' 
        txtbx_total_side_orders.Location = New Point(677, 114)
        txtbx_total_side_orders.Name = "txtbx_total_side_orders"
        txtbx_total_side_orders.Size = New Size(100, 23)
        txtbx_total_side_orders.TabIndex = 26
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(346, 149)
        Label13.Name = "Label13"
        Label13.Size = New Size(40, 15)
        Label13.TabIndex = 27
        Label13.Text = "Drinks"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(713, 174)
        Label14.Name = "Label14"
        Label14.Size = New Size(55, 15)
        Label14.TabIndex = 30
        Label14.Text = "Sub Total"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(599, 174)
        Label15.Name = "Label15"
        Label15.Size = New Size(58, 15)
        Label15.TabIndex = 29
        Label15.Text = "Unit Price"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(505, 174)
        Label16.Name = "Label16"
        Label16.Size = New Size(26, 15)
        Label16.TabIndex = 28
        Label16.Text = "Qty"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(370, 199)
        Label17.Name = "Label17"
        Label17.Size = New Size(70, 15)
        Label17.TabIndex = 31
        Label17.Text = "Soda in Can"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(370, 224)
        Label18.Name = "Label18"
        Label18.Size = New Size(60, 15)
        Label18.TabIndex = 32
        Label18.Text = "Soda 8 oz."
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(370, 249)
        Label19.Name = "Label19"
        Label19.Size = New Size(60, 15)
        Label19.TabIndex = 33
        Label19.Text = "Soda 1.5 L"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(370, 274)
        Label20.Name = "Label20"
        Label20.Size = New Size(33, 15)
        Label20.TabIndex = 34
        Label20.Text = "Juice"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(370, 298)
        Label21.Name = "Label21"
        Label21.Size = New Size(79, 15)
        Label21.TabIndex = 35
        Label21.Text = "Water 120 mL"
        ' 
        ' txtbx_qty_soda_in_can
        ' 
        txtbx_qty_soda_in_can.Location = New Point(485, 196)
        txtbx_qty_soda_in_can.Name = "txtbx_qty_soda_in_can"
        txtbx_qty_soda_in_can.Size = New Size(70, 23)
        txtbx_qty_soda_in_can.TabIndex = 36
        ' 
        ' txtbx_qty_soda_8_oz
        ' 
        txtbx_qty_soda_8_oz.Location = New Point(485, 222)
        txtbx_qty_soda_8_oz.Name = "txtbx_qty_soda_8_oz"
        txtbx_qty_soda_8_oz.Size = New Size(70, 23)
        txtbx_qty_soda_8_oz.TabIndex = 37
        ' 
        ' txtbx_qty_soda_15L
        ' 
        txtbx_qty_soda_15L.Location = New Point(485, 247)
        txtbx_qty_soda_15L.Name = "txtbx_qty_soda_15L"
        txtbx_qty_soda_15L.Size = New Size(70, 23)
        txtbx_qty_soda_15L.TabIndex = 38
        ' 
        ' txtbx_qty_juice
        ' 
        txtbx_qty_juice.Location = New Point(485, 271)
        txtbx_qty_juice.Name = "txtbx_qty_juice"
        txtbx_qty_juice.Size = New Size(70, 23)
        txtbx_qty_juice.TabIndex = 39
        ' 
        ' txtbx_qty_water_120_mL
        ' 
        txtbx_qty_water_120_mL.Location = New Point(485, 295)
        txtbx_qty_water_120_mL.Name = "txtbx_qty_water_120_mL"
        txtbx_qty_water_120_mL.Size = New Size(70, 23)
        txtbx_qty_water_120_mL.TabIndex = 40
        ' 
        ' lbl_price_soda_in_can
        ' 
        lbl_price_soda_in_can.AutoSize = True
        lbl_price_soda_in_can.Location = New Point(611, 199)
        lbl_price_soda_in_can.Name = "lbl_price_soda_in_can"
        lbl_price_soda_in_can.Size = New Size(34, 15)
        lbl_price_soda_in_can.TabIndex = 41
        lbl_price_soda_in_can.Text = "30.00"
        ' 
        ' lbl_price_soda_8_oz
        ' 
        lbl_price_soda_8_oz.AutoSize = True
        lbl_price_soda_8_oz.Location = New Point(611, 224)
        lbl_price_soda_8_oz.Name = "lbl_price_soda_8_oz"
        lbl_price_soda_8_oz.Size = New Size(34, 15)
        lbl_price_soda_8_oz.TabIndex = 42
        lbl_price_soda_8_oz.Text = "15.00"
        ' 
        ' lbl_price_soda_15L
        ' 
        lbl_price_soda_15L.AutoSize = True
        lbl_price_soda_15L.Location = New Point(611, 250)
        lbl_price_soda_15L.Name = "lbl_price_soda_15L"
        lbl_price_soda_15L.Size = New Size(34, 15)
        lbl_price_soda_15L.TabIndex = 43
        lbl_price_soda_15L.Text = "60.00"
        ' 
        ' lbl_price_juice
        ' 
        lbl_price_juice.AutoSize = True
        lbl_price_juice.Location = New Point(611, 274)
        lbl_price_juice.Name = "lbl_price_juice"
        lbl_price_juice.Size = New Size(34, 15)
        lbl_price_juice.TabIndex = 44
        lbl_price_juice.Text = "30.00"
        ' 
        ' lbl_price_water_120mL
        ' 
        lbl_price_water_120mL.AutoSize = True
        lbl_price_water_120mL.Location = New Point(611, 298)
        lbl_price_water_120mL.Name = "lbl_price_water_120mL"
        lbl_price_water_120mL.Size = New Size(34, 15)
        lbl_price_water_120mL.TabIndex = 45
        lbl_price_water_120mL.Text = "20.00"
        ' 
        ' txtbx_subtotal_soda_in_can
        ' 
        txtbx_subtotal_soda_in_can.Location = New Point(707, 197)
        txtbx_subtotal_soda_in_can.Name = "txtbx_subtotal_soda_in_can"
        txtbx_subtotal_soda_in_can.Size = New Size(70, 23)
        txtbx_subtotal_soda_in_can.TabIndex = 46
        ' 
        ' txtbx_subtotal_soda_8_oz
        ' 
        txtbx_subtotal_soda_8_oz.Location = New Point(707, 222)
        txtbx_subtotal_soda_8_oz.Name = "txtbx_subtotal_soda_8_oz"
        txtbx_subtotal_soda_8_oz.Size = New Size(70, 23)
        txtbx_subtotal_soda_8_oz.TabIndex = 47
        ' 
        ' txtbx_subtotal_soda_15L
        ' 
        txtbx_subtotal_soda_15L.Location = New Point(707, 247)
        txtbx_subtotal_soda_15L.Name = "txtbx_subtotal_soda_15L"
        txtbx_subtotal_soda_15L.Size = New Size(70, 23)
        txtbx_subtotal_soda_15L.TabIndex = 48
        ' 
        ' txtbx_subtotal_juice
        ' 
        txtbx_subtotal_juice.Location = New Point(707, 271)
        txtbx_subtotal_juice.Name = "txtbx_subtotal_juice"
        txtbx_subtotal_juice.Size = New Size(70, 23)
        txtbx_subtotal_juice.TabIndex = 49
        ' 
        ' txtbx_subtotal_water_120mL
        ' 
        txtbx_subtotal_water_120mL.Location = New Point(707, 295)
        txtbx_subtotal_water_120mL.Name = "txtbx_subtotal_water_120mL"
        txtbx_subtotal_water_120mL.Size = New Size(70, 23)
        txtbx_subtotal_water_120mL.TabIndex = 50
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(573, 344)
        Label26.Name = "Label26"
        Label26.Size = New Size(71, 15)
        Label26.TabIndex = 51
        Label26.Text = "Total Drinks:"
        ' 
        ' txtbx_total_drinks
        ' 
        txtbx_total_drinks.Location = New Point(677, 341)
        txtbx_total_drinks.Name = "txtbx_total_drinks"
        txtbx_total_drinks.Size = New Size(100, 23)
        txtbx_total_drinks.TabIndex = 52
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(573, 381)
        Label27.Name = "Label27"
        Label27.Size = New Size(68, 15)
        Label27.TabIndex = 53
        Label27.Text = "Total Order:"
        ' 
        ' txtbx_total_orders
        ' 
        txtbx_total_orders.Location = New Point(677, 378)
        txtbx_total_orders.Name = "txtbx_total_orders"
        txtbx_total_orders.Size = New Size(100, 23)
        txtbx_total_orders.TabIndex = 54
        ' 
        ' cmd_compute
        ' 
        cmd_compute.Location = New Point(218, 373)
        cmd_compute.Name = "cmd_compute"
        cmd_compute.Size = New Size(75, 23)
        cmd_compute.TabIndex = 55
        cmd_compute.Text = "Compute"
        cmd_compute.UseVisualStyleBackColor = True
        ' 
        ' cmd_clear
        ' 
        cmd_clear.Location = New Point(328, 373)
        cmd_clear.Name = "cmd_clear"
        cmd_clear.Size = New Size(75, 23)
        cmd_clear.TabIndex = 56
        cmd_clear.Text = "Clear"
        cmd_clear.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmd_clear)
        Controls.Add(cmd_compute)
        Controls.Add(txtbx_total_orders)
        Controls.Add(Label27)
        Controls.Add(txtbx_total_drinks)
        Controls.Add(Label26)
        Controls.Add(txtbx_subtotal_water_120mL)
        Controls.Add(txtbx_subtotal_juice)
        Controls.Add(txtbx_subtotal_soda_15L)
        Controls.Add(txtbx_subtotal_soda_8_oz)
        Controls.Add(txtbx_subtotal_soda_in_can)
        Controls.Add(lbl_price_water_120mL)
        Controls.Add(lbl_price_juice)
        Controls.Add(lbl_price_soda_15L)
        Controls.Add(lbl_price_soda_8_oz)
        Controls.Add(lbl_price_soda_in_can)
        Controls.Add(txtbx_qty_water_120_mL)
        Controls.Add(txtbx_qty_juice)
        Controls.Add(txtbx_qty_soda_15L)
        Controls.Add(txtbx_qty_soda_8_oz)
        Controls.Add(txtbx_qty_soda_in_can)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(Label13)
        Controls.Add(txtbx_total_side_orders)
        Controls.Add(Label12)
        Controls.Add(txtbx_subtotal_chicken_wings)
        Controls.Add(txtbx_subtotal_bread_sticks)
        Controls.Add(Label11)
        Controls.Add(lbl_price_chicken_wings)
        Controls.Add(lbl_price_bread_stick)
        Controls.Add(Label8)
        Controls.Add(txtbx_qty_chicken_wings)
        Controls.Add(txtbx_qty_bread_sticks)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtbx_total_toppings)
        Controls.Add(Label3)
        Controls.Add(chckbx_olives)
        Controls.Add(chckbx_onions)
        Controls.Add(chckbx_sausage)
        Controls.Add(chckbx_peperoni)
        Controls.Add(chckbx_cheese)
        Controls.Add(Label2)
        Controls.Add(rad_size_large)
        Controls.Add(rad_size_medium)
        Controls.Add(rad_size_small)
        Controls.Add(Label1)
        Controls.Add(cmd_home)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form2"
        Text = "Order"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_home As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rad_size_small As RadioButton
    Friend WithEvents rad_size_medium As RadioButton
    Friend WithEvents rad_size_large As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents chckbx_cheese As CheckBox
    Friend WithEvents chckbx_peperoni As CheckBox
    Friend WithEvents chckbx_sausage As CheckBox
    Friend WithEvents chckbx_onions As CheckBox
    Friend WithEvents chckbx_olives As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbx_total_toppings As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbx_qty_bread_sticks As TextBox
    Friend WithEvents txtbx_qty_chicken_wings As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_price_bread_stick As Label
    Friend WithEvents lbl_price_chicken_wings As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtbx_subtotal_bread_sticks As TextBox
    Friend WithEvents txtbx_subtotal_chicken_wings As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbx_total_side_orders As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtbx_qty_soda_in_can As TextBox
    Friend WithEvents txtbx_qty_soda_8_oz As TextBox
    Friend WithEvents txtbx_qty_soda_15L As TextBox
    Friend WithEvents txtbx_qty_juice As TextBox
    Friend WithEvents txtbx_qty_water_120_mL As TextBox
    Friend WithEvents lbl_price_soda_in_can As Label
    Friend WithEvents lbl_price_soda_8_oz As Label
    Friend WithEvents lbl_price_soda_15L As Label
    Friend WithEvents lbl_price_juice As Label
    Friend WithEvents lbl_price_water_120mL As Label
    Friend WithEvents txtbx_subtotal_soda_in_can As TextBox
    Friend WithEvents txtbx_subtotal_soda_8_oz As TextBox
    Friend WithEvents txtbx_subtotal_soda_15L As TextBox
    Friend WithEvents txtbx_subtotal_juice As TextBox
    Friend WithEvents txtbx_subtotal_water_120mL As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtbx_total_drinks As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtbx_total_orders As TextBox
    Friend WithEvents cmd_compute As Button
    Friend WithEvents cmd_clear As Button
End Class
