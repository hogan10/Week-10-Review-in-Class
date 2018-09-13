using System;
using System.Collections;
using System.Collections.Generic;

namespace week_10_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //I want to create different collections of students
            //student has: 
            //name (store as a string)
            //age (store as int)
            //gpa (store as float)
            //id (store as int)

            ClassExercise classExercise = new ClassExercise();
            classExercise.Run();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

     
        }
    }
}
