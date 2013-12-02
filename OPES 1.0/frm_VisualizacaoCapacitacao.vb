Public Class frm_VisualizacaoCapacitacao

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voltar.Click
        Me.txt_capacitacao.Clear()
        Me.txt_codigo_cap.Clear()
        Me.txt_descricao.Clear()

    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class