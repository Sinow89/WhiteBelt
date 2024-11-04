namespace Kata1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, brave adventurer! What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Greetings, {name}! Your journey begins now...");
        Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
        int ScaleNumber = int.Parse(Console.ReadLine());
        if (ScaleNumber > 7 )
        {
            Console.WriteLine("Wow, thats nice to hear!");
        }
        else
        {
            Console.WriteLine("Oh no, how can we make you more enthusiastic?");
        }
        
    }
}