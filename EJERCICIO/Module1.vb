Module Module1

    Sub Main()
        'Declaramos la suma para que pueda ejecutarse
        Dim sumar As Opebasicas = New Opebasicas

        sumar.num1 = 0
        sumar.num2 = 0

        Console.WriteLine(sumar.Sumar())

        'resta
        Dim restar As Opebasicas = New Opebasicas

        restar.restnum1 = 0
        restar.restnum2 = 0

        Console.WriteLine(restar.Restar())

        'multiplicar
        Dim multiplicar As Opebasicas = New Opebasicas

        multiplicar.multnum1 = 0
        multiplicar.multnum2 = 0

        Console.WriteLine(multiplicar.Multiplicar())

        'Dividir
        Dim dividir As Opebasicas = New Opebasicas

        dividir.Divnum1 = 0
        dividir.Divnum2 = 0

        Console.WriteLine(dividir.Dividir())

        'Potencia
        Dim potencia As Opebasicas = New Opebasicas

        potencia.Potnum1 = 0
        potencia.Potnum2 = 0

        Console.WriteLine(potencia.Potencia())


        'Triangulo
        Dim Triangulo As FigGeometricas = New FigGeometricas

        Triangulo.triaLado1 = 0
        Triangulo.triaLado2 = 0
        Triangulo.triaLado3 = 0
        Triangulo.triaBase = 0
        Triangulo.triaAltura = 0


        Console.WriteLine(Triangulo.Triangulo())

        'cuadrado
        Dim Cuadrado As FigGeometricas = New FigGeometricas
        Cuadrado.cuaLado = 0

        Console.WriteLine(Cuadrado.Cuadrado())

        'Rectangulo
        Dim Rectangulo As FigGeometricas = New FigGeometricas
        Rectangulo.RecBase = 0
        Rectangulo.RecAltura = 0


        Console.WriteLine(Rectangulo.Rectangulo())


        'Rombo
        Dim Rombo As FigGeometricas = New FigGeometricas
        Rombo.LadRombo = 0
        Rombo.DiagMenRombo = 0
        Rombo.DiagMayRombo = 0


        Console.WriteLine(Rombo.Rombo())

        'Romboide
        Dim Romboide As FigGeometricas = New FigGeometricas
        Romboide.BaseRomboide = 0
        Romboide.AlturaRomboide = 0

        Console.WriteLine(Romboide.Romboide())


        'Cajero
        Dim Cajero As Cajero = New Cajero
        Cajero.clave = 0


        Console.WriteLine(Cajero.Cajero())

    End Sub







End Module
