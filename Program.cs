using EjerciciosPy1;

Main();
//test();
void test()
{
    bool[] numeros = new bool[100];
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write(i + ") ");
        numeros[i] = true;
        Console.WriteLine(numeros[i].ToString());
    }
}

static void Main()
{
    bool ejecutando = true;
    while (ejecutando)
    {
        Console.WriteLine("---EJERCICIO A REALIZAR--- \n");
        Console.WriteLine("1) Valor Absoluto");
        Console.WriteLine("2) Votacion");
        Console.WriteLine("3) Mensaje segun dia de la semana");
        Console.WriteLine("4) Sumatoria de numeros");
        Console.WriteLine("5) Simulador de dados");
        Console.WriteLine("6) Detector de Panagramas");
        Console.WriteLine("7) Boleto de loteria");
        Console.WriteLine("10) EXIT ");
        Console.Write("Opcion: ");
        
        string ej = Console.ReadLine();
        
        switch (ej.ToLower())
        {
            case "1": 
                Ejercicio1.ValorAbsoluto(); 
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                break;
                
            case "2":
                Ejercicio2.votacion();
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                break;
                
            case "3":
                Ejercicio3.msgSemana();
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "4":
                Ejercicio4.SumatoriaNums();
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "5":
                Ejercicio5.SimuladorDeDados();
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "6":
                Ejercicio6.esPanagram();
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "7":
                Ejercicio7.BoletoLoteria();
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "10":
                ejecutando = !ejecutando;
                break;
            
            case "exit":
                ejecutando = !ejecutando;
                break;
            
            default:
                Console.WriteLine("Por favor selecciona una opcion valida --- Presione enter para continuar ---");
                Console.ReadLine();
                break;
                
        }
    }
    
}





