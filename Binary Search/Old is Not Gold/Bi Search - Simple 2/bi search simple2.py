list = []
found = False
searchFailed = False
first = 0
last = 6

for i in range(6):
    x = int(input("Enter value: "))
    list.append(x)

searchItem = int(input("Enter search Item: "))

while not found and not searchFailed:
    middle = (first+last)//2
    if list[middle] == searchItem:
        found = True
    else:
        if first >= last:
            searchFailed = True
        else:
            if list[middle]> searchItem:
                last = middle-1
            else:
                first = middle+1

if found == True:
    print("value found at:",middle)
else:
    print("not found")
