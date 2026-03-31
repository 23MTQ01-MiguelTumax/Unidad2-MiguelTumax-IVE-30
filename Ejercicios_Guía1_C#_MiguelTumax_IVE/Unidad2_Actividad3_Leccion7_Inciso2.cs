using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(1300);
        Console.WriteLine("Tipos de Triángulo Según sus Ángulos");
        Thread.Sleep(2000);
        Console.WriteLine("Dime los ángulos de tu triángulo y te diré que tipo es.");
        Thread.Sleep(3000);
        Console.Write("Ángulo 1: ");
        double ang1, ang2, ang3;
        ang1 = double.Parse(Console.ReadLine());
        Console.Write("Ángulo 2: ");
        ang2 = double.Parse(Console.ReadLine());
        Console.Write("Ángulo 3: ");
        ang3 = double.Parse(Console.ReadLine());

        Console.Clear();
        Thread.Sleep(2000);

        

        if ((ang1 + ang2 + ang3) != 180)
        {
            Console.WriteLine("Eso no es un triángulo.");
        }
        else if ((ang1 == ang2) && (ang1 == ang3) && (ang2 == ang3))
        {
            Console.WriteLine("Es un triángulo equilátero.");
        }
        else if ((ang1 == ang2) || (ang1 == ang3) || (ang2 == ang3))
        {
            Console.WriteLine("Es un triángulo isósceles.");
        }
        else
        {
            Console.WriteLine("Es un triángulo escaleno.");
        }
    }
}