<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DConsole
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
        Me.DCOutput = New System.Windows.Forms.RichTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DCInput = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DCOutput
        '
        Me.DCOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DCOutput.Location = New System.Drawing.Point(0, 0)
        Me.DCOutput.Name = "DCOutput"
        Me.DCOutput.ReadOnly = True
        Me.DCOutput.Size = New System.Drawing.Size(800, 421)
        Me.DCOutput.TabIndex = 0
        Me.DCOutput.Text = ""
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DCOutput)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DCInput)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 421
        Me.SplitContainer1.TabIndex = 1
        '
        'DCInput
        '
        Me.DCInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DCInput.Location = New System.Drawing.Point(0, 0)
        Me.DCInput.Name = "DCInput"
        Me.DCInput.Size = New System.Drawing.Size(800, 22)
        Me.DCInput.TabIndex = 0
        '
        'DConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DConsole"
        Me.Text = "Console"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DCOutput As RichTextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DCInput As TextBox
End Class
