using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            double input;

            // input
            Console.WriteLine("Please enter a number! Like now!");
            input = double.Parse(Console.ReadLine());

            // processing
            input = Math.Sqrt(input);

            // output

            //Console.WriteLine("The output is {0}.", input);
            Console.WriteLine($"The output is {input}");

        //adding this to push to Git Hub
        //trying a 3rd comitt


        }
    }
}
