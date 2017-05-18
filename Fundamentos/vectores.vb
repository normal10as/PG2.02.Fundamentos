Module vectores
    Sub main()
        'Dim valores(5) As Integer
        'valores(0) = 6
        'Console.WriteLine(valores(0))

        Dim numeros = New UShort() {1, 2, 3, 4}
        For Each numero As UShort In numeros
            Console.WriteLine(numero)
        Next
        Console.WriteLine("")
        ' modificar valor
        For x = 0 To numeros.Length - 1
            numeros(x) = numeros(x) * 2
            Console.WriteLine(numeros(x))
        Next

        Dim matrix = New UShort(4, 1) {{1, 2}, {3, 4}, {5, 6}, {7, 8}, {9, 10}}
        For Each numero As UShort In matrix
            Console.WriteLine(numero)
        Next

        Console.WriteLine("")
        ' modificar valor
        For fila = 0 To matrix.GetLength(0) - 1
            For columna = 0 To matrix.GetLength(1) - 1
                matrix(fila, columna) = matrix(fila, columna) * 2
                Console.WriteLine(matrix(fila, columna))
            Next
        Next

        For fila = 0 To matrix.Rank - 1
            For columna = 0 To matrix.GetLength(fila) - 1
                'matrix(fila, columna) = matrix(fila, columna) * 2
                Console.WriteLine(matrix(fila, columna))
            Next
        Next
    End Sub
End Module
