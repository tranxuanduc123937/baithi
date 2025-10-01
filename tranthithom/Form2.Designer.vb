<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        dgvDSSV = New DataGridView()
        btnThem = New Button()
        btnSua = New Button()
        btnTimKiem = New Button()
        btnThoat = New Button()
        Label1 = New Label()
        lbNV = New Label()
        cboPhongban = New ComboBox()
        cobTimMa = New ComboBox()
        lbTimKiem = New Label()
        TextBox1 = New TextBox()
        CType(dgvDSSV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDSSV
        ' 
        dgvDSSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSSV.Location = New Point(2, 113)
        dgvDSSV.Name = "dgvDSSV"
        dgvDSSV.RowHeadersWidth = 51
        dgvDSSV.Size = New Size(797, 188)
        dgvDSSV.TabIndex = 0
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(172, 334)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 1
        btnThem.Text = "Them"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(281, 334)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 2
        btnSua.Text = "Sua"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnTimKiem
        ' 
        btnTimKiem.Location = New Point(392, 334)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(94, 29)
        btnTimKiem.TabIndex = 3
        btnTimKiem.Text = "Tim Kiem"
        btnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(503, 334)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(94, 29)
        btnThoat.TabIndex = 4
        btnThoat.Text = "Thoat"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(2, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 7
        ' 
        ' lbNV
        ' 
        lbNV.AutoSize = True
        lbNV.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNV.Location = New Point(278, 79)
        lbNV.Name = "lbNV"
        lbNV.Size = New Size(234, 31)
        lbNV.TabIndex = 8
        lbNV.Text = "Danh Sach Nhan Vien"
        ' 
        ' cboPhongban
        ' 
        cboPhongban.FormattingEnabled = True
        cboPhongban.Location = New Point(450, 32)
        cboPhongban.Name = "cboPhongban"
        cboPhongban.Size = New Size(151, 28)
        cboPhongban.TabIndex = 9
        cboPhongban.Text = "Phong ban:"
        ' 
        ' cobTimMa
        ' 
        cobTimMa.FormattingEnabled = True
        cobTimMa.Location = New Point(623, 33)
        cobTimMa.Name = "cobTimMa"
        cobTimMa.Size = New Size(151, 28)
        cobTimMa.TabIndex = 10
        cobTimMa.Text = "Tim Ma:"
        ' 
        ' lbTimKiem
        ' 
        lbTimKiem.AutoSize = True
        lbTimKiem.Location = New Point(2, 32)
        lbTimKiem.Name = "lbTimKiem"
        lbTimKiem.Size = New Size(117, 20)
        lbTimKiem.TabIndex = 11
        lbTimKiem.Text = "Tim kiem nhanh:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(141, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(234, 27)
        TextBox1.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 383)
        Controls.Add(TextBox1)
        Controls.Add(lbTimKiem)
        Controls.Add(cobTimMa)
        Controls.Add(cboPhongban)
        Controls.Add(lbNV)
        Controls.Add(Label1)
        Controls.Add(btnThoat)
        Controls.Add(btnTimKiem)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(dgvDSSV)
        Name = "Form2"
        Text = "Form2"
        CType(dgvDSSV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDSSV As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbNV As Label
    Friend WithEvents cboPhongban As ComboBox
    Friend WithEvents cobTimMa As ComboBox
    Friend WithEvents lbTimKiem As Label
    Friend WithEvents TextBox1 As TextBox
End Class
