Imports System.Xml
Imports Newtonsoft.Json

Module Functions
    Public front_id As String = "renaissance_bg"
    Public event_id As String = "renaissance"
    Public api_id As String
    Public api_lang As String
    Public status As String
    Public count As String

    Public Function Json2XML(ByVal json As String) As XmlDocument
        Return JsonConvert.DeserializeXmlNode(json, "Root")
    End Function
    Public Sub ErrorLog(ByVal sender As String, errorMsg As String)

    End Sub
End Module
