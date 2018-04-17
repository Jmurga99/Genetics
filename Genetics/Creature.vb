Public Class Creature

    Private poolg(,) As Integer
    Private fenotipo As Array
    Private genotipo As Array
    Private emparejar As Byte
    Private poolf(,) As String

    Private Sub llenarpg(ByVal pf(,) As String)
        Dim tofill(pf.GetLength(0) - 1, pf.GetLength(1) - 1) As Integer
        For i As Integer = 0 To pf.GetLength(0) - 1
            Dim vuel As Integer = 0
            For j As Integer = 0 To pf.GetLength(1) - 1
                tofill(i, j) = vuel
                vuel += 1
            Next

        Next
        poolg = tofill
    End Sub

    Public Sub New(ByVal pool(,) As String)

        poolf = pool
        llenarpg(poolf)

    End Sub

    Public Sub pool()

        For i As Integer = 0 To poolf.GetLength(0) - 1
            For j As Integer = 0 To poolf.GetLength(1) - 1
                System.Console.Write(poolf(i, j) & " = " & poolg(i, j) & " ")
            Next
            System.Console.WriteLine()
        Next
    End Sub


End Class
