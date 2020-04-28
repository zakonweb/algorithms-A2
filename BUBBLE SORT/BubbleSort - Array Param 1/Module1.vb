Module Module1

    Sub Main()
        Dim thisArr(5) As Char
        Dim i As Integer

        For i = 1 To 5
            thisArr(i) = Console.ReadLine
        Next

        Call Bubble(thisArr, 5)

        For i = 1 To 5
            Console.WriteLine(thisArr(i))
        Next
        Console.ReadKey()
    End Sub

    Sub Bubble(ByRef TBS() As Char, ByVal UB As Integer)
        Dim wasSwap As Boolean
        Dim i, j, a As Integer
        Dim Temp As Char

        For j = UB - 1 To 1 Step -1
            wasSwap = False
            For i = 1 To j
                a = a + 1
                If TBS(i + 1) < TBS(i) Then
                    wasSwap = True
                    Temp = TBS(i)
                    TBS(i) = TBS(i + 1)
                    TBS(i + 1) = Temp
                End If
            Next i
            If wasSwap = False Then Exit For
        Next j
        Console.WriteLine("No. of loops: " & a)
        Console.ReadKey()
    End Sub
End Module
