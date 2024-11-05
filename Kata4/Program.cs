namespace Kata4;

class Program
{
    static void Main(string[] args)
    {
        {
            int numberOfEnemies = 1;
            for (int numberOfWaves = 1; numberOfWaves < 3; numberOfWaves++)
            {
                Console.WriteLine($"Wave {numberOfWaves} is starting!");
                for (int i = 0; i < 5; i++)
            
                {
                    Console.WriteLine($"Enemy #{numberOfEnemies} spawned!");
                    ++numberOfEnemies;
                }
                Console.WriteLine($"Wave {numberOfWaves} completed. Preparing for the next wave...");
                numberOfEnemies = 1;
                Console.WriteLine("");
                Thread.Sleep(1000);
            }
            Console.WriteLine("All waves completed! Victory is yours!");
        }
        

    }
}