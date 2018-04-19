﻿Public Class Creature

    Private poolg(,) As Byte
    Private fenotipo() As String
    Private genotipo() As Byte
    Private emparejar As Byte
    Private poolf(,) As String

    Private Sub llenarpg(ByVal pf(,) As String)
        Dim tofill(pf.GetLength(0) - 1, pf.GetLength(1) - 1) As Byte
        For i As Integer = 0 To pf.GetLength(0) - 1
            Dim vuel As Integer = 0
            For j As Integer = 0 To pf.GetLength(1) - 1
                tofill(i, j) = vuel
                vuel += 1
            Next

        Next
        poolg = tofill
    End Sub

    Private Sub llenarg(ByVal pg(,) As Byte)
        Dim generator As New Random
        Dim h(pg.GetLength(1) - 1) As Byte
        For i As Integer = 0 To h.Length - 1
            h(i) = generator.Next(pg.GetLength(1) - pg.GetLength(1), pg.GetLength(1))
        Next
        genotipo = h
    End Sub

    Private Sub llenarf(ByVal adn() As Byte)

        Dim a(adn.Length) As String

        For i As Byte = 0 To adn.Length - 1
            Dim b As Byte = adn(i)
            For j As Byte = 0 To poolf.GetLength(0) - 1
                If b = poolg(i, j) Then
                    a(i) = poolf(i, j)
                End If
            Next
        Next
        fenotipo = a
    End Sub

    Private Sub llenare()
        Dim genrator As New Random
        emparejar = genrator.Next(0, 1)
    End Sub

    Public Sub New(ByVal pool(,) As String)

        poolf = pool
        llenarpg(poolf)
        llenarg(poolg)
        llenarf(genotipo)
        llenare()

    End Sub

    Public Sub pool()

        For i As Integer = 0 To poolf.GetLength(0) - 1
            For j As Integer = 0 To poolf.GetLength(1) - 1
                System.Console.Write(poolf(i, j) & " = " & poolg(i, j) & " ")
            Next
            System.Console.WriteLine()
        Next
    End Sub

    Public Sub genes()

        For i As Integer = 0 To genotipo.Length - 1
            System.Console.Write(genotipo(i) & " ")
        Next
        System.Console.WriteLine()

    End Sub

    Public Sub fenos()

        For i As Integer = 0 To fenotipo.Length - 1
            System.Console.Write(fenotipo(i) & " ")
        Next
        System.Console.WriteLine()

    End Sub

    Public ReadOnly Property emp
        Get
            Return emparejar
        End Get
    End Property


End Class
