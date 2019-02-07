Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Loading Form",, "Load Form")
        Dim name As String
        name = "jsoh"
        MsgBox("Hello, " + name,, "Greetings")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Yes")
        PictureBox1.Visible = True
        Button1.Enabled = False
        Button1.Visible = False
        Button2.Enabled = True
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Ok")
        PictureBox1.Visible = False
        Button2.Enabled = False
        Button2.Visible = False
        Button1.Enabled = True
        Button1.Visible = True
    End Sub
End Class
