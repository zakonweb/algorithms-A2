import java.util.*;

class Sorting {
    // Standard Bubble Sort;
    // never stops if the array is already sorted
    public static void bubbleSort(int[] arr) {
        int n = arr.length;
        // Traverse through all array elements
        for (int i = 0; i < n; i++) {
            // Last i elements are already in place
            for (int j = 0; j < n-i-1; j++) {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j+1]) {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }

    // Modified Bubble Sort; stops if no swaps occur in a pass
    public static void modifiedBubbleSort(int[] arr) {
        int n = arr.length;
        // Traverse through all array elements
        for (int i = 0; i < n; i++) {
            boolean swapped = false;
            // Last i elements are already in place
            for (int j = 0; j < n-i-1; j++) {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j+1]) {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                    swapped = true;
                }
            }
            // If no two elements were swapped by inner loop, then break
            if (!swapped) {
                break;
            }
        }
    }

    // Recursive Bubble Sort; uses recursion to sort the array
    public static int[] recursiveBubbleSort(int[] arr) {
        int n = arr.length;
        // Base case
        if (n == 1) {
            return arr;
        }
        // One pass of Bubble Sort. After this pass, the largest element is moved (or bubbled) to the end.
        for (int i = 0; i < n-1; i++) {
            // Swap if the element found is greater than the next element
            if (arr[i] > arr[i+1]) {
                int temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
            }
        }
        // Recursively sort the remaining elements
        int[] result = Arrays.copyOfRange(arr, 0, n-1);
        int[] lastElement = new int[] { arr[n-1] };
        return concatenateArrays(recursiveBubbleSort(result), lastElement);
    }

    // Cocktail Shaker Sort; bidirectional Bubble Sort
    // it sorts the array in both directions alternatively
    // to reduce the number of passes
    public static void cocktailShakerSort(int[] arr) {
        int n = arr.length;
        // Traverse the array from both ends
        boolean swapped = true;
        int start = 0;
        int end = n-1;
        while (swapped) {
            swapped = false;
            // Traverse from left to right
            for (int i = start; i < end; i++) {
                // Swap if the element found is greater than the next element
                if (arr[i] > arr[i+1]) {
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    swapped = true;
                }
            }
            // If no swaps occurred, the array is already sorted
            if (!swapped) {
               
                break;
            }
            swapped = false;
            end--;
            // Traverse from right to left
            for (int i = end-1; i >= start; i--) {
                // Swap if the element found is greater than the next element
                if (arr[i] > arr[i+1]) {
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    swapped = true;
                }
            }
            start++;
        }
    }
    
    // Comb Sort; improves Bubble Sort by using gap of size more than 1
    // the gap starts with a large value and shrinks by a factor of 1.3
    // until it reaches the value 1
    // the shrink factor is chosen to be 1.3 because it is empirically
    // the best value to use
    public static void combSort(int[] arr) {
        int n = arr.length;
        // Initialize gap as the length of the array
        int gap = n;
        // Set the shrink factor to 1.3
        double shrink = 1.3;
        // Flag to indicate if any swaps occurred
        boolean swapped = true;
        while (gap > 1 || swapped) {
            // Update the gap according to the shrink factor
            gap = (int) (gap / shrink);
            if (gap < 1) {
                gap = 1;
            }
            swapped = false;
            // Compare elements with a gap of 'gap'
            for (int i = 0; i < n-gap; i++) {
                // Swap if the element found is greater than the next element
                if (arr[i] > arr[i+gap]) {
                    int temp = arr[i];
                    arr[i] = arr[i+gap];
                    arr[i+gap] = temp;
                    swapped = true;
                }
            }
        }
    }
    
    // Concatenate two arrays
    public static int[] concatenateArrays(int[] arr1, int[] arr2) {
        int[] result = new int[arr1.length + arr2.length];
        System.arraycopy(arr1, 0, result, 0, arr1.length);
        System.arraycopy(arr2, 0, result, arr1.length, arr2.length);
        return result;
    }
    
    // Main method for the program
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int choice = 0;
        // Generate a random array of 10 elements
        int[] arr = new int[10];
        Random r = new Random();
        while (choice != 6) {
            System.out.println("1. Bubble Sort");
            System.out.println("2. Modified Bubble Sort");
            System.out.println("3. Recursive Bubble Sort");
            System.out.println("4. Cocktail Shaker Sort");
            System.out.println("5. Comb Sort");
            System.out.println("6. Exit");
            System.out.print("Enter your choice: ");
            choice = sc.nextInt();

            for (int i = 0; i < arr.length; i++) {
                arr[i] = r.nextInt(100);
            }
            
            if (choice == 1) {
                System.out.println("Array before sorting: " + Arrays.toString(arr));
                bubbleSort(arr);
                System.out.println("Array after sorting: " + Arrays.toString(arr));
            } else if (choice == 2) {
                System.out.println("Array before sorting: " + Arrays.toString(arr));
                modifiedBubbleSort(arr);
                System.out.println("Array after sorting: " + Arrays.toString(arr));
            } else if (choice == 3)
            {
                System.out.println("Array before sorting: " + Arrays.toString(arr));
                arr = recursiveBubbleSort(arr);
                System.out.println("Array after sorting: " + Arrays.toString(arr));
            } else if (choice == 4) {
                System.out.println("Array before sorting: " + Arrays.toString(arr));
                cocktailShakerSort(arr);
                System.out.println("Array after sorting: " + Arrays.toString(arr));
            } else if (choice == 5) {
                System.out.println("Array before sorting: " + Arrays.toString(arr));
                combSort(arr);
                System.out.println("Array after sorting: " + Arrays.toString(arr));
            } else if (choice == 6) {
                System.out.println("Exiting!");
            } else {
                System.out.println("Invalid choice. Please try again.");
            }
        }
        sc.close();
    }
}