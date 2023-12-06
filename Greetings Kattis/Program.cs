using System;
using System.Text;

namespace hey
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new StringBuilder();
            string input = Console.ReadLine();

            char x = 'h';
            char y = 'y';

            foreach(char c in input)
            {
                str.Append(c);
                if (c == 'e')
                {
                    str.Append(c);
                }
            }
            Console.WriteLine(str.ToString());
            
        }
    }
}