<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationRecordingSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCurrentLoginDetails = New System.Windows.Forms.GroupBox
        Me.lblLocationIDValue = New System.Windows.Forms.Label
        Me.lblStaffIDValue = New System.Windows.Forms.Label
        Me.lblLocationID = New System.Windows.Forms.Label
        Me.lblStaffID = New System.Windows.Forms.Label
        Me.grpAddBookDetails = New System.Windows.Forms.GroupBox
        Me.btnClearBooking = New System.Windows.Forms.Button
        Me.btnAddBooking = New System.Windows.Forms.Button
        Me.txtBookingCost = New System.Windows.Forms.TextBox
        Me.nudBookingEndTimeMinute = New System.Windows.Forms.NumericUpDown
        Me.nudBookingEndTimeHour = New System.Windows.Forms.NumericUpDown
        Me.nudBookingStartTimeMinute = New System.Windows.Forms.NumericUpDown
        Me.nudBookingStartTimeHour = New System.Windows.Forms.NumericUpDown
        Me.lblBookingDateValue = New System.Windows.Forms.Label
        Me.txtBookingID = New System.Windows.Forms.TextBox
        Me.lblBookingCost = New System.Windows.Forms.Label
        Me.lblBookingEndTime = New System.Windows.Forms.Label
        Me.lblBookingStartTime = New System.Windows.Forms.Label
        Me.lblBookingDate = New System.Windows.Forms.Label
        Me.lblBookingID = New System.Windows.Forms.Label
        Me.grpBookings = New System.Windows.Forms.GroupBox
        Me.lbxBookingCosts = New System.Windows.Forms.ListBox
        Me.lbxBookingDurations = New System.Windows.Forms.ListBox
        Me.lbxBookingEndTimes = New System.Windows.Forms.ListBox
        Me.lbxBookingStartTimes = New System.Windows.Forms.ListBox
        Me.lbxBookingDates = New System.Windows.Forms.ListBox
        Me.lbxBookingIDs = New System.Windows.Forms.ListBox
        Me.lblBookingCosts = New System.Windows.Forms.Label
        Me.lblBookingDurations = New System.Windows.Forms.Label
        Me.lblBookingEndTimes = New System.Windows.Forms.Label
        Me.lblBookingStartTimes = New System.Windows.Forms.Label
        Me.lblBookingDates = New System.Windows.Forms.Label
        Me.lblBookingIDs = New System.Windows.Forms.Label
        Me.grpBookingsManagement = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClearBookings = New System.Windows.Forms.Button
        Me.btnClearStatistics = New System.Windows.Forms.Button
        Me.btnGetStatistics = New System.Windows.Forms.Button
        Me.grpSummaryStatistics = New System.Windows.Forms.GroupBox
        Me.lblAverageBookingCostValue = New System.Windows.Forms.Label
        Me.lblAverageBookingCost = New System.Windows.Forms.Label
        Me.lblSmallestBookingCostValue = New System.Windows.Forms.Label
        Me.lblSmallestBookingCost = New System.Windows.Forms.Label
        Me.lblLargestBookingCostValue = New System.Windows.Forms.Label
        Me.lblLargestBookingCost = New System.Windows.Forms.Label
        Me.lblAverageBookingDurationValue = New System.Windows.Forms.Label
        Me.lblAverageBookingDuration = New System.Windows.Forms.Label
        Me.lblShortestBookingDurationValue = New System.Windows.Forms.Label
        Me.lblShortestBookingDuration = New System.Windows.Forms.Label
        Me.lblLongestBookingDurationValue = New System.Windows.Forms.Label
        Me.lblLongestBookingDuration = New System.Windows.Forms.Label
        Me.grpCurrentLoginDetails.SuspendLayout()
        Me.grpAddBookDetails.SuspendLayout()
        CType(Me.nudBookingEndTimeMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBookingEndTimeHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBookingStartTimeMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBookingStartTimeHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBookings.SuspendLayout()
        Me.grpBookingsManagement.SuspendLayout()
        Me.grpSummaryStatistics.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCurrentLoginDetails
        '
        Me.grpCurrentLoginDetails.Controls.Add(Me.lblLocationIDValue)
        Me.grpCurrentLoginDetails.Controls.Add(Me.lblStaffIDValue)
        Me.grpCurrentLoginDetails.Controls.Add(Me.lblLocationID)
        Me.grpCurrentLoginDetails.Controls.Add(Me.lblStaffID)
        Me.grpCurrentLoginDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpCurrentLoginDetails.Name = "grpCurrentLoginDetails"
        Me.grpCurrentLoginDetails.Size = New System.Drawing.Size(306, 114)
        Me.grpCurrentLoginDetails.TabIndex = 0
        Me.grpCurrentLoginDetails.TabStop = False
        Me.grpCurrentLoginDetails.Text = "Current Login Details"
        '
        'lblLocationIDValue
        '
        Me.lblLocationIDValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLocationIDValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocationIDValue.Location = New System.Drawing.Point(116, 68)
        Me.lblLocationIDValue.Name = "lblLocationIDValue"
        Me.lblLocationIDValue.Size = New System.Drawing.Size(165, 24)
        Me.lblLocationIDValue.TabIndex = 3
        Me.lblLocationIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStaffIDValue
        '
        Me.lblStaffIDValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStaffIDValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffIDValue.Location = New System.Drawing.Point(116, 32)
        Me.lblStaffIDValue.Name = "lblStaffIDValue"
        Me.lblStaffIDValue.Size = New System.Drawing.Size(165, 24)
        Me.lblStaffIDValue.TabIndex = 1
        Me.lblStaffIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLocationID
        '
        Me.lblLocationID.AutoSize = True
        Me.lblLocationID.Location = New System.Drawing.Point(17, 72)
        Me.lblLocationID.Name = "lblLocationID"
        Me.lblLocationID.Size = New System.Drawing.Size(75, 16)
        Me.lblLocationID.TabIndex = 2
        Me.lblLocationID.Text = "Location ID"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(17, 36)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(50, 16)
        Me.lblStaffID.TabIndex = 0
        Me.lblStaffID.Text = "Staff ID"
        '
        'grpAddBookDetails
        '
        Me.grpAddBookDetails.Controls.Add(Me.btnClearBooking)
        Me.grpAddBookDetails.Controls.Add(Me.btnAddBooking)
        Me.grpAddBookDetails.Controls.Add(Me.txtBookingCost)
        Me.grpAddBookDetails.Controls.Add(Me.nudBookingEndTimeMinute)
        Me.grpAddBookDetails.Controls.Add(Me.nudBookingEndTimeHour)
        Me.grpAddBookDetails.Controls.Add(Me.nudBookingStartTimeMinute)
        Me.grpAddBookDetails.Controls.Add(Me.nudBookingStartTimeHour)
        Me.grpAddBookDetails.Controls.Add(Me.lblBookingDateValue)
        Me.grpAddBookDetails.Controls.Add(Me.txtBookingID)
        Me.grpAddBookDetails.Controls.Add(Me.lblBookingCost)
        Me.grpAddBookDetails.Controls.Add(Me.lblBookingEndTime)
        Me.grpAddBookDetails.Controls.Add(Me.lblBookingStartTime)
        Me.grpAddBookDetails.Controls.Add(Me.lblBookingDate)
        Me.grpAddBookDetails.Controls.Add(Me.lblBookingID)
        Me.grpAddBookDetails.Location = New System.Drawing.Point(324, 12)
        Me.grpAddBookDetails.Name = "grpAddBookDetails"
        Me.grpAddBookDetails.Size = New System.Drawing.Size(504, 275)
        Me.grpAddBookDetails.TabIndex = 1
        Me.grpAddBookDetails.TabStop = False
        Me.grpAddBookDetails.Text = "AddBookingDetails"
        '
        'btnClearBooking
        '
        Me.btnClearBooking.Location = New System.Drawing.Point(356, 220)
        Me.btnClearBooking.Name = "btnClearBooking"
        Me.btnClearBooking.Size = New System.Drawing.Size(131, 31)
        Me.btnClearBooking.TabIndex = 13
        Me.btnClearBooking.Text = "&Clear Booking"
        Me.btnClearBooking.UseVisualStyleBackColor = True
        '
        'btnAddBooking
        '
        Me.btnAddBooking.Location = New System.Drawing.Point(209, 220)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(131, 31)
        Me.btnAddBooking.TabIndex = 12
        Me.btnAddBooking.Text = "&Add Booking"
        Me.btnAddBooking.UseVisualStyleBackColor = True
        '
        'txtBookingCost
        '
        Me.txtBookingCost.Location = New System.Drawing.Point(175, 183)
        Me.txtBookingCost.Name = "txtBookingCost"
        Me.txtBookingCost.Size = New System.Drawing.Size(312, 22)
        Me.txtBookingCost.TabIndex = 11
        '
        'nudBookingEndTimeMinute
        '
        Me.nudBookingEndTimeMinute.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudBookingEndTimeMinute.Location = New System.Drawing.Point(336, 147)
        Me.nudBookingEndTimeMinute.Maximum = New Decimal(New Integer() {45, 0, 0, 0})
        Me.nudBookingEndTimeMinute.Name = "nudBookingEndTimeMinute"
        Me.nudBookingEndTimeMinute.Size = New System.Drawing.Size(151, 22)
        Me.nudBookingEndTimeMinute.TabIndex = 9
        '
        'nudBookingEndTimeHour
        '
        Me.nudBookingEndTimeHour.Location = New System.Drawing.Point(175, 147)
        Me.nudBookingEndTimeHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudBookingEndTimeHour.Name = "nudBookingEndTimeHour"
        Me.nudBookingEndTimeHour.Size = New System.Drawing.Size(155, 22)
        Me.nudBookingEndTimeHour.TabIndex = 8
        '
        'nudBookingStartTimeMinute
        '
        Me.nudBookingStartTimeMinute.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudBookingStartTimeMinute.Location = New System.Drawing.Point(336, 110)
        Me.nudBookingStartTimeMinute.Maximum = New Decimal(New Integer() {45, 0, 0, 0})
        Me.nudBookingStartTimeMinute.Name = "nudBookingStartTimeMinute"
        Me.nudBookingStartTimeMinute.Size = New System.Drawing.Size(151, 22)
        Me.nudBookingStartTimeMinute.TabIndex = 6
        '
        'nudBookingStartTimeHour
        '
        Me.nudBookingStartTimeHour.Location = New System.Drawing.Point(175, 110)
        Me.nudBookingStartTimeHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudBookingStartTimeHour.Name = "nudBookingStartTimeHour"
        Me.nudBookingStartTimeHour.Size = New System.Drawing.Size(155, 22)
        Me.nudBookingStartTimeHour.TabIndex = 5
        '
        'lblBookingDateValue
        '
        Me.lblBookingDateValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBookingDateValue.Location = New System.Drawing.Point(175, 73)
        Me.lblBookingDateValue.Name = "lblBookingDateValue"
        Me.lblBookingDateValue.Size = New System.Drawing.Size(312, 22)
        Me.lblBookingDateValue.TabIndex = 3
        Me.lblBookingDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBookingID
        '
        Me.txtBookingID.Location = New System.Drawing.Point(175, 37)
        Me.txtBookingID.Name = "txtBookingID"
        Me.txtBookingID.Size = New System.Drawing.Size(312, 22)
        Me.txtBookingID.TabIndex = 1
        '
        'lblBookingCost
        '
        Me.lblBookingCost.AutoSize = True
        Me.lblBookingCost.Location = New System.Drawing.Point(30, 186)
        Me.lblBookingCost.Name = "lblBookingCost"
        Me.lblBookingCost.Size = New System.Drawing.Size(88, 16)
        Me.lblBookingCost.TabIndex = 10
        Me.lblBookingCost.Text = "Booking Cost"
        '
        'lblBookingEndTime
        '
        Me.lblBookingEndTime.AutoSize = True
        Me.lblBookingEndTime.Location = New System.Drawing.Point(30, 149)
        Me.lblBookingEndTime.Name = "lblBookingEndTime"
        Me.lblBookingEndTime.Size = New System.Drawing.Size(119, 16)
        Me.lblBookingEndTime.TabIndex = 7
        Me.lblBookingEndTime.Text = "Booking End Time"
        '
        'lblBookingStartTime
        '
        Me.lblBookingStartTime.AutoSize = True
        Me.lblBookingStartTime.Location = New System.Drawing.Point(30, 112)
        Me.lblBookingStartTime.Name = "lblBookingStartTime"
        Me.lblBookingStartTime.Size = New System.Drawing.Size(122, 16)
        Me.lblBookingStartTime.TabIndex = 4
        Me.lblBookingStartTime.Text = "Booking Start Time"
        '
        'lblBookingDate
        '
        Me.lblBookingDate.AutoSize = True
        Me.lblBookingDate.Location = New System.Drawing.Point(30, 76)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(90, 16)
        Me.lblBookingDate.TabIndex = 2
        Me.lblBookingDate.Text = "Booking Date"
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Location = New System.Drawing.Point(30, 40)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(74, 16)
        Me.lblBookingID.TabIndex = 0
        Me.lblBookingID.Text = "Booking ID"
        '
        'grpBookings
        '
        Me.grpBookings.Controls.Add(Me.lbxBookingCosts)
        Me.grpBookings.Controls.Add(Me.lbxBookingDurations)
        Me.grpBookings.Controls.Add(Me.lbxBookingEndTimes)
        Me.grpBookings.Controls.Add(Me.lbxBookingStartTimes)
        Me.grpBookings.Controls.Add(Me.lbxBookingDates)
        Me.grpBookings.Controls.Add(Me.lbxBookingIDs)
        Me.grpBookings.Controls.Add(Me.lblBookingCosts)
        Me.grpBookings.Controls.Add(Me.lblBookingDurations)
        Me.grpBookings.Controls.Add(Me.lblBookingEndTimes)
        Me.grpBookings.Controls.Add(Me.lblBookingStartTimes)
        Me.grpBookings.Controls.Add(Me.lblBookingDates)
        Me.grpBookings.Controls.Add(Me.lblBookingIDs)
        Me.grpBookings.Location = New System.Drawing.Point(12, 293)
        Me.grpBookings.Name = "grpBookings"
        Me.grpBookings.Size = New System.Drawing.Size(816, 242)
        Me.grpBookings.TabIndex = 3
        Me.grpBookings.TabStop = False
        Me.grpBookings.Text = "Bookings"
        '
        'lbxBookingCosts
        '
        Me.lbxBookingCosts.FormattingEnabled = True
        Me.lbxBookingCosts.ItemHeight = 16
        Me.lbxBookingCosts.Location = New System.Drawing.Point(679, 67)
        Me.lbxBookingCosts.Name = "lbxBookingCosts"
        Me.lbxBookingCosts.Size = New System.Drawing.Size(128, 164)
        Me.lbxBookingCosts.TabIndex = 11
        '
        'lbxBookingDurations
        '
        Me.lbxBookingDurations.FormattingEnabled = True
        Me.lbxBookingDurations.ItemHeight = 16
        Me.lbxBookingDurations.Location = New System.Drawing.Point(545, 67)
        Me.lbxBookingDurations.Name = "lbxBookingDurations"
        Me.lbxBookingDurations.Size = New System.Drawing.Size(128, 164)
        Me.lbxBookingDurations.TabIndex = 9
        '
        'lbxBookingEndTimes
        '
        Me.lbxBookingEndTimes.FormattingEnabled = True
        Me.lbxBookingEndTimes.ItemHeight = 16
        Me.lbxBookingEndTimes.Location = New System.Drawing.Point(411, 67)
        Me.lbxBookingEndTimes.Name = "lbxBookingEndTimes"
        Me.lbxBookingEndTimes.Size = New System.Drawing.Size(128, 164)
        Me.lbxBookingEndTimes.TabIndex = 7
        '
        'lbxBookingStartTimes
        '
        Me.lbxBookingStartTimes.FormattingEnabled = True
        Me.lbxBookingStartTimes.ItemHeight = 16
        Me.lbxBookingStartTimes.Location = New System.Drawing.Point(277, 67)
        Me.lbxBookingStartTimes.Name = "lbxBookingStartTimes"
        Me.lbxBookingStartTimes.Size = New System.Drawing.Size(128, 164)
        Me.lbxBookingStartTimes.TabIndex = 5
        '
        'lbxBookingDates
        '
        Me.lbxBookingDates.FormattingEnabled = True
        Me.lbxBookingDates.ItemHeight = 16
        Me.lbxBookingDates.Location = New System.Drawing.Point(143, 67)
        Me.lbxBookingDates.Name = "lbxBookingDates"
        Me.lbxBookingDates.Size = New System.Drawing.Size(128, 164)
        Me.lbxBookingDates.TabIndex = 3
        '
        'lbxBookingIDs
        '
        Me.lbxBookingIDs.FormattingEnabled = True
        Me.lbxBookingIDs.ItemHeight = 16
        Me.lbxBookingIDs.Location = New System.Drawing.Point(9, 67)
        Me.lbxBookingIDs.Name = "lbxBookingIDs"
        Me.lbxBookingIDs.Size = New System.Drawing.Size(128, 164)
        Me.lbxBookingIDs.TabIndex = 1
        '
        'lblBookingCosts
        '
        Me.lblBookingCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookingCosts.Location = New System.Drawing.Point(679, 23)
        Me.lblBookingCosts.Name = "lblBookingCosts"
        Me.lblBookingCosts.Size = New System.Drawing.Size(128, 41)
        Me.lblBookingCosts.TabIndex = 10
        Me.lblBookingCosts.Text = "Booking Cost"
        Me.lblBookingCosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookingDurations
        '
        Me.lblBookingDurations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookingDurations.Location = New System.Drawing.Point(545, 23)
        Me.lblBookingDurations.Name = "lblBookingDurations"
        Me.lblBookingDurations.Size = New System.Drawing.Size(128, 41)
        Me.lblBookingDurations.TabIndex = 8
        Me.lblBookingDurations.Text = "Booking Duration"
        Me.lblBookingDurations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookingEndTimes
        '
        Me.lblBookingEndTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookingEndTimes.Location = New System.Drawing.Point(411, 23)
        Me.lblBookingEndTimes.Name = "lblBookingEndTimes"
        Me.lblBookingEndTimes.Size = New System.Drawing.Size(128, 41)
        Me.lblBookingEndTimes.TabIndex = 6
        Me.lblBookingEndTimes.Text = "Booking End Time"
        Me.lblBookingEndTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookingStartTimes
        '
        Me.lblBookingStartTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookingStartTimes.Location = New System.Drawing.Point(277, 23)
        Me.lblBookingStartTimes.Name = "lblBookingStartTimes"
        Me.lblBookingStartTimes.Size = New System.Drawing.Size(128, 41)
        Me.lblBookingStartTimes.TabIndex = 4
        Me.lblBookingStartTimes.Text = "Booking Start Time"
        Me.lblBookingStartTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookingDates
        '
        Me.lblBookingDates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookingDates.Location = New System.Drawing.Point(143, 23)
        Me.lblBookingDates.Name = "lblBookingDates"
        Me.lblBookingDates.Size = New System.Drawing.Size(128, 41)
        Me.lblBookingDates.TabIndex = 2
        Me.lblBookingDates.Text = "Booking Date"
        Me.lblBookingDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookingIDs
        '
        Me.lblBookingIDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookingIDs.Location = New System.Drawing.Point(9, 23)
        Me.lblBookingIDs.Name = "lblBookingIDs"
        Me.lblBookingIDs.Size = New System.Drawing.Size(128, 41)
        Me.lblBookingIDs.TabIndex = 0
        Me.lblBookingIDs.Text = "Booking ID"
        Me.lblBookingIDs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBookingsManagement
        '
        Me.grpBookingsManagement.Controls.Add(Me.btnExit)
        Me.grpBookingsManagement.Controls.Add(Me.btnClearBookings)
        Me.grpBookingsManagement.Controls.Add(Me.btnClearStatistics)
        Me.grpBookingsManagement.Controls.Add(Me.btnGetStatistics)
        Me.grpBookingsManagement.Location = New System.Drawing.Point(12, 132)
        Me.grpBookingsManagement.Name = "grpBookingsManagement"
        Me.grpBookingsManagement.Size = New System.Drawing.Size(306, 155)
        Me.grpBookingsManagement.TabIndex = 2
        Me.grpBookingsManagement.TabStop = False
        Me.grpBookingsManagement.Text = "Bookings Management"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(158, 93)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 31)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClearBookings
        '
        Me.btnClearBookings.Location = New System.Drawing.Point(17, 93)
        Me.btnClearBookings.Name = "btnClearBookings"
        Me.btnClearBookings.Size = New System.Drawing.Size(131, 31)
        Me.btnClearBookings.TabIndex = 2
        Me.btnClearBookings.Text = "Clear &Bookings"
        Me.btnClearBookings.UseVisualStyleBackColor = True
        '
        'btnClearStatistics
        '
        Me.btnClearStatistics.Location = New System.Drawing.Point(158, 39)
        Me.btnClearStatistics.Name = "btnClearStatistics"
        Me.btnClearStatistics.Size = New System.Drawing.Size(131, 31)
        Me.btnClearStatistics.TabIndex = 1
        Me.btnClearStatistics.Text = "Clear &Statistics"
        Me.btnClearStatistics.UseVisualStyleBackColor = True
        '
        'btnGetStatistics
        '
        Me.btnGetStatistics.Location = New System.Drawing.Point(17, 39)
        Me.btnGetStatistics.Name = "btnGetStatistics"
        Me.btnGetStatistics.Size = New System.Drawing.Size(131, 31)
        Me.btnGetStatistics.TabIndex = 0
        Me.btnGetStatistics.Text = "&Get Statistics"
        Me.btnGetStatistics.UseVisualStyleBackColor = True
        '
        'grpSummaryStatistics
        '
        Me.grpSummaryStatistics.Controls.Add(Me.lblAverageBookingCostValue)
        Me.grpSummaryStatistics.Controls.Add(Me.lblAverageBookingCost)
        Me.grpSummaryStatistics.Controls.Add(Me.lblSmallestBookingCostValue)
        Me.grpSummaryStatistics.Controls.Add(Me.lblSmallestBookingCost)
        Me.grpSummaryStatistics.Controls.Add(Me.lblLargestBookingCostValue)
        Me.grpSummaryStatistics.Controls.Add(Me.lblLargestBookingCost)
        Me.grpSummaryStatistics.Controls.Add(Me.lblAverageBookingDurationValue)
        Me.grpSummaryStatistics.Controls.Add(Me.lblAverageBookingDuration)
        Me.grpSummaryStatistics.Controls.Add(Me.lblShortestBookingDurationValue)
        Me.grpSummaryStatistics.Controls.Add(Me.lblShortestBookingDuration)
        Me.grpSummaryStatistics.Controls.Add(Me.lblLongestBookingDurationValue)
        Me.grpSummaryStatistics.Controls.Add(Me.lblLongestBookingDuration)
        Me.grpSummaryStatistics.Location = New System.Drawing.Point(12, 541)
        Me.grpSummaryStatistics.Name = "grpSummaryStatistics"
        Me.grpSummaryStatistics.Size = New System.Drawing.Size(816, 133)
        Me.grpSummaryStatistics.TabIndex = 4
        Me.grpSummaryStatistics.TabStop = False
        Me.grpSummaryStatistics.Text = "Summary Statistics"
        '
        'lblAverageBookingCostValue
        '
        Me.lblAverageBookingCostValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageBookingCostValue.Location = New System.Drawing.Point(604, 96)
        Me.lblAverageBookingCostValue.Name = "lblAverageBookingCostValue"
        Me.lblAverageBookingCostValue.Size = New System.Drawing.Size(186, 27)
        Me.lblAverageBookingCostValue.TabIndex = 11
        Me.lblAverageBookingCostValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAverageBookingCost
        '
        Me.lblAverageBookingCost.AutoSize = True
        Me.lblAverageBookingCost.Location = New System.Drawing.Point(452, 101)
        Me.lblAverageBookingCost.Name = "lblAverageBookingCost"
        Me.lblAverageBookingCost.Size = New System.Drawing.Size(143, 16)
        Me.lblAverageBookingCost.TabIndex = 10
        Me.lblAverageBookingCost.Text = "Average Booking Cost"
        '
        'lblSmallestBookingCostValue
        '
        Me.lblSmallestBookingCostValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSmallestBookingCostValue.Location = New System.Drawing.Point(604, 61)
        Me.lblSmallestBookingCostValue.Name = "lblSmallestBookingCostValue"
        Me.lblSmallestBookingCostValue.Size = New System.Drawing.Size(186, 27)
        Me.lblSmallestBookingCostValue.TabIndex = 9
        Me.lblSmallestBookingCostValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSmallestBookingCost
        '
        Me.lblSmallestBookingCost.AutoSize = True
        Me.lblSmallestBookingCost.Location = New System.Drawing.Point(452, 66)
        Me.lblSmallestBookingCost.Name = "lblSmallestBookingCost"
        Me.lblSmallestBookingCost.Size = New System.Drawing.Size(143, 16)
        Me.lblSmallestBookingCost.TabIndex = 8
        Me.lblSmallestBookingCost.Text = "Smallest Booking Cost"
        '
        'lblLargestBookingCostValue
        '
        Me.lblLargestBookingCostValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLargestBookingCostValue.Location = New System.Drawing.Point(604, 26)
        Me.lblLargestBookingCostValue.Name = "lblLargestBookingCostValue"
        Me.lblLargestBookingCostValue.Size = New System.Drawing.Size(186, 27)
        Me.lblLargestBookingCostValue.TabIndex = 7
        Me.lblLargestBookingCostValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLargestBookingCost
        '
        Me.lblLargestBookingCost.AutoSize = True
        Me.lblLargestBookingCost.Location = New System.Drawing.Point(452, 31)
        Me.lblLargestBookingCost.Name = "lblLargestBookingCost"
        Me.lblLargestBookingCost.Size = New System.Drawing.Size(136, 16)
        Me.lblLargestBookingCost.TabIndex = 6
        Me.lblLargestBookingCost.Text = "Largest Booking Cost"
        '
        'lblAverageBookingDurationValue
        '
        Me.lblAverageBookingDurationValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageBookingDurationValue.Location = New System.Drawing.Point(198, 96)
        Me.lblAverageBookingDurationValue.Name = "lblAverageBookingDurationValue"
        Me.lblAverageBookingDurationValue.Size = New System.Drawing.Size(186, 27)
        Me.lblAverageBookingDurationValue.TabIndex = 5
        Me.lblAverageBookingDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAverageBookingDuration
        '
        Me.lblAverageBookingDuration.AutoSize = True
        Me.lblAverageBookingDuration.Location = New System.Drawing.Point(23, 101)
        Me.lblAverageBookingDuration.Name = "lblAverageBookingDuration"
        Me.lblAverageBookingDuration.Size = New System.Drawing.Size(166, 16)
        Me.lblAverageBookingDuration.TabIndex = 4
        Me.lblAverageBookingDuration.Text = "Average Booking Duration"
        '
        'lblShortestBookingDurationValue
        '
        Me.lblShortestBookingDurationValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShortestBookingDurationValue.Location = New System.Drawing.Point(198, 61)
        Me.lblShortestBookingDurationValue.Name = "lblShortestBookingDurationValue"
        Me.lblShortestBookingDurationValue.Size = New System.Drawing.Size(186, 27)
        Me.lblShortestBookingDurationValue.TabIndex = 3
        Me.lblShortestBookingDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShortestBookingDuration
        '
        Me.lblShortestBookingDuration.AutoSize = True
        Me.lblShortestBookingDuration.Location = New System.Drawing.Point(22, 66)
        Me.lblShortestBookingDuration.Name = "lblShortestBookingDuration"
        Me.lblShortestBookingDuration.Size = New System.Drawing.Size(163, 16)
        Me.lblShortestBookingDuration.TabIndex = 2
        Me.lblShortestBookingDuration.Text = "Shortest Booking Duration"
        '
        'lblLongestBookingDurationValue
        '
        Me.lblLongestBookingDurationValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLongestBookingDurationValue.Location = New System.Drawing.Point(198, 26)
        Me.lblLongestBookingDurationValue.Name = "lblLongestBookingDurationValue"
        Me.lblLongestBookingDurationValue.Size = New System.Drawing.Size(186, 27)
        Me.lblLongestBookingDurationValue.TabIndex = 1
        Me.lblLongestBookingDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLongestBookingDuration
        '
        Me.lblLongestBookingDuration.AutoSize = True
        Me.lblLongestBookingDuration.Location = New System.Drawing.Point(22, 31)
        Me.lblLongestBookingDuration.Name = "lblLongestBookingDuration"
        Me.lblLongestBookingDuration.Size = New System.Drawing.Size(162, 16)
        Me.lblLongestBookingDuration.TabIndex = 0
        Me.lblLongestBookingDuration.Text = "Longest Booking Duration"
        '
        'frmReservationRecordingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpSummaryStatistics)
        Me.Controls.Add(Me.grpBookingsManagement)
        Me.Controls.Add(Me.grpBookings)
        Me.Controls.Add(Me.grpAddBookDetails)
        Me.Controls.Add(Me.grpCurrentLoginDetails)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReservationRecordingSystem"
        Me.Text = "Paradise Reservation Recording System"
        Me.grpCurrentLoginDetails.ResumeLayout(False)
        Me.grpCurrentLoginDetails.PerformLayout()
        Me.grpAddBookDetails.ResumeLayout(False)
        Me.grpAddBookDetails.PerformLayout()
        CType(Me.nudBookingEndTimeMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBookingEndTimeHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBookingStartTimeMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBookingStartTimeHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBookings.ResumeLayout(False)
        Me.grpBookingsManagement.ResumeLayout(False)
        Me.grpSummaryStatistics.ResumeLayout(False)
        Me.grpSummaryStatistics.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCurrentLoginDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblLocationIDValue As System.Windows.Forms.Label
    Friend WithEvents lblStaffIDValue As System.Windows.Forms.Label
    Friend WithEvents lblLocationID As System.Windows.Forms.Label
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
    Friend WithEvents grpAddBookDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblBookingCost As System.Windows.Forms.Label
    Friend WithEvents lblBookingEndTime As System.Windows.Forms.Label
    Friend WithEvents lblBookingStartTime As System.Windows.Forms.Label
    Friend WithEvents lblBookingDate As System.Windows.Forms.Label
    Friend WithEvents lblBookingID As System.Windows.Forms.Label
    Friend WithEvents txtBookingID As System.Windows.Forms.TextBox
    Friend WithEvents lblBookingDateValue As System.Windows.Forms.Label
    Friend WithEvents nudBookingStartTimeMinute As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBookingStartTimeHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBookingEndTimeMinute As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBookingEndTimeHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtBookingCost As System.Windows.Forms.TextBox
    Friend WithEvents btnClearBooking As System.Windows.Forms.Button
    Friend WithEvents btnAddBooking As System.Windows.Forms.Button
    Friend WithEvents grpBookings As System.Windows.Forms.GroupBox
    Friend WithEvents grpBookingsManagement As System.Windows.Forms.GroupBox
    Friend WithEvents grpSummaryStatistics As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClearBookings As System.Windows.Forms.Button
    Friend WithEvents btnClearStatistics As System.Windows.Forms.Button
    Friend WithEvents btnGetStatistics As System.Windows.Forms.Button
    Friend WithEvents lbxBookingCosts As System.Windows.Forms.ListBox
    Friend WithEvents lbxBookingDurations As System.Windows.Forms.ListBox
    Friend WithEvents lbxBookingEndTimes As System.Windows.Forms.ListBox
    Friend WithEvents lbxBookingStartTimes As System.Windows.Forms.ListBox
    Friend WithEvents lbxBookingDates As System.Windows.Forms.ListBox
    Friend WithEvents lbxBookingIDs As System.Windows.Forms.ListBox
    Friend WithEvents lblBookingCosts As System.Windows.Forms.Label
    Friend WithEvents lblBookingDurations As System.Windows.Forms.Label
    Friend WithEvents lblBookingEndTimes As System.Windows.Forms.Label
    Friend WithEvents lblBookingStartTimes As System.Windows.Forms.Label
    Friend WithEvents lblBookingDates As System.Windows.Forms.Label
    Friend WithEvents lblBookingIDs As System.Windows.Forms.Label
    Friend WithEvents lblAverageBookingCostValue As System.Windows.Forms.Label
    Friend WithEvents lblAverageBookingCost As System.Windows.Forms.Label
    Friend WithEvents lblSmallestBookingCostValue As System.Windows.Forms.Label
    Friend WithEvents lblSmallestBookingCost As System.Windows.Forms.Label
    Friend WithEvents lblLargestBookingCostValue As System.Windows.Forms.Label
    Friend WithEvents lblLargestBookingCost As System.Windows.Forms.Label
    Friend WithEvents lblAverageBookingDurationValue As System.Windows.Forms.Label
    Friend WithEvents lblAverageBookingDuration As System.Windows.Forms.Label
    Friend WithEvents lblShortestBookingDurationValue As System.Windows.Forms.Label
    Friend WithEvents lblShortestBookingDuration As System.Windows.Forms.Label
    Friend WithEvents lblLongestBookingDurationValue As System.Windows.Forms.Label
    Friend WithEvents lblLongestBookingDuration As System.Windows.Forms.Label

End Class
