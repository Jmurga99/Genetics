Module Module1
    Dim a() As String = {"pequeña", "mediana", "grande"}
    Dim b() As String = {"delgado", "esbelto", "gordo"}
    Dim c() As String = {"pequeños", "medianos", "grandes"}
    Dim arr(,) As String

    Public Sub agg(ByVal dimen As Byte, ByVal ar1() As String)
        Dim salida(0, ar1.Length - 1) As String
        For i As Byte = 0 To ar1.Length - 1
            salida(0, i) = ar1(i)
        Next
        arr(dimen) = salida
    End Sub

    Sub Main()
        agg(0, a)
        agg(1, b)
        agg(2, b)
        Dim perro As Creature = New Creature(arr)
        perro.pool()
        System.Console.ReadKey()
    End Sub

End Module
