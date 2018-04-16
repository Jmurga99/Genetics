Module Module1

    Sub Main()
        Dim a() As String = {"pequeña", "mediana", "grande"}
        Dim b() As String = {"delgado", "esbelto", "gordo"}
        Dim c() As String = {"pequeños", "medianos", "grandes"}
        Dim arr(2, 2) As String

        For i As Integer = 0 To a.Length - 1
            arr(0, i) = a(i)
        Next
        For i As Integer = 0 To a.Length - 1
            arr(1, i) = b(i)
        Next
        For i As Integer = 0 To a.Length - 1
            arr(2, i) = c(i)
        Next
        Dim perro As Creature = New Creature(arr)
        perro.pool()
        System.Console.ReadKey()
    End Sub

End Module
