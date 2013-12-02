<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CapacitacaoObrigatoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CapacitacaoObrigatoria))
        Me.lbl_capacitacao = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.cmb_capacitacao = New System.Windows.Forms.ComboBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.btn_nova_capacitacao = New System.Windows.Forms.Button()
        Me.pnl_1 = New System.Windows.Forms.Panel()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_adiciona = New System.Windows.Forms.Button()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_cadastra = New System.Windows.Forms.Button()
        Me.lst_agendados = New System.Windows.Forms.ListBox()
        Me.lst_funcionarios = New System.Windows.Forms.ListBox()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_pesquisa = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.pnl_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_capacitacao
        '
        Me.lbl_capacitacao.AutoSize = True
        Me.lbl_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacitacao.Location = New System.Drawing.Point(24, 65)
        Me.lbl_capacitacao.Name = "lbl_capacitacao"
        Me.lbl_capacitacao.Size = New System.Drawing.Size(95, 18)
        Me.lbl_capacitacao.TabIndex = 0
        Me.lbl_capacitacao.Text = "Capacitação:"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(396, 65)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(44, 18)
        Me.lbl_codigo.TabIndex = 1
        Me.lbl_codigo.Text = "Cód.:"
        '
        'cmb_capacitacao
        '
        Me.cmb_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_capacitacao.FormattingEnabled = True
        Me.cmb_capacitacao.Items.AddRange(New Object() {"", "NR33"})
        Me.cmb_capacitacao.Location = New System.Drawing.Point(125, 62)
        Me.cmb_capacitacao.Name = "cmb_capacitacao"
        Me.cmb_capacitacao.Size = New System.Drawing.Size(196, 26)
        Me.cmb_capacitacao.TabIndex = 7
        '
        'txt_codigo
        '
        Me.txt_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(446, 62)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(161, 24)
        Me.txt_codigo.TabIndex = 8
        '
        'btn_nova_capacitacao
        '
        Me.btn_nova_capacitacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nova_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova_capacitacao.Location = New System.Drawing.Point(621, 65)
        Me.btn_nova_capacitacao.Name = "btn_nova_capacitacao"
        Me.btn_nova_capacitacao.Size = New System.Drawing.Size(104, 68)
        Me.btn_nova_capacitacao.TabIndex = 15
        Me.btn_nova_capacitacao.Text = "Nova Capacitação"
        Me.btn_nova_capacitacao.UseVisualStyleBackColor = True
        '
        'pnl_1
        '
        Me.pnl_1.BackColor = System.Drawing.Color.LightGray
        Me.pnl_1.Controls.Add(Me.btn_remove)
        Me.pnl_1.Controls.Add(Me.btn_adiciona)
        Me.pnl_1.Controls.Add(Me.btn_cancela)
        Me.pnl_1.Controls.Add(Me.btn_cadastra)
        Me.pnl_1.Controls.Add(Me.lst_agendados)
        Me.pnl_1.Controls.Add(Me.lst_funcionarios)
        Me.pnl_1.Controls.Add(Me.txt_pesquisa)
        Me.pnl_1.Controls.Add(Me.ComboBox1)
        Me.pnl_1.Controls.Add(Me.lbl_pesquisa)
        Me.pnl_1.Location = New System.Drawing.Point(6, 161)
        Me.pnl_1.Name = "pnl_1"
        Me.pnl_1.Size = New System.Drawing.Size(748, 228)
        Me.pnl_1.TabIndex = 16
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(360, 114)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(45, 23)
        Me.btn_remove.TabIndex = 9
        Me.btn_remove.Text = "<"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_adiciona
        '
        Me.btn_adiciona.Location = New System.Drawing.Point(360, 85)
        Me.btn_adiciona.Name = "btn_adiciona"
        Me.btn_adiciona.Size = New System.Drawing.Size(45, 23)
        Me.btn_adiciona.TabIndex = 8
        Me.btn_adiciona.Text = ">"
        Me.btn_adiciona.UseVisualStyleBackColor = True
        '
        'btn_cancela
        '
        Me.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(521, 186)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(80, 28)
        Me.btn_cancela.TabIndex = 7
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_cadastra
        '
        Me.btn_cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra.Location = New System.Drawing.Point(435, 186)
        Me.btn_cadastra.Name = "btn_cadastra"
        Me.btn_cadastra.Size = New System.Drawing.Size(80, 28)
        Me.btn_cadastra.TabIndex = 6
        Me.btn_cadastra.Text = "Agendar"
        Me.btn_cadastra.UseVisualStyleBackColor = True
        '
        'lst_agendados
        '
        Me.lst_agendados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_agendados.FormattingEnabled = True
        Me.lst_agendados.ItemHeight = 18
        Me.lst_agendados.Location = New System.Drawing.Point(421, 50)
        Me.lst_agendados.Name = "lst_agendados"
        Me.lst_agendados.Size = New System.Drawing.Size(308, 130)
        Me.lst_agendados.TabIndex = 5
        '
        'lst_funcionarios
        '
        Me.lst_funcionarios.ColumnWidth = 20
        Me.lst_funcionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_funcionarios.FormattingEnabled = True
        Me.lst_funcionarios.ItemHeight = 18
        Me.lst_funcionarios.Location = New System.Drawing.Point(21, 50)
        Me.lst_funcionarios.MultiColumn = True
        Me.lst_funcionarios.Name = "lst_funcionarios"
        Me.lst_funcionarios.Size = New System.Drawing.Size(326, 130)
        Me.lst_funcionarios.TabIndex = 4
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(271, 20)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(458, 24)
        Me.txt_pesquisa.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(88, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 26)
        Me.ComboBox1.TabIndex = 2
        '
        'lbl_pesquisa
        '
        Me.lbl_pesquisa.AutoSize = True
        Me.lbl_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pesquisa.Location = New System.Drawing.Point(18, 21)
        Me.lbl_pesquisa.Name = "lbl_pesquisa"
        Me.lbl_pesquisa.Size = New System.Drawing.Size(73, 18)
        Me.lbl_pesquisa.TabIndex = 1
        Me.lbl_pesquisa.Text = "Pesquisa:"
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(706, 6)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 18
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(729, 6)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 17
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
        Me.lbl_titulo.Size = New System.Drawing.Size(273, 20)
        Me.lbl_titulo.TabIndex = 19
        Me.lbl_titulo.Text = "Definição de Capacitação Obrigatória"
        '
        'frm_CapacitacaoObrigatoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(760, 396)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.pnl_1)
        Me.Controls.Add(Me.btn_nova_capacitacao)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.cmb_capacitacao)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.lbl_capacitacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_CapacitacaoObrigatoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definição de Capacitação Obrigatória"
        Me.pnl_1.ResumeLayout(False)
        Me.pnl_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_capacitacao As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents cmb_capacitacao As System.Windows.Forms.ComboBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents btn_nova_capacitacao As System.Windows.Forms.Button
    Friend WithEvents pnl_1 As System.Windows.Forms.Panel
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_adiciona As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_cadastra As System.Windows.Forms.Button
    Friend WithEvents lst_agendados As System.Windows.Forms.ListBox
    Friend WithEvents lst_funcionarios As System.Windows.Forms.ListBox
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_pesquisa As System.Windows.Forms.Label
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
End Class
