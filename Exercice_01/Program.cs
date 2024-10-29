/* Description de l'algorithme
 * 
 * PRENOM NOM
 * DATE
 */
namespace Exercice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Concevez un algorithme qui demande à l’utilisateur de saisir une série de nombres et 
             * affichez la somme de ces nombres. Utilisez une sentinelle pour arrêter le traitement.
             */
            int nombre;
            int total = 0;
            const int Sentinelle= 0;

            while (true)
            {
                Console.WriteLine("Veuiller Saisir un nombre ou 0 pour finir");
                nombre = Convert.ToInt32(Console.ReadLine());
                total = total + nombre;
                Console.WriteLine($"Le total est {total}");
                
                if (nombre == Sentinelle)
                {
                    break;
                }
            }
            Console.WriteLine($"Le total est {total}");
        }   
    }
}
