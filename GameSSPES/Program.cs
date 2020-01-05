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
            int scoreUser = 0;
            int scoreComputer = 0;
            bool playAgain = true;

            while (playAgain)
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
                            Console.WriteLine("Computer hat Schere\n");
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Unentschieden, nochmal");
                                playAgain = true;
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            break;
                        case 2:
                            computerChoise = "Stein";
                            Console.WriteLine("Computer hat Schere\n");
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Du hast verloren:(");
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Unentschieden, nochmal");
                                playAgain = true;
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            break;
                        case 3:
                            computerChoise = "Papier";
                            Console.WriteLine("Computer hat Papier\n");
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Unentschieden, nochmal");
                                playAgain = true;
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            break;
                        case 4:
                            computerChoise = "Echse";
                            Console.WriteLine("Computer hat Echse\n");
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Du hast gewonnnen!!");
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Unentschieden, nochmal");
                                playAgain = true;
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            break;
                        case 5:
                            computerChoise = "Spock";
                            Console.WriteLine("Computer hat Spock\n");
                            if (userChoice == "Schere")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            else if (userChoice == "Stein")
                            {
                                Console.WriteLine("Du hast verloren :(");
                            }
                            else if (userChoice == "Papier")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            else if (userChoice == "Echse")
                            {
                                Console.WriteLine("Du hast gewonnen!!");
                            }
                            else if (userChoice == "Spock")
                            {
                                Console.WriteLine("Unentschieden, nochmal");
                                playAgain = true;
                            }
                            break;
                        default:
                            computerChoise = "Ungültig";
                            break;
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
