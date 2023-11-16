Public Class Form2
    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Text = "Burger - Small"
            TextBox2.Text = 49
        End If
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox1.Text = "Burger - Medium"
            TextBox2.Text = 75
        End If
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox1.Text = "Burger - Large"
            TextBox2.Text = 99
        End If
    End Sub

    Private Sub Guna2RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox1.Text = "Fries - Small"
            TextBox2.Text = 39
        End If
    End Sub

    Private Sub Guna2RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox1.Text = "Fries - Medium"
            TextBox2.Text = 69
        End If
    End Sub

    Private Sub Guna2RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.Text = "Fries - Large"
            TextBox2.Text = 89
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click

        TextBox4.Text = Val(TextBox3.Text) - Val(TextBox2.Text)
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO tbl_order (`order`, `total`, `cash`, `change`) VALUES ('" & TextBox1.Text & "', 
            '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Succesfully added!")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class