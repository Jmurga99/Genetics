Public Class Creature

    Private poolg As Array
    Private fenotipo As Array
    Private genotipo As Array
    Private emparejar As Byte
    Private poolf(,) As String

    Public Sub New(ByVal pool(,) As String)

        poolf = pool

    End Sub

    Public Sub pool()

        For i As Integer = 0 To poolf.GetLength(0) - 1
            For j As Integer = 0 To poolf.GetLength(1) - 1
                System.Console.Write(poolf(i, j) & " ")
            Next
            System.Console.WriteLine()
        Next
    End Sub


End Class
