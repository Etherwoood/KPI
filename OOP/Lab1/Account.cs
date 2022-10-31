using System.Collections.Generic;

namespace Lab1;
public class UserAccount
{
    public string username;
    public GameManager games;
    public UserAccount(string name)
    {
        username = name;
        games = new GameManager();
    }

    public int rating()
    {
        return games.CalculateRating();
    }

    public int totalGames()
    {
        return games.GetTotal();
    }

    public int totalWinGames()
    {
        return games.GetWins();
    }

    public int totalLoseGames()
    {
        return games.GetLoses();
    }
    
    public Game createGame(UserAccount opponent, int rating, int id)
    {
        return games.Create(this, opponent, rating, id);
    }

    public List<GameStats> GetGameStats()
    {
        return games.GetStats();
    }
}