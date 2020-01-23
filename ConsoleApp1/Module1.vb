Imports System
Imports System.IO
Imports SmartyStreets
Imports SmartyStreets.USStreetApi
Module Module1
    Dim authID = "d8d84491-113f-e4f9-ef23-61b8aae0d7be"  ' Environment.GetEnvironmentVariable("SMARTY_AUTH_ID")
    Dim authToken = "qJ1BI52IeW2QsjVhdAbs"  '  Environment.GetEnvironmentVariable("SMARTY_AUTH_TOKEN")

    'Dim xclient As ClientBuilder

    Dim client = New ClientBuilder(authID, authToken).BuildUsStreetApiClient() ' Build()
    Sub Main()
        Test_SingleAddress()
    End Sub
    Sub Test_SingleAddress()

        Dim myLookup As New Lookup()
        With myLookup
            .Street = "11155 Roseland Road"
            .City = "Sebastian"
            .State = "FL"
            .ZipCode = "32958-8153"
        End With

        Try
            client.Send(myLookup)
        Catch ex As SmartyException
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
        Catch ex As IOException
            Console.WriteLine(ex.StackTrace)
        End Try

        Dim candidates = myLookup.Result

        If candidates.Count = 0 Then
            Console.WriteLine("No candidates. This means the address is not valid.")
            Return
        End If

        Dim firstCandidate = candidates(0)

        Console.WriteLine("Address is valid. (There is at least one candidate)" & vbLf)
        Console.WriteLine("Primary Number: " + firstCandidate.Components.PrimaryNumber)
        Console.WriteLine("Street: " + firstCandidate.Components.StreetName)
        Console.WriteLine("CityName: " + firstCandidate.Components.CityName)
        Console.WriteLine("State: " + firstCandidate.Components.State)
        Console.WriteLine("ZIP Code: " + firstCandidate.Components.ZipCode)
        Console.WriteLine("County: " + firstCandidate.Metadata.CountyName)
        Console.WriteLine("RDI: " + firstCandidate.Metadata.Rdi)
        Console.WriteLine("Latitude: " + firstCandidate.Metadata.Latitude.ToString)
        Console.WriteLine("Longitude: " + firstCandidate.Metadata.Longitude.ToString)

    End Sub
End Module
