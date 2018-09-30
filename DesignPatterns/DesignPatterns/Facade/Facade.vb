Namespace Facade

    'O design pattern Facade é literalmente uma fachada que esconde de quem vai usar a classe, as classes internas de uma forma a simplificar seu uso.
    'É uma interface unificada para uma série de interfaces em um subsistema.
    'Veja mais em: https://www.dofactory.com/net/facade-design-pattern
    Public Class FacadeClass

        Public Sub New()
        End Sub

        Public Function GetSumValue(Value As Decimal) As Decimal

            Dim Sub1 As New Facade.Subsystem1()
            Dim Sub2 As New Facade.Subsystem2()
            Dim Sub3 As New Facade.Subsystem3()
            Dim Sub4 As New Facade.Subsystem4()

            Sub1.SumValue(Value)
            Sub2.SumValue(Value)
            Sub3.SumValue(Value)
            Sub4.SumValue(Value)

            Return Value

        End Function

    End Class

End Namespace
