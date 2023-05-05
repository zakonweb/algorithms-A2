Module Module1
    Sub Main()
        Dim numElements As Integer

        ' Ask the user for the number of elements to sort
        Console.Write("Enter the number of elements: ")
        numElements = Console.ReadLine()

        Dim thisArr(numElements - 1), count As Integer

        ' Input values for each element in the array
        For count = 0 To numElements - 1
            Console.Write("Enter value " & (count + 1) & ": ")
            thisArr(count) = Console.ReadLine()
        Next

        ' Perform Insertion Sort on the array
        InsertionSort(thisArr, numElements)

        ' Show all sorted values in the array
        For count = 0 To numElements - 1
            Console.WriteLine(thisArr(count))
        Next

        Console.ReadKey()
    End Sub

    ' InsertionSort function takes an array and its length as input and sorts it using the Insertion Sort algorithm
    Sub InsertionSort(ByRef arr() As Integer, ByVal length As Integer)
        Dim x, y, temp, count As Integer

        ' Iterate through the array, starting with the second element (position 1)
        For x = 1 To length - 1
            ' Compare the current element (arr[x]) with all elements before it (arr[y])
            For y = 0 To x - 1
                ' If the current element is smaller than the compared element, perform the swap
                If arr(x) < arr(y) Then
                    temp = arr(x)

                    ' Shift all elements between the current position (x) and the compared position (y) one position to the right
                    For count = x To (y + 1) Step -1
                        arr(count) = arr(count - 1)
                    Next

                    ' Insert the sorted value at the correct position (y)
                    arr(y) = temp

                    ' Exit the inner loop, as no further comparisons are necessary for the current element
                    Exit For
                End If
            Next
        Next
    End Sub
End Module
