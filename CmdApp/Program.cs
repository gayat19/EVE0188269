using System;

namespace CmdApp
{
    internal class Program
    {
        int num1;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.num1 = 100;
            Console.WriteLine($"The number is {p.num1}");//Interpollation
            Console.WriteLine("The number is "+p.num1);//Concatination
        }
    }
}