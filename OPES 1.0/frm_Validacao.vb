Public Class frm_Validacao

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
            txt_cargahoraria.Clear()
            txt_codigo.Clear()
            cmb_fornecedor.SelectedIndex = -1
            txt_instrutor.Clear()
            txt_local.Clear()
            IsNothing(cmb_capacitacao)
        Else
            'do nothing
        End If
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            txt_cargahoraria.Clear()
            txt_codigo.Clear()
            cmb_fornecedor.SelectedIndex = -1
            txt_instrutor.Clear()
            txt_local.Clear()
            IsNothing(cmb_capacitacao)
        Else
            'do nothing
        End If
    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Visible = True
            txt_motivo_ausencia.Visible = True
        Else
            Label1.Visible = False
            txt_motivo_ausencia.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Visible = True
            txt_motivo_ausencia.Visible = True
        Else
            Label1.Visible = False
            txt_motivo_ausencia.Visible = False
        End If
    End Sub
End Class