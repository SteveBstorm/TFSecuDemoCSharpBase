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


            /*
             Un magasin en ligne propose 3 articles
                Coca : 1€ (stock 4)
                Sandwich : 5€ (stock 2)
                Porte : 200€ (stock 3)

                Tant que l'utiliseur veut continuer ses achats, le programme
                continue à lui proposer la liste des articles en stock
                et lui demande de faire son choix (1 2 ou 3 )

                Quand il choisit d'arrêter, le programme affiche le total à payer
             
                L'affichage des articles (stocké dans une collection) 
                se fera à l'aide d'une méthode (void)

                Le panier du client doit également être stocké dans une collection 

                le retrait d'un article du stock se fait via méthode

                créer une méthode qui calcule le total des achats
             */
        }
    }
}
