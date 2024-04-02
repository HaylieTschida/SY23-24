Imports System.Reflection.Emit

Public Class Form2



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim F As New Floors
        F.ShowDialog()
        TF.Text = F.Fcount.Value
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim W As New Walls
        W.ShowDialog()
        TW.Text = W.Wcount.Value
        Me.Show()
    End Sub

    Private Sub windowsB_Click(sender As Object, e As EventArgs) Handles windowsB.Click
        Me.Hide()
        Dim Win As New windows
        Win.ShowDialog()
        TWIN.Text = Win.Wincount.Value
        Me.Show()
    End Sub

    Private Sub doorsB_Click(sender As Object, e As EventArgs) Handles doorsB.Click
        Me.Hide()
        Dim D As New doors
        D.ShowDialog()
        TD.Text = D.Dcount.Value
        Me.Show()
    End Sub
End Class