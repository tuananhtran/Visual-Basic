<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListboxExample
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
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblAge = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.btnAddDetails = New System.Windows.Forms.Button
        Me.btnFindSmallestAge = New System.Windows.Forms.Button
        Me.lblNameList = New System.Windows.Forms.Label
        Me.lblAgeList = New System.Windows.Forms.Label
        Me.lbxNameList = New System.Windows.Forms.ListBox
        Me.lbxAgeList = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(36, 40)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 37)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 22)
        Me.txtName.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(354, 40)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 16)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(395, 37)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(186, 22)
        Me.txtAge.TabIndex = 3
        '
        'btnAddDetails
        '
        Me.btnAddDetails.Location = New System.Drawing.Point(148, 90)
        Me.btnAddDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddDetails.Name = "btnAddDetails"
        Me.btnAddDetails.Size = New System.Drawing.Size(145, 35)
        Me.btnAddDetails.TabIndex = 4
        Me.btnAddDetails.Text = "&Add Details"
        Me.btnAddDetails.UseVisualStyleBackColor = True
        '
        'btnFindSmallestAge
        '
        Me.btnFindSmallestAge.Location = New System.Drawing.Point(327, 90)
        Me.btnFindSmallestAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFindSmallestAge.Name = "btnFindSmallestAge"
        Me.btnFindSmallestAge.Size = New System.Drawing.Size(145, 35)
        Me.btnFindSmallestAge.TabIndex = 5
        Me.btnFindSmallestAge.Text = "&Find Smallest Age"
        Me.btnFindSmallestAge.UseVisualStyleBackColor = True
        '
        'lblNameList
        '
        Me.lblNameList.AutoSize = True
        Me.lblNameList.Location = New System.Drawing.Point(36, 149)
        Me.lblNameList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameList.Name = "lblNameList"
        Me.lblNameList.Size = New System.Drawing.Size(45, 16)
        Me.lblNameList.TabIndex = 6
        Me.lblNameList.Text = "Name"
        '
        'lblAgeList
        '
        Me.lblAgeList.AutoSize = True
        Me.lblAgeList.Location = New System.Drawing.Point(324, 149)
        Me.lblAgeList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgeList.Name = "lblAgeList"
        Me.lblAgeList.Size = New System.Drawing.Size(33, 16)
        Me.lblAgeList.TabIndex = 7
        Me.lblAgeList.Text = "Age"
        '
        'lbxNameList
        '
        Me.lbxNameList.FormattingEnabled = True
        Me.lbxNameList.ItemHeight = 16
        Me.lbxNameList.Location = New System.Drawing.Point(39, 169)
        Me.lbxNameList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbxNameList.Name = "lbxNameList"
        Me.lbxNameList.Size = New System.Drawing.Size(254, 212)
        Me.lbxNameList.TabIndex = 8
        '
        'lbxAgeList
        '
        Me.lbxAgeList.FormattingEnabled = True
        Me.lbxAgeList.ItemHeight = 16
        Me.lbxAgeList.Location = New System.Drawing.Point(327, 169)
        Me.lbxAgeList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbxAgeList.Name = "lbxAgeList"
        Me.lbxAgeList.Size = New System.Drawing.Size(254, 212)
        Me.lbxAgeList.TabIndex = 9
        '
        'frmListboxExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 418)
        Me.Controls.Add(Me.lbxAgeList)
        Me.Controls.Add(Me.lbxNameList)
        Me.Controls.Add(Me.lblAgeList)
        Me.Controls.Add(Me.lblNameList)
        Me.Controls.Add(Me.btnFindSmallestAge)
        Me.Controls.Add(Me.btnAddDetails)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmListboxExample"
        Me.Text = "Listbox Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents btnAddDetails As System.Windows.Forms.Button
    Friend WithEvents btnFindSmallestAge As System.Windows.Forms.Button
    Friend WithEvents lblNameList As System.Windows.Forms.Label
    Friend WithEvents lblAgeList As System.Windows.Forms.Label
    Friend WithEvents lbxNameList As System.Windows.Forms.ListBox
    Friend WithEvents lbxAgeList As System.Windows.Forms.ListBox

End Class
