def iterative_binary_search(arr, target):
    left, right = 0, len(arr) - 1

    # Continue searching while the search space is not empty
    while left <= right:
        # Calculate the middle index
        mid = (left + right) // 2

        # If the middle element is equal to the target, return its index
        if arr[mid] == target:
            return mid
        # If the middle element is smaller than the target, search in the right half
        elif arr[mid] < target:
            left = mid + 1
        # If the middle element is larger than the target, search in the left half
        else:
            right = mid - 1

    # If the target is not found, return -1
    return -1

def recursive_binary_search(arr, target, left, right):
    # Base case: if the search space is empty, the target is not found, return -1
    if left > right:
        return -1

    # Calculate the middle index
    mid = (left + right) // 2

    # If the middle element is equal to the target, return its index
    if arr[mid] == target:
        return mid
    # If the middle element is smaller than the target, search in the right half
    elif arr[mid] < target:
        return recursive_binary_search(arr, target, mid + 1, right)
    # If the middle element is larger than the target, search in the left half
    else:
        return recursive_binary_search(arr, target, left, mid - 1)

arr = [1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, \
       26, 28, 30, 32, 34, 36, 38, 40]

while True:
    print("\nStandard Binary Search Variations:")
    print("1. Iterative Binary Search")
    print("2. Recursive Binary Search")
    print("3. Quit")

    choice = int(input("\nEnter your choice: "))

    if choice == 1 or choice == 2:
        target = int(input("Enter the target value: "))
        
        if choice == 1:
            print("Result:", iterative_binary_search(arr, target))
        elif choice == 2:
            print("Result:", recursive_binary_search(arr, target, 0, len(arr) - 1))
    elif choice == 3:
        break
    else:
        print("Invalid choice. Please try again.")