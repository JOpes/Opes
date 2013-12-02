Public Class frm_consultaFornecedor
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
    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frm_consultaFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fechar.Click
        Me.Close()

    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        If (Me.lst_pesquisa_fornecedor.SelectedItem = "GSO") Then
            frm_VisualizaFornecedor.txt_empresa.Text = frm_CadastroFornecedor.txt_empresa.Text
            'GSO foi um teste..
        ElseIf (Me.lst_pesquisa_fornecedor.SelectedItem = "Tzusk Co.") Then
            frm_VisualizaFornecedor.txt_empresa.Text = "Tzusk Co."
            frm_VisualizaFornecedor.msk_cnpj.Text = "31565104029310"
            frm_VisualizaFornecedor.txt_cep.Text = "54590000"
            frm_VisualizaFornecedor.txt_cidade.Text = "Itú"
            frm_VisualizaFornecedor.txt_endereco.Text = "Rua Sorocaba, Nº 1251"
            frm_VisualizaFornecedor.txt_fax.Text = "1149787656"
            frm_VisualizaFornecedor.txt_ramal.Text = "1234"
            frm_VisualizaFornecedor.txt_telefone.Text = "1141234432"
            frm_VisualizaFornecedor.txt_uf.Text = "SP"
            frm_VisualizaFornecedor.txt_bairro.Text = "Cabo de Santo Agostinho"
            frm_VisualizaFornecedor.lbl_titulo.Text = "Consultar dados - " & Me.lst_pesquisa_fornecedor.SelectedItem
        Else
            'do nothing
        End If

        frm_VisualizaFornecedor.Show()

    End Sub

    Private Sub cmb_criterio_pesquisa_fornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_criterio_pesquisa_fornecedor.SelectedIndexChanged

    End Sub

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voltar.Click
        Me.Close()
        txt_pesquisa_fornecedor.Clear()
        cmb_criterio_pesquisa_fornecedor.SelectedIndex = 0
    End Sub
End Class