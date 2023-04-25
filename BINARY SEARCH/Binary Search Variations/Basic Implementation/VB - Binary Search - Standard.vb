Module BinarySearch
    Public Function IterativeBinarySearch(ByVal arr() As Integer, ByVal target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1

        While left <= right
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) = target Then
                Return mid
            ElseIf arr(mid) < target Then
                left = mid + 1
            Else
                right = mid - 1
            End If
        End While

        Return -1
    End Function

    Public Function RecursiveBinarySearch(ByVal arr() As Integer, ByVal target As Integer, ByVal left As Integer, ByVal right As Integer) As Integer
        If left > right Then
            Return -1
        End If

        Dim mid As Integer = (left + right) \ 2

        If arr(mid) = target Then
            Return mid
        ElseIf arr(mid) < target Then
            Return RecursiveBinarySearch(arr, target, mid + 1, right)
        Else
            Return RecursiveBinarySearch(arr, target, left, mid - 1)
        End If
    End Function

    Sub Main()
        Dim arr() As Integer = {1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40}

        While True
            Console.WriteLine(vbCrLf & "Standard Binary Search Variations:")
            Console.WriteLine("1. Iterative Binary Search")
            Console.WriteLine("2. Recursive Binary Search")
            Console.WriteLine("3. Quit")

            Console.Write(vbCrLf & "Enter your choice: ")
            Dim choice As Integer = Integer.Parse(Console.ReadLine())

            If choice = 1 OrElse choice = 2 Then
                Console.Write("Enter the target value: ")
                Dim target As Integer = Integer.Parse(Console.ReadLine())

                If choice = 1 Then
                    Console.WriteLine("Result: " & IterativeBinarySearch(arr, target))
                Else
                    Console.WriteLine("Result: " & RecursiveBinarySearch(arr, target, 0, arr.Length - 1))
                End If
            ElseIf choice = 3 Then
                Exit While
            Else
                Console.WriteLine("Invalid choice. Please try again.")
            End If
        End While
    End Sub
End Module
