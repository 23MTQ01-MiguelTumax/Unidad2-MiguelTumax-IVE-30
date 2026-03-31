using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vamos a hacer una prueba, pero antes dime algo, ¿Crees que eres mayor de edad o no?");
        Thread.Sleep(3000);
        Console.Write("Respuesta: ");
        String respuesta = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Ingrese su edad por favor.");
        Thread.Sleep(1000);
        Console.Write("Edad: ");
        int edad;
        edad = int.Parse(Console.ReadLine());

        Console.Clear();
        Thread.Sleep(1000);

        if ((respuesta == "Si" || respuesta == "SI" || respuesta == "sI" || respuesta == "si") || 
            (respuesta == "No" || respuesta == "NO" || respuesta == "nO" || respuesta == "no"))
        {
            Console.WriteLine("Estás en lo correcto!!!");
        }

        Thread.Sleep(1000);
        
        if (edad >= 18)
        {
            Console.WriteLine("Felicidades, ya eres mayor de edad, ponte a trabajar.");
        }
        else
        {
            Console.WriteLine("Todavía eres menor de edad, disfruta esta etapa antés de que se vaya.");
        }

    }
}