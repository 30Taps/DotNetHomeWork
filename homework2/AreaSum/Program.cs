using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaSum
{
    public abstract class Graph
    {
        public abstract double Area();
    }
    public class Graph1 : Graph
    {
        public override  double Area()
        {
            return 1;
        }
    }
    public class Graph2: Graph
    {
        public override double Area()
        {
            return 2;        
        }
    }
    public class Graph3: Graph
    {
        public override  double Area()
        {
            return 3;
        }
    }
    public class Graph4 : Graph
    {
        public override double Area()
        {
            return 4;
        }
    }
    public class Graph5 : Graph
    {
        public override double Area()
        {
            return 5;
        }
    }
    public class Graph6 : Graph
    {
        public override double Area()
        {
            return 6;
        }
    }
    public class Graph7 : Graph
    {
        public override double Area()
        {
            return 7;
        }
    }

    public class Graph8 : Graph
    {
        public override double Area()
        {
            return 8;
        }
    }
    public class Graph9 : Graph
    {
        public override double Area()
        {
            return 9;
        }
    }
    public class Graph10 : Graph
    {
        public override double Area()
        {
            return 10;
        }
    }

    public class GraphSpecies
    {
        public static Graph Species(int type)
        {
            switch (type)
            {
                case 1:return new Graph1();
                case 2: return new Graph2();
                case 3: return new Graph3();
                case 4: return new Graph4();
                case 5: return new Graph5();
                case 6: return new Graph6();
                case 7: return new Graph7();
                case 8: return new Graph8();
                case 9: return new Graph9();
                case 10: return new Graph10();
                default:return null;

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random(System.DateTime.Now.Millisecond);
            int[] getRd = new int[10];
            double sum = 0;
            for(int i=0; i < 10; i++)
            {
                getRd[i] = rd.Next(1, 11);
            }
            for(int i = 0; i < 10; i++)
            {
                Graph graph = GraphSpecies.Species(getRd[i]);
                sum += graph.Area();
            }
            Console.WriteLine(sum);
        }
    }
}



