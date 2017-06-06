Module pila
    Sub main()
        Dim pila As New Stack
        ' agrega elementos
        pila.Push(1)
        pila.Push(2)
        pila.Push(3)

        mostrarTodos(pila)
        ' quita uno
        Console.WriteLine("Extraigo:" & pila.Pop())
        ' agrega otro
        pila.Push(4)
        Console.WriteLine("proximo:" & pila.Peek())
        mostrarTodos(pila)
        ' informa cantidad (si es igual a cero la pila esta vacia)
        Console.WriteLine("Cantidad: " & pila.Count)
    End Sub

    Private Sub mostrarTodos(pila As Stack)
        For Each elemento In pila
            Console.WriteLine(elemento)
        Next
    End Sub
End Module
