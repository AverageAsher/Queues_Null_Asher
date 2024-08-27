using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a Game object with max players of 50 and current players of 49
        Game game = new Game(50, 49);

        // Create a Queue of Player objects
        Queue<Player> playerQueue = new Queue<Player>();

        // Create 4 Player objects with unique gamer tags
        Player player1 = new Player(100, "Player1");
        Player player2 = new Player(100, "Player2");
        Player player3 = new Player(100, "Player3");
        Player player4 = new Player(100, "Player4");

        // Call JoinGame on all 4 player objects
        player1.JoinGame(game, playerQueue);
        player2.JoinGame(game, playerQueue);
        player3.JoinGame(game, playerQueue);
        player4.JoinGame(game, playerQueue);

        // Print players in queue
        Console.WriteLine("Players in Queue:");
        foreach (Player player in playerQueue)
        {
            Console.WriteLine(player);
        }

        // Call KickPlayer on the game
        game.KickPlayer();

        // Call CheckQueue on the game
        game.CheckQueue(playerQueue);

        // Print players in queue after checking
        Console.WriteLine("\nPlayers in Queue:");
        foreach (Player player in playerQueue)
        {
            Console.WriteLine(player);
        }
    }
}