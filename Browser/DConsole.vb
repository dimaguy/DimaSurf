Imports System.Net

Public Class DConsole
    Private Input As String
    Private Sub DCInput_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles DCInput.PreviewKeyDown
        'Fancy code goes here...
        If e.KeyCode = Keys.Enter Then
            WriteLine("DEBUG: enter key pressed on console input" + vbNewLine)
            Call Command_Handler(sender, e)
        End If
    End Sub
    Public Sub WriteLine(ByVal text As String)
        Dim DCWL As String = ""
        DCWL = DateAndTime.TimeString + " - " + text.ToString() + vbNewLine
        DCOutput.AppendText(DCWL)
    End Sub
    Public Sub Command_Handler(sender As Object, e As EventArgs)
        Input = DCInput.Text.ToLower()

        If Input = "/help" Then
            WriteLine("DCI: " + Input + vbNewLine +
                       "/help - Shows this info" + vbNewLine +
                       "/copy - sends the logs to the clipboard" + vbNewLine +
                       "/go [url/ip] - Navigates to [url/ip]" + vbNewLine +
                       "/settings - Changes settings(if blank it will show available options)" + vbNewLine +
                       "END HELP")
            Return
        End If

        If Input = "/copy" Then
            My.Computer.Clipboard.SetText(DCOutput.Text)
            WriteLine("DCI: " + Input + vbNewLine +
                      "Logs copied to clipboard!" + vbNewLine +
                      "END COPY")
            Return
        End If

        If Input.StartsWith("/go ") Then
            Dim Input1 As String
            WriteLine("UCI: " + Input)
            Input1 = Input.Remove(0, 4)
            WriteLine("Input was modified for optimal use: " + Input1.ToString + vbNewLine)
            Main.WebBrowser1.Navigate(Input1)
            WriteLine("Navigated to the url in the input" + vbNewLine)
            WriteLine("END GO")
            Return
        End If

        If Input.StartsWith("/settings") Then
            If Input = "/settings" Then
                WriteLine("DCI: " + Input + vbNewLine +
                          "ERROR: No arguments detected" + vbNewLine +
                          "Usage - /settings [arguments]" + vbNewLine +
                          "Arguments:" + vbNewLine +
                          "homeurl [url/ip] - sets home setting to [url/ip]" + vbNewLine +
                          "searchurl [url/ip] - sets search setting to [url/ip]" + vbNewLine +
                          "END SETTINGS")
            End If

            If Input.StartsWith("/settings homeurl ") Then
                Dim input1 As String
                WriteLine("DCI: " + Input + vbNewLine +
                                    "homeurl argument detected!")
                input1 = Input.Remove(0, 18)
                Dim ip1 As IPAddress = Nothing
                Dim homeip As Boolean = IPAddress.TryParse(input1, ip1)
                If UrlIsValid(input1) = True Or homeip = True Then
                    My.Settings.home = input1
                    DCOutput.AppendText("Home Settings Changed to: " + input1 + vbNewLine +
                                        "END SETTINGS" + vbNewLine)
                Else
                    DCOutput.AppendText("INVALID URL/IP" + vbNewLine +
                                        "END SETTINGS" + vbNewLine)
                End If

                If Input.StartsWith("/settings searchurl ") Then
                    WriteLine("DCI: " + Input + vbNewLine +
                                        "searchurl argument detected!")
                    input1 = Input.Remove(0, 20)
                    Dim ip2 As IPAddress = Nothing
                    Dim searchip As Boolean = IPAddress.TryParse(input1, ip2)
                    If UrlIsValid(input1) = True Or homeip = True Then
                        My.Settings.home = input1
                        DCOutput.AppendText("Search Settings Changed to: " + input1 + vbNewLine +
                                            "END SETTINGS" + vbNewLine)
                    Else
                        DCOutput.AppendText("INVALID URL/IP" + vbNewLine +
                                            "END SETTINGS" + vbNewLine)
                    End If
                End If
                Return
            End If
        End If
        WriteLine(Input + " - Command Not Found")
        DCInput.Text = ""
    End Sub
End Class