using System;

namespace Classes
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            //var customer = new Customer();

            //customer.Orders.Add(new Order());

            //Console.WriteLine(customer.Orders.Count);

            //var res = Add(1, 2, 3, 4, 5);
            //Console.WriteLine(res);

            //Parse("asd");

            var person = new Person(new DateTime(1995, 03, 12));
            Console.WriteLine(person.Age);

            var cookie = new HttpCookie();
            cookie["name"] = "Tajib";
            Console.WriteLine(cookie["name"]);
        }
    }
}