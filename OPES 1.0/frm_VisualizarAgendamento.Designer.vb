<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisualizarAgendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VisualizarAgendamento))
        Me.dtt_criacao = New System.Windows.Forms.DateTimePicker()
        Me.txt_cargahoraria = New System.Windows.Forms.TextBox()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.txt_capacitacao = New System.Windows.Forms.TextBox()
        Me.txt_codigo_cap = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_cargahoraria = New System.Windows.Forms.Label()
        Me.lbl_descricao = New System.Windows.Forms.Label()
        Me.lbl_capacitacao = New System.Windows.Forms.Label()
        Me.lbl_codigo_cap = New System.Windows.Forms.Label()
        Me.ftt_termino = New System.Windows.Forms.DateTimePicker()
        Me.dtt_incio = New System.Windows.Forms.DateTimePicker()
        Me.lbl_data_termino = New System.Windows.Forms.Label()
        Me.lbl_data_inicio = New System.Windows.Forms.Label()
        Me.txt_instrutor = New System.Windows.Forms.TextBox()
        Me.lbl_fornecedor = New System.Windows.Forms.Label()
        Me.txt_fornecedor = New System.Windows.Forms.TextBox()
        Me.lbl_instrutor = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.lbl_validade = New System.Windows.Forms.Label()
        Me.txt_validade = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.lst_funcionario = New System.Windows.Forms.ListBox()
        Me.lbl_funcionario = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtt_criacao
        '
        Me.dtt_criacao.Enabled = False
        Me.dtt_criacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtt_criacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtt_criacao.Location = New System.Drawing.Point(162, 222)
        Me.dtt_criacao.Name = "dtt_criacao"
        Me.dtt_criacao.Size = New System.Drawing.Size(100, 24)
        Me.dtt_criacao.TabIndex = 31
        Me.dtt_criacao.Value = New Date(2013, 11, 13, 17, 56, 3, 0)
        '
        'txt_cargahoraria
        '
        Me.txt_cargahoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cargahoraria.Location = New System.Drawing.Point(162, 195)
        Me.txt_cargahoraria.Name = "txt_cargahoraria"
        Me.txt_cargahoraria.ReadOnly = True
        Me.txt_cargahoraria.Size = New System.Drawing.Size(100, 24)
        Me.txt_cargahoraria.TabIndex = 30
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(162, 125)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.ReadOnly = True
        Me.txt_descricao.Size = New System.Drawing.Size(205, 40)
        Me.txt_descricao.TabIndex = 29
        '
        'txt_capacitacao
        '
        Me.txt_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_capacitacao.Location = New System.Drawing.Point(162, 98)
        Me.txt_capacitacao.Name = "txt_capacitacao"
        Me.txt_capacitacao.ReadOnly = True
        Me.txt_capacitacao.Size = New System.Drawing.Size(206, 24)
        Me.txt_capacitacao.TabIndex = 28
        '
        'txt_codigo_cap
        '
        Me.txt_codigo_cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_cap.Location = New System.Drawing.Point(162, 71)
        Me.txt_codigo_cap.Name = "txt_codigo_cap"
        Me.txt_codigo_cap.ReadOnly = True
        Me.txt_codigo_cap.Size = New System.Drawing.Size(99, 24)
        Me.txt_codigo_cap.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Data de Criação:"
        '
        'lbl_cargahoraria
        '
        Me.lbl_cargahoraria.AutoSize = True
        Me.lbl_cargahoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cargahoraria.Location = New System.Drawing.Point(35, 198)
        Me.lbl_cargahoraria.Name = "lbl_cargahoraria"
        Me.lbl_cargahoraria.Size = New System.Drawing.Size(105, 18)
        Me.lbl_cargahoraria.TabIndex = 26
        Me.lbl_cargahoraria.Text = "Carga Horária:"
        '
        'lbl_descricao
        '
        Me.lbl_descricao.AutoSize = True
        Me.lbl_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descricao.Location = New System.Drawing.Point(59, 128)
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.Size = New System.Drawing.Size(80, 18)
        Me.lbl_descricao.TabIndex = 24
        Me.lbl_descricao.Text = "Descrição:"
        '
        'lbl_capacitacao
        '
        Me.lbl_capacitacao.AutoSize = True
        Me.lbl_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacitacao.Location = New System.Drawing.Point(45, 101)
        Me.lbl_capacitacao.Name = "lbl_capacitacao"
        Me.lbl_capacitacao.Size = New System.Drawing.Size(95, 18)
        Me.lbl_capacitacao.TabIndex = 23
        Me.lbl_capacitacao.Text = "Capacitação:"
        '
        'lbl_codigo_cap
        '
        Me.lbl_codigo_cap.AutoSize = True
        Me.lbl_codigo_cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_cap.Location = New System.Drawing.Point(79, 74)
        Me.lbl_codigo_cap.Name = "lbl_codigo_cap"
        Me.lbl_codigo_cap.Size = New System.Drawing.Size(60, 18)
        Me.lbl_codigo_cap.TabIndex = 22
        Me.lbl_codigo_cap.Text = "Código:"
        '
        'ftt_termino
        '
        Me.ftt_termino.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftt_termino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ftt_termino.Location = New System.Drawing.Point(481, 222)
        Me.ftt_termino.Name = "ftt_termino"
        Me.ftt_termino.Size = New System.Drawing.Size(98, 24)
        Me.ftt_termino.TabIndex = 42
        '
        'dtt_incio
        '
        Me.dtt_incio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtt_incio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtt_incio.Location = New System.Drawing.Point(481, 195)
        Me.dtt_incio.Name = "dtt_incio"
        Me.dtt_incio.Size = New System.Drawing.Size(98, 24)
        Me.dtt_incio.TabIndex = 41
        '
        'lbl_data_termino
        '
        Me.lbl_data_termino.AutoSize = True
        Me.lbl_data_termino.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_termino.Location = New System.Drawing.Point(373, 227)
        Me.lbl_data_termino.Name = "lbl_data_termino"
        Me.lbl_data_termino.Size = New System.Drawing.Size(102, 18)
        Me.lbl_data_termino.TabIndex = 40
        Me.lbl_data_termino.Text = "Data Término:"
        '
        'lbl_data_inicio
        '
        Me.lbl_data_inicio.AutoSize = True
        Me.lbl_data_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_inicio.Location = New System.Drawing.Point(394, 198)
        Me.lbl_data_inicio.Name = "lbl_data_inicio"
        Me.lbl_data_inicio.Size = New System.Drawing.Size(81, 18)
        Me.lbl_data_inicio.TabIndex = 39
        Me.lbl_data_inicio.Text = "Data Início:"
        '
        'txt_instrutor
        '
        Me.txt_instrutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_instrutor.Location = New System.Drawing.Point(162, 248)
        Me.txt_instrutor.Name = "txt_instrutor"
        Me.txt_instrutor.ReadOnly = True
        Me.txt_instrutor.Size = New System.Drawing.Size(206, 24)
        Me.txt_instrutor.TabIndex = 37
        '
        'lbl_fornecedor
        '
        Me.lbl_fornecedor.AutoSize = True
        Me.lbl_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fornecedor.Location = New System.Drawing.Point(51, 279)
        Me.lbl_fornecedor.Name = "lbl_fornecedor"
        Me.lbl_fornecedor.Size = New System.Drawing.Size(89, 18)
        Me.lbl_fornecedor.TabIndex = 36
        Me.lbl_fornecedor.Text = "Fornecedor:"
        '
        'txt_fornecedor
        '
        Me.txt_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fornecedor.Location = New System.Drawing.Point(162, 276)
        Me.txt_fornecedor.Name = "txt_fornecedor"
        Me.txt_fornecedor.ReadOnly = True
        Me.txt_fornecedor.Size = New System.Drawing.Size(205, 24)
        Me.txt_fornecedor.TabIndex = 38
        '
        'lbl_instrutor
        '
        Me.lbl_instrutor.AutoSize = True
        Me.lbl_instrutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instrutor.Location = New System.Drawing.Point(74, 251)
        Me.lbl_instrutor.Name = "lbl_instrutor"
        Me.lbl_instrutor.Size = New System.Drawing.Size(66, 18)
        Me.lbl_instrutor.TabIndex = 35
        Me.lbl_instrutor.Text = "Instrutor:"
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(504, 462)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 26)
        Me.btn_voltar.TabIndex = 43
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'lbl_validade
        '
        Me.lbl_validade.AutoSize = True
        Me.lbl_validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_validade.Location = New System.Drawing.Point(72, 171)
        Me.lbl_validade.Name = "lbl_validade"
        Me.lbl_validade.Size = New System.Drawing.Size(67, 18)
        Me.lbl_validade.TabIndex = 44
        Me.lbl_validade.Text = "Validade:"
        '
        'txt_validade
        '
        Me.txt_validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_validade.Location = New System.Drawing.Point(162, 168)
        Me.txt_validade.Name = "txt_validade"
        Me.txt_validade.ReadOnly = True
        Me.txt_validade.Size = New System.Drawing.Size(100, 24)
        Me.txt_validade.TabIndex = 30
        '
        'btn_editar
        '
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(423, 462)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 26)
        Me.btn_editar.TabIndex = 47
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'lst_funcionario
        '
        Me.lst_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_funcionario.FormattingEnabled = True
        Me.lst_funcionario.ItemHeight = 18
        Me.lst_funcionario.Location = New System.Drawing.Point(76, 362)
        Me.lst_funcionario.Name = "lst_funcionario"
        Me.lst_funcionario.Size = New System.Drawing.Size(503, 94)
        Me.lst_funcionario.TabIndex = 48
        '
        'lbl_funcionario
        '
        Me.lbl_funcionario.AutoSize = True
        Me.lbl_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_funcionario.Location = New System.Drawing.Point(73, 341)
        Me.lbl_funcionario.Name = "lbl_funcionario"
        Me.lbl_funcionario.Size = New System.Drawing.Size(98, 18)
        Me.lbl_funcionario.TabIndex = 49
        Me.lbl_funcionario.Text = "Funcionários:"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 12)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(235, 20)
        Me.lbl_titulo.TabIndex = 52
        Me.lbl_titulo.Text = "Agendamento X (XX/XX/XXXX)"
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(555, 8)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 51
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(578, 8)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 50
        Me.btn_fechar.Text = "x"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'frm_VisualizarAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(608, 500)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.lbl_funcionario)
        Me.Controls.Add(Me.lst_funcionario)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.lbl_validade)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.ftt_termino)
        Me.Controls.Add(Me.dtt_incio)
        Me.Controls.Add(Me.lbl_data_termino)
        Me.Controls.Add(Me.lbl_data_inicio)
        Me.Controls.Add(Me.txt_instrutor)
        Me.Controls.Add(Me.lbl_fornecedor)
        Me.Controls.Add(Me.txt_fornecedor)
        Me.Controls.Add(Me.lbl_instrutor)
        Me.Controls.Add(Me.dtt_criacao)
        Me.Controls.Add(Me.txt_validade)
        Me.Controls.Add(Me.txt_cargahoraria)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.txt_capacitacao)
        Me.Controls.Add(Me.txt_codigo_cap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_cargahoraria)
        Me.Controls.Add(Me.lbl_descricao)
        Me.Controls.Add(Me.lbl_capacitacao)
        Me.Controls.Add(Me.lbl_codigo_cap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_VisualizarAgendamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_VisualizarCapacitacao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtt_criacao As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_cargahoraria As System.Windows.Forms.TextBox
    Friend WithEvents txt_descricao As System.Windows.Forms.TextBox
    Friend WithEvents txt_capacitacao As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo_cap As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_cargahoraria As System.Windows.Forms.Label
    Friend WithEvents lbl_descricao As System.Windows.Forms.Label
    Friend WithEvents lbl_capacitacao As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_cap As System.Windows.Forms.Label
    Friend WithEvents ftt_termino As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtt_incio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_data_termino As System.Windows.Forms.Label
    Friend WithEvents lbl_data_inicio As System.Windows.Forms.Label
    Friend WithEvents txt_instrutor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fornecedor As System.Windows.Forms.Label
    Friend WithEvents txt_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_instrutor As System.Windows.Forms.Label
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
    Friend WithEvents lbl_validade As System.Windows.Forms.Label
    Friend WithEvents txt_validade As System.Windows.Forms.TextBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents lst_funcionario As System.Windows.Forms.ListBox
    Friend WithEvents lbl_funcionario As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
End Class
