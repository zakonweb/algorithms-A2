import java.util.Scanner;

class BinarySearch {

    public static int iterativeBinarySearch(int[] arr, int target) {
        int left = 0;
        int right = arr.length - 1;

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
        if (left <= right) {
            int mid = (left + right) / 2;

            if (arr[mid] == target) {
                return mid;
            } else if (arr[mid] < target) {
                return recursiveBinarySearch(arr, target, mid + 1, right);
            } else {
                return recursiveBinarySearch(arr, target, left, mid - 1);
            }
        }

        return -1;
    }

    public static int iterativeLeftmostBinarySearch(int[] arr, int target) {
        int left = 0;
        int right = arr.length - 1;
        int result = -1;

        while (left <= right) {
            int mid = (left + right) / 2;

            if (arr[mid] == target) {
                result = mid;
                right = mid - 1;
            } else if (arr[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return result;
    }

    public static int recursiveLeftmostBinarySearch(int[] arr, int target, int left, int right, int result) {
        if (left <= right) {
            int mid = (left + right) / 2;

            if (arr[mid] == target) {
                result = mid;
                return recursiveLeftmostBinarySearch(arr, target, left, mid - 1, result);
            } else if (arr[mid] < target) {
                return recursiveLeftmostBinarySearch(arr, target, mid + 1, right, result);
            } else {
                return recursiveLeftmostBinarySearch(arr, target, left, mid - 1, result);
            }
        }

        return result;
    }
    
    public static int iterativeRightmostBinarySearch(int[] arr, int target) {
        int left = 0;
        int right = arr.length - 1;
        int result = -1;

        while (left <= right) {
            int mid = (left + right) / 2;

            if (arr[mid] == target) {
                result = mid;
                left = mid + 1;
            } else if (arr[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return result;
    }

    /**
     * @param arr
     * @param target
     * @param left
     * @param right
     * @param result
     * @return
     */
    public static int recursiveRightmostBinarySearch(int[] arr, int target, int left, int right, int result) {
        if (left <= right) {
            int mid = (left + right) / 2;

            if (arr[mid] == target) {
                result = mid;
                return recursiveRightmostBinarySearch(arr, target, mid + 1, right, result);
            } else if (arr[mid] < target) {
                return recursiveRightmostBinarySearch(arr, target, mid + 1, right, result);
            }
        } else {
            int mid = (left + right) / 2;
            return recursiveRightmostBinarySearch(arr, target, left, mid - 1, result);
        }

        return result;
    }

public static int iterativeLowerBoundBinarySearch(int[] arr, int target) {
    int left = 0;
    int right = arr.length - 1;
    int result = -1;

    while (left <= right) {
        int mid = (left + right) / 2;

        if (arr[mid] == target) {
            result = mid;
            right = mid - 1;
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            result = mid;
            right = mid - 1;
        }
    }

    return result;
}

public static int recursiveLowerBoundBinarySearch(int[] arr, int target, int left, int right, int result) {
    if (left <= right) {
        int mid = (left + right) / 2;

        if (arr[mid] == target) {
            result = mid;
            return recursiveLowerBoundBinarySearch(arr, target, left, mid - 1, result);
        } else if (arr[mid] < target) {
            return recursiveLowerBoundBinarySearch(arr, target, mid + 1, right, result);
        } else {
            result = mid;
            return recursiveLowerBoundBinarySearch(arr, target, left, mid - 1, result);
        }
    }

    return result;
}

public static int iterativeUpperBoundBinarySearch(int[] arr, int target) {
    int left = 0;
    int right = arr.length - 1;
    int result = -1;

    while (left <= right) {
        int mid = (left + right) / 2;

        if (arr[mid] <= target) {
            left = mid + 1;
        } else {
            result = mid;
            right = mid - 1;
        }
    }

    return result;
}

public static int recursiveUpperBoundBinarySearch(int[] arr, int target, int left, int right, int result) {
    if (left <= right) {
        int mid = (left + right) / 2;

        if (arr[mid] <= target) {
            return recursiveUpperBoundBinarySearch(arr, target, mid + 1, right, result);
        } else {
            result = mid;
            return recursiveUpperBoundBinarySearch(arr, target, left, mid - 1, result);
        }
    }

    return result;
}

public static void main(String[] args) {
    int[] arr = {1, 2, 4, 6, 7, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40};
    Scanner scanner = new Scanner(System.in);

    while (true) {
        System.out.println("\nBinary Search Variations:");
        System.out.println("1. Standard Binary Search (Iterative)");
        System.out.println("2. Standard Binary Search (Recursive)");
        System.out.println("3. Leftmost Binary Search (Iterative)");
        System.out.println("4. Leftmost Binary Search (Recursive)");
        System.out.println("5. Rightmost Binary Search (Iterative)");
        System.out.println("6. Rightmost Binary Search (Recursive)");
        System.out.println("7. Lower Bound Binary Search (Iterative)");
        System.out.println("8. Lower");
        System.out.println("9. Upper Bound Binary Search (Iterative)");
        System.out.println("10. Upper Bound Binary Search (Recursive)");
        System.out.println("11. Quit");
        System.out.print("\nEnter your choice: ");
        int choice = scanner.nextInt();

        if (choice != 11) {
            System.out.print("Enter the target: ");
            int target = scanner.nextInt();

            switch (choice) {
                case 1:
                    System.out.println("Result: " + iterativeBinarySearch(arr, target));
                    break;
                case 2:
                    System.out.println("Result: " + recursiveBinarySearch(arr, target, 0, arr.length - 1));
                    break;
                case 3:
                    System.out.println("Result: " + iterativeLeftmostBinarySearch(arr, target));
                    break;
                case 4:
                    System.out.println("Result: " + recursiveLeftmostBinarySearch(arr, target, 0, arr.length - 1, -1));
                    break;
                case 5:
                    System.out.println("Result: " + iterativeRightmostBinarySearch(arr, target));
                    break;
                case 6:
                    System.out.println("Result: " + recursiveRightmostBinarySearch(arr, target, 0, arr.length - 1, -1));
                    break;
                case 7:
                    System.out.println("Result: " + iterativeLowerBoundBinarySearch(arr, target));
                    break;
                case 8:
                    System.out.println("Result: " + recursiveLowerBoundBinarySearch(arr, target, 0, arr.length - 1, -1));
                    break;
                case 9:
                    System.out.println("Result: " + iterativeUpperBoundBinarySearch(arr, target));
                    break;
                case 10:
                    System.out.println("Result: " + recursiveUpperBoundBinarySearch(arr, target, 0, arr.length - 1, -1));
                    break;
                default:
                    System.out.println("Invalid choice. Please try again.");
                    break;
            }
        } else {
            break;
        }
    }

    scanner.close();
}
}
