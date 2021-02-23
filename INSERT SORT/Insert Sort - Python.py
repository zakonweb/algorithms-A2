#  insert sort algorithm
def insertSort(arr):
    lb = 0
    ub = len(arr)
    firstP = lb +1
    secondP = 0
    temp = -1
    i = 0

    for firstP in range(lb+1,ub):
        for secondP in range(0,firstP):
            if arr[secondP] > arr[firstP]:
                temp = arr[firstP]
                for i in range(firstP,secondP,-1):
                    arr[i] = arr[i-1]
                arr[secondP] = temp
                break

# main module
arr = [20,5,19,4,10,6,1]
print(arr)
insertSort(arr)
print(arr)