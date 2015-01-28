using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Student Name: LI XU
 *Student ID: 300735072
 *Assignment 1
 *Due Date: Friday January 30th, 2015
 *Value:5% marks
 *GitHub: https://github.com/lester88a/COMP123-Assignment-01
 */
namespace Assignment1
{
    class Program
    {
        static void Main( )
        {
            Hero newHero = new Hero("King"); //implement the Hero by create a newHero object
            newHero.show(); //call show method to display hero's abilities
            newHero.fight(); //call fight method;

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();


        }
    }
}
