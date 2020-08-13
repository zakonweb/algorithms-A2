def BinaryS(value):
    isFound = False
    LB = 0
    UB = 9
    while UB > LB or isFound == False:
        middle = (LB+UB)//2
        if alpha[middle] == value:
            isFound = True
            return middle
        elif value < alpha[middle]:
            UB = middle-1
        else:
            LB = middle+1
    return -1


alpha = ["","a","b","c","d","e","f","g","h","i"]
c2s = input()
print(c2s,"found at location", BinaryS(c2s))