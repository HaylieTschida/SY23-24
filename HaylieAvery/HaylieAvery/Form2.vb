Imports System.Reflection.Emit

Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles doorsB.Click
        Me.Hide()
        Dim D As New doors
        D.ShowDialog()
        Label1.Text = D.Dcount.Value
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim F As New Floors
        F.ShowDialog()
        Label1.Text = F.Fcount.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim W As New Walls
        W.ShowDialog()
        Label1.Text = W.Wcount.Value
    End Sub

    Private Sub windowsB_Click(sender As Object, e As EventArgs) Handles windowsB.Click
        Me.Hide()
        Dim Win As New windows
        Win.ShowDialog()
        Label1.Text = Win.Wincount.Value
    End Sub

End Class