Public Class Capacitacao
    Public codigo As String = ""
    Public nome As String = ""
    Public descricao As String = ""
    Public validade As Integer

    Sub novaCapacitacao(ByRef cod As String, ByRef n As String, ByRef d As String, ByRef v As String)
        codigo = cod
        nome = n
        descricao = d
        validade = Integer.Parse(v)
    End Sub

    Sub editaCapacitacao(ByRef cod As String, ByRef n As String, ByRef d As String, ByRef v As String)
        codigo = cod
        nome = n
        descricao = d
        validade = Integer.Parse(v)
    End Sub
End Class
