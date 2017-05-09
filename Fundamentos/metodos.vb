Module metodos
    Sub main()
        ' PROBANDO METODOS
        holaMundo()
        escribir("Quiero escribir esto")
        imprimirMaximo(10, 16)
        escribir(calcularMaximo(20, 15))
        Dim valor As Double = 30
        Console.WriteLine("Valor:" & valor)
        pasoPorValor(valor)
        Console.WriteLine("Valor otra vez:" & valor)
        escribir(concatenar("hola", "Como te va?"))
        escribir(concatenar("hola", "Como te va?", "todo bien?"))
        Console.ReadKey()
    End Sub

    Private Function concatenar(valor1 As String, valor2 As String) As String
        Return valor1 & " " & valor2
    End Function

    Private Function concatenar(valor1 As String, valor2 As String, valor3 As String) As String
        Return valor1 & " " & valor2 & " " & valor3
    End Function

    Private Sub holaMundo()
        Console.WriteLine("Hola Mundo")
    End Sub

    Private Sub escribir(cadena As String)
        Console.WriteLine(cadena)
    End Sub

    Private Sub pasoPorValor(ByRef dato As Single)
        dato = dato + 10
        Console.WriteLine("Valor mas 10:" & dato)
    End Sub

    Private Sub imprimirMaximo(valor1 As Single, valor2 As Single)
        If valor1 > valor2 Then
            escribir(valor1)
        Else
            escribir(valor2)
        End If
    End Sub

    Private Function calcularMaximo(valor1 As Single, valor2 As Single) As Single
        If valor1 > valor2 Then
            Return valor1
        Else
            Return valor2
        End If
    End Function
End Module
