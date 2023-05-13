Imports System

Module MainModule
    ' Standard Bubble Sort;
    ' never stops if the array is already sorted
    Public Sub BubbleSort(ByRef arr() As Integer)
        Dim n As Integer = arr.Length
        ' Traverse through all array elements
        For i As Integer = 0 To n - 1
            ' Last i elements are already in place
            For j As Integer = 0 To n - i - 2
                ' Swap if the element found is greater than the next element
                If arr(j) > arr(j + 1) Then
                    Dim temp As Integer = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                End If
            Next
        Next
    End Sub

    ' Modified Bubble Sort; stops if no swaps occur in a pass
    Public Sub ModifiedBubbleSort(ByRef arr() As Integer)
        Dim n As Integer = arr.Length
        ' Traverse through all array elements
        For i As Integer = 0 To n - 1
            Dim swapped As Boolean = False
            ' Last i elements are already in place
            For j As Integer = 0 To n - i - 2
                ' Swap if the element found is greater than the next element
                If arr(j) > arr(j + 1) Then
                    Dim temp As Integer = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                    swapped = True
                End If
            Next
            ' If no two elements were swapped by inner loop, then break
            If Not swapped Then
                Exit For
            End If
        Next
    End Sub

    ' Recursive Bubble Sort; uses recursion to sort the array
    Function RecursiveBubbleSort(ByRef arr() As Integer, ByVal n As Integer) As Integer
        ' Base case
        If n = 1 Then
            Return 0
        End If
        ' Traverse through all array elements
        For i As Integer = 0 To n - 2
            ' Swap if the element found is greater than the next element
            If arr(i) > arr(i + 1) Then
                Dim temp As Integer = arr(i)
                arr(i) = arr(i + 1)
                arr(i + 1) = temp
            End If
        Next
        ' Largest element is fixed, recur for remaining array
        Return RecursiveBubbleSort(arr, n - 1)
    End Function

    ' Cocktail Shaker Sort; bidirectional Bubble Sort
    ' it sorts the array in both directions alternatively
    ' to reduce the number of passes
    Public Sub CocktailShakerSort(ByRef arr() As Integer)
        Dim n As Integer = arr.Length
        ' Traverse the array from both ends
        Dim swapped As Boolean = True
        Dim start As Integer = 0
        Dim [end] As Integer = n - 1
        While swapped
            swapped = False
            ' Traverse from left to right
            For i As Integer = start To [end] - 1
                ' Swap if the element found is greater than the next element
                If arr(i) > arr(i + 1) Then
                    Dim temp As Integer = arr(i)
                    arr(i) = arr(i + 1)
                    arr(i + 1) = temp
                    swapped = True
                End If
            Next
            ' If no swaps occurred, the array is already sorted
            If Not swapped Then
                Exit While
            End If
            swapped = False
            [end] -= 1
            ' Traverse from right to left
            For i As Integer = [end] - 1 To start Step -1
                ' Swap if the element found is greater than the next element
                If arr(i) > arr(i + 1) Then
                    Dim temp As Integer = arr(i)
                    arr(i) = arr(i + 1)
                    arr(i + 1) = temp
                    swapped = True
                End If
            Next
            start += 1
        End While
    End Sub

    ' Comb Sort; improves Bubble Sort by using gap of size more than 1
    ' the gap starts with a large value and shrinks by a factor of 1.3
    ' until it reaches the value 1
    ' the shrink factor is chosen to be 1.3 because it is empirically
    ' the best value to use
    Public Sub CombSort(ByRef arr() As Integer)
        Dim n As Integer = arr.Length
        ' Initialize gap as the length of the array
        Dim gap As Integer = n
        ' Set the shrink factor to 1.3
        Dim shrink As Double = 1.3
        ' Flag to indicate if any swaps occurred
        Dim swapped As Boolean = True
        While gap > 1 Or swapped
            ' Update the gap according to the shrink factor
            gap = Math.Floor(gap / shrink)
            If gap < 1 Then
                gap = 1
            End If
            swapped = False
            ' Compare elements with a gap of 'gap'
            For i As Integer = 0 To n - gap - 1
                ' Swap if the element found is greater than the next element
                If arr(i) > arr(i + gap) Then
                    Dim temp As Integer = arr(i)
                    arr(i) = arr(i + gap)
                    arr(i + gap) = temp
                    swapped = True
                End If
            Next
        End While
    End Sub

    ' main menu for the program
    Sub Main()
        Dim choice As Integer = 0
        Dim rand As New Random()
        ' generate a random array of 10 elements
        Dim arr(9) As Integer
        While choice <> 6
            Console.WriteLine("1. Bubble Sort")
            Console.WriteLine("2. Modified Bubble Sort")
            Console.WriteLine("3. Recursive Bubble Sort")
            Console.WriteLine("4. Cocktail Shaker Sort")
            Console.WriteLine("5. Comb Sort")
            Console.WriteLine("6. Exit")
            Console.Write("Enter your choice: ")
            choice = Integer.Parse(Console.ReadLine())

            For i As Integer = 0 To 9
                arr(i) = rand.Next(0, 101)
            Next

            If choice = 1 Then
                Console.WriteLine("Array before sorting: " + String.Join(", ", arr))
                BubbleSort(arr)
                Console.WriteLine("Array after sorting: " + String.Join(", ", arr))
            ElseIf choice = 2 Then
                Console.WriteLine("Array before sorting: " + String.Join(", ", arr))
                ModifiedBubbleSort(arr)
                Console.WriteLine("Array after sorting: " + String.Join(", ", arr))
            ElseIf choice = 3 Then
                Console.WriteLine("Array before sorting: " + String.Join(", ", arr))
                RecursiveBubbleSort(arr, arr.Length)
                Console.WriteLine("Array after sorting: " + String.Join(", ", arr))
            ElseIf choice = 4 Then
                Console.WriteLine("Array before sorting: " + String.Join(", ", arr))
                CocktailShakerSort(arr)
                Console.WriteLine("Array after sorting: " + String.Join(", ", arr))
            ElseIf choice = 5 Then
                Console.WriteLine("Array before sorting: " + String.Join(", ", arr))
                CombSort(arr)
                Console.WriteLine("Array after sorting: " + String.Join(", ", arr))
            ElseIf choice = 6 Then
                Console.WriteLine("Exiting!")
            End If
        End While
    End Sub
End Module