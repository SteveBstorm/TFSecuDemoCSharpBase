using System.Collections;
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
            // foreach(int i in tableau)
            //{
            //    Console.WriteLine(i);
            //}
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
            #region Déplacer un curseur
            //string[,] position = new string[10, 10];
            //int posX, posY;

            //int posXCurrent = 5;
            //int posYCurrent = 5;

            //while (true)
            //{
            //    for (int x = 0; x < 10; x++)
            //    {
            //        for (int y = 0; y < 10; y++)
            //        {
            //            Console.Write("|");
            //            position[x, y] = "_";
            //            if (x == posXCurrent && y == posYCurrent)
            //            {
            //                position[x, y] = "P";
            //            }
            //            Console.Write(position[x, y]);
            //            Console.Write("");
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("Direction ? Z Q S D");
            //    ConsoleKeyInfo info = Console.ReadKey();

            //    switch (info.Key)
            //    {
            //        case ConsoleKey.Z:
            //            if (posYCurrent > 0)

            //                posYCurrent -= 1;
            //            break;

            //        case ConsoleKey.Q:
            //            if(posXCurrent > 0)
            //            posXCurrent -= 1;
            //            break;
            //        case ConsoleKey.S:
            //            if(posYCurrent < 9)
            //                posYCurrent += 1;
            //            break;
            //        case ConsoleKey.D:
            //            if(posXCurrent < 9)
            //                posXCurrent += 1;
            //            break;

            //    }
            //    Console.Clear(); 
            #endregion

            #region Exemple ArrayList
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(tableau);
            //arrayList.Add("steve");
            //arrayList.Add(new DateTime());

            //Console.WriteLine(arrayList[1]);

            //foreach (var x in arrayList)
            //{
            //    switch (x)
            //    {
            //        case int[] t:
            //            break;
            //        case string s:
            //            Console.WriteLine(s);
            //            break;
            //        case DateTime dt:
            //            Console.WriteLine(dt);
            //            break;
            //    }
            //    Console.WriteLine(x.ToString());
            //} 
            #endregion

            #region Exemple List
            //List<int> list = new List<int>();
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}


            //list.Add(5);
            //list.AddRange(tableau);


            //Console.WriteLine(list[3]);

            ////list.RemoveAll(albert => albert == 5);

            //Console.WriteLine(list.Count());

            //Console.WriteLine();



            //foreach (int i in list.OrderByDescending(element => element))
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion


            #region DemoCollection
            //Dictionary<string, DateTime> dateNaissance = new Dictionary<string, DateTime>();

            //dateNaissance.Add("Toto", DateTime.Now);
            //dateNaissance.Add("Arthur", new DateTime(1212, 12, 12));
            //dateNaissance.Add("Merlin", new DateTime(1111, 11, 11));

            //Console.WriteLine(dateNaissance["Toto"]);

            //dateNaissance["Toto"] = new DateTime(1983, 06, 28);

            //foreach (KeyValuePair<string, DateTime> dt in dateNaissance)
            //{
            //    Console.WriteLine(dt.Key);
            //    Console.WriteLine(dt.Value);
            //}


            //Dictionary<int, string> truc = new Dictionary<int, string>();

            //truc.Add(69, "Année érotique");
            //truc.Add(1234, "Année érotique");
            //truc.Add(truc.Count(), "Année érotique");
            //truc.Add(truc.Count(), "Année érotique");
            //truc.Add(truc.Count(), "Année érotique");
            //truc.Add(truc.Count(), "Année érotique");

            ////Queue<string> queue = new Queue<string>();
            ////queue.Enqueue("Steve");
            ////queue.Enqueue("Kevinou");
            ////queue.Enqueue("Alba");

            ////string client = queue.Dequeue();
            ////Console.WriteLine(client);
            ////client = queue.Peek();
            ////Console.WriteLine(client);

            //Stack<string> s = new Stack<string>();

            //s.Push("Kevinou");
            //s.Push("Alba");
            //s.Push("Elean");

            //string user = s.Pop();
            //Console.WriteLine(user);
            //Console.WriteLine(s.Peek());
            //s.Pop();
            //Console.WriteLine(s.Peek()); 
            #endregion


        }

    }
}

