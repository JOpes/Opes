Public Class frm_Entrar

    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2
    Dim i As String, s As String
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

    Private Sub chk_senha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_senha.CheckedChanged
        If chk_senha.Checked = True Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar()
    End Sub

    Private Sub btn_fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fechar.Click
        If MessageBox.Show("Deseja mesmo sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_entrar_Click(sender As System.Object, e As System.EventArgs) Handles btn_entrar.Click
        If (txt_usuario.Text = "") Or (txt_senha.Text = "") Then
            MsgBox("Preencha todos os campos!")
        Else
            ' Verificando se há o login do usuário no array
            For i As Integer = 1 To 20 Step 1
                If u(i).login = txt_usuario.Text Then
                    aux = i
                End If
            Next
            If (aux > 0 And aux <= 20) Then
                If u(aux).senha = txt_senha.Text Then
                    frm_Menu.Show()
                    Me.Hide()
                    txt_senha.Clear()
                    txt_usuario.Clear()

                Else
                    MsgBox("Senha incorreta!")
                    txt_senha.Clear()
                    txt_senha.Focus()
                End If
            Else
                MsgBox("Usuário incorreto!")
            End If
        End If
    End Sub

    Private Sub btn_sair_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_sair.Click
        End
    End Sub

  
End Class