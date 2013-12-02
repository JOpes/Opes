<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisualizaFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VisualizaFornecedor))
        Me.lbl_fax = New System.Windows.Forms.Label()
        Me.txt_ramal = New System.Windows.Forms.TextBox()
        Me.lbl_ramal = New System.Windows.Forms.Label()
        Me.txt_fax = New System.Windows.Forms.TextBox()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.lbl_bairro = New System.Windows.Forms.Label()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.txt_cep = New System.Windows.Forms.TextBox()
        Me.lbl_id2 = New System.Windows.Forms.Label()
        Me.lbl_empresa = New System.Windows.Forms.Label()
        Me.lbl_capfornecidas = New System.Windows.Forms.Label()
        Me.lst_fornecidas = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.msk_cnpj = New System.Windows.Forms.MaskedTextBox()
        Me.txt_id2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_fax
        '
        Me.lbl_fax.AutoSize = True
        Me.lbl_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fax.Location = New System.Drawing.Point(81, 255)
        Me.lbl_fax.Name = "lbl_fax"
        Me.lbl_fax.Size = New System.Drawing.Size(36, 18)
        Me.lbl_fax.TabIndex = 36
        Me.lbl_fax.Text = "Fax:"
        '
        'txt_ramal
        '
        Me.txt_ramal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ramal.Location = New System.Drawing.Point(360, 222)
        Me.txt_ramal.Name = "txt_ramal"
        Me.txt_ramal.ReadOnly = True
        Me.txt_ramal.Size = New System.Drawing.Size(100, 24)
        Me.txt_ramal.TabIndex = 35
        '
        'lbl_ramal
        '
        Me.lbl_ramal.AutoSize = True
        Me.lbl_ramal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ramal.Location = New System.Drawing.Point(299, 225)
        Me.lbl_ramal.Name = "lbl_ramal"
        Me.lbl_ramal.Size = New System.Drawing.Size(55, 18)
        Me.lbl_ramal.TabIndex = 34
        Me.lbl_ramal.Text = "Ramal:"
        '
        'txt_fax
        '
        Me.txt_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax.Location = New System.Drawing.Point(139, 252)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.ReadOnly = True
        Me.txt_fax.Size = New System.Drawing.Size(144, 24)
        Me.txt_fax.TabIndex = 32
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(139, 222)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.ReadOnly = True
        Me.txt_telefone.Size = New System.Drawing.Size(144, 24)
        Me.txt_telefone.TabIndex = 33
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(59, 225)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(69, 18)
        Me.lbl_telefone.TabIndex = 31
        Me.lbl_telefone.Text = "Telefone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "UF:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "CEP:"
        '
        'txt_cidade
        '
        Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(139, 193)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.ReadOnly = True
        Me.txt_cidade.Size = New System.Drawing.Size(144, 24)
        Me.txt_cidade.TabIndex = 27
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(139, 164)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.ReadOnly = True
        Me.txt_bairro.Size = New System.Drawing.Size(144, 24)
        Me.txt_bairro.TabIndex = 25
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(139, 135)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.ReadOnly = True
        Me.txt_endereco.Size = New System.Drawing.Size(321, 24)
        Me.txt_endereco.TabIndex = 26
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cidade.Location = New System.Drawing.Point(68, 196)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(58, 18)
        Me.lbl_cidade.TabIndex = 24
        Me.lbl_cidade.Text = "Cidade:"
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bairro.Location = New System.Drawing.Point(71, 167)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(52, 18)
        Me.lbl_bairro.TabIndex = 23
        Me.lbl_bairro.Text = "Bairro:"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_endereco.Location = New System.Drawing.Point(52, 138)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(76, 18)
        Me.lbl_endereco.TabIndex = 22
        Me.lbl_endereco.Text = "Endereço:"
        '
        'txt_empresa
        '
        Me.txt_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empresa.Location = New System.Drawing.Point(139, 70)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.ReadOnly = True
        Me.txt_empresa.Size = New System.Drawing.Size(321, 24)
        Me.txt_empresa.TabIndex = 21
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(360, 164)
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.ReadOnly = True
        Me.txt_cep.Size = New System.Drawing.Size(100, 24)
        Me.txt_cep.TabIndex = 19
        '
        'lbl_id2
        '
        Me.lbl_id2.AutoSize = True
        Me.lbl_id2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id2.Location = New System.Drawing.Point(71, 99)
        Me.lbl_id2.Name = "lbl_id2"
        Me.lbl_id2.Size = New System.Drawing.Size(52, 18)
        Me.lbl_id2.TabIndex = 18
        Me.lbl_id2.Text = "CNPJ:"
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresa.Location = New System.Drawing.Point(57, 73)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(72, 18)
        Me.lbl_empresa.TabIndex = 17
        Me.lbl_empresa.Text = "Empresa:"
        '
        'lbl_capfornecidas
        '
        Me.lbl_capfornecidas.AutoSize = True
        Me.lbl_capfornecidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capfornecidas.Location = New System.Drawing.Point(59, 307)
        Me.lbl_capfornecidas.Name = "lbl_capfornecidas"
        Me.lbl_capfornecidas.Size = New System.Drawing.Size(181, 18)
        Me.lbl_capfornecidas.TabIndex = 37
        Me.lbl_capfornecidas.Text = "Capacitações Fornecidas:"
        '
        'lst_fornecidas
        '
        Me.lst_fornecidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_fornecidas.FormattingEnabled = True
        Me.lst_fornecidas.ItemHeight = 18
        Me.lst_fornecidas.Location = New System.Drawing.Point(60, 328)
        Me.lst_fornecidas.Name = "lst_fornecidas"
        Me.lst_fornecidas.Size = New System.Drawing.Size(400, 94)
        Me.lst_fornecidas.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(304, 428)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(470, 6)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 41
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(493, 6)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 40
        Me.btn_fechar.Text = "x"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(91, 20)
        Me.lbl_titulo.TabIndex = 42
        Me.lbl_titulo.Text = "Fornecedor"
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(385, 428)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 33)
        Me.btn_voltar.TabIndex = 43
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'txt_uf
        '
        Me.txt_uf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.Location = New System.Drawing.Point(360, 193)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.ReadOnly = True
        Me.txt_uf.Size = New System.Drawing.Size(100, 24)
        Me.txt_uf.TabIndex = 44
        '
        'msk_cnpj
        '
        Me.msk_cnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_cnpj.Location = New System.Drawing.Point(139, 96)
        Me.msk_cnpj.Mask = "00,000,000/0000-00"
        Me.msk_cnpj.Name = "msk_cnpj"
        Me.msk_cnpj.ReadOnly = True
        Me.msk_cnpj.Size = New System.Drawing.Size(144, 24)
        Me.msk_cnpj.TabIndex = 70
        '
        'txt_id2
        '
        Me.txt_id2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id2.Location = New System.Drawing.Point(139, 96)
        Me.txt_id2.MaxLength = 14
        Me.txt_id2.Name = "txt_id2"
        Me.txt_id2.ReadOnly = True
        Me.txt_id2.Size = New System.Drawing.Size(100, 24)
        Me.txt_id2.TabIndex = 20
        '
        'frm_VisualizaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 473)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lst_fornecidas)
        Me.Controls.Add(Me.lbl_capfornecidas)
        Me.Controls.Add(Me.lbl_fax)
        Me.Controls.Add(Me.txt_ramal)
        Me.Controls.Add(Me.lbl_ramal)
        Me.Controls.Add(Me.txt_fax)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.lbl_cidade)
        Me.Controls.Add(Me.lbl_bairro)
        Me.Controls.Add(Me.lbl_endereco)
        Me.Controls.Add(Me.txt_empresa)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.lbl_id2)
        Me.Controls.Add(Me.lbl_empresa)
        Me.Controls.Add(Me.msk_cnpj)
        Me.Controls.Add(Me.txt_id2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_VisualizaFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedor X"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_fax As System.Windows.Forms.Label
    Friend WithEvents txt_ramal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ramal As System.Windows.Forms.Label
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefone As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefone As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cidade As System.Windows.Forms.TextBox
    Friend WithEvents txt_bairro As System.Windows.Forms.TextBox
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cidade As System.Windows.Forms.Label
    Friend WithEvents lbl_bairro As System.Windows.Forms.Label
    Friend WithEvents lbl_endereco As System.Windows.Forms.Label
    Friend WithEvents txt_empresa As System.Windows.Forms.TextBox
    Friend WithEvents txt_cep As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id2 As System.Windows.Forms.Label
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents lbl_capfornecidas As System.Windows.Forms.Label
    Friend WithEvents lst_fornecidas As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
    Friend WithEvents txt_uf As System.Windows.Forms.TextBox
    Friend WithEvents msk_cnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_id2 As System.Windows.Forms.TextBox
End Class
