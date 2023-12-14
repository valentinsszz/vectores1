using System;
using System.Security.Cryptography.X509Certificates;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores 
            //que son mayores al promedio.

            int[] numeros = new int[5];
            int promedio, acu = 0, mayor = 0;

            Console.WriteLine("Escribe 10 numeros");
                for (int x = 0; x < 5; x++)
                {
                    numeros[x] = int.Parse(Console.ReadLine());   
                }
            

                for (int x = 0; x < 5; x++)
                {
                    acu+= numeros[x];
                }
                promedio = acu / 5;
                Console.WriteLine("El promedio es" + promedio); 
                for (int x = 0; x < 5; x++)
                {
                    if (numeros[x] > promedio)
                    {
                        mayor++;
                    }
                }
                

            
                

        }   
    }
}
