<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Clicker_Control1 = New Feb5.Clicker_Control()
        Me.Clicker_Control2 = New Feb5.Clicker_Control()
        Me.Clicker_Control3 = New Feb5.Clicker_Control()
        Me.SuspendLayout()
        '
        'Clicker_Control1
        '
        Me.Clicker_Control1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Clicker_Control1.increment = 5
        Me.Clicker_Control1.Location = New System.Drawing.Point(27, 8)
        Me.Clicker_Control1.Name = "Clicker_Control1"
        Me.Clicker_Control1.Size = New System.Drawing.Size(230, 99)
        Me.Clicker_Control1.TabIndex = 9
        '
        'Clicker_Control2
        '
        Me.Clicker_Control2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Clicker_Control2.increment = 1
        Me.Clicker_Control2.Location = New System.Drawing.Point(543, 8)
        Me.Clicker_Control2.Name = "Clicker_Control2"
        Me.Clicker_Control2.Size = New System.Drawing.Size(230, 99)
        Me.Clicker_Control2.TabIndex = 10
        '
        'Clicker_Control3
        '
        Me.Clicker_Control3.BackColor = System.Drawing.Color.DarkSalmon
        Me.Clicker_Control3.increment = 1
        Me.Clicker_Control3.Location = New System.Drawing.Point(284, 8)
        Me.Clicker_Control3.Name = "Clicker_Control3"
        Me.Clicker_Control3.Size = New System.Drawing.Size(244, 99)
        Me.Clicker_Control3.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Clicker_Control3)
        Me.Controls.Add(Me.Clicker_Control2)
        Me.Controls.Add(Me.Clicker_Control1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Clicker_Control1 As Clicker_Control
    Friend WithEvents Clicker_Control2 As Clicker_Control
    Friend WithEvents Clicker_Control3 As Clicker_Control
End Class
