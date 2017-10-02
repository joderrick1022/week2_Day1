using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //the way you declare a array below
            //int[] favoriteNumbers = {1, 2, 3, 4 ,5 ,6 };

            ////the way you initialize a array above

            ////the way you write out a sstring var
            //string[] studentNames = { "Raz","MONICA","DAVID","BRIAN","ALI", };
            //Console.WriteLine(studentNames[2]);



            //string[] vacationSpots = { "NEWYORK", "LOS ANGELOS", "FLORIDA", "CANCOON", "JAMAICA", "ALASKA", "CANADA", "ATLANTA", "HOUSTON", "HAITI", };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);



            //print childs age

            //int[] childrenAge = {5, 10, 12 };
            //Console.WriteLine(childrenAge[0]);
            //Console.WriteLine(childrenAge[1]);
            //Console.WriteLine(childrenAge[2]);


            // PRINT GpA SCORES 

            //float[] gpa = { 1.0f, 2.0f,3.5f,4.0f,3.1f,3.0f,2.5f,2.7f};

            //PRINT FIRST LETTER OF PEERS NAME.

            string[] peersFirstLet = { "o", "h", "l", "l", "e" };

            //Console.WriteLine(peersFirstLet[1] + "\n" + peersFirstLet[4] +  "\n" + peersFirstLet[2] + "\n" + peersFirstLet[3] + "\n" + peersFirstLet[0] );



            // this is how you declare and initialize a empty array
            int[] numbers = new int[4];
            numbers[0] = 43;
            numbers[1] = 12;
            Console.WriteLine("pick a number");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("pick a number");
            numbers[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine(numbers[3]);


        }
    }
}
