using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardb {
    class Program {
        static void NastavAVypisAuto() {
            Console.Write("napiste typ vozu: ");
            string znacka = Console.ReadLine();

            Console.Write("napiste rok vyroby: ");
            int rok = Int32.Parse(Console.ReadLine());

            List<String> vlastnici = new List<string>();

            string podminka = "konec";
            string vlastnik;
            do {
                Console.Write("zadej vlastnika nebo konec: ");
                vlastnik = Console.ReadLine();
                if (vlastnik != podminka)
                    vlastnici.Add(vlastnik);

            } while (vlastnik != podminka);


            Console.WriteLine(znacka + ", " + rok);
            foreach (string vlast in vlastnici) {
                if (vlast != vlastnici.Last())
                    Console.Write(vlast + ", ");
                else
                    Console.Write(vlast);
            }
            Console.WriteLine();
        }

        static void Main() {
            Console.WriteLine("Vitejte v databazi aut.");
            string uvitani = "nyni databaze obsahuje ";
            int pocetAut = 20;
            string auta = " aut";

            for (int i = 0; i < 1; i++) {
                Console.WriteLine(uvitani + pocetAut + auta);
                pocetAut++;
            }
            Console.WriteLine();
            NastavAVypisAuto();
            NastavAVypisAuto();

           

            Console.ReadKey();
            
        }


    }
}
