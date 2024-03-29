```DECLARE infix, postfix: STRING
infix ← "2 + 3 * 4"
postfix ← InfixToPostfix(infix)
OUTPUT "Infix expression: " + infix
OUTPUT "Postfix expression: " + postfix
OUTPUT "Result: " + EvaluatePostfix(postfix)
OUTPUT ""

infix ← "2 + 3 * 4 / 5 - 6"
postfix ← InfixToPostfix(infix)
OUTPUT "Infix expression: " + infix
OUTPUT "Postfix expression: " + postfix
OUTPUT "Result: " + EvaluatePostfix(postfix)
OUTPUT ""

infix ← "2 + 3 * 4 / (5 - 6)"
postfix ← InfixToPostfix(infix)
OUTPUT "Infix expression: " + infix
OUTPUT "Postfix expression: " + postfix
OUTPUT "Result: " + EvaluatePostfix(postfix)
OUTPUT ""

infix ← "2 + 3 * 4 / (5 - 6) ^ 2"
postfix ← InfixToPostfix(infix)
OUTPUT "Infix expression: " + infix
OUTPUT "Postfix expression: " + postfix
OUTPUT "Result: " + EvaluatePostfix(postfix)
OUTPUT ""

infix ← "2 + 3 * 4 / (5 - 6) ^ 2 + 3"
postfix ← InfixToPostfix(infix)
OUTPUT "Infix expression: " + infix
OUTPUT "Postfix expression: " + postfix
OUTPUT "Result: " + EvaluatePostfix(postfix)

// WAIT FOR INPUT TO FINISH PROGRAM
INPUT ""
```
```
FUNCTION IsOperator(c: CHARACTER) RETURNS BOOLEAN
    RETURN c = "+" OR c = "-" OR c = "*" OR c = "/" OR _
	       c = "^" OR c = "(" OR c = ")"
END FUNCTION
```
```
FUNCTION Precedence(c: CHARACTER) RETURNS INTEGER
    CASE OF c
        "^": RETURN 3
        "*", "/": RETURN 2
        "+", "-": RETURN 1
        OTHERWISE: RETURN -1
    END CASE
END FUNCTION
```
```
FUNCTION InfixToPostfix(infix: STRING) RETURNS STRING
    DECLARE postfix: STRING
    DECLARE stack: STACK OF CHARACTER //You may use array instead
    DECLARE prevCHARACTERIsSpace: BOOLEAN
    DECLARE ch: CHARACTER

    prevCHARACTERIsSpace ← False

    FOR i ← 1 TO LENGTH(infix)
        ch ← infix[i]
        IF IsLetterOrDigit(ch) THEN
            IF prevCHARACTERIsSpace THEN
                postfix ← postfix + " "
            ENDIF
            postfix ← postfix + ch
            prevCHARACTERIsSpace ← False
        ELSE IF ch = "(" THEN
            PUSH ch ONTO stack
            prevCHARACTERIsSpace ← False
        ELSE IF ch = ")" THEN
            WHILE stack.COUNT > 0 AND stack.PEEK() <> "("
                postfix ← postfix + " "
                APPEND stack.POP() TO postfix
            END WHILE
            IF stack.COUNT > 0 AND stack.PEEK() = "(" THEN
                stack.POP()
            ENDIF
            prevCHARACTERIsSpace ← False
        ELSE IF ch = " " THEN
            prevCHARACTERIsSpace ← True
        ELSE
            postfix ← postfix + " "
            WHILE stack.COUNT > 0 AND Precedence(ch) <= Precedence(stack.PEEK())
                APPEND stack.POP() TO postfix
                postfix ← postfix + " "
            END WHILE
            PUSH ch ONTO stack
            prevCHARACTERIsSpace ← False
        ENDIF
    NEXT

    WHILE stack.COUNT > 0
        postfix ← postfix + " "
        postfix ← postfix + stack.POP()
    END WHILE

    RETURN postfix
END FUNCTION
```
```
FUNCTION ApplyOperator(op: CHARACTER, a: REAL, b: REAL) RETURNS REAL
    CASE OF op
        "+": RETURN a + b
        "-": RETURN a - b
        "*": RETURN a * b
        "/" 
            IF b = 0 THEN
                OUTPUT "Division by zero"
				BREAK
            ENDIF
            RETURN a / b
        "^": RETURN a ^ b
        OTHERWISE: RETURN 0
    END CASE
END FUNCTION
```
```
FUNCTION EvaluatePostfix(postfix: STRING) RETURNS REAL
    DECLARE stack: STACK OF REAL
    DECLARE token: STRING
    DECLARE tokens: LIST OF STRING //ENUMERATION
    DECLARE a: REAL
    DECLARE b: REAL
    DECLARE c: CHARACTER

    tokens ← SPLIT(postfix, " ")

    FOR i ← 1 TO tokens.COUNT
        token ← tokens[i]
        IF LENGTH(token) = 0 THEN
            CONTINUE //Goto start of the FOR loop
        ENDIF
        c ← token[1]
        IF IsDigit(c) THEN
            PUSH REAL(token) ONTO stack
        ELSE IF IsOperator(c) THEN
            b ← stack.POP()
            a ← stack.POP()
            stack.PUSH(ApplyOperator(c, a, b))
        ELSE
            OUTPUT "Invalid CHARACTERacter: " + c
			BREAK
        ENDIF
    NEXT

    RETURN stack.POP()
END FUNCTION
```
