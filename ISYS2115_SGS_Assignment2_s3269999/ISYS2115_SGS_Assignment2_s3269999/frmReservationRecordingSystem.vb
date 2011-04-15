'Project: Paradise Reservation Recording System
'Assignment: Number 2
'Programmer: Tran Tuan Anh
'Created: 24th April, 2011
'Purpose: This program is to record and generate report for room bookings of Paradise Beach Resort

'import library for regular expression (RegEx)
Imports System.Text.RegularExpressions

Public Class frmReservationRecordingSystem

    Private Sub frmReservationRecordingSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'display login details of logged in user
        lblStaffIDValue.Text = frmLogin.getStaffID
        lblLocationIDValue.Text = frmLogin.getLocationID

        'set booking date as today
        lblBookingDateValue.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub

    Private Sub btnAddBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBooking.Click
        'check if input data is validated (call subroutine to validate input fields)
        If validateBooking() Then
            'if booking data is validated, add new items to listboxes

            'get booking start and end time
            Dim dtBookingStartTime As Date = CDate(nudBookingStartTimeHour.Value & ":" & nudBookingStartTimeMinute.Value)
            Dim dtBookingEndTime As Date = CDate(nudBookingEndTimeHour.Value & ":" & nudBookingEndTimeMinute.Value)

            'add new booking id, date, start time and end time
            lbxBookingIDs.Items.Add(txtBookingID.Text)
            lbxBookingDates.Items.Add(FormatDateTime(Today, DateFormat.GeneralDate))
            lbxBookingStartTimes.Items.Add(FormatDateTime(dtBookingStartTime, DateFormat.ShortTime))
            lbxBookingEndTimes.Items.Add(FormatDateTime(dtBookingEndTime, DateFormat.ShortTime))

            'add new booking duration in minutes (call subroutine to calculate duration)
            lbxBookingDurations.Items.Add(calculateBookingDuration(dtBookingStartTime, dtBookingEndTime))

            'add new booking cost
            lbxBookingCosts.Items.Add(FormatCurrency(txtBookingCost.Text))
        End If
    End Sub

    Private Sub btnClearBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearBooking.Click
        'clear and reset all input fields of Add Booking Details
        txtBookingID.Text = ""
        nudBookingStartTimeHour.Value = 0
        nudBookingStartTimeMinute.Value = 0
        nudBookingEndTimeHour.Value = 0
        nudBookingEndTimeMinute.Value = 0
        txtBookingCost.Text = ""
    End Sub

    Private Sub btnGetStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetStatistics.Click
        'call subroutine to calculate and display statistics for booking duration
        Call getBookingDurationStatistics()

        'call subroutine to calculate and display statistics for booking cost
        Call getBookingCostStatistics()
    End Sub

    Private Sub btnClearStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearStatistics.Click
        'clear all output statistics
        lblLongestBookingDurationValue.Text = ""
        lblShortestBookingDurationValue.Text = ""
        lblAverageBookingDurationValue.Text = ""
        lblLargestBookingCostValue.Text = ""
        lblSmallestBookingCostValue.Text = ""
        lblAverageBookingCostValue.Text = ""
    End Sub

    Private Sub btnClearBookings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearBookings.Click
        'clear all booking detail listboxes
        lbxBookingIDs.Items.Clear()
        lbxBookingDates.Items.Clear()
        lbxBookingDates.Items.Clear()
        lbxBookingStartTimes.Items.Clear()
        lbxBookingEndTimes.Items.Clear()
        lbxBookingDurations.Items.Clear()
        lbxBookingCosts.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'ask if user want to exit
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel, "Exit confirmation") = MsgBoxResult.Yes Then
            'if user choose "Yes", close the main form and exit the application
            Me.Close()
            frmLogin.Close()
        End If
    End Sub

    'subroutine to check and return booking data validation result
    Private Function validateBooking() As Boolean
        'declare regular expression variable to validate booking id input
        Dim bookingIDRegEx As Regex = New Regex("^WWB[\d]{4,5}(HH|TN)$")

        'validate booking id
        If Not bookingIDRegEx.IsMatch(txtBookingID.Text) Then
            'if booking id is in wrong format, display error message
            MsgBox("Invalid Booking ID!" & vbCrLf & "Correct patter: WWBxxxxHH, WWBxxxxTN, WWBxxxxxTN, WWBxxxxxHH (x is a number)", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtBookingID.Focus()
            txtBookingID.SelectAll()

            'indicate failed validation
            Return False
        End If

        'declare variables to store booking start and end time
        Dim dtBookingStartTime As Date = CDate(nudBookingStartTimeHour.Value & ":" & nudBookingStartTimeMinute.Value)
        Dim dtBookingEndTime As Date = CDate(nudBookingEndTimeHour.Value & ":" & nudBookingEndTimeMinute.Value)

        'validate booking (end) time
        If DateDiff(DateInterval.Minute, dtBookingStartTime, dtBookingEndTime) <= 0 Then
            'if booking end time is not after booking start time, display error message
            MsgBox("Booking End Time must be after Booking Start Time!", MsgBoxStyle.Exclamation, "Invalid input value")

            'indicate failed validation
            Return False
        End If

        'validate booking cost
        'check if booking cost is not blank
        If txtBookingCost.Text = "" Then
            'if booking cost is blank, display error message
            MsgBox("Booking Cost cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtBookingCost.Focus()
            txtBookingCost.SelectAll()

            'indicate failed validation
            Return False
        End If
        'check if booking cost is numeric
        If Not IsNumeric(txtBookingCost.Text) Then
            'if booking cost is not numeric, display error message
            MsgBox("Booking Cost must be a numeric!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtBookingCost.Focus()
            txtBookingCost.SelectAll()

            'indicate failed validation
            Return False
        End If
        'check if booking cost is at least $127.50
        If CDbl(txtBookingCost.Text) < 127.5 Then
            'if booking cost is less than $127.50, display error message
            MsgBox("Booking Cost cannot be less than $127.50!", MsgBoxStyle.Exclamation, "Invalid input value")

            'move focus to erroneous field
            txtBookingCost.Focus()
            txtBookingCost.SelectAll()

            'indicate failed validation
            Return False
        End If

        'if no errors found, indicate passed validation
        Return True
    End Function

    'subroutine to calculate booking duration (in minutes)
    Private Function calculateBookingDuration(ByVal dtStartTime As Date, ByVal dtEndTime As Date) As Long
        Return DateDiff(DateInterval.Minute, dtStartTime, dtEndTime)
    End Function

    'subroutine to calculate and display booking duration statistics
    Private Sub getBookingDurationStatistics()
        'check if there are any bookings in the list
        If lbxBookingIDs.Items.Count = 0 Then
            'if no bookings inserted yet, display error message
            MsgBox("No booking details entered yet!", MsgBoxStyle.Exclamation, "Missing data required")

            'move focus to booking id field to allow user to enter new booking
            txtBookingID.Focus()
            txtBookingID.SelectAll()
        Else
            'else, calculate and display statistics

            'declare and initialize variables to store temporary and output values
            Dim lLongestBookingDuration As Long = CLng(lbxBookingDurations.Items(0))
            Dim lShortestBookingDuration As Long = CLng(lbxBookingDurations.Items(0))
            Dim lAverageBookingDuration As Long
            Dim lTotalBookingDuration As Long = CLng(lbxBookingDurations.Items(0))

            'loop through booking duration listbox to get statistic values
            For iCounter As Integer = 1 To lbxBookingDurations.Items.Count - 1
                'if longer booking duration found, update currently longest booking time
                If lbxBookingDurations.Items(iCounter) > lLongestBookingDuration Then
                    lLongestBookingDuration = CLng(lbxBookingDurations.Items(iCounter))
                End If

                'if shorter booking duration found, update currently shortest booking time
                If lbxBookingDurations.Items(iCounter) < lShortestBookingDuration Then
                    lShortestBookingDuration = CLng(lbxBookingDurations.Items(iCounter))
                End If

                'increment total booking duration by current pointed item in the list
                lTotalBookingDuration += CLng(lbxBookingDurations.Items(iCounter))
            Next

            'calculate average booking duration
            lAverageBookingDuration = lTotalBookingDuration \ lbxBookingDurations.Items.Count

            'display statistics
            lblLongestBookingDurationValue.Text = lLongestBookingDuration & " minutes"
            lblShortestBookingDurationValue.Text = lShortestBookingDuration & " minutes"
            lblAverageBookingDurationValue.Text = lAverageBookingDuration & " minutes"
        End If
    End Sub

    'subroutine to calculate and display booking cost statistics
    Private Sub getBookingCostStatistics()
        'check if there are any bookings in the list
        If lbxBookingCosts.Items.Count <> 0 Then
            'if there are bookings in the list, calculate and display statistics

            'declare and initialize variables to store temporary and output values
            Dim dLargestBookingCost As Double = CDbl(lbxBookingCosts.Items(0))
            Dim dSmallestBookingCost As Double = CDbl(lbxBookingCosts.Items(0))
            Dim dAverageBookingCost As Double
            Dim dTotalBookingCost As Double = CDbl(lbxBookingCosts.Items(0))

            'loop through booking duration listbox to get statistic values
            For iCounter As Integer = 1 To lbxBookingCosts.Items.Count - 1
                'if larger booking cost found, update currently largest booking cost
                If lbxBookingCosts.Items(iCounter) > dLargestBookingCost Then
                    dLargestBookingCost = CDbl(lbxBookingCosts.Items(iCounter))
                End If

                'if smaller booking cost found, update currently smallest booking cost
                If lbxBookingCosts.Items(iCounter) < dSmallestBookingCost Then
                    dSmallestBookingCost = CDbl(lbxBookingCosts.Items(iCounter))
                End If

                'increment total booking coost by current pointed item in the list
                dTotalBookingCost += CDbl(lbxBookingCosts.Items(iCounter))
            Next

            'calculate average booking cost
            dAverageBookingCost = dTotalBookingCost / lbxBookingCosts.Items.Count

            'display statistics
            lblLargestBookingCostValue.Text = FormatCurrency(dLargestBookingCost)
            lblSmallestBookingCostValue.Text = FormatCurrency(dSmallestBookingCost)
            lblAverageBookingCostValue.Text = FormatCurrency(dAverageBookingCost)
        End If
    End Sub

End Class
