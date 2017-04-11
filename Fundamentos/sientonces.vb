Module sientonces
    Sub main()
        Dim a As Short
        Console.WriteLine("Ingrese un valor")
        a = Console.ReadLine
        If a < 0 Then
            Console.WriteLine("Es negativo")
        ElseIf a > 0 Then
            Console.WriteLine("Es positivo")
        Else
            Console.WriteLine("Es cero")
        End If
        Console.ReadKey()

    End Sub
End Module
