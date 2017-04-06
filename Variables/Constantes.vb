Module Constantes

    Const iva As Single = 21

    Sub main()
        Dim d As Single = 500
        Console.WriteLine("Compra: $" & d)
        Console.WriteLine("Iva: %" & iva)
        Console.WriteLine("Total: $" & d + d * iva / 100)
        Console.ReadKey()
    End Sub
End Module
