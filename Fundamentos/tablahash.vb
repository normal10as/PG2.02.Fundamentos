Module tablahash
    Sub main()
        Dim tablita As New Hashtable
        tablita.Add("R", "Rojo")
        tablita.Add("V", "Verde")
        tablita.Add("A", "Azul")
        For Each elemento As DictionaryEntry In tablita
            Console.WriteLine(elemento.Key & " " & elemento.Value)
        Next
        'tablita.Contains
    End Sub
End Module
