Public Class frm_CriarUsuario

    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2
    Dim aux, j As Integer

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
            limparCriarUsuario()
            Me.Close()
        End If
        End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            limparCriarUsuario()
            Me.Close()
        End If
    End Sub

    Private Sub btn_cadastra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra.Click
        If (txt_nome_func.Text = "" Or txt_nome_usuario.Text = "" Or txt_matricula.Text = "" Or txt_confirma.Text = "" Or txt_senha.Text = "" Or cmb_nivel_acesso_usuario.SelectedIndex < 0) Then
            MsgBox("Preencha todos os campos!")
        Else
            aux = 0
            ' Verifica se já possui o usuário cadastrado
            For i As Integer = 1 To 20 Step 1
                If u(i).login = txt_nome_usuario.Text Then
                    aux = i
                End If
            Next
            If aux <> 0 Then
                MsgBox("Nome de usuário já existente!")
                txt_nome_usuario.Focus()
            Else
                If (txt_confirma.BackColor <> Color.White) Then
                    MsgBox("A confirmação da senha não confere!")
                    txt_confirma.Focus()
                Else
                    aux = 0
                    j = 1
                    While (j <= 20) And aux = 0
                        If (u(j).nome = vbNullString Or u(j).nome = "") Then
                            aux = j
                        Else
                            j = j + 1
                        End If
                    End While
                    If (aux <> 0) Then
                        u(aux).novoUsuario(txt_nome_func.Text, txt_senha.Text, txt_nome_usuario.Text, Now(), cmb_nivel_acesso_usuario.Text, txt_matricula.Text)
                        MsgBox("Cadastro realizado com sucesso!")
                        limparCriarUsuario()
                        txt_nome_func.Focus()
                    Else
                        MsgBox("Array Insuficiente!")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txt_confirma_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_confirma.TextChanged
        If (txt_confirma.Text <> "") Then
            If (txt_confirma.Text <> txt_senha.Text) Then
                txt_confirma.BackColor = Color.Red
            Else
                txt_confirma.BackColor = Color.White
            End If
        Else
            txt_confirma.BackColor = Color.White
        End If
    End Sub
End Class