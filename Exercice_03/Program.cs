/* Description de l'algorithme
 * 
 * PRENOM NOM
 * DATE
 */
namespace Exercice_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemple d'utilisation
                Console.WriteLine("Veuiller saisir la borne minimale");
                int borneInf  = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Veuiller saisir la borne Maximale");
                int borneSup = Convert.ToInt32(Console.ReadLine());

                int nombrePairs = CompterNombresPairs(borneInf, borneSup);
                Console.WriteLine($"Le nombre de nombres pairs entre {borneInf} et {borneSup} est : {nombrePairs}");

            static int CompterNombresPairs(int borneInf, int borneSup)
            {
                
                int compteur = 0;

                
                for (int i = borneInf + 1; i < borneSup; i++)
                {
                    
                    if (i % 2 == 0)
                    {
                        compteur++;
                    }
                }

                return compteur;
            }
        }

    }
}

