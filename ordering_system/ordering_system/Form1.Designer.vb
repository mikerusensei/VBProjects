<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        cmd_button = New Button()
        cmd_exit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 29)
        Label1.TabIndex = 0
        Label1.Text = "Ordering System"
        ' 
        ' cmd_button
        ' 
        cmd_button.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmd_button.Location = New Point(12, 136)
        cmd_button.Name = "cmd_button"
        cmd_button.Size = New Size(102, 42)
        cmd_button.TabIndex = 1
        cmd_button.Text = "Order"
        cmd_button.UseVisualStyleBackColor = True
        ' 
        ' cmd_exit
        ' 
        cmd_exit.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmd_exit.Location = New Point(12, 243)
        cmd_exit.Name = "cmd_exit"
        cmd_exit.Size = New Size(102, 42)
        cmd_exit.TabIndex = 2
        cmd_exit.Text = "Exit"
        cmd_exit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 29)
        Label2.TabIndex = 3
        Label2.Text = "New order:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 29)
        Label3.TabIndex = 4
        Label3.Text = "Exit program:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.eggpie
        PictureBox1.Location = New Point(213, 97)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(210, 143)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.spaghetti
        PictureBox2.Location = New Point(289, 261)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(210, 143)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 511)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cmd_exit)
        Controls.Add(cmd_button)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Home Page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_button As Button
    Friend WithEvents cmd_exit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
