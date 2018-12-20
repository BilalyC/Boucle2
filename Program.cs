using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 10)// execution de la boucle tant que counter est inférieur ou égal à 10
            {
                Console.WriteLine("Bonjour, je suis le message n°" + counter + ".");
                counter++;//incrémentation de la boucle
            }
        }
    }
}
