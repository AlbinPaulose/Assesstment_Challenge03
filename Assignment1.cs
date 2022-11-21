using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        public string name;
        public int rollNo;

        public void DisplayDetails()
        {
            Console.WriteLine("The name of the student is : {0}",name);
            Console.WriteLine("The roll no of the student is : {0}",rollNo);
        }
    }
    class Assignment1
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.rollNo = 1;
            student.name = "Albin";
            student.DisplayDetails();

            student.rollNo = 2;
            student.name = "Vishnu";
            student.DisplayDetails();

            Console.ReadLine();
        }
    }

}
/* 
 Create a class student with attribute name and roll number and a method displaydetails() 
for displaying the same. Create two instance of the class and call the method for each instance 

 */
