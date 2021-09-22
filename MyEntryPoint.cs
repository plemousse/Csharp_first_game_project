using System;

namespace firstgane
{
    class MyEntryPoint
    {
        //static int nbreEssais = 3;
        //static bool WinOn = false;
        //static bool gameOn = false;
        static bool isApplicationOn = true;
        static void lMain(string[] args)
        {
            while (isApplicationOn)
            {
                Console.WriteLine("Choisissez une action (1 a 3)");
                string stringRecu = Console.ReadLine();//met pause le programme et attend un input
                int indiceActionChoisie = Convert.ToInt32(stringRecu);

                switch (indiceActionChoisie)
                {
                    case 1:
                        sayHello();
                        break;
                    case 2:
                        saySomething("hey !");
                        break;
                    case 3:
                        Console.WriteLine("Est ce un jour BONUS ?? " + isBonusDay());
                        break;
                    case 0:
                        isApplicationOn = false;
                        break;
                    default:
                        Console.WriteLine("choisisez un autre chiffre");
                        break;

                }
            }
        }

        //retour nomFonction (type variable1, typt variable2)
        static void sayHello()
        {
            Console.WriteLine("HELLO!");
        }

        static void saySomething(string message)
        {
            Console.WriteLine(message);
        }

        static bool isBonusDay()
        {
            Random rnd = new Random();
            int bonusCode = rnd.Next(2);//chiffre entre 0 et 1
            bool bonusDay = bonusCode == 0 ? false:true;// operateur ternaire
            return bonusDay;
        }
    }
}