Public Class frm_Menu

    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2
    Dim pv As Boolean = False

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
        If MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            frm_Entrar.Show()
            Me.Close()

        End If
    End Sub

    Private Sub CapacitaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitaçãoToolStripMenuItem.Click
        frm_CadastroCapacitacao.Show()
    End Sub

    Private Sub UsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuárioToolStripMenuItem.Click
        frm_CriarUsuario.Show()
    End Sub

    Private Sub FornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedorToolStripMenuItem.Click
        frm_CadastroFornecedor.Show()
    End Sub

    Private Sub CapacitaçãoObrigatóriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitaçãoObrigatóriaToolStripMenuItem.Click
        frm_CapacitacaoObrigatoria.Show()
    End Sub

    Private Sub AgendamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendamentoToolStripMenuItem.Click
        frm_AgendamentoCapacitacao.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem.Click
        frm_GerenciaUsuarios.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        frm_VisualizaFornecedor.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        frm_VisualizacaoFuncionario.Show()
    End Sub

    Private Sub CapacitaçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitaçõesToolStripMenuItem.Click
        frm_VisualizacaoCapacitacao.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frm_Agenda.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If MessageBox.Show("Deseja realmente fazer Log Off?", "Aviso", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
            frm_Entrar.Show()
            frm_Entrar.txt_senha.Clear()
            frm_Entrar.txt_usuario.Clear()
            Me.Close()

        End If
    End Sub
End Class