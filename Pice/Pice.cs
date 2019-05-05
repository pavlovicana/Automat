using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pice
{
        public class Pice { 
    
        protected string ime_pica;
        protected int kolicina_pica;

        public virtual string Ime_pica
        {
            get { return ime_pica; }
            set { ime_pica = value; }
        }

        public virtual int Kolicina_pica
        {
            get { return kolicina_pica; }
            set { kolicina_pica = value; }
        }

        public Pice()
        {

        }
        public Pice(string ime)
        {
            ime_pica = ime;
            //kolicina_pica = kolicina;
        }

        public virtual int Sipaj()
        {
            return Kolicina_pica;
        }
       
        public virtual void ShowDetails()
        {
            Console.WriteLine("Ime: " + Ime_pica + "\nKolicina: " + Kolicina_pica);
        }

    }
}
