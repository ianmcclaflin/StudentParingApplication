using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenPairing
{
    class Studentlisting
    {
        static void Main(string[] args)
        {

            //Create a console application that with allow you to provide a list of student names and then pair those students into groups.

            //The user should be able to enter an unknown number of student names.
            //The students should be placed in groups of two.If there is an odd number of students, then the application should create one group of three.
            //After all student pairs have been created a list of student pairings should be printed out on the screen.

            //Console.WriteLine("Enter Student Name: ");

            //ArrayList students = new ArrayList() { };

            //string studentName1 = Console.ReadLine();

            //Console.WriteLine($"This is the first student: {studentName1}");

            //List<string> Student = new List<string>();
            //Student.Add("Hi");
            //String[] str = Student.ToArray();

            //int array;
            //string[] StudentNames = new string[i];
            //Console.WriteLine("Enter Student Name: ");
            //string students = Convert.ToString(Console.ReadLine());
            bool exitListOfStudents = false;

            int list = 5;
            string[] studentName = new string[list];
            Console.WriteLine("Please enter your name:");
            for (int i = 1; i < list; i++)
            {
                studentName[i] = Console.ReadLine();
                Console.WriteLine($"Student Name: {i}");
                Console.WriteLine("Are all these your ");
                if (Console.ReadLine === "yes")
                {

                }
            }

        }
    }
}
