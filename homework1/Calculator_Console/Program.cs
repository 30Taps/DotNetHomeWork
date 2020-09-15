using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console
{

    class Program
    {
        static int Input(out int num_1, out int num_2,out string sym)//输入处理
        {
            num_1 = num_2 = 0;sym = "";
            Console.WriteLine("请输入两个数字，以回车间隔");
            //如何用循环做到？
            try
            {
                num_1 = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            try
            {
                num_2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            Console.WriteLine("输入想进行的运算");
            sym = Console.ReadLine();
            if ((sym != "+") & (sym != "-") & (sym != "*") & (sym != "/")) 
            {
                Console.WriteLine("输入不合法！");
                return 0;
            }
            return 1;
        }

        static int Cal(ref int num_1, ref int num_2,ref string sym)//运算处理
        {
            int result = 0;
            switch (sym)
            {
                case "+": result = num_1 + num_2;break;
                case "-": result = num_1 - num_2;break;
                case "*": result = num_1 * num_2;break;
                case "/":
                    if (num_2 != 0)
                    {
                        result = num_1 / num_2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("除0错误");
                        break;
                    }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("简易计算器");
            int num_1 = 0, num_2 = 0; string sym = "";
            int flag = Input(out num_1, out num_2, out sym);
            int result = Cal(ref num_1, ref num_2, ref sym);
            if(flag==1) Console.WriteLine($"结果为{result}");
        }
    }
}

