<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBirthdayCalculator
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
        Me.components = New System.ComponentModel.Container
        Me.lblDateFormat = New System.Windows.Forms.Label
        Me.gbxGender = New System.Windows.Forms.GroupBox
        Me.rbOther = New System.Windows.Forms.RadioButton
        Me.rbFemale = New System.Windows.Forms.RadioButton
        Me.rbMale = New System.Windows.Forms.RadioButton
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.pnlBirthdayAnalyzerContent = New System.Windows.Forms.Panel
        Me.pnlBirthdayReport = New System.Windows.Forms.Panel
        Me.lblChineseYear = New System.Windows.Forms.Label
        Me.lblAge = New System.Windows.Forms.Label
        Me.lblDaysAlive = New System.Windows.Forms.Label
        Me.lblDayOfBirth = New System.Windows.Forms.Label
        Me.lblFullName = New System.Windows.Forms.Label
        Me.lblChineseYearLabel = New System.Windows.Forms.Label
        Me.lblAgeLabel = New System.Windows.Forms.Label
        Me.lblDaysAliveLabel = New System.Windows.Forms.Label
        Me.lblDayOfBirthLabel = New System.Windows.Forms.Label
        Me.lblFullNameLabel = New System.Windows.Forms.Label
        Me.lblBirthdayReportHeading = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnGenerateReport = New System.Windows.Forms.Button
        Me.pnlUserInformation = New System.Windows.Forms.Panel
        Me.txtDOB = New System.Windows.Forms.TextBox
        Me.txtGivenNames = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.lblDateOfBirth = New System.Windows.Forms.Label
        Me.lblGivenNames = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblBirthdayAnalyzerHeading = New System.Windows.Forms.Label
        Me.ttpClearButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpProduceReportButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpExitButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxGender.SuspendLayout()
        Me.pnlBirthdayAnalyzerContent.SuspendLayout()
        Me.pnlBirthdayReport.SuspendLayout()
        Me.pnlUserInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateFormat
        '
        Me.lblDateFormat.AutoSize = True
        Me.lblDateFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFormat.Location = New System.Drawing.Point(300, 93)
        Me.lblDateFormat.Name = "lblDateFormat"
        Me.lblDateFormat.Size = New System.Drawing.Size(73, 16)
        Me.lblDateFormat.TabIndex = 6
        Me.lblDateFormat.Text = "(D/M/yyyy)"
        '
        'gbxGender
        '
        Me.gbxGender.Controls.Add(Me.rbOther)
        Me.gbxGender.Controls.Add(Me.rbFemale)
        Me.gbxGender.Controls.Add(Me.rbMale)
        Me.gbxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGender.Location = New System.Drawing.Point(399, 9)
        Me.gbxGender.Name = "gbxGender"
        Me.gbxGender.Size = New System.Drawing.Size(101, 109)
        Me.gbxGender.TabIndex = 7
        Me.gbxGender.TabStop = False
        Me.gbxGender.Text = "Sex"
        '
        'rbOther
        '
        Me.rbOther.AutoSize = True
        Me.rbOther.Location = New System.Drawing.Point(12, 73)
        Me.rbOther.Name = "rbOther"
        Me.rbOther.Size = New System.Drawing.Size(58, 20)
        Me.rbOther.TabIndex = 2
        Me.rbOther.TabStop = True
        Me.rbOther.Text = "Other"
        Me.rbOther.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.Location = New System.Drawing.Point(12, 47)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(72, 20)
        Me.rbFemale.TabIndex = 1
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.Location = New System.Drawing.Point(12, 21)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(56, 20)
        Me.rbMale.TabIndex = 0
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCopyright.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(10, 527)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblCopyright.Size = New System.Drawing.Size(559, 29)
        Me.lblCopyright.TabIndex = 6
        Me.lblCopyright.Text = "© Tran Tuan Anh 2011"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(279, 204)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 34)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlBirthdayAnalyzerContent
        '
        Me.pnlBirthdayAnalyzerContent.Controls.Add(Me.pnlBirthdayReport)
        Me.pnlBirthdayAnalyzerContent.Controls.Add(Me.lblCopyright)
        Me.pnlBirthdayAnalyzerContent.Controls.Add(Me.btnClear)
        Me.pnlBirthdayAnalyzerContent.Controls.Add(Me.btnExit)
        Me.pnlBirthdayAnalyzerContent.Controls.Add(Me.btnGenerateReport)
        Me.pnlBirthdayAnalyzerContent.Controls.Add(Me.pnlUserInformation)
        Me.pnlBirthdayAnalyzerContent.Controls.Add(Me.lblBirthdayAnalyzerHeading)
        Me.pnlBirthdayAnalyzerContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBirthdayAnalyzerContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlBirthdayAnalyzerContent.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlBirthdayAnalyzerContent.Name = "pnlBirthdayAnalyzerContent"
        Me.pnlBirthdayAnalyzerContent.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlBirthdayAnalyzerContent.Size = New System.Drawing.Size(579, 566)
        Me.pnlBirthdayAnalyzerContent.TabIndex = 1
        '
        'pnlBirthdayReport
        '
        Me.pnlBirthdayReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBirthdayReport.Controls.Add(Me.lblChineseYear)
        Me.pnlBirthdayReport.Controls.Add(Me.lblAge)
        Me.pnlBirthdayReport.Controls.Add(Me.lblDaysAlive)
        Me.pnlBirthdayReport.Controls.Add(Me.lblDayOfBirth)
        Me.pnlBirthdayReport.Controls.Add(Me.lblFullName)
        Me.pnlBirthdayReport.Controls.Add(Me.lblChineseYearLabel)
        Me.pnlBirthdayReport.Controls.Add(Me.lblAgeLabel)
        Me.pnlBirthdayReport.Controls.Add(Me.lblDaysAliveLabel)
        Me.pnlBirthdayReport.Controls.Add(Me.lblDayOfBirthLabel)
        Me.pnlBirthdayReport.Controls.Add(Me.lblFullNameLabel)
        Me.pnlBirthdayReport.Controls.Add(Me.lblBirthdayReportHeading)
        Me.pnlBirthdayReport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBirthdayReport.Location = New System.Drawing.Point(10, 262)
        Me.pnlBirthdayReport.Name = "pnlBirthdayReport"
        Me.pnlBirthdayReport.Size = New System.Drawing.Size(559, 265)
        Me.pnlBirthdayReport.TabIndex = 5
        '
        'lblChineseYear
        '
        Me.lblChineseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChineseYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChineseYear.Location = New System.Drawing.Point(197, 203)
        Me.lblChineseYear.Name = "lblChineseYear"
        Me.lblChineseYear.Size = New System.Drawing.Size(218, 23)
        Me.lblChineseYear.TabIndex = 10
        Me.lblChineseYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAge
        '
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(197, 167)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(171, 23)
        Me.lblAge.TabIndex = 8
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDaysAlive
        '
        Me.lblDaysAlive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaysAlive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysAlive.Location = New System.Drawing.Point(197, 130)
        Me.lblDaysAlive.Name = "lblDaysAlive"
        Me.lblDaysAlive.Size = New System.Drawing.Size(171, 23)
        Me.lblDaysAlive.TabIndex = 6
        Me.lblDaysAlive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDayOfBirth
        '
        Me.lblDayOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDayOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayOfBirth.Location = New System.Drawing.Point(197, 95)
        Me.lblDayOfBirth.Name = "lblDayOfBirth"
        Me.lblDayOfBirth.Size = New System.Drawing.Size(218, 23)
        Me.lblDayOfBirth.TabIndex = 4
        Me.lblDayOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(197, 61)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(285, 23)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChineseYearLabel
        '
        Me.lblChineseYearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChineseYearLabel.Location = New System.Drawing.Point(50, 203)
        Me.lblChineseYearLabel.Name = "lblChineseYearLabel"
        Me.lblChineseYearLabel.Size = New System.Drawing.Size(141, 23)
        Me.lblChineseYearLabel.TabIndex = 9
        Me.lblChineseYearLabel.Text = "Chinese Year of"
        Me.lblChineseYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAgeLabel
        '
        Me.lblAgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeLabel.Location = New System.Drawing.Point(50, 167)
        Me.lblAgeLabel.Name = "lblAgeLabel"
        Me.lblAgeLabel.Size = New System.Drawing.Size(141, 23)
        Me.lblAgeLabel.TabIndex = 7
        Me.lblAgeLabel.Text = "Age"
        Me.lblAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDaysAliveLabel
        '
        Me.lblDaysAliveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysAliveLabel.Location = New System.Drawing.Point(50, 130)
        Me.lblDaysAliveLabel.Name = "lblDaysAliveLabel"
        Me.lblDaysAliveLabel.Size = New System.Drawing.Size(141, 23)
        Me.lblDaysAliveLabel.TabIndex = 5
        Me.lblDaysAliveLabel.Text = "Days Alive"
        Me.lblDaysAliveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDayOfBirthLabel
        '
        Me.lblDayOfBirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayOfBirthLabel.Location = New System.Drawing.Point(50, 95)
        Me.lblDayOfBirthLabel.Name = "lblDayOfBirthLabel"
        Me.lblDayOfBirthLabel.Size = New System.Drawing.Size(141, 23)
        Me.lblDayOfBirthLabel.TabIndex = 3
        Me.lblDayOfBirthLabel.Text = "Day of Birth"
        Me.lblDayOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFullNameLabel
        '
        Me.lblFullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullNameLabel.Location = New System.Drawing.Point(50, 61)
        Me.lblFullNameLabel.Name = "lblFullNameLabel"
        Me.lblFullNameLabel.Size = New System.Drawing.Size(141, 23)
        Me.lblFullNameLabel.TabIndex = 1
        Me.lblFullNameLabel.Text = "Name"
        Me.lblFullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBirthdayReportHeading
        '
        Me.lblBirthdayReportHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBirthdayReportHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBirthdayReportHeading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdayReportHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblBirthdayReportHeading.Name = "lblBirthdayReportHeading"
        Me.lblBirthdayReportHeading.Size = New System.Drawing.Size(555, 29)
        Me.lblBirthdayReportHeading.TabIndex = 0
        Me.lblBirthdayReportHeading.Text = "Birthday Report"
        Me.lblBirthdayReportHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(441, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.Location = New System.Drawing.Point(63, 204)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(127, 34)
        Me.btnGenerateReport.TabIndex = 2
        Me.btnGenerateReport.Text = "&Produce Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'pnlUserInformation
        '
        Me.pnlUserInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlUserInformation.Controls.Add(Me.lblDateFormat)
        Me.pnlUserInformation.Controls.Add(Me.txtDOB)
        Me.pnlUserInformation.Controls.Add(Me.gbxGender)
        Me.pnlUserInformation.Controls.Add(Me.txtGivenNames)
        Me.pnlUserInformation.Controls.Add(Me.txtSurname)
        Me.pnlUserInformation.Controls.Add(Me.lblDateOfBirth)
        Me.pnlUserInformation.Controls.Add(Me.lblGivenNames)
        Me.pnlUserInformation.Controls.Add(Me.lblSurname)
        Me.pnlUserInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUserInformation.Location = New System.Drawing.Point(10, 48)
        Me.pnlUserInformation.Name = "pnlUserInformation"
        Me.pnlUserInformation.Size = New System.Drawing.Size(559, 136)
        Me.pnlUserInformation.TabIndex = 1
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(145, 90)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(149, 22)
        Me.txtDOB.TabIndex = 5
        '
        'txtGivenNames
        '
        Me.txtGivenNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGivenNames.Location = New System.Drawing.Point(145, 53)
        Me.txtGivenNames.Name = "txtGivenNames"
        Me.txtGivenNames.Size = New System.Drawing.Size(223, 22)
        Me.txtGivenNames.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(145, 20)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(223, 22)
        Me.txtSurname.TabIndex = 1
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.Location = New System.Drawing.Point(0, 87)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(137, 24)
        Me.lblDateOfBirth.TabIndex = 4
        Me.lblDateOfBirth.Text = "Date of Birth"
        Me.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGivenNames
        '
        Me.lblGivenNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGivenNames.Location = New System.Drawing.Point(0, 52)
        Me.lblGivenNames.Name = "lblGivenNames"
        Me.lblGivenNames.Size = New System.Drawing.Size(137, 24)
        Me.lblGivenNames.TabIndex = 2
        Me.lblGivenNames.Text = "Given Names"
        Me.lblGivenNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSurname
        '
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(0, 19)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(137, 24)
        Me.lblSurname.TabIndex = 0
        Me.lblSurname.Text = "Surname"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBirthdayAnalyzerHeading
        '
        Me.lblBirthdayAnalyzerHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBirthdayAnalyzerHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBirthdayAnalyzerHeading.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdayAnalyzerHeading.Location = New System.Drawing.Point(10, 10)
        Me.lblBirthdayAnalyzerHeading.Name = "lblBirthdayAnalyzerHeading"
        Me.lblBirthdayAnalyzerHeading.Size = New System.Drawing.Size(559, 38)
        Me.lblBirthdayAnalyzerHeading.TabIndex = 0
        Me.lblBirthdayAnalyzerHeading.Text = "Birthday Analyzer"
        Me.lblBirthdayAnalyzerHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBirthdayCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 566)
        Me.Controls.Add(Me.pnlBirthdayAnalyzerContent)
        Me.Name = "frmBirthdayCalculator"
        Me.Text = "Birthday Analyzer"
        Me.gbxGender.ResumeLayout(False)
        Me.gbxGender.PerformLayout()
        Me.pnlBirthdayAnalyzerContent.ResumeLayout(False)
        Me.pnlBirthdayReport.ResumeLayout(False)
        Me.pnlUserInformation.ResumeLayout(False)
        Me.pnlUserInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDateFormat As System.Windows.Forms.Label
    Friend WithEvents gbxGender As System.Windows.Forms.GroupBox
    Friend WithEvents rbOther As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pnlBirthdayAnalyzerContent As System.Windows.Forms.Panel
    Friend WithEvents pnlBirthdayReport As System.Windows.Forms.Panel
    Friend WithEvents lblChineseYear As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblDaysAlive As System.Windows.Forms.Label
    Friend WithEvents lblDayOfBirth As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblChineseYearLabel As System.Windows.Forms.Label
    Friend WithEvents lblAgeLabel As System.Windows.Forms.Label
    Friend WithEvents lblDaysAliveLabel As System.Windows.Forms.Label
    Friend WithEvents lblDayOfBirthLabel As System.Windows.Forms.Label
    Friend WithEvents lblFullNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblBirthdayReportHeading As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
    Friend WithEvents pnlUserInformation As System.Windows.Forms.Panel
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtGivenNames As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents lblGivenNames As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblBirthdayAnalyzerHeading As System.Windows.Forms.Label
    Friend WithEvents ttpClearButtonToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ttpProduceReportButtonToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ttpExitButtonToolTip As System.Windows.Forms.ToolTip

End Class
