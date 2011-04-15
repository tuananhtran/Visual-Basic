'Project: Listbox Example
'Quiz for: Week 5
'Programmer: Tran Tuan Anh
'Created: 28th March, 2011
'Purpose: This program is to add names and ages to two listboxes and find the smallest age from the age listbox

Public Class frmListboxExample

    Private Sub btnAddDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDetails.Click
        'call subroutine to add new element to listboxes
        Call addElement()
    End Sub

    Private Sub btnFindSmallestAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindSmallestAge.Click
        'call subroutine to find smallest value in Age listbox
        Call findSmallestAge()
    End Sub

    Private Sub addElement()
        'declare variables to store input values
        Dim sName As String = txtName.Text
        Dim sAge As String = txtAge.Text

        'validate use input and get input value
        If sName = "" Then
            'if name field is blank, display error message
            MsgBox("Name cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtName.Focus()
            txtName.SelectAll()
        ElseIf IsNumeric(sName) Then
            'if name field is numeric, display error message
            MsgBox("Name cannot be numeric!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtName.Focus()
            txtName.SelectAll()
        ElseIf sAge = "" Then
            'if age field is blank, display error message
            MsgBox("Age cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtAge.Focus()
            txtAge.SelectAll()
        ElseIf Not IsNumeric(sAge) Then
            'if age field is not numeric, display error message
            MsgBox("Age must be numeric!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtAge.Focus()
            txtAge.SelectAll()
        ElseIf CDbl(sAge) - CInt(sAge) <> 0 Then
            'if age field has decimal place(s), display error message
            MsgBox("Age must be a whole number!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtAge.Focus()
            txtAge.SelectAll()
        Else
            'else, add validated input
            lbxNameList.Items.Add(sName)
            lbxAgeList.Items.Add(sAge)
        End If
    End Sub

    Private Sub findSmallestAge()
        If lbxAgeList.Items.Count = 0 Then
            'if there is no item in the list, display error message
            MsgBox("Please insert at least one item to the list to process!", MsgBoxStyle.Exclamation, "Empty List Warning")
        Else
            'declare variable to store output value (smallest age initialized with first age element)
            Dim iMinAge As Integer = CInt(lbxAgeList.Items(0))

            'loop through age list to find smallest age
            For iCounter As Integer = 1 To lbxAgeList.Items.Count - 1
                'if smaller value detected, update iMinAge
                If CInt(lbxAgeList.Items(iCounter)) < iMinAge Then
                    iMinAge = CInt(lbxAgeList.Items(iCounter))
                End If
            Next

            'display result to user
            MsgBox("Smallest age: " & iMinAge, MsgBoxStyle.Information, "Result")
        End If
    End Sub
End Class
