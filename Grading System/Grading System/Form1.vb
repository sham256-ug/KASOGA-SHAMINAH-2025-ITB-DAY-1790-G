Public Class Form1

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim EnterMarks As Integer
        'input validation for marks to ensure numericinput
        If Not Integer.TryParse(txtEnterMarks.Text, EnterMarks) Then
            MessageBox.Show("Please enter valid numeric value for marks.")
            Exit Sub
        End If

        'Chek if marks exceed 100
        If EnterMarks > 100 Then
            MessageBox.Show("Wrong entry, please re-enter the marks")
            Exit Sub
        End If
        'Using selectcase to determine the grade based on marks
        Select Case EnterMarks
            Case 90 To 100
                txtGrade.Text = "Excellent"
            Case 80 To 89
                txtGrade.Text = "Very Good"
            Case 70 To 79
                txtGrade.Text = "Good"
            Case 60 To 69
                txtGrade.Text = "Medium"
            Case 50 To 59
                txtGrade.Text = "Pass"
            Case 0 To 49
                txtGrade.Text = "Fail"
            Case Else
                txtGrade.Text = "Invalid Input"

        End Select
    End Sub

    Private Sub lblGradingScaleCalculator_Click(sender As Object, e As EventArgs) Handles lblGradingScaleCalculator.Click

    End Sub
End Class
