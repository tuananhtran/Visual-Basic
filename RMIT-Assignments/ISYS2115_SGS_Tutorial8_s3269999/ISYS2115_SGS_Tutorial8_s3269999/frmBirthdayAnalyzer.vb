'Project: Birthday Analyzer
'Lab: Number 8
'Programmer: Tran Tuan Anh
'Created: 18th April, 2011
'Purpose: This program is to analyze and display information about a specified birthday

Public Class frmBirthdayCalculator

    Private Sub frmBirthdayCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'assign tooltips to buttons
        ttpProduceReportButtonToolTip.SetToolTip(btnGenerateReport, "Collect user information and generate Birthday Report!")
        ttpClearButtonToolTip.SetToolTip(btnClear, "Clear the form!")
        ttpExitButtonToolTip.SetToolTip(btnExit, "Exit Birthday Analyzer!")
    End Sub

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click
        'call doReport subroutine to calculate and display birthday analysis
        Call doReport()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear the form
        'clear input fields
        txtSurname.Text = ""
        txtGivenNames.Text = ""
        txtDOB.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False
        rbOther.Checked = False
        'clear output fields
        lblFullName.Text = ""
        lblDayOfBirth.Text = ""
        lblDaysAlive.Text = ""
        lblAge.Text = ""
        lblChineseYear.Text = ""
        'reset report panel's color
        pnlBirthdayReport.BackColor = Color.Transparent

        'focus on the first field
        txtSurname.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'display message box to ask if user want to exit or not
        'if user choose "Yes", then close the form and exit the application
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Exit confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub doReport()
        'declare variables to store input values
        Dim sSurname As String
        Dim sGivenNames As String
        Dim dtDateOfBirth As Date

        'validate and get input values from user
        If txtSurname.Text = "" Then
            'if surname is blank, display error message
            MsgBox("Surname cannot be blank!", MsgBoxStyle.Exclamation, "Invalid Input Value")
            txtSurname.Focus()
            txtSurname.SelectAll()
        ElseIf IsNumeric(txtSurname.Text) Then
            'if surname is numeric, display error message
            MsgBox("Surname cannot be numeric!", MsgBoxStyle.Exclamation, "Invalid Input Value")
            txtSurname.Focus()
            txtSurname.SelectAll()
        ElseIf txtGivenNames.Text = "" Then
            'if given names is blank, display error message
            MsgBox("Given Names cannot be blank!", MsgBoxStyle.Exclamation, "Invalid Input Value")
            txtGivenNames.Focus()
            txtGivenNames.SelectAll()
        ElseIf IsNumeric(txtGivenNames.Text) Then
            'if given names is numeric, display error message
            MsgBox("Given Names cannot be numeric!", MsgBoxStyle.Exclamation, "Invalid Input Value")
            txtGivenNames.Focus()
            txtGivenNames.SelectAll()
        ElseIf txtDOB.Text = "" Then
            'if date of birth is blank, display error message
            MsgBox("Date of Birth cannot be blank!", MsgBoxStyle.Exclamation, "Invalid Input Value")
            txtDOB.Focus()
            txtDOB.SelectAll()
        ElseIf Not IsDate(txtDOB.Text) Then
            'if date of birth is in wrong format, display error message
            MsgBox("Wrong date format!" & vbCrLf & "Date of Birth: D/M/yyyy", MsgBoxStyle.Exclamation, "Invalid Input Value")
            txtDOB.Focus()
            txtDOB.SelectAll()
        ElseIf Not (rbMale.Checked Or rbFemale.Checked Or rbOther.Checked) Then
            MsgBox("Gender cannot be unselected!", MsgBoxStyle.Exclamation, "Invalid Input Value")
        Else
            'get validated input and store into variables
            sSurname = txtSurname.Text
            sGivenNames = txtGivenNames.Text
            dtDateOfBirth = CDate(txtDOB.Text)

            'calculate output values
            'calculate fullname
            lblFullName.Text = sGivenNames & " " & sSurname
            'calculate day of birth
            lblDayOfBirth.Text = sCalculateDayOfBirth(dtDateOfBirth)
            'calculate days alive
            lblDaysAlive.Text = FormatNumber(iCalculateDaysAlive(dtDateOfBirth), 0)
            'calculate age
            lblAge.Text = FormatNumber(iCalculateAge(dtDateOfBirth), 0)
            'update report panel's color
            If rbMale.Checked Then
                pnlBirthdayReport.BackColor = Color.LightBlue
            ElseIf rbFemale.Checked Then
                pnlBirthdayReport.BackColor = Color.Pink
            Else
                pnlBirthdayReport.BackColor = Color.Purple
            End If
            'calculate chinese year
            lblChineseYear.Text = sCalculateChineseYear(dtDateOfBirth)
        End If
    End Sub

    'subroutine to calculate week day of birth
    Private Function sCalculateDayOfBirth(ByVal dtDateOfBirth As Date) As String
        'declare variables to store input and output value
        Dim iDayOfWeek As Integer = dtDateOfBirth.DayOfWeek
        Dim sDayOfBirth As String

        'check and give output value corresponding to the input
        If iDayOfWeek = 0 Then
            sDayOfBirth = "Sunday"
        ElseIf iDayOfWeek = 1 Then
            sDayOfBirth = "Monday"
        ElseIf iDayOfWeek = 2 Then
            sDayOfBirth = "Tuesday"
        ElseIf iDayOfWeek = 3 Then
            sDayOfBirth = "Wednesday"
        ElseIf iDayOfWeek = 4 Then
            sDayOfBirth = "Thursday"
        ElseIf iDayOfWeek = 5 Then
            sDayOfBirth = "Friday"
        Else
            sDayOfBirth = "Saturday"
        End If

        Return sDayOfBirth
    End Function

    'subroutine to calculate number of days alive
    Private Function iCalculateDaysAlive(ByVal dtDateOfBirth As Date) As Integer
        Return DateDiff(DateInterval.Day, dtDateOfBirth, Today)
    End Function

    'subroutine to calculate age
    Private Function iCalculateAge(ByVal dtDateOfBirth As Date) As Integer
        Return DateDiff(DateInterval.Year, dtDateOfBirth, Today)
    End Function

    'subroutine to calculate chinese year of birth
    Private Function sCalculateChineseYear(ByVal dtDateOfBirth As Date) As String
        'declare variables to store input and output value
        Dim iYear As Integer = dtDateOfBirth.Year
        Dim iAnimalNo As Integer = iYear Mod 12
        Dim sChineseYear As String

        'check and give output value corresponding to the input
        If iAnimalNo = 0 Then
            sChineseYear = "Monkey"
        ElseIf iAnimalNo = 1 Then
            sChineseYear = "Rooster"
        ElseIf iAnimalNo = 2 Then
            sChineseYear = "Dog"
        ElseIf iAnimalNo = 3 Then
            sChineseYear = "Pig"
        ElseIf iAnimalNo = 4 Then
            sChineseYear = "Rat"
        ElseIf iAnimalNo = 5 Then
            sChineseYear = "Ox"
        ElseIf iAnimalNo = 6 Then
            sChineseYear = "Tiger"
        ElseIf iAnimalNo = 7 Then
            sChineseYear = "Rabbit"
        ElseIf iAnimalNo = 8 Then
            sChineseYear = "Dragon"
        ElseIf iAnimalNo = 9 Then
            sChineseYear = "Snake"
        ElseIf iAnimalNo = 10 Then
            sChineseYear = "Horse"
        Else
            sChineseYear = "Sheep (Goat)"
        End If

        Return sChineseYear
    End Function
End Class
