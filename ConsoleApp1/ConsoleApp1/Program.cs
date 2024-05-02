using System.Collections;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        void GetProductdDataFromConsole(Product product)
        {
            Console.WriteLine("Please enter the product name");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please enter the product ID");
            int id;
            while (!Int32.TryParse(Console.ReadLine(), out id)) ;
            Console.WriteLine("Invalid number for ID. Try again");
            product.Id = id;
            Console.WriteLine("Please enter the product Price");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price)) ;
            Console.WriteLine("Invalid number for price. Try again");
            product.Price = price;
            Console.WriteLine("Please enter the product Quantity");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
        }
        void PrintProductDetails(Product product)
        {
            Console.WriteLine(product);
        }
        int GetNumber()
        {
            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                return num1;
            }
            catch (FormatException fe)
            {
                Debug.WriteLine(fe);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            return 0;
        }
        public delegate void CalDel(int n1,int n2);
        void Calculate(CalDel cal)
        {
            cal(20, 30);
        }
        //void Add(int num1,int num2)
        //{
        //    int result = num1+num2;
        //    Console.WriteLine("The sum is "+result);
        //}
        static void Main(string[] args)
        {
            //int result = new Program().GetNumber();
            //Console.WriteLine(result);
            Program program = new Program();
            //CalDel obj = delegate (int n1, int n2)//anon function
            //{
            //    int result = n1 + n2;
            //    Console.WriteLine("The sum is " + result);
            //};
            //CalDel obj = (int n1, int n2) => Console.WriteLine("The sum is " +(n1+n2));//Lambda expression
            program.Calculate((n1,n2)=> Console.WriteLine("The sum is " + (n1 + n2)));

        }
    }
    
}
