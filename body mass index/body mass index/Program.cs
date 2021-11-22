using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace body_mass_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kilo değerinizi giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("boy değerinizi girin");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("zayıfsın ha");
                Console.ReadLine();
            }

            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("normalsın");
                Console.ReadLine();
            }

            else if (bke > 25)
            {
                Console.WriteLine("obezsin pis obez seni");
                Console.ReadLine();
            }


        }
    }
}
