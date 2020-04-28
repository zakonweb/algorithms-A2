Module Module1

    Sub Main()
        Dim n, myAns As Int64

        Console.Write("Enter number to find factorial for : ")
        n = Console.ReadLine

        myAns = Fact1(n)
        Console.WriteLine("The Factorial of " & n & " is : " & myAns)
        Console.ReadKey()

        myAns = RecursiveFact(n)
        Console.WriteLine("The Factorial of " & n & " is : " & myAns)
        Console.ReadKey()
    End Sub

    Function Fact1(ByVal x As Int64) As Int64
        Dim count, a As Int64
        a = 1
        For count = x To 1 Step -1
            a = a * count
        Next

        Return a
    End Function

    Function RecursiveFact(ByVal x As Int64) As Int64
        If x = 1 Then
            Return 1
        Else
            Return x * RecursiveFact(x - 1)
        End If
    End Function
End Module
