Namespace Strategy

    'Este pattern é usado para se ter diversos tipos de especialização de classes dentro de outra, contanto que todas mantenham uma base igual entre elas(A interface)
    'Sem a utilização deste pattern, podemos acabar colocando um monte de classes especialistas que possuem uma mesma base de funcionamento em uma classe pai, sujando assim a classe. Com a utilização do pattern
    'podemos deixar o código muito melhor para entendimento e posterior manutenção
    'Veja mais em: https://www.dofactory.com/net/strategy-design-pattern
    Public Class Log

        'Uso de Singleton e lazy init
        Private _LogType As ILogType
        Public Property LogType() As ILogType
            Get
                If _LogType Is Nothing Then
                    _LogType = New ConsoleLog() 'Por padrão, usar Console
                End If
                Return _LogType
            End Get
            Set(ByVal value As ILogType)
                _LogType = value
            End Set
        End Property

        'Recebe um parâmetro do tipo que será criado, Console ou File. No caso, usei Singleton com Lazy Init, assim já fica Console como padrão
        Public Sub New(Optional LogTypeAux As ILogType = Nothing)
            Me.LogType = LogTypeAux
        End Sub

        'Chama funcionalidade da classe-filho
        Public Sub DoLog(Message As String)
            Me.LogType.DoLog(Message)
        End Sub

    End Class

End Namespace
