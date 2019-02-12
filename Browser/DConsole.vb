Imports System.Net

Public Class DConsole
    Private Input As String
    Private Sub DCInput_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles DCInput.PreviewKeyDown
        'Fancy code goes here...
        If e.KeyCode = Keys.Enter Then
            DCOutput.AppendText("DEBUG: enter key pressed on console input" + vbNewLine)
            Call Command_Handler(sender, e)
        End If
    End Sub
    Public Sub Command_Handler(sender As Object, e As EventArgs)
        Input = DCInput.Text.ToLower()
        If Input = "/help" Then
            DCOutput.AppendText("DCI: " + Input + vbNewLine +
                                "/help - Shows this info" + vbNewLine +
                                "/copy - sends the logs to the clipboard" + vbNewLine +
                                "/go [url/ip] - Navigates to [url/ip]" + vbNewLine +
                                "/settings - Changes settings(if blank it will show available options)" + vbNewLine +
                                "END HELP" + vbNewLine)
        End If
        If Input = "/copy" Then
            My.Computer.Clipboard.SetText(DCOutput.Text)
            DCOutput.AppendText("DCI: " + Input + vbNewLine +
                                "Logs copied to clipboard!" + vbNewLine +
                                "END COPY" + vbNewLine)
        End If
        If Input.StartsWith("/go ") Then
            Dim Input1 As String
            DCOutput.AppendText("UCI: " + Input + vbNewLine)
            Input1 = Input.Remove(0, 4)
            DCOutput.AppendText("Input was modified for optimal use: " + Input1.ToString + vbNewLine)
            Main.WebBrowser1.Navigate(Input1)
            DCOutput.AppendText("Navigated to the url in the input" + vbNewLine)
            DCOutput.AppendText("END GO" + vbNewLine)
        End If
        If Input.StartsWith("/settings") Then
            If Input = "/settings" Then
                DCOutput.AppendText("DCI: " + Input + vbNewLine +
                                    "ERROR: No arguments detected" + vbNewLine +
                                    "Usage - /settings [arguments]" + vbNewLine +
                                    "Arguments:" + vbNewLine +
                                    "homeurl [url/ip] - sets home setting to [url/ip]" + vbNewLine +
                                    "searchurl [url/ip] - sets search setting to [url/ip]" + vbNewLine +
                                    "END SETTINGS")
            End If
            If Input.StartsWith("/settings homeurl ") Then
                Dim input1 As String
                DCOutput.AppendText("DCI: " + Input + vbNewLine +
                                    "homeurl argument detected!")
                input1 = Input.Remove(0, 18)
                Dim ip As IPAddress = Nothing
                Dim homeip As Boolean = IPAddress.TryParse(input1, ip)
                If UrlIsValid(input1) = True Or homeip = True Then
                    My.Settings.home = input1
                    DCOutput.AppendText("Home Settings Changed to: " + input1 + vbNewLine +
                                        "END SETTINGS" + vbNewLine)
                Else
                    DCOutput.AppendText("INVALID URL/IP" + vbNewLine +
                                        "END SETTINGS" + vbNewLine)
                End If
            End If
        End If
        DCOutput.AppendText(Input + " - Command Not Found")
            DCInput.Text = ""
    End Sub
End Class