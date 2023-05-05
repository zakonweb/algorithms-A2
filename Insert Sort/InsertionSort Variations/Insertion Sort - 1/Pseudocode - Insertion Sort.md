```
OUTPUT  "Enter the number of elements: "
INPUT numElements

DECLARE thisArr : ARRAY[0:numElements] OF INTEGER

FOR count ← 0 TO numElements - 1
  OUTPUT  "Enter value ", count + 1, ": "
  INPUT thisArr[count]
NEXT

CALL INSERTIONSORT(thisArr, numElements)

FOR count ← 0 TO numElements - 1
  OUTPUT  thisArr[count]
NEXT
```
```
PROCEDURE INSERTIONSORT(BYREF arr[] : INTEGER, length : INTEGER)
  FOR x ← 1 TO length - 1
    FOR y ← 0 TO x - 1
      IF arr[x] < arr[y] THEN
        temp = arr[x]

        FOR count ← x TO y + 1 STEP -1
          arr[count] = arr[count - 1]
        NEXT

        arr[y] = temp
        EXIT FOR //BREAK
      END IF
    NEXT
  NEXT
END PROCEDURE
```