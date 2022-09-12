using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osoba
    {
        private int id { get; set; }
        private string imie { get; set; }
        public static int ileInstancji = 0;

        
        public Osoba()
        {
            this.id = 0;
            this.imie ="";
            ileInstancji++;
        }
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            ileInstancji++;
        }
        public Osoba(Osoba osoba)
        {
            this.id=osoba.id;
            this.imie = osoba.imie;
            ileInstancji++;
        }
        public void PodajImie(String imie)
        {
            if(this.imie == "")
            {
                Console.WriteLine("brak danych");
            }
            else
            Console.WriteLine("Czejsć"+imie+",mam na imie " +this.imie);
        }
    }
   
}
