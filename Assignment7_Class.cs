using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class studentswap
    {
        int id;
        string name;
        int mark;
        public void read()
        {
            Console.WriteLine("Enter id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter mark:");
            mark = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("{0} {1} {2}", id, name, mark);
        }
        public void swap(studentswap a)
        {
            int temp = id;
            id = a.id;
            a.id = temp;
            temp = mark;
            mark = a.mark;
            a.mark = temp;
            string temp1 = name;
            name = a.name;
            a.name = temp1;
        }
    }
    class Assignment7_Class
    {

        static void Main(string[] args)
        {
            studentswap s1 = new studentswap();
            studentswap s2 = new studentswap();
            s1.read();
            s2.read();
            Console.WriteLine("Before swap");
            s1.display();
            s2.display();
            Console.WriteLine("After Swap");
            s1.swap(s2);
            s1.display();
            s2.display();

            Console.ReadLine();
        }
    }
}
/*
 
Create a class studentswap with data members id, name, mark and the member functions are read ( ), 
swap ( ) and display ( ). Using swap function swap 2 student objects value. Call the display( ) before 
and after the swap ( )

 
 */
