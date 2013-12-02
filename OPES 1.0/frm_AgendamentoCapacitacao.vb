Public Class frm_AgendamentoCapacitacao

    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub

    Private Sub btn_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fechar.Click
        If MessageBox.Show("Deseja fechar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.txt_cargahoraria.Clear()
            Me.txt_codigo.Clear()
            Me.cmb_forn.SelectedIndex = 0
            Me.txt_instrutor.Clear()
            Me.txt_local.Clear()
            Me.txt_pesquisa.Clear()
            Me.Close()
        Else
            'do nothing
        End If

    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click

        If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.txt_cargahoraria.Clear()
            Me.txt_codigo.Clear()
            Me.cmb_forn.SelectedIndex = 0
            Me.txt_instrutor.Clear()
            Me.txt_local.Clear()
            Me.txt_pesquisa.Clear()
            Me.Close()
        Else
            'do nothing
        End If



        
    End Sub

    Private Sub frm_AgendamentoCapacitacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_nova_capacitacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nova_capacitacao.Click
        frm_CadastroCapacitacao.Show()
    End Sub

    Private Sub dtg_funcionarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub cmb_forn_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_forn.SelectedIndexChanged





        Me.txt_local.Text = "Rua Sorocaba, Nº 1251 -Itú, SP"
        frm_VisualizaFornecedor.txt_fax.Text = "1149787656"
        frm_VisualizaFornecedor.txt_ramal.Text = "1234"
        frm_VisualizaFornecedor.txt_telefone.Text = "1141234432"
        frm_VisualizaFornecedor.txt_uf.Text = "SP"
        frm_VisualizaFornecedor.txt_bairro.Text = "Cabo de Santo Agostinho"
        frm_VisualizaFornecedor.lbl_titulo.Text = "Consultar dados - " & Me.cmb_capacitacao.SelectedItem
    End Sub

    Private Sub btn_cadastra_Click(sender As System.Object, e As System.EventArgs) Handles btn_cadastra.Click
        
    End Sub

    Private Sub btn_adiciona_Click(sender As System.Object, e As System.EventArgs) Handles btn_adiciona.Click
        If lst_funcionarios.SelectedItem = "Emerson de Jesus" Then
            lst_funcionarios.Items.Clear()
            lst_agendados.Items.Add("Emerson de Jesus")
        End If
    End Sub

    Private Sub btn_remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_remove.Click
        If lst_agendados.SelectedItem = "Emerson de Jesus" Then
            lst_agendados.Items.Clear()
            lst_funcionarios.Items.Add("Emerson de Jesus")
        End If
    End Sub

    
End Class