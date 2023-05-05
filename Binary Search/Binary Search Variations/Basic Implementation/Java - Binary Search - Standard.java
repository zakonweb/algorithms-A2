import java.util.Scanner;

class BinarySearch {
    public static int iterativeBinarySearch(int[] arr, int target) {
        int left = 0, right = arr.length - 1;

        while (left <= right) {
            int mid = (left + right) / 2;

            if (arr[mid] == target) {
                return mid;
            } else if (arr[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return -1;
    }

    public static int recursiveBinarySearch(int[] arr, int target, int left, int right) {
        if (left > right) {
            return -1;
        }

        int mid = (left + right) / 2;

        if (arr[mid] == target) {
            return mid;
        } else if (arr[mid] < target) {
            return recursiveBinarySearch(arr, target, mid + 1, right);
        } else {
            return recursiveBinarySearch(arr, target, left, mid - 1);
        }
    }

    public static void main(String[] args) {
        int[] arr = {1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40};
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.println("\nStandard Binary Search Variations:");
            System.out.println("1. Iterative Binary Search");
            System.out.println("2. Recursive Binary Search");
            System.out.println("3. Quit");

            System.out.print("\nEnter your choice: ");
            int choice = sc.nextInt();

            if (choice == 1 || choice == 2) {
                System.out.print("Enter the target value: ");
                int target = sc.nextInt();

                if (choice == 1) {
                    System.out.println("Result: " + iterativeBinarySearch(arr, target));
                } else {
                    System.out.println("Result: " + recursiveBinarySearch(arr, target, 0, arr.length - 1));
                }
            } else if (choice == 3) {
                break;
            } else {
                System.out.println("Invalid choice. Please try again.");
            }
        }

        sc.close();
    }
}
