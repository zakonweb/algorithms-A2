PROCEDURE BubbleSort(ByRef arr[])
    DECLARE n, i, j, temp : INTEGER
    n ← length(arr)
    FOR i ← 0 to n - 1
        FOR j ← 0 to n - i - 2
            IF arr[j] > arr[j+1] THEN
                temp ← arr[j]
                arr[j] ← arr[j+1]
                arr[j+1] ← temp
            END IF
        NEXT
    NEXT
END PROCEDURE

PROCEDURE ModifiedBubbleSort(ByRef arr[])
    DECLARE n, i, j, temp : INTEGER
    DECLARE swapped : BOOLEAN
    n ← length(arr)
    FOR i ← 0 to n - 1
        swapped ← False
        FOR j ← 0 to n - i - 2
            IF arr[j] > arr[j+1] THEN
                temp ← arr[j]
                arr[j] ← arr[j+1]
                arr[j+1] ← temp
                swapped ← True
            END IF
        NEXT
        IF NOT swapped THEN
            EXIT FOR
        END IF
    NEXT
END PROCEDURE

PROCEDURE RecursiveBubbleSort(ByRef arr[], n)
    DECLARE i, temp : INTEGER
    IF n ← 1 THEN
        RETURN 0
    END IF

    FOR i ← 0 to n - 2
        IF arr[i] > arr[i+1] THEN
            temp ← arr[i]
            arr[i] ← arr[i+1]
            arr[i+1] ← temp
        END IF
    NEXT
    CALL RecursiveBubbleSort(arr, n-1)
END PROCEDURE

PROCEDURE CocktailShakerSort(ByRef arr[])
    DECLARE start, end, n, i, temp : INTEGER
    DECLARE swapped : BOOLEAN
    n ← length(arr)
    swapped ← True
    start ← 0
    end ← n - 1
    WHILE swapped
        swapped ← False
        FOR i ← start to end - 1
            IF arr[i] > arr[i+1] THEN
                temp ← arr[i]
                arr[i] ← arr[i+1]
                arr[i+1] ← temp
                swapped ← True
            END IF
        NEXT
        IF NOT swapped THEN
            EXIT WHILE
        END IF
        swapped ← False
        end ← end - 1
        FOR i ← end - 1 to start STEP -1
            IF arr[i] > arr[i+1] THEN
                temp ← arr[i]
                arr[i] ← arr[i+1]
                arr[i+1] ← temp
                swapped ← True
            END IF
        NEXT
        start ← start + 1
    END WHILE
END PROCEDURE

PROCEDURE CombSort(ByRef arr[])
    DECLARE n, i, gap, temp : INTEGER
    DECLARE swapped : BOOLEAN
    CONSTANT shrink ← 1.3
   
    n ← length(arr)
    gap ← n
    swapped ← True
    WHILE gap > 1 OR swapped
        gap ← INT(gap / shrink)
        IF gap < 1 THEN
            gap ← 1
        END IF
        swapped ← False
        FOR i ← 0 to n - gap - 1
            IF arr[i] > arr[i+gap] THEN
                temp ← arr[i]
                arr[i] ← arr[i+gap]
                arr[i+gap] ← temp
                swapped ← True
            END IF
        NEXT
    END WHILE
END PROCEDURE

DECLARE i, choice, rand : INTEGER
choice ← 0
rand ← new Random()
Dim arr : ARRAY [0:9] OF Integer

While choice <> 6
    OUTPUT ("1. Bubble Sort")
    OUTPUT ("2. Modified Bubble Sort")
    OUTPUT ("3. Recursive Bubble Sort")
    OUTPUT ("4. Cocktail Shaker Sort")
    OUTPUT ("5. Comb Sort")
    OUTPUT ("6. Exit")
    OUTPUT ("Enter your choice: ")
    INPUT choice

    ' generate a random array of 10 elements
    For i ← 0 To 9
        arr[i] ← rand(0, 100)
    Next

    If choice = 1 Then
        OUTPUT "Array before sorting: " + String.Join(", ", arr)
        CALL BubbleSort(arr)
        OUTPUT "Array after sorting: " + String.Join(", ", arr)
    ElseIf choice = 2 Then
        OUTPUT "Array before sorting: " + String.Join(", ", arr)
        CALL ModifiedBubbleSort(arr)
        OUTPUT "Array after sorting: " + String.Join(", ", arr)
    ElseIf choice = 3 Then
        OUTPUT "Array before sorting: " + String.Join(", ", arr)
        CALL RecursiveBubbleSort(arr, arr.Length)
        OUTPUT "Array after sorting: " + String.Join(", ", arr)
    ElseIf choice = 4 Then
        OUTPUT "Array before sorting: " + String.Join(", ", arr)
        CALL CocktailShakerSort(arr)
        OUTPUT "Array after sorting: " + String.Join(", ", arr)
    ElseIf choice = 5 Then
        OUTPUT "Array before sorting: " + String.Join(", ", arr)
        CALL CombSort(arr)
        OUTPUT "Array after sorting: " + String.Join(", ", arr)
    ElseIf choice = 6 Then
        OUTPUT "Exiting!"
    End If
End While