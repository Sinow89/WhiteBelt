namespace Kata3;

class Program
{
    static void Main()
    {
        //
        // Requirements:
        //
        // Declare a playerLuck variable with a value between 1 and 10.
        //     Present the player with choices when they encounter a treasure chest:
        // Choice 1: Open the chest.
        //     If playerLuck > 7, display a success message for finding a rare gem.
        //     If playerLuck >= 5, display a message for finding some gold.
        //     If playerLuck < 5, display a message saying the chest was trapped.
        //     Choice 2: Ignore the chest, displaying a message saying the player continued on their journey.
        //     Choice 3: Leave the area, displaying a message saying the mystery was left unsolved.
        //     Display an error message if the player enters an invalid choice.
        //     Expected Outcome: The program should respond differently based on the player’s choice and playerLuck. Example output:
        //
        // You find a mysterious treasure chest! What will you do?
        // 1. Open the chest
        // 2. Ignore the chest
        // 3. Leave the area
        //     > 1
        // You try to open the chest...
        // Success! The chest contains a rare gem.
        
        
        int playerLuck = 7;
        
        Console.WriteLine("You find a mysterious treasure chest! What will you do?");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput == 1)
        {
            Console.WriteLine("Opens the chest");
            if (playerLuck >= 7)
            {
                Console.WriteLine("Success! The chest contains a rare gem.");
            }

            else if (playerLuck >= 5)
            {
                Console.WriteLine("Success! The chest contains a gem.");
            }

            else if (playerLuck < 5)
            {
                Console.WriteLine("Nope, nothing in the chest");
            }
        }
        else if (userInput == 2)
        {
            Console.WriteLine("You ignore the chest");
        }

        else if (userInput == 3)
        {
            Console.WriteLine("You leave the area");
        }
        else if(userInput >= 4);
        {
            Console.WriteLine("Invalid input");
        }
    }
}