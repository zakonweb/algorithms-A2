def main():
    # Ask the user for the number of elements to sort
    num_elements = int(input("Enter the number of elements: "))

    this_arr = []

    # Input values for each element in the array
    for count in range(num_elements):
        value = int(input(f"Enter value {count + 1}: "))
        this_arr.append(value)

    # Perform Insertion Sort on the array
    insertion_sort(this_arr, num_elements)

    # Show all sorted values in the array
    for count in range(num_elements):
        print(this_arr[count])


def insertion_sort(arr, length):
    # Iterate through the array, starting with the second element (position 1)
    for x in range(1, length):
        # Compare the current element (arr[x]) with all elements before it (arr[y])
        for y in range(x):
            # If the current element is smaller than the compared element, perform the swap
            if arr[x] < arr[y]:
                temp = arr[x]

                # Shift all elements between the current position (x) and the compared position (y) one position to the right
                for count in range(x, y, -1):
                    arr[count] = arr[count - 1]

                # Insert the sorted value at the correct position (y)
                arr[y] = temp
                break


if __name__ == "__main__":
    main()
