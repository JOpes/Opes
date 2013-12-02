<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CadastroCapacitacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CadastroCapacitacao))
        Me.lbl_codigo_cap = New System.Windows.Forms.Label()
        Me.lbl_capacitacao = New System.Windows.Forms.Label()
        Me.lbl_descricao = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.btn_cadastra = New System.Windows.Forms.Button()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_capacitacao = New System.Windows.Forms.TextBox()
        Me.lbl_validade = New System.Windows.Forms.Label()
        Me.txt_duracao = New System.Windows.Forms.TextBox()
        Me.lbl_cod = New System.Windows.Forms.Label()
        Me.lbl_mes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_codigo_cap
        '
        Me.lbl_codigo_cap.AutoSize = True
        Me.lbl_codigo_cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_cap.Location = New System.Drawing.Point(146, 75)
        Me.lbl_codigo_cap.Name = "lbl_codigo_cap"
        Me.lbl_codigo_cap.Size = New System.Drawing.Size(60, 18)
        Me.lbl_codigo_cap.TabIndex = 0
        Me.lbl_codigo_cap.Text = "Código:"
        '
        'lbl_capacitacao
        '
        Me.lbl_capacitacao.AutoSize = True
        Me.lbl_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacitacao.Location = New System.Drawing.Point(116, 101)
        Me.lbl_capacitacao.Name = "lbl_capacitacao"
        Me.lbl_capacitacao.Size = New System.Drawing.Size(95, 18)
        Me.lbl_capacitacao.TabIndex = 1
        Me.lbl_capacitacao.Text = "Capacitação:"
        '
        'lbl_descricao
        '
        Me.lbl_descricao.AutoSize = True
        Me.lbl_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descricao.Location = New System.Drawing.Point(131, 127)
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.Size = New System.Drawing.Size(80, 18)
        Me.lbl_descricao.TabIndex = 2
        Me.lbl_descricao.Text = "Descrição:"
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(230, 124)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(205, 57)
        Me.txt_descricao.TabIndex = 2
        '
        'btn_cadastra
        '
        Me.btn_cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra.Location = New System.Drawing.Point(182, 247)
        Me.btn_cadastra.Name = "btn_cadastra"
        Me.btn_cadastra.Size = New System.Drawing.Size(82, 33)
        Me.btn_cadastra.TabIndex = 4
        Me.btn_cadastra.Text = "Cadastrar"
        Me.btn_cadastra.UseVisualStyleBackColor = True
        '
        'btn_cancela
        '
        Me.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(280, 247)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(82, 33)
        Me.btn_cancela.TabIndex = 5
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(472, 6)
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
        Me.btn_fechar.Location = New System.Drawing.Point(495, 6)
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
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 11)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(138, 20)
        Me.lbl_titulo.TabIndex = 20
        Me.lbl_titulo.Text = "Nova Capacitação"
        '
        'txt_capacitacao
        '
        Me.txt_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_capacitacao.Location = New System.Drawing.Point(230, 98)
        Me.txt_capacitacao.Name = "txt_capacitacao"
        Me.txt_capacitacao.Size = New System.Drawing.Size(205, 24)
        Me.txt_capacitacao.TabIndex = 1
        '
        'lbl_validade
        '
        Me.lbl_validade.AutoSize = True
        Me.lbl_validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_validade.Location = New System.Drawing.Point(147, 190)
        Me.lbl_validade.Name = "lbl_validade"
        Me.lbl_validade.Size = New System.Drawing.Size(67, 18)
        Me.lbl_validade.TabIndex = 23
        Me.lbl_validade.Text = "Validade:"
        '
        'txt_duracao
        '
        Me.txt_duracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_duracao.Location = New System.Drawing.Point(230, 187)
        Me.txt_duracao.Name = "txt_duracao"
        Me.txt_duracao.Size = New System.Drawing.Size(68, 24)
        Me.txt_duracao.TabIndex = 3
        '
        'lbl_cod
        '
        Me.lbl_cod.AutoSize = True
        Me.lbl_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cod.Location = New System.Drawing.Point(227, 75)
        Me.lbl_cod.Name = "lbl_cod"
        Me.lbl_cod.Size = New System.Drawing.Size(16, 18)
        Me.lbl_cod.TabIndex = 26
        Me.lbl_cod.Text = "1"
        '
        'lbl_mes
        '
        Me.lbl_mes.AutoSize = True
        Me.lbl_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mes.Location = New System.Drawing.Point(304, 195)
        Me.lbl_mes.Name = "lbl_mes"
        Me.lbl_mes.Size = New System.Drawing.Size(79, 16)
        Me.lbl_mes.TabIndex = 27
        Me.lbl_mes.Text = "(em meses)"
        '
        'frm_CadastroCapacitacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(526, 306)
        Me.Controls.Add(Me.lbl_mes)
        Me.Controls.Add(Me.lbl_cod)
        Me.Controls.Add(Me.txt_duracao)
        Me.Controls.Add(Me.lbl_validade)
        Me.Controls.Add(Me.txt_capacitacao)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_cancela)
        Me.Controls.Add(Me.btn_cadastra)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.lbl_descricao)
        Me.Controls.Add(Me.lbl_capacitacao)
        Me.Controls.Add(Me.lbl_codigo_cap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frm_CadastroCapacitacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Capacitação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_codigo_cap As System.Windows.Forms.Label
    Friend WithEvents lbl_capacitacao As System.Windows.Forms.Label
    Friend WithEvents lbl_descricao As System.Windows.Forms.Label
    Friend WithEvents txt_descricao As System.Windows.Forms.TextBox
    Friend WithEvents btn_cadastra As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txt_capacitacao As System.Windows.Forms.TextBox
    Friend WithEvents lbl_validade As System.Windows.Forms.Label
    Friend WithEvents txt_duracao As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cod As System.Windows.Forms.Label
    Friend WithEvents lbl_mes As System.Windows.Forms.Label
End Class
