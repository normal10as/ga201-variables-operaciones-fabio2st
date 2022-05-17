// See https://aka.ms/new-console-template for more information
class Program{ 
    static void Main()
    {
        // Declaracion de variables
        float temperaturaCelcius, temperaturaFahrenheit;
        // Ingreso de datos
        Console.Write("Ingrese la temperatura en grados celcius: ");
        temperaturaCelcius = Convert.ToSingle(Console.ReadLine());
        //temperaturaCelcius = float.Parse(Console.ReadLine());
        // proceso
        temperaturaFahrenheit = (float)(temperaturaCelcius * 1.8 + 32);
        //salida
        Console.WriteLine($"Equivale a {temperaturaFahrenheit} grados fahrenheit");
    }
}
