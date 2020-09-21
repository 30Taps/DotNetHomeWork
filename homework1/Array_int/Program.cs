using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_int
{
    class Program
    {
        static int[] Input()
        {
            Console.WriteLine("输入任意多整数，以“，”分隔");
            string inputstr = Console.ReadLine();
            var liststr = inputstr.Split(',');
            //foreach (string i in liststr) Console.Write(i+"\t");
            //Console.WriteLine("\n");
            int[] list = new int[liststr.Length];
            for (int i = 0; i < liststr.Length; i++)
            {
                try
                {
                    list[i] = Convert.ToInt32(liststr[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:" + e);
                }
            }
            Array.Sort(list);
            //foreach (int i in list)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine("\n");
            return list;
        }


        static void Main(string[] args)
        {
            int[] list = Input();
            Console.WriteLine($"min={list[0]},max{list[list.Length-1]}");
            Console.WriteLine($"ave={list.Average()}");
            Console.WriteLine($"sum={list.Sum()}");
            
            //foreach (int i in list)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine("\n");

        }
    }
}
