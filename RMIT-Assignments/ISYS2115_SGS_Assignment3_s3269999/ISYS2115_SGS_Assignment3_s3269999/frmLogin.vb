'Project: Paradise Bookings Processing System
'Assignment: Number 3
'Programmer: Tran Tuan Anh
'Created: 4th May, 2011
'Application Purpose: This program is to record and store room bookings of Paradise Beach Resort
'Form Purpose: This is a login form, which accept and validate Manager Name input

'import library for usage of Regular Expression
Imports System.Text.RegularExpressions

Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'if user click OK button, validate Manager Name

        If bManagerNameIsValid() Then
            'if manager is valid, hide login form and display main form
            Me.Hide()
            frmBookingsProcessingSystem.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'if user click Cancel button, close the form and exit the application
        Me.Close()
    End Sub

    Private Function bManagerNameIsValid() As Boolean
        'validate manager name, display error message and return check result

        If txtManagerName.Text = "" Then

            'if manager name is blank, display error message
            MsgBox("Manager Name cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'move focus to erroneous field
            txtManagerName.Focus()
            txtManagerName.SelectAll()

            'indicate failed check
            Return False

        ElseIf IsNumeric(txtManagerName.Text) Then

            'if manager name field contains only numbers, display error message
            MsgBox("Manager Name cannot be numeric!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'move focus to erroneous field
            txtManagerName.Focus()
            txtManagerName.SelectAll()

            'indicate failed check
            Return False

        Else
            'else, check if manager name is in correct form

            'define regular expression to check input value
            Dim sManagerNameRegEx As Regex = New Regex("^[A-Z][a-z]*( [A-Z][a-z]*)*$")

            If Not sManagerNameRegEx.IsMatch(txtManagerName.Text) Then

                'if manager name is not in correct form, display error message
                MsgBox("Invalid Manager Name!" & vbCrLf & "Correct patterns: 'Sam', 'Bill Gates', etc.", MsgBoxStyle.Exclamation, "Invalid input value!")

                'move focus to erroneous field
                txtManagerName.Focus()
                txtManagerName.SelectAll()

                'indicate failed check
                Return False

            End If

        End If

        'if manager name is in correct form, indicate passed check
        Return True

    End Function

End Class
