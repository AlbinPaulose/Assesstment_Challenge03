using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    class Assignmnet3_Class
    {
        public void CountSpaces(string s1)
        {
            int count = 0;
            foreach(char ch in s1)
            {
                if(ch == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("The number of spaces in the given string is {0}",count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            Assignmnet3_Class assignmnet = new Assignmnet3_Class();
            assignmnet.CountSpaces(s);


            Console.ReadLine();
        }
    }
}

/*
 Program to create a function to input a string and count the number of spaces in the 
string.
 
 */
