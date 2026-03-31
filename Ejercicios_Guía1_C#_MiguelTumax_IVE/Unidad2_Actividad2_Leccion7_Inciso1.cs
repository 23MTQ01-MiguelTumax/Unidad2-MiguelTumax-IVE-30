using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=====BUZÓN DE VOZ ORACLE CORPORATION=====");
        Thread.Sleep(2000);
        Console.WriteLine("Usted está en el buzón de voz de ORACLE CORPORATION.");
        Thread.Sleep(2000);
        Console.WriteLine("Marque 1 si quiere comunicarse con recursos humanos.");
        Thread.Sleep(2000);
        Console.WriteLine("Marque 2 si quiere comunicarse con ventas.");
        Thread.Sleep(2000);
        Console.WriteLine("Maruqe 3 si quiere comunicarse con soporte técnico.");
        Thread.Sleep(2000);
        Console.WriteLine("Maruqe 4 si quiere comunicarse con mantenimiento.");
        Thread.Sleep(2000);
        Console.Write("¿Con que departamento desea comunicarse?: ");
        int num;
        num = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Transfiriéndolo al operador, esto puede tomar tiempo .");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo al operador, esto puede tomar tiempo ..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo al operador, esto puede tomar tiempo ...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo al operador, esto puede tomar tiempo .");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo al operador, esto puede tomar tiempo ..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo al operador, esto puede tomar tiempo ...");
        Thread.Sleep(1000);
        Console.Clear();

        if (num == 1)
        {
            Console.WriteLine("Usted se ha comunicado con recursos humanos, ¿Cuál es su duda?");
        }
        else if (num == 2)
        {
            Console.WriteLine("Usted se ha comunicado con ventas, ¿Cuál es su duda?");
        }
        else if (num == 3)
        {
            Console.WriteLine("Usted se ha comunicado con soporte técnico, ¿Cuál es su duda?");
        }
        else if (num == 4)
        {
            Console.WriteLine("Usted se ha comunicado con mantenimiento, ¿Cuál es su duda?");
        }
        else
        {
            Console.WriteLine("Por favor ingrese un número dentro del rango de 1 a 4.");
        }
    }
}