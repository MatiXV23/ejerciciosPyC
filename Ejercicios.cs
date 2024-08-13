namespace EjerciciosPy1;

public class Ejercicio1
{
    public static void ValorAbsoluto()
    {
        Console.Write("Ingrese valor a calcular: ");
        string valor = Console.ReadLine();
        
        Console.WriteLine("El valor absoluto de " + valor +" es: "+ CalcValorAbsoluto(Int32.Parse(valor)));
    }

    public static int CalcValorAbsoluto(int valor)
    {
        if (valor >= 0)
        {
            return valor;
        }
        else
        {
            return valor * -1;
        }
    }
}

public class Ejercicio2
{
    public static void vote(string candidate)
    {
        if (candidate == "A")
        {
            Console.WriteLine("Usted ha votado al partido Rojo");
        }
        else if (candidate == "B")
        {
            Console.WriteLine("Usted ha votado al partido Verde");
        }
        else if (candidate == "C")
        {
            Console.WriteLine("Usted ha votado al partido Azul");
        }
        else
        {
            Console.WriteLine("Opcion erronea");
        }
    }

    public static void votacion()
    {
        Console.WriteLine("A - Partido Rojo");
        Console.WriteLine("B - Partido Verde");
        Console.WriteLine("C - Partido Azul");
        
        string voto = Console.ReadLine();
        vote(voto.ToUpper());
    }
    
}

public class Ejercicio3
{
    public static string mensajito(string dia)
    {
        dia = dia.ToLower();
        if (dia == "lunes")
        {
            return "Hoy comienza la semana. ¡Ánimo!";
        }
        else if (dia == "viernes")
        {
            return "Ya casi termina!";
        }
        else if (dia == "sabado" || dia == "domingo")
        {
            return "¡Siiii! ¡Fin de semana!";
        }
        else if (dia == "martes" || dia == "miercoles" || dia == "jueves")
        {
            return "¡Vamos que se puede!";
        }
        else
        {
            return "¡Dia de la semana invalido!";
        }
    }

    public static void msgSemana()
    {
        Console.Write("Ingrese el dia de la semana: ");
        string dia = Console.ReadLine();
        
        Console.WriteLine(mensajito(dia));
    }
}

public class Ejercicio4
{
    public static void SumatoriaNums()
    {
        int sum = 0;
        Console.Write("Ingrese un numero a sumar (0 para finalizar) : ");
        string num = Console.ReadLine();
        int Num = Int32.Parse(num);
        while (Num != 0)
        {
            Console.Write("Ingrese otro numero: ");
            num = Console.ReadLine();
            Num = Int32.Parse(num);
            if (Num > 0)
            {
                sum += Num;
            }
        }
        Console.WriteLine("La sumatoria de todos los numeros es: " + sum);
    }
}

public class Ejercicio5
{
    public static int tirada()
    {
        return new Random().Next(1, 7);
    }

    public static void SimuladorDeDados()
    {
        int veces1 = 0, veces2 = 0, veces3 = 0, veces4 = 0, veces5 = 0, veces6 = 0, sum = 0;
        int tiro1, tiro2;
        
        Console.Write("Ingrese la cantida de tiros que desea simular: ");
        int cantidadDeTiros = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < cantidadDeTiros; i++)
        {
            tiro1 = tirada();
            sum += tiro1;
            switch (tiro1)
            {
                case 1:
                    veces1 += 1;
                    break;
                case 2:
                    veces2 += 1;
                    break;
                case 3:
                    veces3 += 1;
                    break;
                case 4:
                    veces4 += 1;
                    break;
                case 5:
                    veces5 += 1;
                    break;
                case 6:
                    veces6 += 1;
                    break;
            }
            tiro2 = tirada();
            sum += tiro2;
            switch (tiro2)
            {
                case 1:
                    veces1 += 1;
                    break;
                case 2:
                    veces2 += 1;
                    break;
                case 3:
                    veces3 += 1;
                    break;
                case 4:
                    veces4 += 1;
                    break;
                case 5:
                    veces5 += 1;
                    break;
                case 6:
                    veces6 += 1;
                    break;
            }
        }

        float promedio = sum / cantidadDeTiros;
        Console.WriteLine("El promedio de los tiros es: " + promedio);
        Console.WriteLine("El 1 salio " + veces1 + " veces");
        Console.WriteLine("El 2 salio " + veces2 + " veces");
        Console.WriteLine("El 3 salio " + veces3 + " veces");
        Console.WriteLine("El 4 salio " + veces4 + " veces");
        Console.WriteLine("El 5 salio " + veces5 + " veces");
        Console.WriteLine("El 6 salio " + veces6 + " veces");
    }
}

public class Ejercicio6
{
    public static string strNormalize(string oracion)
    {
        string normal = "";

        foreach (var letter in oracion.ToLower())
        {
            switch (letter)
            {
                case 'á':
                    normal += 'a';    
                    break;
                case 'é':
                    normal += 'e';
                    break;
                case 'í':
                    normal += 'i';    
                    break;
                case 'ó':
                    normal += 'o';    
                    break;
                case 'ú':
                    normal += 'u';    
                    break;
                case 'ü':
                    normal += 'u';    
                    break;
                default:
                    normal += letter;
                    break;
            }
        }

        return normal;
    }

    public static void esPanagram()
    {
        Console.Write("Ingrese una oracion: ");
        string oracion = Console.ReadLine();
        oracion = strNormalize(oracion);
        Console.WriteLine(oracion);
        string abecedario = "abcdefghijklmnñopqrstuvwxyz";
        
        foreach (var letter in oracion)
        {
            Console.WriteLine(letter);
            if (abecedario.Contains(letter))
            {
                abecedario = abecedario.Remove(abecedario.IndexOf(letter), 1);
            }
        }

        if (abecedario == "")
        {
            Console.WriteLine("La oracion es un Panagrama!");
        }
        else
        {
            Console.WriteLine("La oracion no posee: " + abecedario);
        }
    }
}

public class Ejercicio7
{
    
}