Module ListaOrdenada
    Sub main()
        Dim programaAsociado As New SortedList(Of String, String)

        ' Add some elements to the list. There are no 
        ' duplicate keys, but some of the values are duplicates.
        programaAsociado.Add("txt", "notepad.exe")
        programaAsociado.Add("bmp", "paint.exe")
        programaAsociado.Add("dib", "paint.exe")
        programaAsociado.Add("rtf", "wordpad.exe")
        programaAsociado.Add("exe", "explorer.exe")

        Console.WriteLine("For key = ""rtf"", value = {0}.", programaAsociado("rtf"))
        programaAsociado("rtf") = "winword.exe"
        Console.WriteLine("For key = ""rtf"", value = {0}.", programaAsociado("rtf"))
        programaAsociado.Remove("exe")
        Console.WriteLine("Lista completa")
        For Each kvp As KeyValuePair(Of String, String) In programaAsociado
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value)
        Next
    End Sub
End Module
