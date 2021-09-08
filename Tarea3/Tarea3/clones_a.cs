using System;
using System.IO;
namespace Tarea3
{

    public class clones_a
    {
        
        public void Clone_aluno()
        {
           
            aluno stu = new aluno();
            stu.detail = new detalle();
            aluno Cstu = stu.Clone() as aluno;
            Console.WriteLine("registro del aluno");

            Console.WriteLine("digiste el nombre del aluno.");
            stu.detail.nombre = Console.ReadLine();

            Console.WriteLine("digite el apellido.");
            stu.detail.apellido = Console.ReadLine();
            
            Console.WriteLine("digite el curso.");
            stu.detail.curso = Console.ReadLine();


            Console.WriteLine("digite la edad.");
            stu.detail.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite el telefono.");
            stu.detail.telefono = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("registro completado");
            Console.WriteLine($"nombre={stu.detail.nombre}\napellido={stu.detail.apellido}\nedad={stu.detail.edad}\ntelefono={stu.detail.telefono}");
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"nombre={stu.detail.nombre}\napellido={stu.detail.apellido}\nedad={stu.detail.edad}\ntelefono={stu.detail.telefono}");
            registro.Close();
            Console.ReadKey();
            Console.WriteLine("quiere regresar la menu pricipal\n1.Si\n2.No");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op==1)
            {
                Program.Main(args: new string[0]);
            }
            else
            {
               Clone_aluno(); 
            }
        }

        public void Clone_aluno2()
        {
            aluno stu = new aluno();
            stu.detail = new detalle();
            aluno Cstu = stu.Clone() as aluno;
            Console.WriteLine("registro del aluno");

            Console.WriteLine("digiste el nombre del aluno.");
            stu.detail.nombre = Console.ReadLine();

            Console.WriteLine("digite el apellido.");
            stu.detail.apellido = Console.ReadLine();
            
            Console.WriteLine("digite el curso.");
            stu.detail.curso = Console.ReadLine();


            Console.WriteLine("digite la edad.");
            stu.detail.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite el telefono.");
            stu.detail.telefono = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("registro completado");
            Console.WriteLine($"nombre={stu.detail.nombre}\napellido={stu.detail.apellido}\nedad={stu.detail.edad}\ntelefono={stu.detail.telefono}");
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"nombre={stu.detail.nombre}\napellido={stu.detail.apellido}\nedad={stu.detail.edad}\ntelefono={stu.detail.telefono}");
            registro.Close();
            Console.ReadKey();
            Console.WriteLine("quiere regresar la menu pricipal\n1.Si\n2.No");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op==1)
            {
                Program.Main(args: new string[0]);
            }
            else
            {
                Clone_aluno(); 
            }
        }

        public void Clone_aluno3()
        {
            
            aluno stu = new aluno();
            stu.detail = new detalle();
            aluno Cstu = stu.Clone() as aluno;
            Console.WriteLine("registro del aluno");

            Console.WriteLine("digiste el nombre del aluno.");
            stu.detail.nombre = Console.ReadLine();

            Console.WriteLine("digite el apellido.");
            stu.detail.apellido = Console.ReadLine();
            
            Console.WriteLine("digite el curso.");
            stu.detail.curso = Console.ReadLine();

            Console.WriteLine("digite la edad.");
            stu.detail.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite el telefono.");
            stu.detail.telefono = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("registro completado");
            Console.WriteLine($"nombre={stu.detail.nombre}\napellido={stu.detail.apellido}\nedad={stu.detail.edad}\ntelefono={stu.detail.telefono}");
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"nombre={stu.detail.nombre}\napellido={stu.detail.apellido}\nedad={stu.detail.edad}\ntelefono={stu.detail.telefono}");
            registro.Close();
            Console.ReadKey();
            Console.WriteLine("quiere regresar la menu pricipal\n1.Si\n2.No");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op==1)
            {
                Program.Main(args: new string[0]);
            }
            else
            {
                Clone_aluno(); 
            }
        }
        
        
    }
} 
