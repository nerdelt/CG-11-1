using System;

namespace StudentNames
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates new student object
            Student student = new Student();

            Console.Write("To find out the names of the students who have more than 6 quiz scores, " +
                "please press ENTER.\n");

            Console.ReadLine();

            //calls method to get students name who has more than 6 scores and prints to console
            Console.WriteLine(student.GetStudentName());
            Console.ReadLine();
        }
    }
}
