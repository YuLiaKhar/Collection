using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "([]{})[]";
            //string b = "([]]";

            Stack<char> line = new Stack<char>();
            bool k, l, m, n;
            k = l = m = true;
            for (int i = 0; i < a.Length; i++)
            {
                char c = a[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    line.Push(c);
                }

                if (c == ')')
                {
                    if (line.Contains('('))
                    {
                        line.Pop();
                        k = true;
                    }
                    else
                    {
                        k = false;
                    }
                }
                if (c==']')
                {
                    if (line.Contains('['))
                    {
                        line.Pop();
                        l = true;
                    }
                    else
                    {
                        l = false;
                    }
                }
                if (c=='}')
                {
                    if (line.Contains('{'))
                    {
                        line.Pop();
                        m = true;
                    }
                    else
                    {
                        m = false;
                    }
                }

            }
            if ((k == true) && (l == true) && (m == true))
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Некорректно");
            }
            Console.ReadKey();
        }
    }
}
