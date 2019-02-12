Imports System.Net

Module Functions
    'This Function validates a URL
    Public Function UrlIsValid(ByVal url As String) As Boolean
        Dim is_valid As Boolean = False
        If url.ToLower().StartsWith("www.") Then url =
            "http://" & url

        Dim web_response As HttpWebResponse = Nothing
        Try
            Dim web_request As HttpWebRequest =
                HttpWebRequest.Create(url)
            web_response =
                DirectCast(web_request.GetResponse(),
                HttpWebResponse)
            Return True
        Catch ex As Exception
            Return False
        Finally
            If Not (web_response Is Nothing) Then _
                web_response.Close()
        End Try
    End Function
End Module
