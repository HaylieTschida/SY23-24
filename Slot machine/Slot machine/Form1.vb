Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReelControl1.spin()
        Label1.Text = ReelControl1.itemValue

        ReelControl2.spin()
        Label1.Text = ReelControl1.itemValue

        ReelControl3.spin()
        Timer1.Enabled = True
        If ReelControl1.itemValue = ReelControl2.itemValue And ReelControl3.itemValue Then


        End If

    End Sub

    Private Sub ReelControl12_Load(sender As Object, e As EventArgs) Handles ReelControl2.Load

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = ReelControl1.itemValue
        Label2.Text = ReelControl1.itemValue
        Label3.Text = ReelControl1.itemValue
        Timer1.Enabled = False
    End Sub
End Class
