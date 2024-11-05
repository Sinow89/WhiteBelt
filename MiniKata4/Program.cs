namespace MiniKata4;

class Program
{
    static void Main()
    {
        int numberOfEnemies = 1;
        Console.WriteLine("Spawning enemies using a for loop:");
        for (int i = 0; i < 5; i++)
            
        {
            Console.WriteLine($"Enemy #{numberOfEnemies} spawned!");
            ++numberOfEnemies;
        }
        
        Console.Write("\n");
        Console.WriteLine("Spawning enemies using a while loop:");
        numberOfEnemies = 1;
        while (numberOfEnemies < 4)
        {
            Console.WriteLine($"Enemy #{numberOfEnemies} spawned!");
            ++numberOfEnemies;
        }

    }
}