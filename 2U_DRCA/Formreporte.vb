Public Class Formreporte
    Private Sub Formreporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.TextBox4.Text
        Label2.Text = Form1.TextBox7.Text
        Label3.Text = Form1.TextBox5.Text
    End Sub
End Class