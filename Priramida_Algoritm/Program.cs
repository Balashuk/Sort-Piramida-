using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priramida_Algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int line = 4, column = 4;
            int[,] A = new int[line, column]; // Лінія і стовбець
            A[0, 0]=-50;
            A[0, 1]=67;
            A[0, 2]=39;
            A[0, 3]=95;
            A[1, 0]=46;
            A[1, 1]=-24;
            A[1, 2]=51;
            A[1, 3]=-18;
            A[2, 0]=91;
            A[2, 1]=102;
            A[2, 2]=-36;
            A[2, 3]=18;
            A[3, 0]=15;
            A[3, 1]=-22;
            A[3, 2]=16;
            A[3, 3] = 31;
         
                       
            Console.WriteLine("Початковий масив масив:\n ");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)

                    Console.Write("{0,7:N2}\t", A[i, j]);
                Console.WriteLine();
            }
            int element=0;
            int[] Piramida = new int[line * column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Piramida[element] = A[i, j];
                    element++;
                }
            }

            Array.Sort(Piramida);
            Array.Reverse(Piramida);

            Console.WriteLine("\n Відсортований масив у вигляді піраміди: ");

            Console.WriteLine();
            Console.WriteLine("           "+ Piramida[0]);
            Console.WriteLine("        "+ Piramida[1]+"  "+ Piramida[2]+"  "+ Piramida[3]);
            Console.WriteLine("     "+ Piramida[4]+"  "+ Piramida[5]+"  "+ Piramida[6]+"  "+ Piramida[7]+"  "+ Piramida[8]);
            Console.WriteLine(" "+ Piramida[9]+"  "+ Piramida[10]+"  "+ Piramida[11]+"  "+ Piramida[12]+"  "+ Piramida[13]+"  "+ Piramida[14]+"  "+ Piramida[15]);
            Console.ReadKey();

        }
    }
}
