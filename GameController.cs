namespace Lab1;
public class GameController
{
    public static void StartGame(UserAccount winner, UserAccount looser, int rating)
    { 
        winner.createGame(looser, rating).WinGame();
        looser.createGame(winner, rating).LoseGame();
    }
}
