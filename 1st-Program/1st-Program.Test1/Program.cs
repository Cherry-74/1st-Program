using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ConsoleApp3
{
    public class Addition

    {
        public float Add(float a, float b)
        {
            return (a + b);


        }

        public double Add(double a, double b)
        {
            return (a + b);

        }


        static void Main(string[] args)
        {


            Addition aa = new Addition();

            var c = aa.Add(1.00000000000084, 4.33333334);
            var d = aa.Add(1.03, 2.2222);

            Console.WriteLine("the sum of two no are : " + c);
            Console.WriteLine("the sum of two no are : " + d);
            Console.ReadLine();

        }


    }
}