using System.Threading; //ESTE COMANDO SIRVE PARA UTILIZAR EL Thread.Sleep(); es básicamente hacer que el programa espere los segundos que yo le diga
internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(2000);
        Console.WriteLine("¿GANASTE O PERDISTE?");
        Thread.Sleep(2000);
        Console.WriteLine("Dime 5 calificaciones y te diré si aprobaste o no.");
        Thread.Sleep(2000);
        Console.WriteLine("NOTA IMPORTANTE: Las notas no tiene que ser mayor a 10.");
        double nota1, nota2, nota3, nota4, nota5;

        Console.Write("Nota 1: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        nota2 = double.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        nota3 = double.Parse(Console.ReadLine());
        Console.Write("Nota 4: ");
        nota4 = double.Parse(Console.ReadLine());
        Console.Write("Nota 5: ");
        nota5 = double.Parse(Console.ReadLine());

        Console.Clear();
        Thread.Sleep(1000);
        Console.WriteLine("Procesando información .");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Procesando información ..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Procesando información ...");
        Thread.Sleep(1000);
        Console.Clear();

        if ((nota1 >= 0 && nota1 <11) && 
            (nota2 >= 0 && nota2 < 11) &&
            (nota3 >= 0 && nota3 <11) &&
            (nota4 >= 0 && nota4 <11) &&
            (nota5 >= 0 && nota5 <11))
        {
            double promedio;
            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            if (promedio >= 5)
            {
                Console.WriteLine("FELICIDADES!!!");
                Console.WriteLine("APROBASTE");
            }
            else
            {
                Console.WriteLine("Será para la próxima");
                Console.WriteLine("REPROBASTE");
            }
        }
        else
        {
            Console.WriteLine("INGRESE LAS NOTAS EN EL RANGO ESPERADO.");
        }
    }
}