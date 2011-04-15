'Project: Paradise Booking Cost Calculator
'Assignment: Number 1
'Programmer: Tran Tuan Anh
'Created: 21st March, 2011
'Purpose: This program is to calculate the cost for particular room types and
'         number of people in each booking of Paradise resort. The program is
'         created to be used by Paradise's staff.

Public Class frmBookingCostCalculator

    Private Sub frmBookingCostCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set minimum date/time as today/current time for booking date and arrival date
        lblBookingDate.Text = FormatDateTime(Today, DateFormat.LongDate)
        dtpArrivalDate.MinDate = Today

        'set default arrival time value
        cbArrivalTime.SelectedIndex = 0
    End Sub

    Private Sub cbxAirportPickupOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxAirportPickupOption.CheckedChanged
        'enable/disable option according to user choice
        lblAirportPickupCost.Enabled = cbxAirportPickupOption.Checked
    End Sub

    Private Sub cbxRedeemedAirMilesOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxRedeemedAirMilesOption.CheckedChanged
        'enable/disable option according to user choice
        txtRedeemedAirMiles.Enabled = cbxRedeemedAirMilesOption.Checked
    End Sub

    Private Sub cbxMembershipCardOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMembershipCardOption.CheckedChanged
        'enable/disable option according to user choice
        txtMembershipCardNumber.Enabled = cbxMembershipCardOption.Checked
    End Sub

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click
        'check if number of rooms booked is already 3 or not
        If dgvBookingInformation.Rows.Count = 3 Then
            'if 3 rooms reserved, display warning message
            MsgBox("Each customer can book maximum 3 rooms!", MsgBoxStyle.Exclamation, "Cannot book more room")
        Else
            'else, add more room booking record to database
            Dim iNewRowIndex As Integer = dgvBookingInformation.Rows.Add()

            'set default value for comboboxes
            dgvBookingInformation.Rows(iNewRowIndex).Cells(0).Value = "Superior"
            dgvBookingInformation.Rows(iNewRowIndex).Cells(1).Value = "1"
            dgvBookingInformation.Rows(iNewRowIndex).Cells(2).Value = "1"
            dgvBookingInformation.Rows(iNewRowIndex).Cells(3).Value = "0"
            dgvBookingInformation.Rows(iNewRowIndex).Cells(4).Value = FormatCurrency(150)
            dgvBookingInformation.Rows(iNewRowIndex).Cells(5).Value = FormatCurrency(0)
            dgvBookingInformation.Rows(iNewRowIndex).Cells(6).Value = FormatCurrency(150)
        End If
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'calculate booking cost and report result to user

        If txtFullname.Text = "" Then
            'if fullname is blank, display error message
            MsgBox("Fullname cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous location
            txtFullname.Focus()
        ElseIf IsNumeric(txtFullname.Text) Then
            'if fullname is numeric, display error message
            MsgBox("Fullname cannot be numberic!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous location
            txtFullname.Focus()
            txtFullname.SelectAll()
        ElseIf dgvBookingInformation.Rows.Count = 0 Then
            'if no room booked, display error message
            MsgBox("At least a room must be booked to proceed!", MsgBoxStyle.Exclamation, "Invalid input value")
        Else
            If cbxRedeemedAirMilesOption.Checked Then
                'if air miles redemption option check

                If txtRedeemedAirMiles.Text = "" Then
                    'if redeemed air miles field is blank, display error message
                    MsgBox("Redeemed Air Miles cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")

                    'move focus to errorneous location
                    txtRedeemedAirMiles.Focus()
                    Return
                ElseIf Not IsNumeric(txtRedeemedAirMiles.Text) Then
                    'if redeemed air miles field is not input with number, display error message
                    MsgBox("Please input a number for Redeemed Air Miles!", MsgBoxStyle.Exclamation, "Invalid input value")

                    'move focus to errorneous location
                    txtRedeemedAirMiles.Focus()
                    txtRedeemedAirMiles.SelectAll()
                    Return
                ElseIf CInt(txtRedeemedAirMiles.Text) < 0 Then
                    'if redeemed air miles field is less than 0, display error message
                    MsgBox("Please input a positive number for Redeemed Air Miles!", MsgBoxStyle.Exclamation, "Invalid input value")

                    'move focus to erroneous location
                    txtRedeemedAirMiles.Focus()
                    txtRedeemedAirMiles.SelectAll()
                    Return
                End If
            End If

            If cbxMembershipCardOption.Checked Then
                'if membership card option check

                If txtMembershipCardNumber.Text = "" Then
                    'if membership card number field is blank, display error message
                    MsgBox("Membership Card Number cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")

                    'move focus to errorneous location
                    txtMembershipCardNumber.Focus()
                    Return
                ElseIf Not IsNumeric(txtMembershipCardNumber.Text) Then
                    'if membership card number field is not input with number, display error message
                    MsgBox("Please input a number for Membership Card Number!", MsgBoxStyle.Exclamation, "Invalid input value")

                    'move focus to errorneous location
                    txtMembershipCardNumber.Focus()
                    txtMembershipCardNumber.SelectAll()
                    Return
                End If
            End If

            Call doCalculate()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear and reset all input fields to default values
        txtFullname.Text = ""
        dtpArrivalDate.Value = Today
        cbArrivalTime.SelectedIndex = 0
        cbxAirportPickupOption.Checked = False
        txtRedeemedAirMiles.Text = ""
        cbxRedeemedAirMilesOption.Checked = False
        txtMembershipCardNumber.Text = ""
        cbxMembershipCardOption.Checked = False
        dgvBookingInformation.Rows.Clear()

        'clear all output fields
        lblTotalRoomCost.Text = ""
        lblServiceCost.Text = ""
        lblTaxCharge.Text = ""
        lblAirRedeemAmount.Text = ""
        lblMemberDiscountAmount.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'display message box to ask if user want to exit or not
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Exit confirmation") = MsgBoxResult.Yes Then
            'if user chooses Yes, then close the form and exit the applicaiton
            Me.Close()
        End If
    End Sub

    Private Sub dgvBookingInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBookingInformation.CellContentClick
        'if Remove button is clicked, remove corresponding record from database
        If e.ColumnIndex = dgvBookingInformation.Columns.Count - 1 Then
            dgvBookingInformation.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub dgvBookingInformation_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBookingInformation.CellEndEdit
        'change values of rates per night, extra bed and basic room cost fields accordingly to comboboxes' values

        'declare variables to store current values and updated values
        Dim sTempRoomType As String = dgvBookingInformation.Rows(e.RowIndex).Cells(0).Value
        Dim iTempNumberOfNights As Integer = CInt(dgvBookingInformation.Rows(e.RowIndex).Cells(1).Value)
        Dim iTempNumberOfAdults As Integer = CInt(dgvBookingInformation.Rows(e.RowIndex).Cells(2).Value)
        Dim iTempNumberOfChildren As Integer = CInt(dgvBookingInformation.Rows(e.RowIndex).Cells(3).Value)
        Dim iTempExtraBed As Integer = CInt(dgvBookingInformation.Rows(e.RowIndex).Cells(5).Value)
        Dim sTempRatesPerNight As String
        Dim sTempExtraBed As String = FormatCurrency(0)
        Dim sTempBasicRoomCost As String

        If e.ColumnIndex = 0 Then
            'if room type changed, update rates per night and extra bed fields



            'UPDATE RATES PER NIGHT FIELD

            'set rates per night based on specified room type
            If sTempRoomType = "Superior" Then
                sTempRatesPerNight = FormatCurrency(150)
            ElseIf sTempRoomType = "Deluxe" Then
                sTempRatesPerNight = FormatCurrency(178)
            ElseIf sTempRoomType = "Premium Deluxe" Then
                sTempRatesPerNight = FormatCurrency(238)
            ElseIf sTempRoomType = "Junior Suite" Then
                sTempRatesPerNight = FormatCurrency(400)
            ElseIf sTempRoomType = "Presidential Suite" Then
                sTempRatesPerNight = FormatCurrency(780)
            ElseIf sTempRoomType = "One Bedroom Villa" Then
                sTempRatesPerNight = FormatCurrency(350)
            Else
                sTempRatesPerNight = FormatCurrency(490)
            End If



            'UPDATE EXTRA BED FIELD

            If iTempNumberOfAdults + iTempNumberOfChildren > 4 Then
                'if number of persons is more than 4
                If sTempRoomType = "Presidential Suite" Then
                    'if room type is Presidential Suite
                    If iTempNumberOfAdults > 4 Then
                        'if number of adults is more than 4, update extra bed cost
                        sTempExtraBed = FormatCurrency(iTempNumberOfNights * 45)
                    End If
                Else
                    'if room type is not Presidential Suite, display warning message
                    MsgBox("Only Prsidential Suite allows number of persons per room to be more than 4!", MsgBoxStyle.Exclamation, "Cannot change to other room type")

                    'reset room type to Presidential Suite
                    dgvBookingInformation.Rows(e.RowIndex).Cells(0).Value = "Presidential Suite"
                End If
            Else
                If sTempRoomType = "One Bedroom Villa" Then
                    'if room type is One Bedroom Villa

                    If iTempNumberOfAdults > 2 Then
                        'if there are more than 2 adults in this room, display warning message
                        MsgBox("Cannot have more than 2 adults in this room!", MsgBoxStyle.Exclamation, "Number of adults exceeded")

                        'reset number of adults to 1
                        dgvBookingInformation.Rows(e.RowIndex).Cells(2).Value = "1"
                    End If

                    If iTempNumberOfChildren <> 0 Then
                        'if there are children in this room, display warning message
                        MsgBox("Cannot have children in this room!", MsgBoxStyle.Exclamation, "Children not allowed")

                        'reset number of children to 0
                        dgvBookingInformation.Rows(e.RowIndex).Cells(3).Value = "0"
                    End If
                ElseIf sTempRoomType = "Two Bedroom Villa" Then
                    'if room type is Two Bedrrom Villa

                    If iTempNumberOfAdults > 4 Then
                        'if there are more than 4 adults in this room, display warning message
                        MsgBox("Cannot have more than 4 adults in this room!", MsgBoxStyle.Exclamation, "Number of adults exceeded")

                        'reset number of adults to 1
                        dgvBookingInformation.Rows(e.RowIndex).Cells(2).Value = "1"
                    End If

                    If iTempNumberOfChildren <> 0 Then
                        'if there are children in this room, display warning message
                        MsgBox("Cannot have children in this room!", MsgBoxStyle.Exclamation, "Children not allowed")

                        'reset number of children to 0
                        dgvBookingInformation.Rows(e.RowIndex).Cells(3).Value = "0"
                    End If
                ElseIf sTempRoomType <> "Presidential Suite" Then
                    'for other room types (other from Presidential Suite)
                    If iTempNumberOfAdults > 2 Then
                        'if number of adults is more than 2, update extra bed cost
                        sTempExtraBed = FormatCurrency(iTempNumberOfNights * 45)
                    End If
                End If
            End If



            'UPDATE DATA GRID VIEW
            dgvBookingInformation.Rows(e.RowIndex).Cells(4).Value = sTempRatesPerNight
            dgvBookingInformation.Rows(e.RowIndex).Cells(5).Value = sTempExtraBed
        ElseIf e.ColumnIndex = 1 Then
            'if number of nights changed, update extra bed field

            'check if extra bed is used
            If iTempExtraBed <> 0 Then
                'if extra bed used, update extra bed cost
                sTempExtraBed = FormatCurrency(iTempNumberOfNights * 45)

                'update extra bed field in data grid view
                dgvBookingInformation.Rows(e.RowIndex).Cells(5).Value = sTempExtraBed
            End If
        ElseIf e.ColumnIndex = 2 Then
            'if number of adults changed, update extra bed field

            'if number of adults over 2 for the first 4 room types
            If sTempRoomType = "Superior" Or sTempRoomType = "Deluxe" Or sTempRoomType = "Premium Deluxe" Or sTempRoomType = "Junior Suite" Then
                If iTempNumberOfAdults + iTempNumberOfChildren > 4 Then
                    'if there are more than 4 persons in this room, display warning message and reset number of adults
                    MsgBox("Number of persons for this room type cannot be larger than 4!", MsgBoxStyle.Exclamation, "Cannot add more adults to room")
                    dgvBookingInformation.Rows(e.RowIndex).Cells(2).Value = "1"
                ElseIf iTempNumberOfAdults > 2 Then
                    'if total number of persons is not over 4 and there are more than 2 adults in room, update extra bed cost
                    sTempExtraBed = FormatCurrency(iTempNumberOfNights * 45)
                End If
            ElseIf sTempRoomType = "Presidential Suite" Then
                'if number of adult is over 4 for room type Presidential Suite, update extra bed field
                If iTempNumberOfAdults > 4 Then
                    sTempExtraBed = FormatCurrency(iTempNumberOfNights * 45)
                End If
            ElseIf sTempRoomType = "One Bedroom Villa" Then
                'if number of adult is over 2 for room type One Bedroom Villa
                If iTempNumberOfAdults > 2 Then
                    'display warning message
                    MsgBox("Cannot have more than 2 adults in this room!", MsgBoxStyle.Exclamation, "Number of adults exceeded")

                    'reset number of adults to 1
                    dgvBookingInformation.Rows(e.RowIndex).Cells(2).Value = "1"
                End If

                If iTempNumberOfChildren <> 0 Then
                    'if there are children in this roo,, display warning message
                    MsgBox("Cannot have children in this room!", MsgBoxStyle.Exclamation, "Children not allowed")

                    'reset number of children to 0
                    dgvBookingInformation.Rows(e.RowIndex).Cells(3).Value = "0"
                End If
            ElseIf sTempRoomType = "Two Bedroom Villa" Then
                'if number of adult is over 4 for room type One Bedroom Villa
                If iTempNumberOfAdults > 4 Then
                    'display warning message
                    MsgBox("Cannot have more than 4 adults in this room!", MsgBoxStyle.Exclamation, "Number of adults exceeded")

                    'reset number of adults to 1
                    dgvBookingInformation.Rows(e.RowIndex).Cells(2).Value = "1"
                End If

                If iTempNumberOfChildren <> 0 Then
                    'if there are children in this roo,, display warning message
                    MsgBox("Cannot have children in this room!", MsgBoxStyle.Exclamation, "Children not allowed")

                    'reset number of children to 0
                    dgvBookingInformation.Rows(e.RowIndex).Cells(3).Value = "0"
                End If
            End If

            'update extra bed field in data grid view
            dgvBookingInformation.Rows(e.RowIndex).Cells(5).Value = sTempExtraBed
        ElseIf e.ColumnIndex = 3 Then
            'if number of children changed, check if it is valid for current room type

            If iTempNumberOfChildren <> 0 Then
                'if number of children is different from 0
                If sTempRoomType = "One Bedroom Villa" Or sTempRoomType = "Two Bedroom Villa" Then
                    'if room type is currently a Villa, display warning message
                    MsgBox("Cannot have children in this type of room!", MsgBoxStyle.Exclamation, "Children not allowed")

                    'reset number of children to 0
                    dgvBookingInformation.Rows(e.RowIndex).Cells(3).Value = "0"
                ElseIf sTempRoomType <> "Presidential Suite" Then
                    'if room type is other type (other from Presidential Suite)
                    If iTempNumberOfAdults + iTempNumberOfChildren > 4 Then
                        'if number of persons is over 4, display warning message
                        MsgBox("Only 4 persons are allowed in this room!", MsgBoxStyle.Exclamation, "Number of persons over limitation")

                        'reset number of children to 0
                        dgvBookingInformation.Rows(e.RowIndex).Cells(3).Value = "0"
                    End If
                End If
            End If
        End If

        'get updated values of fields
        iTempNumberOfNights = CInt(dgvBookingInformation.Rows(e.RowIndex).Cells(1).Value)
        Dim iTempRatesPerNight As Integer = CInt(dgvBookingInformation.Rows(e.RowIndex).Cells(4).Value)
        iTempExtraBed = CInt(dgvBookingInformation.Rows(e.RowIndex).Cells(5).Value)

        'update basic room cost
        sTempBasicRoomCost = FormatCurrency(iTempNumberOfNights * iTempRatesPerNight + iTempExtraBed)

        'update basic room cost field in data grid view
        dgvBookingInformation.Rows(e.RowIndex).Cells(6).Value = sTempBasicRoomCost
    End Sub

    Private Sub doCalculate()
        'declare variables to store input values
        Dim dServiceCost As Double = 0
        Dim dAirRedeemAmount As Double = 0
        Dim dMemberDiscountAmount As Double = 0
        Dim dTotal As Double = 0
        Dim dTotalRoomCost As Double = 0
        Dim dTaxCharge As Double = 0
        Dim dSubTotal1 As Double = 0
        Dim dSubTotal2 As Double = 0

        'calculate total room cost
        For iCounter As Integer = 1 To dgvBookingInformation.Rows.Count
            dTotalRoomCost = dTotalRoomCost + CDbl(dgvBookingInformation.Rows(iCounter - 1).Cells(6).Value)
        Next

        'calculate air pick-up service cost
        If cbxAirportPickupOption.Checked Then
            dServiceCost = CDbl(lblAirportPickupCost.Text)
        End If

        'calculate sub total 1
        dSubTotal1 = dTotalRoomCost + dServiceCost

        'calculate tax
        dTaxCharge = 0.15 * dSubTotal1

        'calculate sub total 2
        dSubTotal2 = dSubTotal1 + dTaxCharge

        'calculate air miles redemption amount
        If cbxRedeemedAirMilesOption.Checked Then
            If CInt(txtRedeemedAirMiles.Text) > 1000 Then
                dAirRedeemAmount = 0.1 * dSubTotal2
            Else
                dAirRedeemAmount = 0.05 * dSubTotal2
            End If
        End If

        'calculate membership discount amount
        If cbxMembershipCardOption.Checked Then
            dMemberDiscountAmount = 0.1 * dSubTotal2
        End If

        'calculate total cost
        dTotal = dSubTotal2 - dAirRedeemAmount - dMemberDiscountAmount

        'display result to user
        lblTotalRoomCost.Text = FormatCurrency(dTotalRoomCost)
        lblServiceCost.Text = FormatCurrency(dServiceCost)
        lblTaxCharge.Text = FormatCurrency(dTaxCharge)
        lblAirRedeemAmount.Text = FormatCurrency(dAirRedeemAmount)
        lblMemberDiscountAmount.Text = FormatCurrency(dMemberDiscountAmount)
        lblTotal.Text = FormatCurrency(dTotal)
    End Sub
End Class
