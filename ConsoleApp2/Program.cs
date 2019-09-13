using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operator: ");
            char calculator = char.Parse(Console.ReadLine());


            int add = (a + b);
            int minus = (a - b);
            int multiply =(a * b);
    


            if (calculator == '+')
            {
                Console.WriteLine(add);
                
            }
            else if (calculator == '-')
            {
                Console.WriteLine(minus);
            }
           else if(calculator == '*')
            {
                Console.WriteLine(multiply);
            }
            else if(calculator == '/')
            {
                try
                {
                    int division = (a / b);
                    Console.WriteLine(division);
                }
                catch
                {
                    Console.WriteLine("Please do not enter the value 0");
                }
                
            }
            else
            {
                Console.Write("Invalid Operator!!");
            }
            Console.ReadLine();

        }
    }
}
