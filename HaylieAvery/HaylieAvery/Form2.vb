Imports System.Reflection.Emit

Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles doorsB.Click
        Me.Hide()
        Dim D As New doors
        D.ShowDialog()
        Label1.Text = D.Dcount.Value
        Me.Show()
    End Sub
End Class