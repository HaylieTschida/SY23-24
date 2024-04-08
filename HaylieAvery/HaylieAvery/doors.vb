Public Class doors
    Private Sub priceD_Click(sender As Object, e As EventArgs) Handles priceD.Click
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "doors" Then
                    priceD = 1
                End If
            End If
        Next
    End Sub

End Class