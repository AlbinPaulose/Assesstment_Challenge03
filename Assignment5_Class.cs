using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Book
    {
        private int bookNo;
        private string bookTitle;
        private float bookPrice;

        public float TotalCost(int n)
        {
            return bookPrice * n;
        }
        public void Input()
        {
            Console.Write("Enter book number: ");
            bookNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book title: ");
            bookTitle = Console.ReadLine();
            Console.Write("Enter price: ");
            bookPrice = Convert.ToInt32(Console.ReadLine());
        }

        public void Purchase()
        {
            Console.Write("Enter number of copies to be purchased: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float totalCost = TotalCost(n);
            Console.WriteLine("Total cost to be paid: " + totalCost);
        }
    }

    class Assignment5_Class
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Input();
            book.Purchase();


            Console.ReadLine();
        }
    }
}
/*
 
using Classes and Object. Implement the following facilities using C#
Define a class BOOK with the following specifications :
Private members of the class BOOK are
BOOK NO integer type
BOOKTITLE 20 characters
PRICE float (price per copy)
TOTAL_COST() A function to calculate the total cost for N number of copies where N is passed to 
the function as argument. 
Public members of the class BOOK are
INPUT () function to read BOOK_NO. BOOKTITLE, PRICE
PURCHASE () function to ask the user to input the number of copies to be purchased.
It invokes TOTAL_COST () and prints the total cost to be paid by the user.

 */
