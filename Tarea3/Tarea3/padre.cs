using System;
using System.IO;
namespace Tarea3
{
    public class padre : ICloneable
    {
        
        private ICloneable _cloneableImplementation;
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public int telefono { get; set; }
        public int ID { get; set; }

        Clones_p Clonp = new Clones_p();
        public void registra()
        {
            
            //Clones Clon = new Clones_p();
            Console.WriteLine("digiste el numero de registro");
            int num_R = Convert.ToInt32(Console.ReadLine());
            switch (num_R)
            {
                case 1:
                    Console.WriteLine("registro del padre");
            
                    Console.WriteLine("digiste el numero de registro del padre.");
                    nombre = Console.ReadLine();
            
                    Console.WriteLine("digite el Nombre apellido.");
                    apellido = Console.ReadLine();
            
                    Console.WriteLine("digite la edad.");
                    edad = Convert.ToInt32(Console.ReadLine());
            
                    Console.WriteLine("digite el telefono.");
                    telefono = Convert.ToInt32(Console.ReadLine());
            
                    Console.WriteLine("digite el id. ");
                    ID = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("registro completado");
                    Console.WriteLine($"Nombre={nombre}\nApellido={apellido}\nEdad={edad}\nTelefono={telefono}\nID={ID}");
                    SAVE();
                    
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
                    Console.ReadKey();
                    
                    break;
                
                case 2:
                    Clonp.Clone_padre();
                    break;
                
                case 3:
                    Clonp.Clone_padre2();
                    break;
                
                case 4:
                    Clonp.Clone_padre3();
                    break;
                    
            }
        }

        public void SAVE()
        {
            TextWriter registro;
            registro = new StreamWriter("registro.txt");
            registro.WriteLine($"Nombre={nombre}\nApellido={apellido}\nEdad={edad}\nTelefono={telefono}\nID={ID}");
            registro.Close();
        }
        
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}