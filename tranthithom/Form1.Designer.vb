<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnDangNhap = New Button()
        Label1 = New Label()
        tbnTK = New TextBox()
        Label2 = New Label()
        tbnMK = New TextBox()
        Label3 = New Label()
        btnXoa = New Button()
        btnThoat = New Button()
        SuspendLayout()
        ' 
        ' btnDangNhap
        ' 
        btnDangNhap.Location = New Point(168, 362)
        btnDangNhap.Name = "btnDangNhap"
        btnDangNhap.Size = New Size(94, 29)
        btnDangNhap.TabIndex = 0
        btnDangNhap.Text = "Dang Nhap"
        btnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 1
        Label1.Text = "Tai Khoan"
        ' 
        ' tbnTK
        ' 
        tbnTK.Location = New Point(168, 114)
        tbnTK.Name = "tbnTK"
        tbnTK.Size = New Size(429, 27)
        tbnTK.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(305, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 41)
        Label2.TabIndex = 3
        Label2.Text = "DANG NHAP"
        ' 
        ' tbnMK
        ' 
        tbnMK.Location = New Point(168, 219)
        tbnMK.Name = "tbnMK"
        tbnMK.Size = New Size(429, 27)
        tbnMK.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 4
        Label3.Text = "Mat Khau"
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(354, 362)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 6
        btnXoa.Text = "Xoa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(525, 362)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(94, 29)
        btnThoat.TabIndex = 7
        btnThoat.Text = "Thoat"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(743, 425)
        Controls.Add(btnThoat)
        Controls.Add(btnXoa)
        Controls.Add(tbnMK)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbnTK)
        Controls.Add(Label1)
        Controls.Add(btnDangNhap)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDangNhap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbnTK As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbnMK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button

End Class
