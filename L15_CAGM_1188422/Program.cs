using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_CAGM_1188422
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;


            Console.WriteLine("Ingresar alguna de las opciones 1, 2 o 3");
            Console.WriteLine("1. Estimar la edad de 5 trabajadores");
            Console.WriteLine("2. Salarios a pagar");
            Console.WriteLine("3. Salir ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    string[] nombres = new string[5];
                    int[] edades = new int[5];
                    int[] calculo = new int[5];


                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingresar el nombre de la persona: ");
                        nombres[i] = Console.ReadLine();
                        Console.WriteLine("Ingresar en que año en el que nació: " + nombres[i]);
                        edades[i] = int.Parse(Console.ReadLine());
                        calculo[i] = 2022 - edades[i];
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(nombres[i] + " tiene: " + calculo[i] + " años");
                    }

                    break;

                case 2:
                    string[] puesto = new string[5];
                    double[] salario = new double[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el puesto: ");
                        puesto[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese el salario del puesto: " + puesto[i]);
                        salario[i] = double.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(puesto[i] + "tiene un salario de: " + salario[i]);
                    }
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ingrese una opción válida entre 1 y 3");
                    break;
            }

            Console.ReadKey();
        }
    }
}


