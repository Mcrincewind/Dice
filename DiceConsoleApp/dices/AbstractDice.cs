using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceConsoleApp.Interface;

namespace DiceConsoleApp.dices
{
	// i mama class pou ehei ta haraktiristika tou zariou kai ta dinei sta paidia
	public abstract class AbstractDice : IRollable
	{
		protected int sides { get; set; }
		private Random random = new Random();
		public virtual int Roll()
		{
			return random.Next(1, sides + 1);
		}

	}
}
