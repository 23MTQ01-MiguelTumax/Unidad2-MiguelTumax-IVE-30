using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("¿Quieres saber si aprobaste compu con Cupri?");
        Thread.Sleep(2000);
        Console.WriteLine("Rango de la nota --> 0 a 100");
        Thread.Sleep(2000);
        Console.Write("Dime tu nota: ");
        int nota;
        nota = int.Parse(Console.ReadLine());

        Console.Clear();

        if (nota >= 70 && nota <= 100)
        {
            Console.WriteLine("Felicidades!!!");
            Thread.Sleep(2000);
            Console.WriteLine("Aprobaste compu con Cupri, eso ya es un logro.");
        }
        else if (nota >= 0 && nota <= 69)
        {
            Console.WriteLine("Reprobaste");
            Thread.Sleep(2000);
            Console.WriteLine("Será para la próxima ...");
        }
        else
        {
            Console.WriteLine("Ingresa una nota dentro del rango.");
        }

        Thread.Sleep(1000);
    }
}