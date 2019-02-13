﻿Public Class Main
    Public Safety1 As String
    Public Safety2 As String
    ' On a fresh start the browser will load with default configs which can be altered on settings and loaded on a second start
    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.home = "" And My.Settings.search = "" Then
            My.Settings.home = "http://www.google.com"
            My.Settings.search = "http://www.google.com"
            DConsole.WriteLine("Fresh start! Setting Home and Search buttons to default..." + vbNewLine)
        End If
        'Browser starts with no Back and Forward buttons for no real reason other than common sense
        DConsole.WriteLine("Starting..." + vbNewLine)
        Safety2 = ""
        backbtn.Enabled = False
        DConsole.WriteLine("DEBUG: Back Button Disabled" + vbNewLine)
        forwardbtn.Enabled = False
        DConsole.WriteLine("DEBUG: Forward Button Disabled" + vbNewLine)
        'Browser navigates to the url/ip set as home
        DConsole.WriteLine("INFO: Navigating to: " + My.Settings.home + " (Home) " + vbNewLine)
        WebBrowser1.Navigate(My.Settings.home)
    End Sub
    'Go Button
    Private Sub Gobtn_Click(sender As Object, e As EventArgs) Handles gobtn.Click
        If urltb.Text = "about:notajoke" Then
            'This is a dangerous place...
            While True
                DConsole.WriteLine("SEVERE: You shouldn't have done this" + vbNewLine)
                Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location)
            End While
        End If
        If urltb.Text = "about:me" Then
            'Browser engine version
            DConsole.WriteLine("Info: IE Engine version is:" + WebBrowser1.Version.ToString() + vbNewLine)
            MessageBox.Show(WebBrowser1.Version.ToString(), "IE Engine Version",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        Dim url1 = ""
        DConsole.WriteLine("INFO: Navigating to: " + urltb.Text + vbNewLine)
        If HttpsExists(urltb.Text) = True Then
            If urltb.Text.StartsWith("https://") Then
                WebBrowser1.Navigate(urltb.Text)
            Else
                url1 = urltb.Text.Remove(0, 7)
                WebBrowser1.Navigate("https://" + urltb.Text)
            End If
        Else
            WebBrowser1.Navigate(urltb.Text)
        End If

    End Sub
    'Back Button
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        WebBrowser1.GoBack()
        DConsole.WriteLine("INFO: Back Button" + vbNewLine)
        DConsole.WriteLine("INFO: Navigating to: " + urltb.Text + vbNewLine)
    End Sub
    'Forward Button
    Private Sub Forwardbtn_Click(sender As Object, e As EventArgs) Handles forwardbtn.Click
        WebBrowser1.GoForward()
        DConsole.WriteLine("INFO: Forward Button" + vbNewLine)
        DConsole.WriteLine("INFO: Navigating to: " + urltb.Text + vbNewLine)
    End Sub
    'Refresh Button
    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        WebBrowser1.Refresh(5)
        DConsole.WriteLine("INFO: Refresh" + vbNewLine)
    End Sub
    'Home button
    Private Sub Homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        'WebBrowser1.GoHome was replaced with a separate and easier to configure alternative due to my will to do so
        WebBrowser1.Navigate(My.Settings.home)
        DConsole.WriteLine("INFO: Navigating to home [" + My.Settings.home + "]" + vbNewLine)
    End Sub
    'Search Button
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        'WebBrowser1.GoSearch() was replaced with a separate and easier to configure alternative due to the same reason I changed the Homebtn
        WebBrowser1.Navigate(My.Settings.search)
        DConsole.WriteLine("INFO: Navigating to search [" + My.Settings.search + "]" + vbNewLine)
    End Sub
    'Stop Button
    Private Sub Stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        WebBrowser1.Stop()
        DConsole.WriteLine("ERROR: Stopped (by a user)" + vbNewLine)
    End Sub
    'Settings Button
    Private Sub Settingsbtn_Click(sender As Object, e As EventArgs) Handles settingsbtn.Click
        Settings.Show()
        DConsole.WriteLine("INFO: Settings opened!" + vbNewLine)
    End Sub
    'Print Button
    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        WebBrowser1.ShowPrintPreviewDialog()
        DConsole.WriteLine("INFO: Print (Preview) Dialog opened!" + vbNewLine)
    End Sub
    'Properties Button
    Private Sub Property_Click(sender As Object, e As EventArgs) Handles safety.Click
        WebBrowser1.ShowPropertiesDialog()
        DConsole.WriteLine("INFO: Page Properties Dialog opened!" + vbNewLine)
    End Sub
    'Save As... Button
    Private Sub Saveasbtn_Click(sender As Object, e As EventArgs) Handles saveasbtn.Click
        WebBrowser1.ShowSaveAsDialog()
        DConsole.WriteLine("INFO: Save As Dialog Opened!" + vbNewLine)
    End Sub
    'When a page finishes loading...
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'The WebBrowser1 is too dumb to resize itself... 
        'so gotta write a line to make it autoresize(also had to put it inside a container)
        WebBrowser1.Size = WebBrowser1.Document.Body.ScrollRectangle.Size
        urltb.Text = WebBrowser1.Url.ToString 'yes it is needed a way to see the exact url where the user is... to prevent bad redirections and stuff
        DConsole.WriteLine("INFO: Navigated to: " + WebBrowser1.Url.ToString() + vbNewLine)
    End Sub
    'When a page changes title
    Private Sub WebBrowser1_DocumentTitleChanged(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentTitleChanged

        Text = "Browser - [" + WebBrowser1.DocumentTitle + "]" 'sounds fun and I could do it... why not then
        DConsole.WriteLine("INFO: New Page Title: " + WebBrowser1.DocumentTitle + vbNewLine)
        'TODO: Give a fuckin name to the browser
    End Sub

    'This code allows the Go Button to be "clicked" with Enter key when URL TextBox is on focus
    Private Sub UrlTB_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles urltb.PreviewKeyDown
        'Fancy code goes here...
        If e.KeyCode = Keys.Enter Then
            Call Gobtn_Click(sender, e)
            DConsole.WriteLine("DEBUG: Enter key pressed while focusing on urltb!" + vbNewLine)
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
            DConsole.WriteLine("WARNING: Encryption Level changed: " + WebBrowser1.EncryptionLevel.ToString() + vbNewLine)
        End If

    End Sub
    'Enables the Back Button when it is useful
    Private Sub WebBrowser1_CanGoBackChanged(sender As Object, e As EventArgs) Handles WebBrowser1.CanGoBackChanged

        backbtn.Enabled = WebBrowser1.CanGoBack
        DConsole.WriteLine("DEBUG: Back Button Enabled" + vbNewLine)
    End Sub
    'Enables the Forward Button when it is useful
    Private Sub WebBrowser1_CanGoForwardChanged(sender As Object, e As EventArgs) Handles WebBrowser1.CanGoForwardChanged

        forwardbtn.Enabled = WebBrowser1.CanGoForward
        DConsole.WriteLine("DEBUG: Forward Button Enabled" + vbNewLine)
    End Sub
    'Monitors the page loading and reports errors (of itself)
    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        'Some more fancy code...
        'TODO: add some handmade error handlers...
        Try
            ProgressBar1.Maximum = e.MaximumProgress
            ProgressBar1.Minimum = 0
            If (e.CurrentProgress > 0 Or e.CurrentProgress = 0) Then
                If e.CurrentProgress > e.MaximumProgress Then
                    ProgressBar1.Maximum = e.CurrentProgress
                    DConsole.WriteLine("ERROR: NOT critical - Progress Bar Throttling - Setting Maximum value to Current value")
                End If
                ProgressBar1.Value = e.CurrentProgress
            End If

            If (e.CurrentProgress.ToString = "0" = False) And (e.MaximumProgress.ToString = "0" = False) Then
                DConsole.WriteLine("INFO: Progress - " + e.CurrentProgress.ToString() + "/" + e.MaximumProgress.ToString + vbNewLine)
            End If

            If ProgressBar1.Value = ProgressBar1.Maximum Then

                ProgressBar1.Value = ProgressBar1.Maximum
                Return

            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
