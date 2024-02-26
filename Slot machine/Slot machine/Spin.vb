Public Class Spin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Public Sub Spin()
        Dim rand As New Random
        Dim R As Integer
        R = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(R)

        R = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(R)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
         Spin()
    End Sub
End Class
