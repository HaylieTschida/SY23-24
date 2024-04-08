Public Class Floors
    Private Sub pricef_Click(sender As Object, e As EventArgs) Handles pricef.Click
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "floor" Then
                    pricef = 1
                End If
            End If
        Next
    End Sub
End Class