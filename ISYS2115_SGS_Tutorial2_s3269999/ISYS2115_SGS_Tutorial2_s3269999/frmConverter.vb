'Project: Unit Converter
'Lab: Number 2
'Programmer: Tran Tuan Anh
'Created: 10th March, 2011
'Purpose: This program is to convert feet to metres and pounds to kilos.

Public Class frmConverter
    'define constances of ratio between feet and metre and ratio between pound and kilos
    Const dFeetMetresRate As Double = 0.3048
    Const dPoundKilosRate As Double = 0.45359237

    Private Sub btnFeetMetres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeetMetres.Click
        'define variables to store values of feet and metres
        Dim dFeet As Double
        Dim dMetres As Double

        'convert feet to metres and display result
        dFeet = CDbl(txtFeet.Text)
        dMetres = dFeet * dFeetMetresRate
        lblMetres.Text = FormatNumber(dMetres)
    End Sub

    Private Sub btnPoundsKilos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoundsKilos.Click
        'define variables to store values of pounds to kilos
        Dim dPounds As Double
        Dim dKilos As Double

        'convert pounds to kilos and display result
        dPounds = CDbl(txtPounds.Text)
        dKilos = dPounds * dPoundKilosRate
        lblKilos.Text = FormatNumber(dKilos)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear fields of feet-to-metres converter
        txtFeet.Text = ""
        lblMetres.Text = ""

        'clear fields of pounds-to-kilos converter
        txtPounds.Text = ""
        lblKilos.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'close the form and exit the application
        Close()
    End Sub
End Class
