<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.grpSearchConditions = New System.Windows.Forms.GroupBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cbxTypePresidentialSuite = New System.Windows.Forms.CheckBox
        Me.cbxTypeJuniorSuite = New System.Windows.Forms.CheckBox
        Me.cbxTypePremiumDeluxe = New System.Windows.Forms.CheckBox
        Me.cbxTypeDeluxe = New System.Windows.Forms.CheckBox
        Me.cbxTypeSuperior = New System.Windows.Forms.CheckBox
        Me.lblRoomTypeHeading = New System.Windows.Forms.Label
        Me.txtMaxRoomCost = New System.Windows.Forms.TextBox
        Me.lblMaxRoomCost = New System.Windows.Forms.Label
        Me.txtMinRoomCost = New System.Windows.Forms.TextBox
        Me.lblMinRoomCost = New System.Windows.Forms.Label
        Me.txtCustomerLastName = New System.Windows.Forms.TextBox
        Me.txtManagerName = New System.Windows.Forms.TextBox
        Me.rdbSearchByRoomCost = New System.Windows.Forms.RadioButton
        Me.rdbSearchByCustomerLastName = New System.Windows.Forms.RadioButton
        Me.rdbSearchByManagerName = New System.Windows.Forms.RadioButton
        Me.lblSearchConditionHeading = New System.Windows.Forms.Label
        Me.grpSearchResult = New System.Windows.Forms.GroupBox
        Me.dgvResult = New System.Windows.Forms.DataGridView
        Me.manager_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.booking_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.booking_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.customer_lastname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.customer_firstname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.number_of_nights = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.number_of_adults = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.number_of_children = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.room_cost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpSearchConditions.SuspendLayout()
        Me.grpSearchResult.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSearchConditions
        '
        Me.grpSearchConditions.Controls.Add(Me.btnClear)
        Me.grpSearchConditions.Controls.Add(Me.btnSearch)
        Me.grpSearchConditions.Controls.Add(Me.cbxTypePresidentialSuite)
        Me.grpSearchConditions.Controls.Add(Me.cbxTypeJuniorSuite)
        Me.grpSearchConditions.Controls.Add(Me.cbxTypePremiumDeluxe)
        Me.grpSearchConditions.Controls.Add(Me.cbxTypeDeluxe)
        Me.grpSearchConditions.Controls.Add(Me.cbxTypeSuperior)
        Me.grpSearchConditions.Controls.Add(Me.lblRoomTypeHeading)
        Me.grpSearchConditions.Controls.Add(Me.txtMaxRoomCost)
        Me.grpSearchConditions.Controls.Add(Me.lblMaxRoomCost)
        Me.grpSearchConditions.Controls.Add(Me.txtMinRoomCost)
        Me.grpSearchConditions.Controls.Add(Me.lblMinRoomCost)
        Me.grpSearchConditions.Controls.Add(Me.txtCustomerLastName)
        Me.grpSearchConditions.Controls.Add(Me.txtManagerName)
        Me.grpSearchConditions.Controls.Add(Me.rdbSearchByRoomCost)
        Me.grpSearchConditions.Controls.Add(Me.rdbSearchByCustomerLastName)
        Me.grpSearchConditions.Controls.Add(Me.rdbSearchByManagerName)
        Me.grpSearchConditions.Controls.Add(Me.lblSearchConditionHeading)
        Me.grpSearchConditions.Location = New System.Drawing.Point(16, 15)
        Me.grpSearchConditions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSearchConditions.Name = "grpSearchConditions"
        Me.grpSearchConditions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSearchConditions.Size = New System.Drawing.Size(789, 259)
        Me.grpSearchConditions.TabIndex = 0
        Me.grpSearchConditions.TabStop = False
        Me.grpSearchConditions.Text = "Search Conditions"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(645, 114)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 29)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(645, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 78)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxTypePresidentialSuite
        '
        Me.cbxTypePresidentialSuite.AutoSize = True
        Me.cbxTypePresidentialSuite.Location = New System.Drawing.Point(585, 215)
        Me.cbxTypePresidentialSuite.Name = "cbxTypePresidentialSuite"
        Me.cbxTypePresidentialSuite.Size = New System.Drawing.Size(160, 20)
        Me.cbxTypePresidentialSuite.TabIndex = 15
        Me.cbxTypePresidentialSuite.Text = "Presidential Suite (PS)"
        Me.cbxTypePresidentialSuite.UseVisualStyleBackColor = True
        '
        'cbxTypeJuniorSuite
        '
        Me.cbxTypeJuniorSuite.AutoSize = True
        Me.cbxTypeJuniorSuite.Location = New System.Drawing.Point(447, 215)
        Me.cbxTypeJuniorSuite.Name = "cbxTypeJuniorSuite"
        Me.cbxTypeJuniorSuite.Size = New System.Drawing.Size(123, 20)
        Me.cbxTypeJuniorSuite.TabIndex = 14
        Me.cbxTypeJuniorSuite.Text = "Junior Suite (JS)"
        Me.cbxTypeJuniorSuite.UseVisualStyleBackColor = True
        '
        'cbxTypePremiumDeluxe
        '
        Me.cbxTypePremiumDeluxe.AutoSize = True
        Me.cbxTypePremiumDeluxe.Location = New System.Drawing.Point(276, 215)
        Me.cbxTypePremiumDeluxe.Name = "cbxTypePremiumDeluxe"
        Me.cbxTypePremiumDeluxe.Size = New System.Drawing.Size(155, 20)
        Me.cbxTypePremiumDeluxe.TabIndex = 13
        Me.cbxTypePremiumDeluxe.Text = "Premium Deluxe (PD)"
        Me.cbxTypePremiumDeluxe.UseVisualStyleBackColor = True
        '
        'cbxTypeDeluxe
        '
        Me.cbxTypeDeluxe.AutoSize = True
        Me.cbxTypeDeluxe.Location = New System.Drawing.Point(161, 215)
        Me.cbxTypeDeluxe.Name = "cbxTypeDeluxe"
        Me.cbxTypeDeluxe.Size = New System.Drawing.Size(99, 20)
        Me.cbxTypeDeluxe.TabIndex = 12
        Me.cbxTypeDeluxe.Text = "Deluxe (DE)"
        Me.cbxTypeDeluxe.UseVisualStyleBackColor = True
        '
        'cbxTypeSuperior
        '
        Me.cbxTypeSuperior.AutoSize = True
        Me.cbxTypeSuperior.Location = New System.Drawing.Point(37, 215)
        Me.cbxTypeSuperior.Name = "cbxTypeSuperior"
        Me.cbxTypeSuperior.Size = New System.Drawing.Size(108, 20)
        Me.cbxTypeSuperior.TabIndex = 11
        Me.cbxTypeSuperior.Text = "Superior (SU)"
        Me.cbxTypeSuperior.UseVisualStyleBackColor = True
        '
        'lblRoomTypeHeading
        '
        Me.lblRoomTypeHeading.AutoSize = True
        Me.lblRoomTypeHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomTypeHeading.Location = New System.Drawing.Point(33, 183)
        Me.lblRoomTypeHeading.Name = "lblRoomTypeHeading"
        Me.lblRoomTypeHeading.Size = New System.Drawing.Size(125, 20)
        Me.lblRoomTypeHeading.TabIndex = 10
        Me.lblRoomTypeHeading.Text = "Room Type(s):"
        '
        'txtMaxRoomCost
        '
        Me.txtMaxRoomCost.Enabled = False
        Me.txtMaxRoomCost.Location = New System.Drawing.Point(469, 122)
        Me.txtMaxRoomCost.Name = "txtMaxRoomCost"
        Me.txtMaxRoomCost.Size = New System.Drawing.Size(120, 22)
        Me.txtMaxRoomCost.TabIndex = 9
        '
        'lblMaxRoomCost
        '
        Me.lblMaxRoomCost.AutoSize = True
        Me.lblMaxRoomCost.Location = New System.Drawing.Point(444, 125)
        Me.lblMaxRoomCost.Name = "lblMaxRoomCost"
        Me.lblMaxRoomCost.Size = New System.Drawing.Size(19, 16)
        Me.lblMaxRoomCost.TabIndex = 8
        Me.lblMaxRoomCost.Text = "to"
        '
        'txtMinRoomCost
        '
        Me.txtMinRoomCost.Enabled = False
        Me.txtMinRoomCost.Location = New System.Drawing.Point(276, 122)
        Me.txtMinRoomCost.Name = "txtMinRoomCost"
        Me.txtMinRoomCost.Size = New System.Drawing.Size(120, 22)
        Me.txtMinRoomCost.TabIndex = 7
        '
        'lblMinRoomCost
        '
        Me.lblMinRoomCost.AutoSize = True
        Me.lblMinRoomCost.Location = New System.Drawing.Point(235, 125)
        Me.lblMinRoomCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinRoomCost.Name = "lblMinRoomCost"
        Me.lblMinRoomCost.Size = New System.Drawing.Size(34, 16)
        Me.lblMinRoomCost.TabIndex = 6
        Me.lblMinRoomCost.Text = "from"
        '
        'txtCustomerLastName
        '
        Me.txtCustomerLastName.Enabled = False
        Me.txtCustomerLastName.Location = New System.Drawing.Point(238, 94)
        Me.txtCustomerLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerLastName.Name = "txtCustomerLastName"
        Me.txtCustomerLastName.Size = New System.Drawing.Size(351, 22)
        Me.txtCustomerLastName.TabIndex = 4
        '
        'txtManagerName
        '
        Me.txtManagerName.Enabled = False
        Me.txtManagerName.Location = New System.Drawing.Point(238, 65)
        Me.txtManagerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtManagerName.Name = "txtManagerName"
        Me.txtManagerName.Size = New System.Drawing.Size(351, 22)
        Me.txtManagerName.TabIndex = 2
        '
        'rdbSearchByRoomCost
        '
        Me.rdbSearchByRoomCost.AutoSize = True
        Me.rdbSearchByRoomCost.Location = New System.Drawing.Point(37, 123)
        Me.rdbSearchByRoomCost.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbSearchByRoomCost.Name = "rdbSearchByRoomCost"
        Me.rdbSearchByRoomCost.Size = New System.Drawing.Size(93, 20)
        Me.rdbSearchByRoomCost.TabIndex = 5
        Me.rdbSearchByRoomCost.TabStop = True
        Me.rdbSearchByRoomCost.Text = "Room Cost"
        Me.rdbSearchByRoomCost.UseVisualStyleBackColor = True
        '
        'rdbSearchByCustomerLastName
        '
        Me.rdbSearchByCustomerLastName.AutoSize = True
        Me.rdbSearchByCustomerLastName.Location = New System.Drawing.Point(37, 95)
        Me.rdbSearchByCustomerLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbSearchByCustomerLastName.Name = "rdbSearchByCustomerLastName"
        Me.rdbSearchByCustomerLastName.Size = New System.Drawing.Size(151, 20)
        Me.rdbSearchByCustomerLastName.TabIndex = 3
        Me.rdbSearchByCustomerLastName.TabStop = True
        Me.rdbSearchByCustomerLastName.Text = "Customer Last Name"
        Me.rdbSearchByCustomerLastName.UseVisualStyleBackColor = True
        '
        'rdbSearchByManagerName
        '
        Me.rdbSearchByManagerName.AutoSize = True
        Me.rdbSearchByManagerName.Location = New System.Drawing.Point(37, 66)
        Me.rdbSearchByManagerName.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbSearchByManagerName.Name = "rdbSearchByManagerName"
        Me.rdbSearchByManagerName.Size = New System.Drawing.Size(120, 20)
        Me.rdbSearchByManagerName.TabIndex = 1
        Me.rdbSearchByManagerName.TabStop = True
        Me.rdbSearchByManagerName.Text = "Manager Name"
        Me.rdbSearchByManagerName.UseVisualStyleBackColor = True
        '
        'lblSearchConditionHeading
        '
        Me.lblSearchConditionHeading.AutoSize = True
        Me.lblSearchConditionHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchConditionHeading.Location = New System.Drawing.Point(33, 28)
        Me.lblSearchConditionHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchConditionHeading.Name = "lblSearchConditionHeading"
        Me.lblSearchConditionHeading.Size = New System.Drawing.Size(94, 20)
        Me.lblSearchConditionHeading.TabIndex = 0
        Me.lblSearchConditionHeading.Text = "Search by:"
        '
        'grpSearchResult
        '
        Me.grpSearchResult.Controls.Add(Me.dgvResult)
        Me.grpSearchResult.Location = New System.Drawing.Point(16, 282)
        Me.grpSearchResult.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSearchResult.Name = "grpSearchResult"
        Me.grpSearchResult.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSearchResult.Size = New System.Drawing.Size(789, 267)
        Me.grpSearchResult.TabIndex = 1
        Me.grpSearchResult.TabStop = False
        Me.grpSearchResult.Text = "Search Result"
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToDeleteRows = False
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.manager_name, Me.booking_id, Me.booking_date, Me.customer_lastname, Me.customer_firstname, Me.room_type, Me.room_rate, Me.number_of_nights, Me.number_of_adults, Me.number_of_children, Me.room_cost})
        Me.dgvResult.Location = New System.Drawing.Point(7, 22)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.Size = New System.Drawing.Size(775, 238)
        Me.dgvResult.TabIndex = 0
        '
        'manager_name
        '
        Me.manager_name.HeaderText = "Manager Name"
        Me.manager_name.Name = "manager_name"
        '
        'booking_id
        '
        Me.booking_id.HeaderText = "Booking ID"
        Me.booking_id.Name = "booking_id"
        '
        'booking_date
        '
        Me.booking_date.HeaderText = "Booking Date"
        Me.booking_date.Name = "booking_date"
        '
        'customer_lastname
        '
        Me.customer_lastname.HeaderText = "Customer Last Name"
        Me.customer_lastname.Name = "customer_lastname"
        '
        'customer_firstname
        '
        Me.customer_firstname.HeaderText = "Customer First Name"
        Me.customer_firstname.Name = "customer_firstname"
        '
        'room_type
        '
        Me.room_type.HeaderText = "Room Type"
        Me.room_type.Name = "room_type"
        '
        'room_rate
        '
        Me.room_rate.HeaderText = "Room Rate"
        Me.room_rate.Name = "room_rate"
        '
        'number_of_nights
        '
        Me.number_of_nights.HeaderText = "Number of Nights"
        Me.number_of_nights.Name = "number_of_nights"
        '
        'number_of_adults
        '
        Me.number_of_adults.HeaderText = "Number of Adults"
        Me.number_of_adults.Name = "number_of_adults"
        '
        'number_of_children
        '
        Me.number_of_children.HeaderText = "Number of Children"
        Me.number_of_children.Name = "number_of_children"
        '
        'room_cost
        '
        Me.room_cost.HeaderText = "Room Cost"
        Me.room_cost.Name = "room_cost"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 562)
        Me.Controls.Add(Me.grpSearchResult)
        Me.Controls.Add(Me.grpSearchConditions)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearch"
        Me.Text = "Paradise Bookings Processing System - Search"
        Me.grpSearchConditions.ResumeLayout(False)
        Me.grpSearchConditions.PerformLayout()
        Me.grpSearchResult.ResumeLayout(False)
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSearchConditions As System.Windows.Forms.GroupBox
    Friend WithEvents grpSearchResult As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearchConditionHeading As System.Windows.Forms.Label
    Friend WithEvents txtManagerName As System.Windows.Forms.TextBox
    Friend WithEvents rdbSearchByRoomCost As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSearchByCustomerLastName As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSearchByManagerName As System.Windows.Forms.RadioButton
    Friend WithEvents lblMinRoomCost As System.Windows.Forms.Label
    Friend WithEvents txtCustomerLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxRoomCost As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxRoomCost As System.Windows.Forms.Label
    Friend WithEvents txtMinRoomCost As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomTypeHeading As System.Windows.Forms.Label
    Friend WithEvents cbxTypeSuperior As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbxTypePresidentialSuite As System.Windows.Forms.CheckBox
    Friend WithEvents cbxTypeJuniorSuite As System.Windows.Forms.CheckBox
    Friend WithEvents cbxTypePremiumDeluxe As System.Windows.Forms.CheckBox
    Friend WithEvents cbxTypeDeluxe As System.Windows.Forms.CheckBox
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents manager_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents booking_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents booking_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number_of_nights As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number_of_adults As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number_of_children As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents room_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
