Public Class Main
    Public Safety1 As String
    Public Safety2 As String
    ' On a fresh start the browser will load with default configs which can be altered on settings and loaded on a second start
    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.home = "" And My.Settings.search = "" Then
            My.Settings.home = "http:\\www.google.com"
            My.Settings.search = "http:\\www.google.com"
            DConsole.DCOutput.AppendText("Fresh start! Setting Home and Search buttons to default..." + vbNewLine)
        End If
        'Browser starts with no Back and Forward buttons for no real reason other than common sense
        DConsole.DCOutput.AppendText("Starting..." + vbNewLine)
        Safety2 = ""
        backbtn.Enabled = False
        DConsole.DCOutput.AppendText("DEBUG: Back Button Disabled" + vbNewLine)
        forwardbtn.Enabled = False
        DConsole.DCOutput.AppendText("DEBUG: Forward Button Disabled" + vbNewLine)
        'Browser navigates to the url/ip set as home
        DConsole.DCOutput.AppendText("INFO: Navigating to: " + My.Settings.home + " (Home) " + vbNewLine)
        WebBrowser1.Navigate(My.Settings.home)
    End Sub
    'Go Button
    Private Sub Gobtn_Click(sender As Object, e As EventArgs) Handles gobtn.Click
        If urltb.Text = "about:notajoke" Then
            'This is a dangerous place...
            While True
                DConsole.DCOutput.AppendText("SEVERE: You shouldn't have done this" + vbNewLine)
                Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location)
            End While
        End If
        If urltb.Text = "about:me" Then
            'Browser engine version
            DConsole.DCOutput.AppendText("Info: IE Engine version is:" + WebBrowser1.Version.ToString() + vbNewLine)
            MessageBox.Show(WebBrowser1.Version.ToString(), "IE Engine Version",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        DConsole.DCOutput.AppendText("INFO: Navigating to: " + urltb.Text + vbNewLine)
        WebBrowser1.Navigate(urltb.Text)
    End Sub
    'Back Button
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        WebBrowser1.GoBack()
        DConsole.DCOutput.AppendText("INFO: Back Button" + vbNewLine)
        DConsole.DCOutput.AppendText("INFO: Navigating to: " + urltb.Text + vbNewLine)
    End Sub
    'Forward Button
    Private Sub Forwardbtn_Click(sender As Object, e As EventArgs) Handles forwardbtn.Click
        WebBrowser1.GoForward()
        DConsole.DCOutput.AppendText("INFO: Forward Button" + vbNewLine)
        DConsole.DCOutput.AppendText("INFO: Navigating to: " + urltb.Text + vbNewLine)
    End Sub
    'Refresh Button
    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        WebBrowser1.Refresh(5)
        DConsole.DCOutput.AppendText("INFO: Refresh" + vbNewLine)
    End Sub
    'Home button
    Private Sub Homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        'WebBrowser1.GoHome was replaced with a separate and easier to configure alternative due to my will to do so
        WebBrowser1.Navigate(My.Settings.home)
        DConsole.DCOutput.AppendText("INFO: Navigating to home [" + My.Settings.home + "]" + vbNewLine)
    End Sub
    'Search Button
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        'WebBrowser1.GoSearch() was replaced with a separate and easier to configure alternative due to the same reason I changed the Homebtn
        WebBrowser1.Navigate(My.Settings.search)
        DConsole.DCOutput.AppendText("INFO: Navigating to search [" + My.Settings.search + "]" + vbNewLine)
    End Sub
    'Stop Button
    Private Sub Stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        WebBrowser1.Stop()
        DConsole.DCOutput.AppendText("ERROR: Stopped (by a user)" + vbNewLine)
    End Sub
    'Settings Button
    Private Sub Settingsbtn_Click(sender As Object, e As EventArgs) Handles settingsbtn.Click
        Settings.Show()
        DConsole.DCOutput.AppendText("INFO: Settings opened!" + vbNewLine)
    End Sub
    'Print Button
    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        WebBrowser1.ShowPrintPreviewDialog()
        DConsole.DCOutput.AppendText("INFO: Print (Preview) Dialog opened!" + vbNewLine)
    End Sub
    'Properties Button
    Private Sub Property_Click(sender As Object, e As EventArgs) Handles safety.Click
        WebBrowser1.ShowPropertiesDialog()
        DConsole.DCOutput.AppendText("INFO: Page Properties Dialog opened!" + vbNewLine)
    End Sub
    'Save As... Button
    Private Sub Saveasbtn_Click(sender As Object, e As EventArgs) Handles saveasbtn.Click
        WebBrowser1.ShowSaveAsDialog()
        DConsole.DCOutput.AppendText("INFO: Save As Dialog Opened!" + vbNewLine)
    End Sub
    'When a page finishes loading...
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'The WebBrowser1 is too dumb to resize itself... 
        'so gotta write a line to make it autoresize(also had to put it inside a container)
        WebBrowser1.Size = WebBrowser1.Document.Body.ScrollRectangle.Size
        urltb.Text = WebBrowser1.Url.ToString 'yes it is needed a way to see the exact url where the user is... to prevent bad redirections and stuff
        DConsole.DCOutput.AppendText("INFO: Navigated to: " + WebBrowser1.Url.ToString() + vbNewLine)
    End Sub
    'When a page changes title
    Private Sub WebBrowser1_DocumentTitleChanged(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentTitleChanged

        Text = "Browser - [" + WebBrowser1.DocumentTitle + "]" 'sounds fun and I could do it... why not then
        DConsole.DCOutput.AppendText("INFO: New Page Title: " + WebBrowser1.DocumentTitle + vbNewLine)
        'TODO: Give a fuckin name to the browser
    End Sub

    'This code allows the Go Button to be "clicked" with Enter key when URL TextBox is on focus
    Private Sub UrlTB_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles urltb.PreviewKeyDown
        'Fancy code goes here...
        If e.KeyCode = Keys.Enter Then
            Call Gobtn_Click(sender, e)
            DConsole.DCOutput.AppendText("DEBUG: Enter key pressed while focusing on urltb!" + vbNewLine)
        End If
    End Sub
    'Keeps the Properties Button Label fresh with Encryption Level data
    Private Sub WebBrowser1_EncryptionLevelChanged(sender As Object, e As EventArgs) Handles WebBrowser1.EncryptionLevelChanged
        Safety1 = WebBrowser1.EncryptionLevel.ToString()
        If Safety1 = Safety2 Then
            Return
        Else
            Safety1 = Safety2
            safety.Text = WebBrowser1.EncryptionLevel.ToString()
            'TODO: Replace the safety related text with a lock picture... so it looks less smart...yeaahh I still need to think about it
            DConsole.DCOutput.AppendText("WARNING: Encryption Level changed: " + WebBrowser1.EncryptionLevel.ToString() + vbNewLine)
        End If

    End Sub
    'Enables the Back Button when it is useful
    Private Sub WebBrowser1_CanGoBackChanged(sender As Object, e As EventArgs) Handles WebBrowser1.CanGoBackChanged

        backbtn.Enabled = WebBrowser1.CanGoBack
        DConsole.DCOutput.AppendText("DEBUG: Back Button Enabled" + vbNewLine)
    End Sub
    'Enables the Forward Button when it is useful
    Private Sub WebBrowser1_CanGoForwardChanged(sender As Object, e As EventArgs) Handles WebBrowser1.CanGoForwardChanged

        forwardbtn.Enabled = WebBrowser1.CanGoForward
        DConsole.DCOutput.AppendText("DEBUG: Forward Button Enabled" + vbNewLine)
    End Sub
    'Monitors the page loading and reports errors (of itself)
    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        'Some more fancy code...
        'Error reports disabled since they were very annoying and mainly useless
        Try
            ProgressBar1.Maximum = e.MaximumProgress
            ProgressBar1.Value = e.CurrentProgress

            If ProgressBar1.Value = ProgressBar1.Maximum Then


                ProgressBar1.Value = ProgressBar1.Maximum

            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
