Module ReversePolishNotation

    Sub Main()
        Dim myExpression As New RPN
        Dim infix_exp, postfix_exp As String
        Dim more As Boolean = True

        While more
            Console.Write("Enter Infix expression : ") : infix_exp = Console.ReadLine
            postfix_exp = myExpression.InfixToPostfix(infix_exp)
            Console.WriteLine("Postfix Expression : " & postfix_exp)

            Console.Write("Again? (True/false): ") : more = Console.ReadLine
        End While
    End Sub

End Module
