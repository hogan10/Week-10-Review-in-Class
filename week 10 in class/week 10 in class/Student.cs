using System;
using System.Collections.Generic;
using System.Text;

namespace week_10_in_class
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float GPA { get; set; }
        
        public Student (int id, string name, int age, float gpa)
        {
            Id = id;
            Name = name;
            Age = age;
            GPA = gpa;

        }

        //make it so that anyone making a new student can't make one unless they enter everything needed - this is the private Student below

        private Student () { }

        public override string ToString()
        {
            return $"{this.Name} is {this.Age} and has a GPA of {this.GPA}";
        }
    }
}
