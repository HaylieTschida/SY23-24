Public Class Form1
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Private Sub Frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRIGHT.Start()
            Case Keys.Left
                tmrLEFT.Start()
            Case Keys.Up
                tmrUP.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRIGHT_Tick(sender As Object, e As EventArgs) Handles tmrRIGHT.Tick
        picPlayer.Left += moveSpeed

    End Sub

    Private Sub Frm2DPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRIGHT.Stop()
            Case Keys.Left
                tmrLEFT.Stop()
            Case Keys.Up
                tmrUP.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLEFT_Tick(sender As Object, e As EventArgs) Handles tmrLEFT.Tick
        picPlayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUP_Tick(sender As Object, e As EventArgs) Handles tmrUP.Tick
        picPlayer.Top -= moveSpeed
    End Sub

    Private Sub Frm2DPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()

    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
            If isJumping = False Then
                tmrGravity.Start()
            End If
        ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next
        If picPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Label1.Text = +1
        End If
        If picPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            PictureBox6.Visible = False
        End If
        PictureBox8.Visible = False
        If picPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            PictureBox8.Visible = True
        End If
        If picPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            PictureBox9.Visible = True
            PictureBox10.Visible = True
            Button1.Visible = True
        End If

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox9.Visible = False
        PictureBox10.Visible = False
    End Sub
End Class