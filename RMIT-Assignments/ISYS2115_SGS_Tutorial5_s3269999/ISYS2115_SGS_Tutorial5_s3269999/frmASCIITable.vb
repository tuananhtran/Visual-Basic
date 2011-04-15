'Project: ASCII Table
'Lab: Number 5
'Programmer: Tran Tuan Anh
'Created: 21st March, 2011
'Purpose: This program is to generate the ASCII table with For loop

Public Class frmASCIITable

    Private Sub frmASCIITable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'declare variables to store output values
        Dim sASCIIOutput1 As String = ""
        Dim sASCIIOutput2 As String = ""
        Dim sASCIIOutput3 As String = ""
        Dim sASCIIOutput4 As String = ""

        'loop 1: ASCII characters from 30 to 54
        For iCounter As Integer = 30 To 54
            sASCIIOutput1 = sASCIIOutput1 & iCounter & " = " & Chr(iCounter) & vbCrLf
        Next

        'loop 2: ASCII characters from 55 to 79
        For iCounter As Integer = 55 To 79
            sASCIIOutput2 = sASCIIOutput2 & iCounter & " = " & Chr(iCounter) & vbCrLf
        Next

        'loop 3: ASCII characters from 80 to 104
        For iCounter As Integer = 80 To 104
            sASCIIOutput3 = sASCIIOutput3 & iCounter & " = " & Chr(iCounter) & vbCrLf
        Next

        'loop 4: ASCII characters from 105 to 129
        For iCounter As Integer = 105 To 129
            sASCIIOutput4 = sASCIIOutput4 & iCounter & " = " & Chr(iCounter) & vbCrLf
        Next

        'display results to user
        lblASCIICharacter30To54.Text = sASCIIOutput1
        lblASCIICharater55To79.Text = sASCIIOutput2
        lblASCIICharater80To104.Text = sASCIIOutput3
        lblASCIICharater105To129.Text = sASCIIOutput4
    End Sub
End Class
