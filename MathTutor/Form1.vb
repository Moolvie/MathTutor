Public Class Form1

   
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the program
        Me.Close()
    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        ' Display the answer
        lblAnswer.Text = "15 + 75 = 90"
    End Sub

End Class
