using System.Runtime.InteropServices;

namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize variables for a character’s attributes, using different data types:
        // Name: string
        // Level: int
        //     Health Points: float
        //     Experience Points: double
        //     Magic Ability: bool
        // Rank: char
        
        // Character Name: Lira
        // Level: 5
        // Health Points: 75.5
        // Experience Points: 1025.75
        // Has Magic Ability: True
        // Rank: A
        // Points needed to reach next level: 174.25

        string name = "Lira";
        int level = 5;
        float healthPoints = 75.5f;
        double experiencePoints = 1025.75;
        double pointToNextLevel = 1200;
        bool hasMagicAbility = true;
        char rank = 'A';
        
        Console.WriteLine($"Character name: {name}");
        Console.WriteLine($"Character level: {level}");
        Console.WriteLine($"Character health points: {healthPoints}");
        Console.WriteLine($"Character experience points: {experiencePoints}");
        Console.WriteLine($"Character has magic ability: {hasMagicAbility}");
        Console.WriteLine($"Character rank: {rank}");
        Console.WriteLine($"Points needed to reach next level {pointToNextLevel-experiencePoints}");

    }
}