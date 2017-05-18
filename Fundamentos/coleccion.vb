Module coleccion
    Sub main()
        ' crea la coleccion
        Dim frutas As Collection
        ' inicializa la colección
        frutas = New Collection
        ' agregar elementos
        frutas.Add("Manzanas")
        frutas.Add("Peras")
        frutas.Add("Frutillas")
        ' iterar
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
    End Sub
End Module
