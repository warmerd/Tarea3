using System;

namespace Tarea3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("elija una opcion\n1-padre\n2-aluno\n3-salir");
            int option = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (option)
                {
                    case 1 :
                        padre pa = new padre();
                        pa.registra();
                        break;
                
                    case 2:
                        aluno alu = new aluno();
                        alu.registra();
                        break;
                    case 3 :
                        Console.WriteLine("bay bay.....");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                        
                    default:
                        Console.WriteLine("error! elija una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error! elija una opcion valida");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }

        }
    }
}