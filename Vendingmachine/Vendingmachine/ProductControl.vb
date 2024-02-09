Public Class ProductControl
    Public Property ProductName As String
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductImage As Image
    Public Property Productcount As Integer

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductImage
        IDLabel.Text = ProductID
        PriceLabel.Text = ProductPrice.ToString("C2")
    End Sub
End Class
