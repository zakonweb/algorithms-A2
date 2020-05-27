Module Module1

    Sub Main()
        Dim MyList(7) As Integer
        Dim Index, MaxIndex, n, j, Temp As Integer
        Dim NoMoreSwaps As Boolean

        For Index = 1 To 7
            Console.Write("Enter a number: ")
            MyList(Index) = Console.ReadLine()
        Next

        MaxIndex = 7
        n = MaxIndex - 1
        Do
            NoMoreSwaps = True
            For j = 1 To n
                If MyList(j) > MyList(j + 1) Then
                    Temp = MyList(j)
                    MyList(j) = MyList(j + 1)
                    MyList(j + 1) = Temp
                    NoMoreSwaps = False
                End If
            Next
            n = n - 1
        Loop Until NoMoreSwaps

        For Index = 1 To 7
            Console.Write(MyList(Index) & " ")
        Next
        Console.ReadLine()
    End Sub

End Module
