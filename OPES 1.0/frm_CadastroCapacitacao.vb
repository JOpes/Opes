Public Class frm_CadastroCapacitacao
    Dim contador As Integer
    Dim data As String
    Dim i As Integer
    Dim aux, j As Integer
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
        'If MessageBox.Show("Deseja fechar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        txt_capacitacao.Clear()
        txt_descricao.Clear()
        Me.Close()
        'Else
        'do nothing
        'End If
    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click
        If MessageBox.Show("Deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txt_capacitacao.Clear()
            txt_descricao.Clear()
            Me.Close()
        Else
            'do nothing
        End If
        
    End Sub

    Private Sub btn_cadastra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastra.Click
        If (txt_capacitacao.Text = "" Or txt_descricao.Text = "" Or txt_duracao.Text = "") Then
            MsgBox("Preencha todos os campos!")
            txt_capacitacao.Focus()
        Else
            If (txt_duracao.BackColor = Color.Red) Then
                MsgBox("Preencha o campo de validade com apenas números!")
                txt_duracao.Focus()
            Else
                aux = 0
                j = 1
                While (j <= 20) And aux = 0
                    If (c(j).nome = vbNullString Or c(j).nome = "") Then
                        aux = j
                    Else
                        j = j + 1
                    End If
                End While
                If (aux <> 0) Then
                    c(aux).novaCapacitacao(lbl_cod.Text, txt_capacitacao.Text, txt_descricao.Text, txt_duracao.Text)
                    MsgBox("Cadastro realizado com sucesso!")
                Else
                    MsgBox("Array Insuficiente!")
                End If
                    End If
                End If
        End Sub

    Private Sub btn_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frm_CadastroCapacitacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        i = Integer.Parse(lbl_cod.Text)
    End Sub

    Private Sub txt_duracao_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_duracao.TextChanged
        If Not (txt_duracao.Text = "") Then
            If Not (IsNumeric(txt_duracao.Text)) Then
                txt_duracao.BackColor = Color.Red
            Else
                txt_duracao.BackColor = Color.White
            End If
        Else
            txt_duracao.BackColor = Color.White
        End If
    End Sub
End Class