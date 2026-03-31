using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Thread.Sleep(1300);
        Console.WriteLine("ESTACIONES DEL AÑO -- VERSIÓN EE.UU");
        Thread.Sleep(1500);
        Console.Write("Ingresa el día (máximo 28): ");
        int dia;
        dia = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el mes (máximo 12): ");
        int mes;
        mes = int.Parse(Console.ReadLine());

        Console.Clear();
        Thread.Sleep(2000);

        if ((dia < 1 || dia > 28) || (mes < 1 || mes > 12))
        {
            Console.WriteLine("Ingrese los datos dentro del parámetro por favor.");
        }

        //ESTACIÓN PRIMAVERA

        else if (mes == 3 && (dia >= 21 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("PRIMAVERA");
        }
        else if ((mes >= 4 && mes <= 5) && (dia >= 1 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("PRIMAVERA");
        }
        else if (mes == 6 && (dia >=1 && dia <= 20))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("PRIMAVERA");
        }

        //ESTACIÓN VERANO

        else if (mes == 6 && (dia >= 21 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("VERANO");
        }
        else if ((mes >= 7 && mes <= 8) && (dia >= 1 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("VERANO");
        }
        else if (mes == 9 && (dia >= 1 && dia <= 21))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("VERANO");
        }

        //ESTACIÓN OTOÑO

        else if (mes == 9 && (dia >= 22 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("OTOÑO");
        }
        else if ((mes >= 10 && mes <= 11) && (dia >= 1 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("OTOÑO");
        }
        else if (mes == 12 && (dia >= 1 && dia <= 20))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("OTOÑO");
        }

        //ESTACIÓN INVIERNO
        
        else if (mes == 12 && (dia >= 21 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("INVIERNO");
        }
        else if ((mes >= 1 && mes <= 2) && (dia >= 1 && dia <= 28))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("INVIERNO");
        }
        else if (mes == 3 && (dia >= 1 && dia <= 20))
        {
            Console.Write("ESTÁS EN LA ESTACIÓN DE ... ");
            Thread.Sleep(2000);
            Console.WriteLine("INVIERNO");
        }
    }
}