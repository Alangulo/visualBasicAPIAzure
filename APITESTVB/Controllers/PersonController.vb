Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Namespace Controllers
    Public Class PersonController
        Inherits ApiController

        ' GET: api/Person
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"Get", "Test Data"}
        End Function

        ' GET: api/Person/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "Another Get, this is the value returned"
        End Function

        'this one is neede to route
        Public Function PostCustomer(<FromBody()> ByVal value As PersonalInfo) As HttpResponseMessage
            If ModelState.IsValid Then

                'here you should do whatever you want with the informations coming form the request
                Dim firstName = value.FirstName

                Return New HttpResponseMessage(HttpStatusCode.OK)
            Else
                Return New HttpResponseMessage(HttpStatusCode.BadRequest)
            End If

        End Function


        ' POST: api/Person
        Public Sub PostValue(<FromBody()> ByVal model As PersonalInfo)

            'dummy test here, whre model is an object from a class that is goig to modelate our data, this case PersonaInfo
            Dim firstName = model.FirstName
            Dim lastName = model.LastName



        End Sub

        ' PUT: api/Person/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Person/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace