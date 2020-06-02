using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Circle : Shape
    {
        public override void Dance()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Dance()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public Position Position { get; set; }

        public abstract void Draw();

        public abstract void Dance();
    }
}