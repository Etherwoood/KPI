using System;
using Lab;

namespace Lab1;

public class GameStats
{
    public readonly int id;
    public readonly int rating;
    public readonly string user;
    public readonly string opponent;
    public GameStatus status;

    public GameStats(Game game)
    {
        id = game.id ; 
        user = game.user.username;
        opponent = game.opponent.username;
        status = game.status;
        rating = game.rating;
        if (status == GameStatus.LOSE)
        {
            rating = -1*game.rating;
        }
    }
}