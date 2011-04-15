'Project: Kilos to Pounds Converter
'Quiz for: Week 5
'Programmer: Tran Tuan Anh
'Created: 28th March, 2011
'Purpose: This program is to demo input validation based on the situation of Kilos to Pounds Converter

Public Class frmKilosToPoundsConverter

    Const dKilosToPoundsRate As Double = 2.20462262

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        'Validation rules
        'Number of kilos must be numeric and greater than zero'

        Dim dKilos As Double
        Dim dResult As Double
        Dim bErrorOccurred As Boolean = True
        Dim bInputIsBlank As Boolean = False
        Dim bInputIsNotNumeric As Boolean = False
        Dim bInputIsNegative As Boolean = False

        'check if error occurred
        If txtKilos.Text = "" Then
            'if input is blank, set check variable true
            bInputIsBlank = True
        ElseIf Not IsNumeric(txtKilos.Text) Then
            'if input is not numeric, set check variable true
            bInputIsNotNumeric = True
        ElseIf CDbl(txtKilos.Text) < 0 Then
            'if input is negative, set check variable true
            bInputIsNegative = True
        Else
            'if no error occurred, set check variable false
            bErrorOccurred = False
        End If

        If bErrorOccurred Then
            'if error occurred, display error message accordingly
            If bInputIsBlank Then
                'if input is blank, display error message
                MsgBox("Input cannot be blank!")
            ElseIf bInputIsNotNumeric Then
                'if input is not numeric, display error message
                MsgBox("Input must be numeric!")
            Else
                'if input is negative, display error message
                MsgBox("Input cannot be negative!")
            End If

            'move focus to erroneous field
            txtKilos.Focus()
            txtKilos.SelectAll()
        Else
            'if no error occurred, calculate and display result
            dKilos = CDbl(txtKilos.Text)
            dResult = dKilos * dKilosToPoundsRate
            lblPounds.Text = FormatNumber(dResult)
        End If
    End Sub
End Class