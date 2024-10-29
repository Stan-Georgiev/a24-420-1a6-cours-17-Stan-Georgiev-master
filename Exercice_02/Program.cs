/* Description de l'algorithme
 * 
 * PRENOM NOM
 * DATE
 */
using System.ComponentModel;

namespace Exercice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2. Concevez un algorithme qui doit conserver la position en x et en y d’un joueur dans un jeu en 2D. 
             * Demandez au joueur s’il désire se déplacer au nord, à l’est à l’ouest, au sud ou de dormir. 
             * Affichez la nouvelle position sous le format « (x,y) » et si le joueur décide de dormir le programme s’arrête.
             */
            string direction;
            const string sentinelle = "fin";
            int y = 0;
            int x = 0;

            while (true)
            {
                Console.WriteLine("Aller-vous nord,ouest,est ou sud? type fin pour conclure");
                direction = Console.ReadLine();
                if (direction == sentinelle)
                    {
                        break;
                    }
                else if (direction == "nord")
                    {
                        y++;
                    Console.WriteLine($"Les coordonée du joueur sont ({x},{y})");
                    }
                else if (direction == "sud")
                    {
                        y--;
                    Console.WriteLine($"Les coordonée du joueur sont ({x},{y})");
                    }
                else if (direction == "est")
                    {
                       x++;
                    Console.WriteLine($"Les coordonée du joueur sont ({x},{y})");
                    }
                else if (direction == "ouest")
                    {
                      x--;
                    Console.WriteLine($"Les coordonée du joueur sont ({x},{y})");
                    }
            }
            Console.WriteLine($"Les coordonée du joueur sont ({x},{y})");


        }
    }
}
