<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKilosToPoundsConverter
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
        Me.lblKilosLabel = New System.Windows.Forms.Label
        Me.lblPoundsLabel = New System.Windows.Forms.Label
        Me.lblPounds = New System.Windows.Forms.Label
        Me.txtKilos = New System.Windows.Forms.TextBox
        Me.btnConvert = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblKilosLabel
        '
        Me.lblKilosLabel.AutoSize = True
        Me.lblKilosLabel.Location = New System.Drawing.Point(69, 40)
        Me.lblKilosLabel.Name = "lblKilosLabel"
        Me.lblKilosLabel.Size = New System.Drawing.Size(102, 16)
        Me.lblKilosLabel.TabIndex = 0
        Me.lblKilosLabel.Text = "Enter Kilograms"
        '
        'lblPoundsLabel
        '
        Me.lblPoundsLabel.AutoSize = True
        Me.lblPoundsLabel.Location = New System.Drawing.Point(273, 40)
        Me.lblPoundsLabel.Name = "lblPoundsLabel"
        Me.lblPoundsLabel.Size = New System.Drawing.Size(118, 16)
        Me.lblPoundsLabel.TabIndex = 1
        Me.lblPoundsLabel.Text = "Number of pounds"
        '
        'lblPounds
        '
        Me.lblPounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPounds.Location = New System.Drawing.Point(256, 65)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(149, 22)
        Me.lblPounds.TabIndex = 2
        '
        'txtKilos
        '
        Me.txtKilos.Location = New System.Drawing.Point(44, 65)
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.Size = New System.Drawing.Size(149, 22)
        Me.txtKilos.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(157, 152)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(120, 63)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'frmKilosToPoundsConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 266)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtKilos)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.lblPoundsLabel)
        Me.Controls.Add(Me.lblKilosLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmKilosToPoundsConverter"
        Me.Text = "Kilos to Pounds Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKilosLabel As System.Windows.Forms.Label
    Friend WithEvents lblPoundsLabel As System.Windows.Forms.Label
    Friend WithEvents lblPounds As System.Windows.Forms.Label
    Friend WithEvents txtKilos As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
End Class
