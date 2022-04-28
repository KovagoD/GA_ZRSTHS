using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetikus
{
    class Program
    {
        static void Kiir(GA ga, int iter)
        {
            Console.WriteLine("Iterációszám: {0}", iter);
            for (int i = 0; i < 15; i++)
            {
                ga.Populacio[i].Kiir(ga.Celertek);
            }
            Console.WriteLine("-------------------");
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            GA ga = new GA(49);

            int iter = 0;
            Kiir(ga, iter);
            do
            {
                ga.JosagszamitasSzelekcio();

                Kiir(ga, iter);

                ga.Keresztezodes();
                ga.Mutacio();

                iter++;
            } while (iter < 500);
        }
    }
}
