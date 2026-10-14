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
            Menu menu = new Menu();
            menu.Execute();

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
            /*
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
            */
            /*
            int i = 1;
            int n = 50;


            while(i<=n)
            {
                Console.WriteLine(i);
                i++;
            }*/

            /*
            int result = 1;
            for (int i = 1; i <= 5; i++)
            {
                //result = result * i;
                result *= i;
            }
            Console.WriteLine(result);

            */
            /*
            int[] grades = new int[5];

            grades[0] = 10;
            grades[1] = 8;
            grades[2] = 15;
            grades[3] = 13;
            grades[4] = 20;
            int count=0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]>=12.5)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            */
            /*
            int[,] matrix = new int[3, 5];

            matrix[0, 0] = 10;
            matrix[0, 1] = 20;
            matrix[0, 2] = 30;
            matrix[0, 3] = 40;
            matrix[0, 4] = 50;
            matrix[1, 0] = 60;
            matrix[1, 1] = 70;
            matrix[1, 2] = 80;
            matrix[1, 3] = 90;
            matrix[1, 4] = -1;
            matrix[2, 0] = -2;
            matrix[2, 1] = -3;
            matrix[2, 2] = -4;
            matrix[2, 3] = -5;
            matrix[2, 4] = -6;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }*/
        }
    }
}
