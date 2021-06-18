using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str;
            int[] fre = new int[250];
            int i = 0, max, l;
            int asc;

            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            l = str.Length;

            for (i = 0; i < 250; i++)
            {
                fre[i] = 0;
            }

            i = 0;
            while ( i < l)
            {
                asc = (int) str[i];
                fre[asc] += 1;
                i++;
            }

            max = 0;
            for (i = 0; i < 250; i++)
            {
                if (i != 32)
                {
                    if (fre[i] > fre[max])
                    {
                        max = i;
                    }
                }
            }

            Console.WriteLine("Enter a word to search ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Word found {0} times in the string", fre[max]);
        }
    }
}