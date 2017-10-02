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
            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("pick a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("pick a number");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            //Console.WriteLine(numbers[3]);

            //DECLARE 7 DAYS OF THE WEEK IN ARRAY
            //string[]  daysOfTheWeek = {"MON","TUES","WENS","THUR","FRI","SAT","SUND"};

            //list 5 students ages using the (new) keyword,
            //int[] studentAge = new int[5];

            //studentAge[0] = 10;
            //studentAge[1] = 25;
            //studentAge[2] = 46; // this was naming each index in the studentAge int,
            //studentAge[3] = 55;
            //studentAge[4] = 25;

            // write my name give name letters values in array.

            //string[] lastName = { "L", "G", "D", "N", "O", "E" };

            //Console.WriteLine(lastName[1] + "\n" + lastName[4] + "\n" + lastName[0] + "\n" + lastName[2] + "\n" + lastName[5] + "\n" + lastName[3] );


            //make a array of names, FIND INDEX OF specific name,


            //string[] rndNames = { "JOE", "MAT", "BILLY", "WILLY", "FRANK", "JARRYD", };

            //Console.WriteLine(Array.IndexOf(rndNames, "WILLY"));



            //create a array of lucky numbers

            //int[] luckyNumbers = { 10, 5, 50, 10, 50, 5, 10 };
            //Console.WriteLine(Array.LastIndexOf(luckyNumbers, 5));








            // creaetd array with letters call first index reverse and call first index

            //char[] alphaLetters = {'G','L','l', 'f','h'};
            //Console.WriteLine(alphaLetters[0]);
            //Array.Reverse(alphaLetters);
            //Console.WriteLine(alphaLetters[0]);


            // create a array of rnd students
            string[] students = {"jack ","mike","bill","kacy","matt", };
         Array.Sort(students);
            Console.WriteLine(students[0] + "\n" + students[4]);








        }
    }
}
