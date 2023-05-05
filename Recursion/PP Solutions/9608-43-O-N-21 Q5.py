"""
The recursive algorithm for the Recursion() function is defined in pseudocode as follows:

FUNCTION Recursion(A, B : INTEGER) RETURNS INTEGER
  IF A <= 100 THEN
    RETURN 1
  ELSE
    IF A > B THEN
      RETURN 5 + Recursion(A - 1, B)
    ELSE
       RETURN 10 + Recursion(A – 10, B)
    ENDIF
  ENDIF
ENDFUNCTION
(a) The function is called with the following pseudocode statement:
OUTPUT Recursion(104, 102)
"""
def Recursion(A, B):
    if A <= 100:
        return 1
    else:
        if A > B:
            return 5 + Recursion(A - 1, B)
        else:
            return 10 + Recursion(A - 10, B)

# write the function Recursion() in pseudocode, using an iterative algorithm.
def iterativeDef(A, B):
    c = 0
    while A > 100:
        if A > B:
            A = A - 1
            c = c + 5
        else:
            A = A - 10
            c = c + 10
    if A <= 100:
        c = c + 1
    return c

# test the iterative and recursive function
print(iterativeDef(104, 102))

