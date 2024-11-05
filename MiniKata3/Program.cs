namespace MiniKata3;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
        string input = Console.ReadLine();

        if (input.ToLower() == "yes")
        {
            Console.WriteLine("Attempting to attack");
            int playerLuck = 5;
            if (playerLuck >= 7) 
            { 
                Console.WriteLine("Success! You critical attacked the enemy.");
            }
            else if (playerLuck == 6)
            {
                Console.WriteLine("Barley attacked the enemy.");
            }
            else if(playerLuck <6 )
            {
                Console.WriteLine("No you missed");
            }
        }
    }
}