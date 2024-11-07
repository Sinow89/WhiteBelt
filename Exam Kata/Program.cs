namespace Exam_Kata;

class Program
{
    static void Main(string[] args)
    {
        int playerHealth = 80;
        int goblinHealth = 50;
        bool combat = true;
        var random = new Random();
        
        while (true)
        {
            
            Console.WriteLine("Choose an action:\n1. Attack\n2. Heal");
            string userInput = Console.ReadLine();
            int heroDamage = random.Next(1, 20);
            
            if (userInput == "1")
            {
                
                Console.WriteLine("Hero attacks the Goblin");
                Thread.Sleep(1000);
                Console.WriteLine($"Goblin takes {heroDamage} damage");
                goblinHealth -= heroDamage;
                Thread.Sleep(1000);
            }

            if (userInput == "2")
            {
                {
                    int heal = random.Next(1, 20);
                    Console.WriteLine("Hero heals himself");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{heal} points healed ");
                    playerHealth += heal;
                    Thread.Sleep(1000);
                }
            }
            
            if (goblinHealth <= 0)
            {
                Console.WriteLine($"Victory, you defeated the Goblin!");
                break;
            }
            
            int goblinDamage = random.Next(1, 20);
            playerHealth -= goblinDamage;
            Console.WriteLine($"Goblin attacks the Hero {goblinDamage}\n");
            Thread.Sleep(1000);

            if (playerHealth <= 0)
            {
                Console.WriteLine($"NO YOU DIED!\nGame over!");
                break;
            }
            
            Console.WriteLine($"Hero's health: {playerHealth}");
            Console.WriteLine($"Goblin health: {goblinHealth}\n");
            Thread.Sleep(1000);
            
        }
        
    }
}