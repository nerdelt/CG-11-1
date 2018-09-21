using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace StudentNames
{
    //creates student class
    class Student
    {
        // creates string array for txt file to go into
        public string[] StudentData { get; set; }

        //creates string property to be returned 
        public string Name { get; set; }

        //creates method for getting students name if they have more than 6 quiz scores
        public string GetStudentName()
        {
            //reads txt file
            StudentData = File.ReadAllLines(@"C:\Users\nerdelt\Source\Repos\CG-11-1\StudentNames\StudentNames\studentdata.txt");

            //creates a loop to spilt each line into array
            //then counts items in array and only returns the name of those that have more than 6 scores
            foreach (string s in StudentData)
            {
                string[] score = s.Split(' ');
                int l = score.Length;
                if (l > 7)
                {           
                    Name = score[0];
                }
            }
                return Name;
            

        }
    }
}



