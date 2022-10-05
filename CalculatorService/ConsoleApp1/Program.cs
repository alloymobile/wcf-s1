using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string choice="";
            double n1, n2, n3;
            while (!choice.Equals("5"))
            {
                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\t Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Add(n1, n2);
                        Console.WriteLine("The sum is : "+n3);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            }
        }
    }
}
