using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)


        {


            int[] array = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            EncontrarValorMedio(array);

            Console.ReadLine();
        }

        private static void EncontrarValorMedio(int[] array)
        {
            // somar todos os valores do array 
            double soma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }
            // dividir a soma pela quantidade de valores do array
            double media = soma / array.Length;
            Console.WriteLine(media);
        }
    }
}
