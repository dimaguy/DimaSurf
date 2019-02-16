Imports System.Net
Imports System.Runtime.InteropServices

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.home = "" And My.Settings.search = "" Then
            My.Settings.home = "http:\\www.google.com"
            My.Settings.search = "http:\\www.google.com"
        End If
        homeurl.Text = My.Settings.home
        searchurl.Text = My.Settings.search
        Google_SafeBrowsing_API_KEY.Text = My.Settings.gsbapikey
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim ip As IPAddress = Nothing
        Dim homeip As Boolean = IPAddress.TryParse(homeurl.Text, ip)
        Dim searchip As Boolean = IPAddress.TryParse(searchurl.Text, ip)
        If UrlIsValid(homeurl.Text) = True Or homeip = True Then
            If UrlIsValid(searchurl.Text) = True Or homeip = True Then
                My.Settings.home = homeurl.Text
                My.Settings.search = searchurl.Text
            Else
                MessageBox.Show("Please insert a valid Search URL/IP", "Invalid string",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please insert a valid Home URL/IP", "Invalid string",
    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        My.Settings.gsbapikey = Google_SafeBrowsing_API_KEY.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            DConsole.Show()
        Else
            DConsole.Hide()
        End If
    End Sub
End Class
'TODO: add some... performance monitor... bcoz it looks fancy