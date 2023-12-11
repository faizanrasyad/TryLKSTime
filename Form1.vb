Public Class Form1

    Dim user() As String = {"admin", "pegawai", "pimpinan"}
    Dim pass() As String = {"admin", "pegawai", "pimpinan"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim home As New Home
        If tbUser.Text = user(0) And tbPass.Text = user(0) Then
            home.Show()
            Me.Hide()
        ElseIf tbUser.Text = user(1) And tbPass.Text = user(1) Then
            home.Show()
            Me.Hide()
        ElseIf tbUser.Text = user(2) And tbPass.Text = user(2) Then
            home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah!")
            tbPass.Clear()
            tbUser.Clear()
        End If

        tbPass.Clear()
        tbUser.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
