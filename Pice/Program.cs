using Pice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\t\t***PICA***");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\n\tSokovi (svi po 10cl): \n\tFanta, Djus, Coca-Cola\n\n\tZestina (kraci: 1 cl, dupli: 2cl): \n\tVodka, Rum, Tekila, Dzin");

            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\t\t***NARUCENA PICA***");
            Console.WriteLine("----------------------------------------------------------");


            Sok s1 = new Sok("Djus");
            s1.Sipaj();
            s1.ShowDetails();

            Sok s2 = new Sok("Fanta");
            s2.Sipaj();
            s2.ShowDetails();

            Sok s3 = new Sok("Coca-cola");
            s3.Sipaj();
            s3.ShowDetails();

            Zestina z1 = new Zestina("Vodka", 2);
            z1.Sipaj();
            z1.ShowDetails();

            Zestina z2 = new Zestina("Rum", 1);
            z2.Sipaj();
            z2.ShowDetails();


            Console.WriteLine("\n\t\t***KOKTELI***");
            Console.WriteLine("----------------------------------------------------------");

            Koktel k1 = new Koktel("Blue Lagoon");
            k1.Koktel_1(s2, z1);

            Koktel k2 = new Koktel("Cuba Libre");
            k2.Koktel_2(s1, s2, z2);

            Koktel k3 = new Koktel("Fruity");
            k3.Koktel_3(s3, s2, s1);


        }
    }
}
