Module Variables
    ' zona de declaración private, friend y public
    Private ahora As Date
    Friend ayer As Date
    Public car As Char

    Sub Main()
        ' declaración
        Dim bite As Byte
        ' asignación
        bite = 100
        Console.WriteLine("Byte = " & bite)
        ' operación
        bite = bite - 100
        ' salida
        Console.WriteLine("Byte -= 100 = " & bite)

        ' conversión implícita de double a single: se realiza redondeo
        Dim simple As Single = Math.PI
        Dim doble As Double = Math.PI
        Console.WriteLine("simple: " & simple)
        Console.WriteLine("doble: " & doble)

        ' conversión implícita de double a decimal
        Dim deci As Decimal = Math.PI
        Console.WriteLine("decimal: " & deci)

        ' desplazamiento del punto flotante
        simple = simple * 4
        Console.WriteLine("simple * 4: " & simple)
        deci = deci * 4
        Console.WriteLine("decimal * 4: " & deci)
        ' fecha
        ahora = Date.Now
        Console.WriteLine("Ahora es: " & ahora)
        ayer = #4/2/2017 21:47#
        Console.WriteLine(ayer)

        ' char
        car = "e"
        Console.WriteLine("Char: " & car)
        car = Convert.ToChar(101)
        Console.WriteLine("ToChar(101): " & car)

        Console.ReadKey()
    End Sub

End Module
