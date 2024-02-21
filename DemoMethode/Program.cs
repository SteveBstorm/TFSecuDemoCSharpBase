namespace DemoMethode
{
    internal class Program
    {
        //procédure parce qu'elle ne retourne rien (void)
        

        static void Main(string[] args)
        {
            /*Objectif des méthodes : 
                Subdiviser mon programmes en micro programme réutilisable
             
             */
            MesOutils.maMethode("bidule");

            int result = 17 + MesOutils.addition(8, MesOutils.addition(10,17));
            Console.WriteLine(result);

            string s;
            Console.WriteLine(MesOutils.ExempleOut(out s));
            Console.WriteLine(s);

            int x;
            int.TryParse(s, out x);

            double tvac;
            double htva;
            htva = MesOutils.calculTotal(12, 42, out tvac);
            Console.WriteLine($"Total htva {htva}");
            Console.WriteLine($"Total tva comprise {tvac}");

            DateTime d = new DateTime();

            int i = 1;
            i.ToString()
        }
    }
}
