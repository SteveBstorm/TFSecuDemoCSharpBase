﻿using System.Globalization;

namespace DemoCSharpBase
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();

            //DateTime today = new DateTime();
            //int x = int.Parse(s);

            ////x.ToString();

            //object o = "toto";



            //x = (string)o + 3;

            //Console.WriteLine(x);

            //Console.WriteLine($"La date du \n jour est \t{today}");

            //int x, y;
            //Console.Write("Entrez nombre 1 : ");
            //jour = int.Parse(Console.ReadLine());
            //Console.Write("Entrez nombre 2 : ");
            //mois = int.Parse(Console.ReadLine());

            //Console.WriteLine(x/y);
            //Console.WriteLine(x%y);
            //Console.WriteLine((float)x / y);

            //demander la date de naissance a l'utilisateur
            //calculer son age actuel
            //afficher

            int jour, mois, annee;

            Console.Write("Jour ? ");
            jour = int.Parse(Console.ReadLine());

            Console.Write("Mois ? ");
            mois = int.Parse(Console.ReadLine());

            Console.Write("année ? ");
            annee = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(2024, 02, 16);

            DateTime dateNaissance = new DateTime(annee,mois,jour);
            DateTime date2 = DateTime.Now;

            //int age = date2.Year - dateNaissance.Year;           
            //Console.WriteLine(age);

            //Console.WriteLine(dateNaissance);
            TimeSpan s = date2.Subtract(dateNaissance);

            int ageOk = (int)(s.TotalDays / 365.25);
            Console.WriteLine(ageOk);


            if(ageOk >= 18 && ageOk < 67)
            {
                Console.WriteLine("Tu peux travailler");
                if(ageOk >= 21) Console.WriteLine("Tu peux perdre tout ton fric au casino");
            }
            else
            {
                if(ageOk < 18) Console.WriteLine("Retourne à l'école gamin");
                if(ageOk >= 67) Console.WriteLine("Tu peux enfin profiter de ta jeunesse");
            }

            string role = "admin";

            switch(role)
            {
                case "admin":
                    Console.WriteLine("T'as tout les droits");
                    break;
                case "modo":
                    Console.WriteLine("Tu peux ban les boulets");
                    break;
                case "user":
                    Console.WriteLine("Tu peux jouer");
                    break;
                default:
                    Console.WriteLine("Role inexistant");
                    break;
            }

            // if (condition dans la paranthèse) ? true : false
            string reponse = (role == "admin") ? "Tu peux tout faire" : 
                (role == "modo") ? "j'ai des droit" : "je peux juste jouer";

            if(role == "admin")
            {
                reponse = "Tu peux tout faire";
            }
            else
            {
                reponse = "Tu peux juste jouer";
            }

            Console.WriteLine(reponse);



        }
    }
}