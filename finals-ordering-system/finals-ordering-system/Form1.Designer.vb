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
        cmd_order = New Button()
        cms_about = New Button()
        cmd_exit = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmd_order
        ' 
        cmd_order.Location = New Point(62, 55)
        cmd_order.Name = "cmd_order"
        cmd_order.Size = New Size(75, 23)
        cmd_order.TabIndex = 0
        cmd_order.Text = "pizza 101"
        cmd_order.UseVisualStyleBackColor = True
        ' 
        ' cms_about
        ' 
        cms_about.Location = New Point(318, 55)
        cms_about.Name = "cms_about"
        cms_about.Size = New Size(75, 23)
        cms_about.TabIndex = 1
        cms_about.Text = "about me"
        cms_about.UseVisualStyleBackColor = True
        ' 
        ' cmd_exit
        ' 
        cmd_exit.Location = New Point(588, 55)
        cmd_exit.Name = "cmd_exit"
        cmd_exit.Size = New Size(75, 23)
        cmd_exit.TabIndex = 2
        cmd_exit.Text = "exit"
        cmd_exit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.pizza
        PictureBox1.Location = New Point(217, 124)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(286, 183)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(199, 337)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 86)
        Label1.TabIndex = 4
        Label1.Text = "PIZZA 101"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(cmd_exit)
        Controls.Add(cms_about)
        Controls.Add(cmd_order)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Home"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_order As Button
    Friend WithEvents cms_about As Button
    Friend WithEvents cmd_exit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
