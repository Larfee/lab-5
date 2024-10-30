Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
        Label2.ForeColor = Color.Black
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Today
        Label1.ForeColor = Color.Black
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = "ФАМИЛИЯ1 ИМЯ1"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Text = "ФАМИЛИЯ2 ИМЯ2"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button2.BackColor = Color.Black
        Button3.BackColor = Color.Black
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Text = CSng(TextBox1.Text) + CSng(TextBox2.Text)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CSng(TextBox2.Text) = 0 Then
            TextBox3.Text = "Деление на ноль невозможно"
        Else
            TextBox3.Text = CSng(TextBox1.Text) / CSng(TextBox2.Text)
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub
End Class
