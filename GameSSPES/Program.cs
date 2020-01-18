using System;

namespace GameSSPES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilkommen bei Schere, Stein, Papier, Echse, Spock\n");

            Console.WriteLine("Die Regeln: \nSchere schneidet Papier, \nPapier bedeckt Stein, \nStein zerquetscht Echse, \nEchse vergiftet Spock, \nSpock zertrümmert Schere, \nSchere köpft Echse, \nEchse frisst Papier, \nPapier widerlegt Spock, \nSpock verdampft Stein. \nUnd wie gewöhnlich – Stein schleift Schere. \n ");

            Console.Write("Bitte schreibe deinen Name: ");

            string userName = Console.ReadLine();
            Console.WriteLine();

            string computerChoise;
            int randomNum;
            bool playAgain = true;
            bool tryAgain = true;

            while (playAgain)
            {
                while (tryAgain)
                {
                    Console.WriteLine("{0}, bitte wähle zwischen: Schere, Stein, Papier, Echse, Spock", userName);
                    string userChoice = Console.ReadLine();
                    Console.WriteLine();

                    Random number = new Random();
                    randomNum = number.Next(1,6);

                    switch (randomNum)
                    {
                        case 1:
                            computerChoise = "Schere";
                            if (userChoice == "Schere")
                            {
                                tryAgain = Draw(computerChoise);
                            }
                            else if (userChoice == "Stein")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Papier")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Echse")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Spock")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else
                            {
                                FalseAnswer();
                            }

                            break;
                        case 2:
                            computerChoise = "Stein";
                            if (userChoice == "Schere")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Stein")
                            {
                                tryAgain = Draw(computerChoise);
                            }
                            else if (userChoice == "Papier")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Echse")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Spock")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else
                            {
                                FalseAnswer();
                            }
                            break;
                        case 3:
                            computerChoise = "Papier";
                            if (userChoice == "Schere")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Stein")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Papier")
                            {
                                tryAgain = Draw(computerChoise);
                            }
                            else if (userChoice == "Echse")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Spock")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else
                            {
                                FalseAnswer();
                            }
                            break;
                        case 4:
                            computerChoise = "Echse";
                            if (userChoice == "Schere")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Stein")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Papier")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Echse")
                            {
                                tryAgain = Draw(computerChoise);
                            }
                            else if (userChoice == "Spock")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else
                            {
                                FalseAnswer();
                            }
                            break;
                        case 5:
                            computerChoise = "Spock";
                            if (userChoice == "Schere")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Stein")
                            {
                                tryAgain = YouLost(computerChoise);
                            }
                            else if (userChoice == "Papier")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Echse")
                            {
                                tryAgain = YouWon(computerChoise);
                            }
                            else if (userChoice == "Spock")
                            {
                                tryAgain = Draw(computerChoise);
                            }
                            else
                            {
                                FalseAnswer();
                            }
                            break;
                        default:
                            computerChoise = "Ungültig";
                            break;
                    }

                }
                bool wrongAnswer = true;

                while (wrongAnswer)
                {

                    Console.WriteLine();
                    Console.WriteLine("Möchtest du wieder spielen? Ja oder Nein");
                    string answer = Console.ReadLine();
                    if (answer == "Ja")
                    {
                        Console.WriteLine();
                        playAgain = true;
                        wrongAnswer = false;
                        tryAgain = true;
                    }
                    else if (answer == "Nein")
                    {
                        playAgain = false;
                        wrongAnswer = false;
                    }
                    else
                    {
                        FalseAnswer();
                        wrongAnswer = true;
                    }
                }
            }
            Console.ReadLine();

        }

        private static bool YouWon(string ComputerChoise)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoise);
            Console.WriteLine("Du hast gewonnen!!");
            return false;
        }
        private static bool YouLost(string ComputerChoise)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoise);
            Console.WriteLine("Du hast verloren :(");
            return false;
        }
        private static bool Draw(string ComputerChoise)
        {
            Console.WriteLine("Computer wählt {0} \n", ComputerChoise);
            Console.WriteLine("Unentschieden, nochmal\n");
            return true;
        }
        private static void FalseAnswer()
        {
            Console.WriteLine("Ungültige Antwort\n");
        }
    }
}
