Public Class RPN
    Const topOfStack = 100
    Const nullPtr = -1

    Private stack(99) As Char
    Private top As Integer = nullPtr

    Public Sub push(ByVal item As Char)
        If top >= topOfStack-1 Then
            Console.WriteLine("Stack Overflow.")
        Else
            top = top + 1
            stack(top) = item
        End If
    End Sub

    Public Function pop() As Char
        Dim item As Char
        If top = nullPtr Then
            Console.WriteLine("Stack under flow: Invalid infix expression")
            'underflow may occur for invalid expression 
            'where ( and ) are not matched
            Return ""
        Else
            item = stack(top)
            top = top - 1
            Return item
        End If
    End Function

    'Function that is used to determine whether any symbol is operator or not
    'this fucntion returns TRUE if symbol is opreator else return FALSE 

    Public Function isOperator(ByVal symbol As Char) As Boolean
        Select Case symbol
            Case "^", "*", "/", "+", "-" : Return True
            Case Else : Return False
        End Select
    End Function

    'Fucntion that is used to assign precendence to operator
    'Here ^ denotes exponent operator
    'We assume that higher integer value
    'means higher precendence 
    Public Function precedence(ByVal symbol As Char) As Integer
        Select Case symbol
            Case "^" : Return 3
            Case "*", "/" : Return 2
            Case "+", "-" : Return 1
            Case Else : Return 0
        End Select
    End Function

    Public Function InfixToPostfix(ByVal infix_exp As String) As String

        Dim i As Integer
        Dim x, item As Char
        Dim postfix_exp As String = ""

        push("(") ' push "(" onto stack 
        infix_exp = infix_exp & ")" ' add ")" to infix expression end

        i = 1
        item = Left(infix_exp, 1)         ' initialize before loop

        While i <= Len(infix_exp)         ' run loop till end of infix expression 
            If (item = "(") Then
                push(item)
            ElseIf (InStr("ABCDEFGHIJKLMNOPQRSTUVWXYZ", UCase(item)) > 0 Or InStr("0123456789", item) > 0) Then
                ' add operand symbol to postfix expr 
                postfix_exp = postfix_exp & item
            ElseIf isOperator(item) Then   ' means symbol is operator 
                x = pop()
                While (isOperator(x) = True And precedence(x) >= precedence(item))
                    ' so pop all higher precendence operator and 
                    postfix_exp = postfix_exp & x
                    ' add them to postfix expresion 
                    x = pop()
                End While
                push(x)
                'Because just above while loop will terminate we have
                'popped one extra item
                'for which condition fails and loop terminates, so that one

                ' push current oprerator symbol onto stack 
                push(item)
            ElseIf (item = ")") Then         ' if current symbol is ")" then 
                x = pop()                   ' pop and keep popping until 
                While (x <> "(")                ' "(" encounterd 
                    postfix_exp = postfix_exp & x
                    x = pop()
                End While
            Else
                ' if current symbol is neither operand not "(" nor ")" and nor operator 
                ' the it is illegeal  symbol 
                Console.WriteLine("Invalid infix Expression.")
                Return ""
                Exit Function
            End If
            i = i + 1
            item = Mid(infix_exp, i, 1) ' go to next symbol of infix expression 
        End While ' while loop ends here 

        If (top > nullPtr) Then
            Console.WriteLine("Invalid infix Expression.")        ' the it is illegeal  symbol 
            Return ""
            Exit Function
        End If

        Return postfix_exp
    End Function
End Class
