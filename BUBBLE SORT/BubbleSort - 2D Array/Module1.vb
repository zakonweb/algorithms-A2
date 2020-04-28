Module Module1

    Sub Main()
        Dim myArr(5, 3) As String
        Dim a, b, c As String
        Dim row, col As Integer
        Dim alreadySorted As Boolean = False

        For row = 1 To 5
            For col = 1 To 3
                myArr(row, col) = Console.ReadLine()
            Next
        Next

        While alreadySorted = False
            alreadySorted = True
            For row = 1 To 4
                If myArr(row, 1) > myArr(row + 1, 1) Then
                    a = myArr(row, 1)
                    b = myArr(row, 2)
                    c = myArr(row, 3)

                    myArr(row, 1) = myArr(row + 1, 1)
                    myArr(row, 2) = myArr(row + 1, 2)
                    myArr(row, 3) = myArr(row + 1, 3)

                    myArr(row + 1, 1) = a
                    myArr(row + 1, 2) = b
                    myArr(row + 1, 3) = c
                    alreadySorted = False
                End If
            Next
        End While
        For row = 1 To 5
            For col = 1 To 3
                Console.Write(myArr(row, col) & "-")
            Next
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub

End Module
