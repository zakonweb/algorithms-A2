# Bubble Sort
`Bubble Sort` is a simple and intuitive sorting algorithm that repeatedly swaps adjacent elements if they are in the wrong order until the entire array is sorted. There are several variations of Bubble Sort, some of which are:

## Standard Bubble Sort
This is the simplest version of Bubble Sort. It compares adjacent elements and swaps them if they are in the wrong order until the entire array is sorted. It has a time complexity of `O(n^2)` in the worst case.

## Modified Bubble Sort
In this version of Bubble Sort, the algorithm stops if no swap occurs during a pass through the array. This means that the algorithm terminates early if the array is already sorted. This improves the time complexity in the best case to `O(n)`.

## Recursive Bubble Sort
This version of Bubble Sort uses recursion to sort the array. It compares adjacent elements and swaps them if they are in the wrong order, and then recursively calls the function to sort the remaining elements. This version has a time complexity of `O(n^2)` in the worst case.

## Cocktail Shaker Sort
This is a variation of Bubble Sort that sorts the array in both directions, first from left to right and then from right to left. This helps to eliminate "turtles" (small values near the end of the array) and "rabbits" (large values near the beginning of the array) quickly. This version has a time complexity of `O(n^2)` in the worst case.

## Comb Sort
This is another variation of Bubble Sort that improves the efficiency of the algorithm by using a larger gap than 1 between the elements being compared and swapped. The gap is initialized to the length of the array and is divided by a shrink factor (typically 1.3) after each pass through the array. This version has a time complexity of O(n^2) in the worst case, but it is generally faster than the standard Bubble Sort.
