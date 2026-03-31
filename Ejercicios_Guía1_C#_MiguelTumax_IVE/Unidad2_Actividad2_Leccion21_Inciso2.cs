using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(1000);
        Console.WriteLine("BUZÓN DE VOZ DE NVIDIA");
        Thread.Sleep(2000);
        Console.WriteLine("Hola, mi nombre es Miguel Tumax CEO de NVIDIA.\n" +
            "Por el momento no estoy disponible, pero mi equipo de servicio al cliente te ayudará.");
        Thread.Sleep(3500);
        Console.WriteLine();
        Console.WriteLine("Presiona cualquier tecla para comunicarte con ellos.");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Transfiriéndolo a la llamada .");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo a la llamada ..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo a la llamada ...");
        Thread.Sleep(1000);
        Console.Clear();

        Thread.Sleep(1000);
        Console.WriteLine("Se ha comunicado con el servicio al cliente de NVIDIA.");
        Thread.Sleep(2000);
        Console.WriteLine("Marque 1 si quiere comunicarse con ventas.");
        Thread.Sleep(2000);
        Console.WriteLine("Marque 2 si quiere comunicarse con recepción.");
        Thread.Sleep(2000);
        Console.WriteLine("Marque 3 si quiere comunicarse con dirección.");
        Thread.Sleep(2000);
        Console.WriteLine("Marque 4 si quiere comunicarse con compras.");
        Thread.Sleep(2000);
        Console.WriteLine("¿Con cuál departamento desea comunicarse?");
        int num;
        num = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Transfiriéndolo a la llamada .");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo a la llamada ..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Transfiriéndolo a la llamada ...");
        Thread.Sleep(1000);
        Console.Clear();

        if (num == 1)
        {
            Console.WriteLine("Bienvenido, usted se ha comunicado con ventas.");
            Thread.Sleep(2000);
            Console.WriteLine("Soy Xavier Borrayo y mi correo es: gatunavi@gmail.com");
            Thread.Sleep(2000);
            Console.WriteLine("¿Cómo puedo ayudarte?");
        }
        else if (num == 2)
        {
            Console.WriteLine("Bienvenido, usted se ha comunicado con recepción.");
            Thread.Sleep(2000);
            Console.WriteLine("Soy Anggelo Rosales y mi correo es: arosalesdb23@gmail.com");
            Thread.Sleep(2000);
            Console.WriteLine("¿Cuál es su duda?");
        }
        else if (num == 3)
        {
            Console.WriteLine("Bienvenido, usted se ha comunicado con dirección.");
            Thread.Sleep(2000);
            Console.WriteLine("Soy Kendrick Santos y mi correo es: kasantshnz@gmail.com");
            Thread.Sleep(2000);
            Console.WriteLine("¿Qué puedo hacer por usted?");
        }
        else if (num == 4)
        {
            Console.WriteLine("Bienvenido, usted se ha comunicado con compras.");
            Thread.Sleep(2000);
            Console.WriteLine("Soy Diego Hernández y mi correo es: dieguishernandez.@gmail.com");
            Thread.Sleep(2000);
            Console.WriteLine("¿En qué puedo servirte estimado?");
        }
        else
        {
            Console.WriteLine("INGRESE UN NÚMERO DENTRO DEL RANGO.");
        }
    }
}