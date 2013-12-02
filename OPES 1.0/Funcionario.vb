Public Class Funcionario
    Public matricula As String = ""
    Public nome As String = ""
    Public nasc As Date
    Public sexo As String = ""
    Public cpf As String = ""
    Public funcao As String = ""
    Public setor As String = ""

    Public Sub novoFuncionario(ByRef matricula As String, ByRef nome As String, ByRef nasc As Date, ByRef sexo As String, ByRef cpf As String, ByRef funcao As String, ByRef setor As String)
        Me.matricula = matricula
        Me.nome = nome
        Me.nasc = nasc
        Me.sexo = sexo
        Me.cpf = cpf
        Me.funcao = funcao
        Me.setor = setor
    End Sub

    Public Sub editarFuncionario(ByRef matricula As String, ByRef nome As String, ByRef nasc As Date, ByRef sexo As String, ByRef cpf As String, ByRef funcao As String, ByRef setor As String)
        Me.matricula = matricula
        Me.nome = nome
        Me.nasc = nasc
        Me.sexo = sexo
        Me.cpf = cpf
        Me.funcao = funcao
        Me.setor = setor
    End Sub
End Class
