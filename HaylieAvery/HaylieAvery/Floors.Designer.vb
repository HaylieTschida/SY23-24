<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Floors
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
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Fcount = New System.Windows.Forms.NumericUpDown()
        Me.pricef = New System.Windows.Forms.Label()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fcount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.HaylieAvery.My.Resources.Resources.floor1
        Me.PictureBox10.Location = New System.Drawing.Point(290, 208)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(110, 106)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 77
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "floor"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.HaylieAvery.My.Resources.Resources.Floor2
        Me.PictureBox9.Location = New System.Drawing.Point(462, 208)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(107, 106)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 76
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "floor"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.HaylieAvery.My.Resources.Resources.floor3
        Me.PictureBox8.Location = New System.Drawing.Point(462, 44)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(107, 114)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 75
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "floor"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.HaylieAvery.My.Resources.Resources.Floor4
        Me.PictureBox7.Location = New System.Drawing.Point(275, 44)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(125, 86)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 74
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "floor"
        '
        'Fcount
        '
        Me.Fcount.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fcount.Location = New System.Drawing.Point(28, 44)
        Me.Fcount.Name = "Fcount"
        Me.Fcount.Size = New System.Drawing.Size(120, 31)
        Me.Fcount.TabIndex = 78
        '
        'pricef
        '
        Me.pricef.AutoSize = True
        Me.pricef.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricef.Location = New System.Drawing.Point(24, 107)
        Me.pricef.Name = "pricef"
        Me.pricef.Size = New System.Drawing.Size(59, 23)
        Me.pricef.TabIndex = 79
        Me.pricef.Text = "price"
        '
        'Floors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pricef)
        Me.Controls.Add(Me.Fcount)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Name = "Floors"
        Me.Text = "Floors"
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fcount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Fcount As NumericUpDown
    Friend WithEvents pricef As Label
End Class
