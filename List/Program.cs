using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE");
            //VARIABLES NECESARIAS
            string elem;
            int opcion;
            int i; //control del ciclo
            //instanciamos la list
            List<string> Personas = new List<string>();

            //agregamos objetos a la list
            Personas.Add("LARRYSALSA");
            Personas.Add("LARRYSALSADECALI");
            Personas.Add("LARRYSALSAONLINE");
            Personas.Add("LARRYSALSAYTIMBA");
            Console.WriteLine("el numero de elementos contenidos en nuestra lista es: {0}", Personas.Count()); 

            //Console.WriteLine(Personas[1]);
            /*for(i=0; i<4; i++)
            {
                Console.WriteLine(Personas[i]);
            }*/
            /*do
            {
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                if(opcion== 1)
                {
                    Console.Write("Ingresa ele elemento a agregar en la lista:");
                    elem = Console.ReadLine();
                    Personas.Add(elem);
                }
            } while (opcion == 1);*/
            
        }
    }
}
