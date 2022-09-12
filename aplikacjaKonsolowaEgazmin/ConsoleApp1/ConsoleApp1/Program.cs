using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba= new Osoba(1,"kinga");
            osoba.PodajImie("kasia");
            Console.ReadLine();
            Osoba osoba2 = new Osoba();
            osoba2.PodajImie("Maga");
            Console.ReadLine();
        }
    }
}
