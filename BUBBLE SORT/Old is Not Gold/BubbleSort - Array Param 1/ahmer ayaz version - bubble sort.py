# ahmer ayaz version | bubble sort
def bubble_sort(arr):
    change=True
    temp=-1
    while change == True:
        for i in range(0,len(arr)-1):
            if arr[i]>arr[i+1]:
                temp=arr[i]
                arr[i]=arr[i+1]
                arr[i+1]=temp
                change=True
            else:
                change=False
arr=[0,4,76,32,9]
print(arr)
bubble_sort(arr)
print(arr)
arr3=[1,2,3,4,6,8,10]
print(arr3)
bubble_sort(arr3)
print(arr3)