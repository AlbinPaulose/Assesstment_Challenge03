using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drwaing a Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
    class Assignment2_Class
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle();
            shape.Draw();

            shape=new Circle();
            shape.Draw();


            Console.ReadLine();
        }
    }
}

/*
 
Implement Run Time Polymorphism.

 */
