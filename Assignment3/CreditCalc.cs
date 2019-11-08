using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class CreditCalc
    {
        public int Calc(double x, double y)
        {
            double due = x;
            double mi = y;
            double ir = 1.5d;
            int dur = 0;
            double payment = 0;
            Console.WriteLine("********************");
            Console.WriteLine("Current Due: " + due);
            Console.WriteLine("***********************************************************************");
            for (int i=1;due>=0;i++)
            {
                double intr = (due * ir) / 100;
                due = due - (mi - intr);
                payment += mi;
                Console.WriteLine(String.Format("Month: {0} \t Balance: {1,-20} \t Total Payments: {2}",i,due,payment));

                if (due <= 0) 
                    dur = i;
            }
            Console.WriteLine("***********************************************************************");
            return dur;
        }
    }
}
