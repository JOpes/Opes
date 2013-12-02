Public Class usuario
    Public nome As String = ""
    Public senha As String = ""
    Public login As String = ""
    Public nivel As String = ""
    Public matricula As String = ""
    Public data As Date
    Public Function verificaSenha(ByRef p As String)
        If p = senha Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub novoUsuario(ByRef n As String, ByRef s As String, ByRef l As String, ByRef d As Date, ByRef nvl As String, ByRef m As String)
        nome = n
        senha = s
        login = l
        data = d
        nivel = nvl
        matricula = m
    End Sub

    Public Sub editarUsuario(ByRef m As String, ByRef n As String, ByRef l As String, ByRef s As String)
        matricula = m
        nivel = n
        login = l
        senha = s
    End Sub
End Class
