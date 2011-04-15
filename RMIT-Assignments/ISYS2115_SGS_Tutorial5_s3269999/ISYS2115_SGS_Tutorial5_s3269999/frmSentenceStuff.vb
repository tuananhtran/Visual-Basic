'Project: Sentence Stuff
'Lab: Number 5
'Programmer: Tran Tuan Anh
'Created: 21st March, 2011
'Purpose: This program is to provide sentence stuffing functionality to the user (repetition, reversion and encryption)

Public Class frmSentenceStuff

    Private Sub frmSentenceStuff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set tooltips to buttons
        ttpRepeatButtonToolTip.SetToolTip(btnRepeatText, "Repeat input text 10 times!")
        ttpReverseButtonToolTip.SetToolTip(btnReverseText, "Reverse input text!")
        ttpEncryptButtonToolTip.SetToolTip(btnEncryptText, "Encrypt input text!")
        ttpExitButtonToolTip.SetToolTip(btnExit, "Exit Sentence Stuff!")
    End Sub

    Private Sub btnRepeatText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepeatText.Click
        'repeat input text 10 times
        Call doRepeat()
    End Sub

    Private Sub btnReverseText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReverseText.Click
        'reverse input text (letter by letter)
        Call doReverse()
    End Sub

    Private Sub btnEncryptText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncryptText.Click
        'encrypt input text (shift each letter by 5 ASCII value)
        Call doEncrypt()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear all fields of the form
        txtInputText.Text = ""
        lblOutputText.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'ask if user want to exit
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Exit Confirmation") = MsgBoxResult.Yes Then
            'if user chooses Yes, then close the form and exit the application
            Me.Close()
        End If
    End Sub

    Private Sub doRepeat()
        'validate if input is blank and display warning message
        If txtInputText.Text = "" Then
            MsgBox("Input cannot be blank!", MsgBoxStyle.Exclamation, "Invalid Input Value")
        Else
            'else, process the input
            'declare variable to store input value
            Dim sInputText As String = txtInputText.Text

            'declare variable to store output value
            Dim sOutputText As String = ""

            'repeat text 10 times
            For iCounter As Integer = 1 To 10
                sOutputText = sOutputText & sInputText
            Next

            'display output value to user
            lblOutputText.Text = sOutputText
        End If
    End Sub

    Private Sub doReverse()
        'validate if input is blank and display warning message
        If txtInputText.Text = "" Then
            MsgBox("Input cannot be blank!", MsgBoxStyle.Exclamation, "Invalid Input Value")
        Else
            'else, process the input
            'variable to store input value
            Dim sInputText As String = txtInputText.Text

            'declare variable to store output value
            Dim sOutputText As String = ""

            'reverse input text
            For iCounter As Integer = Len(sInputText) - 1 To 0 Step -1
                sOutputText = sOutputText & sInputText.Chars(iCounter)
            Next

            'display output value to user
            lblOutputText.Text = sOutputText
        End If
    End Sub

    Private Sub doEncrypt()
        'validate if input is blank and display warning message
        If txtInputText.Text = "" Then
            MsgBox("Input cannot be blank!", MsgBoxStyle.Exclamation, "Invalid Input Value")
        Else
            'else, process the input
            'variable to store input value
            Dim sInputText As String = txtInputText.Text

            'declare variable to store output value
            Dim sOutputText As String = ""

            'declare temp variablefor temporary storage
            Dim iASCIIValue As Integer

            'encrypt input text (shift each letter by 5 position)
            For iCounter As Integer = 0 To Len(sInputText) - 1
                'obtain ascii value and add 5 to it
                iASCIIValue = Asc(sInputText.Chars(iCounter)) + 5

                'convert back to ascii character and add to output string
                sOutputText = sOutputText & Chr(iASCIIValue)
            Next

            'display output value to user
            lblOutputText.Text = sOutputText
        End If
    End Sub
End Class