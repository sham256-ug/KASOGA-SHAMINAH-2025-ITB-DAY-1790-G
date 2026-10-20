Public Class Form1
    Private Sub lblVAT_Click(sender As Object, e As EventArgs) Handles lblVAT.Click

    End Sub

    Private Sub btnFixedChargesTotal_Click(sender As Object, e As EventArgs) Handles btnFixedChargesTotal.Click
        'calculate the FIXED CHARGES TOTAL
        Dim ServiceFee As Decimal = CDec(txtServiceFee.Text)
        Dim VAT As Decimal = CDec(txtVAT.Text)
        Dim FixedChargesTotal As Decimal = ServiceFee + VAT
        'Display the result in the Fixed Charges Total textbox
        txtFixedChargesTotal.Text = FixedChargesTotal.ToString()
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        'calculate the TOTAL COST
        Dim UnitsPurchased As Decimal = CDec(txtUnitsPurchased.Text)
        Dim unitcost As Decimal = 780
        Dim FixedChargesTotal As Decimal = CDec(txtFixedChargesTotal.Text)
        Dim TOTALCOST As Decimal = (UnitsPurchased * unitcost) + FixedChargesTotal
        'Display the results in the Total Cost textbox
        txtTotalCost.Text = TOTALCOST.ToString()
    End Sub
End Class
