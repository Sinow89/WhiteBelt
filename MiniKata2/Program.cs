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
                int experiencePointInt = Convert.ToInt32(experiencePoints);
                double goldCoinsDouble = Convert.ToDouble(goldCoins);
                
                Console.WriteLine(playerHealthDouble.GetType());
                Console.WriteLine(attackPowerInt.GetType());
                Console.WriteLine(experiencePointInt.GetType());
                Console.WriteLine(goldCoinsDouble.GetType());
                Console.WriteLine(goldCoinsDouble);
                
                int result;

                if (int.TryParse(playerName, out result))
                {
                    Console.WriteLine($"Conversion successful! Parsed integer value: {result}");
                }
                else
                {
                    Console.WriteLine("Conversion failed. Unable to parse the character name to an integer.");
                }
  
           
    }
}