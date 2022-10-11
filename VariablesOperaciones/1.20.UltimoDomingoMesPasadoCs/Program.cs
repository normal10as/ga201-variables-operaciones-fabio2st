DateTime fechaActual = DateTime.Now;
DateTime finDeMes = fechaActual.AddDays(-fechaActual.Day);
var ultimoDomingoMesPasado = fechaActual.Day + finDeMes.DayOfWeek;
Console.WriteLine("Cantidad de días hasta el último domingo del mes pasado: " + ultimoDomingoMesPasado);