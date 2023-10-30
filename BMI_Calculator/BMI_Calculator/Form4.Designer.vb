<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        weight_input = New TextBox()
        height_input = New TextBox()
        weight_measure = New ComboBox()
        height_measure = New ComboBox()
        cmd_calculate = New Button()
        cmd_clear = New Button()
        cmd_return = New Button()
        Label4 = New Label()
        Label5 = New Label()
        bmi_result = New Label()
        bmi_class = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(189, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "BMI Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter Weight:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 2
        Label3.Text = "Enter Height:"
        ' 
        ' weight_input
        ' 
        weight_input.Location = New Point(183, 147)
        weight_input.Name = "weight_input"
        weight_input.Size = New Size(100, 23)
        weight_input.TabIndex = 3
        ' 
        ' height_input
        ' 
        height_input.Location = New Point(183, 201)
        height_input.Name = "height_input"
        height_input.Size = New Size(100, 23)
        height_input.TabIndex = 4
        ' 
        ' weight_measure
        ' 
        weight_measure.FormattingEnabled = True
        weight_measure.Items.AddRange(New Object() {"lbs", "kg"})
        weight_measure.Location = New Point(317, 147)
        weight_measure.Name = "weight_measure"
        weight_measure.Size = New Size(72, 23)
        weight_measure.TabIndex = 5
        ' 
        ' height_measure
        ' 
        height_measure.FormattingEnabled = True
        height_measure.Items.AddRange(New Object() {"inch", "cm", "m"})
        height_measure.Location = New Point(317, 201)
        height_measure.Name = "height_measure"
        height_measure.Size = New Size(72, 23)
        height_measure.TabIndex = 6
        ' 
        ' cmd_calculate
        ' 
        cmd_calculate.Location = New Point(127, 269)
        cmd_calculate.Name = "cmd_calculate"
        cmd_calculate.Size = New Size(75, 23)
        cmd_calculate.TabIndex = 7
        cmd_calculate.Text = "Calculate"
        cmd_calculate.UseVisualStyleBackColor = True
        ' 
        ' cmd_clear
        ' 
        cmd_clear.Location = New Point(208, 269)
        cmd_clear.Name = "cmd_clear"
        cmd_clear.Size = New Size(75, 23)
        cmd_clear.TabIndex = 8
        cmd_clear.Text = "Clear"
        cmd_clear.UseVisualStyleBackColor = True
        ' 
        ' cmd_return
        ' 
        cmd_return.Location = New Point(127, 325)
        cmd_return.Name = "cmd_return"
        cmd_return.Size = New Size(156, 23)
        cmd_return.TabIndex = 9
        cmd_return.Text = "Return to Home Page"
        cmd_return.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 10
        Label4.Text = "BMI"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(56, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 11
        Label5.Text = "Classification"
        ' 
        ' bmi_result
        ' 
        bmi_result.AutoSize = True
        bmi_result.Location = New Point(183, 60)
        bmi_result.Name = "bmi_result"
        bmi_result.Size = New Size(17, 15)
        bmi_result.TabIndex = 12
        bmi_result.Text = """"""
        ' 
        ' bmi_class
        ' 
        bmi_class.AutoSize = True
        bmi_class.Location = New Point(183, 99)
        bmi_class.Name = "bmi_class"
        bmi_class.Size = New Size(17, 15)
        bmi_class.TabIndex = 13
        bmi_class.Text = """"""
        ' 
        ' Form4
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
        Name = "Form4"
        Text = "Expert Window"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents weight_input As TextBox
    Friend WithEvents height_input As TextBox
    Friend WithEvents weight_measure As ComboBox
    Friend WithEvents height_measure As ComboBox
    Friend WithEvents cmd_calculate As Button
    Friend WithEvents cmd_clear As Button
    Friend WithEvents cmd_return As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bmi_result As Label
    Friend WithEvents bmi_class As Label
End Class
