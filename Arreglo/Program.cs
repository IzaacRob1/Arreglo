//Hecho por Jose Izaac Robles Trinidad & Samir Dominguez Perez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglo
{
    class Program
    {
        private double[] datos;
        public void Ingresar() // En este metodo se ingresan los datos del arreglo
        {
            datos = new double[6];
            for (int f = 1; f < 6; f++)
            {
                Console.Write("Ingrese el valor numero " + f + " del arreglo: ");
                String linea;
                linea = Console.ReadLine();
                datos[f] = double.Parse(linea);
            }
            Console.Write("\n");
        }

        public void Imprimir() //En este metodo se muestran los valores tal y como se ingresaron
        {
            Console.Write("Los valores del arreglo son \n");
            for (int f = 1; f < 6; f++)
            {
                Console.Write("[" + datos[f] + "] ");
            }
            Console.WriteLine("\n");
        }

        public void Ordenar() // En este metodo se ordenan los datos del arreglo
        {
            Console.Write("Orden de menor a mayor \n");
            Array.Sort(datos);
            foreach (double value in datos)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            Console.Write("Orden de mayor a menor \n");
            Array.Reverse(datos);
            foreach (double value in datos)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
        }

        public void Guardar()
        {
            using (StreamWriter writer = new StreamWriter("Arregloizaac.txt", false))
            {
                for (int i = 0; i < datos.Length; i++)
                {
                    writer.WriteLine(datos[i].ToString());
                }
            }
        }

        public void Salir() // En este metodo se sale del programa de consola
        {
            Console.WriteLine("Saliendo...");
            return;
        }

        static void Main(string[] args)//main principal
        {
            Program pv = new Program();
            int Menu;
            do
            {  //Inicia ingreso de datos para la comparacion inicial

                Console.WriteLine("1. Ingresar los numeros" + "\n2. Mostrar los numeros" + "\n3. Ordenar los numeros" + "\n4. Guardar los numeros" + "\n5. Salir");
                Menu = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch (Menu)
                {
                    case 1:
                        Console.WriteLine("Ingreso de datos");
                        pv.Ingresar();
                        break;

                    case 2:
                        Console.WriteLine("Impresion de datos");
                        pv.Imprimir();
                        break;

                    case 3:
                        Console.WriteLine("Impresion de datos ordenados");
                        pv.Ordenar();
                        break;

                    case 4:
                        Console.WriteLine("Guardado de los datos");
                        Console.WriteLine("\n");
                        pv.Guardar();
                        break;

                    case 5:
                        pv.Salir();
                        break;

                    default:
                        Console.WriteLine("Error, dato erroneo");
                        break;

                }
            } while (Menu! == 5);
        }
    }
}
