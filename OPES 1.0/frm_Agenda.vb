Public Class frm_Agenda

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

    Private Sub btn_validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validar.Click
        frm_Validacao.Show()

    End Sub

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub btn_nova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nova.Click
        frm_CadastroCapacitacao.Show()

    End Sub

    Private Sub dtm_data_pesquisa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtm_data_pesquisa.ValueChanged

    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mth_calendario_agenda_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mth_calendario_agenda.DateChanged

    End Sub
End Class