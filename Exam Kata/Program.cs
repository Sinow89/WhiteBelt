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
                Console.WriteLine($"Goblin takes {heroDamage} damage");
                goblinHealth -= heroDamage;
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
            
            if (goblinHealth <= 0)
            {
                Console.WriteLine($"Victory, you defeated the Goblin!");
                break;
            }
            
            int goblinDamage = random.Next(1, 20);
            playerHealth -= goblinDamage;
            Console.WriteLine($"Goblin attacks the Hero {goblinDamage}");

            if (playerHealth <= 0)
            {
                Console.WriteLine($"NO YOU DIED!\nGame over!");
                break;
            }
            
            Console.WriteLine($"Hero's health: {playerHealth}");
            Console.WriteLine($"Goblin health: {goblinHealth}");

            


        }
        
    }
}