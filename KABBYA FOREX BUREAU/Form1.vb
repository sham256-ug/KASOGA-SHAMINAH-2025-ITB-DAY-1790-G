Public Class Form1
    ' KABBYA FOREX BUREAU
    ' Currency Converter
    '
    ' Exchange Rates:
    ' 540 UGX = 1 Chinese Yuan
    ' 110 UGX = 1 UAE Dirham

    ' Exchange Rate Constants

    Const UGX_TO_YUAN_RATE As Decimal = 540D
    Const UGX_TO_DIRHAM_RATE As Decimal = 110D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Clear all text boxes when the application starts
        txtUgx1.Clear()
        txtChineseYuan1.Clear()

        txtChineseYuan2.Clear()
        txtUgx2.Clear()

        txtUgx3.Clear()
        txtDirham1.Clear()

        txtDirham2.Clear()
        txtUgx3.Clear()

        'Make output fields read-only
        txtChineseYuan1.ReadOnly = True
        txtUgx2.ReadOnly = True
        txtDirham1.ReadOnly = True
        txtUgx4.ReadOnly = True
        'Set the cursor to the first input field
        txtUgx1.Focus()

    End Sub

    ' 1. CONVERT UGX TO CHINESE YUAN
    ' Formula:
    ' Chinese Yuan = UGX / 540

    Private Sub BtnConvertToYuan_Click(sender As Object, e As EventArgs) Handles btnConvertToYuan.Click
        Dim ugxAmount As Decimal
        Dim yuanAmount As Decimal
        'Check whether the user entered an amount
        If txtUgx1.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UGX.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUgx1.Focus()
        End If
        'Check whether the entered value is a valid number
        If Not Decimal.TryParse(txtUgx1.Text, ugxAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtUgx1.SelectAll()
            txtUgx1.Focus()
        End If
        'Check for negative amount
        If ugxAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUgx1.SelectAll()
            txtUgx1.Focus()
            Exit Sub
        End If
        'Perform conversion
        yuanAmount = ugxAmount / UGX_TO_YUAN_RATE


        'Display result
        txtChineseYuan1.Text = yuanAmount.ToString("N2")
    End Sub
    ' 2. CONVERT CHINESE YUAN TO UGX
    ' Formula:
    ' UGX = Chinese Yuan × 540

    Private Sub btnConvertToUgx1_Click(sender As Object, e As EventArgs) Handles btnConvertToUgx1.Click
        Dim yuanAmount As Decimal
        Dim ugxAmount As Decimal
        'Check whether amount has been entered
        If txtChineseYuan2.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in Chinese Yuan.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtChineseYuan2.Focus()
            Exit Sub

        End If
        'Validate input
        If Not Decimal.TryParse(txtChineseYuan2.Text, yuanAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtChineseYuan2.SelectAll()
            txtChineseYuan2.Focus()
            Exit Sub

        End If
        'Check for negative value
        If yuanAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtChineseYuan2.SelectAll()
            txtChineseYuan2.Focus()
            Exit Sub

        End If
        'Perform conversion
        ugxAmount = yuanAmount * UGX_TO_YUAN_RATE


        'Display result
        txtUgx2.Text = ugxAmount.ToString("N2")
    End Sub
    ' 3. CONVERT UGX TO UAE DIRHAM
    ' Formula:
    ' UAE Dirham = UGX / 110

    Private Sub btnConvertToDirham_Click(sender As Object, e As EventArgs) Handles btnConvertToDirham.Click
        Dim ugxAmount As Decimal
        Dim dirhamAmount As Decimal

        'Check whether amount has been entered
        If txtUgx3.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UGX.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUgx3.Focus()
            Exit Sub

        End If
        'Validate input
        If Not Decimal.TryParse(txtUgx3.Text, ugxAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtUgx3.SelectAll()
            txtUgx3.Focus()
            Exit Sub

        End If
        'Check for negative amount
        If ugxAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUgx3.SelectAll()
            txtUgx3.Focus()
            Exit Sub

        End If
        'Perform conversion
        dirhamAmount = ugxAmount / UGX_TO_DIRHAM_RATE


        'Display result
        txtDirham1.Text = dirhamAmount.ToString("N2")
    End Sub
    ' 4. CONVERT UAE DIRHAM TO UGX
    ' Formula:
    ' UGX = UAE Dirham × 110

    Private Sub btnConvertToUgx2_Click(sender As Object, e As EventArgs) Handles btnConvertToUgx2.Click
        Dim dirhamAmount As Decimal
        Dim ugxAmount As Decimal
        'Check whether amount has been entered
        If txtDirham2.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UAE Dirham.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtDirham2.Focus()
            Exit Sub

        End If
        'Validate input
        If Not Decimal.TryParse(txtDirham2.Text, dirhamAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtDirham2.SelectAll()
            txtDirham2.Focus()
            Exit Sub

        End If
        'Check for negative value
        If dirhamAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtDirham2.SelectAll()
            txtDirham2.Focus()
            Exit Sub

        End If
        'Perform conversion
        ugxAmount = dirhamAmount * UGX_TO_DIRHAM_RATE


        'Display result
        txtUgx4.Text = ugxAmount.ToString("N2")

    End Sub
    ' 5. CLEAR BUTTON
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear UGX/Yuan conversion
        txtUgx1.Clear()
        txtChineseYuan1.Clear()
        'Clear Yuan/UGX conversion
        txtChineseYuan2.Clear()
        txtUgx2.Clear()
        'Clear UGX/Dirham conversion
        txtUgx3.Clear()
        txtDirham1.Clear()
        'Clear Dirham/UGX conversion
        txtDirham2.Clear()
        txtUgx4.Clear()
        'Return cursor to first field
        txtUgx1.Focus()
    End Sub
    ' 6. EXIT BUTTON
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim answer As DialogResult
        answer = MessageBox.Show(
            "Are you sure you want to exit Kabbya Forex Bureau?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then

            Application.Exit()

        End If


    End Sub

End Class
