﻿'Project: Sale Calculator
'Lab: Number 7
'Programmer: Tran Tuan Anh
'Created: 13rd April, 2011
'Purpose: This program is to display information and calculate total amount (including tax) of all sales

Public Class frmSaleCalculator

    'declare array to store available items to be sold
    Dim ItemIDs(10) As String
    Dim Descriptions(10) As String
    Dim UnitPrices(10) As Double

    Private Sub frmSaleCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'add dummy data for arrays
        For iCounter As Integer = 0 To ItemIDs.Length - 1
            ItemIDs(iCounter) = "S" & (1000 + iCounter)
            Descriptions(iCounter) = "Item #" & iCounter
            UnitPrices(iCounter) = 1000 + iCounter * 1000
        Next
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        'declare variable to store input validation result
        Dim bDataValid As Boolean

        'call subroutine to validate input
        bDataValid = doValidate()

        'call subroutine to add item to list
        Call doAddItem(bDataValid)
    End Sub

    Private Sub btnTotals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotals.Click
        'call subroutine to calculate total amount
        Call doCalculateTotal()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear all input and ouput fields
        txtItemID.Text = ""
        txtQuantity.Text = ""
        lbxItemID.Items.Clear()
        lbxDescription.Items.Clear()
        lbxQuantity.Items.Clear()
        lbxUnitPrice.Items.Clear()
        lbxSubTotal.Items.Clear()
        lblTotalResult.Text = ""
        lblGSTResult.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'ask if user want to exit
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Exit confirmation") = MsgBoxResult.Yes Then
            'if user choose Yes, close the form and exit application
            Me.Close()
        End If
    End Sub

    Private Function doValidate() As Boolean
        'check if item id is empty
        If txtItemID.Text = "" Then
            'if item id is empty, display error message
            MsgBox("Item ID is required!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtItemID.Focus()

            'notify with failed check
            Return False
        End If

        'check if item id is known
        'loop through item id array to find specified id
        For iCounter As Integer = 0 To ItemIDs.Length - 1
            'if item found, jump to next test
            If ItemIDs(iCounter) = txtItemID.Text Then
                Exit For
            End If

            'if item id is not found after comparing with all available ids, display error message
            If iCounter = ItemIDs.Length - 1 Then
                MsgBox("Item ID is not known!", MsgBoxStyle.Exclamation, "Invalid input value")

                'move focus to erroneous field
                txtItemID.Focus()
                txtItemID.SelectAll()

                'notify with failed check
                Return False
            End If
        Next

        'check if quantity is empty
        If txtQuantity.Text = "" Then
            'if item id is empty, display error message
            MsgBox("Quantity is required!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtQuantity.Focus()

            'notify with failed check
            Return False
        End If

        'check if quantity is numeric
        If Not IsNumeric(txtQuantity.Text) Then
            'if quantity is not numeric, display error message
            MsgBox("Quantity must be numeric!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtQuantity.Focus()
            txtQuantity.SelectAll()

            'notify with failed check
            Return False
        End If

        'check if quantity is positive
        If Not CInt(txtQuantity.Text) > 0 Then
            'if quantity is zero or less, display error message
            MsgBox("Quantity must be a positive number!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtQuantity.Focus()
            txtQuantity.SelectAll()

            'notify with failed check
            Return False
        End If

        'if no error found, indicate passed validation
        Return True
    End Function

    Private Sub doAddItem(ByVal bDataValidated As Boolean)
        'if input is valid, add item to list
        If bDataValidated Then
            'add item id to list
            lbxItemID.Items.Add(txtItemID.Text)

            'add quantity to list
            lbxQuantity.Items.Add(txtQuantity.Text)

            'search for item's description, unit price, calculate sub total and add to list
            For iCounter As Integer = 0 To ItemIDs.Length - 1
                'if item found, get description and unit price to add to list
                If ItemIDs(iCounter) = txtItemID.Text Then
                    lbxDescription.Items.Add(Descriptions(iCounter))
                    lbxUnitPrice.Items.Add(UnitPrices(iCounter))
                    lbxSubTotal.Items.Add(CDbl(txtQuantity.Text) * CDbl(UnitPrices(iCounter)))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub doCalculateTotal()
        'check if there are any items in listboxes
        If lbxSubTotal.Items.Count = 0 Then
            'if there are no items in listboxes, display warning message
            MsgBox("No item has been sold!", MsgBoxStyle.Exclamation, "Cannot calculate totals")

            'move focus to input field to allow user to add new item
            txtItemID.Focus()
            txtItemID.SelectAll()
        Else
            'if there are item(s) in listboxes, calculate total and GST amounts

            'declare variable to store output values
            Dim dRawTotal As Double = 0
            Dim dGST As Double
            Dim dTotal As Double

            'loop through all items in the list Sub Total and add them to raw total
            For iCounter As Integer = 0 To lbxSubTotal.Items.Count - 1
                dRawTotal += CDbl(lbxSubTotal.Items(iCounter))
            Next

            'calculate GST
            dGST = doCalculateGST(dRawTotal)

            'calculate total (including GST)
            dTotal = dRawTotal + dGST

            'display calculate values
            lblTotalResult.Text = FormatCurrency(dTotal)
            lblGSTResult.Text = FormatCurrency(dGST)
        End If
    End Sub

    Private Function doCalculateGST(ByVal dRawTotal As Double) As Double
        Return dRawTotal / 11
    End Function

End Class