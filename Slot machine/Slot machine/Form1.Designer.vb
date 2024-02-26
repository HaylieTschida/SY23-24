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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReelControl2 = New Slot_machine.ReelControl1()
        Me.ReelControl3 = New Slot_machine.ReelControl1()
        Me.ReelControl1 = New Slot_machine.ReelControl1()
        Me.Spin1 = New Slot_machine.Spin()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.NickelPictureBox = New System.Windows.Forms.PictureBox()
        Me.DollarPictureBox = New System.Windows.Forms.PictureBox()
        Me.DimesPictureBox = New System.Windows.Forms.PictureBox()
        Me.Quarterpicturebox = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickelPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DimesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quarterpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "download.JPEG")
        Me.ImageList1.Images.SetKeyName(1, "download.JPEG")
        Me.ImageList1.Images.SetKeyName(2, "download.gif")
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(598, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'ReelControl2
        '
        Me.ReelControl2.AutoSize = True
        Me.ReelControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(244, 124)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(240, 263)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 7
        '
        'ReelControl3
        '
        Me.ReelControl3.AutoSize = True
        Me.ReelControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(-2, 124)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(240, 263)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 6
        '
        'ReelControl1
        '
        Me.ReelControl1.AutoSize = True
        Me.ReelControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(488, 124)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(240, 263)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 3
        '
        'Spin1
        '
        Me.Spin1.Location = New System.Drawing.Point(298, 12)
        Me.Spin1.Name = "Spin1"
        Me.Spin1.Size = New System.Drawing.Size(217, 120)
        Me.Spin1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(33, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(178, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(298, 41)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(414, 41)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(101, 60)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'NickelPictureBox
        '
        Me.NickelPictureBox.Image = CType(resources.GetObject("NickelPictureBox.Image"), System.Drawing.Image)
        Me.NickelPictureBox.Location = New System.Drawing.Point(555, 58)
        Me.NickelPictureBox.Name = "NickelPictureBox"
        Me.NickelPictureBox.Size = New System.Drawing.Size(51, 46)
        Me.NickelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NickelPictureBox.TabIndex = 17
        Me.NickelPictureBox.TabStop = False
        Me.NickelPictureBox.Visible = False
        '
        'DollarPictureBox
        '
        Me.DollarPictureBox.Image = CType(resources.GetObject("DollarPictureBox.Image"), System.Drawing.Image)
        Me.DollarPictureBox.Location = New System.Drawing.Point(612, 64)
        Me.DollarPictureBox.Name = "DollarPictureBox"
        Me.DollarPictureBox.Size = New System.Drawing.Size(43, 49)
        Me.DollarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarPictureBox.TabIndex = 16
        Me.DollarPictureBox.TabStop = False
        Me.DollarPictureBox.Visible = False
        '
        'DimesPictureBox
        '
        Me.DimesPictureBox.Image = CType(resources.GetObject("DimesPictureBox.Image"), System.Drawing.Image)
        Me.DimesPictureBox.Location = New System.Drawing.Point(612, 15)
        Me.DimesPictureBox.Name = "DimesPictureBox"
        Me.DimesPictureBox.Size = New System.Drawing.Size(34, 43)
        Me.DimesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DimesPictureBox.TabIndex = 15
        Me.DimesPictureBox.TabStop = False
        Me.DimesPictureBox.Visible = False
        '
        'Quarterpicturebox
        '
        Me.Quarterpicturebox.Image = CType(resources.GetObject("Quarterpicturebox.Image"), System.Drawing.Image)
        Me.Quarterpicturebox.Location = New System.Drawing.Point(555, 12)
        Me.Quarterpicturebox.Name = "Quarterpicturebox"
        Me.Quarterpicturebox.Size = New System.Drawing.Size(42, 46)
        Me.Quarterpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Quarterpicturebox.TabIndex = 14
        Me.Quarterpicturebox.TabStop = False
        Me.Quarterpicturebox.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(726, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Dime"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(726, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Quarter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(726, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Dollar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(726, 126)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Nickel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.NickelPictureBox)
        Me.Controls.Add(Me.DollarPictureBox)
        Me.Controls.Add(Me.DimesPictureBox)
        Me.Controls.Add(Me.Quarterpicturebox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.Spin1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickelPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DimesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quarterpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Spin1 As Spin
    Friend WithEvents ReelControl1 As ReelControl1
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ReelControl3 As ReelControl1
    Friend WithEvents ReelControl2 As ReelControl1
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents NickelPictureBox As PictureBox
    Friend WithEvents DollarPictureBox As PictureBox
    Friend WithEvents DimesPictureBox As PictureBox
    Friend WithEvents Quarterpicturebox As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer2 As Timer
End Class
