<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lnBaoCao = New Label()
        cobLoaiBaoCao = New ComboBox()
        dgvBaoCao = New DataGridView()
        btnLuu = New Button()
        btnThoat = New Button()
        CType(dgvBaoCao, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lnBaoCao
        ' 
        lnBaoCao.AutoSize = True
        lnBaoCao.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnBaoCao.Location = New Point(202, 19)
        lnBaoCao.Name = "lnBaoCao"
        lnBaoCao.Size = New Size(128, 41)
        lnBaoCao.TabIndex = 0
        lnBaoCao.Text = "Báo Cáo"
        ' 
        ' cobLoaiBaoCao
        ' 
        cobLoaiBaoCao.FormattingEnabled = True
        cobLoaiBaoCao.Location = New Point(3, 79)
        cobLoaiBaoCao.Name = "cobLoaiBaoCao"
        cobLoaiBaoCao.Size = New Size(137, 28)
        cobLoaiBaoCao.TabIndex = 1
        cobLoaiBaoCao.Text = "Loai Bao Cao"
        ' 
        ' dgvBaoCao
        ' 
        dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBaoCao.Location = New Point(0, 117)
        dgvBaoCao.Name = "dgvBaoCao"
        dgvBaoCao.RowHeadersWidth = 51
        dgvBaoCao.Size = New Size(539, 188)
        dgvBaoCao.TabIndex = 3
        ' 
        ' btnLuu
        ' 
        btnLuu.Location = New Point(300, 346)
        btnLuu.Name = "btnLuu"
        btnLuu.Size = New Size(94, 29)
        btnLuu.TabIndex = 4
        btnLuu.Text = "Lưu"
        btnLuu.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(415, 346)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(94, 29)
        btnThoat.TabIndex = 5
        btnThoat.Text = "Thoat"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(542, 386)
        Controls.Add(btnThoat)
        Controls.Add(btnLuu)
        Controls.Add(dgvBaoCao)
        Controls.Add(cobLoaiBaoCao)
        Controls.Add(lnBaoCao)
        Name = "Form4"
        Text = "Form4"
        CType(dgvBaoCao, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lnBaoCao As Label
    Friend WithEvents cobLoaiBaoCao As ComboBox
    Friend WithEvents dgvBaoCao As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnThoat As Button
End Class
