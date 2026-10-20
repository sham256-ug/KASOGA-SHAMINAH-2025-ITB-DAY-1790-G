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
        Me.lblGradingScaleCalculator = New System.Windows.Forms.Label()
        Me.lblEnterMarks = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.txtEnterMarks = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGradingScaleCalculator
        '
        Me.lblGradingScaleCalculator.AutoSize = True
        Me.lblGradingScaleCalculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGradingScaleCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradingScaleCalculator.Location = New System.Drawing.Point(115, 40)
        Me.lblGradingScaleCalculator.Name = "lblGradingScaleCalculator"
        Me.lblGradingScaleCalculator.Size = New System.Drawing.Size(529, 37)
        Me.lblGradingScaleCalculator.TabIndex = 0
        Me.lblGradingScaleCalculator.Text = "GRADING SCALE CALCULATOR"
        '
        'lblEnterMarks
        '
        Me.lblEnterMarks.AutoSize = True
        Me.lblEnterMarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterMarks.Location = New System.Drawing.Point(114, 187)
        Me.lblEnterMarks.Name = "lblEnterMarks"
        Me.lblEnterMarks.Size = New System.Drawing.Size(176, 32)
        Me.lblEnterMarks.TabIndex = 1
        Me.lblEnterMarks.Text = "Enter Marks"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(114, 308)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(98, 32)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade"
        '
        'btnEvaluate
        '
        Me.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEvaluate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluate.Location = New System.Drawing.Point(342, 435)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(193, 53)
        Me.btnEvaluate.TabIndex = 3
        Me.btnEvaluate.Text = "Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = False
        '
        'txtEnterMarks
        '
        Me.txtEnterMarks.Location = New System.Drawing.Point(359, 185)
        Me.txtEnterMarks.Multiline = True
        Me.txtEnterMarks.Name = "txtEnterMarks"
        Me.txtEnterMarks.Size = New System.Drawing.Size(285, 50)
        Me.txtEnterMarks.TabIndex = 4
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(359, 290)
        Me.txtGrade.Multiline = True
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(285, 50)
        Me.txtGrade.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 572)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtEnterMarks)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblEnterMarks)
        Me.Controls.Add(Me.lblGradingScaleCalculator)
        Me.Name = "Form1"
        Me.Text = "Grading System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGradingScaleCalculator As System.Windows.Forms.Label
    Friend WithEvents lblEnterMarks As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents btnEvaluate As System.Windows.Forms.Button
    Friend WithEvents txtEnterMarks As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox

End Class
