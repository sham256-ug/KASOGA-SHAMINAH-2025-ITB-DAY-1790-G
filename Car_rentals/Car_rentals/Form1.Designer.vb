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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.txtRentalDuration = New System.Windows.Forms.TextBox()
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDailyCharge = New System.Windows.Forms.TextBox()
        Me.lblFirstLogisticsCompany = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rental Duration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Daily Charge"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(460, 394)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(223, 26)
        Me.txtTotalCost.TabIndex = 4
        '
        'txtRentalDuration
        '
        Me.txtRentalDuration.Location = New System.Drawing.Point(460, 314)
        Me.txtRentalDuration.Name = "txtRentalDuration"
        Me.txtRentalDuration.Size = New System.Drawing.Size(223, 26)
        Me.txtRentalDuration.TabIndex = 5
        '
        'cmbCarType
        '
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.Location = New System.Drawing.Point(460, 146)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(223, 28)
        Me.cmbCarType.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 40)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Cost"
        '
        'txtDailyCharge
        '
        Me.txtDailyCharge.Location = New System.Drawing.Point(460, 232)
        Me.txtDailyCharge.Name = "txtDailyCharge"
        Me.txtDailyCharge.Size = New System.Drawing.Size(223, 26)
        Me.txtDailyCharge.TabIndex = 9
        '
        'lblFirstLogisticsCompany
        '
        Me.lblFirstLogisticsCompany.AutoSize = True
        Me.lblFirstLogisticsCompany.BackColor = System.Drawing.Color.Red
        Me.lblFirstLogisticsCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstLogisticsCompany.Location = New System.Drawing.Point(304, 45)
        Me.lblFirstLogisticsCompany.Name = "lblFirstLogisticsCompany"
        Me.lblFirstLogisticsCompany.Size = New System.Drawing.Size(424, 40)
        Me.lblFirstLogisticsCompany.TabIndex = 10
        Me.lblFirstLogisticsCompany.Text = "First Logistics Company"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(215, 499)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(182, 60)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(645, 499)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 60)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 681)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblFirstLogisticsCompany)
        Me.Controls.Add(Me.txtDailyCharge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCarType)
        Me.Controls.Add(Me.txtRentalDuration)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CAR RENTAL SYSTEM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtRentalDuration As System.Windows.Forms.TextBox
    Friend WithEvents cmbCarType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDailyCharge As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstLogisticsCompany As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
