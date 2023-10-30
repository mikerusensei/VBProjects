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
        bmi_class = New Label()
        bmi_result = New Label()
        Label5 = New Label()
        Label4 = New Label()
        cmd_return = New Button()
        cmd_clear = New Button()
        cmd_calculate = New Button()
        height_measure = New ComboBox()
        weight_measure = New ComboBox()
        height_input = New TextBox()
        weight_input = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' bmi_class
        ' 
        bmi_class.AutoSize = True
        bmi_class.Location = New Point(186, 97)
        bmi_class.Name = "bmi_class"
        bmi_class.Size = New Size(17, 15)
        bmi_class.TabIndex = 27
        bmi_class.Text = """"""
        ' 
        ' bmi_result
        ' 
        bmi_result.AutoSize = True
        bmi_result.Location = New Point(186, 58)
        bmi_result.Name = "bmi_result"
        bmi_result.Size = New Size(17, 15)
        bmi_result.TabIndex = 26
        bmi_result.Text = """"""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 25
        Label5.Text = "Classification"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 24
        Label4.Text = "BMI"
        ' 
        ' cmd_return
        ' 
        cmd_return.Location = New Point(130, 323)
        cmd_return.Name = "cmd_return"
        cmd_return.Size = New Size(156, 23)
        cmd_return.TabIndex = 23
        cmd_return.Text = "Return to Home Page"
        cmd_return.UseVisualStyleBackColor = True
        ' 
        ' cmd_clear
        ' 
        cmd_clear.Location = New Point(211, 267)
        cmd_clear.Name = "cmd_clear"
        cmd_clear.Size = New Size(75, 23)
        cmd_clear.TabIndex = 22
        cmd_clear.Text = "Clear"
        cmd_clear.UseVisualStyleBackColor = True
        ' 
        ' cmd_calculate
        ' 
        cmd_calculate.Location = New Point(130, 267)
        cmd_calculate.Name = "cmd_calculate"
        cmd_calculate.Size = New Size(75, 23)
        cmd_calculate.TabIndex = 21
        cmd_calculate.Text = "Calculate"
        cmd_calculate.UseVisualStyleBackColor = True
        ' 
        ' height_measure
        ' 
        height_measure.FormattingEnabled = True
        height_measure.Items.AddRange(New Object() {"inch", "cm", "m"})
        height_measure.Location = New Point(320, 199)
        height_measure.Name = "height_measure"
        height_measure.Size = New Size(72, 23)
        height_measure.TabIndex = 20
        ' 
        ' weight_measure
        ' 
        weight_measure.FormattingEnabled = True
        weight_measure.Items.AddRange(New Object() {"lbs", "kg"})
        weight_measure.Location = New Point(320, 145)
        weight_measure.Name = "weight_measure"
        weight_measure.Size = New Size(72, 23)
        weight_measure.TabIndex = 19
        ' 
        ' height_input
        ' 
        height_input.Location = New Point(186, 199)
        height_input.Name = "height_input"
        height_input.Size = New Size(100, 23)
        height_input.TabIndex = 18
        ' 
        ' weight_input
        ' 
        weight_input.Location = New Point(186, 145)
        weight_input.Name = "weight_input"
        weight_input.Size = New Size(100, 23)
        weight_input.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 16
        Label3.Text = "Enter Height:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 15
        Label2.Text = "Enter Weight:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 14
        Label1.Text = "BMI Calculator"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 450)
        Controls.Add(bmi_class)
        Controls.Add(bmi_result)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmd_return)
        Controls.Add(cmd_clear)
        Controls.Add(cmd_calculate)
        Controls.Add(height_measure)
        Controls.Add(weight_measure)
        Controls.Add(height_input)
        Controls.Add(weight_input)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bmi_class As Label
    Friend WithEvents bmi_result As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmd_return As Button
    Friend WithEvents cmd_clear As Button
    Friend WithEvents cmd_calculate As Button
    Friend WithEvents height_measure As ComboBox
    Friend WithEvents weight_measure As ComboBox
    Friend WithEvents height_input As TextBox
    Friend WithEvents weight_input As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
