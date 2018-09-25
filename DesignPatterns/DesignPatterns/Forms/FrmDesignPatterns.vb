Public Class FrmDesignPatterns

#Region "Eventos"

    Private Sub BtnSingleton_Click(sender As Object, e As EventArgs) Handles BtnSingleton.Click
        CheckSingleton()
    End Sub

    Private Sub btnStrategy_Click(sender As Object, e As EventArgs) Handles btnStrategy.Click
        CheckStrategy()
    End Sub

#End Region

#Region "Singleton"

    'Verifica o valor do Singleton
    Private Sub CheckSingleton()

        Dim oSing As New SingleTon.SingletonUse()
        Dim IsSingleton As Boolean = oSing.GetIsSingletonValue()
        MsgBox(String.Format("The Value of the Singleton is {0}", IsSingleton))

    End Sub

    Private Sub CheckStrategy()

        Dim ConsoleLog As New Strategy.ConsoleLog()
        Dim Log As New Strategy.Log(ConsoleLog)
        Log.DoLog("Teste de Log de Console")

        Dim FileName As String = String.Format("{0}\Teste.txt", AppDomain.CurrentDomain.BaseDirectory)
        Dim FileLog As New Strategy.FileLog(FileName)
        Log = New Strategy.Log(FileLog)
        Log.DoLog("Teste de Log de File")

    End Sub

#End Region


End Class
