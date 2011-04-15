<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
        Me.grpDetails = New System.Windows.Forms.GroupBox
        Me.lblPrincipalUnit = New System.Windows.Forms.Label
        Me.lblInterestRateUnit = New System.Windows.Forms.Label
        Me.lblLoanDurationUnit = New System.Windows.Forms.Label
        Me.txtPrincipal = New System.Windows.Forms.TextBox
        Me.txtInterestRate = New System.Windows.Forms.TextBox
        Me.txtLoanDuration = New System.Windows.Forms.TextBox
        Me.lblPrincipal = New System.Windows.Forms.Label
        Me.lblInterestRate = New System.Windows.Forms.Label
        Me.lblLoanDuration = New System.Windows.Forms.Label
        Me.grpResults = New System.Windows.Forms.GroupBox
        Me.lblMonthlyPaymentUnit = New System.Windows.Forms.Label
        Me.lblAnnualPaymentUnit = New System.Windows.Forms.Label
        Me.lblTotalPaymentUnit = New System.Windows.Forms.Label
        Me.lblTotalPayment = New System.Windows.Forms.Label
        Me.lblAnnualPayment = New System.Windows.Forms.Label
        Me.lblMonthlyPayment = New System.Windows.Forms.Label
        Me.lblTotalPaymentHeading = New System.Windows.Forms.Label
        Me.lblAnnualPaymentHeading = New System.Windows.Forms.Label
        Me.lblMonthlyPaymentHeading = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.stsStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.stsStatusBar = New System.Windows.Forms.StatusStrip
        Me.grpDetails.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.stsStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.lblPrincipalUnit)
        Me.grpDetails.Controls.Add(Me.lblInterestRateUnit)
        Me.grpDetails.Controls.Add(Me.lblLoanDurationUnit)
        Me.grpDetails.Controls.Add(Me.txtPrincipal)
        Me.grpDetails.Controls.Add(Me.txtInterestRate)
        Me.grpDetails.Controls.Add(Me.txtLoanDuration)
        Me.grpDetails.Controls.Add(Me.lblPrincipal)
        Me.grpDetails.Controls.Add(Me.lblInterestRate)
        Me.grpDetails.Controls.Add(Me.lblLoanDuration)
        Me.grpDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetails.Location = New System.Drawing.Point(40, 40)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(240, 230)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Loan Information"
        '
        'lblPrincipalUnit
        '
        Me.lblPrincipalUnit.AutoSize = True
        Me.lblPrincipalUnit.Location = New System.Drawing.Point(160, 183)
        Me.lblPrincipalUnit.Name = "lblPrincipalUnit"
        Me.lblPrincipalUnit.Size = New System.Drawing.Size(37, 16)
        Me.lblPrincipalUnit.TabIndex = 6
        Me.lblPrincipalUnit.Text = "USD"
        '
        'lblInterestRateUnit
        '
        Me.lblInterestRateUnit.AutoSize = True
        Me.lblInterestRateUnit.Location = New System.Drawing.Point(160, 117)
        Me.lblInterestRateUnit.Name = "lblInterestRateUnit"
        Me.lblInterestRateUnit.Size = New System.Drawing.Size(20, 16)
        Me.lblInterestRateUnit.TabIndex = 6
        Me.lblInterestRateUnit.Text = "%"
        '
        'lblLoanDurationUnit
        '
        Me.lblLoanDurationUnit.AutoSize = True
        Me.lblLoanDurationUnit.Location = New System.Drawing.Point(160, 53)
        Me.lblLoanDurationUnit.Name = "lblLoanDurationUnit"
        Me.lblLoanDurationUnit.Size = New System.Drawing.Size(50, 16)
        Me.lblLoanDurationUnit.TabIndex = 6
        Me.lblLoanDurationUnit.Text = "year(s)"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(30, 180)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(121, 22)
        Me.txtPrincipal.TabIndex = 5
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(30, 114)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(121, 22)
        Me.txtInterestRate.TabIndex = 4
        '
        'txtLoanDuration
        '
        Me.txtLoanDuration.Location = New System.Drawing.Point(30, 50)
        Me.txtLoanDuration.Name = "txtLoanDuration"
        Me.txtLoanDuration.Size = New System.Drawing.Size(121, 22)
        Me.txtLoanDuration.TabIndex = 3
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(27, 160)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(60, 16)
        Me.lblPrincipal.TabIndex = 2
        Me.lblPrincipal.Text = "Principal"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(27, 94)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(83, 16)
        Me.lblInterestRate.TabIndex = 1
        Me.lblInterestRate.Text = "Interest Rate"
        '
        'lblLoanDuration
        '
        Me.lblLoanDuration.AutoSize = True
        Me.lblLoanDuration.Location = New System.Drawing.Point(27, 30)
        Me.lblLoanDuration.Name = "lblLoanDuration"
        Me.lblLoanDuration.Size = New System.Drawing.Size(91, 16)
        Me.lblLoanDuration.TabIndex = 0
        Me.lblLoanDuration.Text = "Loan Duration"
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lblMonthlyPaymentUnit)
        Me.grpResults.Controls.Add(Me.lblAnnualPaymentUnit)
        Me.grpResults.Controls.Add(Me.lblTotalPaymentUnit)
        Me.grpResults.Controls.Add(Me.lblTotalPayment)
        Me.grpResults.Controls.Add(Me.lblAnnualPayment)
        Me.grpResults.Controls.Add(Me.lblMonthlyPayment)
        Me.grpResults.Controls.Add(Me.lblTotalPaymentHeading)
        Me.grpResults.Controls.Add(Me.lblAnnualPaymentHeading)
        Me.grpResults.Controls.Add(Me.lblMonthlyPaymentHeading)
        Me.grpResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResults.Location = New System.Drawing.Point(310, 40)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(240, 230)
        Me.grpResults.TabIndex = 2
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        '
        'lblMonthlyPaymentUnit
        '
        Me.lblMonthlyPaymentUnit.AutoSize = True
        Me.lblMonthlyPaymentUnit.Location = New System.Drawing.Point(160, 55)
        Me.lblMonthlyPaymentUnit.Name = "lblMonthlyPaymentUnit"
        Me.lblMonthlyPaymentUnit.Size = New System.Drawing.Size(37, 16)
        Me.lblMonthlyPaymentUnit.TabIndex = 6
        Me.lblMonthlyPaymentUnit.Text = "USD"
        '
        'lblAnnualPaymentUnit
        '
        Me.lblAnnualPaymentUnit.AutoSize = True
        Me.lblAnnualPaymentUnit.Location = New System.Drawing.Point(160, 119)
        Me.lblAnnualPaymentUnit.Name = "lblAnnualPaymentUnit"
        Me.lblAnnualPaymentUnit.Size = New System.Drawing.Size(37, 16)
        Me.lblAnnualPaymentUnit.TabIndex = 6
        Me.lblAnnualPaymentUnit.Text = "USD"
        '
        'lblTotalPaymentUnit
        '
        Me.lblTotalPaymentUnit.AutoSize = True
        Me.lblTotalPaymentUnit.Location = New System.Drawing.Point(160, 185)
        Me.lblTotalPaymentUnit.Name = "lblTotalPaymentUnit"
        Me.lblTotalPaymentUnit.Size = New System.Drawing.Size(37, 16)
        Me.lblTotalPaymentUnit.TabIndex = 6
        Me.lblTotalPaymentUnit.Text = "USD"
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayment.Location = New System.Drawing.Point(29, 180)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(121, 27)
        Me.lblTotalPayment.TabIndex = 5
        '
        'lblAnnualPayment
        '
        Me.lblAnnualPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualPayment.Location = New System.Drawing.Point(29, 114)
        Me.lblAnnualPayment.Name = "lblAnnualPayment"
        Me.lblAnnualPayment.Size = New System.Drawing.Size(121, 27)
        Me.lblAnnualPayment.TabIndex = 4
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(29, 50)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(121, 27)
        Me.lblMonthlyPayment.TabIndex = 3
        '
        'lblTotalPaymentHeading
        '
        Me.lblTotalPaymentHeading.AutoSize = True
        Me.lblTotalPaymentHeading.Location = New System.Drawing.Point(26, 160)
        Me.lblTotalPaymentHeading.Name = "lblTotalPaymentHeading"
        Me.lblTotalPaymentHeading.Size = New System.Drawing.Size(95, 16)
        Me.lblTotalPaymentHeading.TabIndex = 2
        Me.lblTotalPaymentHeading.Text = "Total Payment"
        '
        'lblAnnualPaymentHeading
        '
        Me.lblAnnualPaymentHeading.AutoSize = True
        Me.lblAnnualPaymentHeading.Location = New System.Drawing.Point(26, 94)
        Me.lblAnnualPaymentHeading.Name = "lblAnnualPaymentHeading"
        Me.lblAnnualPaymentHeading.Size = New System.Drawing.Size(105, 16)
        Me.lblAnnualPaymentHeading.TabIndex = 1
        Me.lblAnnualPaymentHeading.Text = "Annual Payment"
        '
        'lblMonthlyPaymentHeading
        '
        Me.lblMonthlyPaymentHeading.AutoSize = True
        Me.lblMonthlyPaymentHeading.Location = New System.Drawing.Point(26, 30)
        Me.lblMonthlyPaymentHeading.Name = "lblMonthlyPaymentHeading"
        Me.lblMonthlyPaymentHeading.Size = New System.Drawing.Size(110, 16)
        Me.lblMonthlyPaymentHeading.TabIndex = 0
        Me.lblMonthlyPaymentHeading.Text = "Monthly Payment"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(10, 10)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(118, 13)
        Me.lblCopyright.TabIndex = 3
        Me.lblCopyright.Text = "© Tran Tuan Anh 2011"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(107, 286)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 33)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(236, 286)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 33)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(373, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 35)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'stsStatus
        '
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(39, 17)
        Me.stsStatus.Text = "Ready"
        '
        'stsStatusBar
        '
        Me.stsStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsStatus})
        Me.stsStatusBar.Location = New System.Drawing.Point(0, 340)
        Me.stsStatusBar.Name = "stsStatusBar"
        Me.stsStatusBar.Size = New System.Drawing.Size(584, 22)
        Me.stsStatusBar.TabIndex = 0
        Me.stsStatusBar.Text = "Ready"
        '
        'frmLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.stsStatusBar)
        Me.Name = "frmLoanCalculator"
        Me.Text = "Personal Loan Calculator "
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.stsStatusBar.ResumeLayout(False)
        Me.stsStatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpResults As System.Windows.Forms.GroupBox
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblPrincipal As System.Windows.Forms.Label
    Friend WithEvents lblInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblLoanDuration As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanDuration As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPayment As System.Windows.Forms.Label
    Friend WithEvents lblAnnualPayment As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label
    Friend WithEvents lblTotalPaymentHeading As System.Windows.Forms.Label
    Friend WithEvents lblAnnualPaymentHeading As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyPaymentHeading As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPrincipalUnit As System.Windows.Forms.Label
    Friend WithEvents lblInterestRateUnit As System.Windows.Forms.Label
    Friend WithEvents lblLoanDurationUnit As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyPaymentUnit As System.Windows.Forms.Label
    Friend WithEvents lblAnnualPaymentUnit As System.Windows.Forms.Label
    Friend WithEvents lblTotalPaymentUnit As System.Windows.Forms.Label
    Friend WithEvents stsStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsStatusBar As System.Windows.Forms.StatusStrip

End Class
