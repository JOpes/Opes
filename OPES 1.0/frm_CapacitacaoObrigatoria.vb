Public Class frm_CapacitacaoObrigatoria

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

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_funcionarios.SelectedIndexChanged
        lst_funcionarios.MultiColumn = True

    End Sub

    Private Sub btn_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fechar.Click
        If MessageBox.Show("Deseja fechar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            Me.Hide()
            frm_Menu.Show()
            txt_codigo.Clear()
            txt_pesquisa.Clear()
        End If
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            txt_codigo.Clear()
            txt_pesquisa.Clear()
        End If
        

    End Sub

    Private Sub btn_nova_capacitacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nova_capacitacao.Click
        frm_CadastroCapacitacao.Show()

    End Sub

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_cadastra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra.Click

    End Sub

    Private Sub pnl_1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnl_1.Paint

    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmb_fornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.cmb_capacitacao.SelectedItem = "Tzusk Co." Then

        End If
    End Sub

    Private Sub cmb_capacitacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_capacitacao.SelectedIndexChanged
        If Me.cmb_capacitacao.SelectedItem = "NR33" Then
            Me.txt_codigo.Text = "2"


        Else
            Me.txt_codigo.Clear()

        End If


    End Sub

    Private Sub frm_CapacitacaoObrigatoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 19 Step 1
            lst_funcionarios.Items.Add(fu(i))
        Next
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