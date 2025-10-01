<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        picboxAnh = New PictureBox()
        lbHoTen = New Label()
        btnLuu = New Button()
        cobGT = New ComboBox()
        lbEmail = New Label()
        lbGT = New Label()
        lbNS = New Label()
        lbNgayVaoLam = New Label()
        lbMaNV = New Label()
        lbChucVu = New Label()
        tbnHoTen = New TextBox()
        tbnChucVu = New TextBox()
        tbnMaNV = New TextBox()
        tbnEmail = New TextBox()
        btnXoa = New Button()
        lbTieuDe = New Label()
        NgayVaoLam = New TextBox()
        tbnNS = New TextBox()
        btnThoat = New Button()
        Button1 = New Button()
        Button2 = New Button()
        CType(picboxAnh, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picboxAnh
        ' 
        picboxAnh.Location = New Point(12, 59)
        picboxAnh.Name = "picboxAnh"
        picboxAnh.Size = New Size(102, 90)
        picboxAnh.TabIndex = 0
        picboxAnh.TabStop = False
        ' 
        ' lbHoTen
        ' 
        lbHoTen.AutoSize = True
        lbHoTen.Location = New Point(12, 177)
        lbHoTen.Name = "lbHoTen"
        lbHoTen.Size = New Size(56, 20)
        lbHoTen.TabIndex = 1
        lbHoTen.Text = "Ho Ten"
        ' 
        ' btnLuu
        ' 
        btnLuu.Location = New Point(294, 409)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(94, 29)
        btnLuu.TabIndex = 2
        btnLuu.Text = "Luu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' cobGT
        ' 
        cobGT.FormattingEnabled = True
        cobGT.Location = New Point(136, 268)
        cobGT.Name = "cobGT"
        cobGT.Size = New Size(151, 28)
        cobGT.TabIndex = 3
        ' 
        ' lbEmail
        ' 
        lbEmail.AutoSize = True
        lbEmail.Location = New Point(12, 223)
        lbEmail.Name = "lbEmail"
        lbEmail.Size = New Size(46, 20)
        lbEmail.TabIndex = 5
        lbEmail.Text = "Email"
        ' 
        ' lbGT
        ' 
        lbGT.AutoSize = True
        lbGT.Location = New Point(12, 268)
        lbGT.Name = "lbGT"
        lbGT.Size = New Size(68, 20)
        lbGT.TabIndex = 6
        lbGT.Text = "Gioi Tinh"
        ' 
        ' lbNS
        ' 
        lbNS.AutoSize = True
        lbNS.Location = New Point(12, 314)
        lbNS.Name = "lbNS"
        lbNS.Size = New Size(76, 20)
        lbNS.TabIndex = 7
        lbNS.Text = "Ngay Sinh"
        ' 
        ' lbNgayVaoLam
        ' 
        lbNgayVaoLam.AutoSize = True
        lbNgayVaoLam.Location = New Point(12, 365)
        lbNgayVaoLam.Name = "lbNgayVaoLam"
        lbNgayVaoLam.Size = New Size(105, 20)
        lbNgayVaoLam.TabIndex = 8
        lbNgayVaoLam.Text = "Ngay Vao Lam"
        ' 
        ' lbMaNV
        ' 
        lbMaNV.AutoSize = True
        lbMaNV.Location = New Point(389, 177)
        lbMaNV.Name = "lbMaNV"
        lbMaNV.Size = New Size(54, 20)
        lbMaNV.TabIndex = 9
        lbMaNV.Text = "Ma NV"
        ' 
        ' lbChucVu
        ' 
        lbChucVu.AutoSize = True
        lbChucVu.Location = New Point(389, 223)
        lbChucVu.Name = "lbChucVu"
        lbChucVu.Size = New Size(62, 20)
        lbChucVu.TabIndex = 10
        lbChucVu.Text = "Chuc Vu"
        ' 
        ' tbnHoTen
        ' 
        tbnHoTen.Location = New Point(136, 173)
        tbnHoTen.Name = "tbnHoTen"
        tbnHoTen.Size = New Size(125, 27)
        tbnHoTen.TabIndex = 14
        ' 
        ' tbnChucVu
        ' 
        tbnChucVu.Location = New Point(498, 220)
        tbnChucVu.Name = "tbnChucVu"
        tbnChucVu.Size = New Size(125, 27)
        tbnChucVu.TabIndex = 15
        ' 
        ' tbnMaNV
        ' 
        tbnMaNV.Location = New Point(498, 170)
        tbnMaNV.Name = "tbnMaNV"
        tbnMaNV.Size = New Size(125, 27)
        tbnMaNV.TabIndex = 17
        ' 
        ' tbnEmail
        ' 
        tbnEmail.Location = New Point(136, 219)
        tbnEmail.Name = "tbnEmail"
        tbnEmail.Size = New Size(125, 27)
        tbnEmail.TabIndex = 18
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(407, 409)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 21
        btnXoa.Text = "Xoa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' lbTieuDe
        ' 
        lbTieuDe.AutoSize = True
        lbTieuDe.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTieuDe.Location = New Point(136, 9)
        lbTieuDe.Name = "lbTieuDe"
        lbTieuDe.Size = New Size(406, 41)
        lbTieuDe.TabIndex = 22
        lbTieuDe.Text = "Thông Tin Chi Tiết Nhân Viên"
        ' 
        ' NgayVaoLam
        ' 
        NgayVaoLam.Location = New Point(136, 361)
        NgayVaoLam.Name = "NgayVaoLam"
        NgayVaoLam.Size = New Size(125, 27)
        NgayVaoLam.TabIndex = 23
        ' 
        ' tbnNS
        ' 
        tbnNS.Location = New Point(136, 314)
        tbnNS.Name = "tbnNS"
        tbnNS.Size = New Size(125, 27)
        tbnNS.TabIndex = 24
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(517, 409)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(94, 29)
        btnThoat.TabIndex = 27
        btnThoat.Text = "Thoat"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(182, 409)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 28
        Button1.Text = "Tim Kiem"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(73, 409)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 29
        Button2.Text = "Bao cao"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(645, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnThoat)
        Controls.Add(tbnNS)
        Controls.Add(NgayVaoLam)
        Controls.Add(lbTieuDe)
        Controls.Add(btnXoa)
        Controls.Add(tbnEmail)
        Controls.Add(tbnMaNV)
        Controls.Add(tbnChucVu)
        Controls.Add(tbnHoTen)
        Controls.Add(lbChucVu)
        Controls.Add(lbMaNV)
        Controls.Add(lbNgayVaoLam)
        Controls.Add(lbNS)
        Controls.Add(lbGT)
        Controls.Add(lbEmail)
        Controls.Add(cobGT)
        Controls.Add(btnLuu)
        Controls.Add(lbHoTen)
        Controls.Add(picboxAnh)
        Name = "Form3"
        Text = "Form3"
        CType(picboxAnh, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picboxAnh As PictureBox
    Friend WithEvents lbHoTen As Label
    Friend WithEvents btnLuu As Button
    Friend WithEvents cobGT As ComboBox
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbGT As Label
    Friend WithEvents lbNS As Label
    Friend WithEvents lbNgayVaoLam As Label
    Friend WithEvents lbMaNV As Label
    Friend WithEvents lbChucVu As Label
    Friend WithEvents tbnHoTen As TextBox
    Friend WithEvents tbnChucVu As TextBox
    Friend WithEvents tbnMaNV As TextBox
    Friend WithEvents tbnEmail As TextBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents lbTieuDe As Label
    Friend WithEvents NgayVaoLam As TextBox
    Friend WithEvents tbnNS As TextBox
    Friend WithEvents btnThoat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
