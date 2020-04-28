Module Module1

    Sub Main()

        Try
            FileOpen(1, "c:\filePractice\qwer456789.txt", OpenMode.Input)
            FileClose(1)
        Catch ex As Exception
            Console.WriteLine("Error - " & ex.Message)
        Finally
            Console.WriteLine("operation completed")
            Console.ReadKey()
        End Try
    End Sub

End Module
