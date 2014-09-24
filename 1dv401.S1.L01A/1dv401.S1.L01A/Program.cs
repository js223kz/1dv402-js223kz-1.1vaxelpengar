using System;

namespace dv401.S1.L01A
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			float totalSum;
			int totalSumWithoutDecimal;
			float sumLeftAfterRoundedAmount;
			int receivedSum;
			int changeToGiveBack;


			while (true) 
			{
				try 
				{
					Console.Write ("Ange totalbelopp: ");
					totalSum = float.Parse(Console.ReadLine());
					totalSumWithoutDecimal = (int)Math.Round(totalSum);

					if(totalSumWithoutDecimal < 1){
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("Totalbeloppet är för litet. Köpet kunde inte genomföras");
						return;

					}else{
						sumLeftAfterRoundedAmount = totalSum - totalSumWithoutDecimal;
						break;
					}
				} 
				catch 
				{
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine ("Totalbeloppet kan endast innehålla siffror och decimaler");
					Console.ResetColor ();
				}
			}
			while (true) 
			{
				try 
				{
					Console.Write ("Ange erhållet belopp: ");
					receivedSum = int.Parse (Console.ReadLine ());

					if(receivedSum < totalSumWithoutDecimal)
					{
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
						return;
					}
					else
					{
						sumLeftAfterRoundedAmount = totalSum - totalSumWithoutDecimal;
						break;
					}
				} 
				catch 
				{
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine ("Erhållet belopp måste vara ett heltal");
					Console.ResetColor ();
				}
			}

			changeToGiveBack = receivedSum - totalSumWithoutDecimal;

			Console.WriteLine ("\n\n" + "KVITTO"); 
			Console.WriteLine ("------------------------------------");
			Console.WriteLine ("{0,-16}{1,-2}{2,15:f2}{3,3}", "Totalt",":", totalSum, "kr");
			Console.WriteLine ("{0,-16}{1,-2}{2,15:f2}{3,3}", "Öresavrundning", ":", sumLeftAfterRoundedAmount, "kr");
			Console.WriteLine ("{0,-16}{1,-2}{2,15:f2}{3,3}", "Att betala", ":", totalSumWithoutDecimal, "kr");
			Console.WriteLine ("{0,-16}{1,-2}{2,15:f2}{3,3}", "Kontant", ":", receivedSum, "kr");
			Console.WriteLine ("{0,-16}{1,-2}{2,15:f2}{3,3}", "Tillbaka", ":", changeToGiveBack, "kr");
			Console.WriteLine ("------------------------------------");

			int numberOfFivehundreds = 500;
			int numberOfHundreds = 100;
			int numberOfFifties = 50;
			int numberOfTwenties = 20;
			int numberOfTens = 10;
			int numberOfFives = 5;
			int numberOfOnes = 1;
			int valueOfChangeToGiveBack = 0;
			int valueLeftToCalculate = changeToGiveBack;


			if (changeToGiveBack > 500 || changeToGiveBack == 500) 
			{
				valueOfChangeToGiveBack = changeToGiveBack / numberOfFivehundreds;
				valueLeftToCalculate = changeToGiveBack % numberOfFivehundreds;
				Console.WriteLine ("{0,-16}{1,-2}{2,-7}", "500-lappar", ":", valueOfChangeToGiveBack);
			}


			if (valueLeftToCalculate > 100 || valueLeftToCalculate == 100) 
			{
				valueOfChangeToGiveBack = valueLeftToCalculate / numberOfHundreds;
				valueLeftToCalculate = valueLeftToCalculate % numberOfHundreds;
				Console.WriteLine ("{0,-16}{1,-2}{2,-7}", "100-lappar", ":", valueOfChangeToGiveBack);
			} 


			if (valueLeftToCalculate > 50 || valueLeftToCalculate == 50)
			{
				valueOfChangeToGiveBack = valueLeftToCalculate / numberOfFifties;
				valueLeftToCalculate = valueLeftToCalculate % numberOfFifties;
				Console.WriteLine ("{0,-16}{1,-2}{2,-7}", "50-lappar", ":", valueOfChangeToGiveBack);
			}


			if (valueLeftToCalculate > 20 || valueLeftToCalculate == 20) 
			{
				valueOfChangeToGiveBack = valueLeftToCalculate / numberOfTwenties;
				valueLeftToCalculate = valueLeftToCalculate % numberOfTwenties;
				Console.WriteLine ("{0,-16}{1,-2}{2,-7}", "20-lappar", ":", valueOfChangeToGiveBack);
			}


			if (valueLeftToCalculate > 10 || valueLeftToCalculate == 10) 
			{
				valueOfChangeToGiveBack = valueLeftToCalculate / numberOfTens;
				valueLeftToCalculate = valueLeftToCalculate % numberOfTens;
				Console.WriteLine ("{0,-16}{1,-2}{2,-7}", "10-kronor", ":", valueOfChangeToGiveBack);
			}


			if (valueLeftToCalculate > 5 || valueLeftToCalculate == 5)
			{
				valueOfChangeToGiveBack = valueLeftToCalculate / numberOfFives;
				valueLeftToCalculate = valueLeftToCalculate % numberOfFives;
				Console.WriteLine ("{0,-16}{1,-2}{2,-7}", "5-kronor", ":", valueOfChangeToGiveBack);
			}


			if (valueLeftToCalculate > 1 || valueLeftToCalculate == 1) 
			{
				valueOfChangeToGiveBack = valueLeftToCalculate / numberOfOnes;
				valueLeftToCalculate = valueLeftToCalculate % numberOfOnes;
				Console.WriteLine ("{0,-16}{1,-2}{2,-7}", "1-kronor", ":", valueOfChangeToGiveBack);
			}
		}
	}
}
