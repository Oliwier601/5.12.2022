using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacja
{
    class auto
    {
        private string color;
        private int rok;
        private silnik silnik;
        private radio radio;
        public void jedz()
        {
            Console.WriteLine("Jedź....");
        }
        public void napraw()
        {
            Console.WriteLine("Naprawiam....");
        }
        public void setSilnik(silnik silnik)
        {
            this.silnik = silnik;
        }
        public void getRadio(radio radio)
        {
            this.radio = radio;
        }
    }
    class silnik
    {
        private int pojemność;
        private int moc;
        public void start()
        {
            Console.WriteLine("Startyję....");
        }
        public void stop()
        {
            Console.WriteLine("Kończe prace....");
        }
    }
    class radio
    {
        private string marka;
        private string model;
        public void graj()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
