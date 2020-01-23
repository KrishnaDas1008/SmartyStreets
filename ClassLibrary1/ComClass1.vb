<ComClass(ComClass1.ClassId, ComClass1.InterfaceId, ComClass1.EventsId)> _
Public Class ComClass1

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "97a1f0c1-cb45-484e-9e3e-394b39f4e26b"
    Public Const InterfaceId As String = "c14bd77d-ea64-48c0-8e1f-e4d6475c70dd"
    Public Const EventsId As String = "1d01f717-a4b3-4415-aa4b-cc584727f7e9"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

End Class


