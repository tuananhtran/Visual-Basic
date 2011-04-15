<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConverter
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
        Me.lblHeading = New System.Windows.Forms.Label
        Me.lblFeetHeading = New System.Windows.Forms.Label
        Me.lblMetresHeading = New System.Windows.Forms.Label
        Me.lblPoundsHeading = New System.Windows.Forms.Label
        Me.lblKilosHeading = New System.Windows.Forms.Label
        Me.txtFeet = New System.Windows.Forms.TextBox
        Me.txtPounds = New System.Windows.Forms.TextBox
        Me.btnFeetMetres = New System.Windows.Forms.Button
        Me.btnPoundsKilos = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblMetres = New System.Windows.Forms.Label
        Me.lblKilos = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(66, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(284, 40)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Metric Converter"
        '
        'lblFeetHeading
        '
        Me.lblFeetHeading.AutoSize = True
        Me.lblFeetHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeetHeading.Location = New System.Drawing.Point(60, 66)
        Me.lblFeetHeading.Name = "lblFeetHeading"
        Me.lblFeetHeading.Size = New System.Drawing.Size(37, 18)
        Me.lblFeetHeading.TabIndex = 1
        Me.lblFeetHeading.Text = "Feet"
        '
        'lblMetresHeading
        '
        Me.lblMetresHeading.AutoSize = True
        Me.lblMetresHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetresHeading.Location = New System.Drawing.Point(240, 66)
        Me.lblMetresHeading.Name = "lblMetresHeading"
        Me.lblMetresHeading.Size = New System.Drawing.Size(54, 18)
        Me.lblMetresHeading.TabIndex = 2
        Me.lblMetresHeading.Text = "Metres"
        '
        'lblPoundsHeading
        '
        Me.lblPoundsHeading.AutoSize = True
        Me.lblPoundsHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoundsHeading.Location = New System.Drawing.Point(60, 190)
        Me.lblPoundsHeading.Name = "lblPoundsHeading"
        Me.lblPoundsHeading.Size = New System.Drawing.Size(59, 18)
        Me.lblPoundsHeading.TabIndex = 3
        Me.lblPoundsHeading.Text = "Pounds"
        '
        'lblKilosHeading
        '
        Me.lblKilosHeading.AutoSize = True
        Me.lblKilosHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKilosHeading.Location = New System.Drawing.Point(240, 190)
        Me.lblKilosHeading.Name = "lblKilosHeading"
        Me.lblKilosHeading.Size = New System.Drawing.Size(41, 18)
        Me.lblKilosHeading.TabIndex = 4
        Me.lblKilosHeading.Text = "Kilos"
        '
        'txtFeet
        '
        Me.txtFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeet.Location = New System.Drawing.Point(60, 90)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(120, 24)
        Me.txtFeet.TabIndex = 5
        '
        'txtPounds
        '
        Me.txtPounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPounds.Location = New System.Drawing.Point(60, 214)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(120, 24)
        Me.txtPounds.TabIndex = 7
        '
        'btnFeetMetres
        '
        Me.btnFeetMetres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeetMetres.Location = New System.Drawing.Point(120, 126)
        Me.btnFeetMetres.Name = "btnFeetMetres"
        Me.btnFeetMetres.Size = New System.Drawing.Size(200, 30)
        Me.btnFeetMetres.TabIndex = 9
        Me.btnFeetMetres.Text = "Convert Feet To Metres"
        Me.btnFeetMetres.UseVisualStyleBackColor = True
        '
        'btnPoundsKilos
        '
        Me.btnPoundsKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoundsKilos.Location = New System.Drawing.Point(120, 250)
        Me.btnPoundsKilos.Name = "btnPoundsKilos"
        Me.btnPoundsKilos.Size = New System.Drawing.Size(200, 30)
        Me.btnPoundsKilos.TabIndex = 10
        Me.btnPoundsKilos.Text = "Convert Pounds To Kilos"
        Me.btnPoundsKilos.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(130, 314)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(230, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMetres
        '
        Me.lblMetres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMetres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetres.Location = New System.Drawing.Point(241, 90)
        Me.lblMetres.Name = "lblMetres"
        Me.lblMetres.Size = New System.Drawing.Size(120, 24)
        Me.lblMetres.TabIndex = 13
        '
        'lblKilos
        '
        Me.lblKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKilos.Location = New System.Drawing.Point(240, 214)
        Me.lblKilos.Name = "lblKilos"
        Me.lblKilos.Size = New System.Drawing.Size(120, 24)
        Me.lblKilos.TabIndex = 14
        '
        'frmConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 362)
        Me.Controls.Add(Me.lblKilos)
        Me.Controls.Add(Me.lblMetres)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPoundsKilos)
        Me.Controls.Add(Me.btnFeetMetres)
        Me.Controls.Add(Me.txtPounds)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.lblKilosHeading)
        Me.Controls.Add(Me.lblPoundsHeading)
        Me.Controls.Add(Me.lblMetresHeading)
        Me.Controls.Add(Me.lblFeetHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmConverter"
        Me.Text = "Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblFeetHeading As System.Windows.Forms.Label
    Friend WithEvents lblMetresHeading As System.Windows.Forms.Label
    Friend WithEvents lblPoundsHeading As System.Windows.Forms.Label
    Friend WithEvents lblKilosHeading As System.Windows.Forms.Label
    Friend WithEvents txtFeet As System.Windows.Forms.TextBox
    Friend WithEvents txtPounds As System.Windows.Forms.TextBox
    Friend WithEvents btnFeetMetres As System.Windows.Forms.Button
    Friend WithEvents btnPoundsKilos As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMetres As System.Windows.Forms.Label
    Friend WithEvents lblKilos As System.Windows.Forms.Label

End Class
