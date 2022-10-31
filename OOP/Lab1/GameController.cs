namespace Lab1;
public class GameController
{
    private static int lastId = 0;
    public static void StartGame(UserAccount winner, UserAccount looser, int rating)
    {
        int id = lastId++;
        winner.createGame(looser, rating, id).WinGame();
        looser.createGame(winner, rating, id).LoseGame();
    }
}
