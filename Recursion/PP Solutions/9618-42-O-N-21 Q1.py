"""
Following pseudocode is for a recursive function.
FUNCTION Unknown(BYVAL X, BYVAL Y : INTEGER) RETURNS INTEGER
IF X < Y THEN
  OUTPUT X + Y
  RETURN (Unknown(X + 1, Y) * 2)
ELSE
  IF X = Y THEN
    RETURN 1
  ELSE
    OUTPUT X + Y
    RETURN (Unknown(X - 1, Y) DIV 2)
  ENDIF
ENDIF
ENDFUNCTION
The operator DIV returns the integer value after division e.g. 13
"""
def Unknown(x, y):
    if x < y:
        print(x + y)
        return (Unknown(x + 1, y) * 2)
    else:
        if x == y:
            return 1
        else:
            print(x + y)
            return (Unknown(x - 1, y) // 2)
        
"""
Test the function Unknown() with the following pseudocode statement:
Unknown(10, 15)
Unknown(10, 10)
Unknown(15, 10)
"""
print(Unknown(10, 15))
print(Unknown(10, 10))
print(Unknown(15, 10))
