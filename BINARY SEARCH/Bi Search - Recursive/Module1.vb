Module Module1
    Sub Main()
        Dim thisArr() As Char = {"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j"}
        Dim value As Char = ""
        Dim result As Integer = 0

        Console.Write("Enter value between a and j: ")
        value = Console.ReadLine

        result = binarySearch(thisArr, 10, 1, value)
        Dim a As Integer

        If result = -1 Then
            Console.WriteLine(value & " not found.")
        Else
            Console.WriteLine(value & " found at position " & result)
        End If
        Console.ReadKey()
    End Sub

    Function binarySearch(ByVal thisArr() As Char, ByVal UB As Integer, ByVal LB As Integer, _
                          ByVal Value As Char) As Integer
        Dim middle As Integer
        If LB > UB Then
            Return -1 'Not FOund
        Else
            middle = Int((UB + LB) / 2)
            Select Case thisArr(middle) 'Found
                Case Is = Value : Return middle
                Case Is > Value : Return binarySearch(thisArr, middle - 1, LB, Value)
                Case Is < Value : Return binarySearch(thisArr, UB, middle + 1, Value)
            End Select
        End If
    End Function
End Module