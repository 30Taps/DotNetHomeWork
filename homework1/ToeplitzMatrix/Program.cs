using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeplitzMatrix
{
    class Program
    {
        static int[,] array1 = new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
        static int[,] array2 = new int[,] { { 1, 2, 3, 4, 5 }, { 2, 1, 3, 3, 4 }, { 3, 3, 1, 2, 3 }, { 4, 3, 2, 1, 2 } };
        static bool Esti(int[,] array)
        {
            //Console.WriteLine(array1.Length);
            //Console.WriteLine(array2.Length);
            //Console.WriteLine(array1[0]);
            for (int i = 0; i < array.Rank; i++)
            {
                for (int j = 0; j < array.GetLength(i); j++)
                {
                    if (i == 0 || j == 0) continue;
                    else if (array[i,j] != array[(i-1),(j-1)]) return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"array1={Esti(array1)}");
            Console.WriteLine($"array2={Esti(array2)}");
            //bool a = Esti(array1);
            //bool b = Esti(array2);
        }
    }
}
