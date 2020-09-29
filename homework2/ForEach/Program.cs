using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> temp = head;
            while (temp.Next != null)
            {
                action(temp.Data);
                temp = temp.Next;
            }
            action(temp.Data);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                intList.Add(i);
            }
            intList.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("Max=");
            int max = 0;
            intList.ForEach(delegate (int i) { if (max < i) max = i; });
            Console.WriteLine(max);
            Console.WriteLine("Min=");
            int min = 0;
            intList.ForEach(delegate (int i) { if (min > i) min = i; });
            Console.WriteLine(min);
            Console.WriteLine("Sum=");
            int sum = 0;
            intList.ForEach(i => sum += i);
            Console.WriteLine(sum);
        }
    }
}
