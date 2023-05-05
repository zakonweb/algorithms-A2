# iterative factorial function
def factorial(n):
    result = 1
    for i in range(1, n + 1):
        result = result * i
    return result

# recursive factorial function
def recFactorial(n):
    if n == 1:
        return 1
    else:
        return n * recFactorial(n - 1)

"""
# test the functions
for i in range(1, 6):
    print(i, factorial(i), recFactorial(i))
"""

# create an array list for binary search code
myArr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

# binary search function
def binarySearch(target):
    low = 0
    high = len(myArr) - 1
    while low <= high:
        mid = (low + high) // 2
        if target == myArr[mid]:
            return mid
        elif target < myArr[mid]:
            high = mid - 1
        else:
            low = mid + 1
    return -1

# recursive binary search function
def recBinarySearch(target, low, high):
    if low > high:
        return -1
    mid = (low + high) // 2
    if target == myArr[mid]:
        return mid
    elif target < myArr[mid]:
        return recBinarySearch(target, low, mid - 1)
    else:
        return recBinarySearch(target, mid + 1, high)

# test the binary search functions
for i in range(1, 12):
    print(i, binarySearch(i), recBinarySearch(i, 0, len(myArr) - 1))

