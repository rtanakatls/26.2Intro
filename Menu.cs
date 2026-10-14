using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro262
{
    internal class Menu
    {
        public void Execute()
        {
            Console.WriteLine("Hola");
            string name = GetName();
            Console.WriteLine($"Hola veo que te llamas {name}");
        }

        private string GetName()
        {
            Console.WriteLine("Introduce tu nombre");

            return Console.ReadLine();
        }
    }
}
