```
FUNCTION IterativeBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER) RETURNS INTEGER
    DECLARE left, right, mid: INTEGER
    left ← 0
    right ← LENGTH(arr) - 1

    WHILE left <= right
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            RETURN mid
        ELSE IF arr[mid] < target THEN
            left ← mid + 1
        ELSE
            right ← mid - 1
        END IF
    END WHILE

    RETURN -1
END FUNCTION
```
```
FUNCTION RecursiveBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER, left: INTEGER, right: INTEGER) RETURNS INTEGER
    IF left <= right THEN
        DECLARE mid: INTEGER
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            RETURN mid
        ELSE IF arr[mid] < target THEN
            RETURN RecursiveBinarySearch(arr, target, mid + 1, right)
        ELSE
            RETURN RecursiveBinarySearch(arr, target, left, mid - 1)
        END IF
    END IF

    RETURN -1
END FUNCTION
```
```
FUNCTION IterativeLeftmostBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER) RETURNS INTEGER
    DECLARE left, right, mid, result: INTEGER
    left ← 0
    right ← LENGTH(arr) - 1
    result ← -1

    WHILE left <= right
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            result ← mid
            right ← mid - 1
        ELSE IF arr[mid] < target THEN
            left ← mid + 1
        ELSE
            right ← mid - 1
        END IF
    END WHILE

    RETURN result
END FUNCTION
```
```
FUNCTION RecursiveLeftmostBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER, left: INTEGER, right: INTEGER, result: INTEGER = -1) RETURNS INTEGER
    IF left <= right THEN
        DECLARE mid: INTEGER
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            result ← mid
            RETURN RecursiveLeftmostBinarySearch(arr, target, left, mid - 1, result)
        ELSE IF arr[mid] < target THEN
            RETURN RecursiveLeftmostBinarySearch(arr, target, mid + 1, right, result)
        ELSE
            RETURN RecursiveLeftmostBinarySearch(arr, target, left, mid - 1, result)
        END IF
    END IF

    RETURN result
END FUNCTION
```
```
FUNCTION IterativeRightmostBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER) RETURNS INTEGER
    DECLARE left, right, mid, result: INTEGER
    left ← 0
    right ← LENGTH(arr) - 1
    result ← -1

    WHILE left <= right
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            result ← mid
            left ← mid + 1
        ELSE IF arr[mid] < target THEN
            left ← mid + 1
        ELSE
            right ← mid - 1
        END IF
    END WHILE

    RETURN result
END FUNCTION
```
```
FUNCTION RecursiveRightmostBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER, left: INTEGER, right: INTEGER, result: INTEGER = -1) RETURNS INTEGER
    IF left <= right THEN
        DECLARE mid: INTEGER
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            result ← mid
            RETURN RecursiveRightmostBinarySearch(arr, target, mid + 1, right, result)
        ELSE IF arr[mid] < target THEN
            RETURN RecursiveRightmostBinarySearch(arr, target, mid + 1, right, result)
        ELSE
            RETURN RecursiveRightmostBinarySearch(arr, target, left, mid - 1, result)
        END IF
    END IF

    RETURN result
END FUNCTION
```
```
FUNCTION IterativeLowerBoundBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER) RETURNS INTEGER
    DECLARE left, right, mid, result: INTEGER
    left ← 0
    right ← LENGTH(arr) - 1
    result ← -1

    WHILE left <= right
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            result ← mid
            right ← mid - 1
        ELSE IF arr[mid] < target THEN
            left ← mid + 1
        ELSE
            result ← mid
            right ← mid - 1
        END IF
    END WHILE

    RETURN result
END FUNCTION
```
```
FUNCTION RecursiveLowerBoundBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER, left: INTEGER, right: INTEGER, result: INTEGER = -1) RETURNS INTEGER
    IF left <= right THEN
        DECLARE mid: INTEGER
        mid ← (left + right) / 2

        IF arr[mid] = target THEN
            result ← mid
            RETURN RecursiveLowerBoundBinarySearch(arr, target, left, mid - 1, result)
        ELSE IF arr[mid] < target THEN
            RETURN RecursiveLowerBoundBinarySearch(arr, target, mid + 1, right, result)
        ELSE
            result ← mid
            RETURN RecursiveLowerBoundBinarySearch(arr, target, left, mid - 1, result)
        END IF
    END IF

    RETURN result
END FUNCTION
```
```
FUNCTION IterativeUpperBoundBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER) RETURNS INTEGER
    DECLARE left, right, mid, result: INTEGER
    left ← 0
    right ← LENGTH(arr) - 1
    result ← -1

    WHILE left <= right
        mid ← (left + right) / 2

        IF arr[mid] <= target THEN
            left ← mid + 1
        ELSE
            result ← mid
            right ← mid - 1
        END IF
    END WHILE

    RETURN result
END FUNCTION
```
```
FUNCTION RecursiveUpperBoundBinarySearch(arr: ARRAY OF INTEGER, target: INTEGER, left: INTEGER, right: INTEGER, result: INTEGER = -1) RETURNS INTEGER
    IF left <= right THEN
        DECLARE mid: INTEGER
        mid ← (left + right) / 2

        IF arr[mid] <= target THEN
            RETURN RecursiveUpperBoundBinarySearch(arr, target, mid + 1, right, result)
        ELSE
            result ← mid
            RETURN RecursiveUpperBoundBinarySearch(arr, target, left, mid - 1, result)
        END IF
    END IF

    RETURN result
END FUNCTION
```
```
DECLARE arr: ARRAY [1:22] OF INTEGER
arr ← [1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40]

WHILE True
    OUTPUT "Binary Search Variations:"
    OUTPUT "1. Iterative Binary Search"
    OUTPUT "2. Recursive Binary Search"
    OUTPUT "3. Iterative Leftmost Binary Search"
    OUTPUT "4. Recursive Leftmost Binary Search"
    OUTPUT "5. Iterative Rightmost Binary Search"
    OUTPUT "6. Recursive Rightmost Binary Search"
    OUTPUT "7. Iterative Lower Bound Binary Search"
    OUTPUT "8. Recursive Lower Bound Binary Search"
    OUTPUT "9. Iterative Upper Bound Binary Search"
    OUTPUT "10. Recursive Upper Bound Binary Search"
    OUTPUT "0. Exit"
    OUTPUT "Enter your choice: "

    DECLARE choice, target, result: INTEGER
    INPUT choice

    IF choice = 0 THEN
        BREAK
    END IF

    OUTPUT "Enter the target value: "
    INPUT target

    CASE choice OF
        1:
            result ← IterativeBinarySearch(arr, target)
        2:
            result ← RecursiveBinarySearch(arr, target, 0, LENGTH(arr) - 1)
        3:
            result ← IterativeLeftmostBinarySearch(arr, target)
        4:
            result ← RecursiveLeftmostBinarySearch(arr, target, 0, LENGTH(arr) - 1)
        5:
            result ← IterativeRightmostBinarySearch(arr, target)
        6:
            result ← RecursiveRightmostBinarySearch(arr, target, 0, LENGTH(arr) - 1)
        7:
            result ← IterativeLowerBoundBinarySearch(arr, target)
        8:
            result ← RecursiveLowerBoundBinarySearch(arr, target, 0, LENGTH(arr) - 1)
        9:
            result ← IterativeUpperBoundBinarySearch(arr, target)
        10:
            result ← RecursiveUpperBoundBinarySearch(arr, target, 0, LENGTH(arr) - 1)
    END CASE

    IF result = -1 THEN
        OUTPUT "Target not found."
    ELSE
        OUTPUT "Target found at index: ", result
    END IF

    OUTPUT ""
END WHILE
```
