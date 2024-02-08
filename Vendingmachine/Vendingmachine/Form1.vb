Public Class Form1
    Dim WithEvents CS As New CoinSlot



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertDollar()
        Label1.Text = CS.Total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertQuarter()
        Label1.Text = CS.Total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertDime()
        Label1.Text = CS.Total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.insertNickel()
        Label1.Text = CS.Total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.CoinReturn()
        Label1.Text = CS.Total.ToString("c2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer) Handles CS.CoinReturnEvent
        If q > 0 Then
            Quarterpicturebox.Visible = True
        Else
            Quarterpicturebox.Visible = False
        End If

        If di > 0 Then
            DimesPictureBox.Visible = True
        Else
            DimesPictureBox.Visible = False
        End If

        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If

        If n > 0 Then
            NickelPictureBox.Visible = True
        Else
            NickelPictureBox.Visible = False
        End If
    End Sub
End Class
