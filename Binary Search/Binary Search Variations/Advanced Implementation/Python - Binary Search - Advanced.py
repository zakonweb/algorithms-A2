def iterative_binary_search(arr, target):
    left, right = 0, len(arr) - 1

    while left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            return mid
        elif arr[mid] < target:
            left = mid + 1
        else:
            right = mid - 1

    return -1

def recursive_binary_search(arr, target, left, right):
    if left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            return mid
        elif arr[mid] < target:
            return recursive_binary_search(arr, target, mid + 1, right)
        else:
            return recursive_binary_search(arr, target, left, mid - 1)

    return -1

def iterative_leftmost_binary_search(arr, target):
    left, right = 0, len(arr) - 1
    result = -1

    while left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            result = mid
            right = mid - 1
        elif arr[mid] < target:
            left = mid + 1
        else:
            right = mid - 1

    return result

def recursive_leftmost_binary_search(arr, target, left, right, result=-1):
    if left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            result = mid
            return recursive_leftmost_binary_search(arr, target, left, mid - 1, result)
        elif arr[mid] < target:
            return recursive_leftmost_binary_search(arr, target, mid + 1, right, result)
        else:
            return recursive_leftmost_binary_search(arr, target, left, mid - 1, result)

    return result

def iterative_rightmost_binary_search(arr, target):
    left, right = 0, len(arr) - 1
    result = -1

    while left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            result = mid
            left = mid + 1
        elif arr[mid] < target:
            left = mid + 1
        else:
            right = mid - 1

    return result

def recursive_rightmost_binary_search(arr, target, left, right, result=-1):
    if left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            result = mid
            return recursive_rightmost_binary_search(arr, target, mid + 1, right, result)
        elif arr[mid] < target:
            return recursive_rightmost_binary_search(arr, target, mid + 1, right, result)
        else:
            return recursive_rightmost_binary_search(arr, target, left, mid - 1, result)

    return result

def iterative_lower_bound_binary_search(arr, target):
    left, right = 0, len(arr) - 1
    result = -1

    while left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            result = mid
            right = mid - 1
        elif arr[mid] < target:
            left = mid + 1
        else:
            result = mid
            right = mid - 1

    return result

def recursive_lower_bound_binary_search(arr, target, left, right, result=-1):
    if left <= right:
        mid = (left + right) // 2

        if arr[mid] == target:
            result = mid
            return recursive_lower_bound_binary_search(arr, target, left, mid - 1, result)
        elif arr[mid] < target:
            return recursive_lower_bound_binary_search(arr, target, mid + 1, right, result)
        else:
            result = mid
            return recursive_lower_bound_binary_search(arr, target, left, mid - 1, result)

    return result

def iterative_upper_bound_binary_search(arr, target):
    left, right = 0, len(arr) - 1
    result = -1

    while left <= right:
        mid = (left + right) // 2

        if arr[mid] <= target:
            left = mid + 1
        else:
            result = mid
            right = mid - 1

    return result

def recursive_upper_bound_binary_search(arr, target, left, right, result=-1):
    if left <= right:
        mid = (left + right) // 2

        if arr[mid] <= target:
            return recursive_upper_bound_binary_search(arr, target, mid + 1, right, result)
        else:
            result = mid
            return recursive_upper_bound_binary_search(arr, target, left, mid - 1, result)

    return result

def main():
    arr = [1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40]

    while True:
        print("\nBinary Search Variations:")
        print("1. Standard Binary Search (Iterative)")
        print("2. Standard Binary Search (Recursive)")
        print("3. Leftmost Binary Search (Iterative)")
        print("4. Leftmost Binary Search (Recursive)")
        print("5. Rightmost Binary Search (Iterative)")
        print("6. Rightmost Binary Search (Recursive)")
        print("7. Lower Bound Binary Search (Iterative)")
        print("8. Lower Bound Binary Search (Recursive)")
        print("9. Upper Bound Binary Search (Iterative)")
        print("10. Upper Bound Binary Search (Recursive)")
        print("11. Quit")
        choice = int(input("\nEnter your choice: "))

        if choice != 11:
            target = int(input("Enter the target: "))
        
        if choice == 1:
            print("Result:", iterative_binary_search(arr, target))
        elif choice == 2:
            print("Result:", recursive_binary_search(arr, target, 0, len(arr) - 1))
        elif choice == 3:
            print("Result:", iterative_leftmost_binary_search(arr, target))
        elif choice == 4:
            print("Result:", recursive_leftmost_binary_search(arr, target, 0, len(arr) - 1))
        elif choice == 5:
            print("Result:", iterative_rightmost_binary_search(arr, target))
        elif choice == 6:
            print("Result:", recursive_rightmost_binary_search(arr, target, 0, len(arr) - 1))
        elif choice == 7:
            print("Result:", iterative_lower_bound_binary_search(arr, target))
        elif choice == 8:
            print("Result:", recursive_lower_bound_binary_search(arr, target, 0, len(arr) - 1))
        elif choice == 9:
            print("Result:", iterative_upper_bound_binary_search(arr, target))
        elif choice == 10:
            print("Result:", recursive_upper_bound_binary_search(arr, target, 0, len(arr) - 1))
        elif choice == 11:
            break
        else:
            print("Invalid choice. Please try again.")

if __name__ == "__main__":
    main()
