<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountGenerator
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.stsStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblLastName = New System.Windows.Forms.Label
        Me.grpAccountInformation = New System.Windows.Forms.GroupBox
        Me.lblEmailAddress = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUsername = New System.Windows.Forms.Label
        Me.lblEmailAddressHeading = New System.Windows.Forms.Label
        Me.lblPasswordHeading = New System.Windows.Forms.Label
        Me.lblUsernameHeading = New System.Windows.Forms.Label
        Me.lblCompanyDomain = New System.Windows.Forms.Label
        Me.grpUserInformation = New System.Windows.Forms.GroupBox
        Me.txtCompanyDomain = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.stsStatusBar = New System.Windows.Forms.StatusStrip
        Me.lblHeading = New System.Windows.Forms.Label
        Me.grpAccountInformation.SuspendLayout()
        Me.grpUserInformation.SuspendLayout()
        Me.stsStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(373, 327)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 35)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(27, 30)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(78, 16)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name*"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(236, 328)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 33)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(107, 328)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(107, 33)
        Me.btnGenerate.TabIndex = 11
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'stsStatus
        '
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(39, 17)
        Me.stsStatus.Text = "Ready"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(10, 10)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(118, 13)
        Me.lblCopyright.TabIndex = 10
        Me.lblCopyright.Text = "© Tran Tuan Anh 2011"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(27, 94)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(78, 16)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name*"
        '
        'grpAccountInformation
        '
        Me.grpAccountInformation.Controls.Add(Me.lblEmailAddress)
        Me.grpAccountInformation.Controls.Add(Me.lblPassword)
        Me.grpAccountInformation.Controls.Add(Me.lblUsername)
        Me.grpAccountInformation.Controls.Add(Me.lblEmailAddressHeading)
        Me.grpAccountInformation.Controls.Add(Me.lblPasswordHeading)
        Me.grpAccountInformation.Controls.Add(Me.lblUsernameHeading)
        Me.grpAccountInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccountInformation.Location = New System.Drawing.Point(310, 82)
        Me.grpAccountInformation.Name = "grpAccountInformation"
        Me.grpAccountInformation.Size = New System.Drawing.Size(240, 230)
        Me.grpAccountInformation.TabIndex = 9
        Me.grpAccountInformation.TabStop = False
        Me.grpAccountInformation.Text = "Account Information"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(29, 180)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(180, 27)
        Me.lblEmailAddress.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(29, 114)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(180, 27)
        Me.lblPassword.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(29, 50)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(180, 27)
        Me.lblUsername.TabIndex = 3
        '
        'lblEmailAddressHeading
        '
        Me.lblEmailAddressHeading.AutoSize = True
        Me.lblEmailAddressHeading.Location = New System.Drawing.Point(26, 160)
        Me.lblEmailAddressHeading.Name = "lblEmailAddressHeading"
        Me.lblEmailAddressHeading.Size = New System.Drawing.Size(96, 16)
        Me.lblEmailAddressHeading.TabIndex = 2
        Me.lblEmailAddressHeading.Text = "Email Address"
        '
        'lblPasswordHeading
        '
        Me.lblPasswordHeading.AutoSize = True
        Me.lblPasswordHeading.Location = New System.Drawing.Point(26, 94)
        Me.lblPasswordHeading.Name = "lblPasswordHeading"
        Me.lblPasswordHeading.Size = New System.Drawing.Size(68, 16)
        Me.lblPasswordHeading.TabIndex = 1
        Me.lblPasswordHeading.Text = "Password"
        '
        'lblUsernameHeading
        '
        Me.lblUsernameHeading.AutoSize = True
        Me.lblUsernameHeading.Location = New System.Drawing.Point(26, 30)
        Me.lblUsernameHeading.Name = "lblUsernameHeading"
        Me.lblUsernameHeading.Size = New System.Drawing.Size(71, 16)
        Me.lblUsernameHeading.TabIndex = 0
        Me.lblUsernameHeading.Text = "Username"
        '
        'lblCompanyDomain
        '
        Me.lblCompanyDomain.AutoSize = True
        Me.lblCompanyDomain.Location = New System.Drawing.Point(27, 160)
        Me.lblCompanyDomain.Name = "lblCompanyDomain"
        Me.lblCompanyDomain.Size = New System.Drawing.Size(121, 16)
        Me.lblCompanyDomain.TabIndex = 2
        Me.lblCompanyDomain.Text = "Company Domain*"
        '
        'grpUserInformation
        '
        Me.grpUserInformation.Controls.Add(Me.txtCompanyDomain)
        Me.grpUserInformation.Controls.Add(Me.txtLastName)
        Me.grpUserInformation.Controls.Add(Me.txtFirstName)
        Me.grpUserInformation.Controls.Add(Me.lblCompanyDomain)
        Me.grpUserInformation.Controls.Add(Me.lblLastName)
        Me.grpUserInformation.Controls.Add(Me.lblFirstName)
        Me.grpUserInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserInformation.Location = New System.Drawing.Point(40, 82)
        Me.grpUserInformation.Name = "grpUserInformation"
        Me.grpUserInformation.Size = New System.Drawing.Size(240, 230)
        Me.grpUserInformation.TabIndex = 8
        Me.grpUserInformation.TabStop = False
        Me.grpUserInformation.Text = "User Information"
        '
        'txtCompanyDomain
        '
        Me.txtCompanyDomain.Location = New System.Drawing.Point(30, 180)
        Me.txtCompanyDomain.Name = "txtCompanyDomain"
        Me.txtCompanyDomain.Size = New System.Drawing.Size(180, 22)
        Me.txtCompanyDomain.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(30, 114)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(180, 22)
        Me.txtLastName.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(30, 50)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 22)
        Me.txtFirstName.TabIndex = 3
        '
        'stsStatusBar
        '
        Me.stsStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsStatus})
        Me.stsStatusBar.Location = New System.Drawing.Point(0, 380)
        Me.stsStatusBar.Name = "stsStatusBar"
        Me.stsStatusBar.Size = New System.Drawing.Size(584, 22)
        Me.stsStatusBar.TabIndex = 7
        Me.stsStatusBar.Text = "Ready"
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(44, 23)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(506, 56)
        Me.lblHeading.TabIndex = 14
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAccountGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 402)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.grpAccountInformation)
        Me.Controls.Add(Me.grpUserInformation)
        Me.Controls.Add(Me.stsStatusBar)
        Me.Name = "frmAccountGenerator"
        Me.Text = "Account Generator"
        Me.grpAccountInformation.ResumeLayout(False)
        Me.grpAccountInformation.PerformLayout()
        Me.grpUserInformation.ResumeLayout(False)
        Me.grpUserInformation.PerformLayout()
        Me.stsStatusBar.ResumeLayout(False)
        Me.stsStatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents stsStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents grpAccountInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddressHeading As System.Windows.Forms.Label
    Friend WithEvents lblPasswordHeading As System.Windows.Forms.Label
    Friend WithEvents lblUsernameHeading As System.Windows.Forms.Label
    Friend WithEvents lblCompanyDomain As System.Windows.Forms.Label
    Friend WithEvents grpUserInformation As System.Windows.Forms.GroupBox
    Friend WithEvents txtCompanyDomain As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents stsStatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents lblHeading As System.Windows.Forms.Label
End Class
