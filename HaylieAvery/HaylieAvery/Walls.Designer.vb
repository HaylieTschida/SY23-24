﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Walls
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
        Me.Wcount = New System.Windows.Forms.NumericUpDown()
        Me.PictureBoxWall1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWall2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWall4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWall3 = New System.Windows.Forms.PictureBox()
        Me.pricew = New System.Windows.Forms.Label()
        CType(Me.Wcount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWall3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wcount
        '
        Me.Wcount.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wcount.Location = New System.Drawing.Point(12, 36)
        Me.Wcount.Name = "Wcount"
        Me.Wcount.Size = New System.Drawing.Size(120, 31)
        Me.Wcount.TabIndex = 0
        '
        'PictureBoxWall1
        '
        Me.PictureBoxWall1.Image = Global.HaylieAvery.My.Resources.Resources.wall4
        Me.PictureBoxWall1.Location = New System.Drawing.Point(241, 36)
        Me.PictureBoxWall1.Name = "PictureBoxWall1"
        Me.PictureBoxWall1.Size = New System.Drawing.Size(113, 106)
        Me.PictureBoxWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxWall1.TabIndex = 78
        Me.PictureBoxWall1.TabStop = False
        Me.PictureBoxWall1.Tag = "wall"
        '
        'PictureBoxWall2
        '
        Me.PictureBoxWall2.Image = Global.HaylieAvery.My.Resources.Resources.wall3
        Me.PictureBoxWall2.Location = New System.Drawing.Point(430, 36)
        Me.PictureBoxWall2.Name = "PictureBoxWall2"
        Me.PictureBoxWall2.Size = New System.Drawing.Size(93, 128)
        Me.PictureBoxWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxWall2.TabIndex = 77
        Me.PictureBoxWall2.TabStop = False
        Me.PictureBoxWall2.Tag = "wall"
        '
        'PictureBoxWall4
        '
        Me.PictureBoxWall4.Image = Global.HaylieAvery.My.Resources.Resources.wall2
        Me.PictureBoxWall4.Location = New System.Drawing.Point(430, 217)
        Me.PictureBoxWall4.Name = "PictureBoxWall4"
        Me.PictureBoxWall4.Size = New System.Drawing.Size(159, 83)
        Me.PictureBoxWall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxWall4.TabIndex = 76
        Me.PictureBoxWall4.TabStop = False
        Me.PictureBoxWall4.Tag = "wall"
        '
        'PictureBoxWall3
        '
        Me.PictureBoxWall3.Image = Global.HaylieAvery.My.Resources.Resources.wall1
        Me.PictureBoxWall3.Location = New System.Drawing.Point(241, 204)
        Me.PictureBoxWall3.Name = "PictureBoxWall3"
        Me.PictureBoxWall3.Size = New System.Drawing.Size(120, 106)
        Me.PictureBoxWall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxWall3.TabIndex = 75
        Me.PictureBoxWall3.TabStop = False
        Me.PictureBoxWall3.Tag = "wall"
        '
        'pricew
        '
        Me.pricew.AutoSize = True
        Me.pricew.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricew.Location = New System.Drawing.Point(25, 84)
        Me.pricew.Name = "pricew"
        Me.pricew.Size = New System.Drawing.Size(59, 23)
        Me.pricew.TabIndex = 79
        Me.pricew.Text = "price"
        '
        'Walls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pricew)
        Me.Controls.Add(Me.PictureBoxWall1)
        Me.Controls.Add(Me.PictureBoxWall2)
        Me.Controls.Add(Me.PictureBoxWall4)
        Me.Controls.Add(Me.PictureBoxWall3)
        Me.Controls.Add(Me.Wcount)
        Me.Name = "Walls"
        Me.Text = "Walls"
        CType(Me.Wcount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWall3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wcount As NumericUpDown
    Friend WithEvents PictureBoxWall1 As PictureBox
    Friend WithEvents PictureBoxWall2 As PictureBox
    Friend WithEvents PictureBoxWall4 As PictureBox
    Friend WithEvents PictureBoxWall3 As PictureBox
    Friend WithEvents pricew As Label
End Class
