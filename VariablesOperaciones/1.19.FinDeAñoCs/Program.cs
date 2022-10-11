TimeSpan hastaFinDeAño = new DateTime( DateTime.Now.Year, 12, 31, 23, 59, 59).Subtract(DateTime.Now);
Console.WriteLine("Falta hasta fin de año: {0} meses", 12 - DateTime.Now.Month);
Console.WriteLine("Falta hasta fin de año: {0} semanas", hastaFinDeAño.TotalDays / 7);
Console.WriteLine("Falta hasta fin de año: {0:0} horas", hastaFinDeAño.TotalHours);
