Namespace Strategy

    Public Class FileLog
        Implements ILogType

        'Propriedade somente para mostrar a diferença do ConsoleLog
        Public Property _FileName() As String

        Public Sub New(FileName As String)
            _FileName = FileName
        End Sub

        Public Sub DoLog(Message As String) Implements ILogType.DoLog

            'Testes sem muita preocupação com validação, o foco é o pattern usado
            If Not String.IsNullOrEmpty(_FileName) Then
                My.Computer.FileSystem.WriteAllText(Me._FileName, Message, False)
            End If

        End Sub

    End Class

End Namespace
