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
            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.WriteLine("5. Login");
                Console.WriteLine("6. Exit");
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
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Sub(n1, n2);
                        Console.WriteLine("The difference is : " + n3);
                        break;
                    case "3":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Mul(n1, n2);
                        Console.WriteLine("The multiplication is : " + n3);
                        break;
                    case "4":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Div(n1, n2);
                        Console.WriteLine("The division is : " + n3);
                        break;
                    case "5":
                        Console.WriteLine("Enter email: ");
                        string user = Console.ReadLine();
                        Console.WriteLine(" Enter password: ");
                        string pass = Console.ReadLine();
                        string result = client.Login(user, pass);
                        Console.WriteLine(result);
                        break;
                }
            }
        }
    }
}
