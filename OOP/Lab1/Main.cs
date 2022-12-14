using System;
using Lab;

namespace Lab1;
public class Test
{
    private GameController gameController = new GameController();
    public static AccountManager accounts = new AccountManager();

    public static void Main(string[] args)
        {
            UserAccount user1 = accounts.Create("Stanislav");
            UserAccount user2 = accounts.Create("Egor");
            UserAccount user3 = accounts.Create("Gennadiy");
            GameController.StartGame(user1, user2, 5);
            GameController.StartGame(user2, user3, 3);
            GameController.StartGame(user1, user2, 2);



            StatsPrinter.WriteUserStats(user1);
            StatsPrinter.WriteUserStats(user2);
            
            StatsPrinter.GameStatsToText(user1);
            StatsPrinter.GameStatsToText(user2);
            StatsPrinter.GameStatsToText(user3);
        }
}