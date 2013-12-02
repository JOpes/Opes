<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CriarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CriarUsuario))
        Me.lbl_nome_func = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_nome_usuario = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.lbl_confirma = New System.Windows.Forms.Label()
        Me.txt_nome_func = New System.Windows.Forms.TextBox()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.txt_nome_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_confirma = New System.Windows.Forms.TextBox()
        Me.btn_cadastra = New System.Windows.Forms.Button()
        Me.btn_cancela = New System.Windows.Forms.Button()
        Me.lbl_nivelacesso = New System.Windows.Forms.Label()
        Me.cmb_nivel_acesso_usuario = New System.Windows.Forms.ComboBox()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_nome_func
        '
        Me.lbl_nome_func.AutoSize = True
        Me.lbl_nome_func.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_func.Location = New System.Drawing.Point(173, 100)
        Me.lbl_nome_func.Name = "lbl_nome_func"
        Me.lbl_nome_func.Size = New System.Drawing.Size(53, 18)
        Me.lbl_nome_func.TabIndex = 0
        Me.lbl_nome_func.Text = "Nome:"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matricula.Location = New System.Drawing.Point(154, 128)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(72, 18)
        Me.lbl_matricula.TabIndex = 1
        Me.lbl_matricula.Text = "Matrícula:"
        '
        'lbl_nome_usuario
        '
        Me.lbl_nome_usuario.AutoSize = True
        Me.lbl_nome_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_usuario.Location = New System.Drawing.Point(97, 186)
        Me.lbl_nome_usuario.Name = "lbl_nome_usuario"
        Me.lbl_nome_usuario.Size = New System.Drawing.Size(129, 18)
        Me.lbl_nome_usuario.TabIndex = 3
        Me.lbl_nome_usuario.Text = "Nome de Usuário:"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.Location = New System.Drawing.Point(172, 214)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(54, 18)
        Me.lbl_senha.TabIndex = 4
        Me.lbl_senha.Text = "Senha:"
        '
        'lbl_confirma
        '
        Me.lbl_confirma.AutoSize = True
        Me.lbl_confirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirma.Location = New System.Drawing.Point(107, 242)
        Me.lbl_confirma.Name = "lbl_confirma"
        Me.lbl_confirma.Size = New System.Drawing.Size(119, 18)
        Me.lbl_confirma.TabIndex = 5
        Me.lbl_confirma.Text = "Confirma Senha:"
        '
        'txt_nome_func
        '
        Me.txt_nome_func.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_func.Location = New System.Drawing.Point(241, 97)
        Me.txt_nome_func.MaxLength = 90
        Me.txt_nome_func.Name = "txt_nome_func"
        Me.txt_nome_func.Size = New System.Drawing.Size(159, 24)
        Me.txt_nome_func.TabIndex = 6
        '
        'txt_matricula
        '
        Me.txt_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(241, 125)
        Me.txt_matricula.MaxLength = 8
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(159, 24)
        Me.txt_matricula.TabIndex = 7
        '
        'txt_nome_usuario
        '
        Me.txt_nome_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_usuario.Location = New System.Drawing.Point(241, 183)
        Me.txt_nome_usuario.MaxLength = 25
        Me.txt_nome_usuario.Name = "txt_nome_usuario"
        Me.txt_nome_usuario.Size = New System.Drawing.Size(159, 24)
        Me.txt_nome_usuario.TabIndex = 9
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(241, 211)
        Me.txt_senha.MaxLength = 12
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(159, 24)
        Me.txt_senha.TabIndex = 10
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_confirma
        '
        Me.txt_confirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirma.Location = New System.Drawing.Point(242, 239)
        Me.txt_confirma.MaxLength = 12
        Me.txt_confirma.Name = "txt_confirma"
        Me.txt_confirma.Size = New System.Drawing.Size(158, 24)
        Me.txt_confirma.TabIndex = 11
        Me.txt_confirma.UseSystemPasswordChar = True
        '
        'btn_cadastra
        '
        Me.btn_cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastra.Location = New System.Drawing.Point(194, 291)
        Me.btn_cadastra.Name = "btn_cadastra"
        Me.btn_cadastra.Size = New System.Drawing.Size(82, 28)
        Me.btn_cadastra.TabIndex = 12
        Me.btn_cadastra.Text = "Cadastrar"
        Me.btn_cadastra.UseVisualStyleBackColor = True
        '
        'btn_cancela
        '
        Me.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancela.Location = New System.Drawing.Point(290, 291)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(82, 28)
        Me.btn_cancela.TabIndex = 13
        Me.btn_cancela.Text = "Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'lbl_nivelacesso
        '
        Me.lbl_nivelacesso.AutoSize = True
        Me.lbl_nivelacesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nivelacesso.Location = New System.Drawing.Point(108, 156)
        Me.lbl_nivelacesso.Name = "lbl_nivelacesso"
        Me.lbl_nivelacesso.Size = New System.Drawing.Size(118, 18)
        Me.lbl_nivelacesso.TabIndex = 2
        Me.lbl_nivelacesso.Text = "Nível de Acesso:"
        '
        'cmb_nivel_acesso_usuario
        '
        Me.cmb_nivel_acesso_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nivel_acesso_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nivel_acesso_usuario.FormattingEnabled = True
        Me.cmb_nivel_acesso_usuario.Items.AddRange(New Object() {"Administrador", "Usuário"})
        Me.cmb_nivel_acesso_usuario.Location = New System.Drawing.Point(241, 153)
        Me.cmb_nivel_acesso_usuario.Name = "cmb_nivel_acesso_usuario"
        Me.cmb_nivel_acesso_usuario.Size = New System.Drawing.Size(159, 26)
        Me.cmb_nivel_acesso_usuario.TabIndex = 8
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(528, 7)
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
        Me.btn_fechar.Location = New System.Drawing.Point(551, 7)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 15
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
        Me.lbl_titulo.Size = New System.Drawing.Size(104, 20)
        Me.lbl_titulo.TabIndex = 21
        Me.lbl_titulo.Text = "Novo Usuário"
        '
        'frm_CriarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(581, 347)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.cmb_nivel_acesso_usuario)
        Me.Controls.Add(Me.lbl_nivelacesso)
        Me.Controls.Add(Me.btn_cancela)
        Me.Controls.Add(Me.btn_cadastra)
        Me.Controls.Add(Me.txt_confirma)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_nome_usuario)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.txt_nome_func)
        Me.Controls.Add(Me.lbl_confirma)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_nome_usuario)
        Me.Controls.Add(Me.lbl_matricula)
        Me.Controls.Add(Me.lbl_nome_func)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_CriarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criar Usuário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nome_func As System.Windows.Forms.Label
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_nome_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_senha As System.Windows.Forms.Label
    Friend WithEvents lbl_confirma As System.Windows.Forms.Label
    Friend WithEvents txt_nome_func As System.Windows.Forms.TextBox
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents txt_nome_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Friend WithEvents txt_confirma As System.Windows.Forms.TextBox
    Friend WithEvents btn_cadastra As System.Windows.Forms.Button
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    Friend WithEvents lbl_nivelacesso As System.Windows.Forms.Label
    Friend WithEvents cmb_nivel_acesso_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
End Class
