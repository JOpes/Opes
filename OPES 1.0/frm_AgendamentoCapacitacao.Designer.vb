<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AgendamentoCapacitacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AgendamentoCapacitacao))
        Me.txt_instrutor = New System.Windows.Forms.TextBox()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_adiciona = New System.Windows.Forms.Button()
        Me.lbl_fornecedor = New System.Windows.Forms.Label()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_cadastra = New System.Windows.Forms.Button()
        Me.pnl_1 = New System.Windows.Forms.Panel()
        Me.lst_agendados = New System.Windows.Forms.ListBox()
        Me.lst_funcionarios = New System.Windows.Forms.ListBox()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_pesquisa = New System.Windows.Forms.Label()
        Me.lbl_criterio = New System.Windows.Forms.Label()
        Me.btn_nova_capacitacao = New System.Windows.Forms.Button()
        Me.txt_cargahoraria = New System.Windows.Forms.TextBox()
        Me.txt_local = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.lbl_instrutor = New System.Windows.Forms.Label()
        Me.lbl_cargahoraria = New System.Windows.Forms.Label()
        Me.lbl_local = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.lbl_capacitacao = New System.Windows.Forms.Label()
        Me.lbl_data_inicio = New System.Windows.Forms.Label()
        Me.lbl_data_termino = New System.Windows.Forms.Label()
        Me.dtt_incio = New System.Windows.Forms.DateTimePicker()
        Me.ftt_termino = New System.Windows.Forms.DateTimePicker()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.cmb_capacitacao = New System.Windows.Forms.ComboBox()
        Me.cmb_forn = New System.Windows.Forms.ComboBox()
        Me.pnl_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_instrutor
        '
        Me.txt_instrutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_instrutor.Location = New System.Drawing.Point(137, 122)
        Me.txt_instrutor.Name = "txt_instrutor"
        Me.txt_instrutor.Size = New System.Drawing.Size(196, 24)
        Me.txt_instrutor.TabIndex = 4
        '
        'btn_remove
        '
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_remove.Location = New System.Drawing.Point(345, 114)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(45, 23)
        Me.btn_remove.TabIndex = 3
        Me.btn_remove.Text = "<"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_adiciona
        '
        Me.btn_adiciona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_adiciona.Location = New System.Drawing.Point(345, 85)
        Me.btn_adiciona.Name = "btn_adiciona"
        Me.btn_adiciona.Size = New System.Drawing.Size(45, 23)
        Me.btn_adiciona.TabIndex = 2
        Me.btn_adiciona.Text = ">"
        Me.btn_adiciona.UseVisualStyleBackColor = True
        '
        'lbl_fornecedor
        '
        Me.lbl_fornecedor.AutoSize = True
        Me.lbl_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fornecedor.Location = New System.Drawing.Point(364, 125)
        Me.lbl_fornecedor.Name = "lbl_fornecedor"
        Me.lbl_fornecedor.Size = New System.Drawing.Size(89, 18)
        Me.lbl_fornecedor.TabIndex = 22
        Me.lbl_fornecedor.Text = "Fornecedor:"
        '
        'btn_cancela
        '
        Me.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(617, 176)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(90, 34)
        Me.btn_cancela.TabIndex = 6
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_cadastra
        '
        Me.btn_cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra.Location = New System.Drawing.Point(522, 176)
        Me.btn_cadastra.Name = "btn_cadastra"
        Me.btn_cadastra.Size = New System.Drawing.Size(89, 34)
        Me.btn_cadastra.TabIndex = 5
        Me.btn_cadastra.Text = "Agendar"
        Me.btn_cadastra.UseVisualStyleBackColor = True
        '
        'pnl_1
        '
        Me.pnl_1.BackColor = System.Drawing.Color.Gainsboro
        Me.pnl_1.Controls.Add(Me.lst_agendados)
        Me.pnl_1.Controls.Add(Me.lst_funcionarios)
        Me.pnl_1.Controls.Add(Me.btn_remove)
        Me.pnl_1.Controls.Add(Me.btn_adiciona)
        Me.pnl_1.Controls.Add(Me.btn_cancela)
        Me.pnl_1.Controls.Add(Me.btn_cadastra)
        Me.pnl_1.Controls.Add(Me.txt_pesquisa)
        Me.pnl_1.Controls.Add(Me.ComboBox1)
        Me.pnl_1.Controls.Add(Me.lbl_pesquisa)
        Me.pnl_1.Controls.Add(Me.lbl_criterio)
        Me.pnl_1.Location = New System.Drawing.Point(6, 196)
        Me.pnl_1.Name = "pnl_1"
        Me.pnl_1.Size = New System.Drawing.Size(730, 220)
        Me.pnl_1.TabIndex = 0
        '
        'lst_agendados
        '
        Me.lst_agendados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_agendados.FormattingEnabled = True
        Me.lst_agendados.ItemHeight = 18
        Me.lst_agendados.Location = New System.Drawing.Point(407, 58)
        Me.lst_agendados.Name = "lst_agendados"
        Me.lst_agendados.Size = New System.Drawing.Size(300, 112)
        Me.lst_agendados.TabIndex = 4
        '
        'lst_funcionarios
        '
        Me.lst_funcionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_funcionarios.FormattingEnabled = True
        Me.lst_funcionarios.ItemHeight = 18
        Me.lst_funcionarios.Items.AddRange(New Object() {"Emerson de Jesus"})
        Me.lst_funcionarios.Location = New System.Drawing.Point(23, 58)
        Me.lst_funcionarios.Name = "lst_funcionarios"
        Me.lst_funcionarios.Size = New System.Drawing.Size(304, 112)
        Me.lst_funcionarios.TabIndex = 1
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(481, 15)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(226, 24)
        Me.txt_pesquisa.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(171, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 26)
        Me.ComboBox1.TabIndex = 9
        '
        'lbl_pesquisa
        '
        Me.lbl_pesquisa.AutoSize = True
        Me.lbl_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesquisa.Location = New System.Drawing.Point(402, 18)
        Me.lbl_pesquisa.Name = "lbl_pesquisa"
        Me.lbl_pesquisa.Size = New System.Drawing.Size(73, 18)
        Me.lbl_pesquisa.TabIndex = 1
        Me.lbl_pesquisa.Text = "Pesquisa:"
        '
        'lbl_criterio
        '
        Me.lbl_criterio.AutoSize = True
        Me.lbl_criterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_criterio.Location = New System.Drawing.Point(20, 21)
        Me.lbl_criterio.Name = "lbl_criterio"
        Me.lbl_criterio.Size = New System.Drawing.Size(145, 18)
        Me.lbl_criterio.TabIndex = 0
        Me.lbl_criterio.Text = "Critério de Pesquisa:"
        '
        'btn_nova_capacitacao
        '
        Me.btn_nova_capacitacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nova_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova_capacitacao.Location = New System.Drawing.Point(615, 79)
        Me.btn_nova_capacitacao.Name = "btn_nova_capacitacao"
        Me.btn_nova_capacitacao.Size = New System.Drawing.Size(102, 68)
        Me.btn_nova_capacitacao.TabIndex = 8
        Me.btn_nova_capacitacao.Text = "Nova Capacitação"
        Me.btn_nova_capacitacao.UseVisualStyleBackColor = True
        '
        'txt_cargahoraria
        '
        Me.txt_cargahoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cargahoraria.Location = New System.Drawing.Point(463, 94)
        Me.txt_cargahoraria.Name = "txt_cargahoraria"
        Me.txt_cargahoraria.Size = New System.Drawing.Size(121, 24)
        Me.txt_cargahoraria.TabIndex = 3
        '
        'txt_local
        '
        Me.txt_local.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_local.Location = New System.Drawing.Point(137, 94)
        Me.txt_local.Name = "txt_local"
        Me.txt_local.ReadOnly = True
        Me.txt_local.Size = New System.Drawing.Size(196, 24)
        Me.txt_local.TabIndex = 2
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(463, 65)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(121, 24)
        Me.txt_codigo.TabIndex = 1
        '
        'lbl_instrutor
        '
        Me.lbl_instrutor.AutoSize = True
        Me.lbl_instrutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instrutor.Location = New System.Drawing.Point(56, 124)
        Me.lbl_instrutor.Name = "lbl_instrutor"
        Me.lbl_instrutor.Size = New System.Drawing.Size(66, 18)
        Me.lbl_instrutor.TabIndex = 21
        Me.lbl_instrutor.Text = "Instrutor:"
        '
        'lbl_cargahoraria
        '
        Me.lbl_cargahoraria.AutoSize = True
        Me.lbl_cargahoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cargahoraria.Location = New System.Drawing.Point(348, 97)
        Me.lbl_cargahoraria.Name = "lbl_cargahoraria"
        Me.lbl_cargahoraria.Size = New System.Drawing.Size(105, 18)
        Me.lbl_cargahoraria.TabIndex = 20
        Me.lbl_cargahoraria.Text = "Carga Horária:"
        '
        'lbl_local
        '
        Me.lbl_local.AutoSize = True
        Me.lbl_local.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_local.Location = New System.Drawing.Point(74, 97)
        Me.lbl_local.Name = "lbl_local"
        Me.lbl_local.Size = New System.Drawing.Size(48, 18)
        Me.lbl_local.TabIndex = 19
        Me.lbl_local.Text = "Local:"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(409, 68)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(44, 18)
        Me.lbl_codigo.TabIndex = 18
        Me.lbl_codigo.Text = "Cód.:"
        '
        'lbl_capacitacao
        '
        Me.lbl_capacitacao.AutoSize = True
        Me.lbl_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacitacao.Location = New System.Drawing.Point(26, 68)
        Me.lbl_capacitacao.Name = "lbl_capacitacao"
        Me.lbl_capacitacao.Size = New System.Drawing.Size(95, 18)
        Me.lbl_capacitacao.TabIndex = 17
        Me.lbl_capacitacao.Text = "Capacitação:"
        '
        'lbl_data_inicio
        '
        Me.lbl_data_inicio.AutoSize = True
        Me.lbl_data_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_inicio.Location = New System.Drawing.Point(41, 154)
        Me.lbl_data_inicio.Name = "lbl_data_inicio"
        Me.lbl_data_inicio.Size = New System.Drawing.Size(81, 18)
        Me.lbl_data_inicio.TabIndex = 31
        Me.lbl_data_inicio.Text = "Data Início:"
        '
        'lbl_data_termino
        '
        Me.lbl_data_termino.AutoSize = True
        Me.lbl_data_termino.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_termino.Location = New System.Drawing.Point(351, 154)
        Me.lbl_data_termino.Name = "lbl_data_termino"
        Me.lbl_data_termino.Size = New System.Drawing.Size(102, 18)
        Me.lbl_data_termino.TabIndex = 32
        Me.lbl_data_termino.Text = "Data Término:"
        '
        'dtt_incio
        '
        Me.dtt_incio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtt_incio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtt_incio.Location = New System.Drawing.Point(137, 149)
        Me.dtt_incio.MaxDate = New Date(2015, 12, 31, 0, 0, 0, 0)
        Me.dtt_incio.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.dtt_incio.Name = "dtt_incio"
        Me.dtt_incio.Size = New System.Drawing.Size(98, 24)
        Me.dtt_incio.TabIndex = 6
        '
        'ftt_termino
        '
        Me.ftt_termino.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftt_termino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ftt_termino.Location = New System.Drawing.Point(463, 149)
        Me.ftt_termino.MaxDate = New Date(2015, 12, 31, 0, 0, 0, 0)
        Me.ftt_termino.MinDate = New Date(2013, 1, 1, 0, 0, 0, 0)
        Me.ftt_termino.Name = "ftt_termino"
        Me.ftt_termino.Size = New System.Drawing.Size(121, 24)
        Me.ftt_termino.TabIndex = 7
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(689, 7)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 36
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(712, 7)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 35
        Me.btn_fechar.Text = "x"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 11)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(110, 20)
        Me.lbl_titulo.TabIndex = 37
        Me.lbl_titulo.Text = "Agendamento"
        '
        'cmb_capacitacao
        '
        Me.cmb_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_capacitacao.FormattingEnabled = True
        Me.cmb_capacitacao.Items.AddRange(New Object() {"", "NR33"})
        Me.cmb_capacitacao.Location = New System.Drawing.Point(137, 65)
        Me.cmb_capacitacao.Name = "cmb_capacitacao"
        Me.cmb_capacitacao.Size = New System.Drawing.Size(196, 26)
        Me.cmb_capacitacao.TabIndex = 0
        '
        'cmb_forn
        '
        Me.cmb_forn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_forn.FormattingEnabled = True
        Me.cmb_forn.Items.AddRange(New Object() {"", "Tzusk Co."})
        Me.cmb_forn.Location = New System.Drawing.Point(463, 121)
        Me.cmb_forn.Name = "cmb_forn"
        Me.cmb_forn.Size = New System.Drawing.Size(121, 26)
        Me.cmb_forn.TabIndex = 5
        '
        'frm_AgendamentoCapacitacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 424)
        Me.Controls.Add(Me.cmb_forn)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.ftt_termino)
        Me.Controls.Add(Me.dtt_incio)
        Me.Controls.Add(Me.lbl_data_termino)
        Me.Controls.Add(Me.lbl_data_inicio)
        Me.Controls.Add(Me.txt_instrutor)
        Me.Controls.Add(Me.lbl_fornecedor)
        Me.Controls.Add(Me.pnl_1)
        Me.Controls.Add(Me.btn_nova_capacitacao)
        Me.Controls.Add(Me.txt_cargahoraria)
        Me.Controls.Add(Me.txt_local)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.cmb_capacitacao)
        Me.Controls.Add(Me.lbl_instrutor)
        Me.Controls.Add(Me.lbl_cargahoraria)
        Me.Controls.Add(Me.lbl_local)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.lbl_capacitacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_AgendamentoCapacitacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendamento de Capacitação"
        Me.pnl_1.ResumeLayout(False)
        Me.pnl_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_instrutor As System.Windows.Forms.TextBox
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_adiciona As System.Windows.Forms.Button
    Friend WithEvents lbl_fornecedor As System.Windows.Forms.Label
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_cadastra As System.Windows.Forms.Button
    Friend WithEvents pnl_1 As System.Windows.Forms.Panel
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_pesquisa As System.Windows.Forms.Label
    Friend WithEvents lbl_criterio As System.Windows.Forms.Label
    Friend WithEvents btn_nova_capacitacao As System.Windows.Forms.Button
    Friend WithEvents txt_cargahoraria As System.Windows.Forms.TextBox
    Friend WithEvents txt_local As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_instrutor As System.Windows.Forms.Label
    Friend WithEvents lbl_cargahoraria As System.Windows.Forms.Label
    Friend WithEvents lbl_local As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_capacitacao As System.Windows.Forms.Label
    Friend WithEvents lbl_data_inicio As System.Windows.Forms.Label
    Friend WithEvents lbl_data_termino As System.Windows.Forms.Label
    Friend WithEvents dtt_incio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ftt_termino As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents cmb_capacitacao As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_forn As System.Windows.Forms.ComboBox
    Friend WithEvents lst_agendados As System.Windows.Forms.ListBox
    Friend WithEvents lst_funcionarios As System.Windows.Forms.ListBox
End Class
