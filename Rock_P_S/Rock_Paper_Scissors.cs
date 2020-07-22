//Take user input
//Generate a random choice
//Compare the choice
//Declare the winner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	public class Rock_Paper_Scissors
	{
		public static void Main(string[] args)
		{
			string Yourself;
			string Selection;
			int randomInteger;
			bool go_Again = true;
			int score_Of_The_Yourself = 0;
			int score_Of_Selection = 0;
			while (go_Again)
			{
				while (score_Of_The_Yourself < 3 && score_Of_Selection < 3)
				{
					Console.Write("Make a choice Rock or Paper Scissors?: ");
					Yourself = Console.ReadLine();
					Yourself = Yourself.ToUpper();
					Random randomNum = new Random();
					randomInteger = randomNum.Next(1, 3); //Choose a random number between 1 and 4
					switch (randomInteger)
					{
						case 1:
							Selection = "ROCK";
							Console.Write("Opponent Chose Rock\n");
							if (Yourself == "ROCK"&&Selection== "ROCK")
							{
								Console.WriteLine("DRAW");
							}
							else if (Yourself == "Paper"&&Selection== "ROCK")
							{
								Console.WriteLine(" Opponent WINS!!!!!!!");
								score_Of_The_Yourself++;
							}
							else if (Yourself == "Scissors"&&Selection== "ROCK")
							{
								Console.WriteLine("You Win!!!!!!!");
								score_Of_Selection++;
							}

							break;
						case 2:
							Selection = "PAPER";
							Console.Write("Opponent Chose Paper\n");
							if (Yourself == "PAPER"|| Yourself == "paper"&& Selection == "PAPER" || Selection == "Paper")
							{
								Console.WriteLine("DRAW BABY!!");
							}
							else if (Yourself == "ROCK"|| Yourself == "Rock"&& Selection == "PAPER" || Selection == "Paper")
							{
								Console.WriteLine("Opponent WINS!!!!!!!");
								score_Of_Selection++;
							}
							else if (Yourself == "SCISSORS"||Yourself == "Scissors"&& Selection == "PAPER" || Selection == "Paper")
							{
								Console.WriteLine("You Win!!!!!!!");
								score_Of_The_Yourself++;
							}

							break;
						case 3:
							Selection = "SCISSORS";
							Console.Write("Opponent Chose Scissors\n");
							if (Yourself == "Scissors"|| Yourself == "SCISSORS" && Selection == "SCISSORS" || Selection == "Scissors")
							{
								Console.WriteLine(" Draw!!");
							}
							else if (Yourself == "ROCK"||Yourself == "Rock"&& Selection == "SCISSORS" || Selection == "Scissors")
							{
								Console.WriteLine("You  WIN!!!!!!!");
								score_Of_The_Yourself++;
							}
							else if (Yourself == "Paper"||Yourself == "PAPER"&& Selection == "SCISSORS" || Selection == "Scissors")
							{
								Console.WriteLine("You Win");
								score_Of_Selection++;
							}

							break;
						default:
							Console.WriteLine("Invalid Entry");
							break;
					}
				}

				if (score_Of_The_Yourself == 3)
				{
					Console.WriteLine("YOU Won!");
				}
				else if (score_Of_Selection == 3)
				{
					Console.WriteLine("Opponent Won!");
				}
				else
				{
					Console.WriteLine("Draw ");
				}

				Console.WriteLine("Play Again?(y/n)");
				string loop_Cond = Console.ReadLine();
				if (loop_Cond == "Y" || loop_Cond == "y")
				{
					go_Again = true;
					Console.Clear();
				}
				else if (loop_Cond == "N" || loop_Cond == "n")
				{
					go_Again = false;
				}
				else
				{
				}
			}
		}
	}
}
