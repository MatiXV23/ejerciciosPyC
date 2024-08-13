using EjerciciosPy1;

Main();
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
        Console.WriteLine("10) EXIT ");
        Console.Write("Opcion: ");
        
        string ej = Console.ReadLine();
        
        switch (ej.ToLower())
        {
            case "1": 
                Ejercicio1.ValorAbsoluto(); 
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                break;
                
            case "2":
                Ejercicio2.votacion();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                break;
                
            case "3":
                Ejercicio3.msgSemana();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "4":
                Ejercicio4.SumatoriaNums();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "5":
                Ejercicio5.SimuladorDeDados();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                break;
            
            case "6":
                Ejercicio6.esPanagram();
                Console.WriteLine("Presione enter para continuar");
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





