using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class telefon
    {
        private string marka;
        private string model;
        private int ilosc_ram
        {
            get { return ilosc_ram; } 
            set {ilosc_ram = value; }
        }
        private string login_konta;
        public static void procesor()
        {
            Console.WriteLine("Procesor: jakiś");
        }

        public telefon(string marka, string model, int ilosc_ram)
        {
            this.marka = marka;
            this.model = model;
            this.ilosc_ram = ilosc_ram;
        }

        public string getLogin()
        {
            return login_konta;
        }
        public void setLogin(string login)
        {
            login_konta = login;
        }
        public void view()
        {
            Console.WriteLine("marka: {0}, model: {1}, ilosć ram: {2}",marka,model,ilosc_ram);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            telefon.procesor();
            telefon t1 = new telefon("Iphone", "14", 12);
            t1.view();
            t1.setLogin("terminator");

            Console.ReadKey();
        }
    }
}
