# Insertion Sort Algorithm Explanation

1. The user is prompted to enter the number of elements in the array they wish to sort. The number is read and stored in the variable `numElements`.

2. An array named `thisArr` with a size equal to `numElements` is created. This array will hold the values that will be sorted using the Insertion Sort algorithm.

3. A FOR loop is used to iterate through each position in the array `thisArr`. For each position, the user is prompted to enter a value, which is then read and stored in the corresponding position of the array.

4. The `INSERTIONSORT` function is called with the `thisArr` array and the `numElements` as arguments. This function will perform the Insertion Sort algorithm on the given array.

5. The `INSERTIONSORT` function begins by iterating through the array, starting from the second element (at index 1) up to the last element. This is done using a FOR loop with the variable `x`.

6. For each element at index `x`, another FOR loop is used to iterate through all previous elements (from index 0 to `x` - 1) with the variable `y`.

7. Inside the inner FOR loop, the element at index `x` is compared with the element at index `y`. If the element at index `x` is smaller than the element at index `y`, a swap is needed to maintain the sorted order.

8. A temporary variable `temp` is used to store the value of the element at index `x`. Then, a FOR loop is used to shift all the elements between indices `x` and `y` (inclusive of `x` and exclusive of `y`) one position to the right.

9. After shifting the elements, the value stored in the temporary variable `temp` is inserted at the index `y`. This maintains the sorted order of the elements up to index `x`.

10. The BREAK keyword is used to exit the inner FOR loop (the one with the variable `y`) since the correct position for the current element has been found, and there is no need to compare it with the remaining elements.

11. Once the `INSERTIONSORT` function has processed all elements in the array, the sorted array is returned to the main part of the pseudocode.

12. Finally, a FOR loop is used to iterate through the sorted array `thisArr` and print out each element in the sorted order.

In summary, the provided pseudocode demonstrates how the Insertion Sort algorithm works by comparing and swapping elements within an array to maintain the sorted order. The Insertion Sort algorithm has a time complexity of O(n^2) in the worst and average cases, making it inefficient for large datasets. However, it is simple to implement and performs well for small or partially sorted arrays.
