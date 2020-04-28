Module Module1

    Sub Main()
        Dim Found, SearchFailed As Boolean
        Dim First, Last, Middle, Index, SearchItem, x As Integer
        Dim List(6) As Integer

        Found = False
        SearchFailed = False
        First = 0
        Last = 6

        For Index = 0 To 6
            Console.Write(" Enter value : ")
            x = Console.ReadLine
            List(Index) = x

        Next

        Console.WriteLine("Enter Search Item : ")
        SearchItem = Console.ReadLine

        While Not Found And Not SearchFailed
            Middle = (First + Last) / 2

            If List(Middle) = SearchItem Then

                Found = True
            Else
                If First >= Last Then
                    SearchFailed = True
                Else
                    If List(Middle) > SearchItem Then
                        Last = Middle - 1
                    Else
                        First = Middle + 1
                    End If
                End If
            End If

        End While

        If Found = True Then
            Console.WriteLine(" Value found at : " & Middle)
        Else
            Console.WriteLine("Not found ")
        End If
        Console.ReadKey()
    End Sub

End Module
