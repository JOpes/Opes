<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consultaFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consultaFornecedor))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.txt_pesquisa_fornecedor = New System.Windows.Forms.TextBox()
        Me.lbl_pesquisa = New System.Windows.Forms.Label()
        Me.cmb_criterio_pesquisa_fornecedor = New System.Windows.Forms.ComboBox()
        Me.lbl_criterio = New System.Windows.Forms.Label()
        Me.lst_pesquisa_fornecedor = New System.Windows.Forms.ListBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(158, 20)
        Me.lbl_titulo.TabIndex = 38
        Me.lbl_titulo.Text = "Consulta Fornecedor"
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(520, 7)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 40
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(543, 7)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 39
        Me.btn_fechar.Text = "x"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'txt_pesquisa_fornecedor
        '
        Me.txt_pesquisa_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa_fornecedor.Location = New System.Drawing.Point(197, 132)
        Me.txt_pesquisa_fornecedor.Name = "txt_pesquisa_fornecedor"
        Me.txt_pesquisa_fornecedor.Size = New System.Drawing.Size(161, 24)
        Me.txt_pesquisa_fornecedor.TabIndex = 2
        '
        'lbl_pesquisa
        '
        Me.lbl_pesquisa.AutoSize = True
        Me.lbl_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesquisa.Location = New System.Drawing.Point(194, 111)
        Me.lbl_pesquisa.Name = "lbl_pesquisa"
        Me.lbl_pesquisa.Size = New System.Drawing.Size(73, 18)
        Me.lbl_pesquisa.TabIndex = 43
        Me.lbl_pesquisa.Text = "Pesquisa:"
        '
        'cmb_criterio_pesquisa_fornecedor
        '
        Me.cmb_criterio_pesquisa_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_criterio_pesquisa_fornecedor.FormattingEnabled = True
        Me.cmb_criterio_pesquisa_fornecedor.Items.AddRange(New Object() {"Nome", "CNPJ", "UF"})
        Me.cmb_criterio_pesquisa_fornecedor.Location = New System.Drawing.Point(197, 79)
        Me.cmb_criterio_pesquisa_fornecedor.Name = "cmb_criterio_pesquisa_fornecedor"
        Me.cmb_criterio_pesquisa_fornecedor.Size = New System.Drawing.Size(161, 26)
        Me.cmb_criterio_pesquisa_fornecedor.TabIndex = 1
        '
        'lbl_criterio
        '
        Me.lbl_criterio.AutoSize = True
        Me.lbl_criterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_criterio.Location = New System.Drawing.Point(194, 58)
        Me.lbl_criterio.Name = "lbl_criterio"
        Me.lbl_criterio.Size = New System.Drawing.Size(145, 18)
        Me.lbl_criterio.TabIndex = 41
        Me.lbl_criterio.Text = "Critério de Pesquisa:"
        '
        'lst_pesquisa_fornecedor
        '
        Me.lst_pesquisa_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_pesquisa_fornecedor.FormattingEnabled = True
        Me.lst_pesquisa_fornecedor.ItemHeight = 18
        Me.lst_pesquisa_fornecedor.Items.AddRange(New Object() {"Tzusk Co."})
        Me.lst_pesquisa_fornecedor.Location = New System.Drawing.Point(49, 173)
        Me.lst_pesquisa_fornecedor.Name = "lst_pesquisa_fornecedor"
        Me.lst_pesquisa_fornecedor.Size = New System.Drawing.Size(480, 202)
        Me.lst_pesquisa_fornecedor.TabIndex = 3
        '
        'btn_consultar
        '
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar.Location = New System.Drawing.Point(330, 385)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(96, 33)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(433, 385)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(96, 33)
        Me.btn_voltar.TabIndex = 5
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'frm_consultaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(574, 430)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.lst_pesquisa_fornecedor)
        Me.Controls.Add(Me.txt_pesquisa_fornecedor)
        Me.Controls.Add(Me.lbl_pesquisa)
        Me.Controls.Add(Me.cmb_criterio_pesquisa_fornecedor)
        Me.Controls.Add(Me.lbl_criterio)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_consultaFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_consultaFornecedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents txt_pesquisa_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pesquisa As System.Windows.Forms.Label
    Friend WithEvents cmb_criterio_pesquisa_fornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_criterio As System.Windows.Forms.Label
    Friend WithEvents lst_pesquisa_fornecedor As System.Windows.Forms.ListBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
End Class
