<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingsProcessingSystem
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
        Me.grpBookingDetails = New System.Windows.Forms.GroupBox
        Me.lblTotalValue = New System.Windows.Forms.Label
        Me.lblBookingDateValue = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblBookingDate = New System.Windows.Forms.Label
        Me.lblBookingIDValue = New System.Windows.Forms.Label
        Me.lblBookingID = New System.Windows.Forms.Label
        Me.lblManagerNameValue = New System.Windows.Forms.Label
        Me.lblManagerName = New System.Windows.Forms.Label
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.lblMobile = New System.Windows.Forms.Label
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.lblTelephone = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.cmbCountry = New System.Windows.Forms.ComboBox
        Me.lblCountry = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lblLastName = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.grpRoomDetails = New System.Windows.Forms.GroupBox
        Me.lblArrivalTimeUnit = New System.Windows.Forms.Label
        Me.lblRoomSizeMeasureUnit = New System.Windows.Forms.Label
        Me.nudNumberOfChildren = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.nudNumberOfAdults = New System.Windows.Forms.NumericUpDown
        Me.lblNumberOfAdults = New System.Windows.Forms.Label
        Me.nudNumberOfNights = New System.Windows.Forms.NumericUpDown
        Me.lblNumberOfNights = New System.Windows.Forms.Label
        Me.nudArrivalTime = New System.Windows.Forms.NumericUpDown
        Me.lblArrivalTime = New System.Windows.Forms.Label
        Me.dtpArrivalDate = New System.Windows.Forms.DateTimePicker
        Me.lblArrivalDate = New System.Windows.Forms.Label
        Me.lblRoomRateValue = New System.Windows.Forms.Label
        Me.lblRoomRate = New System.Windows.Forms.Label
        Me.lblRoomSizeValue = New System.Windows.Forms.Label
        Me.lblRoomSize = New System.Windows.Forms.Label
        Me.lblRoomTypeValue = New System.Windows.Forms.Label
        Me.lblRoomType = New System.Windows.Forms.Label
        Me.cmbRoomTypeID = New System.Windows.Forms.ComboBox
        Me.lblRoomTypeID = New System.Windows.Forms.Label
        Me.grpBookings = New System.Windows.Forms.GroupBox
        Me.dgvBookings = New System.Windows.Forms.DataGridView
        Me.room_type_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_size = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.arrival_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.arrival_time = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.number_of_nights = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.number_of_adults = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.number_of_children = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.extra_bed_cost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_cost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.remove_or_not = New System.Windows.Forms.DataGridViewButtonColumn
        Me.mgrFile = New System.Windows.Forms.ToolStripMenuItem
        Me.miAddBooking = New System.Windows.Forms.ToolStripMenuItem
        Me.miReset = New System.Windows.Forms.ToolStripMenuItem
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem
        Me.msMenu = New System.Windows.Forms.MenuStrip
        Me.mgrEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.miClearCustomerDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.miClearRoomDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.miClearAllBookings = New System.Windows.Forms.ToolStripMenuItem
        Me.mgrReport = New System.Windows.Forms.ToolStripMenuItem
        Me.miCreateHTMLForRoomTypes = New System.Windows.Forms.ToolStripMenuItem
        Me.miSearchBookings = New System.Windows.Forms.ToolStripMenuItem
        Me.grpBookingDetails.SuspendLayout()
        Me.grpCustomerDetails.SuspendLayout()
        Me.grpRoomDetails.SuspendLayout()
        CType(Me.nudNumberOfChildren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfAdults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfNights, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudArrivalTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBookings.SuspendLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBookingDetails
        '
        Me.grpBookingDetails.Controls.Add(Me.lblTotalValue)
        Me.grpBookingDetails.Controls.Add(Me.lblBookingDateValue)
        Me.grpBookingDetails.Controls.Add(Me.lblTotal)
        Me.grpBookingDetails.Controls.Add(Me.lblBookingDate)
        Me.grpBookingDetails.Controls.Add(Me.lblBookingIDValue)
        Me.grpBookingDetails.Controls.Add(Me.lblBookingID)
        Me.grpBookingDetails.Controls.Add(Me.lblManagerNameValue)
        Me.grpBookingDetails.Controls.Add(Me.lblManagerName)
        Me.grpBookingDetails.Location = New System.Drawing.Point(16, 28)
        Me.grpBookingDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBookingDetails.Name = "grpBookingDetails"
        Me.grpBookingDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBookingDetails.Size = New System.Drawing.Size(928, 95)
        Me.grpBookingDetails.TabIndex = 0
        Me.grpBookingDetails.TabStop = False
        Me.grpBookingDetails.Text = "Booking Details"
        '
        'lblTotalValue
        '
        Me.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValue.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTotalValue.Location = New System.Drawing.Point(716, 23)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(189, 59)
        Me.lblTotalValue.TabIndex = 7
        Me.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookingDateValue
        '
        Me.lblBookingDateValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBookingDateValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingDateValue.Location = New System.Drawing.Point(131, 57)
        Me.lblBookingDateValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookingDateValue.Name = "lblBookingDateValue"
        Me.lblBookingDateValue.Size = New System.Drawing.Size(245, 25)
        Me.lblBookingDateValue.TabIndex = 5
        Me.lblBookingDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(657, 45)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 18)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total"
        '
        'lblBookingDate
        '
        Me.lblBookingDate.AutoSize = True
        Me.lblBookingDate.Location = New System.Drawing.Point(21, 61)
        Me.lblBookingDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(90, 16)
        Me.lblBookingDate.TabIndex = 4
        Me.lblBookingDate.Text = "Booking Date"
        '
        'lblBookingIDValue
        '
        Me.lblBookingIDValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBookingIDValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingIDValue.Location = New System.Drawing.Point(496, 57)
        Me.lblBookingIDValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookingIDValue.Name = "lblBookingIDValue"
        Me.lblBookingIDValue.Size = New System.Drawing.Size(122, 25)
        Me.lblBookingIDValue.TabIndex = 3
        Me.lblBookingIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Location = New System.Drawing.Point(414, 61)
        Me.lblBookingID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(74, 16)
        Me.lblBookingID.TabIndex = 2
        Me.lblBookingID.Text = "Booking ID"
        '
        'lblManagerNameValue
        '
        Me.lblManagerNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblManagerNameValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagerNameValue.Location = New System.Drawing.Point(131, 24)
        Me.lblManagerNameValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManagerNameValue.Name = "lblManagerNameValue"
        Me.lblManagerNameValue.Size = New System.Drawing.Size(487, 25)
        Me.lblManagerNameValue.TabIndex = 1
        Me.lblManagerNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblManagerName
        '
        Me.lblManagerName.AutoSize = True
        Me.lblManagerName.Location = New System.Drawing.Point(21, 28)
        Me.lblManagerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManagerName.Name = "lblManagerName"
        Me.lblManagerName.Size = New System.Drawing.Size(102, 16)
        Me.lblManagerName.TabIndex = 0
        Me.lblManagerName.Text = "Manager Name"
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.Controls.Add(Me.txtMobile)
        Me.grpCustomerDetails.Controls.Add(Me.lblMobile)
        Me.grpCustomerDetails.Controls.Add(Me.txtTelephone)
        Me.grpCustomerDetails.Controls.Add(Me.lblTelephone)
        Me.grpCustomerDetails.Controls.Add(Me.txtEmail)
        Me.grpCustomerDetails.Controls.Add(Me.lblEmail)
        Me.grpCustomerDetails.Controls.Add(Me.txtCity)
        Me.grpCustomerDetails.Controls.Add(Me.cmbCountry)
        Me.grpCustomerDetails.Controls.Add(Me.lblCountry)
        Me.grpCustomerDetails.Controls.Add(Me.lblCity)
        Me.grpCustomerDetails.Controls.Add(Me.txtAddress)
        Me.grpCustomerDetails.Controls.Add(Me.lblAddress)
        Me.grpCustomerDetails.Controls.Add(Me.txtFirstName)
        Me.grpCustomerDetails.Controls.Add(Me.lblFirstName)
        Me.grpCustomerDetails.Controls.Add(Me.txtLastName)
        Me.grpCustomerDetails.Controls.Add(Me.lblLastName)
        Me.grpCustomerDetails.Controls.Add(Me.cmbTitle)
        Me.grpCustomerDetails.Controls.Add(Me.lblTitle)
        Me.grpCustomerDetails.Location = New System.Drawing.Point(13, 131)
        Me.grpCustomerDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCustomerDetails.Size = New System.Drawing.Size(463, 326)
        Me.grpCustomerDetails.TabIndex = 1
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Customer Details"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(134, 288)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(180, 22)
        Me.txtMobile.TabIndex = 17
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(24, 291)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(49, 16)
        Me.lblMobile.TabIndex = 16
        Me.lblMobile.Text = "Mobile"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(134, 255)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(180, 22)
        Me.txtTelephone.TabIndex = 15
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(24, 258)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(74, 16)
        Me.lblTelephone.TabIndex = 14
        Me.lblTelephone.Text = "Telephone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(134, 222)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(303, 22)
        Me.txtEmail.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(24, 225)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 16)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(134, 157)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(245, 22)
        Me.txtCity.TabIndex = 9
        '
        'cmbCountry
        '
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Items.AddRange(New Object() {"Afghanistan", "Akrotiri", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Ashmore and Cartier Islands", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Bassas da India", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Bouvet Island", "Brazil", "British Indian Ocean Territory", "British Virgin Islands", "Brunei", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Clipperton Island", "Cocos (Keeling) Islands", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Cook Islands", "Coral Sea Islands", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Dhekelia", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Europa Island", "Falkland Islands (Islas Malvinas)", "Faroe Islands", "Fiji", "Finland", "France", "French Guiana", "French Polynesia", "French Southern and Antarctic Lands", "Gabon", "Gambia, The", "Gaza Strip", "Georgia", "Germany", "Ghana", "Gibraltar", "Glorioso Islands", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard Island and McDonald Islands", "Holy See (Vatican City)", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Jan Mayen", "Japan", "Jersey", "Jordan", "Juan de Nova Island", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montserrat", "Morocco", "Mozambique", "Namibia", "Nauru", "Navassa Island", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paracel Islands", "Paraguay", "Peru", "Philippines", "Pitcairn Islands", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russia", "Rwanda", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Pierre and Miquelon", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia and Montenegro", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia and the South Sandwich Islands", "Spain", "Spratly Islands", "Sri Lanka", "Sudan", "Suriname", "Svalbard", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tromelin Island", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Virgin Islands", "Wake Island", "Wallis and Futuna", "West Bank", "Western Sahara", "Yemen", "Zambia", "Zimbabwe"})
        Me.cmbCountry.Location = New System.Drawing.Point(134, 190)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(303, 24)
        Me.cmbCountry.TabIndex = 11
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(24, 193)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(53, 16)
        Me.lblCountry.TabIndex = 10
        Me.lblCountry.Text = "Country"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(24, 160)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(30, 16)
        Me.lblCity.TabIndex = 8
        Me.lblCity.Text = "City"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(134, 124)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(303, 22)
        Me.txtAddress.TabIndex = 7
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(24, 127)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(59, 16)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Address"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(134, 91)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 22)
        Me.txtFirstName.TabIndex = 5
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(24, 94)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(73, 16)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(134, 58)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(180, 22)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(24, 61)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(73, 16)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'cmbTitle
        '
        Me.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr.", "Ms."})
        Me.cmbTitle.Location = New System.Drawing.Point(134, 25)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(53, 24)
        Me.cmbTitle.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(24, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(34, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'grpRoomDetails
        '
        Me.grpRoomDetails.Controls.Add(Me.lblArrivalTimeUnit)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomSizeMeasureUnit)
        Me.grpRoomDetails.Controls.Add(Me.nudNumberOfChildren)
        Me.grpRoomDetails.Controls.Add(Me.Label1)
        Me.grpRoomDetails.Controls.Add(Me.nudNumberOfAdults)
        Me.grpRoomDetails.Controls.Add(Me.lblNumberOfAdults)
        Me.grpRoomDetails.Controls.Add(Me.nudNumberOfNights)
        Me.grpRoomDetails.Controls.Add(Me.lblNumberOfNights)
        Me.grpRoomDetails.Controls.Add(Me.nudArrivalTime)
        Me.grpRoomDetails.Controls.Add(Me.lblArrivalTime)
        Me.grpRoomDetails.Controls.Add(Me.dtpArrivalDate)
        Me.grpRoomDetails.Controls.Add(Me.lblArrivalDate)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomRateValue)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomRate)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomSizeValue)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomSize)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomTypeValue)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomType)
        Me.grpRoomDetails.Controls.Add(Me.cmbRoomTypeID)
        Me.grpRoomDetails.Controls.Add(Me.lblRoomTypeID)
        Me.grpRoomDetails.Location = New System.Drawing.Point(484, 131)
        Me.grpRoomDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRoomDetails.Name = "grpRoomDetails"
        Me.grpRoomDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRoomDetails.Size = New System.Drawing.Size(460, 326)
        Me.grpRoomDetails.TabIndex = 2
        Me.grpRoomDetails.TabStop = False
        Me.grpRoomDetails.Text = "Room Details"
        '
        'lblArrivalTimeUnit
        '
        Me.lblArrivalTimeUnit.AutoSize = True
        Me.lblArrivalTimeUnit.Location = New System.Drawing.Point(214, 193)
        Me.lblArrivalTimeUnit.Name = "lblArrivalTimeUnit"
        Me.lblArrivalTimeUnit.Size = New System.Drawing.Size(28, 16)
        Me.lblArrivalTimeUnit.TabIndex = 19
        Me.lblArrivalTimeUnit.Text = "PM"
        '
        'lblRoomSizeMeasureUnit
        '
        Me.lblRoomSizeMeasureUnit.AutoSize = True
        Me.lblRoomSizeMeasureUnit.Location = New System.Drawing.Point(302, 94)
        Me.lblRoomSizeMeasureUnit.Name = "lblRoomSizeMeasureUnit"
        Me.lblRoomSizeMeasureUnit.Size = New System.Drawing.Size(102, 16)
        Me.lblRoomSizeMeasureUnit.TabIndex = 18
        Me.lblRoomSizeMeasureUnit.Text = "(square metres)"
        '
        'nudNumberOfChildren
        '
        Me.nudNumberOfChildren.Location = New System.Drawing.Point(153, 289)
        Me.nudNumberOfChildren.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudNumberOfChildren.Name = "nudNumberOfChildren"
        Me.nudNumberOfChildren.Size = New System.Drawing.Size(55, 22)
        Me.nudNumberOfChildren.TabIndex = 17
        Me.nudNumberOfChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Number of Children"
        '
        'nudNumberOfAdults
        '
        Me.nudNumberOfAdults.Location = New System.Drawing.Point(153, 256)
        Me.nudNumberOfAdults.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudNumberOfAdults.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfAdults.Name = "nudNumberOfAdults"
        Me.nudNumberOfAdults.Size = New System.Drawing.Size(55, 22)
        Me.nudNumberOfAdults.TabIndex = 15
        Me.nudNumberOfAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNumberOfAdults.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNumberOfAdults
        '
        Me.lblNumberOfAdults.AutoSize = True
        Me.lblNumberOfAdults.Location = New System.Drawing.Point(25, 258)
        Me.lblNumberOfAdults.Name = "lblNumberOfAdults"
        Me.lblNumberOfAdults.Size = New System.Drawing.Size(110, 16)
        Me.lblNumberOfAdults.TabIndex = 14
        Me.lblNumberOfAdults.Text = "Number of Adults"
        '
        'nudNumberOfNights
        '
        Me.nudNumberOfNights.Location = New System.Drawing.Point(153, 223)
        Me.nudNumberOfNights.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudNumberOfNights.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfNights.Name = "nudNumberOfNights"
        Me.nudNumberOfNights.Size = New System.Drawing.Size(55, 22)
        Me.nudNumberOfNights.TabIndex = 13
        Me.nudNumberOfNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNumberOfNights.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Location = New System.Drawing.Point(25, 225)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(111, 16)
        Me.lblNumberOfNights.TabIndex = 12
        Me.lblNumberOfNights.Text = "Number of Nights"
        '
        'nudArrivalTime
        '
        Me.nudArrivalTime.Location = New System.Drawing.Point(153, 191)
        Me.nudArrivalTime.Maximum = New Decimal(New Integer() {11, 0, 0, 0})
        Me.nudArrivalTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudArrivalTime.Name = "nudArrivalTime"
        Me.nudArrivalTime.Size = New System.Drawing.Size(55, 22)
        Me.nudArrivalTime.TabIndex = 11
        Me.nudArrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudArrivalTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblArrivalTime
        '
        Me.lblArrivalTime.AutoSize = True
        Me.lblArrivalTime.Location = New System.Drawing.Point(25, 193)
        Me.lblArrivalTime.Name = "lblArrivalTime"
        Me.lblArrivalTime.Size = New System.Drawing.Size(80, 16)
        Me.lblArrivalTime.TabIndex = 10
        Me.lblArrivalTime.Text = "Arrival Time"
        '
        'dtpArrivalDate
        '
        Me.dtpArrivalDate.Location = New System.Drawing.Point(153, 155)
        Me.dtpArrivalDate.Name = "dtpArrivalDate"
        Me.dtpArrivalDate.Size = New System.Drawing.Size(284, 22)
        Me.dtpArrivalDate.TabIndex = 9
        '
        'lblArrivalDate
        '
        Me.lblArrivalDate.AutoSize = True
        Me.lblArrivalDate.Location = New System.Drawing.Point(25, 160)
        Me.lblArrivalDate.Name = "lblArrivalDate"
        Me.lblArrivalDate.Size = New System.Drawing.Size(78, 16)
        Me.lblArrivalDate.TabIndex = 8
        Me.lblArrivalDate.Text = "Arrival Date"
        '
        'lblRoomRateValue
        '
        Me.lblRoomRateValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomRateValue.Location = New System.Drawing.Point(153, 123)
        Me.lblRoomRateValue.Name = "lblRoomRateValue"
        Me.lblRoomRateValue.Size = New System.Drawing.Size(143, 25)
        Me.lblRoomRateValue.TabIndex = 7
        Me.lblRoomRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRoomRate
        '
        Me.lblRoomRate.AutoSize = True
        Me.lblRoomRate.Location = New System.Drawing.Point(25, 127)
        Me.lblRoomRate.Name = "lblRoomRate"
        Me.lblRoomRate.Size = New System.Drawing.Size(77, 16)
        Me.lblRoomRate.TabIndex = 6
        Me.lblRoomRate.Text = "Room Rate"
        '
        'lblRoomSizeValue
        '
        Me.lblRoomSizeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomSizeValue.Location = New System.Drawing.Point(153, 90)
        Me.lblRoomSizeValue.Name = "lblRoomSizeValue"
        Me.lblRoomSizeValue.Size = New System.Drawing.Size(143, 25)
        Me.lblRoomSizeValue.TabIndex = 5
        Me.lblRoomSizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRoomSize
        '
        Me.lblRoomSize.AutoSize = True
        Me.lblRoomSize.Location = New System.Drawing.Point(25, 94)
        Me.lblRoomSize.Name = "lblRoomSize"
        Me.lblRoomSize.Size = New System.Drawing.Size(74, 16)
        Me.lblRoomSize.TabIndex = 4
        Me.lblRoomSize.Text = "Room Size"
        '
        'lblRoomTypeValue
        '
        Me.lblRoomTypeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomTypeValue.Location = New System.Drawing.Point(153, 57)
        Me.lblRoomTypeValue.Name = "lblRoomTypeValue"
        Me.lblRoomTypeValue.Size = New System.Drawing.Size(143, 25)
        Me.lblRoomTypeValue.TabIndex = 3
        Me.lblRoomTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Location = New System.Drawing.Point(25, 61)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(80, 16)
        Me.lblRoomType.TabIndex = 2
        Me.lblRoomType.Text = "Room Type"
        '
        'cmbRoomTypeID
        '
        Me.cmbRoomTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoomTypeID.FormattingEnabled = True
        Me.cmbRoomTypeID.Location = New System.Drawing.Point(153, 25)
        Me.cmbRoomTypeID.Name = "cmbRoomTypeID"
        Me.cmbRoomTypeID.Size = New System.Drawing.Size(55, 24)
        Me.cmbRoomTypeID.TabIndex = 1
        '
        'lblRoomTypeID
        '
        Me.lblRoomTypeID.AutoSize = True
        Me.lblRoomTypeID.Location = New System.Drawing.Point(25, 28)
        Me.lblRoomTypeID.Name = "lblRoomTypeID"
        Me.lblRoomTypeID.Size = New System.Drawing.Size(96, 16)
        Me.lblRoomTypeID.TabIndex = 0
        Me.lblRoomTypeID.Text = "Room Type ID"
        '
        'grpBookings
        '
        Me.grpBookings.Controls.Add(Me.dgvBookings)
        Me.grpBookings.Location = New System.Drawing.Point(13, 465)
        Me.grpBookings.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBookings.Name = "grpBookings"
        Me.grpBookings.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBookings.Size = New System.Drawing.Size(931, 224)
        Me.grpBookings.TabIndex = 3
        Me.grpBookings.TabStop = False
        Me.grpBookings.Text = "Bookings"
        '
        'dgvBookings
        '
        Me.dgvBookings.AllowUserToAddRows = False
        Me.dgvBookings.AllowUserToDeleteRows = False
        Me.dgvBookings.AllowUserToOrderColumns = True
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.room_type_id, Me.room_type, Me.room_size, Me.room_rate, Me.arrival_date, Me.arrival_time, Me.number_of_nights, Me.number_of_adults, Me.number_of_children, Me.extra_bed_cost, Me.room_cost, Me.subtotal, Me.remove_or_not})
        Me.dgvBookings.Location = New System.Drawing.Point(7, 22)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.ReadOnly = True
        Me.dgvBookings.Size = New System.Drawing.Size(917, 195)
        Me.dgvBookings.TabIndex = 0
        '
        'room_type_id
        '
        Me.room_type_id.HeaderText = "Room Type ID"
        Me.room_type_id.Name = "room_type_id"
        Me.room_type_id.ReadOnly = True
        '
        'room_type
        '
        Me.room_type.HeaderText = "Room Type"
        Me.room_type.Name = "room_type"
        Me.room_type.ReadOnly = True
        '
        'room_size
        '
        Me.room_size.HeaderText = "Room Size"
        Me.room_size.Name = "room_size"
        Me.room_size.ReadOnly = True
        '
        'room_rate
        '
        Me.room_rate.HeaderText = "Room Rate"
        Me.room_rate.Name = "room_rate"
        Me.room_rate.ReadOnly = True
        '
        'arrival_date
        '
        Me.arrival_date.HeaderText = "Arrival Date"
        Me.arrival_date.Name = "arrival_date"
        Me.arrival_date.ReadOnly = True
        '
        'arrival_time
        '
        Me.arrival_time.HeaderText = "Arrival Time"
        Me.arrival_time.Name = "arrival_time"
        Me.arrival_time.ReadOnly = True
        '
        'number_of_nights
        '
        Me.number_of_nights.HeaderText = "Number of Nights"
        Me.number_of_nights.Name = "number_of_nights"
        Me.number_of_nights.ReadOnly = True
        '
        'number_of_adults
        '
        Me.number_of_adults.HeaderText = "Number of Adults"
        Me.number_of_adults.Name = "number_of_adults"
        Me.number_of_adults.ReadOnly = True
        '
        'number_of_children
        '
        Me.number_of_children.HeaderText = "Number of Children"
        Me.number_of_children.Name = "number_of_children"
        Me.number_of_children.ReadOnly = True
        '
        'extra_bed_cost
        '
        Me.extra_bed_cost.HeaderText = "Extra Bed Cost"
        Me.extra_bed_cost.Name = "extra_bed_cost"
        Me.extra_bed_cost.ReadOnly = True
        '
        'room_cost
        '
        Me.room_cost.HeaderText = "Room Cost"
        Me.room_cost.Name = "room_cost"
        Me.room_cost.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'remove_or_not
        '
        Me.remove_or_not.HeaderText = "Remove?"
        Me.remove_or_not.Name = "remove_or_not"
        Me.remove_or_not.ReadOnly = True
        Me.remove_or_not.Text = "Remove"
        Me.remove_or_not.ToolTipText = "Click Remove button to remove this booking!"
        Me.remove_or_not.UseColumnTextForButtonValue = True
        '
        'mgrFile
        '
        Me.mgrFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAddBooking, Me.miReset, Me.miExit})
        Me.mgrFile.Name = "mgrFile"
        Me.mgrFile.Size = New System.Drawing.Size(37, 20)
        Me.mgrFile.Text = "File"
        '
        'miAddBooking
        '
        Me.miAddBooking.Name = "miAddBooking"
        Me.miAddBooking.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.miAddBooking.Size = New System.Drawing.Size(185, 22)
        Me.miAddBooking.Text = "Add Booking"
        '
        'miReset
        '
        Me.miReset.Name = "miReset"
        Me.miReset.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.miReset.Size = New System.Drawing.Size(185, 22)
        Me.miReset.Text = "Reset"
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.miExit.Size = New System.Drawing.Size(185, 22)
        Me.miExit.Text = "Exit"
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mgrFile, Me.mgrEdit, Me.mgrReport})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(957, 24)
        Me.msMenu.TabIndex = 4
        Me.msMenu.Text = "MenuStrip1"
        '
        'mgrEdit
        '
        Me.mgrEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miClearCustomerDetails, Me.miClearRoomDetails, Me.miClearAllBookings})
        Me.mgrEdit.Name = "mgrEdit"
        Me.mgrEdit.Size = New System.Drawing.Size(39, 20)
        Me.mgrEdit.Text = "Edit"
        '
        'miClearCustomerDetails
        '
        Me.miClearCustomerDetails.Name = "miClearCustomerDetails"
        Me.miClearCustomerDetails.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.miClearCustomerDetails.Size = New System.Drawing.Size(236, 22)
        Me.miClearCustomerDetails.Text = "Clear Customer Details"
        '
        'miClearRoomDetails
        '
        Me.miClearRoomDetails.Name = "miClearRoomDetails"
        Me.miClearRoomDetails.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.miClearRoomDetails.Size = New System.Drawing.Size(236, 22)
        Me.miClearRoomDetails.Text = "Clear Room Details"
        '
        'miClearAllBookings
        '
        Me.miClearAllBookings.Name = "miClearAllBookings"
        Me.miClearAllBookings.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.miClearAllBookings.Size = New System.Drawing.Size(236, 22)
        Me.miClearAllBookings.Text = "Clear All Bookings"
        '
        'mgrReport
        '
        Me.mgrReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCreateHTMLForRoomTypes, Me.miSearchBookings})
        Me.mgrReport.Name = "mgrReport"
        Me.mgrReport.Size = New System.Drawing.Size(54, 20)
        Me.mgrReport.Text = "Report"
        '
        'miCreateHTMLForRoomTypes
        '
        Me.miCreateHTMLForRoomTypes.Name = "miCreateHTMLForRoomTypes"
        Me.miCreateHTMLForRoomTypes.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.miCreateHTMLForRoomTypes.Size = New System.Drawing.Size(276, 22)
        Me.miCreateHTMLForRoomTypes.Text = "Create HTML For Room Types"
        '
        'miSearchBookings
        '
        Me.miSearchBookings.Name = "miSearchBookings"
        Me.miSearchBookings.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.miSearchBookings.Size = New System.Drawing.Size(276, 22)
        Me.miSearchBookings.Text = "Search Bookings"
        '
        'frmBookingsProcessingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 702)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpBookings)
        Me.Controls.Add(Me.grpRoomDetails)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Controls.Add(Me.grpBookingDetails)
        Me.Controls.Add(Me.msMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.msMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBookingsProcessingSystem"
        Me.Text = "Paradise Bookings Process System"
        Me.grpBookingDetails.ResumeLayout(False)
        Me.grpBookingDetails.PerformLayout()
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.grpRoomDetails.ResumeLayout(False)
        Me.grpRoomDetails.PerformLayout()
        CType(Me.nudNumberOfChildren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfAdults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfNights, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudArrivalTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBookings.ResumeLayout(False)
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBookingDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpRoomDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpBookings As System.Windows.Forms.GroupBox
    Friend WithEvents lblBookingDateValue As System.Windows.Forms.Label
    Friend WithEvents lblBookingDate As System.Windows.Forms.Label
    Friend WithEvents lblBookingIDValue As System.Windows.Forms.Label
    Friend WithEvents lblBookingID As System.Windows.Forms.Label
    Friend WithEvents lblManagerNameValue As System.Windows.Forms.Label
    Friend WithEvents lblManagerName As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblRoomType As System.Windows.Forms.Label
    Friend WithEvents cmbRoomTypeID As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoomTypeID As System.Windows.Forms.Label
    Friend WithEvents lblRoomSize As System.Windows.Forms.Label
    Friend WithEvents lblRoomTypeValue As System.Windows.Forms.Label
    Friend WithEvents lblArrivalDate As System.Windows.Forms.Label
    Friend WithEvents lblRoomRateValue As System.Windows.Forms.Label
    Friend WithEvents lblRoomRate As System.Windows.Forms.Label
    Friend WithEvents lblRoomSizeValue As System.Windows.Forms.Label
    Friend WithEvents dtpArrivalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents nudArrivalTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblArrivalTime As System.Windows.Forms.Label
    Friend WithEvents nudNumberOfChildren As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudNumberOfAdults As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNumberOfAdults As System.Windows.Forms.Label
    Friend WithEvents nudNumberOfNights As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNumberOfNights As System.Windows.Forms.Label
    Friend WithEvents lblArrivalTimeUnit As System.Windows.Forms.Label
    Friend WithEvents lblRoomSizeMeasureUnit As System.Windows.Forms.Label
    Friend WithEvents dgvBookings As System.Windows.Forms.DataGridView
    Friend WithEvents room_type_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_size As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents arrival_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents arrival_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number_of_nights As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number_of_adults As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number_of_children As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents extra_bed_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remove_or_not As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblTotalValue As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents mgrFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAddBooking As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mgrEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClearCustomerDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClearRoomDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClearAllBookings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mgrReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCreateHTMLForRoomTypes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miSearchBookings As System.Windows.Forms.ToolStripMenuItem

End Class
