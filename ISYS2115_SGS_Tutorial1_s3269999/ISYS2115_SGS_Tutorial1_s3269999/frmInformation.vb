'Project: Personal Information
'Lab: Number 1
'Programmer: Tran Tuan Anh
'Created: 4th March, 2011
'Purpose: This program is to display my personal info.

Public Class frmInformation

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'close form window and exit application
        Me.Close()
    End Sub

    Private Sub btnShowDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDetails.Click
        'display author's name
        lblAuthor.Text = "Anh Tran"

        'display project info. and author's age
        lblAge.Text = "This is my first project in Intro to BIS Dev." & vbCrLf & "I am 20 years old."

        'display author's fullname and location
        lblLocation.Text = "Full name: Tran Tuan Anh" & vbCrLf & "Home country: Vietnam" & vbCrLf & "Suburb: Ho Chi Minh City"
    End Sub
End Class
