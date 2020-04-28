Module Module1
    Dim alpha() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i"}

    Sub Main()
        Dim c2s As Char = Console.ReadLine
        Console.WriteLine(c2s & " found at location " & BinaryS(c2s))
        Console.ReadKey()
    End Sub

    Function BinaryS(ByVal value As Char) As Integer
        Dim middle, LB, UB As Integer
        Dim isFOund As Boolean = False

        LB = 0
        UB = 8

        While UB > LB Or isFOund = False
            middle = (LB + UB) \ 2
            If alpha(middle) = value Then
                isFOund = True
                Return middle
            ElseIf value < alpha(middle) Then
                UB = middle - 1
            Else
                LB = middle + 1
            End If
        End While
        Return -1
    End Function

End Module
