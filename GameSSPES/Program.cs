using System;
using System.Collections.Generic;

namespace GameSSPES
{
    class Program
    {
        private static string getActionCombination(Action action1, Action action2)
        {
            return action1.ToString() + action2.ToString();
        }

        static void Main(string[] args)
        {

            var rules = new Dictionary<string, Result> {
                { getActionCombination(Action.Schere, Action.Schere), Result.Draw },
                { getActionCombination(Action.Schere, Action.Stein), Result.Lost },
                { getActionCombination(Action.Schere, Action.Papier), Result.Won },
                { getActionCombination(Action.Schere, Action.Echse), Result.Won },
                { getActionCombination(Action.Schere, Action.Spock), Result.Lost },
                { getActionCombination(Action.Stein, Action.Schere), Result.Won },
                { getActionCombination(Action.Stein, Action.Stein), Result.Draw },
                { getActionCombination(Action.Stein, Action.Papier), Result.Lost },
                { getActionCombination(Action.Stein, Action.Echse), Result.Won },
                { getActionCombination(Action.Stein, Action.Spock), Result.Lost },
                { getActionCombination(Action.Papier, Action.Schere), Result.Lost },
                { getActionCombination(Action.Papier, Action.Stein), Result.Won },
                { getActionCombination(Action.Papier, Action.Papier), Result.Draw },
                { getActionCombination(Action.Papier, Action.Echse), Result.Lost },
                { getActionCombination(Action.Papier, Action.Spock), Result.Won },
                { getActionCombination(Action.Echse, Action.Schere), Result.Lost },
                { getActionCombination(Action.Echse, Action.Stein), Result.Lost },
                { getActionCombination(Action.Echse, Action.Papier), Result.Won },
                { getActionCombination(Action.Echse, Action.Echse), Result.Draw },
                { getActionCombination(Action.Echse, Action.Spock), Result.Won },
                { getActionCombination(Action.Spock, Action.Schere), Result.Won },
                { getActionCombination(Action.Spock, Action.Stein), Result.Won },
                { getActionCombination(Action.Spock, Action.Papier), Result.Lost },
                { getActionCombination(Action.Spock, Action.Echse), Result.Lost },
                { getActionCombination(Action.Spock, Action.Spock), Result.Draw },
            };

            Console.WriteLine("Wilkommen bei Schere, Stein, Papier, Echse, Spock\n");

            Console.WriteLine("Die Regeln: \nSchere schneidet Papier, \nPapier bedeckt Stein, \nStein zerquetscht Echse, \nEchse vergiftet Spock, \nSpock zertrümmert Schere, \nSchere köpft Echse, \nEchse frisst Papier, \nPapier widerlegt Spock, \nSpock verdampft Stein. \nUnd wie gewöhnlich – Stein schleift Schere. \n ");

            Console.Write("Bitte schreibe deinen Name: ");

            string userName = Console.ReadLine();
            Console.WriteLine();

            Action computerChoice;
            bool tryAgain = true;

                while (tryAgain)
            {
                int userInput = getUserChoice(userName);
                getComputerChoice(out computerChoice);

                tryAgain = getWinner(rules, computerChoice, userInput);
            }
        }

        private static bool getWinner(Dictionary<string, Result> rules, Action computerChoice, int userInput)
        {
            bool tryAgain;
            if (userInput != 0)
            {
                tryAgain = true;

                Action userChoice = (Action)userInput;

                Console.WriteLine("\nDu whälst " + userChoice);
                Console.WriteLine();


                switch (rules[getActionCombination(userChoice, computerChoice)])
                {
                    case Result.Draw:
                        Draw(computerChoice);
                        break;
                    case Result.Lost:
                        YouLost(computerChoice);
                        break;
                    case Result.Won:
                        YouWon(computerChoice);
                        break;
                    default:
                        throw new Exception("Das hätte nicht passieren sollen!");
                }
            }
            else
            {
                tryAgain = false;
            }

            return tryAgain;
        }

        private static void getComputerChoice(out Action computerChoice)
        {
            int randomNum;
            Random number = new Random();
            randomNum = number.Next(1, 6);

            computerChoice = (Action)randomNum;
        }

        private static int getUserChoice(string userName)
        {
            Console.WriteLine("{0}, bitte wähle zwischen:", userName);
            Console.WriteLine("1 Schere");
            Console.WriteLine("2 Stein");
            Console.WriteLine("3 Papier");
            Console.WriteLine("4 Echse");
            Console.WriteLine("5 Spock");
            Console.WriteLine("0 Spiel beenden");
            string userInput = Console.ReadKey(true).KeyChar.ToString();

            if (int.TryParse(userInput, out int result))
            {
                if (result >= 0 && result <= 5)
                {
                    return result;
                }
            }

            FalseAnswer();
            return getUserChoice(userName);
        }

        private static bool YouWon(Action ComputerChoise)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoise);
            Console.WriteLine("Du hast gewonnen!!\n");
            return false;
        }
        private static bool YouLost(Action ComputerChoise)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoise);
            Console.WriteLine("Du hast verloren :(\n");
            return false;
        }
        private static bool Draw(Action ComputerChoise)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoise);
            Console.WriteLine("Unentschieden, nochmal\n");
            return true;
        }
        private static void FalseAnswer()
        {
            Console.WriteLine("\nUngültige Option\nbitte whäle eine Nummer von 1 bis 5 oder 0, um das Spiel zu beenden\n");
        }
    }
}
