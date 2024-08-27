using System.Collections.Generic;

// Define the Game class
public class Game
{
    // Automatic getter for MaxPlayers
    public int MaxPlayers { get; }

    // Automatic getter and setter for CurrentPlayers
    public int CurrentPlayers { get; set; }

    // Constructor to initialize MaxPlayers and CurrentPlayers
    public Game(int maxPlayers, int currentPlayers)
    {
        MaxPlayers = maxPlayers;
        CurrentPlayers = currentPlayers;
    }

    // Method to decrement CurrentPlayers by 1
    public void KickPlayer()
    {
        CurrentPlayers -= 1;
    }

    // Method to check the queue and update CurrentPlayers
    public void CheckQueue(Queue<Player> queue)
    {
        // Check if CurrentPlayers is less than MaxPlayers
        if (CurrentPlayers < MaxPlayers)
        {
            // Check if the queue has players
            if (queue.Count > 0)
            {
                // Dequeue a player from the queue and increment CurrentPlayers
                queue.Dequeue();
                CurrentPlayers += 1;
            }
            else
            {
                // Print message if the queue is empty
                System.Console.WriteLine("No Players in the Queue!");
            }
        }
    }
}