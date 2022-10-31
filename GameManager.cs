using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Lab;
namespace Lab1;
public class GameManager
{
    IDictionary<int, Game> store = new Dictionary<int, Game>();
    int defaultRating = 10;
    public List<GameStats> GetStats()
    {
        List<GameStats> stats = new List<GameStats>();

        foreach (var games in store)
        {
            GameStats currentItem = new GameStats(games.Value);
            stats.Add(currentItem);
        }
        
        return stats;
    }
    public int CalculateRating()
    {

        foreach (var game in store)
        {
            if (game.Value.IsWin())
            {
                defaultRating += game.Value.rating;
            }

            if (game.Value.IsLose())
            {
                defaultRating -= game.Value.rating;
            }
        }

        return defaultRating;
    }
    
    
    public Game Create(UserAccount user, UserAccount opponent, int rating, int id)
    {
        Game game = new Game(id, user, opponent, rating);
        store.Add(id, game);
        return game;
    }

    public int GetTotal()
    {
        return store.Count;
    }

    public int GetWins()
    {
        int wins = 0;
        foreach (var game in store)
        {
            if (game.Value.IsWin())
            {
                wins++;
            }
        }

        return wins;
    }

    public int GetLoses()
    {
        int loses = 0;
        foreach (var game in store)
        {
            if (game.Value.IsLose())
            {
                loses++;
            }
        }

        return loses;
    }
}

