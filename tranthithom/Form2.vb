Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=Admin\MSSQLSERVER01;Initial Catalog=QuanLyNhanSu;Integrated Security=True"

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim tenNV As String = TextBox1.Text.Trim()
        If tenNV = "" Then
            MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Using conn As New SqlClient.SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM NhanVien WHERE HoTen LIKE @HoTen"
                Using cmd As New SqlClient.SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@HoTen", "%" & tenNV & "%")
                    Using da As New SqlClient.SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvDSSV.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class