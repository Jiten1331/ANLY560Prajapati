//4.2 The Maclaurin series expansion for cos x is
//cosx= 1- x2/2+x4/4!-x6/6!+x8/8!-....
//Starting with the simplest version, cos x = 1, add terms one at a
//time to estimate cos(pi/3). After each new term is added, compute
//the true and approximate percent relative errors.Use your pocket
//calculator to determine the true value.Add terms until the absolute
//value of the approximate error estimate falls below an error criterion
//conforming to two significant figures.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            double tv = Math.Cos(Math.PI / 3);
            double es = 0.5 * Math.Pow(10, (2 - 2));
            Console.WriteLine(" True Value of cos(pi/3) : {0}", tv);
            Console.WriteLine(" Absolute true error in percentage: {0}%", es);
            // zero order of Cos(pi/3)
            Console.WriteLine("---------zero order of Cos(pi/3)---------");
            double tv0 = Math.Cos(Math.PI / 3);
            Console.WriteLine(" Zero order Value of cos(pi/3) : {0}", tv0);
            double et0 = Math.Abs((tv0 - 1) / tv0) * 100;
            Console.WriteLine(" Absolute true error in percentage of zero order of Cos(pi/3): {0}%", et0);
            // First order of Cos(pi/3)
            Console.WriteLine("--------First order value of Cos(pi/3)---------");
            double tv1 = 1-Math.Pow((Math.PI / 3),2)/Factorial(2);
            Console.WriteLine(" First order Value of cos(pi/3) : {0}", tv1);
            double et1 = Math.Abs((tv0 - tv1) / tv0) * 100;
            Console.WriteLine(" Absolute true error in percentage of first order of Cos(pi/3): {0}%", et1);
            double ea1 = Math.Abs((tv1-1)/tv1)*100;
            Console.WriteLine(" Approximate Absolute relative error in percentage of first order of Cos(pi/3): {0}%", ea1);
            // Second order of Cos(pi/3)
            Console.WriteLine("---------Second order value of Cos(pi/3)---------");
            double tv2 = tv1 + Math.Pow((Math.PI / 3), 4) /Factorial(4);
            Console.WriteLine(" Second order Value of cos(pi/3) : {0}", tv2);
            double et2 = Math.Abs((tv0 - tv2) / tv0) * 100;
            Console.WriteLine(" Absolute true error in percentage of Second order of Cos(pi/3): {0}%", et2);
            double ea2 = Math.Abs((tv2 - tv1) / tv2) * 100;
            Console.WriteLine(" Approximate Absolute relative error in percentage of Second order of Cos(pi/3): {0}%", ea2);
            // Third order of Cos(pi/3)
            Console.WriteLine("---------Third order value of Cos(pi/3)---------");
            double tv3 = tv2 - Math.Pow((Math.PI / 3), 6) / Factorial(6);
            Console.WriteLine(" Third order Value of cos(pi/3) : {0}", tv3);
            double et3 = Math.Abs((tv0 - tv3) / tv0) * 100;
            Console.WriteLine(" Absolute true error in percentage of Third order of Cos(pi/3): {0}%", et3);
            double ea3 = Math.Abs((tv3 - tv2) / tv3) * 100;
            Console.WriteLine(" Approximate Absolute relative error in percentage of Third order of Cos(pi/3): {0}%", ea3);
            Console.WriteLine("ea3<0.5%");
            Console.ReadLine();
        }
        static int Factorial(int n)
        {
            if (n >= 2) return n * Factorial(n - 1);
            return 1;
        }
    }
}
