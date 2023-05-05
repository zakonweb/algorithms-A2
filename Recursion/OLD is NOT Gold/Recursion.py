def Fact1(x):
    a = 1
    for count in range(x, 1, -1):
        a = a * count
    return a


def RecursiveFact(x):
    if x == 1:
        return 1
    else:
        return x * RecursiveFact(x - 1)


n = int(input("Enter number to find factorial for: "))

myAns = Fact1(n)
print("The Factorial of",n,"is :",myAns)

myAns = RecursiveFact(n)
print("The Factorial of",n,"is :",myAns)
