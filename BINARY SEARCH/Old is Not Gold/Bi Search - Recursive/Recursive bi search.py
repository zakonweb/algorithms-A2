def binarySearch(thisArr, UB, LB, value):
    if LB > UB:
        return -1 #not found
    else:
        middle = int((UB+LB)/2)
        if thisArr[middle] == value: #found
            return middle
        elif thisArr[middle] > value:
            return(binarySearch(thisArr, middle-1,LB,value))
        elif thisArr[middle] < value:
            return(binarySearch(thisArr, UB, middle+1, value))


thisArr = ["", "a", "b", "c", "d", "e", "f", "g", "h", "i" "j"]

value = input("Enter value between a and j: ")
result = binarySearch(thisArr, 10, 1, value)

if result == -1:
    print(value, "not found.")
else:
    print(value, "found at position", result)
