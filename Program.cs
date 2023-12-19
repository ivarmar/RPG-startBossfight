namespace Bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreatePlayerCharacter characterCreator = new CreatePlayerCharacter();
            GameCharacter playerCharacter = characterCreator.RegisterPlayerCharacter();

            Console.WriteLine($"Character created: { playerCharacter.Name}");
            Console.WriteLine($"You chose {playerCharacter.PlayerClass} {playerCharacter.Description},");
            Console.WriteLine($"Health: {playerCharacter.Health}");
            Console.WriteLine($"Strength: {playerCharacter.Strength}");
            Console.WriteLine($"Stamina:{playerCharacter.Stamina}");

            IEnemy enemy1 = new Goblin("Makra 'The Beast Tamer'", 30, 20);
            IEnemy enemy2 = new Worgen("Gargal 'The Frenzied Wolf'", 10, 30);
            Combat combat = new Combat(true);
            combat.StartCombat(playerCharacter,enemy1, enemy2);
        }
    }
}
