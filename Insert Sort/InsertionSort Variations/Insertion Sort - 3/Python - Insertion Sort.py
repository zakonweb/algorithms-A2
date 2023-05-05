"""
insertion sort code.
insertion sort is a simple sorting algorithm that builds the final sorted array (or list) one item at a time.
we will write a function that takes in an array of integers and returns a sorted version of that array.
"""

def insertion_sort(array):
    """
    insertion sort function.
    """
    for i in range(1, len(array)):
        j = i
        while j > 0 and array[j] < array[j-1]:
            array[j-1], array[j] = array[j], array[j-1]
            j -= 1
    return array

# there might be different variuations of the insertion sort algorithm.
# the one above is the one that I am familiar with as per the syllabus
# of the course that I am taking.

# the one below is the one that I found on the internet.
# it is a bit different from the one above.
def insertion_sort2(array):
    """
    insertion sort function.
    """
    for i in range(1, len(array)):
        j = i - 1
        while array[j] > array[j+1] and j >= 0:
            array[j], array[j+1] = array[j+1], array[j]
            j -= 1
    return array

# anothe rone is the one below.
def insertion_sort3(thisArray):
    for x in range(1,len(thisArray)):
        for k in range(0,x):
            if thisArray[x] < thisArray[k]:
                temp = thisArray[x]
                for m in range(x,k,-1):
                    thisArray[m] = thisArray[m-1]
                thisArray[k] = temp
    return thisArray

# main program to test the function.
myArr =  [3, 1, 4, 2]
print("Original list", myArr)
print("Sorted list using insertion sort 1: ", insertion_sort(myArr))
print("Sorted list using insertion sort 2: ", insertion_sort2(myArr))
print("Sorted list using insertion sort 3: ", insertion_sort3(myArr))
