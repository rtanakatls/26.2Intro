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
        private int playerLife;
        private int enemyLife;
        private int maxPlayerLife;
        public void Execute()
        {
            story = new string[11];
            story[0] = "Hola!";
            story[1] = "Bienvenido a esta aventura";
            story[2] = "¿Cómo te llamas?";
            story[3] = "Hola ";
            story[4] = "Hoy entrarás al bosque";
            story[5] = "Te encuentras un objeto";
            story[6] = "Lo recoges";
            story[7] = "Lo revisas bien";
            story[8] = "Era un enemigo";
            story[9] = "Combate!";
            story[10] = "Fin del juego";

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
                    case 9:
                        Console.WriteLine(story[i]);
                        RPG();
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

        private void RPG()
        {
            playerLife = 100;
            maxPlayerLife = 100;
            enemyLife = 100;
            while (playerLife > 0 && enemyLife > 0)
            {
                ShowStats();
                PlayerTurn();
                EnemyTurn();
            }
            CheckWinner();
        }

        private void CheckWinner()
        {
            if (playerLife <= 0)
            {
                Console.WriteLine("Has perdido");
            }
            else if (enemyLife <= 0)
            {
                Console.WriteLine("Has ganado");
            }
        }
        private void ShowStats()
        {
            Console.WriteLine($"Tu vida: {playerLife}");
            Console.WriteLine($"Vida del enemigo: {enemyLife}");
        }

        private void PlayerTurn()
        {
            bool actionTaken = false;
            while (!actionTaken)
            {
                Console.WriteLine("Ingresa el número de tu acción:");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Curarte");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Atacaste al enemigo");
                        enemyLife -= 10;
                        actionTaken = true;
                        break;
                    case "2":
                        Console.WriteLine("Te curaste");
                        playerLife += 20;
                        if (playerLife >= maxPlayerLife)
                        {
                            playerLife = maxPlayerLife;
                        }
                        actionTaken = true;
                        break;
                    default:
                        Console.WriteLine("Acción inválida");
                        break;
                }
            }
        }
        private void EnemyTurn()
        {
            Console.WriteLine("El enemigo te atacó");
            playerLife -= 10;
        }
    }
}
