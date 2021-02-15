<Serializable>
Public Class Ação
    Public Ação As String = ""
    Public Cliente As String = ""
    Public Origem As String = ""
    Public Número As String = ""
    Public Inicio As String = ""
    Public Alteradopor As String = ""
    Public atualização As String = ""
    Public GerenteEmail As String = ""
    Public Evidência As String = ""
    Public Prazo As String = ""
    Public Status As String = ""
    Public NãoConformidadeFalha As String = ""
    Public excluidopor As String = ""
    Public CriadorPor As String = ""
    Public Previsto As Boolean = False
    Public Atrasada As Boolean = False
    Public EmExecução As Boolean = False
    Public concluida As Boolean = False
    Public Emviadoconcluido As Boolean = False
    Public Responsáveis As New List(Of String)
End Class
