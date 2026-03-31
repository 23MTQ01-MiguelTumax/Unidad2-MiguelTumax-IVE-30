using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(1000);
        Console.WriteLine("=====MESES DEL AÑO=====");
        Thread.Sleep(1300);
        Console.WriteLine("Ingresa un número del 1 al 12 y te diré que mes es.");
        Thread.Sleep(2000);
        Console.Write("Número: ");
        int num;
        num = int.Parse(Console.ReadLine());

        Console.Clear();
        Thread.Sleep(1500);


        if (num < 1 || num > 12)
        {
            Console.WriteLine("Ingrese un número dentro del rango");
        }
        else if (num == 1)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Enero");
        }
        else if (num == 2)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Febrero");
        }
        else if (num == 3)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Marzo");
        }
        else if (num == 4)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Abril");
        }
        else if (num == 5)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Mayo");
        }
        else if (num == 6)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Junio");
        }
        else if (num == 7)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Julio");
        }
        else if (num == 8)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Agosto");
        }
        else if (num == 9)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Septiembre");
        }
        else if (num == 10)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Octubre");
        }
        else if (num == 11)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Noviembre");
        }
        else if (num == 12)
        {
            Console.Write("El mes que escogiste es... ");
            Thread.Sleep(1500);
            Console.WriteLine("Diciembre");
        }
    }
}