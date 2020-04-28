thisArray=[10,8,7,2,23,6]
for x in range(1,6):
    for k in range(0,x):
        if thisArray[x] < thisArray[k]:
            temp = thisArray[x]
            for m in range(x,k,-1):
                thisArray[m] = thisArray[m-1]
            thisArray[k] = temp
            break
for count in thisArray:
    print(count)
