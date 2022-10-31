using System;
using System.Collections.Generic;
using Lab;

namespace Lab1;

public static class StatsPrinter
{
    public static void GameStatsToText(UserAccount user)
    {
        Console.WriteLine("\nGame Sessions for {0}", user.username);
        {
            foreach (var gameSession in user.GetGameStats())
            {
                Console.WriteLine("\nGame id: {0}", gameSession.id);
                Console.WriteLine("Rating: {0}", gameSession.rating);
                Console.WriteLine("User: {0}", gameSession.user);
                Console.WriteLine("Opponent: {0}", gameSession.opponent);
                Console.WriteLine("Status: {0}", gameSession.status);
            }
        }
    }

    public static void WriteUserStats(UserAccount account)
    {
        Console.WriteLine("\nStatistics by {0}", account.username);
        Console.WriteLine("Rating {0}", account.rating());
        Console.WriteLine("Total games {0}", account.totalGames());
        Console.WriteLine("Total win games {0} ", account.totalWinGames());
        Console.WriteLine("Total loose games {0} ", account.totalLoseGames());
    }
}