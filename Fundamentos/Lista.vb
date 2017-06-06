Module Lista
    Sub main()
        ' declaración e instanciación
        Dim frutas As New List(Of String)
        ' carga de valores
        frutas.Add("Yaca")
        frutas.Add("Melón")
        frutas.Add("Sandía")
        ' salida en pantalla
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
        ' mostrar el indice 1
        Console.WriteLine("indice 1: " & frutas.Item(1))
        ' insertar un elemento
        frutas.Insert(1, "Kiwi")
        ' ordenar
        frutas.Sort()
        ' invierta el orden actual
        frutas.Reverse()
        ' elimino la posición 3
        frutas.RemoveAt(3)
        ' todos con un for
        Console.WriteLine("todos con un for")
        For x As Integer = 0 To frutas.Count - 1
            Console.WriteLine(frutas.Item(x))
        Next
    End Sub
End Module
