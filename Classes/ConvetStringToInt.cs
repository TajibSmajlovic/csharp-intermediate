using System;

namespace Classes
{

    internal partial class Program
    {
        public class ConvetStringToInt
        {
            public static int Add(params int[] numbers)
            {
                var sum = 0;

                foreach (var number in numbers) sum += number;

                return sum;
            }

            public static void Parse(string text)
            {
                int number;

                bool isNumber = int.TryParse(text, out number);

                if (isNumber)
                    Console.WriteLine(number);
                else
                    throw new Exception("Text cannot be converted to int");
            }
        }
    }
}