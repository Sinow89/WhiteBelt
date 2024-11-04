namespace MiniKata1;

class Program
{
    static void Main(string[] args)
    {
        int playerHealth = 100;
        string playerName = "Arin";
        float attackPower = 15.5f;
        bool isParalyzed = true;
        double goldCoins = 24.75;

        
        Console.WriteLine($"Character Name: {playerName}");
        Console.WriteLine($"Health Points: {playerHealth}");
        Console.WriteLine($"Attack Power: {attackPower}");
        Console.WriteLine($"Is Paralyzed: {isParalyzed}");
        Console.WriteLine($"Gold Coins: {goldCoins}");

    }
}