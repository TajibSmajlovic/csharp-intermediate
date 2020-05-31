using System;

namespace AssociationBetweenClasses
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddLink(string url)
        {
            Console.WriteLine("We added a link to" + url);
        }
    }
}