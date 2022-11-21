using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class student
    {
        int id;
        string name;
        int[] mark = new int[3];
        int total;
        public void read()
        {
            Console.WriteLine("Enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks of 3 subjects");
            for (int i = 0; i < 3; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void calculate()
        {
            total = mark[0] + mark[1] + mark[2];
        }
        public void display()
        {
            Console.WriteLine("Id={0}\nName={1}\nTotal={2}", id, name, total);
        }
    }
    class Assignment6_Class
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of students");
            n = Convert.ToInt32(Console.ReadLine());
            student[] s = new student[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = new student();
                s[i].read();
                s[i].calculate();
                s[i].display();
            }
            Console.ReadLine();
        }
    }
}

/*
Create a class named student with data members id, name, mark [3], total and the member functions 
are read ( ), calculate ( ) and display ( ). The read ( ) is for read n student details .Using calculate ( ) find 
the sum of 3 marks and store in total. The display ( ) is for display n student details.
 

 */
