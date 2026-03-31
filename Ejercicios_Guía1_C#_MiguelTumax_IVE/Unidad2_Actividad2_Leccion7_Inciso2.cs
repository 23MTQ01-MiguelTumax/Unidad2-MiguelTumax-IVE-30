using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(1000);
        Console.WriteLine("¿Deseas conocer que tan buena o mala es tu calificación?");
        Thread.Sleep(2000);
        Console.WriteLine("Ingresa tu calificación y te diré si es deficiente, regular, buena, muy buena o excelente.");
        Thread.Sleep(3000);
        Console.WriteLine("*LA NOTA NO TIENE QUE SER MAYOR A 10*");
        Thread.Sleep(2000);
        Console.Write("Nota: ");
        double grade;
        grade = double.Parse(Console.ReadLine());

        Console.Clear();
        Thread.Sleep(1000);

        if (grade < 0 || grade > 10)
        {
            Console.WriteLine("Ingresa una nota dentro del rango.");
        }
        else if (grade >= 0 && grade < 3)
        {
            Console.WriteLine("Lástima, tu calificación es deficiente.");
        }
        else if (grade >= 3 && grade < 5)
        {
            Console.WriteLine("Ya va queriendo, tu calificación es regular.");
        }
        else if (grade >= 5 && grade < 7)
        {
            Console.WriteLine("Vas por buen camino, tu calificación es buena.");
        }
        else if (grade >= 7 && grade < 9)
        {
            Console.WriteLine("Muy bien hecho, tu calificación es muy buena.");
        }
        else if (grade >= 9 && grade <= 10)
        {
            Console.WriteLine("Te felicito, tu calificación es excelente.");
        }
    }
}