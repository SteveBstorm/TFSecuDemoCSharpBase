using System.Xml;

namespace DemoBoucle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exemple boucle
            //int i = 10;
            //bool flag = true;
            //while (i > 0 && flag)
            //{
            //    Console.WriteLine("coucou" + i);
            //    if (i == 5)
            //    {
            //        Console.WriteLine("Bidule");
            //        flag = false;

            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.WriteLine("for " + j);

            //        }
            //    }
            //    i--;
            //}
            //Console.WriteLine(i);

            //for (int max = 0; max < int.MaxValue; max++)
            //{
            //    if (max == 1000000000) Console.WriteLine("toto");
            //}
            //Console.Read();
            #endregion

            /*
             1) Definissez un mot de passe au préalable
                demander à l'utilisateur son mot de passe
                Si le mot de passe entré est correcte : Afficher "Bienvenue"
                Si l'utilisateur se trompe 3 fois, lui suggérer de rentrer chez lui

             2) A l'aide de boucle : 
                Afficher les tables de multiplication de 1 à 10

             3) Un magasin en ligne propose 3 articles
                Coca : 1€ (stock 4)
                Sandwich : 5€ (stock 2)
                Porte : 200€ (stock 3)

                Tant que l'utiliseur veut continuer ses achats, le programme
                continue à lui proposer la liste des articles en stock
                et lui demande de faire son choix (1 2 ou 3 )

                Quand il choisit d'arrêter, le programme affiche le total à payer
             */

            #region Exo 1

            // exo 1 
            //string mdpOK = "Test1234";
            //string mdpTest = "";
            //int nbTentative = 3;

            //while(mdpOK != mdpTest && nbTentative > 0) 
            //{
            //    Console.WriteLine("Entrez votre mot de passe");
            //    mdpTest = Console.ReadLine();
            //    nbTentative--;
            //    if(mdpOK != mdpTest && nbTentative != 0)
            //        Console.WriteLine($"T'as foiré il te reste {nbTentative} tentatives");

            //}

            //Console.WriteLine((mdpOK == mdpTest) ? "Bienvenue" : "Rentre chez toi"); 
            #endregion

            //Exo 2

            //Console.WriteLine("Table de multiplication");
            //Console.WriteLine("-----------------------");

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Table de {i}");
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} X {j} = {i*j}");
            //    }
            //    Console.WriteLine();
            //}

            //exo 3
            #region Exo 3
            //    int total = 0;
            //    int stockCoca = 4;
            //    int stockSandwich = 2;
            //    int stockPorte = 3;
            //    int choix;
            //    bool contiuer = true;

            //    while (contiuer)
            //    {

            //        if (stockCoca > 0) Console.WriteLine("1. Coca : 1 euro");
            //        if (stockSandwich > 0) Console.WriteLine("2. Sandwish : 5 euro");
            //        if (stockPorte > 0) Console.WriteLine("3. Porte : 200 euro");
            //        Console.Write("Faites votre choix (pour quitter tapez 4) : ");

            //        choix = int.Parse(Console.ReadLine());

            //        switch (choix)
            //        {
            //            case 1:
            //                if (stockCoca > 0)
            //                {
            //                    total += 1;
            //                    stockCoca--;
            //                }
            //                else Console.WriteLine("Plus en stock");
            //                break;
            //            case 2:
            //                if (stockSandwich > 0)
            //                {
            //                    total += 5;
            //                    stockSandwich--;
            //                }
            //                else Console.WriteLine("Plus en stock");
            //                break;
            //            case 3:
            //                if (stockPorte > 0)
            //                {
            //                    total += 200;
            //                    stockPorte--;
            //                }
            //                else Console.WriteLine("Plus en stock");
            //                break;
            //            case 4:
            //                contiuer = false;
            //                break;
            //            default:
            //                Console.WriteLine("C'est 1 2 3 ou 4 abruti");
            //                break;
            //        }

            //    }
            //    Console.WriteLine($"Vous nous devez {total} Euros");
            //    Console.WriteLine("Merci pour votre visite abruti");
            #endregion


            int[] tableau = new int[5];

            tableau[0] = 2;
            tableau[1] = 3;
            tableau[3] = 4;
            tableau[4] = 5;
            tableau[2] = 42;

            //string s = "salut";

            //foreach(char c in s)
            //{
            //    //c = 'a';
            //    Console.WriteLine(c);
            //}

            //for(int i = 0; i< s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            //for (int i = 0; i < tableau.Length; i++)
            //{
            //    if (tableau[i] > 10) tableau[i] = 10;
            //    Console.WriteLine(tableau[i]);
            //}

            //foreach (int i in tableau)
            //{
            //    i = 5;
            //    Console.WriteLine(i);
            

            
        }
    }
}
