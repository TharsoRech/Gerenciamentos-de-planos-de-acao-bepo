<Serializable>
Public Class User
    Public user As String = ""
    Public Senha As String = ""
    Public Email As String = ""
    Public EmailDoGerente As String = ""
    Public DataCriacao As String = ""
    Public admin As Boolean = False
    Public Planos As New List(Of PlanoDeAção)



End Class
