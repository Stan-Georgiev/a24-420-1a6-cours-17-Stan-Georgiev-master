/* Description de l'algorithme
 * 
 * PRENOM NOM
 * DATE
 */
namespace Exercice_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. Concevez un algorithme qui demande à l’utilisateur de saisir une série de nombres et 
             * affichez la somme de ces nombres. Utilisez une sentinelle pour arrêter le traitement.
             */
            int total = 0;

            while (true)
            {
                Console.WriteLine("Veuiller Saisir un numero ou 0 pour conclure");
                int nombre = Convert.ToInt32(Console.ReadLine());

                total = total + nombre; 

                    if (nombre == 0)
                        {
                            break;
                        }
                Console.WriteLine($"Le total est {total}");
            }


        }
    }
}
