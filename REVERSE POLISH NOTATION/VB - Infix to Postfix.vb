Imports System.Text
Imports System.Text.RegularExpressions

Module InfixToPostfix
    Public Function IsOperator(c As Char) As Boolean
        Return c = "+"c OrElse c = "-"c OrElse c = "*"c _
            OrElse c = "/"c OrElse c = "^"c OrElse c = "("c OrElse c = ")"c
    End Function

    Public Function Precedence(c As Char) As Integer
        Select Case c
            Case "^"c
                Return 3
            Case "*"c, "/"c
                Return 2
            Case "+"c, "-"c
                Return 1
            Case Else
                Return -1
        End Select
    End Function
    Function InfixToPostfix(ByVal infix As String) As String
        Dim postfix As New StringBuilder()
        Dim stack As New Stack(Of Char)()

        Dim prevCharIsSpace As Boolean = False

        For Each ch As Char In infix
            If Char.IsLetterOrDigit(ch) Then
                If prevCharIsSpace Then
                    postfix.Append(" "c)
                End If
                postfix.Append(ch)
                prevCharIsSpace = False
            ElseIf ch = "("c Then
                stack.Push(ch)
                prevCharIsSpace = False
            ElseIf ch = ")"c Then
                While stack.Count > 0 AndAlso stack.Peek() <> "("c
                    postfix.Append(" "c)
                    postfix.Append(stack.Pop())
                End While
                If stack.Count > 0 AndAlso stack.Peek() = "("c Then
                    stack.Pop()
                End If
                prevCharIsSpace = False
            ElseIf ch = " "c Then
                prevCharIsSpace = True
            Else
                postfix.Append(" "c)
                While stack.Count > 0 AndAlso Precedence(ch) <= Precedence(stack.Peek())
                    postfix.Append(stack.Pop())
                    postfix.Append(" "c)
                End While
                stack.Push(ch)
                prevCharIsSpace = False
            End If
        Next

        While stack.Count > 0
            postfix.Append(" "c)
            postfix.Append(stack.Pop())
        End While

        Return postfix.ToString()
    End Function


    Public Function ApplyOperator(op As Char, a As Double, b As Double) As Double
        Select Case op
            Case "+"c
                Return a + b
            Case "-"c
                Return a - b
            Case "*"c
                Return a * b
            Case "/"c
                If b = 0 Then
                    Throw New DivideByZeroException("Division by zero")
                End If
                Return a / b
            Case "^"c
                Return Math.Pow(a, b)
            Case Else
                Return 0
        End Select
    End Function

    Public Function EvaluatePostfix(postfix As String) As Double
        Dim stack As New Stack(Of Double)()
        For Each token As String In Regex.Split(postfix, "\s+")
            If token.Length = 0 Then
                Continue For
            End If
            Dim c As Char = token(0)
            If Char.IsDigit(c) Then
                stack.Push(Double.Parse(token))
            ElseIf IsOperator(c) Then
                Dim b As Double = stack.Pop()
                Dim a As Double = stack.Pop()
                stack.Push(ApplyOperator(c, a, b))
            Else
                Throw New Exception("Invalid character: " & c)
            End If
        Next
        Return stack.Pop()
    End Function

    Sub Main()
        Dim infix As String = "2 + 3 * 4"
        Dim postfix As String = InfixToPostfix(infix)
        Console.WriteLine("Infix expression: " & infix)
        Console.WriteLine("Postfix expression: " & postfix)
        Console.WriteLine("Result: " & EvaluatePostfix(postfix))
        Console.WriteLine()

        infix = "2 + 3 * 4 / 5 - 6"
        postfix = InfixToPostfix(infix)
        Console.WriteLine("Infix expression: " & infix)
        Console.WriteLine("Postfix expression: " & postfix)
        Console.WriteLine("Result: " & EvaluatePostfix(postfix))
        Console.WriteLine()

        infix = "2 + 3 * 4 / (5 - 6)"
        postfix = InfixToPostfix(infix)
        Console.WriteLine("Infix expression: " & infix)
        Console.WriteLine("Postfix expression: " & postfix)
        Console.WriteLine("Result: " & EvaluatePostfix(postfix))
        Console.WriteLine()

        infix = "2 + 3 * 4 / (5 - 6) ^ 2"
        postfix = InfixToPostfix(infix)
        Console.WriteLine("Infix expression: " & infix)
        Console.WriteLine("Postfix expression: " & postfix)
        Console.WriteLine("Result: " & EvaluatePostfix(postfix))
        Console.WriteLine()

        infix = "2 + 3 * 4 / (5 - 6) ^ 2 + 3"
        postfix = InfixToPostfix(infix)
        Console.WriteLine("Infix expression: " & infix)
        Console.WriteLine("Postfix expression: " & postfix)
        Console.WriteLine("Result: " & EvaluatePostfix(postfix))

        Console.ReadLine()
    End Sub

End Module