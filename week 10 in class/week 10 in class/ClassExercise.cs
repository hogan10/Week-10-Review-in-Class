using System;
using System.Collections.Generic;
using System.Text;

namespace week_10_in_class
{
    class ClassExercise
    {
        public void Run()
        {
            List<Student> students = CreateStudentList();
            //use below if you are using tostring in main
            PrintStudentInfo(students);

            // OTHER EXAMPLE OF CREATING LIST List<Student> students2 = new List<Student>();
            // students2.Add(student1);  (DO THIS FOR EACH STUDENT)

            //do the below if you don't want to use the to string return in the main 
            //PrintId(students);
            //PrintName(students);

        }

        private void PrintStudentInfo(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        private void PrintName(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        private void PrintId(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Id);
          
            }

        }

        private List<Student> CreateStudentList()
        {
           
            Student student1 = new Student(1, "Kendra", 21, 4.0F);
            Student student2 = new Student(2, "Bob", 34, 3.7F);
            Student student3 = new Student(3, "Alex", 42, 3.9F);
            Student student4 = new Student(4, "John", 28, 3.8F);

            List<Student> students = new List<Student> { student1, student2, student3, student4 };
            return students; 
        }
    }
}
