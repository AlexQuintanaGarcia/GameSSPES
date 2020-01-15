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
            int randomInt;
            bool playAgain = true;
            bool tryAgain = true;

            while (playAgain)
            {
                while (tryAgain)
                {
                    Console.WriteLine("{0}, bitte wähle zwischen: Schere, Stein, Papier, Echse, Spock", userName);
                    string userChoice = Console.ReadLine();
                    Console.WriteLine();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1,6);

                    switch (randomInt)
                    {
                        case 1:
                            computerChoise = "Schere";
                            if (userChoice == "Schere")
                            {
                                Draw(computerChoise);
                                tryAgain = true;
                            }
                            else if (userChoice == "Stein")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
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
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {
                                Draw(computerChoise);
                                tryAgain = true;
                            }
                            else if (userChoice == "Papier")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
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
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                Draw(computerChoise);
                                tryAgain = true;
                            }
                            else if (userChoice == "Echse")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
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
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                Draw(computerChoise);
                                tryAgain = true;
                            }
                            else if (userChoice == "Spock")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
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
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {
                                YouLost(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                YouWon(computerChoise);
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                Draw(computerChoise);
                                tryAgain = true;
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

        private static void YouWon(string ComputerChoise)
        {
            Console.WriteLine("Computer wählt" + " " + ComputerChoise + " \n");
            Console.WriteLine("Du hast gewonnen!!");
        }
        private static void YouLost(string ComputerChoise)
        {
            Console.WriteLine("Computer wählt" + " " + ComputerChoise + "\n");
            Console.WriteLine("Du hast verloren :(");
        }
        private static void Draw(string ComputerChoise)
        {
            Console.WriteLine("Computer wählt" + " " + ComputerChoise + "\n");
            Console.WriteLine("Unentschieden, nochmal\n");
        }
        private static void FalseAnswer()
        {
            Console.WriteLine("Ungültige Antwort\n");
        }
    }
}
