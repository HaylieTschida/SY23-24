Public Class windows
    Private Sub pricewin_Click(sender As Object, e As EventArgs) Handles pricewin.Click
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "window" Then
                    pricewin = 1
                End If
            End If
        Next
    End Sub
End Class