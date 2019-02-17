Imports System.Net
Imports Google.Apis.Safebrowsing.v4
Imports Google.Apis.Services

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
            DConsole.WriteLine(ReadException(ex))
            web_response.Close()
            Return False
        Finally
            If Not (web_response Is Nothing) Then _
                web_response.Close()
        End Try
    End Function
    Public Function HttpsExists(ByVal url As String) As Boolean
        Dim is_valid As Boolean = False
        Dim url1 As String = ""
        If url.ToLower().StartsWith("www.") Then url1 =
            "https://" & url
        If url.ToLower().StartsWith("http://") Then url1 =
            "https://" & url.Remove(0, 7)
        If url.ToLower().StartsWith("https://") Then url1 = url
        If url.ToLower().StartsWith("www.") = False And url.ToLower().StartsWith("http://") = False And url.ToLower().StartsWith("https://") = False Then
            url1 = "https://" & url
        End If
        Dim web_response As HttpWebResponse = Nothing
        Try
            Dim web_request As HttpWebRequest =
                WebRequest.Create(url1)
            web_response =
                DirectCast(web_request.GetResponse(),
                HttpWebResponse)
            Return True
        Catch ex As Exception
            DConsole.WriteLine(ReadException(ex))
            Return False
            If Not (web_response Is Nothing) Then _
                web_response.Close()
        End Try
    End Function
    Public Function IsUrlSafe() As String
        Dim service = New SafebrowsingService(New BaseClientService.Initializer)
        'service.
        Return "DISABLED"
    End Function
    Public Function ReadException(ByVal ex As Exception) As String
        Dim msg As String = ex.Message
        If ex.InnerException IsNot Nothing Then
            msg = msg & vbCrLf & "---------" & vbCrLf & ReadException(ex.InnerException)
        End If
        Return msg
    End Function
End Module
