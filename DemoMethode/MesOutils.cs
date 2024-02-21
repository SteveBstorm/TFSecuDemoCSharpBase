using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethode
{
    internal static class MesOutils
    {
        internal static void maMethode(string nom)
        {
            Console.WriteLine($"Hello {nom}! the result is : {addition(5,5, 3)}");
        }

        //function qui demande un type de retour
        internal static int addition(int a, int b, int c = 10)
        {
            //maMethode();
            return a + b + c;
        }

        internal static string ExempleOut(out string nom)
        {
            nom = "steve";
            return $"Bonjour {nom}";
        }

        internal static double calculTotal(out double totalTVAC, params int[] ints)
        {
            double total = 0;
            foreach (double valeur in ints)
            {
                total += valeur;
            }
            totalTVAC = total * 1.21;
            return total;
        }

        internal static double calculTotal(out double totalTVAC, params double[] d)
        {
            double total = 0;
            foreach(double valeur in d)
            {
                total += valeur;
            }
            totalTVAC = total * 1.21;
            return total;
        }

    }
}
