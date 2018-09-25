Public Class FrmDesignPatterns

#Region "Eventos"

    Private Sub BtnSingleton_Click(sender As Object, e As EventArgs) Handles BtnSingleton.Click
        CheckSingleton()
    End Sub

#End Region

#Region "Singleton"

    'Verifica o valor do Singleton
    Private Sub CheckSingleton()

        Dim oSing As New SingleTon.SingletonUse()
        Dim IsSingleton As Boolean = oSing.GetIsSingletonValue()
        MsgBox(String.Format("The Value of the Singleton is {0}", IsSingleton))

    End Sub

#End Region


End Class
