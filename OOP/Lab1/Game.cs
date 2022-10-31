using Lab;

namespace Lab1;

    public class Game
    {
		public UserAccount user;
		public UserAccount opponent;
		public readonly int rating;

		public GameStatus status;
		public int id;

		public Game(int Id, UserAccount owner, UserAccount opposer, int bet)
		{
			id = Id;
			user = owner;
			opponent = opposer;
			rating = bet;
			status = GameStatus.PENDING;
		}

		public void WinGame()
		{
			 status = GameStatus.WIN;
		}

		public void LoseGame()
		{
			status = GameStatus.LOSE;
		}

		public bool IsLose()
		{
			return GameStatus.LOSE == status;
		}

		public bool IsWin() 
		{
			return GameStatus.WIN == status;
		}
	}

