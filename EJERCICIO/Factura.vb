Public Class Factura

    Public Producto As Integer

    Public Sub ImpFactura()

        Dim Prod As Integer

        ' id de la factura
        Dim idFactura As Double
        For idFactura = 0 To 0 Step 3
            Console.Write("Id de factura" & " ")
        Next
        Console.WriteLine("")

        Do
            Console.WriteLine(" Escriba el número de productos a comprar")
            Producto = Console.ReadLine


            If Producto = 1 Then
                Console.WriteLine("Número de id: " & Prod & "Nombre de producto: Lenteja por libra" & "Descripción: Libra de lenteja colombiana" & "Tipo de producto: Despensa")

            ElseIf Producto = 2 Then
                Console.WriteLine("Número de id: " & Prod & "Nombre de producto: Doritos" & "Descripción: Tortilla sabor a maiz" & "Tipo de producto: Snack")

            End If Producto = 3 Then
                Console.WriteLine("Número de id: " & Prod & "Nombre de producto: Cream de dientes" & "Descripción: Pasta dental" & "Tipo de producto: Cuidado personal")

            End If Producto = 4 Then
                Console.WriteLine("Número de id: " & Prod & "Nombre de producto: Leche" & "Descripción: Bebida láctea" & "Tipo de producto: Bebidas")

            End If Producto = 5 Then
                Console.WriteLine("Número de id: " & Prod & "Nombre de producto: Jabón líquido" & "Descripción: Jabón tipo litro para ropa color" & "Tipo de producto: Aseo")

            End If Producto = 6 Then
                Console.WriteLine("Número de id: " & Prod & "Nombre de producto: Cartulina" & "Descripción: Cartulina de color rosa" & "Tipo de producto: Pepeleria")

            Else
            Console.Write("No existe producto")

            End If True Then

End If
            Return Resultado




        Loop Until = Prod















    End Sub







End Class
