Public Class Form2
    Dim weight_var, height_var, bmi, final_weight, final_height As Double
    Private Function ValidInput() As Boolean
        Return IsNumeric(weight_input.Text) And IsNumeric(height_input.Text)
    End Function

    Private Sub Classification(Bmi)
        If Bmi <= 18.5 Then
            bmi_class.Text = "You are 'Underweight'"
        ElseIf Bmi < 24.9 Then
            bmi_class.Text = "You are 'Normal Weight"
        ElseIf Bmi <= 29.9 Then
            bmi_class.Text = "You are 'Overweight"
        ElseIf Bmi <= 34.9 Then
            bmi_class.Text = "You are 'Class 1 Obese"
        ElseIf Bmi <= 39.9 Then
            bmi_class.Text = "You are 'Class 2 Obese"
        Else
            bmi_class.Text = "You are 'Class 3 Obese"
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        weight_measure.SelectedIndex = 0
        height_measure.SelectedIndex = 0
        MsgBox("Please input your height and weight", vbOKOnly + vbInformation, "Guide")
    End Sub
    Private Sub Calculate()
        If weight_measure.Text = "kg" And height_measure.Text = "m" Then
            weight_var = weight_input.Text
            height_var = height_input.Text
            bmi = weight_var / (height_var * height_var)
            bmi_result.Text = Format(bmi, "0.00")
            Classification(bmi)
        Else
            MsgBox("You need to use kg and m as measurement", vbOKOnly + vbInformation, "Weight Measure")
        End If
    End Sub
    Private Sub cmd_calculate_Click(sender As Object, e As EventArgs) Handles cmd_calculate.Click
        If Not ValidInput() Then
            MsgBox("Both of the inputs must be numeric", vbExclamation + vbOKOnly, "Invalid Input")
        Else
            Calculate()
        End If
    End Sub
    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        weight_input.Text = ""
        height_input.Text = ""
        bmi_result.Text = ""
        bmi_class.Text = ""
    End Sub
    Private Sub cmd_return_Click(sender As Object, e As EventArgs) Handles cmd_return.Click
        Close()
        Form1.Show()
    End Sub
End Class