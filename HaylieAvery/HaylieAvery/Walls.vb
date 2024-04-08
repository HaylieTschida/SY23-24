Public Class Walls

    Private Sub pricew_Click(sender As Object, e As EventArgs) Handles pricew.Click
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "wall" Then
                    pricew = 1
                End If
            End If
        Next
    End Sub
End Class