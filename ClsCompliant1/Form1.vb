Public Class Form1

    Private Sub ButtonGetTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGetTime.Click
        TextBoxTime.Text = ProvideTime.TimeProvider.Getdatetime()
    End Sub
End Class
