Public Class Retangulo
    'meus atributos
    Private _base As Double
    Private _altura As Double

    'construtor
    'pode ter vários construtores mas com parâmetros diferentes
    Public Sub New(base As Double, altura As Double)
        _base = base
        _altura = altura
    End Sub

    Public Sub New()

    End Sub

    'function sempre retornam
    Public Function GetArea() As Double
        If _base > 0 And _altura > 0 Then
            Return _base * _altura
        Else
            Return -1
        End If
    End Function

    'sub nao retornam nada
    Public Sub initFields(base As Double, altura As Double)
        _base = base
        _altura = altura
    End Sub
End Class
