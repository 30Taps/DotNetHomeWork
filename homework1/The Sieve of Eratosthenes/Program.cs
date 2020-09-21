using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace The_Sieve_of_Eratosthenes
{
    public struct Array
    {
        public int num;
        public bool isPrime;
    }

    class Program
    {
        static int MAX = 100;
        static void Sieve(Array[] list)
        {
            list[0].isPrime = false;
            list[1].isPrime = false;
            for(int i=2; i<MAX;i++)
            {
                if(list[i].isPrime)
                {
                    //Console.WriteLine(list[i].num);
                    for(int j=2; i*j<MAX;j++)
                    {
                        list[i * j].isPrime = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Array[] list = new Array[MAX];
            for(int i=0; i<MAX;i++)
            {
                list[i].num = i;
                list[i].isPrime = true;
            }
            Sieve(list);
            Console.WriteLine($"MAX={MAX}");
            for(int i=0; i<MAX;i++)
            {
                if(list[i].isPrime)
                {
                    Console.Write(list[i].num + " ");
                }
            }
        }
    }
}
