Public Class frm_editaFornecedor

    Dim helper1 As String

    Private Sub frm_editaFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fechar.Click
        Me.Close()
    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salvar.Click
        Dim flag1, flag2 As Integer
        Dim empresa, cnpj, endereço, bairro, cep, cidade, uf, telefone, ramal, fax As String

        helper1 = lbl_CNPJ_oculto.Text

        If helper1 = lbl_CNPJ_oculto.Text Then
            IsNothing(lbl_CNPJ_oculto)
        Else
            IsNothing(lbl_CNPJ_oculto)
        End If

        'capturando dados para comparação

        empresa = Me.txt_empresa_edita.Text
        cnpj = Me.txt_id2_edita.Text
        endereço = Me.txt_endereco_edita.Text
        bairro = Me.txt_bairro_edita.Text
        cep = Me.txt_cep_edita.Text
        cidade = Me.txt_cep_edita.Text
        uf = Me.txt_uf_edita.Text
        telefone = Me.txt_telefone_edita.Text
        ramal = Me.txt_ramal_edita.Text
        fax = Me.txt_fax_edita.Text

        'verificando se algum campo está vazio antes de apertar o botão
        'se for true, tem campo em branco
        If Me.txt_bairro_edita.Text = "" Or Me.txt_cep_edita.Text = "" Or Me.txt_cidade_edita.Text = "" Or Me.txt_empresa_edita.Text = "" Or Me.txt_endereco_edita.Text = "" Or Me.txt_fax_edita.Text = "" Or Me.txt_id2_edita.Text = "" Or Me.txt_ramal_edita.Text = "" Or Me.txt_telefone_edita.Text = "" Or Me.txt_uf_edita.Text = "" Then
            flag2 = True
        Else
            flag2 = False
        End If



        If flag1 = True Then
            If MessageBox.Show("Campos sem alteração ou em branco. Deseja preenchê-los?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'do nothing
            Else
                Me.Close()
            End If

        Else 'Mudando as coisas já definidas '-'
            If empresa <> frm_VisualizaFornecedor.txt_empresa.Text Or cnpj <> frm_VisualizaFornecedor.msk_cnpj.Text Or endereço <> frm_VisualizaFornecedor.txt_endereco.Text Or bairro <> frm_VisualizaFornecedor.txt_bairro.Text Or cep <> frm_VisualizaFornecedor.txt_cep.Text Or cidade <> frm_VisualizaFornecedor.txt_cidade.Text Or uf <> frm_VisualizaFornecedor.txt_uf.Text Or telefone <> frm_VisualizaFornecedor.txt_telefone.Text Or ramal <> frm_VisualizaFornecedor.txt_ramal.Text Or fax <> frm_VisualizaFornecedor.txt_fax.Text Then

                frm_VisualizaFornecedor.txt_bairro.Text = Me.txt_bairro_edita.Text
                frm_VisualizaFornecedor.txt_empresa.Text = Me.txt_empresa_edita.Text
                frm_VisualizaFornecedor.txt_endereco.Text = Me.txt_endereco_edita.Text
                frm_VisualizaFornecedor.txt_cep.Text = Me.txt_cep_edita.Text
                frm_VisualizaFornecedor.txt_cidade.Text = Me.txt_cidade_edita.Text
                frm_VisualizaFornecedor.txt_uf.Text = Me.txt_uf_edita.Text
                frm_VisualizaFornecedor.txt_telefone.Text = Me.txt_telefone_edita.Text
                frm_VisualizaFornecedor.txt_ramal.Text = Me.txt_ramal_edita.Text
                frm_VisualizaFornecedor.txt_ramal.Text = Me.txt_ramal_edita.Text
                frm_VisualizaFornecedor.msk_cnpj.Text = Me.txt_id2_edita.Text

                MsgBox("As alterações foram salvas com sucesso!")

                If frm_CadastroFornecedor.lst_cnpj.Items.Contains(helper1) Then
                    frm_CadastroFornecedor.lst_cnpj.Items(frm_CadastroFornecedor.lst_cnpj.SelectedItem = Me.helper1) = Me.txt_id2_edita.Text
                End If

            End If

        End If
    End Sub

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voltar.Click
        Me.txt_bairro_edita.Clear()
        Me.txt_cep_edita.Clear()
        Me.txt_cidade_edita.Clear()
        Me.txt_empresa_edita.Clear()
        Me.txt_endereco_edita.Clear()
        Me.txt_fax_edita.Clear()
        Me.txt_id2_edita.Clear()
        Me.txt_ramal_edita.Clear()
        Me.txt_telefone_edita.Clear()
        Me.txt_uf_edita.SelectedIndex = 0

    End Sub
End Class