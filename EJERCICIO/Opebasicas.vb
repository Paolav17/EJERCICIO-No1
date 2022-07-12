Public Class Opebasicas


    'propiedades
    Public num1 As Integer
    Public num2 As Integer
    Public restnum1 As Integer
    Public restnum2 As Integer
    Public multnum1 As Integer
    Public multnum2 As Integer
    Public Divnum1 As Integer
    Public Divnum2 As Integer
    Public potnum1 As Integer
    Public potnum2 As Integer


    'funciones
    Public Function Sumar()
        Dim Resultado As Integer
        Console.WriteLine(" Escribe el primer número")
        num1 = Console.ReadLine
        Console.WriteLine(" Escribe el segundo número")
        num2 = Console.ReadLine
        Resultado = num1 + num2
        Return Resultado

    End Function

    Public Function Restar()
        Dim Resultado2 As Single

        Console.WriteLine(" Escribe el primer número para restar")
        restnum1 = Console.ReadLine
        Console.WriteLine(" Escribe el segundo número para restar")
        restnum2 = Console.ReadLine
        Resultado2 = restnum1 - restnum2
        Return Resultado2

    End Function
    Public Function Multiplicar()
        Dim Resultado3 As Single

        Console.WriteLine(" Escribe el primer número para multiplicar")
        multnum1 = Console.ReadLine
        Console.WriteLine(" Escribe el segundo número para multiplicar")
        multnum2 = Console.ReadLine
        Resultado3 = multnum1 * multnum2
        Return Resultado3

    End Function

    Public Function Dividir()
        Dim Resultado4 As Single

        Console.WriteLine(" Escribe el primer número para dividir")
        Divnum1 = Console.ReadLine
        Console.WriteLine(" Escribe el segundo número para dividir")
        Divnum2 = Console.ReadLine
        Resultado4 = Divnum1 / Divnum2
        Return Resultado4

    End Function


    Public Function Potencia()
        Dim Resultado5 As Single

        Console.WriteLine(" Escribe el número base de potencia")
        potnum1 = Console.ReadLine
        Console.WriteLine(" Escribe el exponente de la potencia")
        potnum2 = Console.ReadLine
        Resultado5 = potnum1 ^ potnum2
        Return Resultado5

    End Function
End Class
