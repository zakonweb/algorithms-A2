"""
Python code for infix to postfix conversion.
System will take input from user and convert it into postfix expression.
a separate function will be used to evaluate the postfix expression.
a separate function will be used to convert the infix expression into postfix expression.
a separate function will be used to check the precedence of the operators.
a separate function will be used to check whether the input is operator or operand.
a separate function will be used to check whether the infix expression input is valid or not.
a main menu will be used to display the options to the user.
"""

# function to check whether the input is operator or operand
def isOperator(c):
    if c == '+' or c == '-' or c == '*' or c == '/' or c == '^' or c == '(' or c == ')':
        return True
    else:
        return False

# function to check the precedence of the operators
# higher the value, higher the precedence
def precedence(c):
    if c == '^':
        return 3
    elif c == '*' or c == '/':
        return 2
    elif c == '+' or c == '-':
        return 1
    else:
        return -1

# function to validate the infix expression
def validateInfix(infix):
    count = 0
    for i in infix:
        if i == '(':
            count += 1
        elif i == ')':
            count -= 1

    if count != 0:
        return False

    # checking for invalid operators in starting and ending of the expression
    if isOperator(infix[0]) or isOperator(infix[len(infix) - 1]):
        return False


    for i in infix:
        if not isOperator(i) and not i.isalnum() and i != ' ':
            return False

    return True

# function to convert infix expression to postfix expression
def infix_to_postfix(infix_expr):
    def is_operator(c):
        return c in ['+', '-', '*', '/', '^']

    def is_operand(c):
        return c.isalnum()

    def higher_precedence(op1, op2):
        return precedence(op1) > precedence(op2)

    postfix_expr = []
    stack = []

    for char in infix_expr:
        if is_operand(char):
            postfix_expr.append(char)
        elif is_operator(char):
            while (stack and stack[-1] != '(' and
                   higher_precedence(stack[-1], char)):
                postfix_expr.append(stack.pop())
            stack.append(char)
        elif char == '(':
            stack.append(char)
        elif char == ')':
            while stack and stack[-1] != '(':
                postfix_expr.append(stack.pop())
            if stack[-1] == '(':
                stack.pop()

    while stack:
        postfix_expr.append(stack.pop())

    return " ".join(postfix_expr)

# function to evaluate the postfix expression
# evaluate means to calculate the value of the expression
def evaluatePostfix(postfix_expr):
    def is_operator(c):
        return c in ['+', '-', '*', '/', '^']

    def apply_operator(op, a, b):
        if op == '+':
            return a + b
        elif op == '-':
            return a - b
        elif op == '*':
            return a * b
        elif op == '/':
            if b == 0:
                raise ZeroDivisionError("Division by zero")
            return a / b
        elif op == '^':
            return a ** b

    stack = []

    tokens = postfix_expr.split()
    for token in tokens:
        if token.isdigit():
            stack.append(float(token))
        elif is_operator(token):
            if len(stack) < 2:
                raise ValueError("Invalid postfix expression")
            b = stack.pop()
            a = stack.pop()
            result = apply_operator(token, a, b)
            stack.append(result)
        else:
            raise ValueError("Invalid character in postfix expression")

    if len(stack) != 1:
        raise ValueError("Invalid postfix expression")

    return stack[0]

# main menu
"""choice = 0
while choice != 3:
    print("1. Enter infix expression")
    print("2. Exit")
    choice = int(input("Enter your choice: "))
    if choice == 1:
        infix = input("Enter infix expression: ")
        postfix = infix_to_postfix(infix)
        print("Postfix expression: ", postfix)
        print("Result: ", evaluatePostfix(postfix))
    elif choice == 2:
        break
    else:
        print("Invalid choice")
    print()
"""


# example data for testing.
# p.s. - please recheck the results manually.
# 1. 2 + 3 * 4. Result should be 14
# 2. 2 + 3 * 4 / 5 - 6. Result should be -1.6
# 3. 2 + 3 * 4 / (5 - 6). Result should be -10
# 4. 2 + 3 * 4 / (5 - 6) ^ 2. Result should be 14
# 5. 2 + 3 * 4 / (5 - 6) ^ 2 + 3. Result should be 17

#code to evaluate all the above examples
infix = "2 + 3 * 4"
postfix = infix_to_postfix(infix)
print("Postfix expression: ", postfix)
print("Result: ", evaluatePostfix(postfix))
print()

infix = "2 + 3 * 4 / 5 - 6"
postfix = infix_to_postfix(infix)
print("Postfix expression: ", postfix)
print("Result: ", evaluatePostfix(postfix))
print()

infix = "2 + 3 * 4 / (5 - 6)"
postfix = infix_to_postfix(infix)
print("Postfix expression: ", postfix)
print("Result: ", evaluatePostfix(postfix))
print()

infix = "2 + 3 * 4 / (5 - 6) ^ 2"
postfix = infix_to_postfix(infix)
print("Postfix expression: ", postfix)
print("Result: ", evaluatePostfix(postfix))
print()

infix = "2 + 3 * 4 / (5 - 6) ^ 2 + 3"
postfix = infix_to_postfix(infix)
print("Postfix expression: ", postfix)
print("Result: ", evaluatePostfix(postfix))

# end of code