using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("OFICINA FEDERAL DE INVESTIGACIÓN DE GUATEMALA");
        Thread.Sleep(2000);
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
        Console.Clear();

        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Iniciando sesión .");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Iniciando sesión ..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Iniciando sesión ...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Iniciando sesión .");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Iniciando sesión ..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Iniciando sesión ...");
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine("Ingrese la contraseña para ingresar a los archivos de investigación clasificados.");
        Thread.Sleep(2000);
        Console.Write("Contraseña: ");
        String password = Console.ReadLine();

        Console.Clear();
        Thread.Sleep(1000);

        if (password == "Password123")
        {
            Console.WriteLine("Sesión iniciada correctamente.");
            Thread.Sleep(1500);
            Console.WriteLine("¿Qué archivos desea consultar?");
        }
        else
        {
            Console.WriteLine("Ingreso prohibido.");
            Thread.Sleep(1500);
            Console.WriteLine("¿Qué estás intentando chaval?");
        }
    }
}