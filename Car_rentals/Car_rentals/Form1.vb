Public Class Form1

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtRentalDuration.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtTotalCost_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCost.TextChanged

    End Sub
    Private Sub cmbCarType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCarType.SelectedIndexChanged
        Select Case cmbCarType.Text

            Case "Sedan"
                txtDailyCharge.Text = "150000"

            Case "SUV"
                txtDailyCharge.Text = "290000"

            Case "Truck"
                txtDailyCharge.Text = "350000"

            Case Else
                txtDailyCharge.Clear()

        End Select
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCarType.Items.Clear()

        cmbCarType.Items.Add("Sedan")
        cmbCarType.Items.Add("SUV")
        cmbCarType.Items.Add("Truck")

        cmbCarType.SelectedIndex = -1

        txtRentalDuration.ReadOnly = True
        txtTotalCost.ReadOnly = True

        txtRentalDuration.Clear()
        txtDailyCharge.Clear()
        txtTotalCost.Clear()

    End Sub
    Private Sub txtDailyCharge_TextChanged(sender As Object, e As EventArgs) Handles txtDailyCharge.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbCarType.SelectedIndex = -1
        txtRentalDuration.Clear()
        txtDailyCharge.Clear()
        txtTotalCost.Clear()

        cmbCarType.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dailyCharge As Decimal
        Dim rentalDuration As Integer
        Dim totalCost As Decimal

        'Check book type
        If cmbCarType.SelectedIndex = -1 Then
            MessageBox.Show(
                "Please select a car type.",
                "Car_rentals",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            cmbCarType.Focus()
            Exit Sub
        End If

        'Check rentalDuration
        If txtRentalDuration.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter the rentalDuration.",
                "Car_rentals",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtRentalDuration.Focus()
            Exit Sub
        End If

        'Validate rentalDuration
        If Not Integer.TryParse(txtRentalDuration.Text, rentalDuration) Then
            MessageBox.Show(
                "Please enter a valid whole number for rentalDuration.",
                "Car_rentals",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            txtRentalDuration.Focus()
            txtRentalDuration.SelectAll()
            Exit Sub
        End If

        If rentalDuration <= 0 Then
            MessageBox.Show(
                "RentalDuration must be greater than zero.",
                "Car_rentals",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtRentalDuration.Focus()
            txtRentalDuration.SelectAll()
            Exit Sub
        End If

        'Convert dailyCharge
        If Not Decimal.TryParse(txtDailyCharge.Text, dailyCharge) Then
            MessageBox.Show(
                "Invalid dailyCharge.",
                "Car_rentals",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Exit Sub
        End If

        'Calculate Total Cost = DailyCharge x RentalDuration
        totalCost = dailyCharge * rentalDuration

        'Display Total Cost
        txtTotalCost.Text = totalCost.ToString("N0")

    End Sub
End Class
