using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic

{
    class Program
    {
        static void Main(string[] args)
        {

            MyStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);

            while (!stack.IsEmpty())
            {
                int number = stack.Pop();
                Console.WriteLine("Last value popped = {0}", number);
            }

            Console.ReadLine();
        }
    }


    public class MyStack<T>
    {
        T[] stack = new T[10];
        int sp;

        public void Push(T item)
        {
            stack[sp++] = item;
        }

        public T Pop()
        {
            return stack[--sp];
        }

        public bool IsEmpty()
        {
            return sp == 0;
        }
    }
}

