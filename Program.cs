using System;

namespace RPGSimple
{
    class Program
    { 
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random rand = new Random();

            string choice;
            int enemyChoice;

            while (playerHp > 0 && enemyHp > 0)
            {
                //Player TURN
                Console.WriteLine();
                Console.WriteLine("-- Player turn --");
                Console.WriteLine("Player HP: {0}. Enemy HP: {1}.", playerHp, enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                Console.WriteLine();

                choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals {0} damage!", playerAttack);
                }
                else if (choice == "h")
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player attack enemy and deals {0} damage!", playerAttack);
                }
                else 
                { 
                    Console.WriteLine("Invalid choice!"); 
                    break; 
                }

                //Enemy TURN
                if (enemyHp > 0 && (choice == "a" || choice == "h"))
                {
                    Console.WriteLine();
                    Console.WriteLine("-- Enemy turn --");
                    Console.WriteLine("Player HP: {0}. Enemy HP: {1}.", playerHp, enemyHp);
                    Console.WriteLine();

                    enemyChoice = rand.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals {0} damage!", enemyAttack);
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores {0} health points!", healAmount);
                    }
                }

                Console.WriteLine();
                if (playerHp > 0) { Console.WriteLine("Congratulations, you have won the game!"); }
                else { Console.WriteLine("You lose!"); }
            }
        }
    }
}