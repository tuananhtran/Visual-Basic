<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarkAnalyzer
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
        Me.pnlContainerPanel = New System.Windows.Forms.Panel
        Me.pnlInformationLists = New System.Windows.Forms.Panel
        Me.lbxNameList = New System.Windows.Forms.ListBox
        Me.lbxMarkList = New System.Windows.Forms.ListBox
        Me.lblMarkList = New System.Windows.Forms.Label
        Me.lblNameList = New System.Windows.Forms.Label
        Me.pnlOutput = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.pnlInput = New System.Windows.Forms.Panel
        Me.btnAddMark = New System.Windows.Forms.Button
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.lblMark = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblHeading = New System.Windows.Forms.Label
        Me.lblAverageLabel = New System.Windows.Forms.Label
        Me.lblHighestLabel = New System.Windows.Forms.Label
        Me.lblLowestLabel = New System.Windows.Forms.Label
        Me.lblAverage = New System.Windows.Forms.Label
        Me.lblHighest = New System.Windows.Forms.Label
        Me.lblLowest = New System.Windows.Forms.Label
        Me.pnlContainerPanel.SuspendLayout()
        Me.pnlInformationLists.SuspendLayout()
        Me.pnlOutput.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainerPanel
        '
        Me.pnlContainerPanel.Controls.Add(Me.pnlInformationLists)
        Me.pnlContainerPanel.Controls.Add(Me.pnlOutput)
        Me.pnlContainerPanel.Controls.Add(Me.pnlInput)
        Me.pnlContainerPanel.Controls.Add(Me.lblHeading)
        Me.pnlContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainerPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlContainerPanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContainerPanel.Name = "pnlContainerPanel"
        Me.pnlContainerPanel.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlContainerPanel.Size = New System.Drawing.Size(378, 598)
        Me.pnlContainerPanel.TabIndex = 0
        '
        'pnlInformationLists
        '
        Me.pnlInformationLists.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInformationLists.Controls.Add(Me.lbxNameList)
        Me.pnlInformationLists.Controls.Add(Me.lbxMarkList)
        Me.pnlInformationLists.Controls.Add(Me.lblMarkList)
        Me.pnlInformationLists.Controls.Add(Me.lblNameList)
        Me.pnlInformationLists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInformationLists.Location = New System.Drawing.Point(8, 151)
        Me.pnlInformationLists.Name = "pnlInformationLists"
        Me.pnlInformationLists.Size = New System.Drawing.Size(362, 310)
        Me.pnlInformationLists.TabIndex = 3
        '
        'lbxNameList
        '
        Me.lbxNameList.FormattingEnabled = True
        Me.lbxNameList.ItemHeight = 18
        Me.lbxNameList.Location = New System.Drawing.Point(17, 40)
        Me.lbxNameList.Name = "lbxNameList"
        Me.lbxNameList.Size = New System.Drawing.Size(220, 238)
        Me.lbxNameList.TabIndex = 3
        '
        'lbxMarkList
        '
        Me.lbxMarkList.FormattingEnabled = True
        Me.lbxMarkList.ItemHeight = 18
        Me.lbxMarkList.Location = New System.Drawing.Point(249, 40)
        Me.lbxMarkList.Name = "lbxMarkList"
        Me.lbxMarkList.Size = New System.Drawing.Size(93, 238)
        Me.lbxMarkList.TabIndex = 2
        '
        'lblMarkList
        '
        Me.lblMarkList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMarkList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkList.Location = New System.Drawing.Point(249, 11)
        Me.lblMarkList.Name = "lblMarkList"
        Me.lblMarkList.Size = New System.Drawing.Size(93, 26)
        Me.lblMarkList.TabIndex = 1
        Me.lblMarkList.Text = "Mark"
        Me.lblMarkList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNameList
        '
        Me.lblNameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNameList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameList.Location = New System.Drawing.Point(17, 11)
        Me.lblNameList.Name = "lblNameList"
        Me.lblNameList.Size = New System.Drawing.Size(220, 26)
        Me.lblNameList.TabIndex = 0
        Me.lblNameList.Text = "Name"
        Me.lblNameList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlOutput
        '
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOutput.Controls.Add(Me.lblLowest)
        Me.pnlOutput.Controls.Add(Me.lblHighest)
        Me.pnlOutput.Controls.Add(Me.lblAverage)
        Me.pnlOutput.Controls.Add(Me.lblLowestLabel)
        Me.pnlOutput.Controls.Add(Me.lblHighestLabel)
        Me.pnlOutput.Controls.Add(Me.lblAverageLabel)
        Me.pnlOutput.Controls.Add(Me.btnExit)
        Me.pnlOutput.Controls.Add(Me.btnClear)
        Me.pnlOutput.Controls.Add(Me.btnCalculate)
        Me.pnlOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlOutput.Location = New System.Drawing.Point(8, 461)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(362, 130)
        Me.pnlOutput.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(31, 88)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 29)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(31, 49)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 29)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(31, 10)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 29)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'pnlInput
        '
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInput.Controls.Add(Me.btnAddMark)
        Me.pnlInput.Controls.Add(Me.txtMark)
        Me.pnlInput.Controls.Add(Me.lblMark)
        Me.pnlInput.Controls.Add(Me.txtName)
        Me.pnlInput.Controls.Add(Me.lblName)
        Me.pnlInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInput.Location = New System.Drawing.Point(8, 54)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(362, 97)
        Me.pnlInput.TabIndex = 1
        '
        'btnAddMark
        '
        Me.btnAddMark.Location = New System.Drawing.Point(219, 48)
        Me.btnAddMark.Name = "btnAddMark"
        Me.btnAddMark.Size = New System.Drawing.Size(107, 29)
        Me.btnAddMark.TabIndex = 4
        Me.btnAddMark.Text = "&Add Mark"
        Me.btnAddMark.UseVisualStyleBackColor = True
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(69, 50)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(100, 24)
        Me.txtMark.TabIndex = 3
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Location = New System.Drawing.Point(14, 53)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(42, 18)
        Me.lblMark.TabIndex = 2
        Me.lblMark.Text = "Mark"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 24)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(14, 12)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 18)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblHeading
        '
        Me.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(8, 7)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(362, 47)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Mark Analyzer"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverageLabel
        '
        Me.lblAverageLabel.AutoSize = True
        Me.lblAverageLabel.Location = New System.Drawing.Point(176, 15)
        Me.lblAverageLabel.Name = "lblAverageLabel"
        Me.lblAverageLabel.Size = New System.Drawing.Size(61, 18)
        Me.lblAverageLabel.TabIndex = 3
        Me.lblAverageLabel.Text = "Average"
        '
        'lblHighestLabel
        '
        Me.lblHighestLabel.AutoSize = True
        Me.lblHighestLabel.Location = New System.Drawing.Point(179, 54)
        Me.lblHighestLabel.Name = "lblHighestLabel"
        Me.lblHighestLabel.Size = New System.Drawing.Size(58, 18)
        Me.lblHighestLabel.TabIndex = 4
        Me.lblHighestLabel.Text = "Highest"
        '
        'lblLowestLabel
        '
        Me.lblLowestLabel.AutoSize = True
        Me.lblLowestLabel.Location = New System.Drawing.Point(181, 93)
        Me.lblLowestLabel.Name = "lblLowestLabel"
        Me.lblLowestLabel.Size = New System.Drawing.Size(56, 18)
        Me.lblLowestLabel.TabIndex = 5
        Me.lblLowestLabel.Text = "Lowest"
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(249, 14)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(93, 25)
        Me.lblAverage.TabIndex = 6
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHighest.Location = New System.Drawing.Point(249, 51)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(93, 25)
        Me.lblHighest.TabIndex = 7
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLowest
        '
        Me.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLowest.Location = New System.Drawing.Point(249, 90)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(93, 25)
        Me.lblLowest.TabIndex = 8
        Me.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMarkAnalyzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 598)
        Me.Controls.Add(Me.pnlContainerPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMarkAnalyzer"
        Me.Text = "Mark Analyzer"
        Me.pnlContainerPanel.ResumeLayout(False)
        Me.pnlInformationLists.ResumeLayout(False)
        Me.pnlOutput.ResumeLayout(False)
        Me.pnlOutput.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainerPanel As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddMark As System.Windows.Forms.Button
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents lblMark As System.Windows.Forms.Label
    Friend WithEvents pnlOutput As System.Windows.Forms.Panel
    Friend WithEvents pnlInformationLists As System.Windows.Forms.Panel
    Friend WithEvents lblNameList As System.Windows.Forms.Label
    Friend WithEvents lblMarkList As System.Windows.Forms.Label
    Friend WithEvents lbxNameList As System.Windows.Forms.ListBox
    Friend WithEvents lbxMarkList As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblHighestLabel As System.Windows.Forms.Label
    Friend WithEvents lblAverageLabel As System.Windows.Forms.Label
    Friend WithEvents lblLowestLabel As System.Windows.Forms.Label
    Friend WithEvents lblLowest As System.Windows.Forms.Label
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
