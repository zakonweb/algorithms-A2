Module Module1
    Sub Main()
        Dim didWork As Boolean = False
        Dim b, c, temp, x As Integer
        Dim n() As Integer = {2, 1, 3, 5, 6, 7, 8}

        For b = 0 To 5
            didWork = False

            For c = 0 To 5
                x = x + 1

                If n(c) > n(c + 1) Then
                    temp = n(c)
                    n(c) = n(c + 1)
                    n(c + 1) = temp

                    didWork = True
                End If

            Next
            If didWork = False Then Exit For

        Next

        For c = 0 To 6
            Console.WriteLine(n(c))
        Next

        Console.WriteLine()
        Console.WriteLine("Counter worked " & x & " times.")
        Console.ReadKey()
    End Sub
End Module
