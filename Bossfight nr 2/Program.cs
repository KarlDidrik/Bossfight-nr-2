
using Bossfight_nr_2;

GameCharacter hero = new GameCharacter(100, 20, 40);
GameCharacter boss = new GameCharacter(400, 20, 10);

Console.WriteLine("The battle begins!");

while (hero.Health > 0 && boss.Health > 0)
{
    boss.Strength = new Random().Next(0, 31);
    hero.Fight(boss);

    if (boss.Health <= 0)
    {
        Console.WriteLine("Hero is the winner!");
        break;
    }


boss.Fight(hero);

if (hero.Health <= 0)
{
    Console.WriteLine("Boss is the winner!");
    break;
}
}