Module metodos
    Sub main()
        holaMundo()
        escribir("Quiero escribir esto")
        imprimirMaximo(10, 16)
        escribir(calcularMaximo(20, 15))
        Console.ReadKey()
    End Sub

    Private Sub holaMundo()
        Console.WriteLine("Hola Mundo")
    End Sub

    Private Sub escribir(cadena As String)
        Console.WriteLine(cadena)
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
