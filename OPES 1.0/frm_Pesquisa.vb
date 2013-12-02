Public Class frm_Pesquisa

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
            Me.Close()
            If cmb_pesquisa.SelectedIndex <> 0 Then
                Me.cmb_pesquisa.SelectedIndex = 0

            Else
                'do nothing
            End If


        Else
            'do nothing
        End If
    End Sub

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voltar.Click

        If MessageBox.Show("Deseja voltar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cmb_pesquisa.SelectedIndex <> 0 Then
                Me.cmb_pesquisa.SelectedIndex = 0
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            'do nothing
        End If
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        frm_VisualizacaoFuncionario.Show()
        If lst_pesquisa.SelectedItem = "Emerson de Jesus" Then
            frm_VisualizacaoFuncionario.msk_cpf.Text = "0331234321"
            frm_VisualizacaoFuncionario.txt_função.Text = "Gerente de Marketing"
            frm_VisualizacaoFuncionario.txt_matricula.Text = "2110"
            frm_VisualizacaoFuncionario.msk_nascimento.Text = "14061997"
            frm_VisualizacaoFuncionario.txt_nome.Text = "Emerson de Jesus"
            frm_VisualizacaoFuncionario.txt_setor.Text = "Comércio"
            frm_VisualizacaoFuncionario.txt_sexo.Text = "Masculino"

            frm_VisualizacaoFuncionario.lst_historico.Items.Add("Empreendedorismo na prática")
            frm_VisualizacaoFuncionario.lst_historico.Items.Add("Mercado Atual - Exigência apurada!")
            frm_VisualizacaoFuncionario.lst_historico.Items.Add("Doutorado em Artes gráfica")
        End If
    End Sub

    Private Sub cmb_pesquisa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_pesquisa.SelectedIndexChanged

    End Sub

    Private Sub frm_Pesquisa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class