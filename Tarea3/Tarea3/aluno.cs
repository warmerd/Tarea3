using System;
using System.IO;
namespace Tarea3
{
    public class aluno:ICloneable
    {
        
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public int telefono { get; set; }
        public string curso { get; set; }
        
        public detalle detail { get; set; }

        public void registra()
        {
            clones_a clonesA = new clones_a();
            
            Console.WriteLine("digite el numero registro");
            int alu = Convert.ToInt32(Console.ReadLine());

            switch (alu)
            {
               case 1:
                   Console.WriteLine("registro del aluno");
            
                   Console.WriteLine("digiste el nombre del padre.");
                   nombre = Console.ReadLine();
            
                   Console.WriteLine("digite el apellido.");
                   apellido = Console.ReadLine();
            
                   Console.WriteLine("digite la edad.");
                   edad = Convert.ToInt32(Console.ReadLine());
            
                   Console.WriteLine("digite el telefono.");
                   telefono = Convert.ToInt32(Console.ReadLine());
            
                   Console.WriteLine("digite el curso. ");
                   curso = Console.ReadLine();
                   Console.Clear();
                 Console.WriteLine("se ha registrado correctamente");
                  Console.WriteLine($"Nombre={nombre}\nApellido={apellido}\nEdad={edad}\nTelefono={telefono}\nCurso={curso}");
                   Console.ReadKey();
                   Console.WriteLine("quiere regresar la menu pricipal\n1.Si\n2.No");
                   int op = Convert.ToInt32(Console.ReadLine());

                   if (op==1)
                   {
                       Program.Main(args: new string[0]);
                   }
                   else
                   {
                       registra(); 
                   }
                   break;
               
               case 2:
                   clonesA.Clone_aluno();
                   
                   break;
               
               case 3:
                   clonesA.Clone_aluno2();
                   break;
               
               case 4:
                   clonesA.Clone_aluno3();
                   break;
               
            }
        }

        public void save()
        {
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"Nombre={nombre}\nApellido={apellido}\nEdad={edad}\nTelefono={telefono}\nCurso={curso}");
            registro.Close();
        }
        public object Clone()
        {
            aluno clon = this.MemberwiseClone() as aluno;
            detalle detal = new detalle();
            detal.nombre = this.detail.nombre;
            detal.apellido = this.detail.apellido;
            detal.curso = this.detail.curso;
            detal.telefono = this.detail.telefono;
            detal.edad = this.detail.edad;
            clon.detail = detal;
            return clon;
        }
    }
    public class detalle
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public int telefono { get; set; }
        public string curso { get; set; }

    }
}