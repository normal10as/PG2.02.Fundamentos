
Module Matematica
    Sub main()
        Dim a As Single = -6
        Console.WriteLine("Signo: " & Math.Sign(a))

        a = Math.Abs(a)
        Console.WriteLine("Valor absoluto: " & a)

        Console.WriteLine("{0} Elevado a la 10: " & Math.Pow(a, 10), a)

        Console.WriteLine("Raiz cuadrada de {0}: " & Math.Sqrt(a), a)
        Console.ReadKey()
    End Sub
End Module
