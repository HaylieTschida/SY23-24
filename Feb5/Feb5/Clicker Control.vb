Public Class Clicker_Control
    Public Property increment As Integer = 1
    Dim c As New Clicker

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.increment = increment
        c.Click()
        TextBox1.Text = c.Count

    End Sub
End Class
