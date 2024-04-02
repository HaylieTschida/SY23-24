<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.windowsB = New System.Windows.Forms.Button()
        Me.doorsB = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TD = New System.Windows.Forms.Label()
        Me.totalTB = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.Label()
        Me.TWIN = New System.Windows.Forms.Label()
        Me.TF = New System.Windows.Forms.Label()
        Me.TW = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'windowsB
        '
        Me.windowsB.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowsB.Location = New System.Drawing.Point(12, 172)
        Me.windowsB.Name = "windowsB"
        Me.windowsB.Size = New System.Drawing.Size(110, 31)
        Me.windowsB.TabIndex = 60
        Me.windowsB.Text = "Windows"
        Me.windowsB.UseVisualStyleBackColor = True
        '
        'doorsB
        '
        Me.doorsB.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doorsB.Location = New System.Drawing.Point(12, 117)
        Me.doorsB.Name = "doorsB"
        Me.doorsB.Size = New System.Drawing.Size(89, 31)
        Me.doorsB.TabIndex = 59
        Me.doorsB.Text = "Doors"
        Me.doorsB.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 31)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Floors"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Walls"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TD
        '
        Me.TD.AutoSize = True
        Me.TD.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TD.Location = New System.Drawing.Point(107, 125)
        Me.TD.Name = "TD"
        Me.TD.Size = New System.Drawing.Size(22, 23)
        Me.TD.TabIndex = 75
        Me.TD.Text = "#"
        '
        'totalTB
        '
        Me.totalTB.Location = New System.Drawing.Point(892, 209)
        Me.totalTB.Name = "totalTB"
        Me.totalTB.Size = New System.Drawing.Size(100, 22)
        Me.totalTB.TabIndex = 76
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(900, 180)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(60, 23)
        Me.total.TabIndex = 77
        Me.total.Text = "Total"
        '
        'TWIN
        '
        Me.TWIN.AutoSize = True
        Me.TWIN.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TWIN.Location = New System.Drawing.Point(128, 172)
        Me.TWIN.Name = "TWIN"
        Me.TWIN.Size = New System.Drawing.Size(22, 23)
        Me.TWIN.TabIndex = 78
        Me.TWIN.Text = "#"
        '
        'TF
        '
        Me.TF.AutoSize = True
        Me.TF.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TF.Location = New System.Drawing.Point(107, 62)
        Me.TF.Name = "TF"
        Me.TF.Size = New System.Drawing.Size(22, 23)
        Me.TF.TabIndex = 79
        Me.TF.Text = "#"
        '
        'TW
        '
        Me.TW.AutoSize = True
        Me.TW.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TW.Location = New System.Drawing.Point(107, 16)
        Me.TW.Name = "TW"
        Me.TW.Size = New System.Drawing.Size(22, 23)
        Me.TW.TabIndex = 80
        Me.TW.Text = "#"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 512)
        Me.Controls.Add(Me.TW)
        Me.Controls.Add(Me.TF)
        Me.Controls.Add(Me.TWIN)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.totalTB)
        Me.Controls.Add(Me.TD)
        Me.Controls.Add(Me.windowsB)
        Me.Controls.Add(Me.doorsB)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents windowsB As Button
    Friend WithEvents doorsB As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TD As Label
    Friend WithEvents totalTB As TextBox
    Friend WithEvents total As Label
    Friend WithEvents TWIN As Label
    Friend WithEvents TF As Label
    Friend WithEvents TW As Label
End Class
