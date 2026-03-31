using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(1000);
        Console.WriteLine("Ya estamos en Semana Santa, dime un número y te diré que día es.");
        Thread.Sleep(2000);
        Console.Write("Número: ");
        int num;
        num = int.Parse(Console.ReadLine());

        Console.Clear();
        Thread.Sleep(1000);

        if (num == 1)
        {
            Console.WriteLine("Hoy es lunes. Es un buen día para ir a procesiones.");
        }
        else if (num == 2)
        {
            Console.WriteLine("Hoy es martes. Sigue reflexionando en la Pasión de Cristo.");
        }
        else if (num == 3)
        {
            Console.WriteLine("Hoy es miércoles. Es el fin de la Cuaresma, ve a hacer el baile de Judas.");
        }
        else if (num == 4)
        {
            Console.WriteLine("Hoy es jueves. Hoy fue la última cena de nuestro Señor Jesucristo.");
        }
        else if (num == 5)
        {
            Console.WriteLine("Hoy es viernes. Hoy Jesús fue juzgado, lastimado, crucificado y posteriormente, murió.");
        }
        else if (num == 6)
        {
            Console.WriteLine("Hoy es sábado. Hay que esperar porque mañana Jesús resucitará.");
        }
        else if (num == 7)
        {
            Console.WriteLine("Hoy es domingo!!, Cristo resucitó y venció a la muerte.");
        }
        else
        {
            Console.WriteLine("Ingrese un número dentro del parámetro.");
        }
    }
}