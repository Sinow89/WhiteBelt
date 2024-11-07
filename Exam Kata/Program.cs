namespace Exam_Kata;

class Program
{
    static void Main(string[] args)
    {
        int playerHealth = 80;
        int goblinHealth = 50;
        bool combat = true;
        var random = new Random();
        

        while (combat)
        {
            Console.WriteLine("Choose an action:\n1. Attack\n2. Heal");
            string userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                int damage = random.Next(1, 20);
                Console.WriteLine("Hero attacks the Goblin");
                Console.WriteLine($"Goblin takes {damage} damage");
                goblinHealth -= damage;
            }

            if (userInput == "2")
            {
                {
                    int heal = random.Next(1, 20);
                    Console.WriteLine("Hero heals himself");
                    Console.WriteLine($"{heal} points healed ");
                    playerHealth += heal;
                }
            }
            Console.WriteLine($"Hero's health: {playerHealth}");
            Console.WriteLine($"Goblin health: {goblinHealth}");
        }
    }
}