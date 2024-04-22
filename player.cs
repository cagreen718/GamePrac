using System;

public class Player
{
    public int Lives { get; set; }
    public int Choices { get; set; }
    
    public Player(int lives, int choices)
    {
        Lives = lives;
        Choices = choices;
    }
    
    public int GetChoice()
    {
        Console.WriteLine("Enter your choice (1 = rock, 2 = paper, 3 = scissors):");
        
        while (true)
        {
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= Choices)
            {
                return choice;
            }
            
            Console.WriteLine("Invalid choice, please try again.");
        }
    }
}
