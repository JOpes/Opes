Public Class Fornecedor
    Public empresa As String = ""
    Public cnpj As String = ""
    Public endereco As String = ""
    Public bairro As String = ""
    Public cidade As String = ""
    Public cep As String = ""
    Public uf As String = ""
    Public tel As String = ""
    Public fax As String = ""
    Public ramal As String = ""

    Public Sub cadastraFornecedor(ByRef emp As String, ByRef c As String, ByRef ende As String, ByRef b As String, ByRef cid As String, ByRef cep As String, ByRef uf As String, ByRef tel As String, ByRef ramal As String, ByRef fax As String)
        Me.empresa = emp
        Me.cnpj = c
        Me.endereco = ende
        Me.bairro = b
        Me.cidade = cid
        Me.cep = cep
        Me.uf = uf
        Me.tel = tel
        Me.fax = fax
        Me.ramal = ramal
    End Sub

    Public Sub editarFornecedor(ByRef emp As String, ByRef c As String, ByRef ende As String, ByRef b As String, ByRef cid As String, ByRef cep As String, ByRef uf As String, ByRef tel As String, ByRef ramal As String, ByRef fax As String)
        Me.empresa = emp
        Me.cnpj = c
        Me.endereco = ende
        Me.bairro = b
        Me.cidade = cid
        Me.cep = cep
        Me.uf = uf
        Me.tel = tel
        Me.fax = fax
        Me.ramal = ramal
    End Sub
End Class
