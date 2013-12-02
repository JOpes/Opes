Public Class frm_GerenciaUsuarios

    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2
    Dim aux As Integer

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
            limparGerenciarUsuarios()
            Me.Close()
        End If
    End Sub

    Private Sub btn_voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voltar.Click
        If MessageBox.Show("Deseja voltar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            limparGerenciarUsuarios()
            Me.Close()
        End If
    End Sub

    Private Sub cmb_usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_usuario.SelectedIndexChanged
        If cmb_usuario.SelectedIndex = -1 Then
            limparGerenciarUsuarios()
        Else
            txt_matricula.Text = u(cmb_usuario.SelectedIndex + 1).matricula
            txt_nivel.Text = u(cmb_usuario.SelectedIndex + 1).nivel
            txt_nomeusuario.Text = u(cmb_usuario.SelectedIndex + 1).login
            txt_senha.Text = u(cmb_usuario.SelectedIndex + 1).senha
            txt_date.Text = u(cmb_usuario.SelectedIndex + 1).data
        End If
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If btn_editar.Text = "Editar" Then
            txt_matricula.ReadOnly = False
            txt_nivel.ReadOnly = False
            txt_nomeusuario.ReadOnly = False
            txt_senha.ReadOnly = False
            cmb_usuario.Enabled = False
            btn_editar.Text = "Salvar"
            txt_matricula.Focus()
        ElseIf btn_editar.Text = "Salvar" Then
            u(cmb_usuario.SelectedIndex + 1).editarUsuario(txt_matricula.Text, txt_nivel.Text, txt_nomeusuario.Text, txt_senha.Text)
            txt_matricula.ReadOnly = True
            txt_nivel.ReadOnly = True
            txt_nomeusuario.ReadOnly = True
            txt_senha.ReadOnly = True
            cmb_usuario.Enabled = True
            btn_editar.Text = "Editar"
            cmb_usuario.Focus()
        End If
    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frm_GerenciaUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 20 Step 1
            If (u(i).nome <> "") Then
                cmb_usuario.Items.Add(u(i).nome)
            End If
        Next
    End Sub
End Class