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
        Label2 = New Label()
        cmd_novince = New Button()
        cmd_intermidiate = New Button()
        cmd_expert = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(188, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "BMI Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 15)
        Label2.TabIndex = 1
        Label2.Text = "Select Type of User:"
        ' 
        ' cmd_novince
        ' 
        cmd_novince.Location = New Point(26, 105)
        cmd_novince.Name = "cmd_novince"
        cmd_novince.Size = New Size(75, 23)
        cmd_novince.TabIndex = 2
        cmd_novince.Text = "Novince"
        cmd_novince.UseVisualStyleBackColor = True
        ' 
        ' cmd_intermidiate
        ' 
        cmd_intermidiate.Location = New Point(26, 175)
        cmd_intermidiate.Name = "cmd_intermidiate"
        cmd_intermidiate.Size = New Size(91, 23)
        cmd_intermidiate.TabIndex = 3
        cmd_intermidiate.Text = "Intermidiate"
        cmd_intermidiate.UseVisualStyleBackColor = True
        ' 
        ' cmd_expert
        ' 
        cmd_expert.Location = New Point(26, 244)
        cmd_expert.Name = "cmd_expert"
        cmd_expert.Size = New Size(75, 23)
        cmd_expert.TabIndex = 4
        cmd_expert.Text = "Expert"
        cmd_expert.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(188, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 15)
        Label3.TabIndex = 5
        Label3.Text = "The program will guide you"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(188, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 6
        Label4.Text = "Less Prompt"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(188, 248)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 15)
        Label5.TabIndex = 7
        Label5.Text = "No prompt"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cmd_expert)
        Controls.Add(cmd_intermidiate)
        Controls.Add(cmd_novince)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Home Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_novince As Button
    Friend WithEvents cmd_intermidiate As Button
    Friend WithEvents cmd_expert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
