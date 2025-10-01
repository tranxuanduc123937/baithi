Imports System.Data.SqlClient

Public Class Form4
    Dim connectionString As String = "Data Source=Admin\MSSQLSERVER01;Initial Catalog=QuanLyNhanSu;Integrated Security=True"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBaoCao()
    End Sub

    Private Sub LoadBaoCao()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM BaoCao"
                Using da As New SqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvBaoCao.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Lưu dữ liệu từ DataGridView vào bảng BaoCao
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                For Each row As DataGridViewRow In dgvBaoCao.Rows
                    If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("MaBC").Value) Then
                        Dim query As String = "INSERT INTO BaoCao (MaBC, LoaiBaoCao, NoiDung, NgayBaoCao) VALUES (@MaBC, @LoaiBaoCao, @NoiDung, @NgayBaoCao)"
                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@MaBC", row.Cells("MaBC").Value)
                            cmd.Parameters.AddWithValue("@LoaiBaoCao", row.Cells("LoaiBaoCao").Value)
                            cmd.Parameters.AddWithValue("@NoiDung", row.Cells("NoiDung").Value)
                            cmd.Parameters.AddWithValue("@NgayBaoCao", row.Cells("NgayBaoCao").Value)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                MessageBox.Show("Đã lưu dữ liệu vào bảng BaoCao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBaoCao()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi lưu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class