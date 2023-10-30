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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        cmd_return = New Button()
        prod_listbox = New ListBox()
        qty_listbox = New ListBox()
        price_listbox = New ListBox()
        total_listbox = New ListBox()
        cmd_clear = New Button()
        cmd_post = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        grand_total = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 29)
        Label1.TabIndex = 1
        Label1.Text = "Ordering System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 21)
        Label2.TabIndex = 2
        Label2.Text = "Menu:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 21)
        Label3.TabIndex = 3
        Label3.Text = "Quantity:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Chicken", "Spaghetti", "Juice", "Egg Pie"})
        ComboBox1.Location = New Point(148, 70)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(186, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(148, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 23)
        TextBox1.TabIndex = 5
        TextBox1.Text = "1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(431, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(210, 143)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' cmd_return
        ' 
        cmd_return.Location = New Point(12, 415)
        cmd_return.Name = "cmd_return"
        cmd_return.Size = New Size(75, 23)
        cmd_return.TabIndex = 7
        cmd_return.Text = "Return"
        cmd_return.UseVisualStyleBackColor = True
        ' 
        ' prod_listbox
        ' 
        prod_listbox.FormattingEnabled = True
        prod_listbox.ItemHeight = 15
        prod_listbox.Location = New Point(38, 210)
        prod_listbox.Name = "prod_listbox"
        prod_listbox.Size = New Size(120, 184)
        prod_listbox.TabIndex = 8
        ' 
        ' qty_listbox
        ' 
        qty_listbox.FormattingEnabled = True
        qty_listbox.ItemHeight = 15
        qty_listbox.Location = New Point(189, 210)
        qty_listbox.Name = "qty_listbox"
        qty_listbox.Size = New Size(120, 184)
        qty_listbox.TabIndex = 9
        ' 
        ' price_listbox
        ' 
        price_listbox.FormattingEnabled = True
        price_listbox.ItemHeight = 15
        price_listbox.Location = New Point(338, 210)
        price_listbox.Name = "price_listbox"
        price_listbox.Size = New Size(120, 184)
        price_listbox.TabIndex = 10
        ' 
        ' total_listbox
        ' 
        total_listbox.FormattingEnabled = True
        total_listbox.ItemHeight = 15
        total_listbox.Location = New Point(490, 210)
        total_listbox.Name = "total_listbox"
        total_listbox.Size = New Size(120, 184)
        total_listbox.TabIndex = 11
        ' 
        ' cmd_clear
        ' 
        cmd_clear.Location = New Point(340, 70)
        cmd_clear.Name = "cmd_clear"
        cmd_clear.Size = New Size(75, 23)
        cmd_clear.TabIndex = 12
        cmd_clear.Text = "Clear"
        cmd_clear.UseVisualStyleBackColor = True
        ' 
        ' cmd_post
        ' 
        cmd_post.Location = New Point(340, 120)
        cmd_post.Name = "cmd_post"
        cmd_post.Size = New Size(75, 23)
        cmd_post.TabIndex = 13
        cmd_post.Text = "Post"
        cmd_post.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(61, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 21)
        Label4.TabIndex = 14
        Label4.Text = "Product"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(212, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 21)
        Label5.TabIndex = 15
        Label5.Text = "Quantity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(377, 176)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 21)
        Label6.TabIndex = 16
        Label6.Text = "Price"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(532, 176)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 21)
        Label7.TabIndex = 17
        Label7.Text = "Total"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(337, 411)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 25)
        Label8.TabIndex = 18
        Label8.Text = "Grand Total:"
        ' 
        ' grand_total
        ' 
        grand_total.AutoSize = True
        grand_total.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        grand_total.Location = New Point(490, 415)
        grand_total.Name = "grand_total"
        grand_total.Size = New Size(19, 21)
        grand_total.TabIndex = 19
        grand_total.Text = "0"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(653, 450)
        Controls.Add(grand_total)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmd_post)
        Controls.Add(cmd_clear)
        Controls.Add(total_listbox)
        Controls.Add(price_listbox)
        Controls.Add(qty_listbox)
        Controls.Add(prod_listbox)
        Controls.Add(cmd_return)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "New Order"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmd_return As Button
    Friend WithEvents prod_listbox As ListBox
    Friend WithEvents qty_listbox As ListBox
    Friend WithEvents price_listbox As ListBox
    Friend WithEvents total_listbox As ListBox
    Friend WithEvents cmd_clear As Button
    Friend WithEvents cmd_post As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grand_total As Label
End Class
