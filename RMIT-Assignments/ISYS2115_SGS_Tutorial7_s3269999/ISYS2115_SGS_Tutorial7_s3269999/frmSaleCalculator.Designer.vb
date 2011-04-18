<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleCalculator
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
        Me.pnlHeading = New System.Windows.Forms.Panel
        Me.spcHeading = New System.Windows.Forms.SplitContainer
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.pnlItemInput = New System.Windows.Forms.Panel
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.txtItemID = New System.Windows.Forms.TextBox
        Me.lblQuantity = New System.Windows.Forms.Label
        Me.lblItemID = New System.Windows.Forms.Label
        Me.pnlResult = New System.Windows.Forms.Panel
        Me.lblGSTResult = New System.Windows.Forms.Label
        Me.lblTotalResult = New System.Windows.Forms.Label
        Me.lblGST = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.btnTotals = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.pnlItemInformation = New System.Windows.Forms.Panel
        Me.pnlLists = New System.Windows.Forms.Panel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lbxItemID = New System.Windows.Forms.ListBox
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.lbxDescription = New System.Windows.Forms.ListBox
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer
        Me.lbxQuantity = New System.Windows.Forms.ListBox
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer
        Me.lbxUnitPrice = New System.Windows.Forms.ListBox
        Me.lbxSubTotal = New System.Windows.Forms.ListBox
        Me.pnlListsHeading = New System.Windows.Forms.Panel
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.lblItemIDList = New System.Windows.Forms.Label
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.lblDescriptionList = New System.Windows.Forms.Label
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.lblQuantityList = New System.Windows.Forms.Label
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer
        Me.lblUnitPrice = New System.Windows.Forms.Label
        Me.lblSubTotalList = New System.Windows.Forms.Label
        Me.pnlHeading.SuspendLayout()
        Me.spcHeading.Panel1.SuspendLayout()
        Me.spcHeading.Panel2.SuspendLayout()
        Me.spcHeading.SuspendLayout()
        Me.pnlItemInput.SuspendLayout()
        Me.pnlResult.SuspendLayout()
        Me.pnlItemInformation.SuspendLayout()
        Me.pnlLists.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        Me.pnlListsHeading.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeading
        '
        Me.pnlHeading.Controls.Add(Me.spcHeading)
        Me.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeading.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeading.Name = "pnlHeading"
        Me.pnlHeading.Size = New System.Drawing.Size(715, 58)
        Me.pnlHeading.TabIndex = 0
        '
        'spcHeading
        '
        Me.spcHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcHeading.Location = New System.Drawing.Point(0, 0)
        Me.spcHeading.Name = "spcHeading"
        '
        'spcHeading.Panel1
        '
        Me.spcHeading.Panel1.Controls.Add(Me.lblCompanyName)
        '
        'spcHeading.Panel2
        '
        Me.spcHeading.Panel2.Controls.Add(Me.lblDepartment)
        Me.spcHeading.Size = New System.Drawing.Size(715, 58)
        Me.spcHeading.SplitterDistance = 545
        Me.spcHeading.SplitterWidth = 1
        Me.spcHeading.TabIndex = 0
        '
        'lblCompanyName
        '
        Me.lblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCompanyName.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(0, 0)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(545, 58)
        Me.lblCompanyName.TabIndex = 0
        Me.lblCompanyName.Text = "Ace Sporting Goods"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartment
        '
        Me.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDepartment.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(0, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(169, 58)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Sale"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlItemInput
        '
        Me.pnlItemInput.Controls.Add(Me.btnAddItem)
        Me.pnlItemInput.Controls.Add(Me.txtQuantity)
        Me.pnlItemInput.Controls.Add(Me.txtItemID)
        Me.pnlItemInput.Controls.Add(Me.lblQuantity)
        Me.pnlItemInput.Controls.Add(Me.lblItemID)
        Me.pnlItemInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlItemInput.Location = New System.Drawing.Point(0, 58)
        Me.pnlItemInput.Name = "pnlItemInput"
        Me.pnlItemInput.Size = New System.Drawing.Size(715, 62)
        Me.pnlItemInput.TabIndex = 1
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(549, 25)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "&Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(338, 25)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(138, 22)
        Me.txtQuantity.TabIndex = 3
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(77, 25)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(149, 22)
        Me.txtItemID.TabIndex = 2
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(276, 28)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(56, 16)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(22, 28)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(49, 16)
        Me.lblItemID.TabIndex = 0
        Me.lblItemID.Text = "Item ID"
        Me.lblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlResult
        '
        Me.pnlResult.Controls.Add(Me.lblGSTResult)
        Me.pnlResult.Controls.Add(Me.lblTotalResult)
        Me.pnlResult.Controls.Add(Me.lblGST)
        Me.pnlResult.Controls.Add(Me.lblTotal)
        Me.pnlResult.Controls.Add(Me.btnTotals)
        Me.pnlResult.Controls.Add(Me.btnExit)
        Me.pnlResult.Controls.Add(Me.btnClear)
        Me.pnlResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlResult.Location = New System.Drawing.Point(0, 450)
        Me.pnlResult.Name = "pnlResult"
        Me.pnlResult.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.pnlResult.Size = New System.Drawing.Size(715, 100)
        Me.pnlResult.TabIndex = 2
        '
        'lblGSTResult
        '
        Me.lblGSTResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGSTResult.Location = New System.Drawing.Point(534, 58)
        Me.lblGSTResult.Name = "lblGSTResult"
        Me.lblGSTResult.Size = New System.Drawing.Size(122, 23)
        Me.lblGSTResult.TabIndex = 6
        Me.lblGSTResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalResult
        '
        Me.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalResult.Location = New System.Drawing.Point(534, 20)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(122, 23)
        Me.lblTotalResult.TabIndex = 5
        Me.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGST
        '
        Me.lblGST.AutoSize = True
        Me.lblGST.Location = New System.Drawing.Point(412, 61)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(101, 16)
        Me.lblGST.TabIndex = 4
        Me.lblGST.Text = "GTS in this sale"
        Me.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(412, 23)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(98, 16)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total (Inc GST)"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTotals
        '
        Me.btnTotals.Location = New System.Drawing.Point(279, 37)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(75, 23)
        Me.btnTotals.TabIndex = 2
        Me.btnTotals.Text = "&Totals"
        Me.btnTotals.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(77, 61)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(77, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlItemInformation
        '
        Me.pnlItemInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlItemInformation.Controls.Add(Me.pnlLists)
        Me.pnlItemInformation.Controls.Add(Me.pnlListsHeading)
        Me.pnlItemInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItemInformation.Location = New System.Drawing.Point(0, 120)
        Me.pnlItemInformation.Name = "pnlItemInformation"
        Me.pnlItemInformation.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.pnlItemInformation.Size = New System.Drawing.Size(715, 330)
        Me.pnlItemInformation.TabIndex = 3
        '
        'pnlLists
        '
        Me.pnlLists.Controls.Add(Me.SplitContainer1)
        Me.pnlLists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLists.Location = New System.Drawing.Point(0, 27)
        Me.pnlLists.Name = "pnlLists"
        Me.pnlLists.Size = New System.Drawing.Size(711, 299)
        Me.pnlLists.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbxItemID)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer1.Size = New System.Drawing.Size(711, 299)
        Me.SplitContainer1.SplitterDistance = 102
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'lbxItemID
        '
        Me.lbxItemID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxItemID.FormattingEnabled = True
        Me.lbxItemID.ItemHeight = 16
        Me.lbxItemID.Location = New System.Drawing.Point(0, 0)
        Me.lbxItemID.Name = "lbxItemID"
        Me.lbxItemID.Size = New System.Drawing.Size(102, 292)
        Me.lbxItemID.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.lbxDescription)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer4.Size = New System.Drawing.Size(608, 299)
        Me.SplitContainer4.SplitterDistance = 272
        Me.SplitContainer4.SplitterWidth = 1
        Me.SplitContainer4.TabIndex = 0
        '
        'lbxDescription
        '
        Me.lbxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxDescription.FormattingEnabled = True
        Me.lbxDescription.ItemHeight = 16
        Me.lbxDescription.Location = New System.Drawing.Point(0, 0)
        Me.lbxDescription.Name = "lbxDescription"
        Me.lbxDescription.Size = New System.Drawing.Size(272, 292)
        Me.lbxDescription.TabIndex = 0
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.lbxQuantity)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.SplitContainer8)
        Me.SplitContainer6.Size = New System.Drawing.Size(335, 299)
        Me.SplitContainer6.SplitterDistance = 97
        Me.SplitContainer6.SplitterWidth = 1
        Me.SplitContainer6.TabIndex = 0
        '
        'lbxQuantity
        '
        Me.lbxQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxQuantity.FormattingEnabled = True
        Me.lbxQuantity.ItemHeight = 16
        Me.lbxQuantity.Location = New System.Drawing.Point(0, 0)
        Me.lbxQuantity.Name = "lbxQuantity"
        Me.lbxQuantity.Size = New System.Drawing.Size(97, 292)
        Me.lbxQuantity.TabIndex = 0
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Name = "SplitContainer8"
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.Controls.Add(Me.lbxUnitPrice)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.Controls.Add(Me.lbxSubTotal)
        Me.SplitContainer8.Size = New System.Drawing.Size(237, 299)
        Me.SplitContainer8.SplitterDistance = 114
        Me.SplitContainer8.SplitterWidth = 1
        Me.SplitContainer8.TabIndex = 0
        '
        'lbxUnitPrice
        '
        Me.lbxUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxUnitPrice.FormattingEnabled = True
        Me.lbxUnitPrice.ItemHeight = 16
        Me.lbxUnitPrice.Location = New System.Drawing.Point(0, 0)
        Me.lbxUnitPrice.Name = "lbxUnitPrice"
        Me.lbxUnitPrice.Size = New System.Drawing.Size(114, 292)
        Me.lbxUnitPrice.TabIndex = 0
        '
        'lbxSubTotal
        '
        Me.lbxSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxSubTotal.FormattingEnabled = True
        Me.lbxSubTotal.ItemHeight = 16
        Me.lbxSubTotal.Location = New System.Drawing.Point(0, 0)
        Me.lbxSubTotal.Name = "lbxSubTotal"
        Me.lbxSubTotal.Size = New System.Drawing.Size(122, 292)
        Me.lbxSubTotal.TabIndex = 0
        '
        'pnlListsHeading
        '
        Me.pnlListsHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlListsHeading.Controls.Add(Me.SplitContainer2)
        Me.pnlListsHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlListsHeading.Location = New System.Drawing.Point(0, 5)
        Me.pnlListsHeading.Name = "pnlListsHeading"
        Me.pnlListsHeading.Size = New System.Drawing.Size(711, 22)
        Me.pnlListsHeading.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblItemIDList)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(709, 20)
        Me.SplitContainer2.SplitterDistance = 101
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 0
        '
        'lblItemIDList
        '
        Me.lblItemIDList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemIDList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblItemIDList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemIDList.Location = New System.Drawing.Point(0, 0)
        Me.lblItemIDList.Name = "lblItemIDList"
        Me.lblItemIDList.Size = New System.Drawing.Size(101, 20)
        Me.lblItemIDList.TabIndex = 0
        Me.lblItemIDList.Text = "Item ID"
        Me.lblItemIDList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblDescriptionList)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer3.Size = New System.Drawing.Size(607, 20)
        Me.SplitContainer3.SplitterDistance = 272
        Me.SplitContainer3.SplitterWidth = 1
        Me.SplitContainer3.TabIndex = 0
        '
        'lblDescriptionList
        '
        Me.lblDescriptionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescriptionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescriptionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionList.Location = New System.Drawing.Point(0, 0)
        Me.lblDescriptionList.Name = "lblDescriptionList"
        Me.lblDescriptionList.Size = New System.Drawing.Size(272, 20)
        Me.lblDescriptionList.TabIndex = 0
        Me.lblDescriptionList.Text = "Description"
        Me.lblDescriptionList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.lblQuantityList)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer7)
        Me.SplitContainer5.Size = New System.Drawing.Size(334, 20)
        Me.SplitContainer5.SplitterDistance = 97
        Me.SplitContainer5.SplitterWidth = 1
        Me.SplitContainer5.TabIndex = 0
        '
        'lblQuantityList
        '
        Me.lblQuantityList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantityList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuantityList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityList.Location = New System.Drawing.Point(0, 0)
        Me.lblQuantityList.Name = "lblQuantityList"
        Me.lblQuantityList.Size = New System.Drawing.Size(97, 20)
        Me.lblQuantityList.TabIndex = 0
        Me.lblQuantityList.Text = "Quantity"
        Me.lblQuantityList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.lblUnitPrice)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.lblSubTotalList)
        Me.SplitContainer7.Size = New System.Drawing.Size(236, 20)
        Me.SplitContainer7.SplitterDistance = 112
        Me.SplitContainer7.SplitterWidth = 1
        Me.SplitContainer7.TabIndex = 0
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(0, 0)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(112, 20)
        Me.lblUnitPrice.TabIndex = 0
        Me.lblUnitPrice.Text = "Unit Price"
        Me.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTotalList
        '
        Me.lblSubTotalList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotalList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubTotalList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalList.Location = New System.Drawing.Point(0, 0)
        Me.lblSubTotalList.Name = "lblSubTotalList"
        Me.lblSubTotalList.Size = New System.Drawing.Size(123, 20)
        Me.lblSubTotalList.TabIndex = 0
        Me.lblSubTotalList.Text = "Sub Total"
        Me.lblSubTotalList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSaleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 550)
        Me.Controls.Add(Me.pnlItemInformation)
        Me.Controls.Add(Me.pnlResult)
        Me.Controls.Add(Me.pnlItemInput)
        Me.Controls.Add(Me.pnlHeading)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSaleCalculator"
        Me.Text = "Ace Sporting Goods - Sale"
        Me.pnlHeading.ResumeLayout(False)
        Me.spcHeading.Panel1.ResumeLayout(False)
        Me.spcHeading.Panel2.ResumeLayout(False)
        Me.spcHeading.ResumeLayout(False)
        Me.pnlItemInput.ResumeLayout(False)
        Me.pnlItemInput.PerformLayout()
        Me.pnlResult.ResumeLayout(False)
        Me.pnlResult.PerformLayout()
        Me.pnlItemInformation.ResumeLayout(False)
        Me.pnlLists.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        Me.SplitContainer8.ResumeLayout(False)
        Me.pnlListsHeading.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        Me.SplitContainer7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeading As System.Windows.Forms.Panel
    Friend WithEvents spcHeading As System.Windows.Forms.SplitContainer
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents pnlItemInput As System.Windows.Forms.Panel
    Friend WithEvents pnlResult As System.Windows.Forms.Panel
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents pnlItemInformation As System.Windows.Forms.Panel
    Friend WithEvents pnlLists As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbxItemID As System.Windows.Forms.ListBox
    Friend WithEvents pnlListsHeading As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblItemIDList As System.Windows.Forms.Label
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbxDescription As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblDescriptionList As System.Windows.Forms.Label
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbxQuantity As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblQuantityList As System.Windows.Forms.Label
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbxUnitPrice As System.Windows.Forms.ListBox
    Friend WithEvents lbxSubTotal As System.Windows.Forms.ListBox
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalList As System.Windows.Forms.Label
    Friend WithEvents lblGSTResult As System.Windows.Forms.Label
    Friend WithEvents lblTotalResult As System.Windows.Forms.Label
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnTotals As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
