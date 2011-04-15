Public Class frmMarkAnalyzer

    Private Sub btnAddMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMark.Click
        'validate and get user input
        'validate name input
        If txtName.Text = "" Then
            'if name field is blank, display error message
            MsgBox("Name cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")
            'move focus to erroneous field
            txtName.Focus()
        ElseIf IsNumeric(txtName.Text) Then
            'if name field is numeric, display error message
            MsgBox("Name cannot be numeric!", MsgBoxStyle.Exclamation, "Invalid input value")
            'move focus to erroneous field
            txtName.Focus()
            txtName.SelectAll()
        Else
            'if name field is okay, validate mark input
            If txtMark.Text = "" Then
                'if mark field is blank, display error message
                MsgBox("Mark cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")
                'move focus to erroneous field
                txtMark.Focus()
            ElseIf Not IsNumeric(txtMark.Text) Then
                'if mark field is not numeric, display error message
                MsgBox("Mark must be a number!", MsgBoxStyle.Exclamation, "Invalid input value")
                'move focus to erroneous field
                txtMark.Focus()
                txtMark.SelectAll()
            ElseIf CInt(txtMark.Text) < 0 Then
                'if mark field is negative, display error message
                MsgBox("Mark must be a positive number!", MsgBoxStyle.Exclamation, "Invalid input value")
                'move focus to erroneous field
                txtMark.Focus()
                txtMark.SelectAll()
            ElseIf CDbl(txtMark.Text) - CInt(txtMark.Text) <> 0.0 Then
                'if mark field is not whole, display error message
                MsgBox("Mark must be a whole number!", MsgBoxStyle.Exclamation, "Invalid input value")
                'move focus to erroneous field
                txtMark.Focus()
                txtMark.SelectAll()
            ElseIf CInt(txtMark.Text) > 100 Then
                'if mark field is more than 100, display error message
                MsgBox("Mark cannot exceed 100!", MsgBoxStyle.Exclamation, "Invalid input value")
                'move focus to erroneous field
                txtMark.Focus()
                txtMark.SelectAll()
            Else
                'if all fields are okay, get user input and add to listboxes
                lbxNameList.Items.Add(txtName.Text)
                lbxMarkList.Items.Add(txtMark.Text)
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'call subroutine to calculate average, highest and lowest marks
        Call doCalculations()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear all input, output fields and listboxes
        txtName.Text = ""
        txtMark.Text = ""
        lbxNameList.Items.Clear()
        lbxMarkList.Items.Clear()
        lblAverage.Text = ""
        lblHighest.Text = ""
        lblLowest.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'ask if user want to exit or not
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Exit confirmation") = MsgBoxResult.Yes Then
            'if user choose "Yes", close the firm and exit application
            Me.Close()
        End If
    End Sub

    Private Sub doCalculations()
        'call subroutines to calculate average, highest and lowest marks
        Call getAverage()
        Call getHighest()
        Call getLowest()
    End Sub

    Private Sub getAverage()
        'declare variables to store calculated values
        Dim iNumberOfMarks As Integer = lbxMarkList.Items.Count
        Dim iTotal As Integer = 0
        Dim dAverage As Double = 0

        'loop through mark listbox to add mark to total variable
        For iCounter As Integer = 0 To iNumberOfMarks - 1
            iTotal += CInt(lbxMarkList.Items(iCounter))
        Next

        'calculate average mark
        dAverage = iTotal / iNumberOfMarks

        'display average mark to end-user
        lblAverage.Text = Int(dAverage)
    End Sub

    Private Sub getHighest()
        'declare variables to store temporary and calculated values
        Dim iCounter As Integer = 0
        Dim iHighest As Integer = 0
        Dim iTemp As Integer

        'loop through mark listbox to find highest mark
        While iCounter < lbxMarkList.Items.Count
            'get current pointed mark
            iTemp = CInt(lbxMarkList.Items(iCounter))

            'check if larger mark found and swap with current highest mark (if needed)
            If iTemp > iHighest Then
                iHighest = iTemp
            End If

            'increment iCounter by 1
            iCounter += 1
        End While

        'display highest mark to end-user
        lblHighest.Text = iHighest
    End Sub

    Private Sub getLowest()
        'declare variables to store temporary and calculated values
        Dim iCounter As Integer = 0
        Dim iLowest As Integer = 100
        Dim iTemp As Integer

        'loop through mark listbox to find lowest mark
        Do
            'get current pointed mark
            iTemp = CInt(lbxMarkList.Items(iCounter))

            'check if lower mark found and swap with current lowest mark (if needed)
            If iTemp < iLowest Then
                iLowest = iTemp
            End If

            'increment iCounter by 1
            iCounter += 1
        Loop Until iCounter >= lbxMarkList.Items.Count

        'display lowest mark to end-user
        lblLowest.Text = iLowest
    End Sub

End Class
