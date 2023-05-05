import java.util.Scanner;

class InsertionSort {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numElements;

        System.out.print("Enter the number of elements: ");
        numElements = scanner.nextInt();

        int[] thisArr = new int[numElements];

        // Input values for each element in the array
        for (int count = 0; count < numElements; count++) {
            System.out.print("Enter value " + (count + 1) + ": ");
            thisArr[count] = scanner.nextInt();
        }

        // Perform Insertion Sort on the array
        insertionSort(thisArr, numElements);

        // Show all sorted values in the array
        for (int count = 0; count < numElements; count++) {
            System.out.println(thisArr[count]);
        }
    }

    // InsertionSort function takes an array and its length as input and sorts it using the Insertion Sort algorithm
    public static void insertionSort(int[] arr, int length) {
        int x, y, temp;

        // Iterate through the array, starting with the second element (position 1)
        for (x = 1; x < length; x++) {
            // Compare the current element (arr[x]) with all elements before it (arr[y])
            for (y = 0; y < x; y++) {
                // If the current element is smaller than the compared element, perform the swap
                if (arr[x] < arr[y]) {
                    temp = arr[x];

                    // Shift all elements between the current position (x) and the compared position (y) one position to the right
                    for (int count = x; count > y; count--) {
                        arr[count] = arr[count - 1];
                    }

                    // Insert the sorted value at the correct position (y)
                    arr[y] = temp;
                    break;
                }
            }
        }
    }
}
