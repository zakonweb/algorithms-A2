Imports System.Data

Module BinarySearch

    Function IterativeBinarySearch(arr As Integer(), target As Integer) As Integer
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

    Function RecursiveBinarySearch(arr As Integer(), target As Integer, left As Integer, right As Integer) As Integer
        If left <= right Then
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) = target Then
                Return mid
            ElseIf arr(mid) < target Then
                Return RecursiveBinarySearch(arr, target, mid + 1, right)
            Else
                Return RecursiveBinarySearch(arr, target, left, mid - 1)
            End If
        End If

        Return -1
    End Function

    Function IterativeLeftmostBinarySearch(arr As Integer(), target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1
        Dim result As Integer = -1

        While left <= right
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) = target Then
                result = mid
                right = mid - 1
            ElseIf arr(mid) < target Then
                left = mid + 1
            Else
                right = mid - 1
            End If
        End While

        Return result
    End Function

    Function RecursiveLeftmostBinarySearch(arr As Integer(), target As Integer, left As Integer, right As Integer, Optional result As Integer = -1) As Integer
        If left <= right Then
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) = target Then
                result = mid
                Return RecursiveLeftmostBinarySearch(arr, target, left, mid - 1, result)
            ElseIf arr(mid) < target Then
                Return RecursiveLeftmostBinarySearch(arr, target, mid + 1, right, result)
            Else
                Return RecursiveLeftmostBinarySearch(arr, target, left, mid - 1, result)
            End If
        End If

        Return result
    End Function

    Function IterativeRightmostBinarySearch(arr As Integer(), target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1
        Dim result As Integer = -1

        While left <= right
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) = target Then
                result = mid
                left = mid + 1
            ElseIf arr(mid) < target Then
                left = mid + 1
            Else
                right = mid - 1
            End If
        End While

        Return result
    End Function

    Function RecursiveRightmostBinarySearch(arr As Integer(), target As Integer, left As Integer, right As Integer, Optional result As Integer = -1) As Integer
        If left <= right Then
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) = target Then
                result = mid
                Return RecursiveRightmostBinarySearch(arr, target, mid + 1, right, result)
            ElseIf arr(mid) < target Then
                Return RecursiveRightmostBinarySearch(arr, target, mid + 1, right, result)
            Else
                Return RecursiveRightmostBinarySearch(arr, target, left, mid - 1, result)
            End If
        End If
        Return result
    End Function
    Function IterativeLowerBoundBinarySearch(arr As Integer(), target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1
        Dim result As Integer = -1
        While left <= right
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) = target Then
                result = mid
                right = mid - 1
            ElseIf arr(mid) < target Then
                left = mid + 1
            Else
                result = mid
                right = mid - 1
            End If
        End While

        Return result
    End Function

    Function RecursiveLowerBoundBinarySearch(arr As Integer(), target As Integer, left As Integer, right As Integer, Optional result As Integer = -1) As Integer
        If left <= right Then
            Dim mid As Integer = (left + right) \ 2
            If arr(mid) = target Then
                result = mid
                Return RecursiveLowerBoundBinarySearch(arr, target, left, mid - 1, result)
            ElseIf arr(mid) < target Then
                Return RecursiveLowerBoundBinarySearch(arr, target, mid + 1, right, result)
            Else
                result = mid
                Return RecursiveLowerBoundBinarySearch(arr, target, left, mid - 1, result)
            End If
        End If

        Return result
    End Function

    Function IterativeUpperBoundBinarySearch(arr As Integer(), target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1
        Dim result As Integer = -1
        While left <= right
            Dim mid As Integer = (left + right) \ 2

            If arr(mid) <= target Then
                left = mid + 1
            Else
                result = mid
                right = mid - 1
            End If
        End While

        Return result
    End Function

    Function RecursiveUpperBoundBinarySearch(arr As Integer(), target As Integer, left As Integer, right As Integer, Optional result As Integer = -1) As Integer
        If left <= right Then
            Dim mid As Integer = (left + right) \ 2
            If arr(mid) <= target Then
                Return RecursiveUpperBoundBinarySearch(arr, target, mid + 1, right, result)
            Else
                result = mid
                Return RecursiveUpperBoundBinarySearch(arr, target, left, mid - 1, result)
            End If
        End If

        Return result
    End Function

    Sub Main()
        Dim arr As Integer() = {1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40}
        While True
            Console.WriteLine(vbLf & "Binary Search Variations:")
            Console.WriteLine("1. Standard Binary Search (Iterative)")
            Console.WriteLine("2. Standard Binary Search (Recursive)")
            Console.WriteLine("3. Leftmost Binary Search (Iterative)")
            Console.WriteLine("4. Leftmost Binary Search (Recursive)")
            Console.WriteLine("5. Rightmost Binary Search (Iterative)")
            Console.WriteLine("6. Rightmost Binary Search (Recursive)")
            Console.WriteLine("7. Lower Bound Binary Search (Iterative)")
            Console.WriteLine("8. Lower Bound Binary Search (Recursive)")
            Console.WriteLine("9. Upper Bound Binary Search (Iterative)")
            Console.WriteLine("10. Upper Bound Binary Search (Recursive)")
            Console.WriteLine("11. Quit")
            Console.Write(vbLf & "Enter your choice: ")
            Dim choice As Integer = Integer.Parse(Console.ReadLine())
            If choice <> 11 Then
                Console.Write("Enter the target: ")
                Dim target As Integer = Integer.Parse(Console.ReadLine())

                If choice = 1 Then
                    Console.WriteLine("Result: " & IterativeBinarySearch(arr, target))
                ElseIf choice = 2 Then
                    Console.WriteLine("Result: " & RecursiveBinarySearch(arr, target, 0, arr.Length - 1))
                ElseIf choice = 3 Then
                    Console.WriteLine("Result: " & IterativeLeftmostBinarySearch(arr, target))
                ElseIf choice = 4 Then
                    Console.WriteLine("Result: " & RecursiveLeftmostBinarySearch(arr, target, 0, arr.Length - 1))
                ElseIf choice = 5 Then
                    Console.WriteLine("Result: " & IterativeRightmostBinarySearch(arr, target))
                ElseIf choice = 6 Then
                    Console.WriteLine("Result: " & RecursiveRightmostBinarySearch(arr, target, 0, arr.Length - 1))
                ElseIf choice = 7 Then
                    Console.WriteLine("Result: " & IterativeLowerBoundBinarySearch(arr, target))
                ElseIf choice = 8 Then
                    Console.WriteLine("Result: " & RecursiveLowerBoundBinarySearch(arr, target, 0, arr.Length - 1))
                ElseIf choice = 9 Then
                    Console.WriteLine("Result: " & IterativeUpperBoundBinarySearch(arr, target))
                ElseIf choice = 10 Then
                    Console.WriteLine("Result: " & RecursiveUpperBoundBinarySearch(arr, target, 0, arr.Length - 1))
                Else
                    Console.WriteLine("Invalid choice. Please try again.")
                End If
            Else
                Exit While
            End If
        End While

    End Sub
End Module