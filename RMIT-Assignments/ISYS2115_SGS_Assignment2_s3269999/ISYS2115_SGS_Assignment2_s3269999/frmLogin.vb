Imports System.Text.RegularExpressions

Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    'declare variable to store login details
    Private sStaffID As String
    Private sLocationID As String

    'if user chooses to login, validate input and open the main form
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'declare regular expression variables to check input values
        Dim staffIDRegEx As Regex = New Regex("^TTC[\d]{4}$")
        Dim passwordRegEx As Regex = New Regex("^PRRS1029$")
        Dim locationIDRegEx As Regex = New Regex("^[A-Z]{2}[\d]{3}$")

        If Not staffIDRegEx.IsMatch(txtStaffID.Text) Then
            'if staff id is in wrong format, display error message
            MsgBox("Invalid Staff ID!" & vbCrLf & "Pattern: TTCxxxx (x is a number)", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtStaffID.Focus()
            txtStaffID.SelectAll()
        ElseIf Not passwordRegEx.IsMatch(txtPassword.Text) Then
            'if password is incorrect, display error message
            MsgBox("Incorrect Password!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtPassword.Focus()
            txtPassword.SelectAll()
        ElseIf Not locationIDRegEx.IsMatch(txtLocationID.Text) Then
            'if location id is in wrong format, display error message
            MsgBox("Invalid Location ID!" & vbCrLf & "Correct pattern: YYxxx (Y is a capital letter, x is a number)", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtLocationID.Focus()
            txtLocationID.SelectAll()
        Else
            'if input is successfully validate, save login details
            sStaffID = txtStaffID.Text
            sLocationID = txtLocationID.Text

            'log user in and show main system form
            Me.Hide()
            frmReservationRecordingSystem.Show()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'if user does not want to login, close the Login form and exit the application
        Me.Close()
    End Sub

    'get staff id of logged in user
    Public Function getStaffID()
        Return sStaffID
    End Function

    'get location id of logged in user
    Public Function getLocationID()
        Return sLocationID
    End Function

End Class
