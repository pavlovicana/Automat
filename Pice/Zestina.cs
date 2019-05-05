using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pice
{
    enum duzina { krace = 1, duze = 2};
    public class Zestina : Pice
    {

        private int x = (int)duzina.krace;
        private int y = (int)duzina.duze;

        public Zestina(string ime, int kolicina) : base(ime)
        {
            Kolicina_pica = kolicina;
        }

        public override int Sipaj()
        {

            if(Kolicina_pica == 1)
            {
                Kolicina_pica = x;
            }
            else
            {
                Kolicina_pica = y;
            }

            return Kolicina_pica;
        }

 
        public override void ShowDetails()
        {
            Console.WriteLine("\nIme: " + Ime_pica + "\nKolicina: " + Sipaj() + " cl");
        }

    }
}
