Namespace Strategy

    Public Class ConsoleLog
        Implements ILogType

        Public Sub New()
        End Sub

        Public Sub DoLog(Message As String) Implements ILogType.DoLog
            Debug.Print(Message)
        End Sub
    End Class

End Namespace
