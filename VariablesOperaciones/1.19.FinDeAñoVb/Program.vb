Imports System

Module Program
    Sub Main(args As String())
        Dim hastaFinDeA�o As TimeSpan = New DateTime(Now.Year, 12, 31, 23, 59, 59).Subtract(Now())
        Console.WriteLine("Falta hasta fin de a�o: {0} meses", 12 - Now.Month)
        Console.WriteLine("Falta hasta fin de a�o: {0} semanas", hastaFinDeA�o.TotalDays / 7)
        Console.WriteLine("Falta hasta fin de a�o: {0:0} horas", hastaFinDeA�o.TotalHours)
    End Sub
End Module
