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

            //to add a new student:

            Student newStudent = new Student(6, "Jane", 24, 3.0F);
            //the 0 makes sure that this new student inserts at the first index and pushes the rest to the next index
            //you could put 1 2 or 3 to move it around to whichever spot you want. can't do this with an array bc it would replace that item instead of pushing it 
            students.Insert(0, newStudent);

            //use below if you are using tostring in main
            PrintStudentInfo(students);

            // OTHER EXAMPLE OF CREATING LIST List<Student> students2 = new List<Student>();
            // students2.Add(student1);  (DO THIS FOR EACH STUDENT)

            //do the below if you don't want to use the to string to return everything at once in the main 
            //PrintId(students);
            //PrintName(students);

        }
        //use the first method below to show all student info when using the string to in the main 
        //if you don't use the string to use individual methods below to call individually (age, gpa, name, id)
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
