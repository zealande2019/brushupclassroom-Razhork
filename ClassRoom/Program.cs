using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum mitKlasseRum = new KlasseRum();

            mitKlasseRum.KlasseNavn = "3B";
            mitKlasseRum.SemesterStart = new DateTime(2018, 4, 9);

            mitKlasseRum.KlasseListe = new List<Studerende>(32);
            mitKlasseRum.KlasseListe.Add(new Studerende("Marcel", 1, 26));
            mitKlasseRum.KlasseListe.Add(new Studerende("Simon", 3, 9));
            mitKlasseRum.KlasseListe.Add(new Studerende("Sofus", 7, 14));


            Console.WriteLine($"Klassenavnet er {mitKlasseRum.KlasseNavn} og semesteret startede {mitKlasseRum.SemesterStart}");
            Console.ReadLine();
          {
        }
    }
  }
}
