import random as r

# Standard Bubble Sort;
# never stops if the array is already sorted
def bubble_sort(arr):
    """
    Sorts an array in ascending order using Bubble Sort.

    Args:
        arr: The array to sort.

    Returns:
        None (the array is sorted in-place).
    """
    n = len(arr)
    # Traverse through all array elements
    for i in range(n):
        # Last i elements are already in place
        for j in range(n-i-1):
            # Swap if the element found is greater than the next element
            if arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]

# Modified Bubble Sort; stops if no swaps occur in a pass
def modified_bubble_sort(arr):
    """
    Sorts an array in ascending order using Modified Bubble Sort.

    Args:
        arr: The array to sort.

    Returns:
        None (the array is sorted in-place).
    """
    n = len(arr)
    # Traverse through all array elements
    for i in range(n):
        swapped = False
        # Last i elements are already in place
        for j in range(n-i-1):
            # Swap if the element found is greater than the next element
            if arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]
                swapped = True
        # If no two elements were swapped by inner loop, then break
        if not swapped:
            break

# Recursive Bubble Sort; uses recursion to sort the array
def recursive_bubble_sort(arr):
    """
    Sorts an array in ascending order using Recursive Bubble Sort.

    Args:
        arr: The array to sort.

    Returns:
        The sorted array.
    """
    n = len(arr)
    # Base case
    if n == 1:
        return arr
    # One pass of Bubble Sort. After this pass, the largest element is moved (or bubbled) to the end.
    for i in range(n-1):
        # Swap if the element found is greater than the next element
        if arr[i] > arr[i+1]:
            arr[i], arr[i+1] = arr[i+1], arr[i]
    # Recursively sort the remaining elements
    return recursive_bubble_sort(arr[:n-1]) + [arr[n-1]]

# Cocktail Shaker Sort; bidirectional Bubble Sort
# it sorts the array in both directions alternatively
# to reduce the number of passes
def cocktail_shaker_sort(arr):
    """
    Sorts an array in ascending order using Cocktail Shaker Sort.

    Args:
        arr: The array to sort.

    Returns:
        None (the array is sorted in-place).
    """
    n = len(arr)
    # Traverse the array from both ends
    swapped = True
    start = 0
    end = n-1
    while swapped:
        swapped = False
        # Traverse from left to right
        for i in range(start, end):
            # Swap if the element found is greater than the next element
            if arr[i] > arr[i+1]:
                arr[i], arr[i+1] = arr[i+1], arr[i]
                swapped = True
        # If no swaps occurred, the array is already sorted
        if not swapped:
            break
        swapped = False
        end -= 1
        # Traverse from right to left
        for i in range(end-1, start-1, -1):
            # Swap if the element found is greater than the next element
            if arr[i] > arr[i+1]:
                arr[i], arr[i+1] = arr[i+1], arr[i]
                swapped = True
        start += 1

# Comb Sort; improves Bubble Sort by using gap of size more than 1
# the gap starts with a large value and shrinks by a factor of 1.3
# until it reaches the value 1
# the shrink factor is chosen to be 1.3 because it is empirically
# the best value to use
def comb_sort(arr):
    """
    Sorts an array in ascending order using Comb Sort.
    Args:
        arr: The array to sort.
    Returns:
        None (the array is sorted in-place).
    """
    n = len(arr)
    # Initialize gap as the length of the array
    gap = n
    # Set the shrink factor to 1.3
    shrink = 1.3
    # Flag to indicate if any swaps occurred
    swapped = True
    while gap > 1 or swapped:
        # Update the gap according to the shrink factor
        gap = int(gap / shrink)
        if gap < 1:
            gap = 1
        swapped = False
        # Compare elements with a gap of 'gap'
        for i in range(n-gap):
            # Swap if the element found is greater than the next element
            if arr[i] > arr[i+gap]:
                arr[i], arr[i+gap] = arr[i+gap], arr[i]
                swapped = True

# main menu for the program
choice = 0
# generate a random array of 10 elements
while choice != 6:
    arr = []
    arr = [r.randint(0, 100) for i in range(10)]    
    print("1. Bubble Sort")
    print("2. Modified Bubble Sort")
    print("3. Recursive Bubble Sort")
    print("4. Cocktail Shaker Sort")
    print("5. Comb Sort")
    print("6. Exit")
    choice = int(input("Enter your choice: "))
    if choice == 1:
        print("Array before sorting:", arr)
        bubble_sort(arr)
        print("Array after sorting:", arr)
    elif choice == 2:
        print("Array before sorting:", arr)
        modified_bubble_sort(arr)
        print("Array after sorting:", arr)
    elif choice == 3:
        print("Array before sorting:", arr)
        arr = recursive_bubble_sort(arr)
        print("Array after sorting:", arr)
    elif choice == 4:
        print("Array before sorting:", arr)
        cocktail_shaker_sort(arr)
        print("Array after sorting:", arr)
    elif choice == 5:
        print("Array before sorting:", arr)
        comb_sort(arr)
        print("Array after sorting:", arr)
    elif choice == 6:
        print("Exiting!")
# end of program