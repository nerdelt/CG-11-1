using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace StudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates new student object
            Student student = new Student();

            Console.Write("The following students have more than 6 quiz scores.\n");

            List<string> Students = new List<string>();
        
            using (StreamReader sr = new StreamReader(@"C:\Users\nerdelt\Source\Repos\CG-11-1\StudentNames\StudentNames\studentdata.txt"))
            {
                string line;

                //creates a list for all the split strings from Students
                List<string> splitList = new List<string>();

                {
                    //while loop to add each line as an element in  list Students
                    while ((line = sr.ReadLine()) != null)
                    {
                        Students.Add(line);
                    }
                }

                foreach (string s in Students)
                {
                    //splits each string into smaller strings and adds them to new list
                    splitList = s.Split(' ').ToList();

                    // assigns name
                    student.Name = splitList[0];

                    int scores = splitList.Count;
                    if (scores > 7)
                    {
                        Console.WriteLine($"{student.Name}");
                    }
                }

                    Console.ReadLine();

                }
            }
        }
    }


