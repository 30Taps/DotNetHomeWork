using System;

namespace Array
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
            for(int i=0;i<liststr.Length;i++)
            {
                try
                { 
                    list[i] = Convert.ToInt32(liststr[i]);
                }
                catch(Exception e)
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


            //foreach (int i in list)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine("\n");

        }

    }
}
