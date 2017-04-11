Module fechas
    Enum fechaComparada
        Anterior = -1
        Igual = 0
        Posterior = 1
    End Enum

    Sub main()
        Dim d As Date
        d = #5-25-2017 15:10#
        Console.WriteLine("Dia de la patria: " & d)
        d = Date.Now
        Console.WriteLine("Ahora: " & d)
        Console.WriteLine("Dia dexl mes: " & d.Day())
        Console.WriteLine("Año: " & d.Year())
        d = New Date(2016, 3, 1)
        Console.WriteLine("fecha programada: " & d)
        d = d.AddMonths(11)
        Console.WriteLine("fecha reprogramada: " & d)
        Dim e As Date = Now
        ' crear variable del tipo de la enumeracion
        Dim comparacion As fechaComparada
        ' asignar valor con ctype correspondiente al valor de la enum
        comparacion = CType(d.CompareTo(e), fechaComparada)

        Console.WriteLine("La fecha es " & comparacion.ToString & " a ahora")
        d = d.AddYears(1)
        Console.WriteLine("fecha rereprogramada: " & d)
        comparacion = CType(d.CompareTo(e), fechaComparada)
        Console.WriteLine("La fecha es " & comparacion.ToString & " a ahora")
        Console.ReadKey()
    End Sub
End Module
