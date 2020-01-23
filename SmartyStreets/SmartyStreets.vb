Imports System.Text
Imports System
Imports System.IO
Imports SmartyStreets
Imports SmartyStreets.USStreetApi
Imports System.Windows.Forms

<ComClass(SmartyStreets.ClassId, SmartyStreets.InterfaceId, SmartyStreets.EventsId)>
Public Class SmartyStreets

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "0ee8865a-63ba-47bf-8dac-deab45b78ee9"
    Public Const InterfaceId As String = "0fa5f11f-6f12-4bb9-9b7e-3c0674c21a1e"
    Public Const EventsId As String = "028ef8bf-f890-4284-aaf1-066f9b96ef9f"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
        _rdi = ""
        _state = ""
        _address1 = ""
        _city = ""
        _last4 = ""
        _address1 = ""
        _last_line = ""
    End Sub
    Dim authID = "d8d84491-113f-e4f9-ef23-61b8aae0d7be"  ' Environment.GetEnvironmentVariable("SMARTY_AUTH_ID")
    Dim authToken = "qJ1BI52IeW2QsjVhdAbs"  '  Environment.GetEnvironmentVariable("SMARTY_AUTH_TOKEN")
    Dim client = New ClientBuilder(authID, authToken).BuildUsStreetApiClient() ' Build()
    Dim sb = New StringBuilder()
    Private _address1, _address2, _city, _state, _zip, _rdi, _last4, _zip_plus4, _last_line, _latitude, _longitude As String
    Public Overridable Property Latitude As String
        Get
            Return _latitude
        End Get

        Set(ByVal value As String)
            _latitude = value
        End Set
    End Property
    Public Overridable Property Longitude As String
        Get
            Return _longitude
        End Get

        Set(ByVal value As String)
            _longitude = value
        End Set
    End Property
    Public Overridable Property RDI As String
        Get
            Return _rdi
        End Get

        Set(ByVal value As String)
            _rdi = value
        End Set
    End Property
    Public Overridable Property Delivery_Address1 As String
        Get
            Return _address1
        End Get

        Set(ByVal value As String)
            _address1 = value
        End Set
    End Property
    Public Overridable Property Delivery_Address2 As String
        Get
            Return _address2
        End Get

        Set(ByVal value As String)
            _address2 = value
        End Set
    End Property
    Public Overridable Property Last_Line As String
        Get
            Return _last_line
        End Get

        Set(ByVal value As String)
            _last_line = value
        End Set
    End Property

    Public Overridable Property City As String
        Get
            Return _city
        End Get

        Set(ByVal value As String)
            _city = value
        End Set
    End Property
    Public Overridable Property State As String
        Get
            Return _state
        End Get

        Set(ByVal value As String)
            _state = value
        End Set
    End Property
    Public Overridable Property Zip As String
        Get
            Return _zip
        End Get

        Set(ByVal value As String)
            _zip = value
        End Set
    End Property
    Public Overridable Property Last4 As String
        Get
            Return _last4
        End Get

        Set(ByVal value As String)
            _last4 = value
        End Set
    End Property
    Public Overridable Property ZipPlus4 As String
        Get
            Return _zip_plus4
        End Get

        Set(ByVal value As String)
            _zip_plus4 = value
        End Set
    End Property

    Dim trsMsg As New StringBuilder()

    Public Function CheckAddress(ByVal myStreet_address As String, ByVal myCity As String, ByVal myState As String, ByVal myZip As String) As Boolean
        Dim myLookup As New Lookup()
        With myLookup
            If myStreet_address <> "" Then
                .Street = myStreet_address   ' "11155 Roseland Road"
            End If
            If myCity <> "" Then
                .City = myCity  '  "Sebastian"
            End If
            If myState <> "" Then
                .State = myState  '  "FL"
            End If
            If myZip <> "" Then
                .ZipCode = myZip   '   "32958-8153"
            End If
            trsMsg.Append("Street = " + myStreet_address + vbCrLf)
            trsMsg.Append("City = " + myCity + vbCrLf)
            trsMsg.Append("State = " + myState + vbCrLf)
            trsMsg.Append("Zip = " + myZip + vbCrLf)
            'MessageBox.Show(trsMsg.ToString())
        End With

        Try
            client.Send(myLookup)
        Catch ex As SmartyException
            sb.append("SmartyException ERROR..." + vbCrLf + vbCrLf)
            sb.append(ex.Message + vbCrLf)  '  Console.WriteLine(ex.Message)
            sb.append(ex.StackTrace + vbCrLf)   '  Console.WriteLine(ex.StackTrace)
            MessageBox.Show(sb.ToString())
            sb.Replace(vbCrLf, "\")
            ReturnMessage = sb.ToString()
            Return False
        Catch ex As IOException
            sb.append("IOException ERROR..." + vbCrLf + vbCrLf)
            sb.append(ex.Message + vbCrLf)  '  Console.WriteLine(ex.Message)
            sb.append(ex.StackTrace + vbCrLf)   '  Console.WriteLine(ex.StackTrace)

            MessageBox.Show(sb.ToString())
            sb.Replace(vbCrLf, "\")
            ReturnMessage = sb.ToString()
            Return False
        Catch ex As Exception
            sb.append("Exception ERROR..." + vbCrLf + vbCrLf)
            'sb.append(ex.ToString() + vbCrLf)
            sb.append(ex.Message + vbCrLf)  '  Console.WriteLine(ex.Message)
            sb.append(ex.StackTrace + vbCrLf)   '  Console.WriteLine(ex.StackTrace)

            MessageBox.Show(sb.ToString())
            sb.Replace(vbCrLf, "\")
            ReturnMessage = sb.ToString()
            Throw
            'Return False
        End Try
        ' MessageBox.Show("here!")
        Dim candidates = myLookup.Result
        'myLookup.Result(0).DeliveryLine1
        'myLookup.Result(0).DeliveryLine2
        'myLookup.Result(0).LastLine
        If candidates.Count = 0 Then
            sb.append("ERROR..." + vbCrLf + vbCrLf)
            sb.append("No candidates. This means the address is not valid.")  '  Console.WriteLine(ex.Message)
            ' Console.WriteLine("No candidates. This means the address is not valid.")
            'MessageBox.Show("No candidates. This means the address is not valid.")
            sb.Replace(vbCrLf, "\")
            ReturnMessage = sb.ToString()
            Return False
        End If

        Dim firstCandidate = candidates(0)
        'Dim x As String = vbCrLf
        sb.append("Address is valid. (There is at least one candidate [" & candidates.Count.ToString() & "])" & vbCrLf)
        sb.append("Delivery Line1: " + firstCandidate.DeliveryLine1 & vbCrLf)
        Delivery_Address1 = firstCandidate.DeliveryLine1
        Delivery_Address2 = firstCandidate.DeliveryLine2
        sb.append("Delivery Line2: " + firstCandidate.DeliveryLine2 & vbCrLf)
        sb.append("Last Line: " + firstCandidate.LastLine & vbCrLf & vbCrLf)
        Last_Line = firstCandidate.LastLine
        'sb.append("Primary Number: " + "" & vbCrLf)
        sb.append("Primary Number: " + firstCandidate.Components.PrimaryNumber & vbCrLf)
        sb.append("Street: " + firstCandidate.Components.StreetName & vbCrLf)
        sb.append("Street Post Direction: " + firstCandidate.Components.StreetPostdirection & vbCrLf)
        sb.append("Street Pre Direction: " + firstCandidate.Components.StreetPredirection & vbCrLf)
        sb.append("Primary number: " + firstCandidate.Components.PrimaryNumber & vbCrLf)
        'Street_Address = firstCandidate.Components.PrimaryNumber

        sb.append("CityName: " + firstCandidate.Components.CityName & vbCrLf)
        City = firstCandidate.Components.CityName
        sb.append("State: " + firstCandidate.Components.State & vbCrLf)
        State = firstCandidate.Components.State
        sb.append("ZIP Code: " + firstCandidate.Components.ZipCode & vbCrLf)
        Zip = firstCandidate.Components.ZipCode
        sb.append("ZIP Last 4: " + firstCandidate.Components.Plus4Code & vbCrLf)
        sb.append("ZIP + 4: " + firstCandidate.Components.ZipCode & "-" & firstCandidate.Components.Plus4Code & vbCrLf)
        ZipPlus4 = firstCandidate.Components.ZipCode & "-" & firstCandidate.Components.Plus4Code
        sb.append("County: " + firstCandidate.Metadata.CountyName & vbCrLf)
        sb.append("RDI: " + firstCandidate.Metadata.Rdi & vbCrLf)
        RDI = firstCandidate.Metadata.Rdi
        sb.append("Latitude: " + firstCandidate.Metadata.Latitude.ToString & vbCrLf)
        Longitude = firstCandidate.Metadata.Longitude
        Latitude = firstCandidate.Metadata.Latitude
        sb.append("Longitude: " + firstCandidate.Metadata.Longitude.ToString & vbCrLf)
        'MessageBox.Show(sb.ToString())
        sb.Replace(vbCrLf, "\")
        ReturnMessage = sb.ToString()
        Return True
    End Function
    Private _returnMessage As String
    Public Overridable Property ReturnMessage As String
        Get
            Return _returnMessage
        End Get

        Set(ByVal value As String)
            _returnMessage = value
        End Set
    End Property
End Class


