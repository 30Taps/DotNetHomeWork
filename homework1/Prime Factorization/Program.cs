using System;

namespace Prime_Factorization
{
    class Program
    {
            static bool Input(out int num)
            {
                Console.WriteLine("输入一个整数：");
                string a = Console.ReadLine();
                if (int.TryParse(a, out num))
                {
                    num = int.Parse(a);
                }
                else
                {
                    Console.WriteLine("输入有误");
                    return false;
                }

                if (num < 2)
                {
                    Console.WriteLine("无解");
                    return false ;
                }
                else return true;
            }
        static void prifac(int num)
        {
            int i = 2; 
            while (i<=num)
            {
                if (num % i == 0)
                {
                    Console.Write($"{i},");
                    num /= i;
                }
                else i++;
            }
        }
        static void Main(string[] args)
        {
            int num = 0;
            Input(out num);
            prifac(num);


        }
    }
}
