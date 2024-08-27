// Define the Player class
public class Player
{
    // Automatic property for Health
    public int Health { get; set; }

    // Automatic property for GamerTag
    public string GamerTag { get; }

    // Constructor to initialize Health and GamerTag
    public Player(int health, string gamerTag)
    {
        Health = health;
        GamerTag = gamerTag;
    }

    // Method to join a game
    public void JoinGame(Game game, Queue<Player> queue)
    {
        // Check if the game is full
        if (game.CurrentPlayers == game.MaxPlayers)
        {
            // Add this player to the queue
            queue.Enqueue(this);
        }
        else
        {
            // Print message and increase CurrentPlayers
            System.Console.WriteLine("Joining Game");
            game.CurrentPlayers += 1;
        }
    }

    // Override ToString method to return GamerTag
    public override string ToString()
    {
        return GamerTag;
    }
}