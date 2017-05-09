Module Module1
    Sub main()

        Dim fecha As Date
        Dim dias As Integer

        Console.WriteLine("Ingrese una fecha")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar")
        dias = Console.ReadLine
        Console.WriteLine("La nueva fecha es: {0}", sumarDias(fecha, dias))
        Console.ReadKey()
    End Sub

    Private Function sumarDias(fecha As Date, dias As Integer) As Date
        Return fecha.AddDays(dias)
    End Function

End Module
