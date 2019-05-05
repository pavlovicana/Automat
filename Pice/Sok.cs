using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pice
{
    public class Sok : Pice
    {
        public Sok(string ime) : base(ime)
        {

        }
        
        public override int Sipaj()
        {
            Kolicina_pica = 10;
            return Kolicina_pica;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("\nIme: " + Ime_pica + "\nKolicina: " + Sipaj() + " cl");
        }


    }
}
