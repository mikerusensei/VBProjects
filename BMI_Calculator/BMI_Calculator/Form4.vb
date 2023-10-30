Public Class Form4
    Dim weight_var, height_var, bmi, final_weight, final_height As Double

    ' Private Functions
    Private Function ValidInput() As Boolean
        Return IsNumeric(weight_input.Text) And IsNumeric(height_input.Text)
    End Function
    Private Function Convert_Weight() As Double
        If weight_measure.Text = "lbs" Then
            final_weight = Val(weight_input.Text) * 0.454
            Return final_weight
        Else
            final_weight = Val(weight_input.Text) * 1
            Return final_weight
        End If
    End Function
    Private Function Convert_Height() As Double
        Dim cm, mtr As Double
        If height_measure.Text = "inch" Then
            cm = Val(height_input.Text) * 2.54
            mtr = cm / 100
            Return mtr
        ElseIf height_measure.Text = "cm" Then
            mtr = Val(height_input.Text) / 100
            Return mtr
        Else
            mtr = Val(height_input.Text)
            Return mtr
        End If
    End Function

    ' Private Subs
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        weight_measure.SelectedIndex = 0
        height_measure.SelectedIndex = 0
    End Sub
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
    Private Sub Calculate()
        weight_var = Convert_Weight()
        height_var = Convert_Height()

        bmi = weight_var / (height_var * height_var)
        bmi_result.Text = Format(bmi, "0.00")
        Classification(bmi)

    End Sub
    Private Sub cmd_return_Click(sender As Object, e As EventArgs) Handles cmd_return.Click
        Close()
        Form1.Show()
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
End Class