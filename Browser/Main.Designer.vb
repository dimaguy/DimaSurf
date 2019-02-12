<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.urltb = New System.Windows.Forms.TextBox()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.forwardbtn = New System.Windows.Forms.Button()
        Me.gobtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.saveasbtn = New System.Windows.Forms.Button()
        Me.safety = New System.Windows.Forms.Button()
        Me.printbtn = New System.Windows.Forms.Button()
        Me.settingsbtn = New System.Windows.Forms.Button()
        Me.stopbtn = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'urltb
        '
        Me.urltb.Location = New System.Drawing.Point(89, 6)
        Me.urltb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.urltb.Name = "urltb"
        Me.urltb.Size = New System.Drawing.Size(413, 22)
        Me.urltb.TabIndex = 1
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(66, 33)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(83, 28)
        Me.backbtn.TabIndex = 2
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'forwardbtn
        '
        Me.forwardbtn.Location = New System.Drawing.Point(155, 33)
        Me.forwardbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.forwardbtn.Name = "forwardbtn"
        Me.forwardbtn.Size = New System.Drawing.Size(83, 28)
        Me.forwardbtn.TabIndex = 3
        Me.forwardbtn.Text = "Forward"
        Me.forwardbtn.UseVisualStyleBackColor = True
        '
        'gobtn
        '
        Me.gobtn.AutoSize = True
        Me.gobtn.Location = New System.Drawing.Point(508, 1)
        Me.gobtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gobtn.Name = "gobtn"
        Me.gobtn.Padding = New System.Windows.Forms.Padding(1)
        Me.gobtn.Size = New System.Drawing.Size(75, 36)
        Me.gobtn.TabIndex = 4
        Me.gobtn.Text = "Go"
        Me.gobtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Location = New System.Drawing.Point(397, 32)
        Me.refreshbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(89, 28)
        Me.refreshbtn.TabIndex = 5
        Me.refreshbtn.Text = "Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'homebtn
        '
        Me.homebtn.Location = New System.Drawing.Point(844, 42)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(75, 23)
        Me.homebtn.TabIndex = 6
        Me.homebtn.Text = "Home"
        Me.homebtn.UseVisualStyleBackColor = True
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(844, 14)
        Me.searchbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 8
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(933, 440)
        Me.WebBrowser1.TabIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.saveasbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.safety)
        Me.SplitContainer1.Panel1.Controls.Add(Me.printbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.settingsbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stopbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.urltb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.searchbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.backbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.homebtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.forwardbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.refreshbtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gobtn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(933, 510)
        Me.SplitContainer1.SplitterDistance = 66
        Me.SplitContainer1.TabIndex = 9
        '
        'saveasbtn
        '
        Me.saveasbtn.Location = New System.Drawing.Point(698, 38)
        Me.saveasbtn.Name = "saveasbtn"
        Me.saveasbtn.Size = New System.Drawing.Size(90, 23)
        Me.saveasbtn.TabIndex = 13
        Me.saveasbtn.Text = "Save As..."
        Me.saveasbtn.UseVisualStyleBackColor = True
        '
        'safety
        '
        Me.safety.AutoSize = True
        Me.safety.Location = New System.Drawing.Point(3, 3)
        Me.safety.Name = "safety"
        Me.safety.Size = New System.Drawing.Size(27, 29)
        Me.safety.TabIndex = 12
        Me.safety.Text = "S"
        Me.safety.UseVisualStyleBackColor = True
        '
        'printbtn
        '
        Me.printbtn.Location = New System.Drawing.Point(617, 38)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(75, 23)
        Me.printbtn.TabIndex = 11
        Me.printbtn.Text = "Print"
        Me.printbtn.UseVisualStyleBackColor = True
        '
        'settingsbtn
        '
        Me.settingsbtn.Location = New System.Drawing.Point(653, 6)
        Me.settingsbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.settingsbtn.Name = "settingsbtn"
        Me.settingsbtn.Size = New System.Drawing.Size(100, 28)
        Me.settingsbtn.TabIndex = 10
        Me.settingsbtn.Text = "Settings"
        Me.settingsbtn.UseVisualStyleBackColor = True
        '
        'stopbtn
        '
        Me.stopbtn.Location = New System.Drawing.Point(301, 33)
        Me.stopbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.Size = New System.Drawing.Size(89, 28)
        Me.stopbtn.TabIndex = 9
        Me.stopbtn.Text = "Stop"
        Me.stopbtn.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ProgressBar1)
        Me.SplitContainer2.Size = New System.Drawing.Size(933, 542)
        Me.SplitContainer2.SplitterDistance = 510
        Me.SplitContainer2.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(907, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 542)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents urltb As TextBox
    Friend WithEvents backbtn As Button
    Friend WithEvents forwardbtn As Button
    Friend WithEvents gobtn As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents homebtn As Button
    Friend WithEvents searchbtn As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents stopbtn As Button
    Friend WithEvents settingsbtn As Button
    Friend WithEvents printbtn As Button
    Friend WithEvents safety As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents saveasbtn As Button
    Public WithEvents WebBrowser1 As WebBrowser
End Class
