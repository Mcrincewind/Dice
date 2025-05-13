using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceConsoleApp.dices;
using DiceConsoleApp.Enums;
using DiceConsoleApp.Factory;

namespace DiceConsoleApp.Utilities
{
	internal class StartApp
	{
			//class wste na kanoume swsta eisagwgh
		internal static void start() {
			Console.WriteLine("ti zari theleis na hrisimopoiiseis??");
			string userInput = Console.ReadLine();
			int value;
			// loopa epivevewshs
			while (!Int32.TryParse(userInput, out value) || !(IsValidDice(value)))
			{
				Console.WriteLine("dwse se parakalw arithmo zariou");
				userInput = Console.ReadLine();
			}

			// ftiahnoume to zari simfona me to factory kai tin klasi userdecision
			AbstractDice zari = DiceFactory.GetInstance().CreateDice((DiceEnum) value);
			userDecision(zari);


			Console.ReadLine();
		}
			//se autin tin klasei elenhoume poio enum na hrisimopoiisoume 
		private static bool IsValidDice(int value)
		{
			return System.Enum.IsDefined(typeof(DiceEnum), value);
		}

		//elenhos validation
		private static void userDecision(AbstractDice zari) {
			int index = 1;
			Console.WriteLine("theleis na rolareis?? 1 for continue or 0 to stop");
			int userInput = Int32.Parse(Console.ReadLine());
			while(userInput != 0) 
			{
				int result=zari.Roll();
				index++;
				// na doume partial classes gt edw trolaroume
				ZariTouDM row=DataZaricache.Instance().getResult(index, result);
				Console.WriteLine($"to buff einai:{row.Buff} kai to debuff einai {row.Debuff}");
				
				Console.WriteLine("theleis na rolareis?? 1 for continue or 0 to stop");
				userInput = Int32.Parse(Console.ReadLine());
			}
	}
	}
}
