'Project: Paradise Bookings Processing System
'Assignment: Number 3
'Programmer: Tran Tuan Anh
'Created: 4th May, 2011
'Application Purpose: This program is to record and store room bookings of Paradise Beach Resort
'Module Purpose: This module contains validation for all input fields 

'import libraries for regular expressions
Imports System.Text.RegularExpressions

Module Validation

    Public Function bRoomRecordIsValid(ByVal sFields() As String) As String
        'validate room record retrieved from room type database

        'declare variables to store fields
        Dim sRoomTypeID As String = sFields(0)
        Dim sRoomType As String = sFields(1)
        Dim sRoomSize As String = sFields(2)
        Dim sRoomRate As String = sFields(3)

        If sRoomTypeID = "" Then

            'if room type id is blank, return error message
            Return "Room Type ID is blank"

        ElseIf IsNumeric(sRoomTypeID) Then

            'if room type id is numeric, return error message
            Return "Room Type ID is numeric"

        ElseIf sRoomType = "" Then

            'if room type is blank, return error message
            Return "Room Type is blank"

        ElseIf IsNumeric(sRoomType) Then

            'if room type is numeric, return error message
            Return "Room Type is numeric"

        ElseIf sRoomSize = "" Then

            'if room size is blank, return error message
            Return "Room Size is blank"

        ElseIf Not IsNumeric(sRoomSize) Then

            'if room size is not numeric, return error message
            Return "Room Size is not numeric"

        ElseIf CInt(sRoomSize) < 0 Then

            'if room size is less than 0, return error message
            Return "Room Size is negative"

        ElseIf sRoomRate = "" Then

            'if room rate is blank, return error message
            Return "Room Rate is blank"

        ElseIf Not IsNumeric(sRoomRate) Then

            'if room rate is not a number, return error message
            Return "Room Rate is not numeric"

        ElseIf CDbl(sRoomRate) < 0 Then

            'if room rate is less than 0, return error message
            Return "Room Rate is negative"

        End If

        'if no errors found, return null
        Return Nothing

    End Function

    Public Function bCustomerDetailsIsValid() As Boolean
        'validate customer details fields

        If bTitleIsValid() Then
            'if title validation passed, check lastname

            If bNameIsValid(frmBookingsProcessingSystem.txtLastName.Text, "Last") Then
                'if last name validation passed, check firstname

                If bNameIsValid(frmBookingsProcessingSystem.txtFirstName.Text, "First") Then
                    'if first name validation passed, check address

                    If bAddressIsValid() Then
                        'if address validation passed, check city name

                        If bNameIsValid(frmBookingsProcessingSystem.txtCity.Text, "City") Then
                            'if city name validation passed, check country

                            If bCountryIsValid() Then
                                'if country validation passed, check email

                                If bEmailIsValid() Then
                                    'if email validation passed, check telephone

                                    If bPhoneIsValid(frmBookingsProcessingSystem.txtTelephone.Text, "Tele") Then
                                        'if telephone validation passed, check mobile phone

                                        If bPhoneIsValid(frmBookingsProcessingSystem.txtMobile.Text, "Mobile ") Then

                                            'if mobile phone validation passed, indicate passed check
                                            Return True

                                        End If

                                    End If

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

        'if error occurs, indicate failed check
        Return False

    End Function

    Private Function bTitleIsValid() As Boolean
        'validate title field in customer details

        If frmBookingsProcessingSystem.cmbTitle.SelectedIndex = -1 Then

            'if no title selected, display error message
            MsgBox("Customer Details Error!" & vbCrLf & "Title not selected!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        End If

        'else, return true
        Return True

    End Function

    Private Function bNameIsValid(ByVal sName As String, ByVal sType As String) As Boolean
        'validate first/last/city name field in customer details

        If sName = "" Then

            'if name is blank, display error message
            MsgBox("Customer Details Error!" & vbCrLf & sType & " name cannot be blank!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf IsNumeric(sName) Then

            'if name field contains only numbers, display error message
            MsgBox("Customer Details Error!" & vbCrLf & sType & " name cannot be numeric!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        Else
            'else, check if name is in correct form

            'define regular expression to check input value
            Dim sNameRegEx As Regex = New Regex("^[A-Z][a-z]*( [A-Z][a-z]*)*$")

            If Not sNameRegEx.IsMatch(sName) Then

                'if name is not in correct form, display error message
                MsgBox("Customer Details Error!" & vbCrLf & "Invalid " & LCase(sType) & " name pattern! " _
                       & "Correct patterns: 'Hai Duong', 'Vinh', etc.", MsgBoxStyle.Exclamation, "Invalid input value!")

                'indicate failed check
                Return False

            End If

        End If

        'if no error found, indicate passed check
        Return True

    End Function

    Private Function bAddressIsValid() As Boolean
        'validate address field from customer details

        'store address to local variable
        Dim sAddress As String = frmBookingsProcessingSystem.txtAddress.Text

        If sAddress = "" Then

            'if address is blank, return error message
            MsgBox("Customer Details Error!" & vbCrLf & "Address cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf IsNumeric(sAddress) Then

            'if address is a number, display error message
            MsgBox("Customer Details Error!" & vbCrLf & "Address cannot be numeric!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        Else
            'else, check if address is in correct form

            'declare address regex (pattern taken from http://regexlib.com/REDetails.aspx?regexp_id=521)
            Dim sAddressRegEx As Regex = New Regex("[a-zA-Z\d]+(([\'\,\.\- #][a-zA-Z\d ])?[a-zA-Z\d]*[\.]*)*$")

            If Not sAddressRegEx.IsMatch(sAddress) Then

                'if address is not in correct form, display error message
                MsgBox("Customer Details Error!" & vbCrLf & _
                       "Invalid address pattern! Correct pattern: 71/14 Hai Ba Trung, District 1" _
                       , MsgBoxStyle.Exclamation, "Invalid input value!")

                'indicate failed check
                Return False

            End If

        End If

        'if no error found, indicate passed check
        Return True

    End Function

    Private Function bCountryIsValid() As Boolean
        'validate country field in customer details

        If frmBookingsProcessingSystem.cmbCountry.SelectedIndex = -1 Then

            'if no country selected, display error message
            MsgBox("Customer Details Error!" & vbCrLf & "Country not selected!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        End If

        'else, return true
        Return True

    End Function

    Private Function bEmailIsValid() As Boolean
        'validate email field from customer details

        'store email to local variable
        Dim sEmail As String = frmBookingsProcessingSystem.txtEmail.Text

        If sEmail = "" Then

            'if email is blank, display error message
            MsgBox("Customer Details Error!" & vbCrLf & "Email cannot be blank!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf IsNumeric(sEmail) Then

            'if email is a number, display error message
            MsgBox("Customer Details Error!" & vbCrLf & "Email cannot be numeric!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        Else
            'else, check if email is in correct form

            'declare email regex (pattern taken from http://regexlib.com/REDetails.aspx?regexp_id=269)
            Dim sEmailRegEx As Regex = New Regex("^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$")

            If Not sEmailRegEx.IsMatch(sEmail) Then

                'if email is not in correct form, display error message
                MsgBox("Customer Details Error!" & vbCrLf & "Invalid email pattern! Correct pattern: trang.nguyen@rmit.edu.vn" _
                       , MsgBoxStyle.Exclamation, "Invalid input value!")

                'indicate failed check
                Return False

            End If

        End If

        'if no error found, indicate passed check
        Return True

    End Function

    Private Function bPhoneIsValid(ByVal sPhone As String, ByVal sTelOrMobile As String) As Boolean
        'validate phone field of customer details

        If sPhone = "" Then

            'if phone is blank, display error message
            MsgBox("Customer Details Error!" & vbCrLf & sTelOrMobile & "phone number cannot be blank!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf Not IsNumeric(sPhone) Then

            'if phone is not numeric, display error message
            MsgBox("Customer Details Error!" & vbCrLf & sTelOrMobile & "phone field must contain a number!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        Else
            'else, check if phone is in correct form

            'declare regex variable to check input value
            Dim sPhoneRegEx As Regex = New Regex("^[\+]?[\d]{10,}$")

            If Not sPhoneRegEx.IsMatch(sPhone) Then

                'if phone is not in correct form, display error message
                MsgBox("Customer Details Error!" & vbCrLf & "Invalid " & LCase(sTelOrMobile) & _
                       "phone pattern! Correct pattern: +84837761300", MsgBoxStyle.Exclamation, "Invalid input value!")

                'indicate failed check
                Return False

            End If

        End If

        'if no error found, indicate passed check
        Return True

    End Function

    Public Function bRoomDetailsIsValid() As Boolean
        'validate room details fields

        If bRoomTypeIDIsValid() Then

            'if room type id is valid, indicate passed check
            Return True

        End If

        'if error occurs, indicate failed check
        Return False

    End Function

    Private Function bRoomTypeIDIsValid() As Boolean
        'validate room type id of room details

        If frmBookingsProcessingSystem.cmbRoomTypeID.SelectedIndex = -1 Then

            'if no room type id selected, display error message
            MsgBox("Room Details Error!" & vbCrLf & "Room Type ID not selected!", MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        End If

        'else, return true
        Return True

    End Function

    Public Function bSearchConditionIsValid() As Boolean
        'validate input of search form

        'validate "Search by" condition
        If frmSearch.rdbSearchByManagerName.Checked Then

            'if search by manager name option chosen, validate manager name
            If Not bNameQueryIsValid(frmSearch.txtManagerName.Text, "Manager") Then

                'if manager name is invalid, indicate failed check
                Return False

            End If

        ElseIf frmSearch.rdbSearchByCustomerLastName.Checked Then

            'else, if search by customer last name option chosen, validate customer last name
            If Not bNameQueryIsValid(frmSearch.txtCustomerLastName.Text, "Customer Last") Then

                'if customer last name is invalid, indicate failed check
                Return False

            End If

        Else

            'else, if search by room cost option chosen, validate room cost range
            If Not bCostRangeIsValid() Then

                'if room cost range is invalid, indicate failed check
                Return False

            End If

        End If

        'validate "Room Type(s)" condition
        If Not bRoomTypeSelectionIsValid() Then

            'if room type condition is invalid, indicate failed check
            Return False

        End If

        'if no errors found, indicate passed check
        Return True

    End Function

    Private Function bNameQueryIsValid(ByVal sName As String, ByVal sType As String) As Boolean
        'validate manager name or customer last name in the search form

        If sName = "" Then

            'if name is blank, display error message
            MsgBox("Search Condition Error!" & vbCrLf & sType & " name cannot be blank!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf IsNumeric(sName) Then

            'if name field contains only numbers, display error message
            MsgBox("Search Condition Error!" & vbCrLf & sType & " name cannot be numeric!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        Else
            'else, check if name is in correct form

            'define regular expression to check input value
            Dim sNameRegEx As Regex = New Regex("^[A-Za-z]+( [A-Za-z]+)*$")

            If Not sNameRegEx.IsMatch(sName) Then

                'if name is not in correct form, display error message
                MsgBox("Search Condition Error!" & vbCrLf & "Invalid " & LCase(sType) & " name pattern! " _
                       & "Correct patterns: 'Sam', 'Bill Gates', etc.", MsgBoxStyle.Exclamation, "Invalid input value!")

                'indicate failed check
                Return False

            End If

        End If

        'if no error found, indicate passed check
        Return True

    End Function

    Private Function bCostRangeIsValid() As Boolean
        'validate cost range in the search form

        'get min and max room costs, and store in local variables
        Dim sMinCost As String = frmSearch.txtMinRoomCost.Text
        Dim sMaxCost As String = frmSearch.txtMaxRoomCost.Text

        'validate start room cost
        If sMinCost = "" Then

            'if min room cost is blank, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "Min Room Cost cannot be blank!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf Not IsNumeric(sMinCost) Then

            'if min room cost is not a number, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "Min Room Cost must be numeric!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf CDbl(sMinCost) < 0 Then

            'if min room cost is less than 0, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "Min Room Cost must be positive!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        End If

        'validate max room cost
        If sMaxCost = "" Then

            'if end room cost is blank, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "Max Room Cost cannot be blank!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf Not IsNumeric(sMaxCost) Then

            'if max room cost is not a number, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "Max Room Cost must be numeric!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        ElseIf CDbl(sMaxCost) < 0 Then

            'if Max room cost is less than 0, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "Max Room Cost must be positive!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        End If

        'check if min room cost is less than or equal max room cost
        If CDbl(sMinCost) > CDbl(sMaxCost) Then

            'if min room cost larger than max room cost, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "Min Room Cost cannot be larger than Max Room Cost!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        End If

        'if no error found, indicate passed check
        Return True

    End Function

    Private Function bRoomTypeSelectionIsValid() As Boolean
        'validate room type condition in the search form

        'get check status of all room type checkboxes
        Dim bSUChecked As Boolean = frmSearch.cbxTypeSuperior.Checked
        Dim bDEChecked As Boolean = frmSearch.cbxTypeDeluxe.Checked
        Dim bPDChecked As Boolean = frmSearch.cbxTypePremiumDeluxe.Checked
        Dim bJSChecked As Boolean = frmSearch.cbxTypeJuniorSuite.Checked
        Dim bPSChecked As Boolean = frmSearch.cbxTypePresidentialSuite.Checked

        'check if any checkbox checked
        If Not (bSUChecked Or bDEChecked Or bPDChecked Or bJSChecked Or bPSChecked) Then

            'if no checkbox checked, display error message
            MsgBox("Search Condition Error!" & vbCrLf & "At least one Room Type must be selected!" _
                   , MsgBoxStyle.Exclamation, "Invalid input value!")

            'indicate failed check
            Return False

        End If

        'if no error found, indicate passed check
        Return True

    End Function

End Module
