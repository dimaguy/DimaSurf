<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.homeurl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchurl = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home URL/IP"
        '
        'homeurl
        '
        Me.homeurl.Location = New System.Drawing.Point(16, 31)
        Me.homeurl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.homeurl.Name = "homeurl"
        Me.homeurl.Size = New System.Drawing.Size(317, 22)
        Me.homeurl.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search URL/IP"
        '
        'searchurl
        '
        Me.searchurl.Location = New System.Drawing.Point(16, 80)
        Me.searchurl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchurl.Name = "searchurl"
        Me.searchurl.Size = New System.Drawing.Size(317, 22)
        Me.searchurl.TabIndex = 3
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(237, 112)
        Me.Save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(100, 28)
        Me.Save.TabIndex = 4
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(129, 112)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 28)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(19, 112)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 21)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Console"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 160)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.searchurl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.homeurl)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents homeurl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchurl As TextBox
    Friend WithEvents Save As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
