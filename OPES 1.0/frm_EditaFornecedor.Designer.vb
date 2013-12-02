<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editaFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editaFornecedor))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.txt_id2_edita = New System.Windows.Forms.TextBox()
        Me.pct_invalido = New System.Windows.Forms.PictureBox()
        Me.pct_valido = New System.Windows.Forms.PictureBox()
        Me.txt_cep_edita = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fax_edita = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefone_edita = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fax = New System.Windows.Forms.Label()
        Me.txt_ramal_edita = New System.Windows.Forms.TextBox()
        Me.lbl_ramal = New System.Windows.Forms.Label()
        Me.txt_fax_fornecedor = New System.Windows.Forms.TextBox()
        Me.txt_telefone_fornecedor = New System.Windows.Forms.TextBox()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cidade_edita = New System.Windows.Forms.TextBox()
        Me.txt_bairro_edita = New System.Windows.Forms.TextBox()
        Me.txt_endereco_edita = New System.Windows.Forms.TextBox()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.lbl_bairro = New System.Windows.Forms.Label()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.txt_cep_fornecedor = New System.Windows.Forms.TextBox()
        Me.txt_empresa_edita = New System.Windows.Forms.TextBox()
        Me.lbl_id2 = New System.Windows.Forms.Label()
        Me.lbl_empresa = New System.Windows.Forms.Label()
        Me.txt_uf_edita = New System.Windows.Forms.ComboBox()
        Me.lbl_CNPJ_oculto = New System.Windows.Forms.Label()
        CType(Me.pct_invalido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_valido, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_titulo.Size = New System.Drawing.Size(102, 20)
        Me.lbl_titulo.TabIndex = 45
        Me.lbl_titulo.Text = "Editar Dados"
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(488, 6)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 44
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(511, 6)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 43
        Me.btn_fechar.Text = "x"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(293, 306)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(71, 36)
        Me.btn_voltar.TabIndex = 67
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'btn_salvar
        '
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.Location = New System.Drawing.Point(216, 306)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(71, 36)
        Me.btn_salvar.TabIndex = 66
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'txt_id2_edita
        '
        Me.txt_id2_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id2_edita.Location = New System.Drawing.Point(156, 115)
        Me.txt_id2_edita.MaxLength = 18
        Me.txt_id2_edita.Name = "txt_id2_edita"
        Me.txt_id2_edita.Size = New System.Drawing.Size(117, 24)
        Me.txt_id2_edita.TabIndex = 70
        '
        'pct_invalido
        '
        Me.pct_invalido.Image = CType(resources.GetObject("pct_invalido.Image"), System.Drawing.Image)
        Me.pct_invalido.Location = New System.Drawing.Point(279, 117)
        Me.pct_invalido.Name = "pct_invalido"
        Me.pct_invalido.Size = New System.Drawing.Size(20, 20)
        Me.pct_invalido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_invalido.TabIndex = 92
        Me.pct_invalido.TabStop = False
        Me.pct_invalido.Visible = False
        '
        'pct_valido
        '
        Me.pct_valido.Image = CType(resources.GetObject("pct_valido.Image"), System.Drawing.Image)
        Me.pct_valido.Location = New System.Drawing.Point(280, 116)
        Me.pct_valido.Name = "pct_valido"
        Me.pct_valido.Size = New System.Drawing.Size(20, 20)
        Me.pct_valido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_valido.TabIndex = 91
        Me.pct_valido.TabStop = False
        Me.pct_valido.Visible = False
        '
        'txt_cep_edita
        '
        Me.txt_cep_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep_edita.Location = New System.Drawing.Point(373, 173)
        Me.txt_cep_edita.Mask = "00,000-000"
        Me.txt_cep_edita.Name = "txt_cep_edita"
        Me.txt_cep_edita.Size = New System.Drawing.Size(100, 24)
        Me.txt_cep_edita.TabIndex = 75
        '
        'txt_fax_edita
        '
        Me.txt_fax_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax_edita.Location = New System.Drawing.Point(156, 260)
        Me.txt_fax_edita.Mask = "(000) 000-0000"
        Me.txt_fax_edita.Name = "txt_fax_edita"
        Me.txt_fax_edita.Size = New System.Drawing.Size(144, 24)
        Me.txt_fax_edita.TabIndex = 78
        '
        'txt_telefone_edita
        '
        Me.txt_telefone_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone_edita.Location = New System.Drawing.Point(156, 232)
        Me.txt_telefone_edita.Mask = "(00) 0000-0000"
        Me.txt_telefone_edita.Name = "txt_telefone_edita"
        Me.txt_telefone_edita.Size = New System.Drawing.Size(144, 24)
        Me.txt_telefone_edita.TabIndex = 77
        '
        'lbl_fax
        '
        Me.lbl_fax.AutoSize = True
        Me.lbl_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fax.Location = New System.Drawing.Point(110, 262)
        Me.lbl_fax.Name = "lbl_fax"
        Me.lbl_fax.Size = New System.Drawing.Size(36, 18)
        Me.lbl_fax.TabIndex = 90
        Me.lbl_fax.Text = "Fax:"
        '
        'txt_ramal_edita
        '
        Me.txt_ramal_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ramal_edita.Location = New System.Drawing.Point(373, 232)
        Me.txt_ramal_edita.MaxLength = 5
        Me.txt_ramal_edita.Name = "txt_ramal_edita"
        Me.txt_ramal_edita.Size = New System.Drawing.Size(100, 24)
        Me.txt_ramal_edita.TabIndex = 79
        '
        'lbl_ramal
        '
        Me.lbl_ramal.AutoSize = True
        Me.lbl_ramal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ramal.Location = New System.Drawing.Point(309, 238)
        Me.lbl_ramal.Name = "lbl_ramal"
        Me.lbl_ramal.Size = New System.Drawing.Size(55, 18)
        Me.lbl_ramal.TabIndex = 89
        Me.lbl_ramal.Text = "Ramal:"
        '
        'txt_fax_fornecedor
        '
        Me.txt_fax_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax_fornecedor.Location = New System.Drawing.Point(156, 260)
        Me.txt_fax_fornecedor.MaxLength = 10
        Me.txt_fax_fornecedor.Name = "txt_fax_fornecedor"
        Me.txt_fax_fornecedor.Size = New System.Drawing.Size(100, 24)
        Me.txt_fax_fornecedor.TabIndex = 85
        '
        'txt_telefone_fornecedor
        '
        Me.txt_telefone_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone_fornecedor.Location = New System.Drawing.Point(156, 232)
        Me.txt_telefone_fornecedor.MaxLength = 11
        Me.txt_telefone_fornecedor.Name = "txt_telefone_fornecedor"
        Me.txt_telefone_fornecedor.Size = New System.Drawing.Size(100, 24)
        Me.txt_telefone_fornecedor.TabIndex = 83
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(82, 235)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(69, 18)
        Me.lbl_telefone.TabIndex = 88
        Me.lbl_telefone.Text = "Telefone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(332, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "UF:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "CEP:"
        '
        'txt_cidade_edita
        '
        Me.txt_cidade_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade_edita.Location = New System.Drawing.Point(156, 202)
        Me.txt_cidade_edita.Name = "txt_cidade_edita"
        Me.txt_cidade_edita.Size = New System.Drawing.Size(144, 24)
        Me.txt_cidade_edita.TabIndex = 74
        '
        'txt_bairro_edita
        '
        Me.txt_bairro_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro_edita.Location = New System.Drawing.Point(156, 173)
        Me.txt_bairro_edita.Name = "txt_bairro_edita"
        Me.txt_bairro_edita.Size = New System.Drawing.Size(144, 24)
        Me.txt_bairro_edita.TabIndex = 73
        '
        'txt_endereco_edita
        '
        Me.txt_endereco_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco_edita.Location = New System.Drawing.Point(156, 144)
        Me.txt_endereco_edita.Name = "txt_endereco_edita"
        Me.txt_endereco_edita.Size = New System.Drawing.Size(317, 24)
        Me.txt_endereco_edita.TabIndex = 72
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cidade.Location = New System.Drawing.Point(91, 205)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(58, 18)
        Me.lbl_cidade.TabIndex = 84
        Me.lbl_cidade.Text = "Cidade:"
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bairro.Location = New System.Drawing.Point(94, 176)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(52, 18)
        Me.lbl_bairro.TabIndex = 82
        Me.lbl_bairro.Text = "Bairro:"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_endereco.Location = New System.Drawing.Point(75, 147)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(76, 18)
        Me.lbl_endereco.TabIndex = 81
        Me.lbl_endereco.Text = "Endereço:"
        '
        'txt_cep_fornecedor
        '
        Me.txt_cep_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep_fornecedor.Location = New System.Drawing.Point(372, 172)
        Me.txt_cep_fornecedor.Name = "txt_cep_fornecedor"
        Me.txt_cep_fornecedor.Size = New System.Drawing.Size(100, 24)
        Me.txt_cep_fornecedor.TabIndex = 80
        '
        'txt_empresa_edita
        '
        Me.txt_empresa_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empresa_edita.Location = New System.Drawing.Point(156, 85)
        Me.txt_empresa_edita.Name = "txt_empresa_edita"
        Me.txt_empresa_edita.Size = New System.Drawing.Size(317, 24)
        Me.txt_empresa_edita.TabIndex = 69
        '
        'lbl_id2
        '
        Me.lbl_id2.AutoSize = True
        Me.lbl_id2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id2.Location = New System.Drawing.Point(94, 118)
        Me.lbl_id2.Name = "lbl_id2"
        Me.lbl_id2.Size = New System.Drawing.Size(52, 18)
        Me.lbl_id2.TabIndex = 71
        Me.lbl_id2.Text = "CNPJ:"
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresa.Location = New System.Drawing.Point(74, 88)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(72, 18)
        Me.lbl_empresa.TabIndex = 68
        Me.lbl_empresa.Text = "Empresa:"
        '
        'txt_uf_edita
        '
        Me.txt_uf_edita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_uf_edita.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf_edita.FormattingEnabled = True
        Me.txt_uf_edita.Items.AddRange(New Object() {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.txt_uf_edita.Location = New System.Drawing.Point(373, 202)
        Me.txt_uf_edita.Name = "txt_uf_edita"
        Me.txt_uf_edita.Size = New System.Drawing.Size(100, 26)
        Me.txt_uf_edita.TabIndex = 76
        '
        'lbl_CNPJ_oculto
        '
        Me.lbl_CNPJ_oculto.AutoSize = True
        Me.lbl_CNPJ_oculto.Location = New System.Drawing.Point(30, 202)
        Me.lbl_CNPJ_oculto.Name = "lbl_CNPJ_oculto"
        Me.lbl_CNPJ_oculto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_CNPJ_oculto.TabIndex = 93
        Me.lbl_CNPJ_oculto.Text = "Label3"
        Me.lbl_CNPJ_oculto.Visible = False
        '
        'frm_editaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(546, 369)
        Me.Controls.Add(Me.lbl_CNPJ_oculto)
        Me.Controls.Add(Me.txt_id2_edita)
        Me.Controls.Add(Me.pct_invalido)
        Me.Controls.Add(Me.pct_valido)
        Me.Controls.Add(Me.txt_cep_edita)
        Me.Controls.Add(Me.txt_uf_edita)
        Me.Controls.Add(Me.txt_fax_edita)
        Me.Controls.Add(Me.txt_telefone_edita)
        Me.Controls.Add(Me.lbl_fax)
        Me.Controls.Add(Me.txt_ramal_edita)
        Me.Controls.Add(Me.lbl_ramal)
        Me.Controls.Add(Me.txt_fax_fornecedor)
        Me.Controls.Add(Me.txt_telefone_fornecedor)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cidade_edita)
        Me.Controls.Add(Me.txt_bairro_edita)
        Me.Controls.Add(Me.txt_endereco_edita)
        Me.Controls.Add(Me.lbl_cidade)
        Me.Controls.Add(Me.lbl_bairro)
        Me.Controls.Add(Me.lbl_endereco)
        Me.Controls.Add(Me.txt_cep_fornecedor)
        Me.Controls.Add(Me.txt_empresa_edita)
        Me.Controls.Add(Me.lbl_id2)
        Me.Controls.Add(Me.lbl_empresa)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editaFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_editaFornecedor"
        CType(Me.pct_invalido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_valido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
    Friend WithEvents btn_salvar As System.Windows.Forms.Button
    Friend WithEvents txt_id2_edita As System.Windows.Forms.TextBox
    Friend WithEvents pct_invalido As System.Windows.Forms.PictureBox
    Friend WithEvents pct_valido As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cep_edita As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fax_edita As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telefone_edita As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_fax As System.Windows.Forms.Label
    Friend WithEvents txt_ramal_edita As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ramal As System.Windows.Forms.Label
    Friend WithEvents txt_fax_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefone_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefone As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cidade_edita As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro_edita As System.Windows.Forms.TextBox
    Friend WithEvents txt_endereco_edita As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cidade As System.Windows.Forms.Label
    Friend WithEvents lbl_bairro As System.Windows.Forms.Label
    Friend WithEvents lbl_endereco As System.Windows.Forms.Label
    Friend WithEvents txt_cep_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_empresa_edita As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id2 As System.Windows.Forms.Label
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents txt_uf_edita As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CNPJ_oculto As System.Windows.Forms.Label
End Class
