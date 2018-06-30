using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical1
{
    /// <summary>   
    ///  Program that asks from the user for a number (data type: double) as the radius of a circle.
    ///  Calculate area and perimeter of the circle and display the results in a tabular format.
    ///  Note, the results should be rounded up to two decimal points by using composite formatting.
    ///  The following are the formula for calculating circle area and perimeter.
    ///  𝑎𝑟𝑒𝑎 = 𝑟𝑎𝑑𝑖𝑢𝑠 ∗ 𝑟𝑎𝑑𝑖𝑢𝑠 ∗ 𝜋
    ///  𝑝𝑒𝑟𝑖𝑚𝑒𝑡𝑒𝑟 = 𝑟𝑎𝑑𝑖𝑢𝑠 ∗ 2 ∗ 𝜋
    ///  Author: Faryaz
    /// </summary> 

    class MainClass
    {
        public static void Main(string[] args)
        {
            CricleArthimaticCalculation();

        }
        static void CricleArthimaticCalculation()
        {
            const double PI = 3.14;
            Write("Enter Radius: ");
            double radius = double.Parse(ReadLine());
            double area = radius * radius * PI;
            double perimeter = radius * 2 * PI;

            string header3 = "Radius", header4 = "Area", header5 = "Perimeter";
            WriteLine($"{header3,-20}{header4,-20}{header5,-20}");
            WriteLine(new string('-', 60));//a separation line
            WriteLine($"{radius,-20:f2}{area,-20:f2}{perimeter,-20:f2}");

        }

    }
}