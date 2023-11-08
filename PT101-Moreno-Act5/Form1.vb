Public Class Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "ADMIN" And TextBox2.Text = "admin" Then
            Timer1.Start()

        Else
            MsgBox("Your Input is Invalid! Try again.")
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Value += 1
        If ProgressBar.Value = ProgressBar.Maximum Then
            Timer1.Enabled = False
            Hide()
            MsgBox("Success! Welcome to Burger and Fries!")
            Form2.Show()
        End If
    End Sub

End Class