using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceConsoleApp.Utilities
{
	//klasi i opoia travaei apo tin data base olous tous pinakes (enan gia twra) kai mas afinei na tous diaheiristoume san lista gia eukolia
	internal class DataZaricache
	{
		private List<ZariTouDM> cache; 
		private static DataZaricache instance; 
		private DataZaricache() 
		{
			//travaei me using wste na klisei aytomata i sindesi me tin vasi molis teliwsei

			using (WildOctahedronEntities context = new WildOctahedronEntities()){
				cache = context.ZariTouDMs.ToList();
			}
		}
			// na paroume to instance dimiourgoume mia public static wste na ftiahtei 1
		public static DataZaricache Instance(){
			if(instance == null)
			{
				 instance = new DataZaricache();
			}
			return instance;
		}
		
			// class opou mas dinei tin eikanotita na epexeragstouem tin pliroforia pou travixame kai na hrisimopoiisoume to erotima se mia lista gia na mas ferei mia grami
		public ZariTouDM getResult(int numberOfRoll,int rollDice){
			return cache.FirstOrDefault(x => x.NumberOfRoll == numberOfRoll && x.RollDice == rollDice);
		}
	}
}
