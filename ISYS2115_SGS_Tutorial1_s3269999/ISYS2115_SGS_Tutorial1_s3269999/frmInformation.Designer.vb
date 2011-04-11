<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformation
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
        Me.lblAuthor = New System.Windows.Forms.Label
        Me.lblAge = New System.Windows.Forms.Label
        Me.lblLocation = New System.Windows.Forms.Label
        Me.btnShowDetails = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblAuthor
        '
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(52, 42)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Padding = New System.Windows.Forms.Padding(2)
        Me.lblAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAuthor.Size = New System.Drawing.Size(420, 50)
        Me.lblAuthor.TabIndex = 0
        '
        'lblAge
        '
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(52, 115)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Padding = New System.Windows.Forms.Padding(2)
        Me.lblAge.Size = New System.Drawing.Size(420, 80)
        Me.lblAge.TabIndex = 1
        '
        'lblLocation
        '
        Me.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(52, 218)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Padding = New System.Windows.Forms.Padding(2)
        Me.lblLocation.Size = New System.Drawing.Size(420, 140)
        Me.lblLocation.TabIndex = 2
        '
        'btnShowDetails
        '
        Me.btnShowDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDetails.Location = New System.Drawing.Point(102, 380)
        Me.btnShowDetails.Name = "btnShowDetails"
        Me.btnShowDetails.Size = New System.Drawing.Size(120, 40)
        Me.btnShowDetails.TabIndex = 3
        Me.btnShowDetails.Text = "Show Details"
        Me.btnShowDetails.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(302, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "© 2011 Tran Tuan Anh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "v1.0"
        '
        'frmInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 472)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowDetails)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblAuthor)
        Me.Name = "frmInformation"
        Me.Text = "GENERAL INFORMATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents btnShowDetails As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
