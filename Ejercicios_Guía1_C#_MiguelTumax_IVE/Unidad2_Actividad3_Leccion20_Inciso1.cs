using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(1000);
        Console.WriteLine("Hola");
        Thread.Sleep(1000);
        Console.WriteLine("Dame un número 1 al 7.");
        Thread.Sleep(1000);
        Console.Write("Número: ");
        int num;
        num = int.Parse(Console.ReadLine());
        Console.Clear();

        if ((num == 1) || (num == 2) || (num == 3) || (num == 4) || (num == 5))
        {
            Console.WriteLine("Todavía estás entre semana, sigue trabajando");
        }
        else if ((num == 6) || (num == 7))
        {
            Console.WriteLine("Ya puedes descansar, es fin de semana");
            Thread.Sleep(2000);
            Console.WriteLine("No te olvides de ir a Misa los domingos.");
        }
        else
        {
            Console.WriteLine("Ingresa un número dentro del rango.");
        }

        Thread.Sleep(2000);
        Console.WriteLine();
        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
        Console.Clear();
    }
}