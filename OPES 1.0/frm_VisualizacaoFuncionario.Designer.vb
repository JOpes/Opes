<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisualizacaoFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VisualizacaoFuncionario))
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_dtnascimento = New System.Windows.Forms.Label()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_funcao = New System.Windows.Forms.Label()
        Me.lbl_setor = New System.Windows.Forms.Label()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_nascimento = New System.Windows.Forms.TextBox()
        Me.txt_função = New System.Windows.Forms.TextBox()
        Me.txt_setor = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_sexo = New System.Windows.Forms.TextBox()
        Me.lbl_historico = New System.Windows.Forms.Label()
        Me.lst_historico = New System.Windows.Forms.ListBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.lbl_faltas = New System.Windows.Forms.Label()
        Me.lst_faltas = New System.Windows.Forms.ListBox()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.msk_nascimento = New System.Windows.Forms.MaskedTextBox()
        Me.msk_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matricula.Location = New System.Drawing.Point(88, 66)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(72, 18)
        Me.lbl_matricula.TabIndex = 0
        Me.lbl_matricula.Text = "Matrícula:"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(359, 67)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(53, 18)
        Me.lbl_nome.TabIndex = 1
        Me.lbl_nome.Text = "Nome:"
        '
        'lbl_dtnascimento
        '
        Me.lbl_dtnascimento.AutoSize = True
        Me.lbl_dtnascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dtnascimento.Location = New System.Drawing.Point(13, 97)
        Me.lbl_dtnascimento.Name = "lbl_dtnascimento"
        Me.lbl_dtnascimento.Size = New System.Drawing.Size(147, 18)
        Me.lbl_dtnascimento.TabIndex = 2
        Me.lbl_dtnascimento.Text = "Data de Nascimento:"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.Location = New System.Drawing.Point(363, 95)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(46, 18)
        Me.lbl_sexo.TabIndex = 3
        Me.lbl_sexo.Text = "Sexo:"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(118, 125)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(42, 18)
        Me.lbl_cpf.TabIndex = 4
        Me.lbl_cpf.Text = "CPF:"
        '
        'lbl_funcao
        '
        Me.lbl_funcao.AutoSize = True
        Me.lbl_funcao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_funcao.Location = New System.Drawing.Point(98, 154)
        Me.lbl_funcao.Name = "lbl_funcao"
        Me.lbl_funcao.Size = New System.Drawing.Size(62, 18)
        Me.lbl_funcao.TabIndex = 5
        Me.lbl_funcao.Text = "Função:"
        '
        'lbl_setor
        '
        Me.lbl_setor.AutoSize = True
        Me.lbl_setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_setor.Location = New System.Drawing.Point(112, 178)
        Me.lbl_setor.Name = "lbl_setor"
        Me.lbl_setor.Size = New System.Drawing.Size(48, 18)
        Me.lbl_setor.TabIndex = 6
        Me.lbl_setor.Text = "Setor:"
        '
        'txt_matricula
        '
        Me.txt_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(172, 66)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.ReadOnly = True
        Me.txt_matricula.Size = New System.Drawing.Size(100, 24)
        Me.txt_matricula.TabIndex = 7
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(172, 122)
        Me.txt_cpf.MaxLength = 11
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.ReadOnly = True
        Me.txt_cpf.Size = New System.Drawing.Size(100, 24)
        Me.txt_cpf.TabIndex = 7
        '
        'txt_nascimento
        '
        Me.txt_nascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nascimento.Location = New System.Drawing.Point(172, 94)
        Me.txt_nascimento.MaxLength = 8
        Me.txt_nascimento.Name = "txt_nascimento"
        Me.txt_nascimento.ReadOnly = True
        Me.txt_nascimento.Size = New System.Drawing.Size(100, 24)
        Me.txt_nascimento.TabIndex = 7
        '
        'txt_função
        '
        Me.txt_função.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_função.Location = New System.Drawing.Point(172, 151)
        Me.txt_função.Name = "txt_função"
        Me.txt_função.ReadOnly = True
        Me.txt_função.Size = New System.Drawing.Size(168, 24)
        Me.txt_função.TabIndex = 7
        '
        'txt_setor
        '
        Me.txt_setor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_setor.Location = New System.Drawing.Point(172, 178)
        Me.txt_setor.Name = "txt_setor"
        Me.txt_setor.ReadOnly = True
        Me.txt_setor.Size = New System.Drawing.Size(168, 24)
        Me.txt_setor.TabIndex = 7
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(418, 64)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.ReadOnly = True
        Me.txt_nome.Size = New System.Drawing.Size(200, 24)
        Me.txt_nome.TabIndex = 7
        '
        'txt_sexo
        '
        Me.txt_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sexo.Location = New System.Drawing.Point(418, 91)
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.ReadOnly = True
        Me.txt_sexo.Size = New System.Drawing.Size(200, 24)
        Me.txt_sexo.TabIndex = 7
        '
        'lbl_historico
        '
        Me.lbl_historico.AutoSize = True
        Me.lbl_historico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_historico.Location = New System.Drawing.Point(56, 214)
        Me.lbl_historico.Name = "lbl_historico"
        Me.lbl_historico.Size = New System.Drawing.Size(187, 18)
        Me.lbl_historico.TabIndex = 8
        Me.lbl_historico.Text = "Histórico de Capacitações:"
        '
        'lst_historico
        '
        Me.lst_historico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_historico.FormattingEnabled = True
        Me.lst_historico.ItemHeight = 18
        Me.lst_historico.Location = New System.Drawing.Point(59, 245)
        Me.lst_historico.Name = "lst_historico"
        Me.lst_historico.Size = New System.Drawing.Size(559, 94)
        Me.lst_historico.TabIndex = 9
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(545, 450)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(73, 35)
        Me.btn_voltar.TabIndex = 10
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'lbl_faltas
        '
        Me.lbl_faltas.AutoSize = True
        Me.lbl_faltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_faltas.Location = New System.Drawing.Point(56, 354)
        Me.lbl_faltas.Name = "lbl_faltas"
        Me.lbl_faltas.Size = New System.Drawing.Size(136, 18)
        Me.lbl_faltas.TabIndex = 11
        Me.lbl_faltas.Text = "Histórico de Faltas:"
        '
        'lst_faltas
        '
        Me.lst_faltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_faltas.FormattingEnabled = True
        Me.lst_faltas.ItemHeight = 18
        Me.lst_faltas.Location = New System.Drawing.Point(59, 386)
        Me.lst_faltas.Name = "lst_faltas"
        Me.lst_faltas.Size = New System.Drawing.Size(559, 58)
        Me.lst_faltas.TabIndex = 12
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(602, 6)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 14
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(625, 6)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 13
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
        Me.lbl_titulo.Size = New System.Drawing.Size(107, 20)
        Me.lbl_titulo.TabIndex = 15
        Me.lbl_titulo.Text = "Funcionário X"
        '
        'msk_nascimento
        '
        Me.msk_nascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_nascimento.Location = New System.Drawing.Point(172, 94)
        Me.msk_nascimento.Mask = "00/00/0000"
        Me.msk_nascimento.Name = "msk_nascimento"
        Me.msk_nascimento.ReadOnly = True
        Me.msk_nascimento.Size = New System.Drawing.Size(100, 24)
        Me.msk_nascimento.TabIndex = 16
        Me.msk_nascimento.ValidatingType = GetType(Date)
        '
        'msk_cpf
        '
        Me.msk_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_cpf.Location = New System.Drawing.Point(172, 122)
        Me.msk_cpf.Mask = "000,000,000-00"
        Me.msk_cpf.Name = "msk_cpf"
        Me.msk_cpf.ReadOnly = True
        Me.msk_cpf.Size = New System.Drawing.Size(168, 24)
        Me.msk_cpf.TabIndex = 17
        '
        'frm_VisualizacaoFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(662, 497)
        Me.Controls.Add(Me.msk_cpf)
        Me.Controls.Add(Me.msk_nascimento)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.lst_faltas)
        Me.Controls.Add(Me.lbl_faltas)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lst_historico)
        Me.Controls.Add(Me.lbl_historico)
        Me.Controls.Add(Me.txt_nascimento)
        Me.Controls.Add(Me.txt_sexo)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_setor)
        Me.Controls.Add(Me.txt_função)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.lbl_setor)
        Me.Controls.Add(Me.lbl_funcao)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.lbl_dtnascimento)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_matricula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_VisualizacaoFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionário X"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_nome As System.Windows.Forms.Label
    Friend WithEvents lbl_dtnascimento As System.Windows.Forms.Label
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_cpf As System.Windows.Forms.Label
    Friend WithEvents lbl_funcao As System.Windows.Forms.Label
    Friend WithEvents lbl_setor As System.Windows.Forms.Label
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents txt_cpf As System.Windows.Forms.TextBox
    Friend WithEvents txt_nascimento As System.Windows.Forms.TextBox
    Friend WithEvents txt_função As System.Windows.Forms.TextBox
    Friend WithEvents txt_setor As System.Windows.Forms.TextBox
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents txt_sexo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_historico As System.Windows.Forms.Label
    Friend WithEvents lst_historico As System.Windows.Forms.ListBox
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
    Friend WithEvents lbl_faltas As System.Windows.Forms.Label
    Friend WithEvents lst_faltas As System.Windows.Forms.ListBox
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents msk_nascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msk_cpf As System.Windows.Forms.MaskedTextBox
End Class
