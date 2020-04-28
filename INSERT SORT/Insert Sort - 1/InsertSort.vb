Module Module1
    Sub Main()
        Dim thisArr(8), Count, X, Y, Temp As Integer
        'Input values

        For Count = 1 To 8
            Console.Write("Enter " & Count & " value: ")
            thisArr(Count) = Console.ReadLine
        Next

        'sorting starts with 2nd array position
        For X = 2 To 8
            For Y = 1 To X - 1
                If thisArr(X) < thisArr(Y) Then
                    Temp = thisArr(X)
                    'swap value with previous value
                    'from current (X) position to the Y position
                    For Count = X To (Y + 1) Step -1
                        thisArr(Count) = thisArr(Count - 1)
                    Next
                    'Insert sorted value at Y position
                    thisArr(Y) = Temp
                    Exit For ' Once swapped, no further matches are necessary
                End If
            Next
        Next
        'Show all sorted value in the array
        For Count = 1 To 8
            Console.WriteLine(thisArr(Count))
        Next
        Console.ReadKey()
    End Sub
End Module