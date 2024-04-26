using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.*/
            int n, max = 0, pos = 0;
            int [] numeros = new int [10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
                numeros [i] = n;
            }
            for (int x = 0; x < 10; x++)
            {
               if(x == 0){
                    max = numeros [x];
                }
                if(numeros [x] > max){
                    max = numeros [x];
                    pos = x;
                }

            }
            Console.WriteLine("El valor maximo es " + max + " y su posicion " + pos);
        }
    }
}
