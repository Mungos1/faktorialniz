using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktorialNiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[5];
            

            Console.WriteLine("Unesite niz od 5 brojeva");
            
            for (int i = 0; i<5; i++)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
                
              }

            int najveciBroj = niz[1];
            
            for (int i =0; i<5; i++)
            {
                if (najveciBroj < niz[i])
                {
                    najveciBroj = niz[i];

                }
            }

            int najmanjiBroj = niz[1];

            for (int i = 0; i < 5; i++)
            {
                if (najmanjiBroj > niz [i])
                {
                    najmanjiBroj = niz[i];
                }
            }


            Console.WriteLine("Najveci broj je {0}, a najmanji {1}", najveciBroj, najmanjiBroj);
            Console.WriteLine("Izracunat cemo faktorial broja {0} i {1}", najveciBroj, najmanjiBroj);

            int f1 = 1;
            int f2 = 1;

            for (int i=1; i<= najveciBroj; i++)
            {
                f1 = f1 * i;
            }

            for (int i=1; i<=najmanjiBroj; i++ )
            {
                f2 = f2 * i;
            }

            Console.WriteLine("Faktorial najveceg broja u nizu je {0}, a najmanjeg je {1}", f1, f2);
            Console.ReadLine();
            

        }
    }
}
