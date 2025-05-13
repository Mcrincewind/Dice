using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceConsoleApp.dices;
using DiceConsoleApp.Enums;

namespace DiceConsoleApp.Factory
{
	// mas ena factory apo zaria pou me to instace hrisimopoioume kathe fora ena kai hrisei twn enum
public class DiceFactory
	{
		private static DiceFactory instance;
		private DiceFactory() { }

		public static DiceFactory GetInstance()
		{
			if (instance == null)
			{
				instance = new DiceFactory();
			}
			return instance;
		}
		public AbstractDice CreateDice(DiceEnum diceenum) 
		{
			switch (diceenum) 
			{
				case DiceEnum.exagono:
				{
					d6 exaedro = new d6();
					return exaedro;
				}

				case DiceEnum.ohtagono:
				{
					oktahedron ohtagono=new oktahedron();
					return ohtagono;
				}

				case DiceEnum.eikosagono: 
				{
					D20 eikosaedro = new D20();
					return eikosaedro;
				}

				case DiceEnum.d4:
				{
					d4 d4 = new d4();
					return d4;
				}

				default:
				{
					throw new Exception("wrong input..");
				}
			}
			
		}
	}
}
