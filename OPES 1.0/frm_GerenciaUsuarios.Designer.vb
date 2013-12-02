<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GerenciaUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GerenciaUsuarios))
        Me.lbl_nomeusuario = New System.Windows.Forms.Label()
        Me.txt_nomeusuario = New System.Windows.Forms.TextBox()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.cmb_usuario = New System.Windows.Forms.ComboBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_nivelacesso = New System.Windows.Forms.Label()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.txt_nivel = New System.Windows.Forms.TextBox()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_nomeusuario
        '
        Me.lbl_nomeusuario.AutoSize = True
        Me.lbl_nomeusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomeusuario.Location = New System.Drawing.Point(100, 123)
        Me.lbl_nomeusuario.Name = "lbl_nomeusuario"
        Me.lbl_nomeusuario.Size = New System.Drawing.Size(129, 18)
        Me.lbl_nomeusuario.TabIndex = 1
        Me.lbl_nomeusuario.Text = "Nome de Usuário:"
        '
        'txt_nomeusuario
        '
        Me.txt_nomeusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomeusuario.Location = New System.Drawing.Point(235, 118)
        Me.txt_nomeusuario.Name = "txt_nomeusuario"
        Me.txt_nomeusuario.ReadOnly = True
        Me.txt_nomeusuario.Size = New System.Drawing.Size(126, 24)
        Me.txt_nomeusuario.TabIndex = 1
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(457, 6)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(24, 29)
        Me.btn_min.TabIndex = 9
        Me.btn_min.Text = "__"
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_fechar.Location = New System.Drawing.Point(480, 6)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(24, 29)
        Me.btn_fechar.TabIndex = 8
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
        Me.lbl_titulo.Size = New System.Drawing.Size(72, 20)
        Me.lbl_titulo.TabIndex = 10
        Me.lbl_titulo.Text = "Usuários"
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(264, 292)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(77, 33)
        Me.btn_voltar.TabIndex = 8
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'cmb_usuario
        '
        Me.cmb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.Location = New System.Drawing.Point(199, 75)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(161, 26)
        Me.cmb_usuario.TabIndex = 0
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(127, 78)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(64, 18)
        Me.lbl_usuario.TabIndex = 15
        Me.lbl_usuario.Text = "Usuário:"
        '
        'btn_editar
        '
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(178, 292)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(77, 33)
        Me.btn_editar.TabIndex = 7
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.Location = New System.Drawing.Point(175, 235)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(54, 18)
        Me.lbl_senha.TabIndex = 20
        Me.lbl_senha.Text = "Senha:"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(235, 232)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.ReadOnly = True
        Me.txt_senha.Size = New System.Drawing.Size(126, 24)
        Me.txt_senha.TabIndex = 6
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matricula.Location = New System.Drawing.Point(157, 149)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(72, 18)
        Me.lbl_matricula.TabIndex = 0
        Me.lbl_matricula.Text = "Matrícula:"
        '
        'lbl_nivelacesso
        '
        Me.lbl_nivelacesso.AutoSize = True
        Me.lbl_nivelacesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nivelacesso.Location = New System.Drawing.Point(111, 205)
        Me.lbl_nivelacesso.Name = "lbl_nivelacesso"
        Me.lbl_nivelacesso.Size = New System.Drawing.Size(118, 18)
        Me.lbl_nivelacesso.TabIndex = 4
        Me.lbl_nivelacesso.Text = "Nível de Acesso:"
        '
        'txt_matricula
        '
        Me.txt_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(235, 146)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.ReadOnly = True
        Me.txt_matricula.Size = New System.Drawing.Size(126, 24)
        Me.txt_matricula.TabIndex = 2
        '
        'txt_nivel
        '
        Me.txt_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nivel.Location = New System.Drawing.Point(235, 204)
        Me.txt_nivel.Name = "txt_nivel"
        Me.txt_nivel.ReadOnly = True
        Me.txt_nivel.Size = New System.Drawing.Size(126, 24)
        Me.txt_nivel.TabIndex = 3
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.Location = New System.Drawing.Point(186, 178)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(43, 18)
        Me.lbl_data.TabIndex = 21
        Me.lbl_data.Text = "Data:"
        '
        'txt_date
        '
        Me.txt_date.BackColor = System.Drawing.SystemColors.Control
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(235, 175)
        Me.txt_date.MaxLength = 10
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(126, 24)
        Me.txt_date.TabIndex = 22
        '
        'frm_GerenciaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(514, 367)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.cmb_usuario)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.txt_nivel)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.txt_nomeusuario)
        Me.Controls.Add(Me.lbl_nivelacesso)
        Me.Controls.Add(Me.lbl_nomeusuario)
        Me.Controls.Add(Me.lbl_matricula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_GerenciaUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Usuários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nomeusuario As System.Windows.Forms.Label
    Friend WithEvents txt_nomeusuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
    Friend WithEvents cmb_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents lbl_senha As System.Windows.Forms.Label
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_nivelacesso As System.Windows.Forms.Label
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents txt_nivel As System.Windows.Forms.TextBox
    Friend WithEvents lbl_data As System.Windows.Forms.Label
    Friend WithEvents txt_date As System.Windows.Forms.TextBox
End Class
