'Project: Paradise Bookings Processing System
'Assignment: Number 3
'Programmer: Tran Tuan Anh
'Created: 4th May, 2011
'Application Purpose: This program is to record and store room bookings of Paradise Beach Resort
'Form Purpose: This is the search form, which allows user to search for particular bookings with specified details

'import library for file handling
Imports System.IO

Public Class frmSearch

    'declare array lists to store data fetched from room records database
    Dim SUBookings As ArrayList = New ArrayList 'data array list for room type Superior
    Dim DEBookings As ArrayList = New ArrayList 'data array list for room type Deluxe
    Dim PDBookings As ArrayList = New ArrayList 'data array list for room type Premium Deluxe
    Dim JSBookings As ArrayList = New ArrayList 'data array list for room type Junior Suite
    Dim PSBookings As ArrayList = New ArrayList 'data array list for room type Presidential Suite

    'declare array list to store search result
    Dim Result As ArrayList = New ArrayList

    Private Sub rdbSearchByManagerName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSearchByManagerName.CheckedChanged
        'enable and disable input field accordingly to "search by manager name" condition

        If rdbSearchByManagerName.Checked Then

            'if "search by manager name" is chosen, enable the manager name field
            txtManagerName.Enabled = True

        Else

            'else, disable manager name field
            txtManagerName.Enabled = False

        End If

    End Sub

    Private Sub rdbSearchByCustomerLastName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSearchByCustomerLastName.CheckedChanged
        'enable and disable input field accordingly to "search by customer last name" condition

        If rdbSearchByCustomerLastName.Checked Then

            'if "search by customer last name" is chosen, enable the customer last name field
            txtCustomerLastName.Enabled = True

        Else

            'else, disable customer last name field
            txtCustomerLastName.Enabled = False

        End If

    End Sub

    Private Sub rdbSearchByRoomCost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSearchByRoomCost.CheckedChanged
        'enable and disable input fields accordingly to "search by room cost" condition

        If rdbSearchByRoomCost.Checked Then

            'if "search by room cost" is chosen, enable the start and end cost fields
            txtMinRoomCost.Enabled = True
            txtMaxRoomCost.Enabled = True

        Else

            'else, disable start and end cost fields
            txtMinRoomCost.Enabled = False
            txtMaxRoomCost.Enabled = False

        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'search for particular bookings with specified data

        'validate input data
        If bSearchConditionIsValid() Then
            'if search condition validation passed, query and display the result

            'clear past result
            Result.Clear()
            dgvResult.Rows.Clear()

            'load booking data from database
            Call loadBookingData()

            If rdbSearchByManagerName.Checked Then

                'if Search by Manager Name selected, search bookings by manager name
                Call searchByManagerName()

                'display result
                Call displayResult()

            ElseIf rdbSearchByCustomerLastName.Checked Then

                'if Search by Customer Last Name selected, search bookings by customer last name
                Call searchByCustomerLastName()

                'display result
                Call displayResult()

            Else

                'if Search by Room Cost selected, search bookings by room cost range
                Call searchByRoomCost()

                'display result
                Call displayResult()

            End If

        End If

    End Sub

    Private Sub loadBookingData()
        'load booking data from database

        'clear current data in array lists
        SUBookings.Clear()
        DEBookings.Clear()
        PDBookings.Clear()
        JSBookings.Clear()
        PSBookings.Clear()

        'begin load data from database file(s)

        If cbxTypeSuperior.Checked Then

            'if superior option selected, fetch SU database
            Call fetchSUBookingData()

        End If

        If cbxTypeDeluxe.Checked Then

            'if deluxe option selected, fetch DE database
            Call fetchDEBookingData()

        End If

        If cbxTypePremiumDeluxe.Checked Then

            'if premium deluxe option selected, fetch PD database
            Call fetchPDBookingData()

        End If

        If cbxTypeJuniorSuite.Checked Then

            'if junior suite option selected, fetch JS database
            Call fetchJSBookingData()

        End If

        If cbxTypePresidentialSuite.Checked Then

            'if presidential suite option selected, fetch PS database
            Call fetchPSBookingData()

        End If

    End Sub

    Private Sub fetchSUBookingData()
        'get booking data for room type Superior

        'define database name and location
        Const sSUBookingDatabase As String = "SU.txt"
        Dim sSUBookingDatabaseLocation As String = Application.StartupPath & "\" & sSUBookingDatabase

        'begin to fetch data from database

        'check if SU database exists
        If File.Exists(sSUBookingDatabaseLocation) Then
            'if SU database exists, load data to array list

            'declare temporary variables to store information while fetching data
            Dim sLine As String 'variable to store line fetched from database
            Dim sFields(12) As String 'variable to store fields splitted from sLine

            'declare stream reader
            Dim srSUDatabaseReader As StreamReader = File.OpenText(sSUBookingDatabaseLocation)

            'begin to get data
            sLine = srSUDatabaseReader.ReadLine
            While sLine <> Nothing
                'if in each fetch, data is not null, add data to array list

                'split line fetched to fields stored in an array
                sFields = Split(sLine, ",")

                'add array to array list
                SUBookings.Add(sFields)

                'read next line
                sLine = srSUDatabaseReader.ReadLine

            End While

            'close file
            srSUDatabaseReader.Close()

        End If

    End Sub

    Private Sub fetchDEBookingData()
        'get booking data for room type Deluxe

        'define database name and location
        Const sDEBookingDatabase As String = "DE.txt"
        Dim sDEBookingDatabaseLocation As String = Application.StartupPath & "\" & sDEBookingDatabase

        'begin to fetch data from database

        'check if DE database exists
        If File.Exists(sDEBookingDatabaseLocation) Then
            'if DE database exists, load data to array list

            'declare temporary variables to store information while fetching data
            Dim sLine As String 'variable to store line fetched from database
            Dim sFields(12) As String 'variable to store fields splitted from sLine

            'declare stream reader
            Dim srDEDatabaseReader As StreamReader = File.OpenText(sDEBookingDatabaseLocation)

            'begin to get data
            sLine = srDEDatabaseReader.ReadLine
            While sLine <> Nothing
                'if in each fetch, data is not null, add data to array list

                'split line fetched to fields stored in an array
                sFields = Split(sLine, ",")

                'add array to array list
                DEBookings.Add(sFields)

                'read next line
                sLine = srDEDatabaseReader.ReadLine

            End While

            'close file
            srDEDatabaseReader.Close()

        End If

    End Sub

    Private Sub fetchPDBookingData()
        'get booking data for room type Premium Deluxe

        'define database name and location
        Const sPDBookingDatabase As String = "PD.txt"
        Dim sPDBookingDatabaseLocation As String = Application.StartupPath & "\" & sPDBookingDatabase

        'begin to fetch data from database

        'check if PD database exists
        If File.Exists(sPDBookingDatabaseLocation) Then
            'if PD database exists, load data to array list

            'declare temporary variables to store information while fetching data
            Dim sLine As String 'variable to store line fetched from database
            Dim sFields(12) As String 'variable to store fields splitted from sLine

            'declare stream reader
            Dim srPDDatabaseReader As StreamReader = File.OpenText(sPDBookingDatabaseLocation)

            'begin to get data
            sLine = srPDDatabaseReader.ReadLine
            While sLine <> Nothing
                'if in each fetch, data is not null, add data to array list

                'split line fetched to fields stored in an array
                sFields = Split(sLine, ",")

                'add array to array list
                PDBookings.Add(sFields)

                'read next line
                sLine = srPDDatabaseReader.ReadLine

            End While

            'close file
            srPDDatabaseReader.Close()

        End If

    End Sub

    Private Sub fetchJSBookingData()
        'get booking data for room type Junior Suite

        'define database name and location
        Const sJSBookingDatabase As String = "JS.txt"
        Dim sJSBookingDatabaseLocation As String = Application.StartupPath & "\" & sJSBookingDatabase

        'begin to fetch data from database

        'check if JS database exists
        If File.Exists(sJSBookingDatabaseLocation) Then
            'if JS database exists, load data to array list

            'declare temporary variables to store information while fetching data
            Dim sLine As String 'variable to store line fetched from database
            Dim sFields(12) As String 'variable to store fields splitted from sLine

            'declare stream reader
            Dim srJSDatabaseReader As StreamReader = File.OpenText(sJSBookingDatabaseLocation)

            'begin to get data
            sLine = srJSDatabaseReader.ReadLine
            While sLine <> Nothing
                'if in each fetch, data is not null, add data to array list

                'split line fetched to fields stored in an array
                sFields = Split(sLine, ",")

                'add array to array list
                JSBookings.Add(sFields)

                'read next line
                sLine = srJSDatabaseReader.ReadLine

            End While

            'close file
            srJSDatabaseReader.Close()

        End If

    End Sub

    Private Sub fetchPSBookingData()
        'get booking data for room type Presidential Suite

        'define database name and location
        Const sPSBookingDatabase As String = "PS.txt"
        Dim sPSBookingDatabaseLocation As String = Application.StartupPath & "\" & sPSBookingDatabase

        'begin to fetch data from database

        'check if PS database exists
        If File.Exists(sPSBookingDatabaseLocation) Then
            'if PS database exists, load data to array list

            'declare temporary variables to store information while fetching data
            Dim sLine As String 'variable to store line fetched from database
            Dim sFields(12) As String 'variable to store fields splitted from sLine

            'declare stream reader
            Dim srPSDatabaseReader As StreamReader = File.OpenText(sPSBookingDatabaseLocation)

            'begin to get data
            sLine = srPSDatabaseReader.ReadLine
            While sLine <> Nothing
                'if in each fetch, data is not null, add data to array list

                'split line fetched to fields stored in an array
                sFields = Split(sLine, ",")

                'add array to array list
                PSBookings.Add(sFields)

                'read next line
                sLine = srPSDatabaseReader.ReadLine

            End While

            'close file
            srPSDatabaseReader.Close()

        End If

    End Sub

    Private Sub searchByManagerName()
        'search for particular bookings with specified manager name

        'get manager name and store in local variable
        Dim sName As String = txtManagerName.Text

        'begin to search

        'declare temporary variables
        Dim enumerator As IEnumerator   'enumerator to loop through data array lists
        Dim sCurrent(10) As String  'array to store current pointed group of data in array list

        If cbxTypeSuperior.Checked Then
            'if superior type chosen, search superior booking database to add item(s)

            'get enumerator
            enumerator = SUBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(0)) = LCase(sName) Then

                    'if manager name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypeDeluxe.Checked Then
            'if deluxe type chosen, search deluxe booking database to add item(s)

            'get enumerator
            enumerator = DEBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(0)) = LCase(sName) Then

                    'if manager name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypePremiumDeluxe.Checked Then
            'if premium deluxe type chosen, search premium deluxe booking database to add item(s)

            'get enumerator
            enumerator = PDBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(0)) = LCase(sName) Then

                    'if manager name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypeJuniorSuite.Checked Then
            'if junior suite type chosen, search junior suite booking database to add item(s)

            'get enumerator
            enumerator = JSBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(0)) = LCase(sName) Then

                    'if manager name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypePresidentialSuite.Checked Then
            'if presidential suite type chosen, search presidential suite booking database to add item(s)

            'get enumerator
            enumerator = PSBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(0)) = LCase(sName) Then

                    'if manager name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

    End Sub

    Private Sub searchByCustomerLastName()
        'search for particular bookings with specified customer last name

        'get customer last name and store in local variable
        Dim sName As String = txtCustomerLastName.Text

        'begin to search

        'declare temporary variables
        Dim enumerator As IEnumerator   'enumerator to loop through data array lists
        Dim sCurrent(10) As String  'array to store current pointed group of data in array list

        If cbxTypeSuperior.Checked Then
            'if superior type chosen, search superior booking database to add item(s)

            'get enumerator
            enumerator = SUBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(3)) = LCase(sName) Then

                    'if customer last name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypeDeluxe.Checked Then
            'if deluxe type chosen, search deluxe booking database to add item(s)

            'get enumerator
            enumerator = DEBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(3)) = LCase(sName) Then

                    'if customer last name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypePremiumDeluxe.Checked Then
            'if premium deluxe type chosen, search premium deluxe booking database to add item(s)

            'get enumerator
            enumerator = PDBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(3)) = LCase(sName) Then

                    'if customer last name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypeJuniorSuite.Checked Then
            'if junior suite type chosen, search junior suite booking database to add item(s)

            'get enumerator
            enumerator = JSBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(3)) = LCase(sName) Then

                    'if customer last name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypePresidentialSuite.Checked Then
            'if presidential suite type chosen, search presidential suite booking database to add item(s)

            'get enumerator
            enumerator = PSBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If LCase(sCurrent(3)) = LCase(sName) Then

                    'if customer last name matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

    End Sub

    Private Sub searchByRoomCost()
        'search for particular bookings with specified room cost range

        'get min and max room costs and store in local variables
        Dim dMin As Double = CDbl(txtMinRoomCost.Text)
        Dim dMax As Double = CDbl(txtMaxRoomCost.Text)

        'begin to search

        'declare temporary variables
        Dim enumerator As IEnumerator   'enumerator to loop through data array lists
        Dim sCurrent(10) As String  'array to store current pointed group of data in array list

        If cbxTypeSuperior.Checked Then
            'if superior type chosen, search superior booking database to add item(s)

            'get enumerator
            enumerator = SUBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If CDbl(sCurrent(12)) >= dMin And CDbl(sCurrent(12)) <= dMax Then

                    'if room range matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypeDeluxe.Checked Then
            'if deluxe type chosen, search deluxe booking database to add item(s)

            'get enumerator
            enumerator = DEBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If CDbl(sCurrent(12)) >= dMin And CDbl(sCurrent(12)) <= dMax Then

                    'if room range matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypePremiumDeluxe.Checked Then
            'if premium deluxe type chosen, search premium deluxe booking database to add item(s)

            'get enumerator
            enumerator = PDBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If CDbl(sCurrent(12)) >= dMin And CDbl(sCurrent(12)) <= dMax Then

                    'if room range matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypeJuniorSuite.Checked Then
            'if junior suite type chosen, search junior suite booking database to add item(s)

            'get enumerator
            enumerator = JSBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If CDbl(sCurrent(12)) >= dMin And CDbl(sCurrent(12)) <= dMax Then


                    'if room range matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

        If cbxTypePresidentialSuite.Checked Then
            'if presidential suite type chosen, search presidential suite booking database to add item(s)

            'get enumerator
            enumerator = PSBookings.GetEnumerator

            'begin to search data
            While enumerator.MoveNext

                'get current pointed data object
                sCurrent = CType(enumerator.Current, String())

                'check if matched data found
                If CDbl(sCurrent(12)) >= dMin And CDbl(sCurrent(12)) <= dMax Then

                    'if room range matched, add result to result array list
                    Result.Add(sCurrent)

                End If

            End While

        End If

    End Sub

    Private Sub displayResult()
        'display search result

        'clear old result
        dgvResult.Rows.Clear()

        'get enumerator for result arraylist
        Dim enumerator As IEnumerator = Result.GetEnumerator

        'get items from array list and add to data grid view
        While enumerator.MoveNext

            'get current pointed item in array list
            Dim sCurrent(10) As String
            sCurrent = CType(enumerator.Current, String())

            'add new record to data grid view and get current index
            Dim iIndex As Integer = dgvResult.Rows.Add()

            'set record with received data
            dgvResult.Rows(iIndex).Cells(0).Value = sCurrent(0)
            dgvResult.Rows(iIndex).Cells(1).Value = sCurrent(1)
            dgvResult.Rows(iIndex).Cells(2).Value = sCurrent(2)
            dgvResult.Rows(iIndex).Cells(3).Value = sCurrent(3)
            dgvResult.Rows(iIndex).Cells(4).Value = sCurrent(4)
            dgvResult.Rows(iIndex).Cells(5).Value = sCurrent(7)
            dgvResult.Rows(iIndex).Cells(6).Value = FormatCurrency(sCurrent(8))
            dgvResult.Rows(iIndex).Cells(7).Value = sCurrent(9)
            dgvResult.Rows(iIndex).Cells(8).Value = sCurrent(10)
            dgvResult.Rows(iIndex).Cells(9).Value = sCurrent(11)
            dgvResult.Rows(iIndex).Cells(10).Value = FormatCurrency(sCurrent(12))

        End While

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear/reset all input and output fields

        'clear fields
        txtManagerName.Text = ""
        txtCustomerLastName.Text = ""
        txtMinRoomCost.Text = ""
        txtMaxRoomCost.Text = ""
        dgvResult.Rows.Clear()

        'reset fields
        rdbSearchByManagerName.Checked = True
        cbxTypeSuperior.Checked = False
        cbxTypeDeluxe.Checked = False
        cbxTypePremiumDeluxe.Checked = False
        cbxTypeJuniorSuite.Checked = False
        cbxTypePresidentialSuite.Checked = False

    End Sub

End Class