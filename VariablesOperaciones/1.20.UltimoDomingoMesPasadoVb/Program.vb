Imports System

Module Program
    Sub Main(args As String())
        Dim fechaActual As DateTime = Now
        Dim finDeMes As DateTime = fechaActual.AddDays(-fechaActual.Day)
        Dim ultimoDomingoMesPasado = fechaActual.Day + finDeMes.DayOfWeek
        Console.WriteLine("Cantidad de días hasta el último domingo del mes pasado: " & ultimoDomingoMesPasado)
    End Sub
End Module
