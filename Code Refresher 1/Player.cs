using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Refresher_1
{
	internal class Player
	{
		private string name;
		private int number;
		public string Name
		{
			get { return name; }
		}
		public Player(string name, int number)
		{
			this.name = name;
			this.number = number;
		}
		public override string ToString()
		{
			return $"Name: {name}| ID: {number}";
		}
	}
}
