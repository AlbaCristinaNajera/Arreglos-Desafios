using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validacion = true;
            int opcion;
            List<string> lista= new List<string>() { };
            do
            {
                Console.Clear();
                Console.WriteLine("----Administrador de tareas---");
                Console.WriteLine("1. Mostrar");
                Console.WriteLine("2. Agregar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Ingrese la opción que desea utilizar: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                   case 1:

                      foreach(string elemento in lista)
                      {
                            Console.WriteLine(elemento);
                        }
                        break;

                   case 2:
                        Console.WriteLine("Ingresa la tarea que deseas agregar a la lista: ");
                        string tareaAgregar = Console.ReadLine();
                        lista.Add(tareaAgregar);

                        Console.WriteLine("La tarea se agregó con éxito");
                        Console.WriteLine("Presione Enter para continuar");

                        break;

                   case 3:
                        Console.WriteLine("Ingresa la tarea que deseas eliminar de la lista: ");
                        string tareaEliminar = Console.ReadLine();
                        lista.Remove(tareaEliminar);

                        Console.WriteLine("Tarea eliminada de la lista con éxito");
                        Console.WriteLine("Presione Enter para continuar");

                        break;

                    case 4: validacion = false;
                        break;


                }

                Console.ReadKey();

            } while (validacion);
            
        }
    }
}
