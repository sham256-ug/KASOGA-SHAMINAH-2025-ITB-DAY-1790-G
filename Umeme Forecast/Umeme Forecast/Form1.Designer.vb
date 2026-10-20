<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblServiceFee = New Label()
        lblTotalCost = New Label()
        lblUnitsPurchased = New Label()
        lblFixedChargesTotal = New Label()
        lblVAT = New Label()
        btnFixedChargesTotal = New Button()
        btnTotalCost = New Button()
        txtVAT = New TextBox()
        txtServiceFee = New TextBox()
        txtTotalCost = New TextBox()
        txtUnitsPurchased = New TextBox()
        txtFixedChargesTotal = New TextBox()
        SuspendLayout()
        ' 
        ' lblServiceFee
        ' 
        lblServiceFee.AutoSize = True
        lblServiceFee.Location = New Point(113, 80)
        lblServiceFee.Name = "lblServiceFee"
        lblServiceFee.Size = New Size(62, 15)
        lblServiceFee.TabIndex = 0
        lblServiceFee.Text = "ServiceFee"
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Location = New Point(171, 401)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(60, 15)
        lblTotalCost.TabIndex = 1
        lblTotalCost.Text = "Total Cost"
        ' 
        ' lblUnitsPurchased
        ' 
        lblUnitsPurchased.AutoSize = True
        lblUnitsPurchased.Location = New Point(139, 276)
        lblUnitsPurchased.Name = "lblUnitsPurchased"
        lblUnitsPurchased.Size = New Size(92, 15)
        lblUnitsPurchased.TabIndex = 2
        lblUnitsPurchased.Text = "Units Purchased"
        ' 
        ' lblFixedChargesTotal
        ' 
        lblFixedChargesTotal.AutoSize = True
        lblFixedChargesTotal.Location = New Point(122, 235)
        lblFixedChargesTotal.Name = "lblFixedChargesTotal"
        lblFixedChargesTotal.Size = New Size(109, 15)
        lblFixedChargesTotal.TabIndex = 3
        lblFixedChargesTotal.Text = "Fixed Charges Total"
        ' 
        ' lblVAT
        ' 
        lblVAT.AutoSize = True
        lblVAT.Location = New Point(138, 128)
        lblVAT.Name = "lblVAT"
        lblVAT.Size = New Size(27, 15)
        lblVAT.TabIndex = 4
        lblVAT.Text = "VAT"
        ' 
        ' btnFixedChargesTotal
        ' 
        btnFixedChargesTotal.Location = New Point(190, 171)
        btnFixedChargesTotal.Name = "btnFixedChargesTotal"
        btnFixedChargesTotal.Size = New Size(180, 36)
        btnFixedChargesTotal.TabIndex = 5
        btnFixedChargesTotal.Text = "FIXED CHARGES TOTAL"
        btnFixedChargesTotal.UseVisualStyleBackColor = True
        ' 
        ' btnTotalCost
        ' 
        btnTotalCost.Location = New Point(205, 323)
        btnTotalCost.Name = "btnTotalCost"
        btnTotalCost.Size = New Size(165, 47)
        btnTotalCost.TabIndex = 6
        btnTotalCost.Text = "TOTAL COST"
        btnTotalCost.UseVisualStyleBackColor = True
        ' 
        ' txtVAT
        ' 
        txtVAT.Location = New Point(205, 125)
        txtVAT.Name = "txtVAT"
        txtVAT.Size = New Size(192, 23)
        txtVAT.TabIndex = 7
        ' 
        ' txtServiceFee
        ' 
        txtServiceFee.Location = New Point(205, 96)
        txtServiceFee.Name = "txtServiceFee"
        txtServiceFee.Size = New Size(192, 23)
        txtServiceFee.TabIndex = 8
        ' 
        ' txtTotalCost
        ' 
        txtTotalCost.Location = New Point(246, 393)
        txtTotalCost.Name = "txtTotalCost"
        txtTotalCost.Size = New Size(192, 23)
        txtTotalCost.TabIndex = 9
        ' 
        ' txtUnitsPurchased
        ' 
        txtUnitsPurchased.Location = New Point(246, 276)
        txtUnitsPurchased.Name = "txtUnitsPurchased"
        txtUnitsPurchased.Size = New Size(192, 23)
        txtUnitsPurchased.TabIndex = 10
        ' 
        ' txtFixedChargesTotal
        ' 
        txtFixedChargesTotal.Location = New Point(246, 232)
        txtFixedChargesTotal.Name = "txtFixedChargesTotal"
        txtFixedChargesTotal.Size = New Size(192, 23)
        txtFixedChargesTotal.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtFixedChargesTotal)
        Controls.Add(txtUnitsPurchased)
        Controls.Add(txtTotalCost)
        Controls.Add(txtServiceFee)
        Controls.Add(txtVAT)
        Controls.Add(btnTotalCost)
        Controls.Add(btnFixedChargesTotal)
        Controls.Add(lblVAT)
        Controls.Add(lblFixedChargesTotal)
        Controls.Add(lblUnitsPurchased)
        Controls.Add(lblTotalCost)
        Controls.Add(lblServiceFee)
        Name = "Form1"
        Text = "UmemeForecast"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblServiceFee As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblUnitsPurchased As Label
    Friend WithEvents lblFixedChargesTotal As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents btnFixedChargesTotal As Button
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtServiceFee As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents txtUnitsPurchased As TextBox
    Friend WithEvents txtFixedChargesTotal As TextBox

End Class
