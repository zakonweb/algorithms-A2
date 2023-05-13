## Binary search

`Binary search` is a search algorithm that is used to efficiently locate a target value within a sorted array. The algorithm works by repeatedly dividing the search interval in half, comparing the middle element of the interval to the target value, and narrowing down the search space until the target is found or the interval becomes empty.

Here's an algorithm to implement binary search:

1. Initialize two pointers, `left` and `right`, to the first and last indices of the array.
2. While the `left` pointer is less than or equal to the `right` pointer: 
	1. Calculate the middle index `mid` as the average of `left` and `right` (integer division). 
	2. Compare the middle element of the array at index `mid` with the target value:
		- If the middle element is equal to the target, return `mid` (the target is found).
		- If the middle element is less than the target, update the `left` pointer to `mid + 1` (search the right half).
		- If the middle element is greater than the target, update the `right` pointer to `mid - 1` (search the left half).
3. If the target is not found, return `-1`.

Binary search is an efficient search algorithm that can be used to locate a target value within a sorted array. However, there are certain conditions that must be met for binary search to be effective:

1. The array must be sorted in ascending or descending order.
2. The search is typically performed on an array or list data structure.
3. The elements of the array must be comparable using the `<` and `>` operators.

The performance of binary search can vary depending on the number of data items being searched. As the number of data items increases, the time taken to perform a binary search generally increases logarithmically. This means that the time taken to search 100 items is roughly double the time taken to search 10 items, and the time taken to search 1000 items is roughly double the time taken to search 100 items. Binary search is therefore a very efficient search algorithm for large datasets, as the search time grows very slowly compared to the size of the dataset.
