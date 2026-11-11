using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro262
{
    internal class Menu
    {
        private string[] story;
        public void Execute()
        {
            story = new string[10];
            story[0] = "Hola!";
            story[1] = "Bienvenido a esta aventura";
            story[2] = "¿Cómo te llamas?";
            story[3] = "Hola ";
            story[4] = "Hoy entrarás al bosque";
            story[5] = "Te encuentras un objeto";
            story[6] = "Lo recoges";
            story[7] = "Lo revisas bien";
            story[8] = "Explota";
            story[9] = "Moriste, fin del juego";

            string name = "1";
            for(int i=0; i < story.Length; i++)
            {
                switch(i)
                {
                    case 2:
                        Console.WriteLine(story[i]);
                        name = ReadName();
                        break;
                    case 3:
                        Console.WriteLine(story[i] + name);
                        break;
                    default:
                        Console.WriteLine(story[i]);
                        break;
                }
                Console.WriteLine("Presiona una tecla para continuar...");
                Console.ReadKey();
            }
        }

        private string ReadName()
        {
            return Console.ReadLine();
        }
    }
}
