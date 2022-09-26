namespace _1._02.VelocidadDeLaLuzCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            ushort segundos;
            ulong distancia;
            const uint velocidadDeLaLuz = 300000;
            //Entrada
            Console.Write("Ingrese número de segundos: ");
            segundos = Convert.ToUInt16(Console.ReadLine());
            //Proceso
            distancia = (ulong)segundos * velocidadDeLaLuz;
            //Salida
            Console.WriteLine("En {0} segundos, la luz recorre {1} Kilometros.", segundos, distancia);
        }
    }
}