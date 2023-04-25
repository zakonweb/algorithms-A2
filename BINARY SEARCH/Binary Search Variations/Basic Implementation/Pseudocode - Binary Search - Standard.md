FUNCTION iterativeBinarySearch(arr[], target) RETURNS INTEGER
    DECLARE left, right, mid : INTEGER
    left ← 0
    right ← length(arr) - 1

    WHILE left <= right DO
        mid ← (left + right) MOD 2
        IF arr[mid] = target THEN
           RETURN mid
        ELSEIF arr[mid] < target THEN
           left ← mid + 1
        ELSE
           SET right ← mid - 1
        END IF
    ENDWHILE
    RETURN -1
END FUNCTION

FUNCTION recursiveBinarySearch(arr[], target, left, right) RETURN INTEGER
    DECLARE left, right, mid : INTEGER
    IF left > right THEN
        RETURN -1
    END IF
    mid ← (left + right) MOD 2
    IF arr[mid] = target THEN
        RETURN mid
    ELSEIF arr[mid] < target THEN
        RETURN recursiveBinarySearch(arr, target, mid + 1, right)
    ELSE
        RETURN recursiveBinarySearch(arr, target, left, mid - 1)
    END IF
END FUNCTION

PROCEDURE DisplayMenu()
    OUTPUT "Standard Binary Search Variations:"
    OUTPUT "1. Iterative Binary Search"
    OUTPUT "2. Recursive Binary Search"
    OUTPUT "3. Quit"
    OUTPUT "Enter your choice: "
END PROCEDURE

DECLARE arr : ARRAY[] OF INTEGER
arr[] ← [1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40]

DECLARE Choice : INTEGER
WHILE TRUE DO
    CALL DisplayMenu()
    INPUT choice

    IF choice = 1 OR choice = 2 THEN
        OUTPUT "Enter the target value: "
        INPUT target

        IF choice = 1 THEN
            OUTPUT "Result: " + iterativeBinarySearch(arr, target)
        ELSE
            OUTPUT "Result: " + recursiveBinarySearch(arr, target, 0, length(arr) - 1)
        END IF
    ELSE IF choice = 3 THEN
        EXIT WHILE
    ELSE
        OUTPUT"Invalid choice. Please try again."
    END IF
END WHILE