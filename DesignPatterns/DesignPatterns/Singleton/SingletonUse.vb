Namespace SingleTon

    Public Class SingletonUse

        Public Sub New()
        End Sub

        'O Design Patterns Singleton indica o uso de apenas um ponto de acesso ao objecto
        'Usado em classes 'shared' para uso global da mesma instância de objeto, como indicado em: https://www.dofactory.com/net/singleton-design-pattern (exemplo na classe Singleton)
        'Em meus exemplos da vida real, uso muito em variáveis 'privadas' da classe que precisam ser acessadas de diversos pontos e devem ser sempre o mesmo objeto, também uso lazy init, assim não nos preocupamos com sua 'inicialização'
        Private _IsSingleton As Boolean
        Private Property IsSingleton() As Boolean
            Get
                If Not _IsSingleton Then
                    _IsSingleton = True
                End If
                Return _IsSingleton
            End Get
            Set(ByVal value As Boolean)
                _IsSingleton = value
            End Set
        End Property

        'Retorna valor do Singleton
        Public Function GetIsSingletonValue() As Boolean
            Return Me.IsSingleton
        End Function

    End Class

End Namespace
