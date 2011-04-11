'Project: Personal Loan Calculator
'Lab: Number 3
'Programmer: Tran Tuan Anh
'Created: 14th March, 2011
'Purpose: This program is to calculate payments (by month, year and total) based on specified info. (duration, rate and principal)

Public Class frmLoanCalculator

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'declare variables to store input values
        Dim dLoanDuration As Double
        Dim dInterestRate As Double
        Dim dPrincipal As Double

        'declare variables to store output values
        Dim dMonthlyPayment As Double
        Dim dAnnualPayment As Double
        Dim dTotalPayment As Double

        ' * Validate and get values from all input fields
        '
        ' |- Loan Duration
        '
        If Not IsNumeric(txtLoanDuration.Text) Then
            'if duration is not a number, display error message and focus on the erroneous field
            MsgBox("Please enter a positive whole number for Loan Duration!", MsgBoxStyle.Exclamation, "Invalid Loan Duration value")
            txtLoanDuration.Focus()
            txtLoanDuration.SelectAll()
        ElseIf CDbl(txtLoanDuration.Text) < 1 Then
            'if duration is negative, display error message and focus on the erroneous field
            MsgBox("Please enter a positive number for Loan Duration!", MsgBoxStyle.Exclamation, "Invalid Loan Duration value")
            txtLoanDuration.Focus()
            txtLoanDuration.SelectAll()
        ElseIf CDbl(txtLoanDuration.Text) - CInt(txtLoanDuration.Text) <> 0 Then
            'if duration is not a whole number, display error message and focus on the erroneous field
            MsgBox("Please enter a whole number for Loan Duration!", MsgBoxStyle.Exclamation, "Invalid Loan Duration value")
            txtLoanDuration.Focus()
            txtLoanDuration.SelectAll()
        Else
            'else, assign value to variable
            dLoanDuration = CDbl(txtLoanDuration.Text)
            '
            ' |- Interest Rate
            '
            If Not IsNumeric(txtInterestRate.Text) Then
                'if rate is not a number, display error message and focus on the erroneous field
                MsgBox("Please enter a positive number for Interest Rate!", MsgBoxStyle.Exclamation, "Invalid Interest Rate value")
                txtInterestRate.Focus()
                txtInterestRate.SelectAll()
            ElseIf CDbl(txtInterestRate.Text) <= 0 Or CDbl(txtInterestRate.Text) > 100 Then
                'if rate is negative or over 100, display error message and focus on the erroneous field
                MsgBox("Interest Rate can only be a positive number between 0 and 100!", MsgBoxStyle.Exclamation, "Invalid Interest Rate value")
                txtInterestRate.Focus()
                txtInterestRate.SelectAll()
            Else
                'else, assign value to variable
                dInterestRate = CDbl(txtInterestRate.Text) / 100
                '
                ' |- Principal
                '
                If Not IsNumeric(txtPrincipal.Text) Then
                    'if principal is not a number, display error message and focus on the erroneous field
                    MsgBox("Please enter a positive number for Principal!", MsgBoxStyle.Exclamation, "Invalid Principal value")
                    txtPrincipal.Focus()
                    txtPrincipal.SelectAll()
                ElseIf CDbl(txtPrincipal.Text) <= 0 Then
                    'if principal is negative, display error message and focus on the erroneous field
                    MsgBox("Principal can only be a positive number!", MsgBoxStyle.Exclamation, "Invalid Principal value")
                    txtPrincipal.Focus()
                    txtPrincipal.SelectAll()
                Else
                    'else, assign value to variable
                    dPrincipal = CDbl(txtPrincipal.Text)

                    'calculate payments and assign to output variables
                    dTotalPayment = dPrincipal + dInterestRate * dPrincipal
                    dAnnualPayment = dTotalPayment / dLoanDuration
                    dMonthlyPayment = dAnnualPayment / 12

                    'display results to the end-user
                    lblMonthlyPayment.Text = FormatNumber(dMonthlyPayment)
                    lblAnnualPayment.Text = FormatNumber(dAnnualPayment)
                    lblTotalPayment.Text = FormatNumber(dTotalPayment)
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear input fields
        txtLoanDuration.Text = ""
        txtInterestRate.Text = ""
        txtPrincipal.Text = ""

        'clear output fields
        lblMonthlyPayment.Text = ""
        lblAnnualPayment.Text = ""
        lblTotalPayment.Text = ""

        'inform the end-user
        stsStatus.Text = "All fields cleared!"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'ask user if they want to exit, if yes then close the form and exit application
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalculate_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.MouseHover
        'display functionality details when mouse hovers the "Calculate" button
        stsStatus.Text = "Calculate monthy, annual and total payments for this loan"
    End Sub

    Private Sub btnCalculate_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.MouseLeave
        'restore default status text
        stsStatus.Text = "Ready"
    End Sub
    Private Sub btnClear_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.MouseHover
        'display functionality details when mouse hovers the "Clear" button
        stsStatus.Text = "Clear all fields to add new values"
    End Sub

    Private Sub btnClear_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.MouseLeave
        'restore default status text
        stsStatus.Text = "Ready"
    End Sub

    Private Sub btnExit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseHover
        'display functionality details when mouse hovers the "Exit" button
        stsStatus.Text = "Exit Personal Loan Calculator"
    End Sub

    Private Sub btnExit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave
        'restore default status text
        stsStatus.Text = "Ready"
    End Sub

    Private Sub txtLoanDuration_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanDuration.MouseHover
        stsStatus.Text = "Loan duration in years (1, 12, 26, 40, ...)"
    End Sub

    Private Sub txtLoandDuration_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanDuration.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub txtInterestRate_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInterestRate.MouseHover
        stsStatus.Text = "Interest rate in percents (1, 2 , 14, 28, ..., 100)"
    End Sub

    Private Sub txtInterestRate_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInterestRate.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub txtPrincipal_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrincipal.MouseHover
        stsStatus.Text = "Amount of money to be borrowed in USD (10, 500, 80000, ...)"
    End Sub

    Private Sub txtPrincipal_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrincipal.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub lblMonthlyPayment_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMonthlyPayment.MouseHover
        stsStatus.Text = "Result monthly payment in USD"
    End Sub

    Private Sub lblMonthlyPayment_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMonthlyPayment.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub lblAnnualPayment_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnnualPayment.MouseHover
        stsStatus.Text = "Result annual payment in USD"
    End Sub

    Private Sub lblAnnualPayment_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnnualPayment.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub lblTotalPayment_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalPayment.MouseHover
        stsStatus.Text = "Result total payment in USD"
    End Sub

    Private Sub lblTotalPayment_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalPayment.MouseLeave
        stsStatus.Text = "Ready"
    End Sub
End Class
