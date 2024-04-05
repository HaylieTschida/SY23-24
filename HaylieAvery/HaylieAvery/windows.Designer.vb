<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windows
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
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Wincount = New System.Windows.Forms.NumericUpDown()
        Me.pricewin = New System.Windows.Forms.Label()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wincount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.HaylieAvery.My.Resources.Resources.window5
        Me.PictureBox15.Location = New System.Drawing.Point(384, 249)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(175, 118)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox15.TabIndex = 82
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "window"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.HaylieAvery.My.Resources.Resources.window2
        Me.PictureBox14.Location = New System.Drawing.Point(412, 105)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(141, 101)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 81
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "window"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.HaylieAvery.My.Resources.Resources.window1
        Me.PictureBox12.Location = New System.Drawing.Point(241, 84)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(140, 111)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 80
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "window"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.HaylieAvery.My.Resources.Resources.window4
        Me.PictureBox3.Location = New System.Drawing.Point(251, 235)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 143)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 79
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "window"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(387, 136)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 16)
        Me.TotalLabel.TabIndex = 78
        Me.TotalLabel.Tag = "window"
        '
        'Wincount
        '
        Me.Wincount.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wincount.Location = New System.Drawing.Point(49, 49)
        Me.Wincount.Name = "Wincount"
        Me.Wincount.Size = New System.Drawing.Size(120, 31)
        Me.Wincount.TabIndex = 83
        '
        'pricewin
        '
        Me.pricewin.AutoSize = True
        Me.pricewin.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricewin.Location = New System.Drawing.Point(54, 94)
        Me.pricewin.Name = "pricewin"
        Me.pricewin.Size = New System.Drawing.Size(59, 23)
        Me.pricewin.TabIndex = 84
        Me.pricewin.Text = "price"
        '
        'windows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pricewin)
        Me.Controls.Add(Me.Wincount)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TotalLabel)
        Me.Name = "windows"
        Me.Text = "windows"
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wincount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Wincount As NumericUpDown
    Friend WithEvents pricewin As Label
End Class
