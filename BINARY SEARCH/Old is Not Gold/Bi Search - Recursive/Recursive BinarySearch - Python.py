# binary search recursive function
def recursiveBinSearch(arr, ub, lb, data):
    mid = (ub + lb) // 2
    if lb > ub:  # base case
        return -1
    elif arr[mid] == data:
        return mid
    elif data > arr[mid]: # general case
        return recursiveBinSearch(arr, ub, mid+1, data)
    else: # general case
        return recursiveBinSearch(arr, mid-1, lb, data)

arr = ["a","b","c","d","e","f","g","h","i","j","k"]
x = input("Enter item to search for: ")
position = recursiveBinSearch(arr, len(arr)-1, 0, x)

if position != -1:
    print(x, "item found @", position+1)
else:
    print(x, "item couldn't be found.")