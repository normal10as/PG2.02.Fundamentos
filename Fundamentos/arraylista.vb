Module arraylista

    Sub main()
        ' crea la coleccion
        Dim frutas As ArrayList
        ' inicializa la colección
        frutas = New ArrayList
        ' agregar elementos
        frutas.Add("Manzanas")
        frutas.Add("Peras")
        frutas.Add("Frutillas")
        frutas.Add("Tomate")
        Console.WriteLine("CAntidad: " & frutas.Count)
        ' iterar
        frutas.RemoveAt(3)
        frutas.Remove("Peras")
        frutas.Insert(0, "Mandarina")
        frutas.Insert(2, "Naranja")
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
        frutas.Sort()
        frutas.Reverse()

        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next

        Console.WriteLine("segundo: " & frutas.Item(1))
        frutas.Clear()
        Console.WriteLine("borrado todo")
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
    End Sub

End Module
