<Serializable>
Public Class Database
    Public users As New List(Of User)
    Public Emailadmin As String = ""
    Public Senhaadmin As String = ""
    Public servidorEmail As String = ""
    Public Clientes As New List(Of String)
    Public HistoricodePlanos As New List(Of PlanoDeAção)
    Public listadeexcluidos As New List(Of Ação)
    Public Alertas As New List(Of Alerta)
    Public Enviarresponsávelantes As Boolean = True
    Public Enviargerenteantes As Boolean = False
    Public Enviarresponsável1aviso As Boolean = True
    Public Enviargerente1aviso As Boolean = True
    Public Enviarresponsávelultimoaviso As Boolean = True
    Public Enviargerenteultimoaviso As Boolean = True
    Public DiasAntes As Integer = 5
    Public DiaApós As Integer = 1
    Public DiadoUltimoaviso As Integer = 5



End Class
