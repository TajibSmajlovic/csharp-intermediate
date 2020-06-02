using Olx;

namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customer = new Customer();
            var BMW = new Car("ASD123");

            Text text = new Text();
            Shape shape = text;

            text.Width = 300;
            shape.Width = 200;

            Shape newShape = new Shape();
            Text text2 = (Text)newShape; // or text2 = newShape as Text;
        }
    }
}