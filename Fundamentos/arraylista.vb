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
        ' ordena por valores
        frutas.Sort()
        ' invierte el orden
        frutas.Reverse()

        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
        ' obtiene el segundo elemento
        Console.WriteLine("segundo: " & frutas.Item(1))
        ' modifica el segundo elemento
        frutas(1) = "Sandia"
        frutas.Item(1) = "Morango"
        Console.WriteLine("segundo: " & frutas.Item(1))
        ' buscar un valor
        Console.WriteLine(frutas.Contains("Sandia"))
        Console.WriteLine(frutas.Contains("Morango"))
        Console.WriteLine(frutas.IndexOf("Sandia"))
        Console.WriteLine(frutas.IndexOf("Morango"))

        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next

        frutas.Clear()
        Console.WriteLine("borrado todo")
        Console.WriteLine("Cantidad elementos: " & frutas.Count)
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
    End Sub

End Module
