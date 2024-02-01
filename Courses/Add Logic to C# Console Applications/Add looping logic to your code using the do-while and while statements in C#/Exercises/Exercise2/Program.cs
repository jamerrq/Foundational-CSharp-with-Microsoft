/*
- You must use either the do-while statement or the while statement as an outer game loop.
- The hero and the monster will start with 10 health points.
- All attacks will be a value between 1 and 10.
- The hero will attack first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.
*/

using System;

class Game
{
    static void Main()
    {
        Random random = new Random();
        int heroHealth = 10;
        int monsterHealth = 10;
        int heroAttack = 0;
        int monsterAttack = 0;

        Console.WriteLine("Hero vs Monster");
        Console.WriteLine("FIGHT!");
        Console.WriteLine();

        do
        {
            heroAttack = random.Next(1, 11);
            monsterHealth -= heroAttack;
            Console.WriteLine($"The hero attacks for {heroAttack} damage. The monster's health is now {monsterHealth}.");
            if (monsterHealth <= 0)
            {
                Console.WriteLine("The monster has been defeated!");
                break;
            }

            monsterAttack = random.Next(1, 11);
            heroHealth -= monsterAttack;
            Console.WriteLine($"The monster attacks for {monsterAttack} damage. The hero's health is now {heroHealth}.");
            if (heroHealth <= 0)
            {
                Console.WriteLine("The hero has been defeated!");
                break;
            }
        } while (heroHealth > 0 && monsterHealth > 0);
    }
}
