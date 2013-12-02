<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Validacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Validacao))
        Me.ftt_termino = New System.Windows.Forms.DateTimePicker()
        Me.dtt_incio = New System.Windows.Forms.DateTimePicker()
        Me.lbl_data_termino = New System.Windows.Forms.Label()
        Me.lbl_data_inicio = New System.Windows.Forms.Label()
        Me.txt_instrutor = New System.Windows.Forms.TextBox()
        Me.lbl_fornecedor = New System.Windows.Forms.Label()
        Me.txt_cargahoraria = New System.Windows.Forms.TextBox()
        Me.txt_local = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.cmb_capacitacao = New System.Windows.Forms.ComboBox()
        Me.lbl_instrutor = New System.Windows.Forms.Label()
        Me.lbl_cargahoraria = New System.Windows.Forms.Label()
        Me.lbl_local = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.lbl_capacitacao = New System.Windows.Forms.Label()
        Me.lst_funcionarios = New System.Windows.Forms.ListBox()
        Me.lst_participantes = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.cmb_fornecedor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_motivo_ausencia = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ftt_termino
        '
        Me.ftt_termino.Enabled = False
        Me.ftt_termino.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftt_termino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ftt_termino.Location = New System.Drawing.Point(448, 153)
        Me.ftt_termino.Name = "ftt_termino"
        Me.ftt_termino.Size = New System.Drawing.Size(98, 24)
        Me.ftt_termino.TabIndex = 50
        '
        'dtt_incio
        '
        Me.dtt_incio.Enabled = False
        Me.dtt_incio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtt_incio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtt_incio.Location = New System.Drawing.Point(118, 156)
        Me.dtt_incio.Name = "dtt_incio"
        Me.dtt_incio.Size = New System.Drawing.Size(98, 24)
        Me.dtt_incio.TabIndex = 49
        '
        'lbl_data_termino
        '
        Me.lbl_data_termino.AutoSize = True
        Me.lbl_data_termino.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_termino.Location = New System.Drawing.Point(331, 160)
        Me.lbl_data_termino.Name = "lbl_data_termino"
        Me.lbl_data_termino.Size = New System.Drawing.Size(102, 18)
        Me.lbl_data_termino.TabIndex = 48
        Me.lbl_data_termino.Text = "Data Término:"
        '
        'lbl_data_inicio
        '
        Me.lbl_data_inicio.AutoSize = True
        Me.lbl_data_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_inicio.Location = New System.Drawing.Point(31, 160)
        Me.lbl_data_inicio.Name = "lbl_data_inicio"
        Me.lbl_data_inicio.Size = New System.Drawing.Size(81, 18)
        Me.lbl_data_inicio.TabIndex = 47
        Me.lbl_data_inicio.Text = "Data Início:"
        '
        'txt_instrutor
        '
        Me.txt_instrutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_instrutor.Location = New System.Drawing.Point(118, 129)
        Me.txt_instrutor.Name = "txt_instrutor"
        Me.txt_instrutor.ReadOnly = True
        Me.txt_instrutor.Size = New System.Drawing.Size(196, 24)
        Me.txt_instrutor.TabIndex = 45
        '
        'lbl_fornecedor
        '
        Me.lbl_fornecedor.AutoSize = True
        Me.lbl_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fornecedor.Location = New System.Drawing.Point(344, 132)
        Me.lbl_fornecedor.Name = "lbl_fornecedor"
        Me.lbl_fornecedor.Size = New System.Drawing.Size(89, 18)
        Me.lbl_fornecedor.TabIndex = 40
        Me.lbl_fornecedor.Text = "Fornecedor:"
        '
        'txt_cargahoraria
        '
        Me.txt_cargahoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cargahoraria.Location = New System.Drawing.Point(448, 98)
        Me.txt_cargahoraria.Name = "txt_cargahoraria"
        Me.txt_cargahoraria.ReadOnly = True
        Me.txt_cargahoraria.Size = New System.Drawing.Size(100, 24)
        Me.txt_cargahoraria.TabIndex = 44
        '
        'txt_local
        '
        Me.txt_local.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_local.Location = New System.Drawing.Point(118, 101)
        Me.txt_local.Name = "txt_local"
        Me.txt_local.ReadOnly = True
        Me.txt_local.Size = New System.Drawing.Size(196, 24)
        Me.txt_local.TabIndex = 43
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(448, 69)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(100, 24)
        Me.txt_codigo.TabIndex = 42
        '
        'cmb_capacitacao
        '
        Me.cmb_capacitacao.Enabled = False
        Me.cmb_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_capacitacao.FormattingEnabled = True
        Me.cmb_capacitacao.Location = New System.Drawing.Point(118, 72)
        Me.cmb_capacitacao.Name = "cmb_capacitacao"
        Me.cmb_capacitacao.Size = New System.Drawing.Size(196, 26)
        Me.cmb_capacitacao.TabIndex = 41
        '
        'lbl_instrutor
        '
        Me.lbl_instrutor.AutoSize = True
        Me.lbl_instrutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instrutor.Location = New System.Drawing.Point(46, 132)
        Me.lbl_instrutor.Name = "lbl_instrutor"
        Me.lbl_instrutor.Size = New System.Drawing.Size(66, 18)
        Me.lbl_instrutor.TabIndex = 39
        Me.lbl_instrutor.Text = "Instrutor:"
        '
        'lbl_cargahoraria
        '
        Me.lbl_cargahoraria.AutoSize = True
        Me.lbl_cargahoraria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cargahoraria.Location = New System.Drawing.Point(328, 104)
        Me.lbl_cargahoraria.Name = "lbl_cargahoraria"
        Me.lbl_cargahoraria.Size = New System.Drawing.Size(105, 18)
        Me.lbl_cargahoraria.TabIndex = 38
        Me.lbl_cargahoraria.Text = "Carga Horária:"
        '
        'lbl_local
        '
        Me.lbl_local.AutoSize = True
        Me.lbl_local.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_local.Location = New System.Drawing.Point(64, 104)
        Me.lbl_local.Name = "lbl_local"
        Me.lbl_local.Size = New System.Drawing.Size(48, 18)
        Me.lbl_local.TabIndex = 37
        Me.lbl_local.Text = "Local:"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(389, 75)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(44, 18)
        Me.lbl_codigo.TabIndex = 36
        Me.lbl_codigo.Text = "Cód.:"
        '
        'lbl_capacitacao
        '
        Me.lbl_capacitacao.AutoSize = True
        Me.lbl_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacitacao.Location = New System.Drawing.Point(17, 75)
        Me.lbl_capacitacao.Name = "lbl_capacitacao"
        Me.lbl_capacitacao.Size = New System.Drawing.Size(95, 18)
        Me.lbl_capacitacao.TabIndex = 35
        Me.lbl_capacitacao.Text = "Capacitação:"
        '
        'lst_funcionarios
        '
        Me.lst_funcionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_funcionarios.FormattingEnabled = True
        Me.lst_funcionarios.ItemHeight = 18
        Me.lst_funcionarios.Location = New System.Drawing.Point(37, 273)
        Me.lst_funcionarios.Name = "lst_funcionarios"
        Me.lst_funcionarios.Size = New System.Drawing.Size(525, 112)
        Me.lst_funcionarios.TabIndex = 51
        '
        'lst_participantes
        '
        Me.lst_participantes.AutoSize = True
        Me.lst_participantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_participantes.Location = New System.Drawing.Point(34, 248)
        Me.lst_participantes.Name = "lst_participantes"
        Me.lst_participantes.Size = New System.Drawing.Size(98, 18)
        Me.lst_participantes.TabIndex = 52
        Me.lst_participantes.Text = "Funcionários:"
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(560, 7)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 54
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(583, 7)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 53
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
        Me.lbl_titulo.Size = New System.Drawing.Size(79, 20)
        Me.lbl_titulo.TabIndex = 55
        Me.lbl_titulo.Text = "Validação"
        '
        'btn_cancela
        '
        Me.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(489, 391)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(75, 28)
        Me.btn_cancela.TabIndex = 56
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_validar
        '
        Me.btn_validar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_validar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validar.Location = New System.Drawing.Point(408, 391)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(75, 28)
        Me.btn_validar.TabIndex = 57
        Me.btn_validar.Text = "Validar"
        Me.btn_validar.UseVisualStyleBackColor = True
        '
        'cmb_fornecedor
        '
        Me.cmb_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fornecedor.FormattingEnabled = True
        Me.cmb_fornecedor.Location = New System.Drawing.Point(448, 124)
        Me.cmb_fornecedor.Name = "cmb_fornecedor"
        Me.cmb_fornecedor.Size = New System.Drawing.Size(98, 26)
        Me.cmb_fornecedor.TabIndex = 58
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 53)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Situação Final"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(106, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ausente"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Concluído"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Motivo:"
        Me.Label1.Visible = False
        '
        'txt_motivo_ausencia
        '
        Me.txt_motivo_ausencia.Location = New System.Drawing.Point(331, 214)
        Me.txt_motivo_ausencia.Name = "txt_motivo_ausencia"
        Me.txt_motivo_ausencia.Size = New System.Drawing.Size(196, 20)
        Me.txt_motivo_ausencia.TabIndex = 61
        Me.txt_motivo_ausencia.Visible = False
        '
        'frm_Validacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(613, 437)
        Me.Controls.Add(Me.txt_motivo_ausencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_fornecedor)
        Me.Controls.Add(Me.btn_validar)
        Me.Controls.Add(Me.btn_cancela)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.lst_participantes)
        Me.Controls.Add(Me.lst_funcionarios)
        Me.Controls.Add(Me.ftt_termino)
        Me.Controls.Add(Me.dtt_incio)
        Me.Controls.Add(Me.lbl_data_termino)
        Me.Controls.Add(Me.lbl_data_inicio)
        Me.Controls.Add(Me.txt_instrutor)
        Me.Controls.Add(Me.lbl_fornecedor)
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
        Me.Name = "frm_Validacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validacao"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ftt_termino As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtt_incio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_data_termino As System.Windows.Forms.Label
    Friend WithEvents lbl_data_inicio As System.Windows.Forms.Label
    Friend WithEvents txt_instrutor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fornecedor As System.Windows.Forms.Label
    Friend WithEvents txt_cargahoraria As System.Windows.Forms.TextBox
    Friend WithEvents txt_local As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents cmb_capacitacao As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_instrutor As System.Windows.Forms.Label
    Friend WithEvents lbl_cargahoraria As System.Windows.Forms.Label
    Friend WithEvents lbl_local As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents lbl_capacitacao As System.Windows.Forms.Label
    Friend WithEvents lst_funcionarios As System.Windows.Forms.ListBox
    Friend WithEvents lst_participantes As System.Windows.Forms.Label
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    Friend WithEvents cmb_fornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_motivo_ausencia As System.Windows.Forms.TextBox
End Class
