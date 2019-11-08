using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your credit card amount due");
            double credit = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the monthly payment you wish to make");
            double emi = double.Parse(Console.ReadLine());

            CreditCalc c = new CreditCalc();
            int mon=c.Calc(credit, emi);
            Console.WriteLine("You will take {0} months to pay back {1}",mon,credit);
            Console.ReadKey();

        }
    }
}
