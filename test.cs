using System;

namespace firstgane
{
    class Test
    {
        static string[] jours = new string[] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
        static void kMain(string[] args)
        {
            Console.WriteLine("bob " + jours[0]);
            Console.WriteLine("bob2 " + jours.Length);
            Console.WriteLine("bob2 " + jours[jours.Length - 1] + '\n');


            //boucle foreach
            foreach(string jour in jours)
            {
                Console.WriteLine(" on lit une cellule " + jour);
            }


            for (int i = 0; i < jours.Length; i++)
            {
                jours[i] = "bob";
                Console.WriteLine("cellule " + i + " " + jours[i]);
            }

            foreach(string jour in jours)
            {
                Console.WriteLine(" on lit une cellule " + jour);
            }            

        }
    }
}