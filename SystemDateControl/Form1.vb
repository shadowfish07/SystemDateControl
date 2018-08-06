Public Class Form1
    Dim Tod As Date = Today
    Dim i As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Today = CType(TextBox1.Text, Date)
        i = 60
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i -= 1
        Label2.Text = CStr(i) + "秒后重设"
        If i = 0 Then
            Today = Tod
            Timer1.Enabled = False
            Label2.Text = "重设完毕"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Today = Tod
        Label2.Text = "重设完毕"
        Timer1.Enabled = False
    End Sub
End Class
