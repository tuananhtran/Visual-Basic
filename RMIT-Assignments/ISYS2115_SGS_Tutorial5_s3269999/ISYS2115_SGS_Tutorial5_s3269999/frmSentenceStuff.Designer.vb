<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSentenceStuff
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
        Me.pnlSentenceStuff = New System.Windows.Forms.Panel
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblSentenceStuffHeading = New System.Windows.Forms.Label
        Me.lblOutputTextLabel = New System.Windows.Forms.Label
        Me.lblInputTextLabel = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEncryptText = New System.Windows.Forms.Button
        Me.btnReverseText = New System.Windows.Forms.Button
        Me.btnRepeatText = New System.Windows.Forms.Button
        Me.lblOutputText = New System.Windows.Forms.Label
        Me.txtInputText = New System.Windows.Forms.TextBox
        Me.ttpRepeatButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpReverseButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpEncryptButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpExitButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpClearButtonToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlSentenceStuff.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSentenceStuff
        '
        Me.pnlSentenceStuff.Controls.Add(Me.lblCopyright)
        Me.pnlSentenceStuff.Controls.Add(Me.lblSentenceStuffHeading)
        Me.pnlSentenceStuff.Controls.Add(Me.lblOutputTextLabel)
        Me.pnlSentenceStuff.Controls.Add(Me.lblInputTextLabel)
        Me.pnlSentenceStuff.Controls.Add(Me.btnClear)
        Me.pnlSentenceStuff.Controls.Add(Me.btnExit)
        Me.pnlSentenceStuff.Controls.Add(Me.btnEncryptText)
        Me.pnlSentenceStuff.Controls.Add(Me.btnReverseText)
        Me.pnlSentenceStuff.Controls.Add(Me.btnRepeatText)
        Me.pnlSentenceStuff.Controls.Add(Me.lblOutputText)
        Me.pnlSentenceStuff.Controls.Add(Me.txtInputText)
        Me.pnlSentenceStuff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSentenceStuff.Location = New System.Drawing.Point(0, 0)
        Me.pnlSentenceStuff.Name = "pnlSentenceStuff"
        Me.pnlSentenceStuff.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlSentenceStuff.Size = New System.Drawing.Size(624, 271)
        Me.pnlSentenceStuff.TabIndex = 0
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(12, 246)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(138, 16)
        Me.lblCopyright.TabIndex = 5
        Me.lblCopyright.Text = "© Tran Tuan Anh 2011"
        '
        'lblSentenceStuffHeading
        '
        Me.lblSentenceStuffHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSentenceStuffHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSentenceStuffHeading.Location = New System.Drawing.Point(20, 20)
        Me.lblSentenceStuffHeading.Name = "lblSentenceStuffHeading"
        Me.lblSentenceStuffHeading.Size = New System.Drawing.Size(584, 31)
        Me.lblSentenceStuffHeading.TabIndex = 9
        Me.lblSentenceStuffHeading.Text = "Sentence Stuff"
        Me.lblSentenceStuffHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputTextLabel
        '
        Me.lblOutputTextLabel.AutoSize = True
        Me.lblOutputTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputTextLabel.Location = New System.Drawing.Point(319, 81)
        Me.lblOutputTextLabel.Name = "lblOutputTextLabel"
        Me.lblOutputTextLabel.Size = New System.Drawing.Size(75, 16)
        Me.lblOutputTextLabel.TabIndex = 8
        Me.lblOutputTextLabel.Text = "Output Text"
        '
        'lblInputTextLabel
        '
        Me.lblInputTextLabel.AutoSize = True
        Me.lblInputTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputTextLabel.Location = New System.Drawing.Point(38, 81)
        Me.lblInputTextLabel.Name = "lblInputTextLabel"
        Me.lblInputTextLabel.Size = New System.Drawing.Size(65, 16)
        Me.lblInputTextLabel.TabIndex = 7
        Me.lblInputTextLabel.Text = "Input Text"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(387, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 39)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(500, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEncryptText
        '
        Me.btnEncryptText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncryptText.Location = New System.Drawing.Point(272, 168)
        Me.btnEncryptText.Name = "btnEncryptText"
        Me.btnEncryptText.Size = New System.Drawing.Size(88, 39)
        Me.btnEncryptText.TabIndex = 6
        Me.btnEncryptText.Text = "&Encrypt"
        Me.btnEncryptText.UseVisualStyleBackColor = True
        '
        'btnReverseText
        '
        Me.btnReverseText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReverseText.Location = New System.Drawing.Point(158, 168)
        Me.btnReverseText.Name = "btnReverseText"
        Me.btnReverseText.Size = New System.Drawing.Size(88, 39)
        Me.btnReverseText.TabIndex = 5
        Me.btnReverseText.Text = "Re&verse"
        Me.btnReverseText.UseVisualStyleBackColor = True
        '
        'btnRepeatText
        '
        Me.btnRepeatText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepeatText.Location = New System.Drawing.Point(41, 168)
        Me.btnRepeatText.Name = "btnRepeatText"
        Me.btnRepeatText.Size = New System.Drawing.Size(88, 39)
        Me.btnRepeatText.TabIndex = 4
        Me.btnRepeatText.Text = "&Repeat"
        Me.btnRepeatText.UseVisualStyleBackColor = True
        '
        'lblOutputText
        '
        Me.lblOutputText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputText.Location = New System.Drawing.Point(322, 106)
        Me.lblOutputText.Name = "lblOutputText"
        Me.lblOutputText.Size = New System.Drawing.Size(266, 25)
        Me.lblOutputText.TabIndex = 3
        '
        'txtInputText
        '
        Me.txtInputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputText.Location = New System.Drawing.Point(41, 109)
        Me.txtInputText.Name = "txtInputText"
        Me.txtInputText.Size = New System.Drawing.Size(266, 22)
        Me.txtInputText.TabIndex = 2
        '
        'frmSentenceStuff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 271)
        Me.Controls.Add(Me.pnlSentenceStuff)
        Me.Name = "frmSentenceStuff"
        Me.Text = "Sentence Stuff"
        Me.pnlSentenceStuff.ResumeLayout(False)
        Me.pnlSentenceStuff.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSentenceStuff As System.Windows.Forms.Panel
    Friend WithEvents lblOutputText As System.Windows.Forms.Label
    Friend WithEvents txtInputText As System.Windows.Forms.TextBox
    Friend WithEvents lblOutputTextLabel As System.Windows.Forms.Label
    Friend WithEvents lblInputTextLabel As System.Windows.Forms.Label
    Friend WithEvents btnEncryptText As System.Windows.Forms.Button
    Friend WithEvents btnReverseText As System.Windows.Forms.Button
    Friend WithEvents btnRepeatText As System.Windows.Forms.Button
    Friend WithEvents lblSentenceStuffHeading As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ttpRepeatButtonToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ttpReverseButtonToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ttpEncryptButtonToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ttpExitButtonToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ttpClearButtonToolTip As System.Windows.Forms.ToolTip
End Class
