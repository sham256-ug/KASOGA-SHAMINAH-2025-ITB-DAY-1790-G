<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.txtRentalDuration = New System.Windows.Forms.TextBox()
        Me.txtTotalRentalCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblRentalDuration = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblTotalRentalCost = New System.Windows.Forms.Label()
        Me.lblDailyCharge = New System.Windows.Forms.Label()
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDailyCharge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbCarType
        '
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.Location = New System.Drawing.Point(583, 137)
        Me.cmbCarType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(397, 28)
        Me.cmbCarType.TabIndex = 0
        '
        'txtRentalDuration
        '
        Me.txtRentalDuration.Location = New System.Drawing.Point(586, 314)
        Me.txtRentalDuration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRentalDuration.Name = "txtRentalDuration"
        Me.txtRentalDuration.Size = New System.Drawing.Size(394, 26)
        Me.txtRentalDuration.TabIndex = 1
        '
        'txtTotalRentalCost
        '
        Me.txtTotalRentalCost.Location = New System.Drawing.Point(586, 394)
        Me.txtTotalRentalCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalRentalCost.Name = "txtTotalRentalCost"
        Me.txtTotalRentalCost.Size = New System.Drawing.Size(394, 26)
        Me.txtTotalRentalCost.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(262, 483)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(258, 64)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblRentalDuration
        '
        Me.lblRentalDuration.AutoSize = True
        Me.lblRentalDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalDuration.Location = New System.Drawing.Point(215, 303)
        Me.lblRentalDuration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRentalDuration.Name = "lblRentalDuration"
        Me.lblRentalDuration.Size = New System.Drawing.Size(254, 37)
        Me.lblRentalDuration.TabIndex = 4
        Me.lblRentalDuration.Text = "Rental Duration"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarType.Location = New System.Drawing.Point(215, 137)
        Me.lblCarType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(156, 37)
        Me.lblCarType.TabIndex = 5
        Me.lblCarType.Text = "Car Type"
        '
        'lblTotalRentalCost
        '
        Me.lblTotalRentalCost.AutoSize = True
        Me.lblTotalRentalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRentalCost.Location = New System.Drawing.Point(215, 384)
        Me.lblTotalRentalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRentalCost.Name = "lblTotalRentalCost"
        Me.lblTotalRentalCost.Size = New System.Drawing.Size(281, 37)
        Me.lblTotalRentalCost.TabIndex = 6
        Me.lblTotalRentalCost.Text = "Total Rental Cost"
        '
        'lblDailyCharge
        '
        Me.lblDailyCharge.AutoSize = True
        Me.lblDailyCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyCharge.Location = New System.Drawing.Point(215, 221)
        Me.lblDailyCharge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDailyCharge.Name = "lblDailyCharge"
        Me.lblDailyCharge.Size = New System.Drawing.Size(213, 37)
        Me.lblDailyCharge.TabIndex = 7
        Me.lblDailyCharge.Text = "Daily Charge"
        '
        'lblFastLogisticsCompanyRentalChargesTrackingSystem
        '
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.AutoSize = True
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.BackColor = System.Drawing.Color.Red
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Location = New System.Drawing.Point(385, 30)
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Name = "lblFastLogisticsCompanyRentalChargesTrackingSystem"
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Size = New System.Drawing.Size(470, 46)
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.TabIndex = 9
        Me.lblFastLogisticsCompanyRentalChargesTrackingSystem.Text = "First Logistics Company"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(759, 483)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 64)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtDailyCharge
        '
        Me.txtDailyCharge.Location = New System.Drawing.Point(583, 232)
        Me.txtDailyCharge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDailyCharge.Name = "txtDailyCharge"
        Me.txtDailyCharge.Size = New System.Drawing.Size(397, 26)
        Me.txtDailyCharge.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.txtDailyCharge)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblFastLogisticsCompanyRentalChargesTrackingSystem)
        Me.Controls.Add(Me.lblDailyCharge)
        Me.Controls.Add(Me.lblTotalRentalCost)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.lblRentalDuration)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotalRentalCost)
        Me.Controls.Add(Me.txtRentalDuration)
        Me.Controls.Add(Me.cmbCarType)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Car_rental system"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCarType As ComboBox
    Friend WithEvents txtRentalDuration As TextBox
    Friend WithEvents txtTotalRentalCost As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblRentalDuration As Label
    Friend WithEvents lblCarType As Label
    Friend WithEvents lblTotalRentalCost As Label
    Friend WithEvents lblDailyCharge As Label
    Friend WithEvents lblFastLogisticsCompanyRentalChargesTrackingSystem As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtDailyCharge As TextBox
End Class
