Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Newtonsoft.Json

Namespace Controllers
    <EnableCors("http://localhost:26334", "*", "*")>
    Public Class NLBAPIController
        Inherits ApiController

        ' GET: api/NLBAPI
        Public Function GetValues() As String
            Dim list As New List(Of Student)
            Dim hobbies1 As New List(Of String)
            Dim student1 As Student = New Student
            student1.age = 20
            student1.name = "Alice"
            hobbies1.Add("reading")
            hobbies1.Add("swimming")
            hobbies1.Add("coding")
            student1.hobbies = String.Join(",", hobbies1.ToArray())
            Dim hobbies2 As New List(Of String)
            Dim student2 As Student = New Student
            student2.age = 22
            student2.name = "Bob"
            hobbies2.Add("painting")
            hobbies2.Add("dancing")
            hobbies2.Add("singing")
            student2.hobbies = String.Join(",", hobbies2.ToArray())
            list.Add(student1)
            list.Add(student2)
            Return JsonConvert.SerializeObject(list)
        End Function

    End Class
End Namespace

Public Class Student
    Public Property name As String
    Public Property age As Integer
    Public Property hobbies As String
End Class

Public Class NLBResponse
    Public Property students As List(Of Student)
End Class