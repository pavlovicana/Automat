using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pice
{
  
    class Koktel : Pice
    {
       
        public Koktel(string ime) : base(ime)
        {
            
        }
        
        public void Koktel_1(Sok s, Zestina z)
        {

            int ukupno;
            int sok = s.Sipaj();
            int zestina = z.Sipaj();

            ukupno = sok + zestina;

            Console.WriteLine("\n***KOKTEL_1: 1 SOK + 1 ZESTINA***");
            Console.WriteLine("\n\tIme soka: " + s.Ime_pica);
            Console.WriteLine("\tIme zestine: " + z.Ime_pica);
            Ukupno_pice(ukupno);          
        }


        public void Koktel_2(Sok s1, Sok s2, Zestina z1)
        {
            int ukupno;
            int sok1 = s1.Sipaj();
            int sok2 = s2.Sipaj();
            int zestina = z1.Sipaj();

            ukupno = sok1 + sok2 + zestina;

            Console.WriteLine("\n***KOKTEL_2: 2 SOKA + 1 ZESTINA***");
            Console.WriteLine("\n\tIme prvog soka: " + s1.Ime_pica);
            Console.WriteLine("\tIme drugog soka: " + s2.Ime_pica);
            Console.WriteLine("\tIme zestine: " + z1.Ime_pica);
            Ukupno_pice(ukupno);
        }

        public void Koktel_3(Sok s1, Sok s2, Sok s3)
        {
            int ukupno;
            int sok1 = s1.Sipaj();
            int sok2 = s2.Sipaj();
            int sok3 = s3.Sipaj();

            ukupno = sok1 + sok2 + sok3;

            Console.WriteLine("\n***KOKTEL_3: 3 SOKA***");
            Console.WriteLine("\n\tIme prvog soka: " + s1.Ime_pica);
            Console.WriteLine("\tIme drugog soka: " + s2.Ime_pica);
            Console.WriteLine("\tIme treceg soka: " + s3.Ime_pica);
            Ukupno_pice(ukupno);
        }

        public void Ukupno_pice(int u)
        {      
            Console.WriteLine("\tUkupna kolicina pica: " + u + " cl");
        }
      
    }
}
