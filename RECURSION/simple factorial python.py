# Simple Factorial
# iterative function
def factorial(n):
    f = 1
    for i in range (n,0,-1):
        f = f * i
    return f

# recursive function
def recursiveFactorial(n):
    if n == 0: # base care
        return 1
    else:
        return n * recursiveFactorial(n-1) # general case

def x(n): # recursive procedure outputting bin of given den
    if n == 0 or n == 1:
        print(n)
    else:
        x(n // 2)
        print(n % 2)

x(100)

"""
x = factorial(5)
print(x)

x = recursiveFactorial(5)
print(x)
"""