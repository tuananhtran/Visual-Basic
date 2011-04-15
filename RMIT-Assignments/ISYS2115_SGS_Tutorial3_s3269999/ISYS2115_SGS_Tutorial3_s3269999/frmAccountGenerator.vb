'Project: Account Generator
'Lab: Number 3
'Programmer: Tran Tuan Anh
'Created: 14th March, 2011
'Purpose: This program is to generate account (username, password and email) for specified user info. (name and domain)

Public Class frmAccountGenerator
    'define heading constant
    Const sFormHeading As String = "RMIT's Account Generator"

    Private Sub frmAccountGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set form heading with heading constant declared above
        lblHeading.Text = sFormHeading
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        'declare variables to store input values
        Dim sFirstName As String
        Dim sLastName As String
        Dim sCompanyDomain As String

        'declare variables to store output values
        Dim sUsername As String
        Dim sPassword As String
        Dim sEmailAddress As String

        'validate and get values from all input fields
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtCompanyDomain.Text = "" Then
            'if a field is is blank, display error message
            MsgBox("All fields are required!", MsgBoxStyle.Exclamation, "Invalid input value")
        ElseIf IsNumeric(txtFirstName.Text) Or IsNumeric(txtFirstName.Text) Or IsNumeric(txtCompanyDomain.Text) Then
            'if a field contains only number, display error message
            MsgBox("Fields cannot contain numbers only!", MsgBoxStyle.Exclamation, "Invalid input value")
        Else
            'assign values to variables
            sFirstName = txtFirstName.Text
            sLastName = txtLastName.Text
            sCompanyDomain = txtCompanyDomain.Text

            'calculate output values
            sUsername = LCase(sFirstName.Substring(0, 3) & sLastName.Substring(0, 3))
            sPassword = LCase(sFirstName.Substring(0, 2) & Len(sFirstName & sLastName) & sLastName.Substring(0, 2))
            sEmailAddress = sFirstName & "." & sLastName & "@" & sCompanyDomain

            'display calculated values to the end-user
            lblUsername.Text = sUsername
            lblPassword.Text = sPassword
            lblEmailAddress.Text = sEmailAddress
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear input fields
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtCompanyDomain.Text = ""

        'clear output fields
        lblUsername.Text = ""
        lblPassword.Text = ""
        lblEmailAddress.Text = ""

        'inform the end-user
        stsStatus.Text = "All fields cleared!"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'ask user if they want to exit, if yes then close the form and exit application
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalculate_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.MouseHover
        'display functionality details when mouse hovers the "Calculate" button
        stsStatus.Text = "Generate account information for this user"
    End Sub

    Private Sub btnCalculate_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.MouseLeave
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
        stsStatus.Text = "Exit Acount Generator"
    End Sub

    Private Sub btnExit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave
        'restore default status text
        stsStatus.Text = "Ready"
    End Sub

    Private Sub txtFirstName_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.MouseHover
        stsStatus.Text = "First Name"
    End Sub

    Private Sub txtFirstName_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub txtLastName_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.MouseHover
        stsStatus.Text = "Last Name"
    End Sub

    Private Sub txtLastName_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub txtCompanyDomain_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompanyDomain.MouseHover
        stsStatus.Text = "Company's Domain (rmit.edu.vn, ...)"
    End Sub

    Private Sub txtCompanyDomain_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompanyDomain.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub lblUsername_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsername.MouseHover
        stsStatus.Text = "Username"
    End Sub

    Private Sub lblUsername_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsername.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub lblPassword_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPassword.MouseHover
        stsStatus.Text = "Password"
    End Sub

    Private Sub lblPassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPassword.MouseLeave
        stsStatus.Text = "Ready"
    End Sub

    Private Sub lblEmailAddress_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEmailAddress.MouseHover
        stsStatus.Text = "Email Address (firstname.lastname@company.domain)"
    End Sub

    Private Sub lblEmailAddress_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEmailAddress.MouseLeave
        stsStatus.Text = "Ready"
    End Sub
End Class