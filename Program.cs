using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro262
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Hola, introduce tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hey te llamas {name}");
            Console.WriteLine("Introduce tu edad:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Veo que tienes {age} años y el próximo cumplirás {age + 1}");


        }
    }
}
