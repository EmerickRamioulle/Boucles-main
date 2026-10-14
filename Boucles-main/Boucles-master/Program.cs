namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        // Étape 1 : faire un compteur qui va de 1 à 10

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Étape 2 : faire un décompte qui va de 5 à 1 puis qui dit Bonne année !

        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Bonne année !");

        // Étape 3 : faire un compteur qui va de -4 à 2

        for (int i = -4; i <= 2; i++)
        {
            Console.WriteLine(i);
        }

        // Étape 4 : faire un compteur qui compte 2 par 2 de 0 à 15


        for (int i = 0; i <= 15; i += 2)
        {
            Console.WriteLine(i);
        }

        // Étape 5 : faire une boucle qui se répète à chaque fois que l utilisateur écrit autre chose que oui

        string reponse;
        do
        {
            Console.Write("Voulez-vous arrêter ? (Écrivez oui pour quitter) ");
            reponse = Console.ReadLine();
        } while (reponse != "oui");
        Console.WriteLine("Merci ! La boucle est terminée");
    }
}