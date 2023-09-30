namespace Code_Refresher_1
{
	internal class Program
	{
		public static List<Player> playerslist = new List<Player> { new Player("James", 0), new Player("Jackson", 1), new Player("Jill", 2), new Player("Johnathan", 3), new Player("Jasmine", 4) };
		static void Main(string[] args)
		{
			//Automatically add a player to the list
			playerslist.Add(new Player("Terry", 5));
			//Print odd numbers in list
			for (int i = 0; i < playerslist.Count; i++)
			{
				if (i % 2 == 1)
				{
					Console.WriteLine(playerslist.ElementAt(i));
				}
			}
			Console.WriteLine("Enter a letter to search for");
			//Get player input
			string input = Console.ReadLine();
			//Print names that start with player input
			foreach (Player player in playerslist)
			{
				if (player.Name[0] == input[0])
				{
					Console.WriteLine(player);
				}
			}
			//Add player to the list
			Console.WriteLine("Enter a name");
			string name = Console.ReadLine();
			Console.WriteLine("Enter a number");
			
			int ID = Convert.ToInt32(Console.ReadLine());
			Player newplayer = new Player(name,ID);
			playerslist.Add(newplayer);

			foreach (Player player in playerslist)
			{
				Console.WriteLine(player);
			}

		}
	}
}