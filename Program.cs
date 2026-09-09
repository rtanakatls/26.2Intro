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
            /*
            string name;
            int age;

            Console.WriteLine("Hola, introduce tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hey te llamas {name}");
            Console.WriteLine("Introduce tu edad:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Veo que tienes {age} años y el próximo cumplirás {age + 1}");
            */
            /*
            float a;
            float b;

            a = 10;
            b = 20;

            Console.WriteLine($"La suma es {a + b}");
            Console.WriteLine($"La resta es {a - b}");
            Console.WriteLine($"La multiplicación es {a * b}");

            Console.WriteLine($"La división es {a / b}");
            Console.WriteLine($"Él módulo es {a % b}");


            Console.WriteLine($"El área del rectángulo es {a * b} y el perímetro es {2 * (a + b)}");

            float days = 1000;

            Console.WriteLine($"{days} días en años es {days / 365} años");
            Console.WriteLine($"{days} días en semanas es {days / 7} semanas");

            float angle1 = 90;
            float angle2 = 60;

            Console.WriteLine($"El tercer ángulo vale {180 - (angle1 + angle2)}");
            */

            string job;

            job = "Alchemist";

            switch(job)
            {
                case "Paladin":
                    Console.WriteLine("Eres un paladín");
                    break;
                case "Warrior":
                    Console.WriteLine("Eres un guerrero");
                    break;
                case "Mage":
                    Console.WriteLine("Eres un mago");
                    break;
                default:
                    Console.WriteLine("No existe ese trabajo");
                    break;
            }
        }
    }
}
