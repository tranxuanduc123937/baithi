Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Đặt textbox mật khẩu dạng ***
        tbnMK.UseSystemPasswordChar = True
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim username As String = tbnTK.Text.Trim()
        Dim password As String = tbnMK.Text
        If username = "admin" And password = "123456" Then
            Dim frm2 As New Form2()
            Form3.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        tbnTK.Text = ""
        tbnMK.Text = ""
        tbnTK.Focus()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub
End Class
