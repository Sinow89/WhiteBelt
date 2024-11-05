namespace MiniKata2;

class Program
{
    static void Main(string[] args)
    {
                int playerHealth = 100;
                string playerName = "Arin";
                float attackPower = 15.5f;
                float experiencePoints = 100f;
                bool isParalyzed = true;
                string goldCoins = "150,33333333333";

                double playerHealthDouble = Convert.ToDouble(playerHealth);
                int attackPowerInt = Convert.ToInt32(attackPower);
                double experiencePointInt = Convert.ToDouble(experiencePoints);
                double goldCoinsDouble = Convert.ToDouble(goldCoins);
                
                
                Console.WriteLine(playerHealthDouble.GetType());
                Console.WriteLine(attackPowerInt.GetType());
                Console.WriteLine(experiencePointInt.GetType());
                Console.WriteLine(goldCoinsDouble.GetType());
                Console.WriteLine(goldCoinsDouble);
                // Console.WriteLine($"Character Name: {playerName}");
                // Console.WriteLine($"Health Points: {playerHealth}");
                // Console.WriteLine($"Attack Power: {attackPower}");
                // Console.WriteLine($"Is Paralyzed: {isParalyzed}");
                // Console.WriteLine($"Gold Coins: {goldCoins}");
    }
}