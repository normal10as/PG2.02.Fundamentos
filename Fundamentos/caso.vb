Module caso
    Sub main()
        Dim valor As Short
        valor = Console.ReadLine()
        Select Case valor
            Case 1
                Console.WriteLine("Es uno")
            Case 2
                Console.WriteLine("Es dos")
            Case 3, 5
                Console.WriteLine("Es tres o cinco")
            Case 6 To 8
                Console.WriteLine("Es de seis a ocho")
            Case is < 0
                Console.WriteLine("Es negativo")
            Case Else
                Console.WriteLine("Es otro numero")
        End Select
        Console.ReadKey()
    End Sub
End Module
