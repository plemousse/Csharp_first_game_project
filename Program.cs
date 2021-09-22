using System;

namespace firstgane
{
    class Program
    {
        static int nbreEssais = 5;
        static int range = 51;
        const int essaie = 5;
        static int nbreChoisi = 0;
        static bool devIsOn = false;
        static bool WinOn = false;
        //static bool gameOn = false;
        static bool isApplicationOn = true;
        static bool rdnStatus = false;
        static int chiffreMystereRandom;
        static void Main(string[] args)
        {
            Update();
        }
        static void Update()  // retour nomFonction variable, (type variable1, type variable2)
        {
            while (isApplicationOn)
            {

                while (Program.nbreEssais >= 1 && !WinOn)
                {
                    if (!rdnStatus)
                    {
                        //affiche le titre du jeu
                        Console.WriteLine("***************************");
                        Console.WriteLine("****** Jeu du + / - ******");
                        Console.WriteLine("*************************");

                        //genere un entier aleatoire entre 0 et 50
                        Random rnd = new Random();
                        chiffreMystereRandom = rnd.Next(range);
                        rdnStatus = true;

                        //debug
                        if (devIsOn) { Console.WriteLine("Le chiffre mystere est " + chiffreMystereRandom); }
                    }

                    //demande un chiffre a l'utilisateur
                    Console.WriteLine("trouver le nombre entre 0 et " + (range-1));

                    //met en pause le programme et attend un input
                    string stringRecu = Console.ReadLine();

                    if (isNumeric(stringRecu))
                    {
                        nbreChoisi = Convert.ToInt32(stringRecu);
                        //affichage console

                        Console.WriteLine("Vous avez choisi  : " + nbreChoisi);
                        nbreEssais--;

                        if (nbreEssais >= 0 && nbreChoisi == chiffreMystereRandom)
                        {
                            Console.WriteLine("Vous avez gagner !");
                            WinOn = true;
                        }
                        else if (nbreChoisi != chiffreMystereRandom && nbreEssais >= 1)
                        {
                            Console.WriteLine("Il vous reste " + nbreEssais + " d'essais");
                            Console.WriteLine("Rejouer...");
                            indice();


                        }
                        else if (nbreEssais <= 0 && nbreChoisi != chiffreMystereRandom)
                        {
                            Console.WriteLine("Il vous reste auccun d'essais");
                            Console.WriteLine("LOOSE");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Emter des chiffre pas des lettre !!!!!!!!");
                    }
                }

                restart();
            }
        }
        static bool isNumeric(string value)
        {
            bool isNumeric = false;
            isNumeric = int.TryParse(value, out nbreChoisi);
            return isNumeric;
        }
        static void restart()
        {

            if (devIsOn)
            {
                Console.WriteLine("Tu est de vuloir garder le dev mod 1 / 0");

                //met en pause le programme et attend un input
                string devCheck = Console.ReadLine();

                if (isNumeric(devCheck))
                {
                    int choice = Convert.ToInt32(devCheck);
                    if (choice == 1)
                    {
                        Console.WriteLine("ok");
                    }
                    else if (choice == 0)
                    {
                        devIsOn = false;
                    }


                }
                else
                {
                    Console.WriteLine("Emter des chiffre pas des lettre !!!!!!!!");
                }

            }
            if (Program.nbreEssais < 1 || WinOn)
            {
                Console.WriteLine("Voulez vous continuer a jouer ?");
                Console.WriteLine("Taper sur 1 pour continuer sinon taper sur 0 ?");
                //met en pause le programme et attend un input
                string endGame = Console.ReadLine();

                if (isNumeric(endGame))
                {
                    int gameOn = Convert.ToInt32(endGame);


                    if (gameOn == 1)
                    {
                        WinOn = false;
                        nbreEssais = essaie;
                        rdnStatus = false;

                        Console.WriteLine("c'est partie");
                    }

                    else if (gameOn == 0)
                    {
                        isApplicationOn = false;
                        Console.WriteLine("ADIEU");
                    }

                    else if (gameOn < 0 || gameOn > 1)
                    {
                        Console.WriteLine("entre 0 et 1 s'il te plait");
                        if (gameOn == 42)
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine("******** Dev menu ********");
                            Console.WriteLine("*************************");

                            Console.WriteLine("veux tu activer le dev mod 0 / 1");
                            string devWrite = Console.ReadLine();

                            if (isNumeric(devWrite))
                            {
                                int devOn = Convert.ToInt32(devWrite);

                                if (devOn == 1)
                                {
                                    WinOn = false;
                                    nbreEssais = essaie;
                                    rdnStatus = false;
                                    devIsOn = true;
                                    Console.WriteLine("cheat activer");
                                }
                                else
                                {
                                    Console.WriteLine("pas de dev mod");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Emter des chiffre pas des lettre !!!!!!!!");
                            }

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Emter des chiffre pas des lettre !!!!!!!!");
                }
            }
        }
        static void indice()
        {
            if (nbreChoisi < chiffreMystereRandom)
                Console.WriteLine("C'est plus");
            else
                Console.WriteLine("C'est mois");
        }

    }
}
