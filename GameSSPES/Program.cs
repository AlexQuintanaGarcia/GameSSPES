using System;

namespace GameSSPES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilkommen bei Schere, Stein, Papier, Echse, Spock\n");

            Console.WriteLine("Die Regeln: \nSchere schneidet Papier, \nPapier bedeckt Stein, \nStein zerquetscht Echse, \nEchse vergiftet Spock, \nSpock zertrümmert Schere, \nSchere köpft Echse, \nEchse frisst Papier, \nPapier widerlegt Spock, \nSpock verdampft Stein. \nUnd wie gewöhnlich – Stein schleift Schere. \n ");

            Console.Write("Bitte schreibe deine Name: ");

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
                    randomInt = rnd.Next(1, 6);

                    switch (randomInt)
                    {
                        case 1:
                            computerChoise = "Schere";
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Computer hat Schere\n");
                                Console.WriteLine("Unentschieden, nochmal\n");
                                tryAgain = true;
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Computer hat Schere\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Computer hat Schere\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Computer hat Schere\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Computer hat Schere\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Antwort\n");
                            }

                            break;
                        case 2:
                            computerChoise = "Stein";
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Computer hat Stein\n");
                                Console.WriteLine("Du hast verloren:(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Computer hat Stein\n");
                                Console.WriteLine("Unentschieden, nochmal\n");
                                tryAgain = true;
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Computer hat Stein\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Computer hat Stein\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Computer hat Stein\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Antwort\n");
                            }
                            break;
                        case 3:
                            computerChoise = "Papier";
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Computer hat Papier\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Computer hat Papier\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Computer hat Papier\n");
                                Console.WriteLine("Unentschieden, nochmal\n");
                                tryAgain = true;
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Computer hat Papier\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Computer hat Papier\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Antwort\n");
                            }
                            break;
                        case 4:
                            computerChoise = "Echse";
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Computer hat Echse\n");
                                Console.WriteLine("Du hast gewonnnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {

                                Console.WriteLine("Computer hat Echse\n"); 
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Computer hat Echse\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Computer hat Echse\n");
                                Console.WriteLine("Unentschieden, nochmal\n");
                                tryAgain = true;
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Computer hat Echse\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Antwort\n");
                            }
                            break;
                        case 5:
                            computerChoise = "Spock";
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Computer hat Spock\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Computer hat Spock\n");
                                Console.WriteLine("Du hast verloren :(");
                                tryAgain = false;
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Computer hat Spock\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Computer hat Spock\n");
                                Console.WriteLine("Du hast gewonnen!!");
                                tryAgain = false;
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Computer hat Spock\n");
                                Console.WriteLine("Unentschieden, nochmal\n");
                                tryAgain = true;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Antwort\n");
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
                            Console.WriteLine("Ungültige Antwort");
                            wrongAnswer = true;
                        }
                    }
            }
            Console.ReadLine();

        }

    }
}
