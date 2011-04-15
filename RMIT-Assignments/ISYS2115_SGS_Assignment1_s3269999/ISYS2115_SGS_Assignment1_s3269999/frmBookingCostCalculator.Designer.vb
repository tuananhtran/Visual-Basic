<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingCostCalculator
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblBookingCostCalculatorHeading = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.pnlBookingInformation = New System.Windows.Forms.Panel
        Me.gbxBookingInformation = New System.Windows.Forms.GroupBox
        Me.lblBookingDate = New System.Windows.Forms.Label
        Me.cbArrivalTime = New System.Windows.Forms.ComboBox
        Me.txtFullname = New System.Windows.Forms.TextBox
        Me.lblFullnameLabel = New System.Windows.Forms.Label
        Me.txtRedeemedAirMiles = New System.Windows.Forms.TextBox
        Me.txtMembershipCardNumber = New System.Windows.Forms.TextBox
        Me.lblAirportPickupCost = New System.Windows.Forms.Label
        Me.btnAddRoom = New System.Windows.Forms.Button
        Me.dtpArrivalDate = New System.Windows.Forms.DateTimePicker
        Me.cbxMembershipCardOption = New System.Windows.Forms.CheckBox
        Me.cbxRedeemedAirMilesOption = New System.Windows.Forms.CheckBox
        Me.cbxAirportPickupOption = New System.Windows.Forms.CheckBox
        Me.lblArrivalTimeLabel = New System.Windows.Forms.Label
        Me.lblArrivalDateLabel = New System.Windows.Forms.Label
        Me.lblBookingDateLabel = New System.Windows.Forms.Label
        Me.pnlBookingManipulation = New System.Windows.Forms.Panel
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.pnlRoomBookingInformation = New System.Windows.Forms.Panel
        Me.dgvBookingInformation = New System.Windows.Forms.DataGridView
        Me.room_type = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.number_of_nights = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.number_of_adults = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.number_of_children = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.rates_per_night = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.extra_bed = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.basic_room_cost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.to_be_removed = New System.Windows.Forms.DataGridViewButtonColumn
        Me.pnlBookingCostResult = New System.Windows.Forms.Panel
        Me.gbxBookingCostResult = New System.Windows.Forms.GroupBox
        Me.lblMemberDiscountAmount = New System.Windows.Forms.Label
        Me.lblMemberDiscountLabel = New System.Windows.Forms.Label
        Me.lblMinusSign2 = New System.Windows.Forms.Label
        Me.lblAirRedeemAmount = New System.Windows.Forms.Label
        Me.lblAirRedeemLabel = New System.Windows.Forms.Label
        Me.lblMinusSign1 = New System.Windows.Forms.Label
        Me.lblTaxCharge = New System.Windows.Forms.Label
        Me.lblPlusSign2 = New System.Windows.Forms.Label
        Me.lblTaxChargeLabel = New System.Windows.Forms.Label
        Me.lblServiceCost = New System.Windows.Forms.Label
        Me.lblPlusSign1 = New System.Windows.Forms.Label
        Me.lblServiceCostLabel = New System.Windows.Forms.Label
        Me.lblTotalRoomCost = New System.Windows.Forms.Label
        Me.lblTotalRoomCostLabel = New System.Windows.Forms.Label
        Me.lblEqualSign = New System.Windows.Forms.Label
        Me.lblTotalLabel = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.pnlBookingInformation.SuspendLayout()
        Me.gbxBookingInformation.SuspendLayout()
        Me.pnlBookingManipulation.SuspendLayout()
        Me.pnlRoomBookingInformation.SuspendLayout()
        CType(Me.dgvBookingInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBookingCostResult.SuspendLayout()
        Me.gbxBookingCostResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBookingCostCalculatorHeading
        '
        Me.lblBookingCostCalculatorHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBookingCostCalculatorHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingCostCalculatorHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblBookingCostCalculatorHeading.Name = "lblBookingCostCalculatorHeading"
        Me.lblBookingCostCalculatorHeading.Size = New System.Drawing.Size(783, 53)
        Me.lblBookingCostCalculatorHeading.TabIndex = 0
        Me.lblBookingCostCalculatorHeading.Text = "Booking Cost Calculator"
        Me.lblBookingCostCalculatorHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(0, 657)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblCopyright.Size = New System.Drawing.Size(783, 39)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "© Copyright Paradise 2011"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBookingInformation
        '
        Me.pnlBookingInformation.Controls.Add(Me.gbxBookingInformation)
        Me.pnlBookingInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBookingInformation.Location = New System.Drawing.Point(0, 53)
        Me.pnlBookingInformation.Name = "pnlBookingInformation"
        Me.pnlBookingInformation.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlBookingInformation.Size = New System.Drawing.Size(783, 243)
        Me.pnlBookingInformation.TabIndex = 2
        '
        'gbxBookingInformation
        '
        Me.gbxBookingInformation.Controls.Add(Me.lblBookingDate)
        Me.gbxBookingInformation.Controls.Add(Me.cbArrivalTime)
        Me.gbxBookingInformation.Controls.Add(Me.txtFullname)
        Me.gbxBookingInformation.Controls.Add(Me.lblFullnameLabel)
        Me.gbxBookingInformation.Controls.Add(Me.txtRedeemedAirMiles)
        Me.gbxBookingInformation.Controls.Add(Me.txtMembershipCardNumber)
        Me.gbxBookingInformation.Controls.Add(Me.lblAirportPickupCost)
        Me.gbxBookingInformation.Controls.Add(Me.btnAddRoom)
        Me.gbxBookingInformation.Controls.Add(Me.dtpArrivalDate)
        Me.gbxBookingInformation.Controls.Add(Me.cbxMembershipCardOption)
        Me.gbxBookingInformation.Controls.Add(Me.cbxRedeemedAirMilesOption)
        Me.gbxBookingInformation.Controls.Add(Me.cbxAirportPickupOption)
        Me.gbxBookingInformation.Controls.Add(Me.lblArrivalTimeLabel)
        Me.gbxBookingInformation.Controls.Add(Me.lblArrivalDateLabel)
        Me.gbxBookingInformation.Controls.Add(Me.lblBookingDateLabel)
        Me.gbxBookingInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxBookingInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBookingInformation.Location = New System.Drawing.Point(10, 10)
        Me.gbxBookingInformation.Name = "gbxBookingInformation"
        Me.gbxBookingInformation.Size = New System.Drawing.Size(763, 223)
        Me.gbxBookingInformation.TabIndex = 0
        Me.gbxBookingInformation.TabStop = False
        Me.gbxBookingInformation.Text = "Booking Information"
        '
        'lblBookingDate
        '
        Me.lblBookingDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookingDate.Location = New System.Drawing.Point(114, 89)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(200, 22)
        Me.lblBookingDate.TabIndex = 16
        Me.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbArrivalTime
        '
        Me.cbArrivalTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArrivalTime.FormattingEnabled = True
        Me.cbArrivalTime.Items.AddRange(New Object() {"1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", "10:00 PM", "11:00 PM"})
        Me.cbArrivalTime.Location = New System.Drawing.Point(114, 174)
        Me.cbArrivalTime.Name = "cbArrivalTime"
        Me.cbArrivalTime.Size = New System.Drawing.Size(121, 24)
        Me.cbArrivalTime.TabIndex = 15
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(114, 42)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(200, 22)
        Me.txtFullname.TabIndex = 14
        '
        'lblFullnameLabel
        '
        Me.lblFullnameLabel.AutoSize = True
        Me.lblFullnameLabel.Location = New System.Drawing.Point(45, 45)
        Me.lblFullnameLabel.Name = "lblFullnameLabel"
        Me.lblFullnameLabel.Size = New System.Drawing.Size(63, 16)
        Me.lblFullnameLabel.TabIndex = 13
        Me.lblFullnameLabel.Text = "Fullname"
        '
        'txtRedeemedAirMiles
        '
        Me.txtRedeemedAirMiles.Enabled = False
        Me.txtRedeemedAirMiles.Location = New System.Drawing.Point(586, 87)
        Me.txtRedeemedAirMiles.Name = "txtRedeemedAirMiles"
        Me.txtRedeemedAirMiles.Size = New System.Drawing.Size(100, 22)
        Me.txtRedeemedAirMiles.TabIndex = 12
        '
        'txtMembershipCardNumber
        '
        Me.txtMembershipCardNumber.Enabled = False
        Me.txtMembershipCardNumber.Location = New System.Drawing.Point(586, 129)
        Me.txtMembershipCardNumber.Name = "txtMembershipCardNumber"
        Me.txtMembershipCardNumber.Size = New System.Drawing.Size(149, 22)
        Me.txtMembershipCardNumber.TabIndex = 11
        '
        'lblAirportPickupCost
        '
        Me.lblAirportPickupCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAirportPickupCost.Enabled = False
        Me.lblAirportPickupCost.Location = New System.Drawing.Point(586, 42)
        Me.lblAirportPickupCost.Name = "lblAirportPickupCost"
        Me.lblAirportPickupCost.Size = New System.Drawing.Size(100, 22)
        Me.lblAirportPickupCost.TabIndex = 10
        Me.lblAirportPickupCost.Text = "$140.00"
        Me.lblAirportPickupCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Location = New System.Drawing.Point(516, 170)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(93, 30)
        Me.btnAddRoom.TabIndex = 3
        Me.btnAddRoom.Text = "&Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'dtpArrivalDate
        '
        Me.dtpArrivalDate.Location = New System.Drawing.Point(114, 127)
        Me.dtpArrivalDate.Name = "dtpArrivalDate"
        Me.dtpArrivalDate.Size = New System.Drawing.Size(237, 22)
        Me.dtpArrivalDate.TabIndex = 8
        '
        'cbxMembershipCardOption
        '
        Me.cbxMembershipCardOption.AutoSize = True
        Me.cbxMembershipCardOption.Location = New System.Drawing.Point(411, 131)
        Me.cbxMembershipCardOption.Name = "cbxMembershipCardOption"
        Me.cbxMembershipCardOption.Size = New System.Drawing.Size(158, 20)
        Me.cbxMembershipCardOption.TabIndex = 6
        Me.cbxMembershipCardOption.Text = "Membership Card No."
        Me.cbxMembershipCardOption.UseVisualStyleBackColor = True
        '
        'cbxRedeemedAirMilesOption
        '
        Me.cbxRedeemedAirMilesOption.AutoSize = True
        Me.cbxRedeemedAirMilesOption.Location = New System.Drawing.Point(411, 89)
        Me.cbxRedeemedAirMilesOption.Name = "cbxRedeemedAirMilesOption"
        Me.cbxRedeemedAirMilesOption.Size = New System.Drawing.Size(150, 20)
        Me.cbxRedeemedAirMilesOption.TabIndex = 5
        Me.cbxRedeemedAirMilesOption.Text = "Redeemed Air Miles"
        Me.cbxRedeemedAirMilesOption.UseVisualStyleBackColor = True
        '
        'cbxAirportPickupOption
        '
        Me.cbxAirportPickupOption.AutoSize = True
        Me.cbxAirportPickupOption.Location = New System.Drawing.Point(411, 44)
        Me.cbxAirportPickupOption.Name = "cbxAirportPickupOption"
        Me.cbxAirportPickupOption.Size = New System.Drawing.Size(163, 20)
        Me.cbxAirportPickupOption.TabIndex = 4
        Me.cbxAirportPickupOption.Text = "Airport Pick-up Service"
        Me.cbxAirportPickupOption.UseVisualStyleBackColor = True
        '
        'lblArrivalTimeLabel
        '
        Me.lblArrivalTimeLabel.AutoSize = True
        Me.lblArrivalTimeLabel.Location = New System.Drawing.Point(28, 177)
        Me.lblArrivalTimeLabel.Name = "lblArrivalTimeLabel"
        Me.lblArrivalTimeLabel.Size = New System.Drawing.Size(80, 16)
        Me.lblArrivalTimeLabel.TabIndex = 2
        Me.lblArrivalTimeLabel.Text = "Arrival Time"
        '
        'lblArrivalDateLabel
        '
        Me.lblArrivalDateLabel.AutoSize = True
        Me.lblArrivalDateLabel.Location = New System.Drawing.Point(30, 132)
        Me.lblArrivalDateLabel.Name = "lblArrivalDateLabel"
        Me.lblArrivalDateLabel.Size = New System.Drawing.Size(78, 16)
        Me.lblArrivalDateLabel.TabIndex = 1
        Me.lblArrivalDateLabel.Text = "Arrival Date"
        '
        'lblBookingDateLabel
        '
        Me.lblBookingDateLabel.AutoSize = True
        Me.lblBookingDateLabel.Location = New System.Drawing.Point(18, 90)
        Me.lblBookingDateLabel.Name = "lblBookingDateLabel"
        Me.lblBookingDateLabel.Size = New System.Drawing.Size(90, 16)
        Me.lblBookingDateLabel.TabIndex = 0
        Me.lblBookingDateLabel.Text = "Booking Date"
        '
        'pnlBookingManipulation
        '
        Me.pnlBookingManipulation.Controls.Add(Me.btnClear)
        Me.pnlBookingManipulation.Controls.Add(Me.btnExit)
        Me.pnlBookingManipulation.Controls.Add(Me.btnCalculate)
        Me.pnlBookingManipulation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBookingManipulation.Location = New System.Drawing.Point(0, 296)
        Me.pnlBookingManipulation.Name = "pnlBookingManipulation"
        Me.pnlBookingManipulation.Size = New System.Drawing.Size(783, 59)
        Me.pnlBookingManipulation.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(348, 15)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(500, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(194, 15)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 30)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'pnlRoomBookingInformation
        '
        Me.pnlRoomBookingInformation.Controls.Add(Me.dgvBookingInformation)
        Me.pnlRoomBookingInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRoomBookingInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRoomBookingInformation.Location = New System.Drawing.Point(0, 355)
        Me.pnlRoomBookingInformation.Name = "pnlRoomBookingInformation"
        Me.pnlRoomBookingInformation.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlRoomBookingInformation.Size = New System.Drawing.Size(783, 142)
        Me.pnlRoomBookingInformation.TabIndex = 4
        '
        'dgvBookingInformation
        '
        Me.dgvBookingInformation.AllowUserToAddRows = False
        Me.dgvBookingInformation.AllowUserToOrderColumns = True
        Me.dgvBookingInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookingInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.room_type, Me.number_of_nights, Me.number_of_adults, Me.number_of_children, Me.rates_per_night, Me.extra_bed, Me.basic_room_cost, Me.to_be_removed})
        Me.dgvBookingInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBookingInformation.Location = New System.Drawing.Point(10, 10)
        Me.dgvBookingInformation.Name = "dgvBookingInformation"
        Me.dgvBookingInformation.Size = New System.Drawing.Size(763, 122)
        Me.dgvBookingInformation.TabIndex = 0
        '
        'room_type
        '
        Me.room_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.room_type.DefaultCellStyle = DataGridViewCellStyle22
        Me.room_type.HeaderText = "Room Type"
        Me.room_type.Items.AddRange(New Object() {"Superior", "Deluxe", "Premium Deluxe", "Junior Suite", "Presidential Suite", "One Bedroom Villa", "Two Bedroom Villa"})
        Me.room_type.Name = "room_type"
        Me.room_type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.room_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.room_type.Width = 88
        '
        'number_of_nights
        '
        Me.number_of_nights.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.number_of_nights.DefaultCellStyle = DataGridViewCellStyle23
        Me.number_of_nights.HeaderText = "Number of Nights"
        Me.number_of_nights.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.number_of_nights.Name = "number_of_nights"
        Me.number_of_nights.Width = 67
        '
        'number_of_adults
        '
        Me.number_of_adults.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.number_of_adults.DefaultCellStyle = DataGridViewCellStyle24
        Me.number_of_adults.HeaderText = "Number of Adults"
        Me.number_of_adults.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.number_of_adults.Name = "number_of_adults"
        Me.number_of_adults.Width = 67
        '
        'number_of_children
        '
        Me.number_of_children.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.number_of_children.DefaultCellStyle = DataGridViewCellStyle25
        Me.number_of_children.HeaderText = "Number of Children"
        Me.number_of_children.Items.AddRange(New Object() {"0", "1", "2"})
        Me.number_of_children.Name = "number_of_children"
        Me.number_of_children.Width = 108
        '
        'rates_per_night
        '
        Me.rates_per_night.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.rates_per_night.DefaultCellStyle = DataGridViewCellStyle26
        Me.rates_per_night.HeaderText = "Rates per Night"
        Me.rates_per_night.Name = "rates_per_night"
        Me.rates_per_night.ReadOnly = True
        Me.rates_per_night.Width = 107
        '
        'extra_bed
        '
        Me.extra_bed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.extra_bed.DefaultCellStyle = DataGridViewCellStyle27
        Me.extra_bed.HeaderText = "Extra Bed"
        Me.extra_bed.Name = "extra_bed"
        Me.extra_bed.ReadOnly = True
        Me.extra_bed.Width = 79
        '
        'basic_room_cost
        '
        Me.basic_room_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.basic_room_cost.DefaultCellStyle = DataGridViewCellStyle28
        Me.basic_room_cost.HeaderText = "Basic Room Cost"
        Me.basic_room_cost.Name = "basic_room_cost"
        Me.basic_room_cost.ReadOnly = True
        Me.basic_room_cost.Width = 94
        '
        'to_be_removed
        '
        Me.to_be_removed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.to_be_removed.HeaderText = "Remove?"
        Me.to_be_removed.Name = "to_be_removed"
        Me.to_be_removed.Text = "Remove"
        Me.to_be_removed.UseColumnTextForButtonValue = True
        Me.to_be_removed.Width = 66
        '
        'pnlBookingCostResult
        '
        Me.pnlBookingCostResult.Controls.Add(Me.gbxBookingCostResult)
        Me.pnlBookingCostResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBookingCostResult.Location = New System.Drawing.Point(0, 497)
        Me.pnlBookingCostResult.Name = "pnlBookingCostResult"
        Me.pnlBookingCostResult.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlBookingCostResult.Size = New System.Drawing.Size(783, 160)
        Me.pnlBookingCostResult.TabIndex = 5
        '
        'gbxBookingCostResult
        '
        Me.gbxBookingCostResult.Controls.Add(Me.lblTotal)
        Me.gbxBookingCostResult.Controls.Add(Me.lblTotalLabel)
        Me.gbxBookingCostResult.Controls.Add(Me.lblEqualSign)
        Me.gbxBookingCostResult.Controls.Add(Me.lblMemberDiscountAmount)
        Me.gbxBookingCostResult.Controls.Add(Me.lblMemberDiscountLabel)
        Me.gbxBookingCostResult.Controls.Add(Me.lblMinusSign2)
        Me.gbxBookingCostResult.Controls.Add(Me.lblAirRedeemAmount)
        Me.gbxBookingCostResult.Controls.Add(Me.lblAirRedeemLabel)
        Me.gbxBookingCostResult.Controls.Add(Me.lblMinusSign1)
        Me.gbxBookingCostResult.Controls.Add(Me.lblTaxCharge)
        Me.gbxBookingCostResult.Controls.Add(Me.lblPlusSign2)
        Me.gbxBookingCostResult.Controls.Add(Me.lblTaxChargeLabel)
        Me.gbxBookingCostResult.Controls.Add(Me.lblServiceCost)
        Me.gbxBookingCostResult.Controls.Add(Me.lblPlusSign1)
        Me.gbxBookingCostResult.Controls.Add(Me.lblServiceCostLabel)
        Me.gbxBookingCostResult.Controls.Add(Me.lblTotalRoomCost)
        Me.gbxBookingCostResult.Controls.Add(Me.lblTotalRoomCostLabel)
        Me.gbxBookingCostResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxBookingCostResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBookingCostResult.Location = New System.Drawing.Point(10, 10)
        Me.gbxBookingCostResult.Name = "gbxBookingCostResult"
        Me.gbxBookingCostResult.Size = New System.Drawing.Size(763, 140)
        Me.gbxBookingCostResult.TabIndex = 0
        Me.gbxBookingCostResult.TabStop = False
        Me.gbxBookingCostResult.Text = "Booking Cost Result"
        '
        'lblMemberDiscountAmount
        '
        Me.lblMemberDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMemberDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberDiscountAmount.Location = New System.Drawing.Point(489, 61)
        Me.lblMemberDiscountAmount.Name = "lblMemberDiscountAmount"
        Me.lblMemberDiscountAmount.Size = New System.Drawing.Size(89, 50)
        Me.lblMemberDiscountAmount.TabIndex = 13
        Me.lblMemberDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMemberDiscountLabel
        '
        Me.lblMemberDiscountLabel.AutoSize = True
        Me.lblMemberDiscountLabel.Location = New System.Drawing.Point(477, 35)
        Me.lblMemberDiscountLabel.Name = "lblMemberDiscountLabel"
        Me.lblMemberDiscountLabel.Size = New System.Drawing.Size(113, 16)
        Me.lblMemberDiscountLabel.TabIndex = 12
        Me.lblMemberDiscountLabel.Text = "Member Discount"
        '
        'lblMinusSign2
        '
        Me.lblMinusSign2.AutoSize = True
        Me.lblMinusSign2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinusSign2.Location = New System.Drawing.Point(466, 71)
        Me.lblMinusSign2.Name = "lblMinusSign2"
        Me.lblMinusSign2.Size = New System.Drawing.Size(20, 25)
        Me.lblMinusSign2.TabIndex = 11
        Me.lblMinusSign2.Text = "-"
        '
        'lblAirRedeemAmount
        '
        Me.lblAirRedeemAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAirRedeemAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirRedeemAmount.Location = New System.Drawing.Point(373, 61)
        Me.lblAirRedeemAmount.Name = "lblAirRedeemAmount"
        Me.lblAirRedeemAmount.Size = New System.Drawing.Size(89, 50)
        Me.lblAirRedeemAmount.TabIndex = 10
        Me.lblAirRedeemAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAirRedeemLabel
        '
        Me.lblAirRedeemLabel.AutoSize = True
        Me.lblAirRedeemLabel.Location = New System.Drawing.Point(377, 35)
        Me.lblAirRedeemLabel.Name = "lblAirRedeemLabel"
        Me.lblAirRedeemLabel.Size = New System.Drawing.Size(80, 16)
        Me.lblAirRedeemLabel.TabIndex = 9
        Me.lblAirRedeemLabel.Text = "Air Redeem"
        '
        'lblMinusSign1
        '
        Me.lblMinusSign1.AutoSize = True
        Me.lblMinusSign1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinusSign1.Location = New System.Drawing.Point(350, 71)
        Me.lblMinusSign1.Name = "lblMinusSign1"
        Me.lblMinusSign1.Size = New System.Drawing.Size(20, 25)
        Me.lblMinusSign1.TabIndex = 8
        Me.lblMinusSign1.Text = "-"
        '
        'lblTaxCharge
        '
        Me.lblTaxCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxCharge.Location = New System.Drawing.Point(256, 61)
        Me.lblTaxCharge.Name = "lblTaxCharge"
        Me.lblTaxCharge.Size = New System.Drawing.Size(89, 50)
        Me.lblTaxCharge.TabIndex = 7
        Me.lblTaxCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlusSign2
        '
        Me.lblPlusSign2.AutoSize = True
        Me.lblPlusSign2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlusSign2.Location = New System.Drawing.Point(231, 71)
        Me.lblPlusSign2.Name = "lblPlusSign2"
        Me.lblPlusSign2.Size = New System.Drawing.Size(25, 25)
        Me.lblPlusSign2.TabIndex = 6
        Me.lblPlusSign2.Text = "+"
        '
        'lblTaxChargeLabel
        '
        Me.lblTaxChargeLabel.AutoSize = True
        Me.lblTaxChargeLabel.Location = New System.Drawing.Point(285, 35)
        Me.lblTaxChargeLabel.Name = "lblTaxChargeLabel"
        Me.lblTaxChargeLabel.Size = New System.Drawing.Size(31, 16)
        Me.lblTaxChargeLabel.TabIndex = 5
        Me.lblTaxChargeLabel.Text = "Tax"
        '
        'lblServiceCost
        '
        Me.lblServiceCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServiceCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCost.Location = New System.Drawing.Point(138, 61)
        Me.lblServiceCost.Name = "lblServiceCost"
        Me.lblServiceCost.Size = New System.Drawing.Size(89, 50)
        Me.lblServiceCost.TabIndex = 4
        Me.lblServiceCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlusSign1
        '
        Me.lblPlusSign1.AutoSize = True
        Me.lblPlusSign1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlusSign1.Location = New System.Drawing.Point(112, 71)
        Me.lblPlusSign1.Name = "lblPlusSign1"
        Me.lblPlusSign1.Size = New System.Drawing.Size(25, 25)
        Me.lblPlusSign1.TabIndex = 3
        Me.lblPlusSign1.Text = "+"
        '
        'lblServiceCostLabel
        '
        Me.lblServiceCostLabel.AutoSize = True
        Me.lblServiceCostLabel.Location = New System.Drawing.Point(140, 35)
        Me.lblServiceCostLabel.Name = "lblServiceCostLabel"
        Me.lblServiceCostLabel.Size = New System.Drawing.Size(84, 16)
        Me.lblServiceCostLabel.TabIndex = 2
        Me.lblServiceCostLabel.Text = "Service Cost"
        '
        'lblTotalRoomCost
        '
        Me.lblTotalRoomCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRoomCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRoomCost.Location = New System.Drawing.Point(19, 61)
        Me.lblTotalRoomCost.Name = "lblTotalRoomCost"
        Me.lblTotalRoomCost.Size = New System.Drawing.Size(89, 50)
        Me.lblTotalRoomCost.TabIndex = 1
        Me.lblTotalRoomCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalRoomCostLabel
        '
        Me.lblTotalRoomCostLabel.AutoSize = True
        Me.lblTotalRoomCostLabel.Location = New System.Drawing.Point(26, 35)
        Me.lblTotalRoomCostLabel.Name = "lblTotalRoomCostLabel"
        Me.lblTotalRoomCostLabel.Size = New System.Drawing.Size(75, 16)
        Me.lblTotalRoomCostLabel.TabIndex = 0
        Me.lblTotalRoomCostLabel.Text = "Room Cost"
        '
        'lblEqualSign
        '
        Me.lblEqualSign.AutoSize = True
        Me.lblEqualSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqualSign.Location = New System.Drawing.Point(586, 65)
        Me.lblEqualSign.Name = "lblEqualSign"
        Me.lblEqualSign.Size = New System.Drawing.Size(37, 37)
        Me.lblEqualSign.TabIndex = 14
        Me.lblEqualSign.Text = "="
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.ForeColor = System.Drawing.Color.Red
        Me.lblTotalLabel.Location = New System.Drawing.Point(655, 22)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(56, 24)
        Me.lblTotalLabel.TabIndex = 15
        Me.lblTotalLabel.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Green
        Me.lblTotal.Location = New System.Drawing.Point(630, 53)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(106, 71)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBookingCostCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 696)
        Me.Controls.Add(Me.pnlBookingCostResult)
        Me.Controls.Add(Me.pnlRoomBookingInformation)
        Me.Controls.Add(Me.pnlBookingManipulation)
        Me.Controls.Add(Me.pnlBookingInformation)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblBookingCostCalculatorHeading)
        Me.Name = "frmBookingCostCalculator"
        Me.Text = "Paradise Booking Cost Calculator"
        Me.pnlBookingInformation.ResumeLayout(False)
        Me.gbxBookingInformation.ResumeLayout(False)
        Me.gbxBookingInformation.PerformLayout()
        Me.pnlBookingManipulation.ResumeLayout(False)
        Me.pnlRoomBookingInformation.ResumeLayout(False)
        CType(Me.dgvBookingInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBookingCostResult.ResumeLayout(False)
        Me.gbxBookingCostResult.ResumeLayout(False)
        Me.gbxBookingCostResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBookingCostCalculatorHeading As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents pnlBookingInformation As System.Windows.Forms.Panel
    Friend WithEvents pnlBookingManipulation As System.Windows.Forms.Panel
    Friend WithEvents pnlRoomBookingInformation As System.Windows.Forms.Panel
    Friend WithEvents dgvBookingInformation As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents gbxBookingInformation As System.Windows.Forms.GroupBox
    Friend WithEvents txtMembershipCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblAirportPickupCost As System.Windows.Forms.Label
    Friend WithEvents dtpArrivalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxMembershipCardOption As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRedeemedAirMilesOption As System.Windows.Forms.CheckBox
    Friend WithEvents cbxAirportPickupOption As System.Windows.Forms.CheckBox
    Friend WithEvents lblArrivalTimeLabel As System.Windows.Forms.Label
    Friend WithEvents lblArrivalDateLabel As System.Windows.Forms.Label
    Friend WithEvents lblBookingDateLabel As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents txtRedeemedAirMiles As System.Windows.Forms.TextBox
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents lblFullnameLabel As System.Windows.Forms.Label
    Friend WithEvents cbArrivalTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblBookingDate As System.Windows.Forms.Label
    Friend WithEvents room_type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents number_of_nights As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents number_of_adults As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents number_of_children As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents rates_per_night As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents extra_bed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents basic_room_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents to_be_removed As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlBookingCostResult As System.Windows.Forms.Panel
    Friend WithEvents gbxBookingCostResult As System.Windows.Forms.GroupBox
    Friend WithEvents lblMemberDiscountAmount As System.Windows.Forms.Label
    Friend WithEvents lblMemberDiscountLabel As System.Windows.Forms.Label
    Friend WithEvents lblMinusSign2 As System.Windows.Forms.Label
    Friend WithEvents lblAirRedeemAmount As System.Windows.Forms.Label
    Friend WithEvents lblAirRedeemLabel As System.Windows.Forms.Label
    Friend WithEvents lblMinusSign1 As System.Windows.Forms.Label
    Friend WithEvents lblTaxCharge As System.Windows.Forms.Label
    Friend WithEvents lblPlusSign2 As System.Windows.Forms.Label
    Friend WithEvents lblTaxChargeLabel As System.Windows.Forms.Label
    Friend WithEvents lblServiceCost As System.Windows.Forms.Label
    Friend WithEvents lblPlusSign1 As System.Windows.Forms.Label
    Friend WithEvents lblServiceCostLabel As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoomCost As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoomCostLabel As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblEqualSign As System.Windows.Forms.Label

End Class
