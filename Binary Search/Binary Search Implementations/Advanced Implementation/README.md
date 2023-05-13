# Variations of Binary Search Algorithms

This program implements various variations of binary search algorithms for a sorted array. The following functions are defined:

## Standard Binary Search
### `iterative_binary_search(arr, target)`
An iterative implementation of the standard binary search algorithm that returns the index of the target element in the array, or -1 if it is not present.

### `recursive_binary_search(arr, target, left, right)`
A recursive implementation of the standard binary search algorithm that takes the left and right indices of the search range as additional arguments.

## Leftmost Binary Search
### `iterative_leftmost_binary_search(arr, target)`
An iterative implementation of the leftmost binary search algorithm that returns the index of the leftmost occurrence of the target element in the array, or -1 if it is not present.

### `recursive_leftmost_binary_search(arr, target, left, right, result=-1)`
A recursive implementation of the leftmost binary search algorithm that takes the left and right indices of the search range as additional arguments, and also maintains a result variable that stores the current leftmost index found so far.

## Rightmost Binary Search
### `iterative_rightmost_binary_search(arr, target)`
An iterative implementation of the rightmost binary search algorithm that returns the index of the rightmost occurrence of the target element in the array, or -1 if it is not present.

### `recursive_rightmost_binary_search(arr, target, left, right, result=-1)`
A recursive implementation of the rightmost binary search algorithm that takes the left and right indices of the search range as additional arguments, and also maintains a result variable that stores the current rightmost index found so far.

## Lower Bound Binary Search
### `iterative_lower_bound_binary_search(arr, target)`
An iterative implementation of the lower bound binary search algorithm that returns the index of the first element in the array that is greater than or equal to the target element.

### `recursive_lower_bound_binary_search(arr, target, left, right, result=-1)`
A recursive implementation of the lower bound binary search algorithm that takes the left and right indices of the search range as additional arguments, and also maintains a result variable that stores the current lower bound index found so far.

## Upper Bound Binary Search
### `iterative_upper_bound_binary_search(arr, target)`
An iterative implementation of the upper bound binary search algorithm that returns the index of the first element in the array that is greater than the target element.

### `recursive_upper_bound_binary_search(arr, target, left, right, result=-1)`
A recursive implementation of the upper bound binary search algorithm that takes the left and right indices of the search range as additional arguments, and also maintains a result variable that stores the current upper bound index found so far.

## User Interface and Demonstration

The `main()` function provides a simple command-line interface for the user to choose which binary search variation to run and specify the target element. It uses a sample sorted array of integers for demonstration purposes.

## Conclusion

Overall, this program is useful for understanding and experimenting with different variations of binary search algorithms, and can be adapted for use in other applications that require efficient searching of sorted arrays.