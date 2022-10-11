Imports System

Module Program
    Sub Main(args As String())
        Dim hastaFinDeAño As TimeSpan = New DateTime(Now.Year, 12, 31, 23, 59, 59).Subtract(Now())
        Console.WriteLine("Falta hasta fin de año: {0} meses", 12 - Now.Month)
        Console.WriteLine("Falta hasta fin de año: {0} semanas", hastaFinDeAño.TotalDays / 7)
        Console.WriteLine("Falta hasta fin de año: {0:0} horas", hastaFinDeAño.TotalHours)
    End Sub
End Module
