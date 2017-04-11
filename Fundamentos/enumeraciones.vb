Module enumeraciones
    Enum ColoresPrimarios
        Red = 5
        Green = 18
        Blue = 67
    End Enum

    Sub main()
        Console.WriteLine("Ingrese un color (5, 18, 67)")
        Dim color As UShort
        color = Console.ReadLine()
        'color -= 1
        If color = ColoresPrimarios.Blue Then
            Console.WriteLine("Azul")
        End If
        If color = ColoresPrimarios.Green Then
            Console.WriteLine("Verde")
        End If
        If color = ColoresPrimarios.Red Then
            Console.WriteLine("Rojo")
        End If
        Console.ReadKey()
    End Sub

End Module
