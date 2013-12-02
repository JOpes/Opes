<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisualizacaoCapacitacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VisualizacaoCapacitacao))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_validade = New System.Windows.Forms.Label()
        Me.txt_capacitacao = New System.Windows.Forms.TextBox()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.txt_codigo_cap = New System.Windows.Forms.TextBox()
        Me.lbl_descricao = New System.Windows.Forms.Label()
        Me.lbl_capacitacao = New System.Windows.Forms.Label()
        Me.lbl_codigo_cap = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 195)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(68, 24)
        Me.TextBox1.TabIndex = 32
        '
        'lbl_validade
        '
        Me.lbl_validade.AutoSize = True
        Me.lbl_validade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_validade.Location = New System.Drawing.Point(124, 198)
        Me.lbl_validade.Name = "lbl_validade"
        Me.lbl_validade.Size = New System.Drawing.Size(67, 18)
        Me.lbl_validade.TabIndex = 31
        Me.lbl_validade.Text = "Validade:"
        '
        'txt_capacitacao
        '
        Me.txt_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_capacitacao.Location = New System.Drawing.Point(200, 106)
        Me.txt_capacitacao.Name = "txt_capacitacao"
        Me.txt_capacitacao.ReadOnly = True
        Me.txt_capacitacao.Size = New System.Drawing.Size(205, 24)
        Me.txt_capacitacao.TabIndex = 30
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(200, 132)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.ReadOnly = True
        Me.txt_descricao.Size = New System.Drawing.Size(205, 57)
        Me.txt_descricao.TabIndex = 29
        '
        'txt_codigo_cap
        '
        Me.txt_codigo_cap.Enabled = False
        Me.txt_codigo_cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_cap.Location = New System.Drawing.Point(200, 80)
        Me.txt_codigo_cap.Name = "txt_codigo_cap"
        Me.txt_codigo_cap.ReadOnly = True
        Me.txt_codigo_cap.Size = New System.Drawing.Size(109, 24)
        Me.txt_codigo_cap.TabIndex = 28
        '
        'lbl_descricao
        '
        Me.lbl_descricao.AutoSize = True
        Me.lbl_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descricao.Location = New System.Drawing.Point(111, 135)
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.Size = New System.Drawing.Size(80, 18)
        Me.lbl_descricao.TabIndex = 27
        Me.lbl_descricao.Text = "Descrição:"
        '
        'lbl_capacitacao
        '
        Me.lbl_capacitacao.AutoSize = True
        Me.lbl_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacitacao.Location = New System.Drawing.Point(96, 109)
        Me.lbl_capacitacao.Name = "lbl_capacitacao"
        Me.lbl_capacitacao.Size = New System.Drawing.Size(95, 18)
        Me.lbl_capacitacao.TabIndex = 26
        Me.lbl_capacitacao.Text = "Capacitação:"
        '
        'lbl_codigo_cap
        '
        Me.lbl_codigo_cap.AutoSize = True
        Me.lbl_codigo_cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_cap.Location = New System.Drawing.Point(131, 83)
        Me.lbl_codigo_cap.Name = "lbl_codigo_cap"
        Me.lbl_codigo_cap.Size = New System.Drawing.Size(60, 18)
        Me.lbl_codigo_cap.TabIndex = 25
        Me.lbl_codigo_cap.Text = "Código:"
        '
        'btn_editar
        '
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(229, 249)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(77, 30)
        Me.btn_editar.TabIndex = 33
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(148, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 30)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(310, 249)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(77, 30)
        Me.btn_voltar.TabIndex = 35
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(13, 12)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(113, 20)
        Me.lbl_titulo.TabIndex = 55
        Me.lbl_titulo.Text = "Capacitação X"
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(455, 7)
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
        Me.btn_fechar.Location = New System.Drawing.Point(478, 7)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 53
        Me.btn_fechar.Text = "x"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'frm_VisualizacaoCapacitacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(508, 308)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_validade)
        Me.Controls.Add(Me.txt_capacitacao)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.txt_codigo_cap)
        Me.Controls.Add(Me.lbl_descricao)
        Me.Controls.Add(Me.lbl_capacitacao)
        Me.Controls.Add(Me.lbl_codigo_cap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_VisualizacaoCapacitacao"
        Me.Text = "Capacitação X"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_validade As System.Windows.Forms.Label
    Friend WithEvents txt_capacitacao As System.Windows.Forms.TextBox
    Friend WithEvents txt_descricao As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo_cap As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descricao As System.Windows.Forms.Label
    Friend WithEvents lbl_capacitacao As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_cap As System.Windows.Forms.Label
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
End Class
