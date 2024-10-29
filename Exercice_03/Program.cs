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
            using System;
                // Exemple d'utilisation
                int borneInf = 3;
                int borneSup = 100;
                int nombrePairs = CompterNombresPairs(borneInf, borneSup);
                Console.WriteLine($"Le nombre de nombres pairs entre {borneInf} et {borneSup} est : {nombrePairs}");

            static int CompterNombresPairs(int borneInf, int borneSup)
            {
                // Initialisation du compteur
                int compteur = 0;

                // On commence à la première valeur après la borne inférieure
                for (int i = borneInf + 1; i < borneSup; i++)
                {
                    // Vérification si le nombre est pair
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
}
