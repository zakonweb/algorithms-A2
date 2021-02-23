# bubble sort
def bubble(arr):
    ub = len(arr) -1
    lb = -1
    for j in range(ub,lb,-1):
        alreadyOrdered = True
        for i in range(0,j):
            if arr[i] > arr[i+1]:
                temp = arr[i]
                arr[i] = arr[i+1]
                arr[i+1] = temp
                alreadyOrdered = False
        if alreadyOrdered == True:
            break

arr = [9,45,30,50,49,15,3,38]
print(arr)
bubble(arr)
print(arr)