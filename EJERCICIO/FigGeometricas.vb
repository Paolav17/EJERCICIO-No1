Public Class FigGeometricas
    'declarar variables
    Public triaLado1 As Single
    Public triaLado2 As Single
    Public triaLado3 As Single
    Public triaBase As Single
    Public triaAltura As Single
    Public cuaLado As Single
    Public RecBase As Single
    Public RecAltura As Single
    Public LadRombo As Single
    Public DiagMenRombo As Single
    Public DiagMayRombo As Single
    Public BaseRomboide As Single
    Public AlturaRomboide As Single








    Public Function Triangulo()
        Dim TriaPerímetro As Single
        Dim TriaArea1 As Single
        Dim TriaArea As Single

        Console.WriteLine(" Escribe el valor de la medida lado 1 del triangulo")
        triaLado1 = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la medida lado 2 del triangulo")
        triaLado2 = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la medida lado 3 del triangulo")
        triaLado3 = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la medida de la base del triangulo")
        triaBase = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la medida de la altura del triangulo")
        triaAltura = Console.ReadLine
        TriaPerímetro = triaLado1 + triaLado2 + triaLado3
        TriaArea1 = (triaBase * triaAltura)
        TriaArea = TriaArea1 / 2
        Return " Perímetro del triangulo es " & TriaPerímetro & " El área del triangulo es " & TriaArea

    End Function


    Public Function Cuadrado()
        Dim CuaPerímetro As Single
        Dim CuaArea As Single

        Console.WriteLine(" Escribe el valor de la medida del lado del cuadrado")
        cuaLado = Console.ReadLine

        CuaPerímetro = 4 * cuaLado
        CuaArea = cuaLado ^ 2
        Return " Perímetro del cuadrado es " & CuaPerímetro & " El área del cuadrado es " & CuaArea

    End Function

    Public Function Rectangulo()
        Dim RecPerímetro As Single
        Dim RecArea As Single

        Console.WriteLine(" Escribe el valor de la medida de la base del rectangulo")
        RecBase = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la medida de la altura del rectangulo")
        RecAltura = Console.ReadLine

        RecPerímetro = (2 * RecBase) + (2 * RecAltura)
        RecArea = RecBase * RecAltura

        Return " Perímetro del rectangulo  es " & RecPerímetro & " El área del rectangulo es " & RecArea

    End Function

    Public Function Rombo()
        Dim RomboPerímetro As Single
        Dim RomboArea As Single

        Console.WriteLine(" Escribe el valor de la medida del lado del rombo")
        LadRombo = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la medida del Diagonal menor del rombo ")
        DiagMenRombo = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la medida del Diagonal mayor del rombo ")
        DiagMayRombo = Console.ReadLine

        RomboPerímetro = 2 * LadRombo
        RomboArea = (DiagMenRombo * DiagMayRombo) * 2

        Return " Perímetro del rombo  es " & RomboPerímetro & " El área del rombo es " & RomboArea

    End Function

    Public Function Romboide()
        Dim RomboidePerímetro As Single
        Dim RomboideArea As Single

        Console.WriteLine(" Escribe el valor de la base del rombiode")
        BaseRomboide = Console.ReadLine
        Console.WriteLine(" Escribe el valor de la altura del romboide ")
        AlturaRomboide = Console.ReadLine

        RomboidePerímetro = (2 * BaseRomboide) + (2 * AlturaRomboide)
        RomboideArea = BaseRomboide * AlturaRomboide

        Return " Perímetro del rombo  es " & RomboidePerímetro & " El área del rombo es " & RomboideArea

    End Function

End Class
