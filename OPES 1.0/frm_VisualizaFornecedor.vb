Public Class frm_VisualizaFornecedor

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
        Me.Close()

    End Sub

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voltar.Click
        If MessageBox.Show("Deseja voltar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()


        Else
            'do nothing
        End If
    End Sub


    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_deletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cont As Integer
        cont = 0
        If MessageBox.Show("Deseja realmente excluir o fornecedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frm_CadastroFornecedor.lst_cnpj.Items.Remove(Me.txt_id2.Text)
            Me.txt_bairro.Clear()
            Me.txt_cep.Clear()
            Me.txt_cidade.Clear()
            Me.txt_empresa.Clear()
            Me.txt_endereco.Clear()
            Me.txt_fax.Clear()
            Me.txt_id2.Clear()
            Me.msk_cnpj.Clear()
            Me.txt_ramal.Clear()
            Me.txt_telefone.Clear()
            Me.txt_uf.Clear()
            frm_consultaFornecedor.lst_pesquisa_fornecedor.Items.Remove(frm_consultaFornecedor.lst_pesquisa_fornecedor.SelectedItem)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_editaFornecedor.Show()
        txt_id2.Text = frm_editaFornecedor.lbl_CNPJ_oculto.Text
    End Sub
End Class