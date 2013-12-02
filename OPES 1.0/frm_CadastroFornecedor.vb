Public Class frm_CadastroFornecedor

    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2
    Dim validade As Boolean

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
            Me.txt_empresa.Clear()
            'Me.txt_id2.Clear()
            Me.txt_bairro_fornecedor.Clear()
            Me.txt_cep_fornecedor.Clear()
            Me.txt_cidade_fornecedor.Clear()
            Me.txt_endedero_fornecedor.Clear()
            Me.txt_endedero_fornecedor.Clear()
            Me.txt_fax_fornecedor.Clear()
            Me.txt_ramal_fornecedor.Clear()
            Me.txt_telefone_fornecedor.Clear()
            Me.Close()

        Else
            'do nothing
        End If
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txt_empresa.Clear()
            txt_bairro_fornecedor.Clear()
            txt_cep_fornecedor.Clear()
            txt_cidade_fornecedor.Clear()
            txt_endedero_fornecedor.Clear()
            txt_endedero_fornecedor.Clear()
            txt_fax_fornecedor.Clear()
            txt_ramal_fornecedor.Clear()
            txt_telefone_fornecedor.Clear()
            cmb_uf.SelectedIndex = 0
            Hide()

        Else
            'do nothing
        End If
    End Sub

    Private Sub btn_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpar.Click
        Me.txt_empresa.Clear()
        Me.txt_cnpj.Clear()
        Me.txt_bairro_fornecedor.Clear()
        Me.txt_cep_fornecedor.Clear()
        Me.txt_cidade_fornecedor.Clear()
        Me.txt_endedero_fornecedor.Clear()
        Me.txt_endedero_fornecedor.Clear()
        Me.txt_fax_fornecedor.Clear()
        Me.txt_ramal_fornecedor.Clear()
        Me.txt_telefone_fornecedor.Clear()
        Me.cmb_uf.SelectedIndex = 0
        Me.msk_telefone.Clear()
        Me.msk_fax.Clear()
        Me.msk_cep.Clear()
    End Sub

    Private Sub btn_cadastra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra.Click
        Dim flag_cnpj, campo As Boolean
        Dim flag_valido As Boolean

        'comparar e ver se já existe
        For Each txt_id2 As String In lst_cnpj.Items
            If lst_cnpj.Items.Contains(Me.txt_cnpj.Text) Then
                flag_cnpj = True
            Else
                flag_cnpj = False
            End If
        Next


        If txt_cnpj.BackColor = Color.Red Then

            flag_valido = False

        Else
            flag_valido = True
        End If

        'verificar se tá em branco
        If txt_bairro_fornecedor.Text = "" Or msk_cep.Text = "" Or txt_cidade_fornecedor.Text = "" Or txt_empresa.Text = "" Or txt_endedero_fornecedor.Text = "" Or msk_fax.Text = "" Or txt_cnpj.Text = "" Or txt_ramal_fornecedor.Text = "" Or msk_telefone.Text = "" Then
            campo = True
        Else
            campo = False
        End If



        If flag_cnpj = False And campo = False And flag_valido = True Then
            frm_consultaFornecedor.lst_pesquisa_fornecedor.Items.Add(Me.txt_empresa.Text)
            frm_Validacao.cmb_fornecedor.Items.Add(Me.txt_empresa.Text)


            MsgBox("Cadastrado com sucesso!", , "Aviso")

            lst_cnpj.Items.Add(Me.txt_cnpj.Text)

            '     If frm_consultaFornecedor.lst_pesquisa_fornecedor.SelectedItem(Me.txt_empresa.Text) Then
            '          frm_VisualizaFornecedor.txt_bairro.Text = Me.txt_bairro_fornecedor.Text
            '           frm_VisualizaFornecedor.txt_ramal.Text = Me.txt_ramal_fornecedor.Text
            '            frm_VisualizaFornecedor.txt_telefone.Text = Me.txt_telefone_fornecedor.Text
            '             frm_VisualizaFornecedor.txt_uf.Text = Me.cmb_uf.SelectedItem
            '              frm_VisualizaFornecedor.txt_cep.Text = Me.txt_cep_fornecedor.Text
            '               frm_VisualizaFornecedor.txt_cidade.Text = Me.txt_cidade_fornecedor.Text
            '            frm_VisualizaFornecedor.txt_fax.Text = Me.txt_fax_fornecedor.Text
            '                frm_VisualizaFornecedor.txt_endereco.Text = Me.txt_endedero_fornecedor.Text

            '          Else
            '               'do nothing
            '            End If


            Me.txt_bairro_fornecedor.Clear()
            Me.txt_cep_fornecedor.Clear()
            Me.txt_cidade_fornecedor.Clear()
            Me.txt_empresa.Clear()
            Me.txt_endedero_fornecedor.Clear()
            Me.txt_fax_fornecedor.Clear()
            Me.txt_cnpj.Clear()
            Me.txt_ramal_fornecedor.Clear()
            Me.txt_telefone_fornecedor.Clear()
            Me.cmb_uf.SelectedIndex = 0
            'Me.msk_cnpj.Clear()
            Me.msk_telefone.Clear()
            Me.msk_fax.Clear()
            Me.msk_cep.Clear()




        ElseIf flag_cnpj = False And campo = True Then
            MsgBox("Campo em Branco!")


        ElseIf flag_cnpj = True And campo = False Then
            MsgBox("Fornecedor já cadastrado!")
            txt_cnpj.Clear()
            'msk_cnpj.Clear()
            txt_cnpj.Focus()

        ElseIf flag_cnpj = True And campo = True Then
            MsgBox("Fornecedor já cadastrado!")
            txt_cnpj.Clear()
            'msk_cnpj.Clear()
            txt_cnpj.Focus()

        Else
            MsgBox("CNPJ Inválido.")
            'msk_cnpj.Clear()

        End If
    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txt_cnpj_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_cnpj.TextChanged
        If Not (txt_cnpj.Text = "") Then
            If CALCULO_CNPJ(txt_cnpj.Text) = False Then
                txt_cnpj.BackColor = Color.Red
            Else
                txt_cnpj.BackColor = Color.White
            End If
        Else
            txt_cnpj.BackColor = Color.White
        End If
    End Sub
End Class