Imports System.Data.SqlClient

Public Class Form3
    Dim connectionString As String = "Data Source=Admin\MSSQLSERVER01;Initial Catalog=QuanLyNhanSu;Integrated Security=True"

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO NhanVien (MaNV, HoTen, Email, GioiTinh, NgaySinh, NgayVaoLam, ChucVu) VALUES (@MaNV, @HoTen, @Email, @GioiTinh, @NgaySinh, @NgayVaoLam, @ChucVu)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaNV", tbnMaNV.Text)
                    cmd.Parameters.AddWithValue("@HoTen", tbnHoTen.Text)
                    cmd.Parameters.AddWithValue("@Email", tbnEmail.Text)
                    cmd.Parameters.AddWithValue("@GioiTinh", cobGT.Text)
                    cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(tbnNS.Text))
                    cmd.Parameters.AddWithValue("@NgayVaoLam", DateTime.Parse(NgayVaoLam.Text))
                    cmd.Parameters.AddWithValue("@ChucVu", tbnChucVu.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Lỗi khi lưu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show
        Hide
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class