using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozycja
{
    class liver
    {
        private int weight;
        private string color;
    }
    class heart
    {
        private int weight;
        private string condition;
    }
    class body
    {
        private liver liver;
        private heart heart;
        public body(liver aliver, heart aheart)
        {
            this.liver = aliver;
            this.heart = aheart;
        }
        public void eat()
        {
            Console.WriteLine("Mniam mniam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            liver l1 = new liver();
            heart h1 = new heart();
            body b1 = new body(l1, h1);
        }
    }
}
