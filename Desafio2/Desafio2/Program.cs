using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];

            comprasClientes(numeros);

            Console.ReadKey();

        }
        public static void comprasClientes(int[,] listaCompras)
        {
            int[] totalClientes = new int[5];

            for (int i = 0; i < listaCompras.GetLength(0); i++)
            {
                for (int j = 0; j < listaCompras.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el precio del cliente {i +1} con la compra {j+1}: ");
                    listaCompras[i, j] = int.Parse(Console.ReadLine());
                    totalClientes[i] += listaCompras[i, j];
                }
            }

            for (int i = 0; i < totalClientes.Length; i++)
            {
                if (totalClientes[i] <= 99)
                {
                    Console.WriteLine($"No aplica descuento para el cliente {i + 1}, su total es de: {totalClientes[i] }" );
                }

                else if (totalClientes[i] >= 100 && totalClientes[i] <= 1000)
                {
                    Console.WriteLine($"Se le aplicó un descuento del 10% al cliente {i + 1}, ahora el total con el descuento aplicado es de:  { totalClientes[i] - (totalClientes[i] * 0.1) }" );
                }

                else if (totalClientes[i] >= 1000)
                {
                    Console.WriteLine($"Se le aplicó un descuento del 20% al cliente {i + 1}, el total final con el descuento aplicado es de: {totalClientes[i] - (totalClientes[i] * 0.2) }" );
                }
            }

        }


    }
}
