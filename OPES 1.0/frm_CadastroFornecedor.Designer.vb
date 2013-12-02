<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CadastroFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CadastroFornecedor))
        Me.lbl_empresa = New System.Windows.Forms.Label()
        Me.lbl_id2 = New System.Windows.Forms.Label()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.btn_cadastra = New System.Windows.Forms.Button()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_fax = New System.Windows.Forms.Label()
        Me.txt_ramal_fornecedor = New System.Windows.Forms.TextBox()
        Me.lbl_ramal = New System.Windows.Forms.Label()
        Me.txt_fax_fornecedor = New System.Windows.Forms.TextBox()
        Me.txt_telefone_fornecedor = New System.Windows.Forms.TextBox()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cidade_fornecedor = New System.Windows.Forms.TextBox()
        Me.txt_bairro_fornecedor = New System.Windows.Forms.TextBox()
        Me.txt_endedero_fornecedor = New System.Windows.Forms.TextBox()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.lbl_bairro = New System.Windows.Forms.Label()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.txt_cep_fornecedor = New System.Windows.Forms.TextBox()
        Me.msk_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.msk_fax = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_uf = New System.Windows.Forms.ComboBox()
        Me.msk_cep = New System.Windows.Forms.MaskedTextBox()
        Me.lst_cnpj = New System.Windows.Forms.ListBox()
        Me.btn_cnpj = New System.Windows.Forms.Button()
        Me.txt_cnpj = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresa.Location = New System.Drawing.Point(71, 79)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(72, 18)
        Me.lbl_empresa.TabIndex = 0
        Me.lbl_empresa.Text = "Empresa:"
        '
        'lbl_id2
        '
        Me.lbl_id2.AutoSize = True
        Me.lbl_id2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id2.Location = New System.Drawing.Point(91, 109)
        Me.lbl_id2.Name = "lbl_id2"
        Me.lbl_id2.Size = New System.Drawing.Size(52, 18)
        Me.lbl_id2.TabIndex = 2
        Me.lbl_id2.Text = "CNPJ:"
        '
        'txt_empresa
        '
        Me.txt_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empresa.Location = New System.Drawing.Point(153, 76)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(317, 24)
        Me.txt_empresa.TabIndex = 1
        '
        'btn_cadastra
        '
        Me.btn_cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra.Location = New System.Drawing.Point(129, 316)
        Me.btn_cadastra.Name = "btn_cadastra"
        Me.btn_cadastra.Size = New System.Drawing.Size(86, 31)
        Me.btn_cadastra.TabIndex = 11
        Me.btn_cadastra.Text = "Cadastrar"
        Me.btn_cadastra.UseVisualStyleBackColor = True
        '
        'btn_cancela
        '
        Me.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(232, 316)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(86, 31)
        Me.btn_cancela.TabIndex = 12
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.Location = New System.Drawing.Point(330, 316)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(86, 31)
        Me.btn_limpar.TabIndex = 13
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(504, 7)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 21
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(527, 7)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 20
        Me.btn_fechar.Text = "x"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 10)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(131, 20)
        Me.lbl_titulo.TabIndex = 22
        Me.lbl_titulo.Text = "Novo Fornecedor"
        '
        'lbl_fax
        '
        Me.lbl_fax.AutoSize = True
        Me.lbl_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fax.Location = New System.Drawing.Point(107, 253)
        Me.lbl_fax.Name = "lbl_fax"
        Me.lbl_fax.Size = New System.Drawing.Size(36, 18)
        Me.lbl_fax.TabIndex = 38
        Me.lbl_fax.Text = "Fax:"
        '
        'txt_ramal_fornecedor
        '
        Me.txt_ramal_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ramal_fornecedor.Location = New System.Drawing.Point(370, 223)
        Me.txt_ramal_fornecedor.MaxLength = 5
        Me.txt_ramal_fornecedor.Name = "txt_ramal_fornecedor"
        Me.txt_ramal_fornecedor.Size = New System.Drawing.Size(100, 24)
        Me.txt_ramal_fornecedor.TabIndex = 10
        '
        'lbl_ramal
        '
        Me.lbl_ramal.AutoSize = True
        Me.lbl_ramal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ramal.Location = New System.Drawing.Point(306, 229)
        Me.lbl_ramal.Name = "lbl_ramal"
        Me.lbl_ramal.Size = New System.Drawing.Size(55, 18)
        Me.lbl_ramal.TabIndex = 37
        Me.lbl_ramal.Text = "Ramal:"
        '
        'txt_fax_fornecedor
        '
        Me.txt_fax_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax_fornecedor.Location = New System.Drawing.Point(153, 251)
        Me.txt_fax_fornecedor.MaxLength = 10
        Me.txt_fax_fornecedor.Name = "txt_fax_fornecedor"
        Me.txt_fax_fornecedor.Size = New System.Drawing.Size(100, 24)
        Me.txt_fax_fornecedor.TabIndex = 33
        '
        'txt_telefone_fornecedor
        '
        Me.txt_telefone_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone_fornecedor.Location = New System.Drawing.Point(153, 223)
        Me.txt_telefone_fornecedor.MaxLength = 11
        Me.txt_telefone_fornecedor.Name = "txt_telefone_fornecedor"
        Me.txt_telefone_fornecedor.Size = New System.Drawing.Size(100, 24)
        Me.txt_telefone_fornecedor.TabIndex = 30
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(79, 226)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(69, 18)
        Me.lbl_telefone.TabIndex = 36
        Me.lbl_telefone.Text = "Telefone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "UF:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "CEP:"
        '
        'txt_cidade_fornecedor
        '
        Me.txt_cidade_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade_fornecedor.Location = New System.Drawing.Point(153, 193)
        Me.txt_cidade_fornecedor.Name = "txt_cidade_fornecedor"
        Me.txt_cidade_fornecedor.Size = New System.Drawing.Size(144, 24)
        Me.txt_cidade_fornecedor.TabIndex = 5
        '
        'txt_bairro_fornecedor
        '
        Me.txt_bairro_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro_fornecedor.Location = New System.Drawing.Point(153, 164)
        Me.txt_bairro_fornecedor.Name = "txt_bairro_fornecedor"
        Me.txt_bairro_fornecedor.Size = New System.Drawing.Size(144, 24)
        Me.txt_bairro_fornecedor.TabIndex = 4
        '
        'txt_endedero_fornecedor
        '
        Me.txt_endedero_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endedero_fornecedor.Location = New System.Drawing.Point(153, 135)
        Me.txt_endedero_fornecedor.Name = "txt_endedero_fornecedor"
        Me.txt_endedero_fornecedor.Size = New System.Drawing.Size(317, 24)
        Me.txt_endedero_fornecedor.TabIndex = 3
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cidade.Location = New System.Drawing.Point(88, 196)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(58, 18)
        Me.lbl_cidade.TabIndex = 32
        Me.lbl_cidade.Text = "Cidade:"
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bairro.Location = New System.Drawing.Point(91, 167)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(52, 18)
        Me.lbl_bairro.TabIndex = 29
        Me.lbl_bairro.Text = "Bairro:"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_endereco.Location = New System.Drawing.Point(72, 138)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(76, 18)
        Me.lbl_endereco.TabIndex = 27
        Me.lbl_endereco.Text = "Endereço:"
        '
        'txt_cep_fornecedor
        '
        Me.txt_cep_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep_fornecedor.Location = New System.Drawing.Point(369, 163)
        Me.txt_cep_fornecedor.Name = "txt_cep_fornecedor"
        Me.txt_cep_fornecedor.Size = New System.Drawing.Size(100, 24)
        Me.txt_cep_fornecedor.TabIndex = 25
        '
        'msk_telefone
        '
        Me.msk_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_telefone.Location = New System.Drawing.Point(153, 223)
        Me.msk_telefone.Mask = "(00) 0000-0000"
        Me.msk_telefone.Name = "msk_telefone"
        Me.msk_telefone.Size = New System.Drawing.Size(144, 24)
        Me.msk_telefone.TabIndex = 8
        '
        'msk_fax
        '
        Me.msk_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_fax.Location = New System.Drawing.Point(153, 251)
        Me.msk_fax.Mask = "(00) 0000-0000"
        Me.msk_fax.Name = "msk_fax"
        Me.msk_fax.Size = New System.Drawing.Size(144, 24)
        Me.msk_fax.TabIndex = 9
        '
        'cmb_uf
        '
        Me.cmb_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_uf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_uf.FormattingEnabled = True
        Me.cmb_uf.Items.AddRange(New Object() {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cmb_uf.Location = New System.Drawing.Point(370, 193)
        Me.cmb_uf.Name = "cmb_uf"
        Me.cmb_uf.Size = New System.Drawing.Size(100, 26)
        Me.cmb_uf.TabIndex = 7
        '
        'msk_cep
        '
        Me.msk_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_cep.Location = New System.Drawing.Point(370, 164)
        Me.msk_cep.Mask = "00,000-000"
        Me.msk_cep.Name = "msk_cep"
        Me.msk_cep.Size = New System.Drawing.Size(100, 24)
        Me.msk_cep.TabIndex = 6
        '
        'lst_cnpj
        '
        Me.lst_cnpj.FormattingEnabled = True
        Me.lst_cnpj.Items.AddRange(New Object() {"31.565.104/0293-10"})
        Me.lst_cnpj.Location = New System.Drawing.Point(12, 125)
        Me.lst_cnpj.Name = "lst_cnpj"
        Me.lst_cnpj.Size = New System.Drawing.Size(74, 160)
        Me.lst_cnpj.TabIndex = 44
        Me.lst_cnpj.Visible = False
        '
        'btn_cnpj
        '
        Me.btn_cnpj.Location = New System.Drawing.Point(27, 316)
        Me.btn_cnpj.Name = "btn_cnpj"
        Me.btn_cnpj.Size = New System.Drawing.Size(68, 22)
        Me.btn_cnpj.TabIndex = 45
        Me.btn_cnpj.Text = "Button1"
        Me.btn_cnpj.UseVisualStyleBackColor = True
        Me.btn_cnpj.Visible = False
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cnpj.Location = New System.Drawing.Point(153, 106)
        Me.txt_cnpj.MaxLength = 18
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(144, 24)
        Me.txt_cnpj.TabIndex = 2
        '
        'frm_CadastroFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(557, 368)
        Me.Controls.Add(Me.txt_cnpj)
        Me.Controls.Add(Me.btn_cnpj)
        Me.Controls.Add(Me.lst_cnpj)
        Me.Controls.Add(Me.msk_cep)
        Me.Controls.Add(Me.cmb_uf)
        Me.Controls.Add(Me.msk_fax)
        Me.Controls.Add(Me.msk_telefone)
        Me.Controls.Add(Me.lbl_fax)
        Me.Controls.Add(Me.txt_ramal_fornecedor)
        Me.Controls.Add(Me.lbl_ramal)
        Me.Controls.Add(Me.txt_fax_fornecedor)
        Me.Controls.Add(Me.txt_telefone_fornecedor)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cidade_fornecedor)
        Me.Controls.Add(Me.txt_bairro_fornecedor)
        Me.Controls.Add(Me.txt_endedero_fornecedor)
        Me.Controls.Add(Me.lbl_cidade)
        Me.Controls.Add(Me.lbl_bairro)
        Me.Controls.Add(Me.lbl_endereco)
        Me.Controls.Add(Me.txt_cep_fornecedor)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_cancela)
        Me.Controls.Add(Me.btn_cadastra)
        Me.Controls.Add(Me.txt_empresa)
        Me.Controls.Add(Me.lbl_id2)
        Me.Controls.Add(Me.lbl_empresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CadastroFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fornecedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents lbl_id2 As System.Windows.Forms.Label
    Friend WithEvents txt_empresa As System.Windows.Forms.TextBox
    Friend WithEvents btn_cadastra As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_limpar As System.Windows.Forms.Button
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_fax As System.Windows.Forms.Label
    Friend WithEvents txt_ramal_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ramal As System.Windows.Forms.Label
    Friend WithEvents txt_fax_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefone_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefone As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cidade_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_endedero_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cidade As System.Windows.Forms.Label
    Friend WithEvents lbl_bairro As System.Windows.Forms.Label
    Friend WithEvents lbl_endereco As System.Windows.Forms.Label
    Friend WithEvents txt_cep_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents msk_telefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msk_fax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_uf As System.Windows.Forms.ComboBox
    Friend WithEvents msk_cep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lst_cnpj As System.Windows.Forms.ListBox
    Friend WithEvents btn_cnpj As System.Windows.Forms.Button
    Friend WithEvents txt_cnpj As System.Windows.Forms.TextBox
End Class
