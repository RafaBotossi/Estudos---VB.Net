Public Class SingletonClass

    Private Shared _IsSingleton As Boolean

    Public Sub New()
    End Sub

    Public Shared Function GetIsSingletonValue() As Boolean

        'Lazy init, not thread safe
        If Not _IsSingleton Then
            _IsSingleton = True
        End If

        Return _IsSingleton

    End Function


End Class
