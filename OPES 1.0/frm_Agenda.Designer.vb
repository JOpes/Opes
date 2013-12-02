<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Agenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Agenda))
        Me.mth_calendario_agenda = New System.Windows.Forms.MonthCalendar()
        Me.lst_agenda = New System.Windows.Forms.ListBox()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.btn_visualizar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.grp_pesquisa = New System.Windows.Forms.GroupBox()
        Me.cmb_capacitacao = New System.Windows.Forms.ComboBox()
        Me.lbl_capacitacao = New System.Windows.Forms.Label()
        Me.dtm_data_pesquisa = New System.Windows.Forms.DateTimePicker()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.btn_nova = New System.Windows.Forms.Button()
        Me.lbl_cap = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.grp_pesquisa.SuspendLayout()
        Me.SuspendLayout()
        '
        'mth_calendario_agenda
        '
        Me.mth_calendario_agenda.Location = New System.Drawing.Point(36, 70)
        Me.mth_calendario_agenda.Name = "mth_calendario_agenda"
        Me.mth_calendario_agenda.TabIndex = 0
        '
        'lst_agenda
        '
        Me.lst_agenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_agenda.FormattingEnabled = True
        Me.lst_agenda.ItemHeight = 18
        Me.lst_agenda.Location = New System.Drawing.Point(333, 85)
        Me.lst_agenda.Name = "lst_agenda"
        Me.lst_agenda.Size = New System.Drawing.Size(399, 256)
        Me.lst_agenda.TabIndex = 3
        '
        'btn_validar
        '
        Me.btn_validar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_validar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validar.Location = New System.Drawing.Point(554, 359)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(86, 30)
        Me.btn_validar.TabIndex = 7
        Me.btn_validar.Text = "Validar"
        Me.btn_validar.UseVisualStyleBackColor = True
        '
        'btn_visualizar
        '
        Me.btn_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_visualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_visualizar.Location = New System.Drawing.Point(462, 359)
        Me.btn_visualizar.Name = "btn_visualizar"
        Me.btn_visualizar.Size = New System.Drawing.Size(86, 30)
        Me.btn_visualizar.TabIndex = 6
        Me.btn_visualizar.Text = "Visualizar"
        Me.btn_visualizar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(370, 359)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(86, 30)
        Me.btn_editar.TabIndex = 5
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'grp_pesquisa
        '
        Me.grp_pesquisa.Controls.Add(Me.cmb_capacitacao)
        Me.grp_pesquisa.Controls.Add(Me.lbl_capacitacao)
        Me.grp_pesquisa.Controls.Add(Me.dtm_data_pesquisa)
        Me.grp_pesquisa.Controls.Add(Me.lbl_data)
        Me.grp_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_pesquisa.Location = New System.Drawing.Point(18, 244)
        Me.grp_pesquisa.Name = "grp_pesquisa"
        Me.grp_pesquisa.Size = New System.Drawing.Size(269, 97)
        Me.grp_pesquisa.TabIndex = 7
        Me.grp_pesquisa.TabStop = False
        Me.grp_pesquisa.Text = "Pesquisa:"
        '
        'cmb_capacitacao
        '
        Me.cmb_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_capacitacao.FormattingEnabled = True
        Me.cmb_capacitacao.Items.AddRange(New Object() {"", "NR33"})
        Me.cmb_capacitacao.Location = New System.Drawing.Point(116, 56)
        Me.cmb_capacitacao.Name = "cmb_capacitacao"
        Me.cmb_capacitacao.Size = New System.Drawing.Size(121, 26)
        Me.cmb_capacitacao.TabIndex = 2
        '
        'lbl_capacitacao
        '
        Me.lbl_capacitacao.AutoSize = True
        Me.lbl_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacitacao.Location = New System.Drawing.Point(15, 59)
        Me.lbl_capacitacao.Name = "lbl_capacitacao"
        Me.lbl_capacitacao.Size = New System.Drawing.Size(95, 18)
        Me.lbl_capacitacao.TabIndex = 9
        Me.lbl_capacitacao.Text = "Capacitação:"
        '
        'dtm_data_pesquisa
        '
        Me.dtm_data_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtm_data_pesquisa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtm_data_pesquisa.Location = New System.Drawing.Point(116, 25)
        Me.dtm_data_pesquisa.MaxDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtm_data_pesquisa.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtm_data_pesquisa.Name = "dtm_data_pesquisa"
        Me.dtm_data_pesquisa.Size = New System.Drawing.Size(121, 24)
        Me.dtm_data_pesquisa.TabIndex = 1
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.Location = New System.Drawing.Point(67, 31)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(43, 18)
        Me.lbl_data.TabIndex = 7
        Me.lbl_data.Text = "Data:"
        '
        'btn_nova
        '
        Me.btn_nova.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nova.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova.Location = New System.Drawing.Point(65, 347)
        Me.btn_nova.Name = "btn_nova"
        Me.btn_nova.Size = New System.Drawing.Size(157, 37)
        Me.btn_nova.TabIndex = 4
        Me.btn_nova.Text = "Nova Capacitação"
        Me.btn_nova.UseVisualStyleBackColor = True
        '
        'lbl_cap
        '
        Me.lbl_cap.AutoSize = True
        Me.lbl_cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cap.Location = New System.Drawing.Point(330, 55)
        Me.lbl_cap.Name = "lbl_cap"
        Me.lbl_cap.Size = New System.Drawing.Size(179, 18)
        Me.lbl_cap.TabIndex = 11
        Me.lbl_cap.Text = "Capacitações agendadas:"
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.Transparent
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_min.Location = New System.Drawing.Point(699, 7)
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
        Me.btn_fechar.Location = New System.Drawing.Point(722, 7)
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
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 10)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(65, 20)
        Me.lbl_titulo.TabIndex = 15
        Me.lbl_titulo.Text = "Agenda"
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(646, 359)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(86, 30)
        Me.btn_voltar.TabIndex = 8
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'frm_Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(754, 405)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_min)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.lbl_cap)
        Me.Controls.Add(Me.btn_nova)
        Me.Controls.Add(Me.grp_pesquisa)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_visualizar)
        Me.Controls.Add(Me.btn_validar)
        Me.Controls.Add(Me.lst_agenda)
        Me.Controls.Add(Me.mth_calendario_agenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Agenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.grp_pesquisa.ResumeLayout(False)
        Me.grp_pesquisa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mth_calendario_agenda As System.Windows.Forms.MonthCalendar
    Friend WithEvents lst_agenda As System.Windows.Forms.ListBox
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    Friend WithEvents btn_visualizar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents grp_pesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_capacitacao As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_capacitacao As System.Windows.Forms.Label
    Friend WithEvents dtm_data_pesquisa As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_data As System.Windows.Forms.Label
    Friend WithEvents btn_nova As System.Windows.Forms.Button
    Friend WithEvents lbl_cap As System.Windows.Forms.Label
    Friend WithEvents btn_min As System.Windows.Forms.Button
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_voltar As System.Windows.Forms.Button
End Class
