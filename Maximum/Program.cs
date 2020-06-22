using System;

namespace Maximum
{
    class Program
    {

        static int Maximum(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b > c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine($"Maximum(3, 4, 7) is {Maximum(3, 4, 7)}");
        }
    }
}
