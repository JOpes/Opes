Module Modulo
    Public u(20) As usuario
    Public fo(20) As Fornecedor
    Public c(20) As Capacitacao
    Public fu(20) As Funcionario

    Public Sub carregar()
        For i As Integer = 1 To 20 Step 1
            u(i) = New usuario
            fo(i) = New Fornecedor
            c(i) = New Capacitacao
            fu(i) = New Funcionario
        Next
        u(1).novoUsuario("Jonas Alves da Silva", "1234", "admin", Now(), "Administrador", "000001")
        fo(1).cadastraFornecedor("Galdino SA", "86.013.193/0001-30", "Rua Rangel Pestana, 404", "Boa Vista", "São Vicente", "11420-113", "SP", "(13)1234-5678", "", "()-")
        c(1).novaCapacitacao("500", "Excel Avançado", "Conhecimento acerca da criação de modelos, do uso de espaços de trabalho e exibições personalizadas, de referência e auditoria de fórmulas, da organização de dados, da dinamização de planilhas, da importação de dados, do trabalho com funções, da análise de dados, do uso de macros e formulários personalizados e da proteção de pastas de trabalho.", "0")
        fu(1).novoFuncionario("123456", "Matheus Scarparo Galdino", "02/10/2013", "Masculino", "223.565.879-25", "Estagiário", "TI")
    End Sub

    Public Sub cleanTXT(ByVal ParamArray txt() As TextBox)
        For i As Integer = 0 To (txt.Length - 1) Step 1
            txt(i).Clear()
        Next
    End Sub

    Public Sub limparCriarUsuario()
        cleanTXT(frm_CriarUsuario.txt_confirma, frm_CriarUsuario.txt_matricula, frm_CriarUsuario.txt_nome_func, frm_CriarUsuario.txt_nome_usuario, frm_CriarUsuario.txt_senha)
        frm_CriarUsuario.cmb_nivel_acesso_usuario.SelectedIndex = -1
    End Sub

    Public Sub limparGerenciarUsuarios()
        frm_GerenciaUsuarios.txt_matricula.Clear()
        frm_GerenciaUsuarios.txt_nivel.Clear()
        frm_GerenciaUsuarios.txt_nomeusuario.Clear()
        frm_GerenciaUsuarios.cmb_usuario.SelectedIndex = -1
    End Sub

    Public Function CALCULO_CNPJ(ByVal CGC As String) As Boolean
        CGC = Replace(CGC, ".", "")
        CGC = Replace(CGC, "-", "")
        CGC = Replace(CGC, "/", "")
        Dim Var1, Var2, Var3, Var4, Var5
        If Len(CGC) = 8 And Val(CGC) > 0 Then
            Var1 = 0 : Var2 = 0 : Var4 = 0
            For Var3 = 1 To 7
                Var1 = Val(Mid(CGC, Var3, 1))
                If (Var1 Mod 2) <> 0 Then
                    Var1 = Var1 * 2
                End If
                If Var1 > 9 Then
                    Var2 = Var2 + Int(Var1 / 10) + (Var1 Mod 10)
                Else
                    Var2 = Var2 + Var1
                End If
            Next Var3
            Var4 = IIf((Var2 Mod 10) <> 0, 10 - (Var2 Mod 10), 0)
            If Var4 = Val(Mid(CGC, 8, 1)) Then
                CALCULO_CNPJ = True
            Else
                CALCULO_CNPJ = False
            End If
        Else
            If Len(CGC) = 14 And Val(CGC) > 0 Then
                Var1 = 0 : Var3 = 0 : Var4 = 0 : Var5 = 0 : Var2 = 5
                For Var3 = 1 To 12
                    Var1 = Var1 + (Val(Mid(CGC, Var3, 1)) * Var2)
                    Var2 = IIf(Var2 > 2, Var2 - 1, 9)
                Next Var3
                Var1 = Var1 Mod 11
                Var4 = IIf(Var1 > 1, 11 - Var1, 0)
                Var1 = 0 : Var3 = 0 : Var2 = 6
                For Var3 = 1 To 13
                    Var1 = Var1 + (Val(Mid(CGC, Var3, 1)) * Var2)
                    Var2 = IIf(Var2 > 2, Var2 - 1, 9)
                Next Var3
                Var1 = Var1 Mod 11
                Var5 = IIf(Var1 > 1, 11 - Var1, 0)
                If (Var4 = Val(Mid(CGC, 13, 1)) And Var5 = Val(Mid(CGC, 14, 1))) Then
                    CALCULO_CNPJ = True
                Else
                    CALCULO_CNPJ = False
                End If
            Else
                CALCULO_CNPJ = False
            End If
        End If
    End Function
End Module
