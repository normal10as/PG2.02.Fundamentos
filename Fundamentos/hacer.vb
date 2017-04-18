Module hacer
    Sub main()
        Dim x As Short
        x = 1
        Do While x <= 5
            Console.WriteLine(x)
            x = x + 1
        Loop
        x = 1
        Do Until x > 5
            Console.WriteLine(x)
            x = x + 1
        Loop
        x = 1
        Do
            Console.WriteLine(x)
            x = x + 1
        Loop While x <= 5
        x = 1
        Do
            Console.WriteLine(x)
            x = x + 1
        Loop Until x > 5

        For y As Byte = 1 To 5
            Console.WriteLine(y)
        Next
        For y As Byte = 3 To 30 Step 3
            Console.WriteLine(y)
        Next
        Console.ReadKey()

        Do
            Console.WriteLine("ingresar un valor entre 1 y 10")
            x = Console.ReadLine()
        Loop Until x >= 1 And x <= 10
    End Sub
End Module
