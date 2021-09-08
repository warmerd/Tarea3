using System;
using System.IO;
namespace Tarea3
{
    public class Clones_p
    {
        public void Clone_padre()
        {
            padre dad1 = new padre();
            padre Cdad = dad1.Clone() as padre;
            Console.WriteLine("registro del padre");
            
            Console.WriteLine("digiste el nombre del padre.");
            Cdad.nombre = Console.ReadLine();
            
            Console.WriteLine("digite el apellido.");
            Cdad.apellido = Console.ReadLine();
            
            Console.WriteLine("digite la edad.");
            Cdad.edad = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("digite el telefono.");
            Cdad.telefono = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"nombre={Cdad.nombre}\napellido={Cdad.apellido}\nedad={Cdad.edad}\ntelefono={Cdad.telefono}");
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"nombre={Cdad.nombre}\napellido={Cdad.apellido}\nedad={Cdad.edad}\ntelefono={Cdad.telefono}");
            registro.Close();
            Console.WriteLine("quiere regresar la menu pricipal\n1.Si\n2.No");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op==1)
            {
                Program.Main(args: new string[0]);
            }
            else
            {
                Clone_padre(); 
            }
        }

        public void Clone_padre2()
        {
            padre dad1 = new padre();
            padre Cdad1 = dad1.Clone() as padre;
            Console.WriteLine("registro del padre");
            
            Console.WriteLine("digiste el nombre del padre.");
            Cdad1.nombre = Console.ReadLine();
            
            Console.WriteLine("digite el apellido.");
            Cdad1.apellido = Console.ReadLine();
            
            Console.WriteLine("digite la edad.");
            Cdad1.edad = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("digite el telefono.");
            Cdad1.telefono = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"nombre={Cdad1.nombre}\napellido={Cdad1.apellido}\nedad={Cdad1.edad}\ntelefono={Cdad1.telefono}");
            
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"nombre={dad1.nombre}\napellido={dad1.apellido}\nedad={dad1.edad}\ntelefono={dad1.telefono}");
            registro.Close();
            
            Console.WriteLine("quiere regresar la menu pricipal\n1.Si\n2.No");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op==1)
            {
                Program.Main(args: new string[0]);
            }
            else
            {
                Clone_padre2(); 
            }
        }

        public void Clone_padre3()
        {
            padre dad1 = new padre();
            padre Cdad2 = dad1.Clone() as padre;
            Console.WriteLine("registro del padre");
            
            Console.WriteLine("digiste el nombre del padre.");
            Cdad2.nombre = Console.ReadLine();
            
            Console.WriteLine("digite el apellido.");
            Cdad2.apellido = Console.ReadLine();
            
            Console.WriteLine("digite la edad.");
            Cdad2.edad = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("digite el telefono.");
            Cdad2.telefono = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"nombre={Cdad2.nombre}\napellido={Cdad2.apellido}\nedad={Cdad2.edad}\ntelefono={Cdad2.telefono}");
            
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"nombre={Cdad2.nombre}\napellido={Cdad2.apellido}\nedad={Cdad2.edad}\ntelefono={Cdad2.telefono}");
            registro.Close();
            
            Console.WriteLine("quiere regresar la menu pricipal\n1.Si\n2.No");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op==1)
            {
                Program.Main(args: new string[0]);
            }
            else
            {
                Clone_padre(); 
            }
        }
    }
}