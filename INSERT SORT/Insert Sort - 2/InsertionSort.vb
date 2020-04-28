Module Module1

    Sub Main()
        Dim Pointer, NumberOfItems, ItemToBeInserted, CurrentItem As Integer
        Dim List(6) As Integer

        NumberOfItems = 6
        List(1) = 53
        List(2) = 21
        List(3) = 60
        List(4) = 18
        List(5) = 42
        List(6) = 19

        For Pointer = 1 To NumberOfItems
            Console.Write(List(Pointer) & " ")
        Next

        Console.WriteLine()
        For Pointer = 2 To NumberOfItems
            ItemToBeInserted = List(Pointer)
            CurrentItem = Pointer - 1

            While (List(CurrentItem) > ItemToBeInserted) And (CurrentItem > 0)
                List(CurrentItem + 1) = List(CurrentItem)
                CurrentItem = CurrentItem - 1
            End While
            List(CurrentItem + 1) = ItemToBeInserted
        Next

        For Pointer = 1 To NumberOfItems
            Console.Write(List(Pointer) & " ")
        Next

        Console.ReadLine()
    End Sub

End Module
